Imports BackEnd

Public Class MovimientoInterno
    Dim linea As Integer
    Dim movInt As New MovInternoDAO
    Private Sub MovimientoInterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuspendLayout()
        centrarElementos()
        prepararElementos()
        backgroundElementos()
        ResumeLayout()
    End Sub

    Private Sub centrarElementos()
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        pnlDatosMov.Left = (Me.ClientSize.Width / 2) - (pnlDatosMov.Width / 2)
        pnlDatosProducto.Left = pnlDatosMov.Left
        dgvProductos.Left = (Me.ClientSize.Width / 2) - (dgvProductos.Width / 2)
        pnlBusqueda.Left = pnlDatosMov.Right - pnlBusqueda.Width
        pnlGuardarMov.Left = pnlBusqueda.Left
        dgvBusquedaResult.Left = dgvProductos.Left
        dgvBusquedaResult.Visible = False
    End Sub

    Private Sub prepararElementos()
        cbSolicitante.DataSource = VariablesUtiles.sucursales
        Dim prov = movInt.CargaProv()
        cbProveedor.DataSource = prov.Tables("tabla")
        cbProveedor.DisplayMember = "Descripción"
        cbProveedor.ValueMember = "Código"
        dgvProductos.DataSource = New stockcapiataDataSet.MovInternoProductosDataTable
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        linea = 0
    End Sub

    Private Sub backgroundElementos()
        pnlDatosMov.BackColor = Color.FromArgb(80, Color.Black)
        pnlDatosProducto.BackColor = Color.FromArgb(80, Color.Black)
        pnlBusqueda.BackColor = Color.FromArgb(80, Color.Black)
        pnlGuardarMov.BackColor = Color.FromArgb(80, Color.Black)
        lblTitulo.BackColor = Color.FromArgb(80, Color.Black)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
    End Sub

    Private Sub btnBuscarProd_Click(sender As Object, e As EventArgs) Handles btnBuscarProd.Click
        Dim cod = txtCodProd.Text
        Try
            Dim producto = movInt.BuscarProducts(cod)
            'If producto.codigo = "" Then
            '    MsgBox("Producto no encontrado. Re inserte código", MsgBoxStyle.Critical, "Notificación")
            '    txtCodProd.Focus()
            '    Exit Sub
            'End If
            'txtCodProd.Text = Producto.codigo
            dgvBusquedaResult.DataSource = producto.Tables("tabla")
            dgvBusquedaResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvBusquedaResult.Visible = True
            dgvProductos.Visible = False
            pnlBusqueda.Visible = True
            pnlGuardarMov.Visible = False
            btnSeleccionarDeBusqueda.Visible = True
            'txtDescripcionProd.Text = producto.descripcion
            'txtDescripcionProd.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnSeleccionarDeBusqueda_Click(sender As Object, e As EventArgs) Handles btnSeleccionarDeBusqueda.Click
        dgvBusquedaResult.Visible = False
        dgvProductos.Visible = True
        pnlBusqueda.Visible = False
        pnlGuardarMov.Visible = True
        Dim row = dgvBusquedaResult.CurrentRow.Index
        Dim codigo = dgvBusquedaResult.Item(0, row).Value
        txtCodigoProd.Text = dgvBusquedaResult.Item(0, row).Value
        txtDescripcionProd.Text = dgvBusquedaResult.Item(1, row).Value
        txtStock.Text = dgvBusquedaResult.Item(2, row).Value
    End Sub

    Private Sub btnInsertarProd_Click(sender As Object, e As EventArgs) Handles btnInsertarProd.Click
        If validarCantidad() Then
            Dim tablaaux As DataTable = dgvProductos.DataSource
            Dim row As DataRow = tablaaux.NewRow
            row("Código") = txtCodigoProd.Text
            row("Descripción") = txtDescripcionProd.Text
            row("Línea") = linea + 1
            linea = linea + 1
            row("Cantidad") = CInt(txtCantidad.Text)
            row("Superficie") = 0
            tablaaux.Rows.Add(row)
            dgvProductos.DataSource = tablaaux
        Else
            MsgBox("La cantidad supera al stock disponible", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub

    Private Function validarCantidad() As Boolean
        If CInt(txtCantidad.Text) > CInt(txtStock.Text) Then
            Return False
        End If

        Return True
    End Function

    Private Sub btnEliminarProd_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click

        Dim index = dgvProductos.CurrentRow.Index
        Dim row = dgvProductos.CurrentRow

        Dim i As Integer
        For i = index + 1 To dgvProductos.RowCount - 1
            dgvProductos.Item(2, i).Value = dgvProductos.Item(2, i).Value - 1
            linea = linea - 1
        Next
        dgvProductos.Rows.Remove(row)
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub btnGuardarMov_Click(sender As Object, e As EventArgs) Handles btnGuardarMov.Click
        Dim validar = validarMovimiento()
        If validar = "ok" Then
            MsgBox("Movimiento Realizado")
        ElseIf validar = "0" Then
            MsgBox("Debe selecionar un tipo de movimiento", MsgBoxStyle.Critical, "Notificación")
            gbTipoMov.Focus()
        ElseIf validar = "1" Then
            MsgBox("Debe ingresar un Nro. de operación", MsgBoxStyle.Critical, "Notificación")
            txtNroOperacion.Focus()
        ElseIf validar = "2" Then
            MsgBox("Debe Seleccionar un solicitante", MsgBoxStyle.Critical, "Notificación")
            cbSolicitante.Focus()

        End If
    End Sub

    Private Function validarMovimiento() As String
        Dim resultado = "ok"

        If rbEntrada.Checked = False And rbSalida.Checked = False Then
            Return "0"
        ElseIf txtNroOperacion.Text = "" Then
            Return "1"
        ElseIf cbSolicitante.SelectedIndex = 0 Then
            Return "2"
        End If
        Return resultado
    End Function
End Class