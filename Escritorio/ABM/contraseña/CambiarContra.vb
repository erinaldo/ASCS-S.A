Imports BackEnd

Public Class CambiarContra

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If validarDatos() Then
            Dim daoUsu As New UsuarioDAO
            Dim resultado = daoUsu.cambiarContra(txtActual.Text, txtNueva.Text, txtNueva2.Text)
            MsgBox(resultado)
            Me.DialogResult = DialogResult.OK
        Else
            MsgBox("Debe llenar todos los campos!", MsgBoxStyle.Critical, "Atención")

        End If

    End Sub

    Private Function validarDatos()
        If txtActual.Text <> "" And txtNueva.Text <> "" And txtNueva2.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub CambiarContra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        pnlContra.Left = (Me.ClientSize.Width / 2) - (pnlContra.Width / 2)
        pnlContra.BackColor = Color.FromArgb(80, Color.Black)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
        Me.ResumeLayout()
    End Sub
End Class