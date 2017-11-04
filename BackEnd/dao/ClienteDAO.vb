Imports MySql.Data.MySqlClient

Public Class ClienteDAO
    Public Function cargar() As DataSet
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT `clieCod` as `Código`, `clieNombre` as Nombre,`clieRuc` as RUC, clieTelef as Teléfono,clieContacto as Contacto FROM `stclientes`"

            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


            'While dr.Read
            ' modelo.codigo = dr(0).ToString
            ' modelo.descripcion = dr(1).ToString
            '  modelo.stock = dr(2).ToString
            '  modelo.tipo = dr(3).ToString


            '  productos.Add(modelo)


            ' a += 1
            '  End While
            ' MsgBox(a)

            ' dr.Close()
            'con.Close()


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Sub agregar(ByVal modelo As Cliente)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query As String = "INSERT INTO stclientes(clieNombre,clieRuc,clieTelef,clieContacto)" & vbCrLf & _
                            "VALUES (@nombre,@ruc,@tel,@contacto)"
            Dim sqlcmd As New MySqlCommand(query, con)
            sqlcmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            sqlcmd.Parameters.AddWithValue("@ruc", modelo.ruc)
            sqlcmd.Parameters.AddWithValue("@tel", modelo.tel)
            sqlcmd.Parameters.AddWithValue("@contacto", modelo.contacto)

            sqlcmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Function obtenerCliente(ByVal codigo As String) As Cliente
        Dim modelo As New Cliente
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from stClientes where clieCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", codigo)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.nombre = SafeGetInt(reader, 0)
                modelo.ruc = SafeGetString(reader, 2)
                modelo.tel = SafeGetString(reader, 3)
                modelo.contacto = SafeGetString(reader, 4)
            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return modelo
    End Function

    Sub actualizarCliente(ByVal modelo As Cliente)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE stClientes set clieCod = @codigo, clieNombre = @nombre, clieRuc = @ruc, " _
                        & "clieTelef = @tel, clieContacto = @contacto where clieCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", modelo.codigo)
            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.Parameters.AddWithValue("@ruc", modelo.ruc)
            cmd.Parameters.AddWithValue("@tel", modelo.tel)
            cmd.Parameters.AddWithValue("@contacto", modelo.contacto)

            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function cargarBusqueda(ByVal criterio As Integer, ByVal regla As String) As DataSet
        Dim clientes As New Collection
        Dim modelo As New Cliente
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = ""
            'Dim cmd As New MySqlCommand(query, con)


            Dim dbcomm As New MySqlCommand
            If criterio = 0 Then
                query = "SELECT clieCod as Código, clieNombre as Nombre,clieRuc as RUC,clieTelef as Teléfono, " _
                            & "clieContacto as Contacto from stclientes where clieNombre LIKE CONCAT('%',@nombre,'%') "
                dbcomm = New MySqlCommand(query, con)
                dbcomm.Parameters.AddWithValue("@nombre", regla)

            ElseIf criterio = 1 Then
                query = "SELECT clieCod as Código, clieNombre as Nombre,clieRuc as RUC,clieTelef as Teléfono, " _
                            & "clieContacto as Contacto from stclientes where clieRuc = @ruc "
                dbcomm = New MySqlCommand(query, con)
                dbcomm.Parameters.AddWithValue("@ruc", regla)
            ElseIf criterio = 2 Then
                query = "SELECT clieCod as Código, clieNombre as Nombre,clieRuc as RUC,clieTelef as Teléfono, " _
                            & "clieContacto as Contacto from stclientes where clieContacto LIKE CONCAT('%',@contacto,'%') "
                dbcomm = New MySqlCommand(query, con)
                dbcomm.Parameters.AddWithValue("@contacto", regla)

            End If


            Dim adp As New MySqlDataAdapter(dbcomm)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Sub eliminar(ByVal eliminar As Windows.Forms.DataGridViewSelectedRowCollection, ByVal seleccionados As Integer)

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "DELETE FROM stclientes WHERE clieCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            Dim cod As String


            For i As Integer = 0 To seleccionados - 1

                cod = eliminar(i).DataBoundItem(0)
                cmd.Parameters.AddWithValue("@codigo", cod)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()

            Next
            con.Close()
            MsgBox("Se han eliminado " + seleccionados.ToString + " cliente/s correctamente", MsgBoxStyle.Information, "Notificación")
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub
End Class
