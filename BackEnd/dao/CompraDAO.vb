Imports BackEnd
Imports MySql.Data.MySqlClient

Public Class CompraDAO

    Function carga(ByVal inicio As Date, ByVal fin As Date) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT * from cargacomprasview WHERE (`Fecha Factura` BETWEEN @desde AND @hasta)"

            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@desde", inicio)


            cmd.Parameters.AddWithValue("@hasta", fin)
            Dim adp As New MySqlDataAdapter(cmd)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


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

    Public Function cargarPoductosCompra(codigo As String) As stockcapiataDataSet.detalleproductocompraviewDataTable
        Dim ds As New stockcapiataDataSet.detalleproductocompraviewDataTable
        Dim dt As New DataTable
        Try
            Dim tabla = New stockcapiataDataSetTableAdapters.detalleproductocompraviewTableAdapter
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql As String = "Select   *   FROM `detalleproductocompraview` WHERE Compra = " & codigo & ""
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(cmd)
            tabla.Connection = con

            ds = tabla.GetDataByCompra(codigo)

            'tabla.Fill(ds)

            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function obtenerCompraDatos(codigo As String) As Compra
        Dim compra As New Compra
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim mysql As String = "SELECT * FROM cargacompraparadetalleview WHERE `Código` = " & codigo & ""
            Dim cmd As New MySqlCommand(mysql, con)
            Dim reader = cmd.ExecuteReader()

            If reader.Read Then
                compra.codigo = SafeGetString(reader, 0)
                compra.fechaFactura = SafeGetDate(reader, 1)
                compra.nroFactura = SafeGetString(reader, 2)
                compra.estado = SafeGetString(reader, 3)
                compra.comentario = SafeGetString(reader, 4)
                compra.fechaAnulacion = SafeGetDate(reader, 5)
                compra.fechaPagado = SafeGetDate(reader, 6)
                compra.saldo = SafeGetInt(reader, 7)
                compra.tipo = SafeGetString(reader, 8)
                compra.proveedor = SafeGetString(reader, 9)
                compra.usuario = SafeGetString(reader, 10)
                compra.fechaActualizacion = SafeGetDate(reader, 11)
                compra.fechaInsFactura = SafeGetDate(reader, 12)
            End If
            reader.Close()
            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return compra
    End Function





    Function buscarCompra(ByVal filtro As String, ByVal tipo As Integer) As DataSet
        Dim ds As New DataSet
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim mysql As String = ""

            If tipo = 0 Then
                mysql = "SELECT * from cargacomprasview WHERE `Nro. Factura` = " & filtro & ""

            ElseIf tipo = 2 Then

                mysql = "SELECT * from cargacomprasview WHERE `Proveedor` = '" & filtro & "'"

            End If


            Dim cmd As New MySqlCommand(mysql, con)



            Dim adp As New MySqlDataAdapter(cmd)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()


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

    Public Sub anularCompra(codigo As Object)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            ' Actualizando compra
            Dim query = "UPDATE `stcompras`  SET `comprasEstado`= @estado, comprasFechaAnulacion= @fechaAnul, comprasUsrUpd = @usuario, `comprasFechaUpd` = @fechaUpd where comprasCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Parameters.AddWithValue("@estado", "Anul")
            cmd.Parameters.AddWithValue("@fechaAnul", Date.Today)
            cmd.Parameters.AddWithValue("@usuario", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fechaUpd", Date.Today)
            cmd.ExecuteNonQuery()

            ' Actualizando existencia
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub
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
                        & "FROM `stproveedor`"

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

    Public Function cargaImpuesto() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT `impCod` AS `Código`, `impPorcentaje` AS `Porcentaje`, impDesc AS `Impuesto` " _
                        & "FROM `stimpuesto`"

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

    Public Sub guardarCompra(ByVal compra As Compra, ByVal productos As Windows.Forms.DataGridViewRowCollection)
        Try

            compra.userInsert = Sesion.Usuario
            Dim mysql As String = ""
            If compra.tipo = "Contado" Then

                mysql = "INSERT INTO `stcompras` ( `comprasCod`, `comprasFechaFact`, `comprasNroFactura`, `comprasObs`, `comprasSaldo`, `comprasTipoFact`, `provCodigo`, `comprasUsrIns`, `comprasFechaIns`,`comprasFechaPagado`,`comprasEstado` ) " _
                       & "VALUES (@cod,@fechaFact,@nroFact,@obs,@saldo,@tipo,@prov,@userIns,@fechaIns,@fechaPago,@estado)"

            Else
                mysql = "INSERT INTO `stcompras` ( `comprasCod`, `comprasFechaFact`, `comprasNroFactura`, `comprasObs`, `comprasSaldo`, `comprasTipoFact`, `provCodigo`, `comprasUsrIns`, `comprasFechaIns`,`comprasEstado` ) " _
                       & "VALUES (@cod,@fechaFact,@nroFact,@obs,@saldo,@tipo,@prov,@userIns,@fechaIns,@estado)"

            End If
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            Dim con2 As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim sqlcmd As New MySqlCommand(mysql, con)
            If compra.tipo = "Contado" Then
                sqlcmd.Parameters.AddWithValue("@cod", compra.nroFactura)
                sqlcmd.Parameters.AddWithValue("@fechaFact", compra.fechaFactura)
                sqlcmd.Parameters.AddWithValue("@nroFact", compra.nroFactura)
                sqlcmd.Parameters.AddWithValue("@obs", compra.comentario)

                sqlcmd.Parameters.AddWithValue("@saldo", compra.saldo)

                sqlcmd.Parameters.AddWithValue("@tipo", compra.tipo)
                sqlcmd.Parameters.AddWithValue("@estado", compra.estado)
                sqlcmd.Parameters.AddWithValue("@prov", compra.proveedor)
                sqlcmd.Parameters.AddWithValue("@userIns", compra.userInsert)
                sqlcmd.Parameters.AddWithValue("@fechaIns", compra.fechaInsFactura)
                sqlcmd.Parameters.AddWithValue("@fechapago", compra.fechaPagado)

            Else
                sqlcmd.Parameters.AddWithValue("@cod", compra.nroFactura)
                sqlcmd.Parameters.AddWithValue("@fechaFact", compra.fechaFactura)
                sqlcmd.Parameters.AddWithValue("@nroFact", compra.nroFactura)
                sqlcmd.Parameters.AddWithValue("@obs", compra.comentario)

                sqlcmd.Parameters.AddWithValue("@saldo", compra.saldo)
                sqlcmd.Parameters.AddWithValue("@estado", compra.estado)
                sqlcmd.Parameters.AddWithValue("@tipo", compra.tipo)
                sqlcmd.Parameters.AddWithValue("@prov", compra.proveedor)
                sqlcmd.Parameters.AddWithValue("@userIns", compra.userInsert)
                sqlcmd.Parameters.AddWithValue("@fechaIns", compra.fechaInsFactura)

            End If

            sqlcmd.ExecuteNonQuery()


            Dim queryDetalle = "INSERT INTO `stcomprasdet` ( `comprasCod`, `codigo_base`, `comprasCosto`, `comprasImpExcente`, `comprasImp5`, `comprasImp10`, `comprasCanitad` )" _
                                & "VALUE(@cod,@codBase,@costo,@impEx,@imp5,@imp10,@cant)"
            Dim sqldetalle As New MySqlCommand(queryDetalle, con)

            'Dim queryCheckExistencia = "SELECT * from stexistencia WHERE codigo_base = @cod AND depoCod = @depo AND `exisNroOt`= @ot"
            'con2.Open()
            'Dim sqlCheck As New MySqlCommand(queryCheckExistencia, con2)


            For Each row As Windows.Forms.DataGridViewRow In productos
                ' Se agrega el detalle 
                Dim codigo = row.Cells("Código").Value

                Dim cantidad = row.Cells("Cantidad").Value
                Dim impuesto = row.Cells("Impuesto").Value
                Dim iva = row.Cells("Iva").Value
                Dim costo = row.Cells("Total").Value
                Dim deposito = row.Cells("DepoCod").Value
                sqldetalle.Parameters.AddWithValue("@cod", compra.nroFactura)
                sqldetalle.Parameters.AddWithValue("@codBase", codigo)
                sqldetalle.Parameters.AddWithValue("@costo", costo)

                If impuesto.ToString = "10%" Then
                    sqldetalle.Parameters.AddWithValue("@imp10", iva)
                    sqldetalle.Parameters.AddWithValue("@imp5", 0)
                    sqldetalle.Parameters.AddWithValue("@impEx", 0)

                ElseIf impuesto.ToString = "5%" Then
                    sqldetalle.Parameters.AddWithValue("@imp10", 0)
                    sqldetalle.Parameters.AddWithValue("@imp5", iva)
                    sqldetalle.Parameters.AddWithValue("@impEx", 0)

                Else
                    sqldetalle.Parameters.AddWithValue("@imp10", 0)
                    sqldetalle.Parameters.AddWithValue("@imp5", 0)
                    sqldetalle.Parameters.AddWithValue("@impEx", iva)

                End If
                sqldetalle.Parameters.AddWithValue("@cant", cantidad)

                sqldetalle.ExecuteNonQuery()
                sqldetalle.Parameters.Clear()

                ' Existencia

                'sqlCheck.Parameters.AddWithValue("@cod", codigo)
                'sqlCheck.Parameters.AddWithValue("@depo", deposito)

                'sqlCheck.Parameters.AddWithValue("@ot", compra.nroFactura)
                'Dim reader As MySqlDataReader = sqlCheck.ExecuteReader
                'If reader.Read Then
                '    Dim cantActual = reader.GetInt16(2)
                '    Dim nuevaCant = cantActual + cantidad
                '    Dim queryExistencia = "UPDATE `stockcapiata`.`stexistencia` SET `exisCantidad` =  @cantidad, `exisUsrIns` = @user, `exisFchIns` = @fecha " _
                '                     & "WHERE `codigo_base` = @cod AND `depoCod` = @depo AND `exisNroOt`= @ot"

                '    Dim sqlExistencia As New MySqlCommand(queryExistencia, con)
                '    sqlExistencia.Parameters.AddWithValue("@cod", codigo)
                '    sqlExistencia.Parameters.AddWithValue("@depo", deposito)
                '    sqlExistencia.Parameters.AddWithValue("@cantidad", nuevaCant)
                '    sqlExistencia.Parameters.AddWithValue("@user", compra.userInsert)
                '    sqlExistencia.Parameters.AddWithValue("@fecha", compra.fechaInsFactura)
                '    sqlExistencia.Parameters.AddWithValue("@ot", compra.nroFactura)
                '    Dim a = sqlExistencia.ExecuteNonQuery()

                '    sqlExistencia.Parameters.Clear()
                'Else
                Dim queryExistencia = "INSERT INTO `stexistencia` (`codigo_base`, `depoCod`, `exisCantidad`, `exisUsrIns`, `exisFchIns`,`exisNroOt`) " _
                                     & "VALUES(@cod,@depo,@cantidad,@user,@fecha,@Ot) "
                Dim sqlExistencia As New MySqlCommand(queryExistencia, con)
                sqlExistencia.Parameters.AddWithValue("@cod", codigo)
                sqlExistencia.Parameters.AddWithValue("@depo", deposito)
                sqlExistencia.Parameters.AddWithValue("@cantidad", cantidad)
                sqlExistencia.Parameters.AddWithValue("@user", compra.userInsert)
                sqlExistencia.Parameters.AddWithValue("@fecha", compra.fechaInsFactura)
                sqlExistencia.Parameters.AddWithValue("@Ot", compra.nroFactura)
                sqlExistencia.ExecuteNonQuery()
                sqlExistencia.Parameters.Clear()
                'End If
                'reader.Close()
                'sqlCheck.Parameters.Clear()
            Next
            con.Close()
            con2.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub
End Class
