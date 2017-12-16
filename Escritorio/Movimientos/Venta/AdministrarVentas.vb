Imports BackEnd

Public Class AdministrarVentas
    Dim daoVenta As New VentaDAO
    Dim depo
    Dim linea As Integer = 0



    ' ------------------------------------------------- Carga -------------------------------------------------
    Private Sub AdministrarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()

        centrarElementos()
        backgroundElementos()
        prepararElementos()
        Me.ResumeLayout()
    End Sub

    Private Sub prepararElementos()

        Dim clientes = daoVenta.cbClientes()
        Dim listClientes = clientes.Tables("tabla")
        Dim rowC = listClientes.NewRow()
        rowC("Nombre") = "-- Seleccione Cliente -- "
        rowC("Código") = 0
        listClientes.Rows.InsertAt(rowC, 0)



        Dim vendedores = daoVenta.cbVendedores()
        Dim listVend = vendedores.Tables("tabla")
        Dim rowV = listVend.NewRow()
        rowV("Nombre") = "-- Seleccione Vendedor -- "
        rowV("Código") = 0
        listVend.Rows.InsertAt(rowV, 0)

        ' -------------- Listado --------------
        cbBuscarVentaListado.DataSource = VariablesUtiles.busquedaVentas
        'cbCliente1.Location = txtNroFacturaListado.Location
        'cbCliente1.DataSource = listClientes.Copy
        'cbCliente1.DisplayMember = "Nombre"
        'cbCliente1.ValueMember = "Código"
        txtClienteRucListado.Location = txtNroFacturaListado.Location
        txtClienteRucListado.Visible = False
        dgvVentasListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVentasListado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        ' -------------- Nueva Venta --------------
        'cbCliente2.DataSource = listClientes.Copy
        'cbCliente2.DisplayMember = "Nombre"
        'cbCliente2.ValueMember = "Código"


        cbVendedor2.DataSource = listVend.Copy
        cbVendedor2.DisplayMember = "Nombre"
        cbVendedor2.ValueMember = "Código"

        Dim depositos = daoVenta.cargaDeposito()
        Dim listDepositos = depositos.Tables("tabla")
        Dim rowD = listDepositos.NewRow
        rowD("Descripción") = "-- Seleccione Depósito -- "
        rowD("Código") = 0
        listDepositos.Rows.InsertAt(rowD, 0)
        cbDeposito.DataSource = listDepositos
        cbDeposito.DisplayMember = "Descripción"
        cbDeposito.ValueMember = "Código"
        cbDeposito.Enabled = False
        cbDeposito.SelectedIndex = 2
        Dim impuestos = daoVenta.cargaImpuesto()
        Dim listImpuesto = impuestos.Tables("tabla")
        Dim rowI = listImpuesto.NewRow
        rowI("Código") = 0
        rowI("Impuesto") = "-- Seleccione Impuesto --"
        listImpuesto.Rows.InsertAt(rowI, 0)
        cbImpuesto.DataSource = listImpuesto
        cbImpuesto.ValueMember = "Código"
        cbImpuesto.DisplayMember = "Impuesto"

        dgvProductos.DataSource = New stockcapiataDataSet.productosVentaDataTable
        dgvProductos.Columns("DepoCod").Visible = False
        dgvProductos.Columns("Depósito").Visible = False
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' -------------- Anular --------------
        cbAnularFiltro.BindingContext = New BindingContext()
        cbAnularFiltro.DataSource = VariablesUtiles.busquedaVentas
        dgvVentasAnular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVentasAnular.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        ' -------------- Cobros --------------

        cbFiltroCobro.BindingContext = New BindingContext()
        cbFiltroCobro.DataSource = VariablesUtiles.busquedaVentas
        'cbCliente4.DataSource = listClientes.Copy
        'cbCliente4.DisplayMember = "Nombre"
        'cbCliente4.ValueMember = "Código"
        txtClienteCobro.Location = txtNroFactCobro.Location
        txtClienteCobro.Visible = False
        dgvVentasCobro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVentasCobro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        ' -------------- Nueva Venta --------------
    End Sub

    Private Sub centrarElementos()
        ' -------------- Listado ----------
        txtTituloBusquedaList.Left = (Me.ClientSize.Width / 2) - (txtTituloBusquedaList.Width / 2)
        pnlListado.Left = (Me.ClientSize.Width / 2) - (pnlListado.Width / 2)
        dgvVentasListado.Left = pnlListado.Left

        ' Nueva Venta

        pnlDatosProducto.Left = (Me.ClientSize.Width / 2) - (pnlDatosProducto.Width / 2)
        pnlDatosVenta.Left = pnlDatosProducto.Left
        dgvProductos.Left = pnlDatosProducto.Left
        dgvBusquedaResult.Left = (Me.ClientSize.Width / 2) - (dgvBusquedaResult.Width / 2)
        pnlComentario.Left = pnlDatosProducto.Left
        pnlOperadores.Left = pnlDatosProducto.Left
        pnlTotales.Left = pnlDatosProducto.Right - pnlTotales.Width
        Panel2.Left = pnlDatosProducto.Left
        Panel3.Left = pnlDatosVenta.Right - Panel3.Width
        pnlSeleccionProd.Left = (Me.ClientSize.Width / 2) - (pnlSeleccionProd.Width / 2)
        pnlDescuento.Left = (Me.ClientSize.Width / 2) - (pnlDescuento.Width / 2)
        ' Anular

        txtTituloAnular.Left = (Me.ClientSize.Width / 2) - (txtTituloAnular.Width / 2)
        pnlAnular.Left = (Me.ClientSize.Width / 2) - (pnlAnular.Width / 2)
        pnlOperandosAnular.Left = pnlAnular.Right - pnlOperandosAnular.Width
        dgvVentasAnular.Left = (Me.ClientSize.Width / 2) - (dgvVentasAnular.Width / 2)
        pnlComentarioAnular.Left = pnlAnular.Left
        ' Cobros
        lblTituloVenta.Left = (Me.ClientSize.Width / 2) - (lblTituloVenta.Width / 2)
        pnlCobro.Left = (Me.ClientSize.Width / 2) - (pnlCobro.Width / 2)
        dgvVentasCobro.Left = (Me.ClientSize.Width / 2) - (dgvVentasCobro.Width / 2)
    End Sub

    Private Sub backgroundElementos()
        ' -------------- Listado ----------
        txtTituloBusquedaList.BackColor = Color.FromArgb(80, Color.Black)
        pnlListado.BackColor = Color.FromArgb(80, Color.Black)
        tpListado.BackgroundImageLayout = ImageLayout.Center
        tpListado.BackgroundImage = My.Resources.Panther1

        ' Nueva Venta

        pnlDatosProducto.BackColor = Color.FromArgb(80, Color.Black)
        pnlDatosVenta.BackColor = Color.FromArgb(80, Color.Black)
        pnlDescuento.BackColor = Color.FromArgb(80, Color.Black)
        pnlComentario.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperadores.BackColor = Color.FromArgb(80, Color.Black)
        pnlTotales.BackColor = Color.FromArgb(80, Color.Black)
        tpNuevaVenta.BackgroundImageLayout = ImageLayout.Center
        tpNuevaVenta.BackgroundImage = My.Resources.Panther1
        pnlSeleccionProd.BackColor = Color.FromArgb(80, Color.Black)
        Panel2.BackColor = Color.FromArgb(80, Color.Black)
        Panel3.BackColor = Color.FromArgb(80, Color.Black)
        ' Anular

        txtTituloAnular.BackColor = Color.FromArgb(80, Color.Black)
        pnlAnular.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperandosAnular.BackColor = Color.FromArgb(80, Color.Black)
        tpAnularVenta.BackgroundImageLayout = ImageLayout.Center
        tpAnularVenta.BackgroundImage = My.Resources.Panther1
        pnlComentarioAnular.BackColor = Color.FromArgb(80, Color.Black)

        ' Cobros
        lblTituloVenta.BackColor = Color.FromArgb(80, Color.Black)
        pnlCobro.BackColor = Color.FromArgb(80, Color.Black)
        tpCobros.BackgroundImageLayout = ImageLayout.Center
        tpCobros.BackgroundImage = My.Resources.Panther1

    End Sub
    ' ------------------------------------- LISTADO -------------------------------------
    Private Sub cbBuscarVentaListado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBuscarVentaListado.SelectedIndexChanged
        btnDetalle.Visible = False
        Me.SuspendLayout()
        If cbBuscarVentaListado.SelectedIndex = 0 Then
            pnlRangoFecha.Visible = False
            txtNroFacturaListado.Visible = True
            txtClienteRucListado.Visible = False
            txtNroFacturaListado.Text = ""
            txtNroFacturaListado.Focus()
            lblBusqTxt.Text = "Inserte Nro. Factura"
            lblBusqTxt.Visible = True
            cbEstadoCompra.Visible = False
        ElseIf cbBuscarVentaListado.SelectedIndex = 1 Then
            pnlRangoFecha.Visible = True
            txtNroFacturaListado.Visible = False
            txtClienteRucListado.Visible = False
            cbEstadoCompra.Visible = False
            lblBusqTxt.Visible = False
        ElseIf cbBuscarVentaListado.SelectedIndex = 2 Then
            pnlRangoFecha.Visible = False
            txtNroFacturaListado.Visible = False
            txtClienteRucListado.Visible = True
            lblBusqTxt.Text = "Ingrese el RUC/CI "
            lblBusqTxt.Visible = True
            cbEstadoCompra.Visible = False
            txtClienteRucListado.Focus()
        End If
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        If dgvVentasListado.SelectedRows.Count > 0 Then
            Dim row = dgvVentasListado.CurrentRow.Index
            Dim codigo = dgvVentasListado.Item(0, row).Value
            Dim detalleForm As New DetalleVenta(codigo)
            detalleForm.ShowDialog()

            detalleForm.Dispose()
        Else
            MsgBox("¡Ninguna venta seleccionada!", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub

    Private Sub btnBuscarCompra_Click(sender As Object, e As EventArgs) Handles btnBuscarCompra.Click
        If validarBusquedaVenta() Then
            Try
                Dim listadoVentas As New DataSet
                If cbBuscarVentaListado.SelectedIndex = 0 Then
                    Dim filtro = txtNroFacturaListado.Text

                    listadoVentas = daoVenta.buscarVentas(filtro, 0, Nothing, Nothing)
                ElseIf cbBuscarVentaListado.SelectedIndex = 1 Then
                    Dim inicio = datepInicio.Value.Date
                    Dim fin = datepFin.Value.Date
                    listadoVentas = daoVenta.buscarVentas(Nothing, 1, inicio, fin)
                ElseIf cbBuscarVentaListado.SelectedIndex = 2 Then
                    Dim filtro = txtClienteRucListado.Text
                    listadoVentas = daoVenta.buscarVentas(filtro, 2, Nothing, Nothing)
                    'Else
                    '    Dim filtro = cbEstadoCompra.SelectedValue

                    '    listadoCompras = CompraDAO.buscarCompra(filtro, 3)
                End If

                btnDetalle.Visible = True
                dgvVentasListado.DataSource = listadoVentas.Tables("tabla")
                dgvVentasListado.Visible = True
                dgvVentasListado.Columns("rucCliente").Visible = False
                dgvVentasListado.Columns("Código").Visible = False
                dgvVentasListado.ClearSelection()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'carga elementos generar compra
        Else
            MsgBox("¡Inserte los parametros de búsqueda!", MsgBoxStyle.Critical, "Notificación")
        End If

    End Sub

    Private Function validarBusquedaVenta()
        If cbBuscarVentaListado.SelectedIndex = 0 Then
            If txtNroFacturaListado.Text = "" Then
                Return False
            End If
        ElseIf cbBuscarVentaListado.SelectedIndex = 2 Then
            If txtClienteRucListado.Text = "" Then
                MsgBox("¡Ingrese el RUC/CI del cliente!", MsgBoxStyle.Critical, "Error de búsqueda")
            End If
        End If
        Return True
    End Function
    ' ------------------------------------- NUEVA VENTA -------------------------------------
    Private Sub txt_buscar_ci(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCI.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Try

                Dim ci = txtCI.Text
                Dim client = daoVenta.buscarCliente(ci)

                If client.ruc = Nothing Then
                    Dim result As Integer = MessageBox.Show("¡Cliente no registrado! ¿Registrarlo?", "caption", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then
                        Dim nuevoCliente As New AgregarCliente(ci)
                        Dim res As New DialogResult
                        res = nuevoCliente.ShowDialog()
                        nuevoCliente.Dispose()
                        If res = DialogResult.OK Then
                            client = daoVenta.buscarCliente(ci)
                            txtNombreCli.Text = client.nombre
                        End If
                    Else
                        Me.DialogResult = DialogResult.None

                    End If
                Else
                    txtNombreCli.Text = client.nombre
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub txtCI_TextChanged(sender As Object, e As EventArgs) Handles txtCI.TextChanged
        txtNombreCli.Text = ""
    End Sub

    Private Sub txtFiltroBusquedaNC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltroBusquedaNC.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SuspendLayout()
            btnBuscarProd_Click(sender, e)
            Me.ResumeLayout()
        End If
    End Sub

    Private Sub btnBuscarProd_Click(sender As Object, e As EventArgs) Handles btnBuscarProd.Click
        Dim cod = txtFiltroBusquedaNC.Text
        If cod = "" Then
            MsgBox("Debe ingresar un campo para la búsqueda", MsgBoxStyle.Critical, "Notificación")
            txtFiltro.Focus()
            Exit Sub
        ElseIf cbDeposito.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un Depósito", MsgBoxStyle.Critical, "Notificación")
            Exit Sub
        End If
        Dim deposito = cbDeposito.SelectedItem.item("Código")
        'depositoAct = cbDeposito.SelectedItem.item("Descripción")
        'depositoActCod = deposito
        Try
            Dim productos = daoVenta.BuscarProducts(cod)
            'If producto.codigo = "" Then
            '    MsgBox("Producto no encontrado. Re inserte código", MsgBoxStyle.Critical, "Notificación")
            '    txtCodProd.Focus()
            '    Exit Sub
            'End If
            'txtCodProd.Text = Producto.codigoddsa
            Me.SuspendLayout()
            pnlDescuento.Visible = False
            dgvBusquedaResult.DataSource = productos.Tables("tabla")
            dgvBusquedaResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvBusquedaResult.Visible = True
            dgvProductos.Visible = False
            pnlSeleccionProd.Visible = True
            pnlComentario.Visible = False
            pnlOperadores.Visible = False
            pnlTotales.Visible = False
            'pnlGuardarMov.Visible = False
            dgvBusquedaResult.ClearSelection()
            'btnSeleccionarDeBusqueda.Visible = True
            'lblTituloDetalle.Text = "SELECCIONE PRODUCTO"
            Me.ResumeLayout()
            'txtDescripcionProd.Text = producto.descripcion
            'txtDescripcionProd.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCancelarSeleccion_Click(sender As Object, e As EventArgs) Handles btnCancelarSeleccion.Click
        Me.SuspendLayout()
        dgvBusquedaResult.Visible = False
        dgvProductos.Visible = True
        pnlSeleccionProd.Visible = False
        pnlComentario.Visible = True
        pnlOperadores.Visible = True
        pnlDescuento.Visible = True
        pnlTotales.Visible = True
        Me.ResumeLayout()
    End Sub

    Private Sub btnGuardarCompra_Click(sender As Object, e As EventArgs) Handles btnGuardarVenta.Click
        If validarVenta() Then
            Try
                Dim venta As New Venta
                Dim cli As New Cliente
                cli = daoVenta.buscarCliente(txtCI.Text)
                venta.cliente = cli.codigo
                venta.comentario = txtComentario.Text
                venta.vendedor = cbVendedor2.SelectedItem.item("Código")
                If rbContado.Checked = True Then
                    venta.tipo = "Contado"
                    venta.estado = "Paga"
                    venta.fechaPagado = Date.Today
                    venta.saldo = 0
                Else
                    venta.tipo = "Crédito"
                    venta.estado = "Acti"
                    venta.saldo = CDbl(txtTotalVenta.Text)
                End If

                If txtDescuento.Text = "" Then

                    venta.descuento = 0

                Else
                    venta.descuento = CDbl(txtDescuento.Text)
                End If
                venta.fechaFactura = dateFactura.Value
                venta.fechaInsFactura = Date.Today
                venta.nroFactura = txtFacturaNro.Text
                venta.total = CDbl(txtTotalVenta.Text)
                daoVenta.guardarVenta(venta, dgvProductos.Rows)
                MsgBox("¡Venta Realizada!", MsgBoxStyle.Information, "Notificación Venta")
                limpiarCamposProducto()
                limpiarVenta()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub limpiarVenta()
        Me.SuspendLayout()
        txtFacturaNro.Text = ""
        txtCI.Text = ""
        txtTotalVenta.Text = ""
        txtSub.Text = ""
        txtIva.Text = ""
        txtDescuento.Text = ""
        btnAplicarDesc.Enabled = True
        btnDeschacerDesc.Enabled = False
        dgvProductos.DataSource = ""
        dgvProductos.DataSource = New stockcapiataDataSet.productosVentaDataTable
        Me.ResumeLayout()
    End Sub
    Private Function validarVenta() As Boolean
        If txtFacturaNro.Text = "" Then
            MsgBox("¡Inserte un número de factura!", MsgBoxStyle.Critical, "Error de campos")
            txtFacturaNro.Focus()
            Return False
        ElseIf rbContado.Checked = False And rbCredito.Checked = False Then
            MsgBox("¡Seleccione el tipo de venta!", MsgBoxStyle.Critical, "Error de campos")
            Return False
        ElseIf cbVendedor2.SelectedIndex = 0 Then
            MsgBox("¡Seleccione un vendedor de la lista!", MsgBoxStyle.Critical, "Error de campos")
            Return False
        ElseIf txtCI.Text = "" Then
            MsgBox("¡Ingrese el RUC/CI del cliente!", MsgBoxStyle.Critical, "Error de campos")
            txtCI.Focus()
            Return False
        ElseIf txtNombreCli.Text = "" Then
            MsgBox("¡Datos del cliente incompletos. Vuelva a introducir el RUC/CI !", MsgBoxStyle.Critical, "Error de campos")
            txtCI.Focus()
            Return False
        ElseIf dgvProductos.RowCount = 0 Then
            MsgBox("¡No hay productos en la lista de venta!", MsgBoxStyle.Critical, "Error de campos")
            Return False
        End If
        Return True
    End Function

    Private Function validarProducto() As Boolean
        If txtCodProd.Text = "" Then
            MsgBox("Busque un producto para agregar", MsgBoxStyle.Critical, "Error de datos")
            Return False
        ElseIf txtCodProd.Text = "" Then
            MsgBox("Busque un producto para agregar", MsgBoxStyle.Critical, "Error de datos")
            Return False
        ElseIf txtCantidad.Text = "" Then
            MsgBox("Ingrese la cantidad", MsgBoxStyle.Critical, "Error de datos")
            Return False
        ElseIf txtPrecioProd.Text = "" Then
            MsgBox("Ingrese un precio de venta", MsgBoxStyle.Critical, "Error de datos")
            Return False
        ElseIf cbImpuesto.SelectedIndex = 0 Then
            MsgBox("Seleccione un impuesto", MsgBoxStyle.Critical, "Error de datos")
            Return False
        ElseIf txtM2.Text = "" Then
            MsgBox("Ingrese la superficie del producto", MsgBoxStyle.Critical, "Error de datos")
            Return False
        End If
        Return True

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
            row("Superficie") = txtM2.Text
            Dim total = CDbl(txtPrecioProd.Text) * CDbl(txtCantidad.Text)
            Dim iva = calcularIva(total, cbImpuesto.SelectedItem("Impuesto"))
            row("Impuesto") = cbImpuesto.SelectedItem("Impuesto")
            row("Iva") = FormatCurrency(iva)
            row("Sub-Total") = FormatCurrency(total)
            row("Total") = FormatCurrency(total + iva)

            If txtSub.Text = "" Then
                txtSub.Text = FormatCurrency(total)
            Else
                txtSub.Text = FormatCurrency(CDbl(txtSub.Text) + total)
            End If
            If txtTotalVenta.Text <> "" Then
                txtTotalVenta.Text = FormatCurrency(CDbl(txtTotalVenta.Text) + total + iva)
            Else
                txtTotalVenta.Text = FormatCurrency(total + iva)
            End If

            If txtIva.Text <> "" Then
                txtIva.Text = FormatCurrency(CDbl(txtIva.Text) + iva)
            Else
                txtIva.Text = FormatCurrency(iva)
            End If

            'Dim agregar As New DataGridViewRow
            'dgvProductos.Rows.Add(txtCodProd)
            'Dim dt As DataTable = DirectCast(dgvProductos.DataSource, DataTable)
            'dt.Rows.Add(row)
            row2.Rows.Add(row)
            dgvProductos.DataSource = row2
            dgvProductos.ClearSelection()
            limpiarCamposProducto()
        End If
    End Sub

    Private Sub limpiarCamposProducto()
        txtFiltroBusquedaNC.Text = ""
        txtFiltroBusquedaNC.Focus()
        txtCodProd.Text = ""
        txtDescripcionProd.Text = ""
        txtM2.Text = ""
        txtCantidad.Text = ""
        txtStock.Text = ""
        txtPrecioProd.Text = ""

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
    Private Sub btnSeleccionarPr_Click(sender As Object, e As EventArgs) Handles btnSeleccionarPr.Click
        If dgvBusquedaResult.SelectedRows.Count > 0 Then
            Me.SuspendLayout()
            dgvBusquedaResult.Visible = False
            dgvProductos.Visible = True
            pnlSeleccionProd.Visible = False
            'pnlGuardarMov.Visible = True
            Dim row = dgvBusquedaResult.CurrentRow.Index
            Dim codigo = dgvBusquedaResult.Item(0, row).Value
            txtCodProd.Text = dgvBusquedaResult.Item(0, row).Value
            txtDescripcionProd.Text = dgvBusquedaResult.Item(1, row).Value
            txtStock.Text = dgvBusquedaResult.Item(2, row).Value
            pnlComentario.Visible = True
            pnlOperadores.Visible = True
            pnlDescuento.Visible = True
            pnlTotales.Visible = True
            '' 'txtDepositoOrigen.Text = depositoAct
            'lblTituloDetalle.Text = "PRODUCTOS DEL MOVIMIENTO"
            Me.ResumeLayout()
        Else
            MsgBox("¡Seleccione un producto!", MsgBoxStyle.Critical, "Notificación")
        End If

    End Sub

    Private Sub btnEliminarProd_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click
        If dgvProductos.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvProductos.SelectedRows
                Dim restarSub = row.Cells("Sub-Total").Value
                Dim restarIva = row.Cells("Iva").Value
                Dim restarTotal = row.Cells("Total").Value
                txtTotalVenta.Text = CDbl(txtTotalVenta.Text) - CDbl(restarTotal)
                txtIva.Text = CDbl(txtIva.Text) - CDbl(restarIva)
                txtSub.Text = CDbl(txtSub.Text) - CDbl(restarSub)
                dgvProductos.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub txtPrecioProd_LostFocus(sender As Object, e As EventArgs) Handles txtPrecioProd.LostFocus
        txtPrecioProd.Text = FormatCurrency(txtPrecioProd.Text)
    End Sub

    '------------------------------------- ANULAR -------------------------------------
    Private Sub cbAnularFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAnularFiltro.SelectedIndexChanged
        If cbAnularFiltro.SelectedIndex = 0 Then
            dpAnularVentaIni.Visible = False
            txtClienteAnular.Visible = False
            txtNrofacturaAnul.Visible = True
            txtFiltro.Text = "Nro. Factura"
            txtFiltro.Visible = True
            pnlAnular.Height = 76
            pnlAnular.Width = 821
            pnlOperandosAnular.Top = pnlAnular.Bottom + 5
            pnlComentarioAnular.Top = pnlAnular.Bottom + 5
            dgvVentasAnular.Top = pnlOperandosAnular.Bottom + 5
            txtNrofacturaAnul.Focus()

        ElseIf cbAnularFiltro.SelectedIndex = 1 Then
            txtFiltro.Text = "Desde"
            txtFiltro.Visible = True

            dpAnularVentaIni.Visible = True
            dpAnularVentaIni.Location = txtNrofacturaAnul.Location
            pnlAnular.Height = 138
            pnlAnular.Width = 821
            pnlOperandosAnular.Top = pnlAnular.Bottom + 5
            pnlComentarioAnular.Top = pnlAnular.Bottom + 5
            dgvVentasAnular.Top = pnlOperandosAnular.Bottom + 5
            txtHastaAnul.Visible = True
            dpAnularVentaFin.Visible = True
            txtClienteAnular.Visible = False
            txtNrofacturaAnul.Visible = False

        ElseIf cbAnularFiltro.SelectedIndex = 2 Then
            txtFiltro.Text = "Ingrese RUC/CI del Cliente"
            txtFiltro.Visible = True

            pnlAnular.Height = 76
            pnlAnular.Width = 821
            dpAnularVentaIni.Visible = False
            dpAnularVentaFin.Visible = False
            txtClienteAnular.Location = txtNrofacturaAnul.Location
            txtClienteAnular.Visible = True
            txtClienteAnular.Focus()
            txtNrofacturaAnul.Visible = False
            pnlOperandosAnular.Top = pnlAnular.Bottom + 5
            pnlComentarioAnular.Top = pnlAnular.Bottom + 5
            dgvVentasAnular.Top = pnlOperandosAnular.Bottom + 5
        End If
    End Sub




    ' ------------------------------------------------- Cobros -------------------------------------------------
    Private Sub cbFiltroC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroCobro.SelectedIndexChanged
        btnDetalle.Visible = False
        Me.SuspendLayout()
        If cbFiltroCobro.SelectedIndex = 0 Then
            pnlFechas.Visible = False
            txtNroFactCobro.Visible = True
            txtClienteCobro.Visible = False
            txtNroFactCobro.Text = ""
            txtNroFactCobro.Focus()
            lblFiltroTipo.Text = "Inserte Nro. Factura"
            lblFiltroTipo.Visible = True

        ElseIf cbFiltroCobro.SelectedIndex = 1 Then
            pnlFechas.Visible = True
            txtNroFactCobro.Visible = False
            txtClienteCobro.Visible = False
            lblFiltroTipo.Visible = False
        ElseIf cbFiltroCobro.SelectedIndex = 2 Then
            pnlFechas.Visible = False
            txtNroFactCobro.Visible = False
            txtClienteCobro.Visible = True
            lblFiltroTipo.Text = "Ingrese RUC/C.I"
            lblFiltroTipo.Visible = True
            txtClienteCobro.Text = ""
            txtClienteCobro.Focus()
            txtClienteCobro.Location = txtNroFactCobro.Location
            'txtNroFacturaListado.Focus()
            'ElseIf cbBuscarCompra.SelectedItem = "Proveedor" Then
            '    dpAnularCompra.Visible = False
            '    cbProveedoresAnular.Location = txtNrofacturaAnul.Location
            '    cbProveedoresAnular.Visible = True
            '    txtNrofacturaAnul.Visible = False
        End If
        Me.ResumeLayout()
    End Sub

    Private Sub btnDetalleCobro_Click(sender As Object, e As EventArgs) Handles btnDetalleCobro.Click
        If dgvVentasCobro.SelectedRows.Count > 0 Then
            Dim row = dgvVentasCobro.CurrentRow.Index
            Dim codigo = dgvVentasCobro.Item(0, row).Value
            Dim detalleForm As New DetalleVenta(codigo)
            detalleForm.ShowDialog()

            detalleForm.Dispose()
        Else
            MsgBox("¡Ninguna venta seleccionada!", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub
    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        If dgvVentasCobro.SelectedRows.Count <= 0 Then
            MsgBox("¡Ninguna Venta seleccionada", MsgBoxStyle.Critical, "Error cobro")
        Else
            Dim cobro As New CobroVenta
            Dim row = dgvVentasCobro.CurrentRow.Index
            Dim codigo = dgvVentasCobro.Item(0, row).Value

            Dim venta = daoVenta.obtenerVentaDatos(codigo)
            cobro.venta = venta
            cobro.cliente = dgvVentasCobro.Item(2, row).Value
            cobro.vendedor = dgvVentasCobro.Item(7, row).Value
            cobro.ShowDialog()
            cobro.Dispose()
        End If
    End Sub

    Private Sub buscarVentaCobros(sender As Object, e As EventArgs) Handles btnBuscarCobro.Click
        If validarBusquedaVentaCobro() Then
            Try
                Dim listadoVentas As New DataSet
                If cbFiltroCobro.SelectedIndex = 0 Then
                    Dim filtro = txtNroFactCobro.Text

                    listadoVentas = daoVenta.buscarVentasCobro(filtro, 0, Nothing, Nothing)
                ElseIf cbFiltroCobro.SelectedIndex = 1 Then
                    Dim inicio = dpDesdePago.Value.Date
                    Dim fin = dpHastaPago.Value.Date
                    listadoVentas = daoVenta.buscarVentasCobro(Nothing, 1, inicio, fin)
                ElseIf cbFiltroCobro.SelectedIndex = 2 Then
                    Dim filtro = txtClienteCobro.Text
                    listadoVentas = daoVenta.buscarVentasCobro(filtro, 2, Nothing, Nothing)
                    'Else
                    '    Dim filtro = cbEstadoCompra.SelectedValue

                    '    listadoCompras = CompraDAO.buscarCompra(filtro, 3)
                End If

                btnDetalleCobro.Visible = True
                dgvVentasCobro.DataSource = listadoVentas.Tables("tabla")
                dgvVentasCobro.Visible = True
                dgvVentasCobro.Columns("rucCliente").Visible = False
                dgvVentasCobro.Columns("Código").Visible = False

                dgvVentasCobro.ClearSelection()
                btnPagar.Visible = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'carga elementos generar compra
        Else
            MsgBox("¡Inserte los parametros de búsqueda!", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub


    Private Function validarBusquedaVentaCobro()
        If cbFiltroCobro.SelectedIndex = 0 Then
            If txtNroFactCobro.Text = "" Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress, txtPrecioProd.KeyPress, txtNroFacturaListado.KeyPress, txtDescuento.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtClienteRucListado_TextChanged(sender As Object, e As EventArgs) Handles txtClienteRucListado.TextChanged

    End Sub

    Private Sub txtClienteRucListado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteRucListado.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnBuscarCompra_Click(sender, e)
        End If
    End Sub

    Private Sub txtClienteCobro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteCobro.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            buscarVentaCobros(sender, e)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAplicarDesc.Click
        If txtDescuento.Text = "" Then
            MsgBox("Ingrese un monto válido", MsgBoxStyle.Critical, "Error descuento")
            txtDescuento.Focus()
        Else
            If txtTotalVenta.Text = "" Then
                MsgBox("No se pudo aplicar. Total igual a 0", MsgBoxStyle.Critical, "Error descuento")
            ElseIf CDbl(txtTotalVenta.Text) < CDbl(txtDescuento.Text) Then
                MsgBox("No se pudo aplicar. Descuento mayor al total", MsgBoxStyle.Critical, "Error descuento")
            Else
                txtTotalVenta.Text = FormatCurrency(CDbl(txtTotalVenta.Text) - CDbl(txtDescuento.Text))
                btnAplicarDesc.Enabled = False
                txtDescuento.Enabled = False
                btnDeschacerDesc.Enabled = True
            End If

        End If
    End Sub

    Private Sub btnDeschacerDesc_Click(sender As Object, e As EventArgs) Handles btnDeschacerDesc.Click
        txtTotalVenta.Text = FormatCurrency(CDbl(txtTotalVenta.Text) + CDbl(txtDescuento.Text))
        btnAplicarDesc.Enabled = True
        txtDescuento.Enabled = True
        txtDescuento.Text = ""
        btnDeschacerDesc.Enabled = False
    End Sub

    Private Sub txtPrecioProd_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioProd.TextChanged

    End Sub

    Private Sub tbcVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcVenta.SelectedIndexChanged
        If tbcVenta.SelectedIndex = 1 Then
            If cajaAbierta() = False Then
                MsgBox("Caja cerrada", MsgBoxStyle.Information, "Caja")
                desactivarNuevaVenta()
            End If
        End If
    End Sub

    Private Sub desactivarNuevaVenta()
        btnGuardarVenta.Enabled = False
    End Sub
    Private Function cajaAbierta()
        Dim daoVenta As New VentaDAO
        Return daoVenta.confirmarCaja()
    End Function

    Private Sub btnAnularVenta_Click(sender As Object, e As EventArgs) Handles btnAnularVenta.Click

        Dim seguridad As New Acceso
        If txtComentAnular.Text = "" Then
            Dim result As Integer = MessageBox.Show("No ingreso ningun comentario. Desea continuar  ?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Exit Sub
            End If
        End If
        If seguridad.permisosAnular = True Then
            Try
                If dgvVentasAnular.RowCount > 0 Then
                    If dgvVentasAnular.SelectedRows.Count > 0 Then
                        Dim row = dgvVentasAnular.CurrentRow.Index
                        Dim codigo = dgvVentasAnular.Item(0, row).Value
                        Dim anular = dgvVentasAnular.CurrentRow
                        Dim result As Integer = MessageBox.Show("Desea Anular la compra  " + codigo.ToString + " ?", "caption", MessageBoxButtons.YesNo)

                        If result = DialogResult.No Then
                            Exit Sub
                        ElseIf result = DialogResult.Yes Then

                            daoVenta.anularVenta(codigo, txtComentAnular.Text)
                            MsgBox("Venta Anulada con éxito!", MsgBoxStyle.Information, "Notificación Anulación")
                            dgvVentasAnular.Rows.Remove(anular)
                            dgvVentasAnular.ClearSelection()
                            pnlComentarioAnular.Enabled = False
                            txtComentAnular.Text = ""
                        End If
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No posee permisos para anular una venta", MsgBoxStyle.Critical, "Permisos")
        End If

    End Sub

    Private Sub btnBuscarAnular_Click(sender As Object, e As EventArgs) Handles btnBuscarAnular.Click
        Dim listadoCompras As New DataSet
        If validarAnulacion() Then
            If cbAnularFiltro.SelectedIndex = 0 Then
                Dim filtro = txtNrofacturaAnul.Text

                listadoCompras = daoVenta.buscarVentasAnular(filtro, 0, Nothing, Nothing)
            ElseIf cbAnularFiltro.SelectedIndex = 1 Then
                Dim inicio = dpAnularVentaIni.Value.Date
                Dim fin = dpAnularVentaFin.Value.Date
                listadoCompras = daoVenta.buscarVentasAnular(Nothing, 1, inicio, fin)
            ElseIf cbAnularFiltro.SelectedIndex = 2 Then
                Dim filtro = txtClienteAnular.Text

                Dim tipoBusq = 2
                listadoCompras = daoVenta.buscarVentasAnular(filtro, 2, Nothing, Nothing)
            End If
            dgvVentasAnular.DataSource = listadoCompras.Tables("tabla")
            dgvVentasAnular.Visible = True
            dgvVentasAnular.Columns("rucCliente").Visible = False
            dgvVentasAnular.Columns("Código").Visible = False
            dgvVentasAnular.ClearSelection()
            pnlOperandosAnular.Visible = True


        End If
    End Sub

    Private Function validarAnulacion() As Boolean
        If cbAnularFiltro.SelectedIndex = 0 Then
            If txtNrofacturaAnul.Text = "" Then
                MsgBox("Debe ingresar un número de factura", MsgBoxStyle.Critical, "Notificación")
                Return False
            End If
        ElseIf cbAnularFiltro.SelectedIndex = 2 Then
            If txtClienteAnular.Text = "" Then
                MsgBox("Debe ingresar el RUC/CI del cliente", MsgBoxStyle.Critical, "Notificación")
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub txtClienteAnular_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteAnular.KeyDown, txtNrofacturaAnul.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnBuscarAnular_Click(sender, e)
        End If
    End Sub

    Private Sub dgvVentasAnular_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentasAnular.CellClick
        pnlComentarioAnular.Enabled = True
    End Sub

    Private Sub btnVerDetalleAnul_Click(sender As Object, e As EventArgs) Handles btnVerDetalleAnul.Click
        If dgvVentasAnular.SelectedRows.Count > 0 Then
            Dim row = dgvVentasAnular.CurrentRow.Index
            Dim codigo = dgvVentasAnular.Item(0, row).Value
            Dim detalleForm As New DetalleVenta(codigo)
            detalleForm.ShowDialog()

            detalleForm.Dispose()
        Else
            MsgBox("¡Ninguna venta seleccionada!", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub
End Class