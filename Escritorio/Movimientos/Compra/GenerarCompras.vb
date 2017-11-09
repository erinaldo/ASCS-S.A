Imports System.Drawing.Drawing2D
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

    Private Sub centrarElementos()
        txtTituloBusqueda.Left = (Me.ClientSize.Width / 2) - (txtTituloBusqueda.Width / 2)
        pnlListado.Left = (Me.ClientSize.Width / 2) - (pnlListado.Width / 2)
        dgvCompras.Left = (Me.ClientSize.Width / 2) - (dgvCompras.Width / 2)
        pnlDatosCompra.Left = (Me.ClientSize.Width / 2) - (pnlDatosCompra.Width / 2)
        pnlDatosProducto.Left = (Me.ClientSize.Width / 2) - (pnlDatosProducto.Width / 2)
        pnlComentario.Left = pnlDatosCompra.Left
        dgvProductos.Left = pnlDatosCompra.Left
        pnlOperadores.Left = pnlComentario.Left
        pnlTotales.Left = pnlDatosCompra.Right - pnlTotales.Width

        ' Anular Compra
        pnlAnular.Left = (Me.ClientSize.Width / 2) - (pnlAnular.Width / 2)
        dgvBusquedaResult.Left = (Me.ClientSize.Width / 2) - (dgvBusquedaResult.Width / 2)
        dgvComprasAnular.Left = pnlAnular.Left
        txtTituloAnular.Left = (Me.ClientSize.Width / 2) - (txtTituloAnular.Width / 2)
        pnlOperandosAnular.Left = pnlAnular.Right - pnlOperandosAnular.Width
        pnlOperandosAnular.Visible = False
        pnlSeleccionProd.Left = dgvBusquedaResult.Left

        '' PAGO COMPRA
        pnlPago.Left = (Me.ClientSize.Width / 2) - (pnlPago.Width / 2)
        cbProveedor4.Location = txtNroFactPago.Location
        lblTituloP.Left = (Me.ClientSize.Width / 2) - (lblTituloP.Width / 2)
        dgvComprasP.Left = pnlPago.Left
    End Sub
    Private Sub generarCompraElementos()
        dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvComprasAnular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvComprasAnular.Visible = False
        dgvComprasAnular.EditMode = False

        Dim prov = compraDao.CargaProv()

        cbProveedor2.DataSource = prov.Tables("tabla").Copy
        cbProveedor2.DisplayMember = "Descripción"
        cbProveedor2.ValueMember = "Código"

        cbEstadoCompra.DataSource = VariablesUtiles.estado

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

        pnlListado.BackColor = Color.FromArgb(80, Color.Black)

        pnlComentario.BackColor = Color.FromArgb(80, Color.Black)
        pnlTotales.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperadores.BackColor = Color.FromArgb(80, Color.Black)
        pnlDatosCompra.BackColor = Color.FromArgb(80, Color.Black)
        pnlDatosProducto.BackColor = Color.FromArgb(80, Color.Black)
        pnlAnular.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperandosAnular.BackColor = Color.FromArgb(80, Color.Black)
        pnlSeleccionProd.BackColor = Color.FromArgb(80, Color.Black)

        cbProveedor3.DataSource = prov.Tables("tabla").Copy
        cbProveedor3.DisplayMember = "Descripción"
        cbProveedor3.ValueMember = "Código"
        cbAnularFiltro.DataSource = VariablesUtiles.AnularCompras
        tpListado.BackgroundImage = My.Resources.Panther1
        tpListado.BackgroundImageLayout = ImageLayout.Center
        tpNuevaCompra.BackgroundImage = My.Resources.Panther1
        tpNuevaCompra.BackgroundImageLayout = ImageLayout.Center



        tpAnularCompra.BackgroundImage = My.Resources.Panther1
        tpAnularCompra.BackgroundImageLayout = ImageLayout.Center
        tpPagos.BackgroundImage = My.Resources.Panther1
        tpPagos.BackgroundImageLayout = ImageLayout.Center

        ' LISTADO BUSQUEDA

        cbProveedor1.DataSource = prov.Tables("tabla")
        cbProveedor1.DisplayMember = "Descripción"
        cbProveedor1.ValueMember = "Código"

        ' PAGO COMPRA

        cbFiltroP.DataSource = VariablesUtiles.busquedaComprasPago
        pnlPago.BackColor = Color.FromArgb(80, Color.Black)
        cbProveedor4.DataSource = prov.Tables("tabla").Copy
        cbProveedor4.DisplayMember = "Descripción"
        cbProveedor4.ValueMember = "Código"
        dgvComprasP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    'Private Function CreateBackgroundGradient() As Bitmap
    '    Dim Img As New Bitmap(Me.Width, Me.Height)

    '    Dim Hght As Integer = Me.Height

    '    Using e As Graphics = Graphics.FromImage(Img)
    '        Using b As New LinearGradientBrush(New Rectangle(0I, 0I, Me.Width, Me.Height), Color.RoyalBlue, Color.CornflowerBlue, Drawing2D.LinearGradientMode.ForwardDiagonal)
    '            e.FillRectangle(b, New Rectangle(0I, 0I, Me.Width, Me.Height))
    '        End Using

    '    End Using


    '    Return Img
    'End Function

    ' --------------------------------------------- BUSQUEDA / LISTADO DE COMPRAS - METODOS ---------------------------------------------
    Private Sub buscarCompraFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCompra.Click
        Try
            Dim listadoCompras As New DataSet
            If cbBuscarCompra.SelectedIndex = 0 Then
                Dim filtro = txtNroFacturaListado.Text

                listadoCompras = compraDao.buscarCompra(filtro, 0)
            ElseIf cbBuscarCompra.SelectedIndex = 1 Then
                Dim inicio = datepInicio.Value.Date
                Dim fin = datepFin.Value.Date
                listadoCompras = compraDao.carga(inicio, fin, 0)
            ElseIf cbBuscarCompra.SelectedIndex = 2 Then
                Dim filtro = cbProveedor2.SelectedItem.item("Descripción")

                listadoCompras = compraDao.buscarCompra(filtro, 2)
            End If

            btnDetalle.Visible = True
            dgvCompras.DataSource = listadoCompras.Tables("tabla")
            dgvCompras.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'carga elementos generar compra

    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        If dgvCompras.SelectedRows.Count > 0 Then
            Dim row = dgvCompras.CurrentRow.Index
            Dim codigo = dgvCompras.Item(0, row).Value
            Dim detalleForm As New DetalleCompra(codigo)
            detalleForm.ShowDialog()

            detalleForm.Dispose()
        Else
            MsgBox("Niguna compra selecciona!", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub

    Private Sub cbBuscarCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBuscarCompra.SelectedIndexChanged
        btnDetalle.Visible = False
        Me.SuspendLayout()
        If cbBuscarCompra.SelectedItem = "Nro. Factura" Then
            pnlRangoFecha.Visible = False
            txtNroFacturaListado.Visible = True
            cbProveedor1.Visible = False
            txtNroFacturaListado.Text = ""
            txtNroFacturaListado.Focus()
            lblBusqTxt.Text = "Inserte Nro. Factura"
            lblBusqTxt.Visible = True
            cbEstadoCompra.Visible = False
        ElseIf cbBuscarCompra.SelectedItem = "Rango de Fecha" Then
            pnlRangoFecha.Visible = True
            txtNroFacturaListado.Visible = False
            cbProveedor1.Visible = False
            cbEstadoCompra.Visible = False
            lblBusqTxt.Visible = False
        ElseIf cbBuscarCompra.SelectedItem = "Proveedor" Then
            pnlRangoFecha.Visible = False
            txtNroFacturaListado.Visible = False
            cbProveedor1.Visible = True
            lblBusqTxt.Text = "Seleccione el proveedor"
            lblBusqTxt.Visible = True
            cbEstadoCompra.Visible = False
            'txtNroFacturaListado.Focus()
            'ElseIf cbBuscarCompra.SelectedItem = "Proveedor" Then
            '    dpAnularCompra.Visible = False
            '    cbProveedoresAnular.Location = txtNrofacturaAnul.Location
            '    cbProveedoresAnular.Visible = True
            '    txtNrofacturaAnul.Visible = False
        Else
            lblBusqTxt.Text = "Seleccione un estado"
            pnlRangoFecha.Visible = False
            txtNroFacturaListado.Visible = False
            cbProveedor1.Visible = False
            cbEstadoCompra.Visible = True
            cbEstadoCompra.Location = txtNroFacturaListado.Location
        End If
        Me.ResumeLayout()
    End Sub


    ' --------------------------------------------- GENERAR COMPRA - METODOS ---------------------------------------------
    Private Sub btnBuscarProd_Click(sender As Object, e As EventArgs) Handles btnBuscarProd.Click
        Dim cod = txtFiltroBusquedaNC.Text
        Try
            Dim producto = compraDao.BuscarProducts(cod)
            'If producto.codigo = "" Then
            '    MsgBox("Producto no encontrado. Re inserte código", MsgBoxStyle.Critical, "Notificación")
            '    txtCodProd.Focus()
            '    Exit Sub
            'End If
            'txtCodProd.Text = Producto.codigo
            Me.SuspendLayout()
            dgvBusquedaResult.DataSource = producto.Tables("tabla")
            dgvBusquedaResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvBusquedaResult.Visible = True
            dgvProductos.Visible = False
            pnlComentario.Visible = False
            pnlOperadores.Visible = False
            pnlSeleccionProd.Visible = True
            'pnlBusqueda.Visible = True
            'pnlGuardarMov.Visible = False
            'btnSeleccionarDeBusqueda.Visible = True
            'lblTituloDetalle.Text = "SELECCIONE PRODUCTO"
            Me.ResumeLayout()
            'txtDescripcionProd.Text = producto.descripcion
            'txtDescripcionProd.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        'Try
        '    producto = compraDao.BuscarProd(cod)
        '    If producto.codigo = "" Then
        '        MsgBox("Producto no encontrado. Re inserte código", MsgBoxStyle.Critical, "Notificación")
        '        txtCodProd.Focus()
        '        Exit Sub
        '    End If
        '    txtCodProd.Text = producto.codigo
        '    txtDescripcionProd.Text = producto.descripcion
        '    txtPrecioProd.Text = producto.venta
        '    txtPrecioProd.Enabled = True
        '    txtDescripcionProd.Enabled = False
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try
    End Sub

    Private Sub btnSeleccionarPr_Click(sender As Object, e As EventArgs) Handles btnSeleccionarPr.Click
        Me.SuspendLayout()
        dgvBusquedaResult.Visible = False
        dgvProductos.Visible = True
        pnlComentario.Visible = True
        pnlOperadores.Visible = True
        pnlSeleccionProd.Visible = False
        Dim row = dgvBusquedaResult.CurrentRow.Index
        Dim codigo = dgvBusquedaResult.Item(0, row).Value
        txtCodProd.Text = dgvBusquedaResult.Item(0, row).Value
        txtDescripcionProd.Text = dgvBusquedaResult.Item(1, row).Value


        Me.ResumeLayout()
    End Sub

    Private Sub rbCredito_CheckedChanged(sender As Object, e As EventArgs) Handles rbCredito.CheckedChanged
        If rbCredito.Checked Then
            gbTipoPago.Height = gbTipoPago.Height * 2
            txtEntregaInicial.Text = 0
        Else
            gbTipoPago.Height = gbTipoPago.Height / 2
        End If
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
        Else
            MsgBox("Complete los campos del producto!", MsgBoxStyle.Critical, "Notificación")
        End If
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
                compra.proveedor = cbProveedor2.SelectedItem.item("Código")
                If rbContado.Checked = True Then
                    compra.tipo = "Contado"
                    compra.estado = "Paga"
                    compra.saldo = CDbl(0)
                    compra.fechaPagado = Date.Today
                Else
                    compra.tipo = "Crédito"
                    compra.estado = "Acti"
                    compra.saldo = CDbl(txtTotalCompra.Text) - CDbl(txtEntregaInicial.Text)
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
                MsgBox(ex.Message)
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
        ElseIf txtCantidad.Text = "" Then
            Return False
        ElseIf txtPrecioProd.Text = "" Then
            Return False
        End If
        Return True

    End Function



    ' ---------------------------------------------- ANULAR COMPRA Métodos -----------------------

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAnularFiltro.SelectedIndexChanged
        If cbAnularFiltro.SelectedIndex = 0 Then
            dpAnularCompraIni.Visible = False
            cbProveedor3.Visible = False
            txtNrofacturaAnul.Visible = True
            txtFiltro.Text = "Nro. Factura"
            txtFiltro.Visible = True
            pnlAnular.Height = 76
            pnlAnular.Width = 821
            pnlOperandosAnular.Top = pnlAnular.Bottom + 5
            dgvComprasAnular.Top = pnlOperandosAnular.Bottom + 5
            txtNrofacturaAnul.Focus()

        ElseIf cbAnularFiltro.Selectedindex = 1 Then
            txtFiltro.Text = "Desde"
            txtFiltro.Visible = True

            dpAnularCompraIni.Visible = True
            dpAnularCompraIni.Location = txtNrofacturaAnul.Location
            pnlAnular.Height = 138
            pnlAnular.Width = 821
            pnlOperandosAnular.Top = pnlAnular.Bottom + 5
            dgvComprasAnular.Top = pnlOperandosAnular.Bottom + 5
            txtHastaAnul.Visible = True
            dpAnularCompraFin.Visible = True
            cbProveedor3.Visible = False
            txtNrofacturaAnul.Visible = False

        ElseIf cbAnularFiltro.SelectedIndex = 2 Then
            txtFiltro.Text = "Seleccione Proveedor"
            txtFiltro.Visible = True

            pnlAnular.Height = 76
            pnlAnular.Width = 821
            dpAnularCompraIni.Visible = False
            dpAnularCompraFin.Visible = False
            cbProveedor3.Location = txtNrofacturaAnul.Location
            cbProveedor3.Visible = True
            txtNrofacturaAnul.Visible = False
            pnlOperandosAnular.Top = pnlAnular.Bottom + 5
            dgvComprasAnular.Top = pnlOperandosAnular.Bottom + 5
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAnularCompra.Click
        Dim row = dgvComprasAnular.CurrentRow.Index
        Dim codigo = dgvComprasAnular.Item(0, row).Value

        Dim result As Integer = MessageBox.Show("Desea Anular la compra  " + codigo.ToString + " ?", "caption", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim daoProd As New ProductoDAO
            compraDao.anularCompra(codigo)
            MsgBox("Compra Anulada con éxito!", MsgBoxStyle.Information, "Notificación Anulación")
        End If
    End Sub

    Private Sub btnBuscarAnular_Click(sender As Object, e As EventArgs) Handles btnBuscarAnular.Click
        Dim listadoCompras As New DataSet
        If validarAnulacion() Then
            If cbAnularFiltro.SelectedIndex = 0 Then
                Dim filtro = txtNrofacturaAnul.Text
                Dim tipoBusq = cbBuscarCompra.SelectedIndex
                listadoCompras = compraDao.buscarCompra(filtro, tipoBusq)
            ElseIf cbAnularFiltro.SelectedIndex = 1 Then
                Dim inicio = dpAnularCompraIni.Value.Date
                Dim fin = dpAnularCompraFin.Value.Date
                listadoCompras = compraDao.carga(inicio, fin, 0)
            ElseIf cbAnularFiltro.SelectedIndex = 2 Then
                Dim filtro = cbProveedor3.SelectedItem.item("Descripción")

                Dim tipoBusq = 2
                listadoCompras = compraDao.buscarCompra(filtro, tipoBusq)
            End If
            dgvComprasAnular.DataSource = listadoCompras.Tables("tabla")
            dgvComprasAnular.Visible = True
            pnlOperandosAnular.Visible = True
        Else
            MsgBox("Debe ingresar un número de factura", MsgBoxStyle.Critical, "Notificación")
        End If

    End Sub

    Private Function validarAnulacion()
        If cbAnularFiltro.SelectedIndex = 0 Then
            If txtNrofacturaAnul.Text = "" Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVerDetalleAnul.Click
        If dgvComprasAnular.SelectedRows.Count > 0 Then
            Dim row = dgvComprasAnular.CurrentRow.Index
            Dim codigo = dgvComprasAnular.Item(0, row).Value
            Dim detalleForm As New DetalleCompra(codigo)
            detalleForm.ShowDialog()

            detalleForm.Dispose()
        End If
    End Sub

    ' --------------------------------------------- PAGOS COMPRAS - METODOS ---------------------------------------------
    Private Sub cbFiltroP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroP.SelectedIndexChanged
        btnDetalle.Visible = False
        Me.SuspendLayout()
        If cbFiltroP.SelectedIndex = 0 Then
            pnlFechas.Visible = False
            txtNroFactPago.Visible = True
            cbProveedor4.Visible = False
            txtNroFactPago.Text = ""
            txtNroFactPago.Focus()
            lblFiltroTipo.Text = "Inserte Nro. Factura"
            lblFiltroTipo.Visible = True

        ElseIf cbFiltroP.SelectedIndex = 1 Then
            pnlFechas.Visible = True
            txtNroFactPago.Visible = False
            cbProveedor4.Visible = False
            lblFiltroTipo.Visible = False
        ElseIf cbFiltroP.SelectedIndex = 2 Then
            pnlFechas.Visible = False
            txtNroFactPago.Visible = False
            cbProveedor4.Visible = True
            lblFiltroTipo.Text = "Seleccione el proveedor"

            'txtNroFacturaListado.Focus()
            'ElseIf cbBuscarCompra.SelectedItem = "Proveedor" Then
            '    dpAnularCompra.Visible = False
            '    cbProveedoresAnular.Location = txtNrofacturaAnul.Location
            '    cbProveedoresAnular.Visible = True
            '    txtNrofacturaAnul.Visible = False
        End If
        Me.ResumeLayout()
    End Sub

    Private Sub btnBuscarP_Click(sender As Object, e As EventArgs) Handles btnBuscarP.Click
        Try
            Dim listadoCompras As New DataSet
            If cbFiltroP.SelectedIndex = 0 Then
                Dim filtro = txtNroFactPago.Text

                listadoCompras = compraDao.buscarCompraPago(filtro, 0)
            ElseIf cbFiltroP.SelectedIndex = 1 Then
                Dim inicio = dpDesdePago.Value.Date
                Dim fin = dpHastaPago.Value.Date
                listadoCompras = compraDao.carga(inicio, fin, 1)
            ElseIf cbFiltroP.SelectedIndex = 2 Then
                Dim filtro = cbProveedor4.SelectedItem.item("Descripción")

                listadoCompras = compraDao.buscarCompraPago(filtro, 2)
            End If

            btnDetalleP.Visible = True
            btnPagar.Visible = True
            dgvComprasP.DataSource = listadoCompras.Tables("tabla")
            dgvComprasP.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'carga elemento
    End Sub



    Private Sub btnDetalleP_Click(sender As Object, e As EventArgs) Handles btnDetalleP.Click
        If dgvComprasP.SelectedRows.Count > 0 Then
            Dim row = dgvComprasP.CurrentRow.Index
            Dim codigo = dgvComprasP.Item(0, row).Value
            Dim detalleForm As New DetalleCompra(codigo)
            detalleForm.ShowDialog()

            detalleForm.Dispose()
        Else
            MsgBox("Niguna compra selecciona!", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub



    ' --------------------------------------------- LOAD - METODOS ---------------------------------------------






    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress, txtEntregaInicial.KeyPress, txtPrecioProd.KeyPress, txtFiltroBusquedaNC.KeyPress, txtNroFacturaListado.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        If dgvComprasP.SelectedRows.Count > 0 Then
            Dim row = dgvComprasP.CurrentRow.Index
            Dim codigo = dgvComprasP.Item(0, row).Value
            Dim fecha = dgvComprasP.Item(3, row).Value
            Dim fechaAct = dgvComprasP.Item(6, row).Value
            If IsDBNull(dgvComprasP.Item(6, row).Value) Then
                fechaAct = Nothing
            End If
            Dim saldo = dgvComprasP.Item(5, row).Value
                Dim detalleForm As New DetalleCompra(codigo)

                Dim pago As New Pagar(codigo, saldo, fecha, fechaAct)
                pago.ShowDialog()
                pago.Dispose()

            Else
                MsgBox("Niguna compra selecciona!", MsgBoxStyle.Critical, "Notificación")
        End If


    End Sub

End Class