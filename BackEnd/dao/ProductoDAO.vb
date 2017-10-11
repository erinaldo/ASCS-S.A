﻿Imports MySql.Data.MySqlClient

Public Class ProductoDAO

    'carga de productos
    Public Function cargar() As DataSet
        Dim productos As New Collection
        Dim modelo As New Producto
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
           

            Dim mysql = "SELECT `prodCodigo` as `Código`,`prodDescripcion` as `Descripción`,`prodStockMinimo` as `Stock`,`prodTipo` as `Tipo` FROM `stockcapiata`.`stproductos`"
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



    Public Sub agregarProducto(ByVal modelo As Producto)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim da As New MySqlDataAdapter
            'Dim mysql As String = "INSERT INTO stproductos(prodCodigo,prodDescripcion,prodEspesor,prodLargo,prodAlto,prodM2,prodColor,tprodCod)"
            'mysql += " VALUES ('" & modelo.codigo & "','" & modelo.descripcion & "'," & modelo.espesor & "," & modelo.largo & "," & modelo.alto & "," & modelo.m2 & ",'" & modelo.color & "','" & modelo.tipo & "')"
            'MsgBox(mysql)


            Dim query As String = "INSERT INTO stproductos(prodCodigo,prodDescripcion,prodEspesor,prodLargo,prodAlto,prodM2,prodColor,prodTipo,prodVenta,prodStockMinimo)" _
                            & "VALUES (@cod,@desc,@espesor,@largo,@alto,@m2,@color,@tipo,@venta,@stock)"
            Dim sqlcmd As New MySqlCommand(query, con)
            sqlcmd.Parameters.AddWithValue("@cod", modelo.codigo)
            sqlcmd.Parameters.AddWithValue("@desc", modelo.descripcion)
            sqlcmd.Parameters.AddWithValue("@espesor", modelo.espesor)
            sqlcmd.Parameters.AddWithValue("@largo", modelo.largo)
            sqlcmd.Parameters.AddWithValue("@alto", modelo.alto)
            sqlcmd.Parameters.AddWithValue("@m2", modelo.m2)
            sqlcmd.Parameters.AddWithValue("@color", modelo.color)
            sqlcmd.Parameters.AddWithValue("@tipo", modelo.tipo)
            sqlcmd.Parameters.AddWithValue("@venta", modelo.venta)
            sqlcmd.Parameters.AddWithValue("@stock", modelo.stock)



            sqlcmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try
    End Sub

    Public Function cargarBusqueda(ByVal criterio As Integer, ByVal regla As String) As DataSet
        Dim productos As New Collection
        Dim modelo As New Producto
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

                query = "SELECT prodCodigo as Código, prodDescripcion as Descripción,prodStockMinimo as Stock,prodTipo as Tipo " _
                            & "from stproductos where prodCodigo = @codigo "
                dbcomm = New MySqlCommand(query, con)
                dbcomm.Parameters.AddWithValue("@codigo", regla)

            ElseIf criterio = 1 Then

                query = "SELECT prodCodigo AS 'Código', prodDescripcion AS 'Descripción',prodStockMinimo AS 'Stock',prodTipo AS 'Tipo'" _
                        & " from stproductos where prodTipo = @tipo "
                dbcomm = New MySqlCommand(query, con)
                dbcomm.Parameters.AddWithValue("@tipo", regla)
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

    Public Function obtenerProducto(ByVal codigo As String) As Producto
        Dim modelo As New Producto
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from stProductos where prodCodigo = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", codigo)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.codigo = reader.GetString(0)
                modelo.descripcion = reader.GetString(1)
                modelo.espesor = reader.GetDecimal(2)
                modelo.largo = reader.GetDecimal(3)
                modelo.alto = reader.GetDecimal(4)
                modelo.m2 = reader.GetDecimal(5)
                modelo.venta = reader.GetDouble(6)
                modelo.color = reader.GetString(7)
                modelo.stock = reader.GetInt16(8)
                modelo.tipo = reader.GetString(9)

            End While

            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return modelo
    End Function

    Public Sub actualizarProducto(ByVal modelo As Producto)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE stProductos set prodDescripcion = @desc, prodEspesor = @espesor, " _
                        & " prodLargo = @largo,prodAlto = @alto, prodM2 = @m2,prodVenta= @venta,prodColor = @color," _
                        & " prodStockMinimo = @stock, prodTipo= @tipo where prodCodigo = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", modelo.codigo)
            cmd.Parameters.AddWithValue("@desc", modelo.descripcion)
            cmd.Parameters.AddWithValue("@espesor", modelo.espesor)
            cmd.Parameters.AddWithValue("@largo", modelo.largo)
            cmd.Parameters.AddWithValue("@alto", modelo.alto)
            cmd.Parameters.AddWithValue("@m2", modelo.m2)
            cmd.Parameters.AddWithValue("@venta", modelo.venta)
            cmd.Parameters.AddWithValue("@color", modelo.color)
            cmd.Parameters.AddWithValue("@stock", modelo.stock)
            cmd.Parameters.AddWithValue("@tipo", modelo.tipo)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Producto Modificado!")
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub
End Class
