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

    Public Function cargaMov(ByVal codigo As String) As MovimientoInterno
        Dim modelo As New MovimientoInterno
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim query = "SELECT * FROM stmovinterno WHERE `movNro` = @cod LIMIT 1"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", codigo)
            Dim reader = cmd.ExecuteReader()

            If reader.Read Then
                modelo.nroMov = codigo
                modelo.fecha = SafeGetDate(reader, 3)
                modelo.solicitante = SafeGetString(reader, 4)
                modelo.proveedor = SafeGetInt(reader, 6)
                modelo.autorizado = SafeGetString(reader, 5)
                modelo.tipo = SafeGetString(reader, 10)
            End If
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return modelo
    End Function
    Public Function cargarDetalle(codigo As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim query = "SELECT * FROM detallemovintproductosview WHERE `MovNro` = @cod ORDER BY Linea"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", codigo)
            Dim adp As New MySqlDataAdapter(cmd)
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

    Public Sub anular(codigo As String)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim query = "UPDATE stmovinterno SET movEstado = 'ANUL' WHERE movNro = " & codigo & ""
            Dim cmd As New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
    End Sub

    Public Function buscarMovimiento(ByVal filtro As String, ByVal tipo As Integer, ByVal inicio As Date, ByVal fin As Date)
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim query = ""

            Select Case tipo
                Case 0
                    query = "SELECT * FROM movinternolistadoview WHERE `Nro. Operación` =  @filtro and Estado <> 'Anulado' GROUP BY `Nro. Operación`  "
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@filtro", filtro)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))

                Case 1
                    query = "Select * FROM movinternolistadoview WHERE (Fecha BETWEEN @desde AND @hasta) and Estado <> 'Anulado' GROUP BY `Nro. Operación` "
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@desde", inicio)
                    cmd.Parameters.AddWithValue("@hasta", fin)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))
                Case 2
                    query = "SELECT * FROM movinternolistadoview WHERE Proveedor =  @filtro and Estado <> 'Anulado' GROUP BY `Nro. Operación`"
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@filtro", filtro)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))

            End Select
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

End Class
