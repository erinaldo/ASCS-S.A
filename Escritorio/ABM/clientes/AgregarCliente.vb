Imports BackEnd

Public Class AgregarCliente




    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If validarDatos() Then
            Dim modelo As New Cliente
            Dim clienteDAO As New ClienteDAO
            modelo.nombre = txtNombre.Text
            modelo.ruc = txtRUC.Text
            modelo.tel = txtTel.Text
            modelo.contacto = txtContacto.Text
            clienteDAO.agregar(modelo)
            MsgBox("Cliente Agregado!", MsgBoxStyle.Information, "Notificación")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("Debe llenar todos los campos!", MsgBoxStyle.Exclamation, "Atención")
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If

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

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        backgroundElementos()
        Me.ResumeLayout()
    End Sub

    Private Sub backgroundElementos()
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
        Panel1.BackColor = Color.FromArgb(80, Color.Black)
        Panel2.BackColor = Color.FromArgb(80, Color.Black)

    End Sub
End Class