Imports MySql.Data.MySqlClient

Public Class Acceso
    Public Sub login(ByVal user As String, ByVal passwd As String)

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(user, passwd))
            con.Open()
            MsgBox("Conexión exitosa!")
            con.Close()
            Sesion.Usuario = user
            Sesion.Password = passwd

        Catch ex As Exception
            Throw New DAOException("Conexion sin éxito")
        End Try
    End Sub
End Class
