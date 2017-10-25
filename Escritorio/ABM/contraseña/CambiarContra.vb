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
End Class