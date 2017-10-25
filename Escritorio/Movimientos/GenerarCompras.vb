Imports BackEnd
Public Class GenerarCompras
    Dim compraDao As New CompraDAO
    Dim producto As New Producto
    Dim listado As New DataTable

    Private Sub GenerarCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'StockcapiataDataSet.cargacompras' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'StockcapiataDataSet.cargacompras' Puede moverla o quitarla según sea necesario.
        'Me.CargacomprasTableAdapter.Fill(Me.StockcapiataDataSet.cargacompras)
        centrarElementos()
        generarCompraElementos()

    End Sub

    Private Sub buscarCompraFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCompra.Click

        'carga elementos generar compra

        Dim inicio = datepInicio.Value.Date
        Dim fin = datepFin.Value.Date
        Dim listadoCompras = compraDao.carga(inicio, fin)


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
        txtImpuesto.Text = "10%"

        dgvProductos.DataSource = New stockcapiataDataSet.productosCompraDataTable

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

    Private Sub btnInsertarProd_Click(sender As Object, e As EventArgs) Handles btnInsertarProd.Click
        If validarProducto() Then
            Dim row2 As DataTable = dgvProductos.DataSource
            Dim row As DataRow = row2.NewRow
            row("Código") = txtCodProd.Text
            row("Descripción") = txtDescripcionProd.Text
            row("Cantidad") = txtCantidad.Text
            row("Precio") = txtPrecioProd.Text
            row("Depósito") = cbDeposito.SelectedItem.item("Descripción")
            Dim total = CDbl(txtPrecioProd.Text) * CDbl(txtCantidad.Text)
            row("Total") = total
            If txtTotalCompra.Text <> "" Then
                txtTotalCompra.Text = CDbl(txtTotalCompra.Text) + total
            Else
                txtTotalCompra.Text = total
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
        gbDatosCompra.Left = (Me.ClientSize.Width / 2) - (gbDatosCompra.Width / 2)
        gbDatosProducto.Left = (Me.ClientSize.Width / 2) - (gbDatosProducto.Width / 2)
        gbComentario.Left = gbDatosCompra.Left
        dgvProductos.Left = gbDatosCompra.Left
        gbOperadores.Left = gbDatosCompra.Right - gbOperadores.Width
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub btnEliminarProd_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click
        If dgvProductos.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvProductos.SelectedRows
                Dim restar = row.Cells("Total").Value
                txtTotalCompra.Text = CDbl(txtTotalCompra.Text) - CDbl(restar)
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
                Else
                    compra.tipo = "Crédito"
                End If

                compra.saldo = CDbl(txtTotalCompra.Text)
                compraDao.guardarCompra(compra)
                MsgBox("!Compra registrada con éxito!", MsgBoxStyle.Information, "Notificación")
            Catch ex As Exception

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