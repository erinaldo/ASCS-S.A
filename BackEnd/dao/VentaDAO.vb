Imports System.Windows.Forms
Imports BackEnd
Imports MySql.Data.MySqlClient

Public Class VentaDAO
    Public Function cbVendedores() As DataSet
        Dim daoV As New VendedorDAO
        Return daoV.cbVendedor()
    End Function



    Public Function cbClientes() As DataSet
        Dim daoC As New ClienteDAO
        Return daoC.cbCliente()
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
            Dim adp As New MySqlDataAdapter(mysql, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds

    End Function

    Public Function cargaImpuesto() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT `impCod` AS `Código`, `impPorcentaje` AS `Porcentaje`, impDesc AS `Impuesto` " _
                        & "FROM `stimpuesto`"
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function BuscarProducts(cod As String) As DataSet
        Dim tmp As New ProductoDAO
        Return tmp.obtenerProductos(cod, 2)
    End Function

    Public Function buscarCliente(ByVal ci As String) As Cliente
        Dim tmp As New ClienteDAO
        Return tmp.obtenerClienteVenta(ci)
    End Function

    Public Function duplicado(v As String) As Boolean
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT * " _
                        & "FROM stmovinterno WHERE movNro = " & v & ""

            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            Return cmd.ExecuteScalar
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return True
    End Function

    Public Function obtenerCliente(cliente As Integer) As Cliente
        Dim tmp As New ClienteDAO
        Return tmp.obtenerCliente(cliente.ToString)
    End Function

    Public Function obtenerVendedor(vendedor As Integer) As Vendedor
        Dim tmp As New VendedorDAO
        Return tmp.obtenerVendedor(vendedor.ToString)
    End Function

    Public Sub guardarVenta(venta As Venta, productos As DataGridViewRowCollection)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            venta.userInsert = Sesion.Usuario
            Dim queryVenta = ""
            queryVenta = "INSERT INTO stventas (`clieCod`, `ventasFechaFact`, `ventasNroFactu`, `ventasTipoFactura`, `depoCod`,  `ventasEstado`, `ventasObs`, `ventasSaldo`," _
                            & " `ventasUsrIns`, `ventasFchIns`, `ventasVendedor`, ventasDescuento ) " _
                            & "VALUES (@cliente,@fechaFact,@nroFact,@tipo,@depo,@estado,@observ,@saldo,@usuario,@fechaIns,@vendedor,@desc); SELECT LAST_INSERT_ID();"
            Dim cmdVenta As New MySqlCommand(queryVenta, con)

            cmdVenta.Parameters.AddWithValue("@cliente", venta.cliente)
            cmdVenta.Parameters.AddWithValue("@fechaFact", venta.fechaFactura)
            cmdVenta.Parameters.AddWithValue("@nroFact", venta.nroFactura)
            cmdVenta.Parameters.AddWithValue("@tipo", venta.tipo)
            cmdVenta.Parameters.AddWithValue("@depo", 2)
            cmdVenta.Parameters.AddWithValue("@estado", venta.estado)
            cmdVenta.Parameters.AddWithValue("@observ", venta.comentario)
            cmdVenta.Parameters.AddWithValue("@saldo", venta.saldo)
            cmdVenta.Parameters.AddWithValue("@usuario", venta.userInsert)
            cmdVenta.Parameters.AddWithValue("@fechaIns", venta.fechaInsFactura)
            cmdVenta.Parameters.AddWithValue("@vendedor", venta.vendedor)
            cmdVenta.Parameters.AddWithValue("@desc", venta.descuento)
            Dim ventaCod = CInt(cmdVenta.ExecuteScalar())


            con.Close()
            con.Open()

            Dim queryDetalle = "INSERT INTO stventasdet (`ventasCod`, `prodCodigo`, `impCod`, `superficie`, `ventasDetCantidad`, `ventasPrecioUnitario`, `ventasImpExcenta`, `ventasImp5`, `ventasImp10` ) " _
                                & "VALUES (@codVenta,@producto,@impuesto,@m2,@cantidad,@precio,@impEx,@imp5,@imp10)"
            Dim cmdDetalle As New MySqlCommand(queryDetalle, con)
            For Each row As Windows.Forms.DataGridViewRow In productos
                Dim producto = row.Cells("Código").Value
                Dim impuesto = row.Cells("Impuesto").Value
                Dim m2 = CDbl(row.Cells("Superficie").Value)
                Dim cantidad = CInt(row.Cells("Cantidad").Value)
                Dim precio = CDbl(row.Cells("Precio").Value)
                Dim iva = CDbl(row.Cells("Iva").Value)

                cmdDetalle.Parameters.AddWithValue("@codVenta", ventaCod)
                cmdDetalle.Parameters.AddWithValue("@producto", producto)
                cmdDetalle.Parameters.AddWithValue("@precio", precio)
                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad)
                cmdDetalle.Parameters.AddWithValue("@m2", m2)
                If impuesto.ToString = "10%" Then
                    cmdDetalle.Parameters.AddWithValue("@impuesto", 1)
                    cmdDetalle.Parameters.AddWithValue("@imp10", iva)
                    cmdDetalle.Parameters.AddWithValue("@imp5", 0)
                    cmdDetalle.Parameters.AddWithValue("@impEx", 0)

                ElseIf impuesto.ToString = "5%" Then
                    cmdDetalle.Parameters.AddWithValue("@impuesto", 4)
                    cmdDetalle.Parameters.AddWithValue("@imp10", 0)
                    cmdDetalle.Parameters.AddWithValue("@imp5", iva)
                    cmdDetalle.Parameters.AddWithValue("@impEx", 0)

                Else
                    cmdDetalle.Parameters.AddWithValue("@impuesto", 5)
                    cmdDetalle.Parameters.AddWithValue("@imp10", 0)
                    cmdDetalle.Parameters.AddWithValue("@imp5", 0)
                    cmdDetalle.Parameters.AddWithValue("@impEx", iva)

                End If

                cmdDetalle.ExecuteNonQuery()
                cmdDetalle.Parameters.Clear()
            Next







            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function buscarVentas(ByVal filtro As String, ByVal tipo As Integer, ByVal inicio As Date, ByVal fin As Date) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query = ""

            Select Case tipo
                Case 0
                    query = "SELECT * FROM cargaventasview WHERE `Factura Nro.` =  @filtro and Estado <> 'Anulado'  "
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@filtro", filtro)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))

                Case 1
                    query = "SELECT * FROM cargaventasview WHERE (Fecha BETWEEN @desde AND @hasta) and Estado <> 'Anulado'  "
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@desde", inicio)
                    cmd.Parameters.AddWithValue("@hasta", fin)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))
                Case 2
                    query = "SELECT * FROM cargaventasview WHERE rucCliente =  @filtro and Estado <> 'Anulado'"
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@filtro", filtro)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))

            End Select
        Catch ex As Exception

        End Try

        Return ds

    End Function

    Public Function buscarVentasCobro(ByVal filtro As String, ByVal tipo As Integer, ByVal inicio As Date, ByVal fin As Date) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query = ""

            Select Case tipo
                Case 0
                    query = "SELECT * FROM cargaventasview WHERE `Factura Nro.` =  @filtro and Estado = 'Activo'  "
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@filtro", filtro)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))

                Case 1
                    query = "SELECT * FROM cargaventasview WHERE (Fecha BETWEEN @desde AND @hasta) and Estado = 'Activo'  "
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@desde", inicio)
                    cmd.Parameters.AddWithValue("@hasta", fin)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))
                Case 2
                    query = "SELECT * FROM cargaventasview WHERE rucCliente =  @filtro and Estado = 'Activo'"
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@filtro", filtro)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))

            End Select
        Catch ex As Exception

        End Try

        Return ds

    End Function

    Public Function obtenerVentaDatos(codigo As String) As Venta
        Dim venta As New Venta
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim mysql As String = "SELECT * FROM stventas WHERE `ventasCod` = " & codigo & ""
            Dim cmd As New MySqlCommand(mysql, con)
            Dim reader = cmd.ExecuteReader()

            If reader.Read Then
                venta.codigo = SafeGetInt(reader, 0)
                venta.cliente = SafeGetInt(reader, 1)
                venta.fechaFactura = SafeGetDate(reader, 2)

                venta.nroFactura = SafeGetString(reader, 3)
                venta.tipo = SafeGetString(reader, 4)
                venta.estado = SafeGetString(reader, 6)
                venta.fechaAnulacion = SafeGetDate(reader, 7)
                venta.comentario = SafeGetString(reader, 8)

                venta.fechaPagado = SafeGetDate(reader, 2)
                venta.saldo = SafeGetInt(reader, 9)


                venta.vendedor = SafeGetString(reader, 15)
                venta.fechaActualizacion = SafeGetDate(reader, 14)
                venta.fechaInsFactura = SafeGetDate(reader, 12)
                venta.descuento = SafeGetDouble(reader, 16)
            End If
            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return venta
    End Function

    Public Function cargarPoductosVenta(codigo As String) As stockcapiataDataSet.detalleproductoventaviewDataTable
        Dim ds As New stockcapiataDataSet.detalleproductoventaviewDataTable
        Dim dt As New DataTable
        Try
            Dim tabla = New stockcapiataDataSetTableAdapters.detalleproductoventaviewTableAdapter
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql As String = "Select   *   FROM `detalleproductoventaview` WHERE Compra = " & codigo & ""
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(cmd)
            tabla.Connection = con

            ds = tabla.GetDataByVenta(codigo)

            'tabla.Fill(ds)

            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function
End Class
