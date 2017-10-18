Imports MySql.Data.MySqlClient

Public Class CompraDAO

    Function carga(ByVal inicio As Date, ByVal fin As Date) As DataSet
        Dim ds As New DataSet
        'Try
        '    Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
        '    con.Open()


        '    Dim mysql = "SELECT `clieCod` as `Código`, `clieNombre` as Nombre,`clieRuc` as RUC, clieTelef as Teléfono,clieContacto as Contacto FROM stockcapiata.`stclientes`"

        '    Dim cmd As New MySqlCommand(mysql, con)
        '    Dim adp As New MySqlDataAdapter(mysql, con)

        '    ds.Tables.Add("tabla")
        '    adp.Fill(ds.Tables("tabla"))

        '    con.Close()


        '    'While dr.Read
        '    ' modelo.codigo = dr(0).ToString
        '    ' modelo.descripcion = dr(1).ToString
        '    '  modelo.stock = dr(2).ToString
        '    '  modelo.tipo = dr(3).ToString


        '    '  productos.Add(modelo)


        '    ' a += 1
        '    '  End While
        '    ' MsgBox(a)

        '    ' dr.Close()
        '    'con.Close()


        'Catch ex As Exception
        '    Throw New DAOException(ex.ToString)
        'End Try
        Return ds
    End Function

End Class
