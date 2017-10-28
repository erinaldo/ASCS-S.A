Imports BackEnd
Public Class GenerarCompras
    Dim compraDao As New CompraDAO
    Dim producto As New Producto
    Dim listado As New DataTable

    Private Sub GenerarCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'StockcapiataDataSet.cargacompras' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'StockcapiataDataSet.cargacompras' Puede moverla o quitarla según sea necesario.
        'Me.CargacomprasTableAdapter.Fill(Me.StockcapiataDataSet.cargacompras)
        Me.SuspendLayout()
        centrarElementos()
        generarCompraElementos()
        Me.ResumeLayout()
    End Sub

    Private Sub buscarCompraFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCompra.Click

        'carga elementos generar compra

        Dim inicio = datepInicio.Value.Date
        Dim fin = datepFin.Value.Date
        Dim listadoCompras = compraDao.carga(inicio, fin)
        dgvCompras.DataSource = listadoCompras.Tables("tabla")

    End Sub

    Private Sub generarCompraElementos()
        dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim prov = compraDao.CargaProv()
        cbProveedores.DataSource = prov.Tables("tabla")
        cbProveedores.DisplayMember = "Descripción"
        cbProveedores.ValueMember = "Código"

        Dim depositos = compraDao.cargaDeposito()
        cbDeposito.DataSource = depositos.Tables("tabla")
        cbDeposito.DisplayMember = "Descripción"
        cbDeposito.ValueMember = "Código"


        'gbTipoPago.Controls.OfType(Of RadioButton).FirstOrDefault(rbContado)
        rbContado.Checked = True
        ' Dim interes = compraDato.cargaInteres()
        Dim impuesto = compraDao.cargaImpuesto()
        cbImpuesto.DataSource = impuesto.Tables("tabla")
        cbImpuesto.DisplayMember = "Impuesto"
        cbImpuesto.ValueMember = "Código"

        dgvProductos.DataSource = New stockcapiataDataSet.productosCompraDataTable
        'dgvProductos.Columns("Impuesto").Visible = False
        dgvProductos.Columns("DepoCod").Visible = False
        cbBuscarCompra.DataSource = VariablesUtiles.busquedaCompras

        gbBusquedaCompra.BackColor = Color.FromArgb(80, Color.Black)

        pnlComentario.BackColor = Color.FromArgb(80, Color.Black)
        pnlTotales.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperadores.BackColor = Color.FromArgb(80, Color.Black)
        pnlDatosCompra.BackColor = Color.FromArgb(80, Color.Black)
        pnlDatosProducto.BackColor = Color.FromArgb(80, Color.Black)
    End Sub


    Private Sub btnBuscarProd_Click(sender As Object, e As EventArgs) Handles btnBuscarProd.Click
        Dim cod = txtCodProd.Text
        Try
            producto = compraDao.BuscarProd(cod)
            If producto.codigo = "" Then
                MsgBox("Producto no encontrado. Re inserte código", MsgBoxStyle.Critical, "Notificación")
                txtCodProd.Focus()
                Exit Sub
            End If
            txtCodProd.Text = producto.codigo
            txtDescripcionProd.Text = producto.descripcion
            txtPrecioProd.Text = producto.venta
            txtPrecioProd.Enabled = False
            txtDescripcionProd.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Function calcularIva(ByVal total As Double, ByVal cod As String) As Double
        Dim resultado As Double
        If cod = "10%" Then
            resultado = CDbl((total * 10) / 100)
        ElseIf cod = "5%" Then
            resultado = CDbl((total * 5) / 100)
        Else
            resultado = 0
        End If
        Return resultado
    End Function

    Private Sub btnInsertarProd_Click(sender As Object, e As EventArgs) Handles btnInsertarProd.Click
        If validarProducto() Then
            Dim row2 As DataTable = dgvProductos.DataSource
            Dim row As DataRow = row2.NewRow
            row("Código") = txtCodProd.Text
            row("Descripción") = txtDescripcionProd.Text
            row("Cantidad") = txtCantidad.Text
            row("Precio") = txtPrecioProd.Text
            row("Depósito") = cbDeposito.SelectedItem.item("Descripción")
            row("DepoCod") = cbDeposito.SelectedItem.item("Código")
            Dim total = CDbl(txtPrecioProd.Text) * CDbl(txtCantidad.Text)
            Dim iva = calcularIva(total, cbImpuesto.SelectedItem("Impuesto"))
            row("Impuesto") = cbImpuesto.SelectedItem("Impuesto")
            row("Iva") = iva
            row("Sub-Total") = total
            row("Total") = total + iva

            If txtSub.Text = "" Then
                txtSub.Text = total
            Else
                txtSub.Text = CDbl(txtSub.Text) + total
            End If
            If txtTotalCompra.Text <> "" Then
                txtTotalCompra.Text = CDbl(txtTotalCompra.Text) + total + iva
            Else
                txtTotalCompra.Text = total + iva
            End If

            If txtIva.Text <> "" Then
                txtIva.Text = CDbl(txtIva.Text) + iva
            Else
                txtIva.Text = iva
            End If

            'Dim agregar As New DataGridViewRow
            'dgvProductos.Rows.Add(txtCodProd)
            'Dim dt As DataTable = DirectCast(dgvProductos.DataSource, DataTable)
            'dt.Rows.Add(row)
            row2.Rows.Add(row)
            dgvProductos.DataSource = row2

        End If
    End Sub



    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub centrarElementos()
        txtTituloBusqueda.Left = (Me.ClientSize.Width / 2) - (txtTituloBusqueda.Width / 2)
        gbBusquedaCompra.Left = (Me.ClientSize.Width / 2) - (gbBusquedaCompra.Width / 2)
        dgvCompras.Left = (Me.ClientSize.Width / 2) - (dgvCompras.Width / 2)
        pnlDatosCompra.Left = (Me.ClientSize.Width / 2) - (pnlDatosCompra.Width / 2)
        pnlDatosProducto.Left = (Me.ClientSize.Width / 2) - (pnlDatosProducto.Width / 2)
        pnlComentario.Left = pnlDatosCompra.Left
        dgvProductos.Left = pnlDatosCompra.Left
        pnlOperadores.Left = pnlDatosCompra.Right - pnlOperadores.Width
        pnlTotales.Left = pnlDatosCompra.Right - pnlTotales.Width
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub btnEliminarProd_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click
        If dgvProductos.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvProductos.SelectedRows
                Dim restarSub = row.Cells("Sub-Total").Value
                Dim restarIva = row.Cells("Iva").Value
                Dim restarTotal = row.Cells("Total").Value
                txtTotalCompra.Text = CDbl(txtTotalCompra.Text) - CDbl(restarTotal)
                txtIva.Text = CDbl(txtIva.Text) - CDbl(restarIva)
                txtSub.Text = CDbl(txtSub.Text) - CDbl(restarSub)
                dgvProductos.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub guardarCompra_Click(sender As Object, e As EventArgs) Handles btnGuardarCompra.Click
        If validarCompra() Then
            Try
                Dim compra As New Compra
                Dim compraDao As New CompraDAO
                compra.nroFactura = txtFacturaNro.Text
                compra.fechaFactura = dateFactura.Value
                compra.fechaInsFactura = Date.Today
                compra.comentario = txtComentario.Text
                compra.proveedor = cbProveedores.SelectedItem.item("Código")
                If rbContado.Checked = True Then
                    compra.tipo = "Contado"
                    compra.saldo = CDbl(0)
                Else
                    compra.tipo = "Crédito"
                    compra.saldo = CDbl(txtTotalCompra.Text)
                End If


                Dim productos As New Collection
                'For Each row As DataGridViewRow In dgvProductos.Rows
                '    Dim codigo = dgvProductos.Item(0, row.Index).Value
                '    Dim cantidad = dgvProductos.Item(3, row.Index).Value

                '    productos.Add(cantidad, codigo)
                'Next

                compraDao.guardarCompra(compra, dgvProductos.Rows)
                MsgBox("!Compra registrada con éxito!", MsgBoxStyle.Information, "Notificación")
            Catch ex As Exception
                Throw New DAOException(ex.ToString)
            End Try
        End If
    End Sub
    ' Validaciones
    Private Function validarCompra() As Boolean
        If validarProducto() Then
            If txtFacturaNro.Text = "" Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Function validarProducto() As Boolean
        If txtCodProd.Text = "" Then
            Return False
        ElseIf txtCodProd.Text = "" Then
            Return False
        End If
        Return True

    End Function
End Class