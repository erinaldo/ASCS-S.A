Imports BackEnd

Public Class AdministrarVentas
    Dim daoVenta As New VentaDAO
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
        cbCliente1.Location = txtNroFacturaListado.Location
        cbCliente1.DataSource = listClientes.Copy
        cbCliente1.DisplayMember = "Nombre"
        cbCliente1.ValueMember = "Código"

        ' -------------- Nueva Venta --------------
        cbCliente2.DataSource = listClientes.Copy
        cbCliente2.DisplayMember = "Nombre"
        cbCliente2.ValueMember = "Código"


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

        Dim impuestos = daoVenta.cargaImpuesto()
        Dim listImpuesto = impuestos.Tables("tabla")
        Dim rowI = listImpuesto.NewRow
        rowI("Código") = 0
        rowI("Impuesto") = "-- Seleccione Impuesto --"
        listImpuesto.Rows.InsertAt(rowI, 0)
        cbImpuesto.DataSource = listImpuesto
        cbImpuesto.ValueMember = "Código"
        cbImpuesto.DisplayMember = "Impuesto"
        ' -------------- Anular --------------
        cbAnularFiltro.BindingContext = New BindingContext()
        cbAnularFiltro.DataSource = VariablesUtiles.busquedaVentas

        cbCliente3.DataSource = listClientes.Copy
        cbCliente3.DisplayMember = "Nombre"
        cbCliente3.ValueMember = "Código"
        ' -------------- Cobros --------------

        cbFiltroC.BindingContext = New BindingContext()
        cbFiltroC.DataSource = VariablesUtiles.busquedaVentas
        cbCliente4.DataSource = listClientes.Copy
        cbCliente4.DisplayMember = "Nombre"
        cbCliente4.ValueMember = "Código"

    End Sub

    Private Sub centrarElementos()
        ' -------------- Listado ----------
        txtTituloBusquedaList.Left = (Me.ClientSize.Width / 2) - (txtTituloBusquedaList.Width / 2)
        pnlListado.Left = (Me.ClientSize.Width / 2) - (pnlListado.Width / 2)
        dgvVentasListado.Left = pnlListado.Left

        ' Nueva Venta

        pnlDatosProducto.Left = (Me.ClientSize.Width / 2) - (pnlDatosProducto.Width / 2)
        pnlDatosVenta.Left = (Me.ClientSize.Width / 2) - (pnlDatosVenta.Width / 2)
        dgvProductos.Left = pnlDatosProducto.Left
        dgvBusquedaResult.Left = (Me.ClientSize.Width / 2) - (dgvBusquedaResult.Width / 2)
        pnlComentario.Left = pnlDatosProducto.Left
        pnlOperadores.Left = pnlDatosProducto.Left
        pnlTotales.Left = pnlDatosProducto.Right - pnlTotales.Width

        ' Anular

        txtTituloAnular.Left = (Me.ClientSize.Width / 2) - (txtTituloAnular.Width / 2)
        pnlAnular.Left = (Me.ClientSize.Width / 2) - (pnlAnular.Width / 2)
        pnlOperandosAnular.Left = pnlAnular.Right - pnlOperandosAnular.Width
        dgvVentasAnular.Left = (Me.ClientSize.Width / 2) - (dgvVentasAnular.Width / 2)

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

        pnlComentario.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperadores.BackColor = Color.FromArgb(80, Color.Black)
        pnlTotales.BackColor = Color.FromArgb(80, Color.Black)
        tpNuevaVenta.BackgroundImageLayout = ImageLayout.Center
        tpNuevaVenta.BackgroundImage = My.Resources.Panther1

        ' Anular

        txtTituloAnular.BackColor = Color.FromArgb(80, Color.Black)
        pnlAnular.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperandosAnular.BackColor = Color.FromArgb(80, Color.Black)
        tpAnularVenta.BackgroundImageLayout = ImageLayout.Center
        tpAnularVenta.BackgroundImage = My.Resources.Panther1


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
            cbCliente1.Visible = False
            txtNroFacturaListado.Text = ""
            txtNroFacturaListado.Focus()
            lblBusqTxt.Text = "Inserte Nro. Factura"
            lblBusqTxt.Visible = True
            cbEstadoCompra.Visible = False
        ElseIf cbBuscarVentaListado.SelectedIndex = 1 Then
            pnlRangoFecha.Visible = True
            txtNroFacturaListado.Visible = False
            cbCliente1.Visible = False
            cbEstadoCompra.Visible = False
            lblBusqTxt.Visible = False
        ElseIf cbBuscarVentaListado.SelectedIndex = 2 Then
            pnlRangoFecha.Visible = False
            txtNroFacturaListado.Visible = False
            cbCliente1.Visible = True
            lblBusqTxt.Text = "Seleccione el cliente"
            lblBusqTxt.Visible = True
            cbEstadoCompra.Visible = False
        End If
    End Sub

    ' ------------------------------------- NUEVA VENTA -------------------------------------


    '------------------------------------- ANULAR -------------------------------------
    Private Sub cbAnularFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAnularFiltro.SelectedIndexChanged
        If cbAnularFiltro.SelectedIndex = 0 Then
            dpAnularVentaIni.Visible = False
            cbCliente3.Visible = False
            txtNrofacturaAnul.Visible = True
            txtFiltro.Text = "Nro. Factura"
            txtFiltro.Visible = True
            pnlAnular.Height = 76
            pnlAnular.Width = 821
            pnlOperandosAnular.Top = pnlAnular.Bottom + 5
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
            dgvVentasAnular.Top = pnlOperandosAnular.Bottom + 5
            txtHastaAnul.Visible = True
            dpAnularVentaFin.Visible = True
            cbCliente3.Visible = False
            txtNrofacturaAnul.Visible = False

        ElseIf cbAnularFiltro.SelectedIndex = 2 Then
            txtFiltro.Text = "Seleccione Cliente"
            txtFiltro.Visible = True

            pnlAnular.Height = 76
            pnlAnular.Width = 821
            dpAnularVentaIni.Visible = False
            dpAnularVentaFin.Visible = False
            cbCliente3.Location = txtNrofacturaAnul.Location
            cbCliente3.Visible = True
            txtNrofacturaAnul.Visible = False
            pnlOperandosAnular.Top = pnlAnular.Bottom + 5
            dgvVentasAnular.Top = pnlOperandosAnular.Bottom + 5
        End If
    End Sub




    ' ------------------------------------------------- Cobros -------------------------------------------------
    Private Sub cbFiltroC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroC.SelectedIndexChanged
        btnDetalle.Visible = False
        Me.SuspendLayout()
        If cbFiltroC.SelectedIndex = 0 Then
            pnlFechas.Visible = False
            txtNroFactCobro.Visible = True
            cbCliente4.Visible = False
            txtNroFactCobro.Text = ""
            txtNroFactCobro.Focus()
            lblFiltroTipo.Text = "Inserte Nro. Factura"
            lblFiltroTipo.Visible = True

        ElseIf cbFiltroC.SelectedIndex = 1 Then
            pnlFechas.Visible = True
            txtNroFactCobro.Visible = False
            cbCliente4.Visible = False
            lblFiltroTipo.Visible = False
        ElseIf cbFiltroC.SelectedIndex = 2 Then
            pnlFechas.Visible = False
            txtNroFactCobro.Visible = False
            cbCliente4.Visible = True
            lblFiltroTipo.Text = "Seleccione el cliente"
            cbCliente4.Location = txtNroFactCobro.Location
            'txtNroFacturaListado.Focus()
            'ElseIf cbBuscarCompra.SelectedItem = "Proveedor" Then
            '    dpAnularCompra.Visible = False
            '    cbProveedoresAnular.Location = txtNrofacturaAnul.Location
            '    cbProveedoresAnular.Visible = True
            '    txtNrofacturaAnul.Visible = False
        End If
        Me.ResumeLayout()
    End Sub
End Class