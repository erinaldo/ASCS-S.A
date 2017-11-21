Imports BackEnd

Public Class MovimientoInterno
    Dim linea As Integer
    Dim movInt As New MovInternoDAO
    Dim movsolicitante As String = ""
    Dim movprov As String = ""
    Dim depositoAct = ""
    Dim depositoActCod = 0
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
        lblTituloDetalle.Left = (Me.ClientSize.Width / 2) - (lblTituloDetalle.Width / 2)

        dgvBusquedaResult.Visible = False
    End Sub

    Private Sub prepararElementos()

        Dim prov = movInt.CargaProv()
        Dim sucursales = movInt.cargaSucursales()
        Dim sucursales2 = movInt.cargaSucursales()
        cbProveedor.DataSource = sucursales.Tables("tabla")
        cbProveedor.DisplayMember = "Nombre"
        cbProveedor.ValueMember = "Código"

        Dim listSolicitantes = sucursales2.Tables("tabla")
        Dim rowSol = listSolicitantes.NewRow
        rowSol("Nombre") = "-- Seleccione Solicitante -- "
        rowSol("Código") = 0
        listSolicitantes.Rows.InsertAt(rowSol, 0)
        cbSolicitante.DataSource = listSolicitantes
        cbSolicitante.DisplayMember = "Nombre"
        cbSolicitante.ValueMember = "Código"

        cbAutorizador.DataSource = VariablesUtiles.autorizado

        Dim depositos = movInt.cargaDeposito()
        Dim listDepositos = depositos.Tables("tabla")
        Dim rowD = listDepositos.NewRow
        rowD("Descripción") = "-- Seleccione Depósito -- "
        rowD("Código") = 0
        listDepositos.Rows.InsertAt(rowD, 0)
        cbDeposito.DataSource = listDepositos
        cbDeposito.DisplayMember = "Descripción"
        cbDeposito.ValueMember = "Código"


        dgvProductos.DataSource = New stockcapiataDataSet.MovInternoProductosDataTable
        dgvProductos.Columns(5).Visible = False
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        linea = 0
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

    Private Sub btnBuscarProd_Click(sender As Object, e As EventArgs) Handles btnBuscarProd.Click
        Dim cod = txtFiltro.Text
        If cod = "" Then
            MsgBox("Debe ingresar un campo para la búsqueda", MsgBoxStyle.Critical, "Notificación")
            txtFiltro.Focus()
            Exit Sub
        ElseIf cbDeposito.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un Depósito", MsgBoxStyle.Critical, "Notificación")
            Exit Sub
        End If
        Dim deposito = cbDeposito.SelectedItem.item("Código")
        depositoAct = cbDeposito.SelectedItem.item("Descripción")
        depositoActCod = deposito
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
            txtDepositoOrigen.Text = depositoAct
            lblTituloDetalle.Text = "PRODUCTOS DEL MOVIMIENTO"
            Me.ResumeLayout()
        Else
            MsgBox("Seleccione un producto!", MsgBoxStyle.Critical, "Notificación")
        End If

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
            'row("Superficie") = 0
            row("Depósito Origen") = txtDepositoOrigen.Text
            row("Depósito Codigo") = depositoActCod
            tablaaux.Rows.Add(row)
            dgvProductos.DataSource = tablaaux
            dgvProductos.ClearSelection()
        Else
            MsgBox("La cantidad supera al stock disponible", MsgBoxStyle.Critical, "Notificación")
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

    Private Sub btnEliminarProd_Click(sender As Object, e As EventArgs) Handles btnEliminarProd.Click


        If dgvProductos.RowCount <> 0 Then
                Dim index = dgvProductos.CurrentRow.Index
                Dim row = dgvProductos.CurrentRow

                Dim i As Integer
                For i = index + 1 To dgvProductos.RowCount - 1
                    dgvProductos.Item(2, i).Value = dgvProductos.Item(2, i).Value - 1
                    linea = linea - 1
                Next
                dgvProductos.Rows.Remove(row)
            Else
                MsgBox("Lista ya vacia ", MsgBoxStyle.Critical, "No se pudo eliminar")
            End If


    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub btnGuardarMov_Click(sender As Object, e As EventArgs) Handles btnGuardarMov.Click
        Dim validar = validarMovimiento()
        If validar = "ok" Then
            Dim mov As New BackEnd.MovimientoInterno
            If rbEntrada.Checked Then
                mov.tipo = "Entrada"
            ElseIf rbSalida.Checked Then
                mov.tipo = "Salida"
            End If

            mov.nroMov = txtNroOperacion.Text

            mov.solicitante = cbSolicitante.SelectedItem.item("Nombre")
            mov.proveedor = cbProveedor.SelectedItem.item("Código")
            mov.autorizado = cbAutorizador.SelectedItem
            mov.fecha = dpFechaMov.Value
            mov.fechaIns = Date.Now
            movInt.guardar(mov, dgvProductos.Rows)
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
                Me.DialogResult = DialogResult.OK
            End If

        ElseIf validar = "0" Then
            MsgBox("Debe selecionar un tipo de movimiento", MsgBoxStyle.Critical, "Notificación")
            gbTipoMov.Focus()
        ElseIf validar = "1" Then
            MsgBox("Debe ingresar un Nro. de operación", MsgBoxStyle.Critical, "Notificación")
            txtNroOperacion.Focus()
        ElseIf validar = "2" Then
            MsgBox("Debe Seleccionar un solicitante", MsgBoxStyle.Critical, "Notificación")
            cbSolicitante.Focus()
        ElseIf validar = "3" Then
            MsgBox("No agrego ningún producto al movimiento", MsgBoxStyle.Critical, "Notificación")
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
        ElseIf dgvProductos.RowCount = 0 Then
            Return "3"
        End If
        Return resultado
    End Function

    Private Sub rbEntrada_CheckedChanged(sender As Object, e As EventArgs) Handles rbEntrada.CheckedChanged, rbSalida.CheckedChanged
        If rbEntrada.Checked Then
            cbSolicitante.Enabled = False
            cbSolicitante.SelectedIndex = cbSolicitante.FindString("Madame Lynch").ToString
            cbProveedor.Enabled = True

        ElseIf rbSalida.Checked Then
            cbSolicitante.Enabled = True
            cbProveedor.SelectedIndex = cbProveedor.FindString("Madame Lynch").ToString
            cbProveedor.Enabled = False
        End If
    End Sub
    Private Sub soloAdmiteNumeros(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        'soloNumeros(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub pnlDatosMov_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatosMov.Paint

    End Sub

    Private Sub pnlDatosProducto_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatosProducto.Paint

    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub

    Private Sub pnlBusqueda_Paint(sender As Object, e As PaintEventArgs) Handles pnlBusqueda.Paint

    End Sub

    Private Sub pnlGuardarMov_Paint(sender As Object, e As PaintEventArgs) Handles pnlGuardarMov.Paint

    End Sub
End Class