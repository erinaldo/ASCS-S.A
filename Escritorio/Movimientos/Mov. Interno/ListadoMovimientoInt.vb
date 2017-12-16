Imports BackEnd

Public Class ListadoMovimientoInt
    Dim movInt As New MovInternoDAO
    Private Sub ListadoMovimientoInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuspendLayout()
        centrarElementos()
        prepararElementos()
        backgroundElementos()
        ResumeLayout()

    End Sub

    Private Sub centrarElementos()
        pnlListado.Left = (Me.ClientSize.Width / 2) - (pnlListado.Width / 2)
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        dgvMovInt.Left = pnlListado.Left
        dgvMovInt.Visible = False
        cbProveedor.Location = txtNroFacturaListado.Location
    End Sub

    Private Sub prepararElementos()

        Dim prov = movInt.CargaProv()
        Dim sucursales = movInt.cargaSucursales()
        Dim sucursales2 = movInt.cargaSucursales()
        cbProveedor.DataSource = sucursales.Tables("tabla")
        cbProveedor.DisplayMember = "Nombre"
        cbProveedor.ValueMember = "Código"
        cbBuscarMovInt.DataSource = VariablesUtiles.busquedaMovInterno
        'cbSolicitante.DataSource = sucursales2.Tables("tabla")
        'cbSolicitante.DisplayMember = "Nombre"
        'cbSolicitante.ValueMember = "Código"

        'cbAutorizador.DataSource = VariablesUtiles.autorizado

        dgvMovInt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'dgvProductos.DataSource = New stockcapiataDataSet.MovInternoProductosDataTable
        'dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'linea = 0
        pnlRangoFecha.Visible = False
        cbProveedor.Visible = False
        btnDetalle.Visible = False
    End Sub

    Private Sub backgroundElementos()
        pnlListado.BackColor = Color.FromArgb(80, Color.Black)
        'pnlDatosProducto.BackColor = Color.FromArgb(80, Color.Black)
        'pnlBusqueda.BackColor = Color.FromArgb(80, Color.Black)
        'pnlGuardarMov.BackColor = Color.FromArgb(80, Color.Black)
        'lblTitulo.BackColor = Color.FromArgb(80, Color.Black)
        'lblTituloDetalle.BackColor = Color.FromArgb(80, Color.Black)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
    End Sub

    Private Sub btnBuscarCompra_Click(sender As Object, e As EventArgs) Handles btnBuscarMov.Click
        Try
            Dim listadoMovs As New DataSet
            If cbBuscarMovInt.SelectedIndex = 0 Then
                Dim filtro = txtNroFacturaListado.Text

                listadoMovs = movInt.buscarMovimiento(filtro, 0, Nothing, Nothing)
            ElseIf cbBuscarMovInt.SelectedIndex = 1 Then
                Dim inicio = datepInicio.Value.Date
                Dim fin = datepFin.Value.Date
                listadoMovs = movInt.buscarMovimiento(Nothing, 1, inicio, fin)
            ElseIf cbBuscarMovInt.SelectedIndex = 2 Then
                Dim filtro = cbProveedor.SelectedItem.item("Nombre")

                listadoMovs = movInt.buscarMovimiento(filtro, 2, Nothing, Nothing)

            End If

            btnDetalle.Visible = True
            btnAnular.Visible = True
            dgvMovInt.DataSource = listadoMovs.Tables("tabla")
            dgvMovInt.Visible = True
            dgvMovInt.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbBuscarMovInt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBuscarMovInt.SelectedIndexChanged
        btnDetalle.Visible = False
        btnAnular.Visible = False
        Me.SuspendLayout()
        If cbBuscarMovInt.SelectedIndex = 0 Then
            pnlRangoFecha.Visible = False
            txtNroFacturaListado.Visible = True
            cbProveedor.Visible = False
            txtNroFacturaListado.Text = ""
            txtNroFacturaListado.Focus()
            lblBusqTxt.Text = "Inserte Nro. Movimiento"
            lblBusqTxt.Visible = True

        ElseIf cbBuscarMovInt.SelectedIndex = 1 Then
            pnlRangoFecha.Visible = True
            txtNroFacturaListado.Visible = False
            cbProveedor.Visible = False
            lblBusqTxt.Visible = False
        ElseIf cbBuscarMovInt.SelectedIndex = 2 Then
            pnlRangoFecha.Visible = False
            txtNroFacturaListado.Visible = False
            cbProveedor.Visible = True
            lblBusqTxt.Text = "Seleccione el proveedor"
            lblBusqTxt.Visible = True
            'txtNroFacturaListado.Focus()
            'ElseIf cbBuscarCompra.SelectedItem = "Proveedor" Then
            '    dpAnularCompra.Visible = False
            '    cbProveedoresAnular.Location = txtNrofacturaAnul.Location
            '    cbProveedoresAnular.Visible = True
            '    txtNrofacturaAnul.Visible = False

        End If
        Me.ResumeLayout()

    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        If dgvMovInt.SelectedRows.Count > 0 Then
            Dim row = dgvMovInt.CurrentRow.Index
            Dim codigo = dgvMovInt.Item(1, row).Value
            Dim detalleForm As New DetalleMovimiento(codigo)

            If dgvMovInt.Item(4, row).Value = "Depósitos" Then
                detalleForm.deposito = 1
            End If
            detalleForm.ShowDialog()
            detalleForm.Dispose()

        Else
                MsgBox("Nigun movimiento seleccionado!", MsgBoxStyle.Critical, "Notificación")
        End If
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try
            If dgvMovInt.SelectedRows.Count > 0 Then
                Dim row = dgvMovInt.CurrentRow.Index
                Dim codigo = dgvMovInt.Item(1, row).Value

                Dim result As Integer = MessageBox.Show("Anular el movimiento " + dgvMovInt.SelectedRows.Count.ToString + " seleccionado?", "caption", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then

                    movInt.anular(codigo)
                    Dim anular = dgvMovInt.CurrentRow
                    dgvMovInt.Rows.Remove(anular)
                    MsgBox("Movimiento Anulado!", MsgBoxStyle.Information, "Notificación")
                End If
            Else
                MsgBox("Nigun movimiento seleccionado!", MsgBoxStyle.Critical, "Notificación")
            End If


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Private Sub txtNroFacturaListado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroFacturaListado.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscarCompra_Click(sender, e)
        End If
    End Sub
End Class