Imports BackEnd

Public Class ModificarProveedor
    Private codigo As String
    Private modelo As Proveedor
    Private daoProv As New ProveedorDAO
    Public Sub New(ByVal item As String)
        InitializeComponent() ' This call is required by the Windows Form Designer.
        codigo = item
    End Sub

    Private Sub ModificarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        Try
            backgroundElementos()
            modelo = daoProv.obtenerProveedor(codigo)
            txtNombre.Text = modelo.descripcion
            txtRUC.Text = modelo.ruc
            txtTel.Text = modelo.tel
            txtContacto.Text = modelo.contacto
            txtNombre.Focus()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Me.ResumeLayout()
    End Sub

    Private Sub backgroundElementos()
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
        Panel1.BackColor = Color.FromArgb(80, Color.Black)
        Panel2.BackColor = Color.FromArgb(80, Color.Black)

    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        txtNombre.Text = modelo.descripcion
        txtRUC.Text = modelo.ruc
        txtTel.Text = modelo.tel
        txtContacto.Text = modelo.contacto
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then
                Dim modelo2 As New Proveedor
                modelo2.descripcion = txtNombre.Text
                modelo2.codigo = codigo
                modelo2.contacto = txtContacto.Text
                modelo2.ruc = txtRUC.Text
                modelo2.tel = txtTel.Text
                daoProv.actualizarProveedor(modelo2)
                MsgBox("Proveedor Modificado!", MsgBoxStyle.Information, "Notificación")
            Else
                MsgBox("Debe llenar todos los campos!", MsgBoxStyle.Exclamation, "Atención")
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Private Function validarDatos()

        If txtNombre.Text = "" Then
            Return False
        ElseIf txtRUC.Text = "" Then
            Return False
        ElseIf txtTel.Text = "" Then
            Return False
        ElseIf txtContacto.Text = "" Then
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    Private Sub Panel1_Paint1(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Panel1.BorderStyle = BorderStyle.None

        e.Graphics.DrawRectangle(Pens.White,
                                 e.ClipRectangle.Left,
                                 e.ClipRectangle.Top,
                                 e.ClipRectangle.Width - 1,
                                 e.ClipRectangle.Height - 1)
    End Sub
End Class