Imports BackEnd

Public Class DetalleMovimiento
    Dim codigo = ""
    Dim movInt As New MovInternoDAO
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
        Dim modelo = movInt.cargaMov(codigo)
        txtAutorizado.Text = modelo.autorizado
        txtFecha.Text = modelo.fecha.ToShortDateString
        txtSolicita.Text = modelo.solicitante
        txtTipo.Text = modelo.tipo
        txtProveedor.Text = modelo.proveedor
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
End Class