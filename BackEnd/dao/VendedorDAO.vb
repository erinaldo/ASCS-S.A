Imports MySql.Data.MySqlClient

Public Class VendedorDAO
    Public Function cargar() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT venCod as Código, venNombreApellido as Nombre, venTelefono as Teléfono,venEstado as Estado, venPorcentaje as Porcentaje FROM stvendedores"

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

    Public Sub agregar(ByVal modelo As Vendedor)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim porcentaje = If(modelo.porcentaje = 0, 1, 0.5)
            Dim query As String = "INSERT INTO stvendedores(venNombreApellido,venPorcentaje,venTelefono,venEstado)" _
                            & "VALUES (@nombre,@porcentaje,@tel,@estado)"
            Dim sqlcmd As New MySqlCommand(query, con)
            sqlcmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            sqlcmd.Parameters.AddWithValue("@porcentaje", porcentaje)
            sqlcmd.Parameters.AddWithValue("@tel", modelo.tel)
            sqlcmd.Parameters.AddWithValue("@estado", modelo.estado)
            sqlcmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Function obtenerVendedor(ByVal codigo As String) As Vendedor
        Dim modelo As New Vendedor
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from stvendedores where venCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", codigo)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.codigo = SafeGetInt(reader, 0)
                modelo.nombre = SafeGetString(reader, 1)
                modelo.porcentaje = SafeGetString(reader, 2)
                modelo.tel = SafeGetString(reader, 3)
                modelo.estado = SafeGetString(reader, 4)
            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return modelo
    End Function

    Sub actualizarVendedor(ByVal modelo As Vendedor)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE stvendedores set venNombreApellido = @nombre, venTelefono = @tel, " _
                        & "venEstado = @Estado, venPorcentaje = @porcentaje where venCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", modelo.codigo)
            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.Parameters.AddWithValue("@porcentaje", modelo.porcentaje)
            cmd.Parameters.AddWithValue("@tel", modelo.tel)
            cmd.Parameters.AddWithValue("@estado", modelo.estado)

            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function cargarBusqueda(ByVal criterio As Integer, ByVal regla As String) As DataSet
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

                query = "SELECT venCod as Código, venNombreApellido as Nombre, venTelefono as Teléfono,venEstado as Estado, venPorcentaje as Porcentaje " _
                            & "from stvendedores where venNombreApellido LIKE CONCAT('%',@nombre,'%') "
                dbcomm = New MySqlCommand(query, con)
                dbcomm.Parameters.AddWithValue("@nombre", regla)

            ElseIf criterio = 1 Then
                query = "SELECT venCod as Código, venNombreApellido as Nombre, venTelefono as Teléfono,venEstado as Estado, venPorcentaje as Porcentaje " _
                             & "from stvendedores where venEstado = @estado"

                dbcomm = New MySqlCommand(query, con)
                dbcomm.Parameters.AddWithValue("@estado", regla)
            ElseIf criterio = 2 Then
                query = "SELECT venCod as Código, venNombreApellido as Nombre, venTelefono as Teléfono,venEstado as Estado, venPorcentaje as Porcentaje " _
                             & "from stvendedores where venPorcentaje = @porcentaje"
                Dim porcentaje = Convert.ToInt16(regla)
                dbcomm = New MySqlCommand(query, con)
                dbcomm.Parameters.AddWithValue("@porcentaje", porcentaje + 1)

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
