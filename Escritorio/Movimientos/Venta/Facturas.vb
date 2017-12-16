Imports BackEnd

Public Class Facturas
    Dim daoVent As New VentaDAO
    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        'tpAnularVenta.Enabled = False
        centrarElementos()
        backgroundElementos()
        prepararElementos()

        Dim ventas = daoVent.ventasImprimir()
        dgvVentas.DataSource = ventas.Tables("tabla")
        dgvVentas.ClearSelection()
        Me.ResumeLayout()
    End Sub

    Private Sub centrarElementos()
        Panel1.Left = (Me.ClientSize.Width / 2) - (Panel1.Width / 2)
        Panel2.Left = (Me.ClientSize.Width / 2) - (Panel2.Width / 2)
        'lblVentas.Left = (Me.ClientSize.Width / 2) - (lblVentas.Width / 2)
    End Sub
    Private Sub prepararElementos()


        ' -------------- Cobros --------------

        cbFiltroCobro.BindingContext = New BindingContext()
        cbFiltroCobro.DataSource = VariablesUtiles.busquedaVentas
        'cbCliente4.DataSource = listClientes.Copy
        'cbCliente4.DisplayMember = "Nombre"
        'cbCliente4.ValueMember = "Código"
        txtClienteCobro.Location = txtNroFactCobro.Location
        txtClienteCobro.Visible = False
        dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        ' -------------- Nueva Venta --------------
    End Sub

    Private Sub backgroundElementos()


        ' Cobros
        'lblTituloVenta.BackColor = Color.FromArgb(80, Color.Black)
        pnlCobro.BackColor = Color.FromArgb(80, Color.Black)
        Panel1.BackColor = Color.FromArgb(80, Color.Black)
        Panel2.BackColor = Color.FromArgb(80, Color.Black)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1

    End Sub
    Private Sub cbFiltroCobro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroCobro.SelectedIndexChanged

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



    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellClick
        Dim row = dgvVentas.CurrentRow.Index
        Dim codigo = dgvVentas.Item(0, row).Value

        Dim daoventa As New VentaDAO
        Dim detalle = daoventa.cargarDetalle(codigo)
        dgvDetalle.DataSource = detalle.Tables("tabla")
        dgvDetalle.Columns(0).Visible = False
        dgvDetalle.ClearSelection()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim facturaImprimir As New rpFactura
            Dim row = dgvVentas.CurrentRow.Index
            Dim codigo = dgvVentas.Item(0, row).Value
            facturaImprimir.SetParameterValue("codigo", codigo)
            facturaImprimir.PrintOptions.PrinterName = "ELX350"
            facturaImprimir.PrintToPrinter(1, False, 0, 0)
            MsgBox("¡Factura impresa!", MsgBoxStyle.Information, "Notificación")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnBuscarCobro_Click(sender As Object, e As EventArgs) Handles btnBuscarCobro.Click
        If cbFiltroCobro.SelectedIndex = 0 Then
            Dim filtro = txtNroFactCobro.Text
            Dim lista = daoVent.buscarVentasImprimir(filtro, 0, Nothing, Nothing)
            dgvVentas.DataSource = lista.Tables("tabla")
            dgvVentas.ClearSelection()
            dgvVentas.Refresh()
        ElseIf cbFiltroCobro.SelectedIndex = 1 Then
            Dim inicio = dpDesdePago.Value.Date
            Dim fin = dpHastaPago.Value.Date

            Dim lista = daoVent.buscarVentasImprimir(Nothing, 1, inicio, fin)
            dgvVentas.DataSource = lista.Tables("tabla")
            dgvVentas.ClearSelection()
            dgvVentas.Refresh()
        ElseIf cbFiltroCobro.SelectedIndex = 2 Then
            Dim filtro = txtClienteCobro.Text
            Dim lista = daoVent.buscarVentasImprimir(filtro, 2, Nothing, Nothing)
            dgvVentas.DataSource = lista.Tables("tabla")
            dgvVentas.ClearSelection()
            dgvVentas.Refresh()
        End If
    End Sub

    Private Sub txtClienteCobro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteCobro.KeyDown, txtNroFactCobro.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnBuscarCobro_Click(sender, e)
        End If
    End Sub

End Class