Imports BackEnd
Public Class login

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Application.Exit()

    End Sub

    
    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        conexion()
    End Sub


    Private Sub conexion()
        Try
            Dim conectar As New Acceso
            conectar.login(Me.txtUsuario.Text, Me.txtPasswd.Text)
            Me.Visible = False
            Dim mdi As New Inicio
            mdi.Show()
        Catch ex As Exception

            Me.lbAdvertencia.Visible = True

            Me.txtUsuario.Text = ""
            Me.txtPasswd.Text = ""
            Me.txtUsuario.Focus()
        End Try
    End Sub

   
    Private Sub txtPasswd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPasswd.KeyDown
        If e.KeyCode = Keys.Enter Then
            conexion()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
