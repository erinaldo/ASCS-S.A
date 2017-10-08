Imports MySql.Data.MySqlClient

Public Class ProductoDAO

    'carga de productos
    Public Function cargar() As DataSet
        Dim productos As New Collection
        Dim modelo As New Producto
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("samuel", "system"))
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


            Dim query As String = "INSERT INTO stproductos(prodCodigo,prodDescripcion,prodEspesor,prodLargo,prodAlto,prodM2,prodColor,prodTipo)" & vbCrLf & _
                            "VALUES (@cod,@desc,@espesor,@largo,@alto,@m2,@color,@tipo)"
            Dim sqlcmd As New MySqlCommand(query, con)
            sqlcmd.Parameters.AddWithValue("@cod", modelo.codigo)
            sqlcmd.Parameters.AddWithValue("@desc", modelo.descripcion)
            sqlcmd.Parameters.AddWithValue("@espesor", modelo.espesor)
            sqlcmd.Parameters.AddWithValue("@largo", modelo.largo)
            sqlcmd.Parameters.AddWithValue("@alto", modelo.alto)
            sqlcmd.Parameters.AddWithValue("@m2", modelo.m2)
            sqlcmd.Parameters.AddWithValue("@color", modelo.color)
            sqlcmd.Parameters.AddWithValue("@tipo", modelo.tipo)

            sqlcmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try
    End Sub
End Class
