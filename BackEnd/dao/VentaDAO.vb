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

    Public Function confirmarCaja() As Boolean
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT cajaCod FROM stcajas WHERE cajaFechApert = CURDATE() and cajaEstado = 'A'"
            Dim cmd As New MySqlCommand(query, con)
            Dim res = cmd.ExecuteScalar()
            If res = Nothing Then
                con.Close()
                Return False
            Else
                con.Close()
                Return True
            End If
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
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

    Public Function ventasImprimir() As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * from `cargaventasimprimirview`"
            Dim adp As New MySqlDataAdapter(query, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
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
                            & " `ventasUsrIns`, `ventasFchIns`, `ventasVendedor`, ventasDescuento,ventasTotal ) " _
                            & "VALUES (@cliente,@fechaFact,@nroFact,@tipo,@depo,@estado,@observ,@saldo,@usuario,@fechaIns,@vendedor,@desc,@total); SELECT LAST_INSERT_ID();"
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
            cmdVenta.Parameters.AddWithValue("@total", venta.total)
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



            If venta.tipo = "Contado" Then
                actualizarCaja(venta.total)
            End If



            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub cobrar(cobro As Cobro, venta As Integer)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            If cobro.tipo = 0 Then
                Dim query = "UPDATE stventas SET ventasSaldo = ventasSaldo - @monto, ventasFchUpd = CURDATE()  WHERE ventasCod = @cod"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@monto", cobro.efectivo)
                cmd.Parameters.AddWithValue("@cod", venta)
                cmd.ExecuteNonQuery()

                Dim caja = obtenerCaja()
                Dim queryRecibo = "INSERT INTO strecibo (`cajaCod`, `reciFecha`, `clieCod`, `reciTotal`, `reciUsrIns`, `reciFchIns`, `reciObs`, `reciNro`, `ventasCod`, `reciFormaPago`) " _
                                   & "VALUES(@caja,@fecha,@cliente,@total,@usuario,@fechaIns,@obs,@nroRec,@venta,@forma); SELECT LAST_INSERT_ID();"
                Dim cmdRecibo As New MySqlCommand(queryRecibo, con)
                cmdRecibo.Parameters.AddWithValue("@caja", caja)
                cmdRecibo.Parameters.AddWithValue("@fecha", Date.Today)
                cmdRecibo.Parameters.AddWithValue("@cliente", cobro.cliente)
                cmdRecibo.Parameters.AddWithValue("@total", cobro.efectivo)
                cmdRecibo.Parameters.AddWithValue("@usuario", Sesion.Usuario)
                cmdRecibo.Parameters.AddWithValue("@fechaIns", Date.Today)
                cmdRecibo.Parameters.AddWithValue("@obs", "Pago en efectivo")
                cmdRecibo.Parameters.AddWithValue("@nroRec", cobro.recibo)
                cmdRecibo.Parameters.AddWithValue("@venta", venta)
                cmdRecibo.Parameters.AddWithValue("@forma", "E")
                Dim recibo = cmdRecibo.ExecuteScalar()



                Dim queryReciboDet = "INSERT INTO strecibodet (reciCod, ventasCod, reciDetMonto,reciTipo) VALUES (@recibo, @venta, @monto,@tipo) "
                Dim cmdReciboDet As New MySqlCommand(queryReciboDet, con)
                cmdReciboDet.Parameters.AddWithValue("@recibo", recibo)
                cmdReciboDet.Parameters.AddWithValue("@venta", venta)
                cmdReciboDet.Parameters.AddWithValue("@monto", cobro.efectivo)
                cmdReciboDet.Parameters.AddWithValue("@tipo", "Efectivo")
                cmdReciboDet.ExecuteNonQuery()
                actualizarCaja(cobro.efectivo)
            ElseIf cobro.tipo = 1 Then
                Dim query = "UPDATE stventas SET ventasSaldo = ventasSaldo - @monto, ventasFchUpd = CURDATE() WHERE ventasCod = @cod"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@monto", cobro.cheque)
                cmd.Parameters.AddWithValue("@cod", venta)
                cmd.ExecuteNonQuery()

                Dim caja = obtenerCaja()
                Dim queryRecibo = "INSERT INTO strecibo (`cajaCod`, `reciFecha`, `clieCod`, `reciTotal`, `reciUsrIns`, `reciFchIns`, `reciObs`, `reciNro`, `ventasCod`, `reciFormaPago`, `reciChequeNro`, `reciBanco`, `reciFechaCheque`) " _
                                   & "VALUES(@caja,@fecha,@cliente,@total,@usuario,@fechaIns,@obs,@nroRec,@venta,@forma,@cheque,@banco,@fechaCheque); SELECT LAST_INSERT_ID();"
                Dim cmdRecibo As New MySqlCommand(queryRecibo, con)
                cmdRecibo.Parameters.AddWithValue("@caja", caja)
                cmdRecibo.Parameters.AddWithValue("@fecha", Date.Today)
                cmdRecibo.Parameters.AddWithValue("@cliente", cobro.cliente)
                cmdRecibo.Parameters.AddWithValue("@total", cobro.cheque)
                cmdRecibo.Parameters.AddWithValue("@usuario", Sesion.Usuario)
                cmdRecibo.Parameters.AddWithValue("@fechaIns", Date.Today)
                cmdRecibo.Parameters.AddWithValue("@obs", "Pago en cheque")
                cmdRecibo.Parameters.AddWithValue("@nroRec", cobro.recibo)
                cmdRecibo.Parameters.AddWithValue("@venta", venta)
                cmdRecibo.Parameters.AddWithValue("@forma", "C")
                cmdRecibo.Parameters.AddWithValue("@cheque", cobro.chequeNro)
                cmdRecibo.Parameters.AddWithValue("@banco", cobro.banco)
                cmdRecibo.Parameters.AddWithValue("@fechaCheque", cobro.fechaCheque)
                Dim recibo = cmdRecibo.ExecuteScalar()






                Dim queryReciboDet = "INSERT INTO strecibodet (reciCod, ventasCod, reciDetMonto,reciTipo) VALUES (@recibo, @venta, @monto,@tipo) "
                Dim cmdReciboDet As New MySqlCommand(queryReciboDet, con)
                cmdReciboDet.Parameters.AddWithValue("@recibo", recibo)
                cmdReciboDet.Parameters.AddWithValue("@venta", venta)
                cmdReciboDet.Parameters.AddWithValue("@monto", cobro.cheque)
                cmdReciboDet.Parameters.AddWithValue("@tipo", "Cheque")
                cmdReciboDet.ExecuteNonQuery()
                actualizarCaja(cobro.cheque)
            ElseIf cobro.tipo = 2 Then
                '' PAGO EFECTIVO + CHEQUE
                Dim query = "UPDATE stventas SET ventasSaldo = ventasSaldo - @monto, ventasFchUpd = CURDATE() WHERE ventasCod = @cod"
                Dim cmd As New MySqlCommand(query, con)
                Dim monto = cobro.efectivo + cobro.cheque
                cmd.Parameters.AddWithValue("@monto", monto)
                cmd.Parameters.AddWithValue("@cod", venta)
                cmd.ExecuteNonQuery()

                Dim caja = obtenerCaja()

                '' PARTE EN EFECTIVO
                Dim queryReciboEfectivo = "INSERT INTO strecibo (`cajaCod`, `reciFecha`, `clieCod`, `reciTotal`, `reciUsrIns`, `reciFchIns`, `reciObs`, `reciNro`, `ventasCod`, `reciFormaPago`, `reciChequeNro`, `reciBanco`, `reciFechaCheque`) " _
                                   & "VALUES(@caja,@fecha,@cliente,@total,@usuario,@fechaIns,@obs,@nroRec,@venta,@forma,@cheque,@banco,@fechaCheque); SELECT LAST_INSERT_ID();"
                Dim cmdReciboEfectivo As New MySqlCommand(queryReciboEfectivo, con)
                cmdReciboEfectivo.Parameters.AddWithValue("@caja", caja)
                cmdReciboEfectivo.Parameters.AddWithValue("@fecha", Date.Today)
                cmdReciboEfectivo.Parameters.AddWithValue("@cliente", cobro.cliente)
                cmdReciboEfectivo.Parameters.AddWithValue("@total", monto)
                cmdReciboEfectivo.Parameters.AddWithValue("@usuario", Sesion.Usuario)
                cmdReciboEfectivo.Parameters.AddWithValue("@fechaIns", Date.Today)
                cmdReciboEfectivo.Parameters.AddWithValue("@obs", "Pago en efectivo y cheque")
                cmdReciboEfectivo.Parameters.AddWithValue("@nroRec", cobro.recibo)
                cmdReciboEfectivo.Parameters.AddWithValue("@venta", venta)
                cmdReciboEfectivo.Parameters.AddWithValue("@forma", "EC")
                cmdReciboEfectivo.Parameters.AddWithValue("@cheque", cobro.chequeNro)
                cmdReciboEfectivo.Parameters.AddWithValue("@banco", cobro.banco)
                cmdReciboEfectivo.Parameters.AddWithValue("@fechaCheque", cobro.fechaCheque)
                Dim reciboE = cmdReciboEfectivo.ExecuteScalar()

                Dim queryReciboDetEfectivo = "INSERT INTO strecibodet (reciCod, ventasCod, reciDetMonto,recitipo) VALUES (@recibo, @venta, @monto,@tipo) "
                Dim cmdReciboDetE As New MySqlCommand(queryReciboDetEfectivo, con)
                cmdReciboDetE.Parameters.AddWithValue("@recibo", reciboE)
                cmdReciboDetE.Parameters.AddWithValue("@venta", venta)
                cmdReciboDetE.Parameters.AddWithValue("@monto", cobro.efectivo)
                cmdReciboDetE.Parameters.AddWithValue("@tipo", "Efectivo")
                cmdReciboDetE.ExecuteNonQuery()

                cmdReciboDetE.Parameters.Clear()
                cmdReciboDetE.Parameters.AddWithValue("@recibo", reciboE)
                cmdReciboDetE.Parameters.AddWithValue("@venta", venta)
                cmdReciboDetE.Parameters.AddWithValue("@monto", cobro.cheque)
                cmdReciboDetE.Parameters.AddWithValue("@tipo", "Cheque")
                cmdReciboDetE.ExecuteNonQuery()
                '' PARTE EN CHEQUE







                actualizarCaja(monto)
            End If
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Private Sub actualizarCaja(ByVal monto As Double)

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "UPDATE `stcajas`  SET `cajaMontofijo` = `cajaMontofijo` + @monto WHERE cajaFechApert = @date AND cajaEstado = 'A' "
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@monto", monto)
            cmd.Parameters.AddWithValue("@date", DateTime.Today)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub
    Public Function obtenerCaja() As Integer
        Try
            Dim codigo As Integer
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT cajaCod FROM stcajas WHERE cajaFechApert = CURDATE() "
            Dim cmd As New MySqlCommand(query, con)
            Dim reader = cmd.ExecuteReader()

            If reader.Read Then
                codigo = SafeGetInt(reader, 0)
            End If
            Return codigo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Function
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
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
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
                venta.total = SafeGetDouble(reader, 17)
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

    Public Function cargarDetalle(venta As String) As DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim sql = "Select * from `detalleproductoventaview` WHERE Venta = " & venta & ""
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, con)
            da.Fill(ds, "tabla")
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Function

    Public Sub anularVenta(ByVal codigo As Integer, ByVal comentario As String)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            ' Actualizando compra
            Dim query = "UPDATE `stventas`  SET `ventasEstado`= @estado, ventasObs = @comentario, ventasFechaAnul= @fechaAnul, ventasUsrUpd = @usuario, `ventasFchUpd` = @fechaUpd where ventasCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            Dim aux = "Anulado: " + comentario
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Parameters.AddWithValue("@estado", "Anul")
            cmd.Parameters.AddWithValue("@fechaAnul", Date.Today)
            cmd.Parameters.AddWithValue("@usuario", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fechaUpd", Date.Today)
            cmd.Parameters.AddWithValue("@comentario", aux)

            cmd.ExecuteNonQuery()

            ' Actualizando existencia
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function buscarVentasAnular(ByVal filtro As String, ByVal tipo As Integer, ByVal inicio As Date, ByVal fin As Date) As DataSet
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
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

        Return ds

    End Function

    Public Function buscarVentasImprimir(ByVal filtro As String, ByVal tipo As Integer, ByVal inicio As Date, ByVal fin As Date) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query = ""

            Select Case tipo
                Case 0
                    query = "SELECT * FROM cargaventasimprimirview WHERE `Factura Nro.` =  @filtro and Estado <> 'Anulado'  "
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@filtro", filtro)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))

                Case 1
                    query = "SELECT * FROM cargaventasimprimirview WHERE (Fecha BETWEEN @desde AND @hasta) and Estado <> 'Anulado'  "
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@desde", inicio)
                    cmd.Parameters.AddWithValue("@hasta", fin)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))
                Case 2
                    query = "SELECT * FROM cargaventasimprimirview WHERE rucCliente =  @filtro and Estado <> 'Anulado'"
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@filtro", filtro)
                    Dim adp As New MySqlDataAdapter(cmd)
                    ds.Tables.Add("tabla")
                    adp.Fill(ds.Tables("tabla"))

            End Select
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function
End Class
