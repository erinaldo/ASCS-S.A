Imports System.Windows.Forms
Imports BackEnd
Imports MySql.Data.MySqlClient

Public Class MovInternoDAO
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
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds

    End Function

    Public Function cargaSucursales() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT `sucCod` as Código, `sucNombre` as Nombre FROM `stsucursales` "

            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds

    End Function
    Public Function CargaProv() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT `provCodigo` as `Código`, `provDescripcion` as Descripción " _
                        & "FROM `stproveedor`"
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function BuscarProd(cod As String) As Producto
        Dim tmp As New ProductoDAO
        Return tmp.obtenerProducto(cod)
    End Function

    Public Function BuscarProducts(cod As String) As DataSet
        Dim tmp As New ProductoDAO
        Return tmp.obtenerProductos(cod)
    End Function

    Public Sub guardar(mov As MovimientoInterno, productos As DataGridViewRowCollection)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query = "INSERT INTO `stmovinterno` (`movNro`, `movEstado`, `movFecha`," _
                & "`movSolicitado`, `movAutorizado`, `provCodigo`, `movLineaNro`, `prodCodigo`, `movCantidad`," _
                & "`movTipo`, `movUsrIns`, `movFchIns`) " _
                & "VALUES(@nro,@estado,@fecha,@solicita,@autoriza,@prov,@linea,@prodCod,@cantidad,@tipo,@user,@fechaIns)"

            Dim cmd As New MySqlCommand(query, con)

            For Each row As Windows.Forms.DataGridViewRow In productos
                Dim codProd = row.Cells("Código").Value
                Dim linea = row.Cells("Línea").Value

                Dim cant = row.Cells("Cantidad").Value
                cmd.Parameters.AddWithValue("@nro", mov.nroMov)
                cmd.Parameters.AddWithValue("@estado", "ACTI")
                cmd.Parameters.AddWithValue("@fecha", mov.fecha)
                cmd.Parameters.AddWithValue("@solicita", mov.solicitante)
                cmd.Parameters.AddWithValue("@autoriza", mov.autorizado)
                cmd.Parameters.AddWithValue("@prov", mov.proveedor)
                cmd.Parameters.AddWithValue("@linea", linea)
                cmd.Parameters.AddWithValue("@prodCod", codProd)
                cmd.Parameters.AddWithValue("@cantidad", cant)
                cmd.Parameters.AddWithValue("@tipo", mov.tipo)
                cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
                cmd.Parameters.AddWithValue("@fechaIns", Date.Now)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()

            Next
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try


    End Sub
End Class
