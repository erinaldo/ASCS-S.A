Imports MySql.Data.MySqlClient

Public Class UsuarioDAO
    Function cambiarContra(ByVal actual As String, ByVal nueva As String, ByVal nueva2 As String) As String
        Dim res As String = ""
        If actual = Sesion.Password And nueva = nueva2 Then
            Try
                'aqui se debe especificaru
                Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD2(Sesion.Usuario, Sesion.Password))
                con.Open()

                Dim query = "SET PASSWORD FOR '" + Sesion.Usuario + "'@'localhost' = PASSWORD('" + nueva + "');"
                Dim cmd As New MySqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Sesion.Password = nueva
                res = "Contraseña Cambiada!"
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            res = "Contraseñas no coinciden"
        End If
        Return res
    End Function


End Class