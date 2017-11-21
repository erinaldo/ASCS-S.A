Imports BackEnd

Public Class DetalleMovimiento
    Dim codigo = ""
    Dim movInt As New MovInternoDAO
    Dim modelo As New BackEnd.MovimientoInterno
    Public Sub New(ByVal item As String)
        InitializeComponent() ' This call is required by the Windows Form Designer.
        codigo = item
    End Sub
    Private Sub DetalleMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        centrarElementos()
        prepararElementos()
        backgroundElementos()
        Me.ResumeLayout()

    End Sub

    Private Sub centrarElementos()
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        pnlDatosMov.Left = (Me.ClientSize.Width / 2) - (pnlDatosMov.Width / 2)
        dgvProductos.Left = (Me.ClientSize.Width / 2) - (dgvProductos.Width / 2)
        pnlOperadores.Left = pnlDatosMov.Right - pnlOperadores.Width
        dgvProductos.Visible = True
    End Sub

    Private Sub prepararElementos()
        txtNroOperacion.Text = codigo
        Dim modelo2 = movInt.cargaMov(codigo)
        modelo = modelo2
        txtAutorizado.Text = modelo2.autorizado
        txtFecha.Text = modelo2.fecha.ToShortDateString
        Dim soli = modelo2.solicitante

        txtSolicita.Text = soli

        txtTipo.Text = modelo2.tipo
        txtProveedor.Text = movInt.buscarSolicitante(modelo2.proveedor)
        Dim listado = movInt.cargarDetalle(codigo)
        dgvProductos.DataSource = listado.Tables("tabla")
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub backgroundElementos()
        pnlDatosMov.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperadores.BackColor = Color.FromArgb(80, Color.Black)
        lblTitulo.BackColor = Color.FromArgb(80, Color.Black)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtProveedor.TextChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim reporte As New Reporte
        reporte.codigoCompra = codigo
        reporte.tipo = "movInt"
        reporte.movInt = modelo
        reporte.ShowDialog()
        reporte.Dispose()
    End Sub
End Class