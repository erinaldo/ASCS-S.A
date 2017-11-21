Imports BackEnd

Public Class ModificarProducto
    Private codigo As String
    Dim modelo As New Producto
    Dim daoProd As New ProductoDAO
    Public Sub New(ByVal item As String)
        InitializeComponent() ' This call is required by the Windows Form Designer.
        codigo = item
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If validarParametros() Then
            Dim modelo2 As New Producto
            modelo2.codigo = txtCod.Text
            modelo2.descripcion = txtDesc.Text
            modelo2.espesor = txtEspesor.Text
            modelo2.alto = txtAlto.Text
            modelo2.largo = txtLargo.Text
            modelo2.m2 = txtM2.Text
            modelo2.color = cbColor.SelectedItem
            modelo2.stock = txtStock.Text
            modelo2.venta = txtPrecio.Text
            modelo2.tipo = cbTipo.SelectedItem
            daoProd.actualizarProducto(modelo2)
        Else
            MsgBox("Debe completar todos lo campos", MsgBoxStyle.Exclamation, "Atención")
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    
    ' ---------------------------- Carga del Formulario ---------------------------------
    Private Sub ModificarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SuspendLayout()
            backgroundElementos()
            modelo = daoProd.obtenerProducto(codigo)
            txtCod.Text = modelo.codigo
            txtAlto.Text = modelo.alto
            txtDesc.Text = modelo.descripcion
            txtEspesor.Text = modelo.espesor
            txtLargo.Text = modelo.largo
            txtM2.Text = modelo.m2
            txtPrecio.Text = modelo.venta
            cbTipo.SelectedItem = modelo.tipo
            Dim color = VariablesUtiles.colores.Item(modelo.color)
            cbColor.DataSource = VariablesUtiles.colores
            cbColor.SelectedItem = color
            txtStock.Text = modelo.stock
            Me.ResumeLayout()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Private Sub backgroundElementos()
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
        Panel1.BackColor = Color.FromArgb(80, Color.Black)
        Panel2.BackColor = Color.FromArgb(80, Color.Black)
        Panel3.BackColor = Color.FromArgb(80, Color.Black)
        Label2.BackColor = Color.FromArgb(80, Color.Black)
    End Sub
    ' ---------------------------- Cancelar modificación ---------------------------------
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    ' ---------------------------- Botón Retornar a datos originales ---------------------------------
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        txtCod.Text = modelo.codigo
        txtAlto.Text = modelo.alto
        txtDesc.Text = modelo.descripcion
        txtEspesor.Text = modelo.espesor
        txtLargo.Text = modelo.largo
        txtM2.Text = modelo.m2
        txtPrecio.Text = modelo.venta
        cbTipo.SelectedItem = modelo.tipo
        Dim color = VariablesUtiles.colores.Item(modelo.color)
        cbColor.SelectedItem = color
        txtStock.Text = modelo.stock
    End Sub

    ' ---------------------------- Validación de campos ---------------------------------
    Private Function validarParametros()
        Dim validar As Boolean = True

        If txtAlto.Text = "" Then
            Return False
        ElseIf txtCod.Text = "" Then
            Return False
        ElseIf cbColor.SelectedItem = "" Then
            Return False
        ElseIf txtDesc.Text = "" Then
            Return False
        ElseIf txtEspesor.Text = "" Then
            Return False
        ElseIf txtLargo.Text = "" Then
            Return False
        ElseIf txtM2.Text = "" Then
            Return False
        ElseIf cbTipo.SelectedItem = "" Then
            Return False
        End If

        Return True

    End Function

    Private Sub Panel1_Paint1(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Panel1.BorderStyle = BorderStyle.None

        e.Graphics.DrawRectangle(Pens.White,
                                 e.ClipRectangle.Left,
                                 e.ClipRectangle.Top,
                                 e.ClipRectangle.Width - 1,
                                 e.ClipRectangle.Height - 1)
    End Sub
End Class