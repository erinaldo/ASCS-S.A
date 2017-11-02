Imports MySql.Data.MySqlClient

Public Class ProveedorDAO

    Function cargar() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT `provCodigo` as `Código`, `provDescripcion` as Descripción,`provRuc` as RUC, provTelef as Teléfono, " _
                        & "provContacto as Contacto,provUsuario as Usuario, provFechaIns as Fecha FROM stockcapiata.`stproveedor`"

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

    Public Sub agregar(ByVal modelo As Proveedor)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            modelo.usuarioP = Sesion.Usuario
            MsgBox(modelo.descripcion)
            Dim query As String = "INSERT INTO stProveedor(provDescripcion,provRuc,provTelef,provContacto,provUsuario,provFechaIns)" _
                            & "VALUES (@nombre,@ruc,@tel,@contacto,@usuario,@fecha)"
            Dim sqlcmd As New MySqlCommand(query, con)
            sqlcmd.Parameters.AddWithValue("@nombre", modelo.descripcion)
            sqlcmd.Parameters.AddWithValue("@ruc", modelo.ruc)
            sqlcmd.Parameters.AddWithValue("@tel", modelo.tel)
            sqlcmd.Parameters.AddWithValue("@contacto", modelo.contacto)
            sqlcmd.Parameters.AddWithValue("@usuario", modelo.usuarioP)
            sqlcmd.Parameters.AddWithValue("@fecha", modelo.fecha)

            sqlcmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Function obtenerProveedor(ByVal codigo As String) As Proveedor
        Dim modelo As New Proveedor
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from stProveedor where provCodigo = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", codigo)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.codigo = SafeGetInt(reader, 0)
                modelo.descripcion = SafeGetString(reader, 1)
                modelo.ruc = SafeGetString(reader, 6)
                modelo.tel = SafeGetString(reader, 2)
                modelo.contacto = SafeGetString(reader, 3)
                modelo.usuarioP = SafeGetString(reader, 4)
                Dim tmp = SafeGetDate(reader, 5)

                modelo.fecha = tmp

            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return modelo
    End Function



    Sub actualizarProveedor(ByVal modelo As Proveedor)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE stproveedor set provDescripcion = @nombre,provRuc = @ruc,provTelef = @tel,provContacto = @contacto" _
                        & " where provCodigo = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", modelo.codigo)
            cmd.Parameters.AddWithValue("@nombre", modelo.descripcion)
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
                query = "SELECT `provCodigo` as `Código`, `provDescripcion` as Descripción,`provRuc` as RUC, provTelef as Teléfono, " _
                            & "provContacto as Contacto,provUsuario as Usuario, provFechaIns as Fecha FROM stockcapiata.`stproveedor` " _
                            & "where provDescripcion LIKE CONCAT('%',@nombre,'%')"
                dbcomm = New MySqlCommand(query, con)
                dbcomm.Parameters.AddWithValue("@nombre", regla)

            ElseIf criterio = 1 Then
                query = "SELECT `provCodigo` as `Código`, `provDescripcion` as Descripción,`provRuc` as RUC, provTelef as Teléfono, " _
                            & "provContacto as Contacto,provUsuario as Usuario, provFechaIns as Fecha FROM stockcapiata.`stproveedor` " _
                            & "where provRuc = @ruc"
                dbcomm = New MySqlCommand(query, con)
                dbcomm.Parameters.AddWithValue("@ruc", regla)
            ElseIf criterio = 2 Then
                query = "SELECT `provCodigo` as `Código`, `provDescripcion` as Descripción,`provRuc` as RUC, provTelef as Teléfono, " _
                            & "provContacto as Contacto,provUsuario as Usuario, provFechaIns as Fecha FROM stockcapiata.`stproveedor` " _
                            & "where provContacto LIKE CONCAT('%',@contacto,'%')"
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


End Class
