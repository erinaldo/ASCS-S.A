Imports BackEnd

Public Class MovimientoInterno
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
    End Sub

    Private Sub prepararElementos()
        cbSolicitante.DataSource = VariablesUtiles.sucursales
        Dim prov = movInt.CargaProv()
        cbProveedor.DataSource = prov.Tables("tabla")
        cbProveedor.DisplayMember = "Descripción"
        cbProveedor.ValueMember = "Código"
        dgvProductos.DataSource = New stockcapiataDataSet.MovInternoProductosDataTable
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub backgroundElementos()
        pnlDatosMov.BackColor = Color.FromArgb(80, Color.Black)
        pnlDatosProducto.BackColor = Color.FromArgb(80, Color.Black)
        lblTitulo.BackColor = Color.FromArgb(80, Color.Black)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
    End Sub

    Private Sub btnBuscarProd_Click(sender As Object, e As EventArgs) Handles btnBuscarProd.Click
        Dim cod = txtCodProd.Text
        Try
            Dim producto = movInt.BuscarProd(cod)
            If producto.codigo = "" Then
                MsgBox("Producto no encontrado. Re inserte código", MsgBoxStyle.Critical, "Notificación")
                txtCodProd.Focus()
                Exit Sub
            End If
            txtCodProd.Text = Producto.codigo
            txtDescripcionProd.Text = producto.descripcion
            txtDescripcionProd.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class