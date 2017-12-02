Imports BackEnd

Public Class DepositosMI
    Dim movInt As New MovInternoDAO
    Dim linea = 0
    Private Sub DepositosMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuspendLayout()
        centrarElementos()
        prepararElementos()
        backgroundElementos()
        ResumeLayout()
    End Sub

    Private Sub centrarElementos()
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        pnlDatosMov.Left = (Me.ClientSize.Width / 2) - (pnlDatosMov.Width / 2)
        pnlDatosProducto.Left = (Me.ClientSize.Width / 2) - (pnlDatosProducto.Width / 2)
        dgvProductos.Left = (Me.ClientSize.Width / 2) - (dgvProductos.Width / 2)
        pnlBusqueda.Left = pnlDatosProducto.Right - pnlBusqueda.Width
        pnlGuardarMov.Left = pnlBusqueda.Left
        dgvBusquedaResult.Left = dgvProductos.Left
        lblTituloDetalle.Left = (Me.ClientSize.Width / 2) - (lblTituloDetalle.Width / 2)

        dgvBusquedaResult.Visible = False
    End Sub

    Private Sub prepararElementos()
        Label4.BackColor = Color.Transparent
        Label10.BackColor = Color.Transparent
        Dim prov = movInt.CargaProv()
        Dim sucursales = movInt.cargaSucursales()
        Dim sucursales2 = movInt.cargaSucursales()


        cbAutorizador.DataSource = VariablesUtiles.autorizado

        Dim depositos = movInt.cargaDeposito()
        Dim listDepositos = depositos.Tables("tabla")
        Dim rowD = listDepositos.NewRow
        rowD("Descripción") = "-- Seleccione Depósito -- "
        rowD("Código") = 0
        listDepositos.Rows.InsertAt(rowD, 0)
        cbDepositoOrigen.DataSource = listDepositos
        txtDepoDestino.Text = ""
        cbDepositoOrigen.DisplayMember = "Descripción"
        cbDepositoOrigen.ValueMember = "Código"

        dgvProductos.DataSource = New stockcapiataDataSet.MovInternoProductosDataTable
        dgvProductos.Columns(5).Visible = False
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub backgroundElementos()
        pnlDatosMov.BackColor = Color.FromArgb(80, Color.Black)
        pnlDatosProducto.BackColor = Color.FromArgb(80, Color.Black)
        pnlBusqueda.BackColor = Color.FromArgb(80, Color.Black)
        pnlGuardarMov.BackColor = Color.FromArgb(80, Color.Black)
        lblTitulo.BackColor = Color.FromArgb(80, Color.Black)
        lblTituloDetalle.BackColor = Color.FromArgb(80, Color.Black)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
    End Sub

    Private Sub pnlDatosMov_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatosMov.Paint

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub btnBuscarProd_Click(sender As Object, e As EventArgs) Handles btnBuscarProd.Click
        Dim cod = txtFiltro.Text
        If cod = "" Then
            MsgBox("Debe ingresar un campo para la búsqueda", MsgBoxStyle.Critical, "Notificación")
            txtFiltro.Focus()
            Exit Sub
        ElseIf cbDepositoOrigen.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un Depósito", MsgBoxStyle.Critical, "Notificación")
            Exit Sub
        End If
        Dim deposito = cbDepositoOrigen.SelectedItem.item("Código")

        Try
            Dim Producto = movInt.BuscarProducts(cod, deposito)
            'If producto.codigo = "" Then
            '    MsgBox("Producto no encontrado. Re inserte código", MsgBoxStyle.Critical, "Notificación")
            '    txtCodProd.Focus()
            '    Exit Sub
            'End If
            'txtCodProd.Text = Producto.codigoddsa
            Me.SuspendLayout()
            dgvBusquedaResult.DataSource = Producto.Tables("tabla")
            dgvBusquedaResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvBusquedaResult.Visible = True
            dgvProductos.Visible = False
            pnlBusqueda.Visible = True
            pnlGuardarMov.Visible = False
            dgvBusquedaResult.ClearSelection()
            btnSeleccionarDeBusqueda.Visible = True
            lblTituloDetalle.Text = "SELECCIONE PRODUCTO"
            Me.ResumeLayout()
            'txtDescripcionProd.Text = producto.descripcion
            'txtDescripcionProd.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cbDepositoOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepositoOrigen.SelectedIndexChanged
        If cbDepositoOrigen.SelectedIndex = 0 Then
            txtDepoDestino.Text = ""
        ElseIf cbDepositoOrigen.SelectedIndex = 1 Then
            txtDepoDestino.Text = cbDepositoOrigen.Items(2).Item("Descripción")
        Else
            txtDepoDestino.Text = cbDepositoOrigen.Items(1).Item("Descripción")
        End If
        dgvProductos.DataSource = Nothing
        dgvProductos.DataSource = New stockcapiataDataSet.MovInternoProductosDataTable
        dgvProductos.Columns(5).Visible = False
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnSeleccionarDeBusqueda_Click(sender As Object, e As EventArgs) Handles btnSeleccionarDeBusqueda.Click
        If dgvBusquedaResult.SelectedRows.Count > 0 Then
            Me.SuspendLayout()
            dgvBusquedaResult.Visible = False
            dgvProductos.Visible = True
            pnlBusqueda.Visible = False
            pnlGuardarMov.Visible = True
            Dim row = dgvBusquedaResult.CurrentRow.Index
            Dim codigo = dgvBusquedaResult.Item(0, row).Value
            txtCodigoProd.Text = dgvBusquedaResult.Item(0, row).Value
            txtDescripcionProd.Text = dgvBusquedaResult.Item(1, row).Value
            txtStock.Text = dgvBusquedaResult.Item(2, row).Value

            lblTituloDetalle.Text = "PRODUCTOS DEL MOVIMIENTO"
            Me.ResumeLayout()
        Else
            MsgBox("Seleccione un producto!", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub



    Private Function validarCantidad() As Boolean
        If txtCantidad.Text = "" Or txtStock.Text = "" Then
            Return False
        ElseIf CInt(txtCantidad.Text) > CInt(txtStock.Text) Then
            Return False
        End If

        Return True
    End Function

    Private Sub btnInsertarProd_Click(sender As Object, e As EventArgs) Handles btnInsertarProd.Click
        If validarCantidad() Then
            Dim tablaaux As DataTable = dgvProductos.DataSource
            Dim row As DataRow = tablaaux.NewRow
            row("Código") = txtCodigoProd.Text
            row("Descripción") = txtDescripcionProd.Text
            row("Línea") = linea + 1
            linea = linea + 1
            row("Cantidad") = CInt(txtCantidad.Text)
            'row("Superficie") = 0
            row("Depósito Origen") = cbDepositoOrigen.SelectedItem.Item("Descripción")
            row("Depósito Codigo") = cbDepositoOrigen.SelectedItem.Item("Código")
            tablaaux.Rows.Add(row)
            dgvProductos.DataSource = tablaaux
            dgvProductos.ClearSelection()
        Else
            MsgBox("La cantidad supera al stock disponible", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnGuardarMov_Click(sender As Object, e As EventArgs) Handles btnGuardarMov.Click
        Dim validar = validarMovimiento()
        If validar = "ok" Then
            Dim mov As New BackEnd.MovimientoInterno


            mov.nroMov = txtNroOperacion.Text
            mov.tipo = "Depos"
            mov.solicitante = txtDepoDestino.Text
            mov.proveedor = cbDepositoOrigen.SelectedItem.item("Código")
            mov.autorizado = cbAutorizador.SelectedItem
            mov.fecha = dpFechaMov.Value
            mov.fechaIns = Date.Now
            movInt.guardarMovDepositos(mov, dgvProductos.Rows)
            Dim result As Integer = MessageBox.Show("!Momivimento realizado y guardado! ¿Desea generar un reporte ahora?", "caption", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Dim reporte As New Reporte
                reporte.codigoCompra = txtNroOperacion.Text
                reporte.tipo = "movInt"
                reporte.movInt = mov
                reporte.ShowDialog()
                reporte.Dispose()
                Me.DialogResult = DialogResult.OK
            Else
                limpiarCampos()
            End If

        ElseIf validar = "1" Then
            MsgBox("Debe ingresar un Nro. de operación", MsgBoxStyle.Critical, "Notificación")
            txtNroOperacion.Focus()

        ElseIf validar = "3" Then
            MsgBox("No agrego ningún producto al movimiento", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub
    Private Sub limpiarCampos()
        txtCantidad.Text = ""
        txtCodigoProd.Text = ""
        txtDepoDestino.Text = ""
        txtDescripcionProd.Text = ""
        txtFiltro.Text = ""
        txtNroOperacion.Text = ""
        txtStock.Text = ""
        cbDepositoOrigen.SelectedIndex = 0
        txtNroOperacion.Focus()
        dgvBusquedaResult.DataSource = Nothing
        dgvProductos.DataSource = Nothing
        dgvProductos.DataSource = New stockcapiataDataSet.MovInternoProductosDataTable

    End Sub
    Private Function validarMovimiento() As String
        Dim resultado = "ok"


        If txtNroOperacion.Text = "" Then
            Return "1"

        ElseIf dgvProductos.RowCount = 0 Then
            Return "3"
        End If
        Return resultado
    End Function
End Class