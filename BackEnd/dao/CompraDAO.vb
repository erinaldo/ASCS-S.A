Imports BackEnd
Imports MySql.Data.MySqlClient

Public Class CompraDAO

    Function carga(ByVal inicio As Date, ByVal fin As Date) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT * from Views.cargaCompras"

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

    Public Function cargaDeposito() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT depoCod as Código, depoDescripcion as Descripción " _
                        & "FROM stdeposito"

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

    Public Function BuscarProd(cod As String) As Producto
        Dim tmp As New ProductoDAO
        Return tmp.obtenerProducto(cod)
    End Function

    Public Function CargaProv() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT `provCodigo` as `Código`, `provDescripcion` as Descripción " _
                        & "FROM stockcapiata.`stproveedor`"

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

    Public Sub guardarCompra(compra As Compra)
        Try
            compra.userInsert = Sesion.Usuario
            Dim mysql = "INSERT INTO `stockcapiata`.`stcompras` ( `comprasCod`, `comprasFechaFact`, `comprasNroFactura`, `comprasObs`, `comprasSaldo`, `comprasTipoFact`, `provCodigo`, `comprasUsrIns`, `comprasFechaIns` ) " _
                       & "VALUES (@cod,@fechaFact,@nroFact,@obs,@saldo,@tipo,@prov,@userIns,@fechaIns)"
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim sqlcmd As New MySqlCommand(mysql, con)
            sqlcmd.Parameters.AddWithValue("@cod", compra.nroFactura)
            sqlcmd.Parameters.AddWithValue("@fechaFact", compra.fechaFactura)
            sqlcmd.Parameters.AddWithValue("@nroFact", compra.nroFactura)
            sqlcmd.Parameters.AddWithValue("@obs", compra.comentario)
            sqlcmd.Parameters.AddWithValue("@saldo", compra.saldo)
            sqlcmd.Parameters.AddWithValue("@tipo", compra.tipo)
            sqlcmd.Parameters.AddWithValue("@prov", compra.proveedor)
            sqlcmd.Parameters.AddWithValue("@userIns", compra.userInsert)
            sqlcmd.Parameters.AddWithValue("@fechaIns", compra.fechaInsFactura)

            sqlcmd.ExecuteNonQuery()

            Dim queryDetalle = "INSERT INTO `stockcapiata`.`stcomprasdet` ( `comprasCod`, `codigo_base`, `comprasCosto`, `comprasImpExcente`, `comprasImp5`, `comprasImp10`, `comprasCanitad` )" _
                                & "VALUE(@cod,@codBase,@costo,@impEx,@imp5,@imp10,@cant)"

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub
End Class
