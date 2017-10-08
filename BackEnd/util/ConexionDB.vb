

Public Class ConexionDB

    Public Shared Function cadenaConexionBD(ByVal user As String, ByVal passwd As String)
        Dim server As String = "localhost"
        Dim BD As String = "stockcapiata"
       
        'Dim cadenaConexion As String = "database=mysql;server=localhost;Allow Zero Datetime=True;Convert Zero Datetime=True;User Id='" & usuario & "';Password='" & password & "' ; Pooling=false;Connection Lifetime=1; Max Pool Size=1"
        'Dim ConexionBaseDatos As String = "Database=stockcapiata;Data Source=localhost;Allow Zero Datetime=True;Convert Zero Datetime=True;User Id='" & usuario & "';Password='" & password & "' ; Pooling=false;Connection Lifetime=1; Max Pool Size=1"

       


        Return String.Format("server={0};DataBase={1};User Id={2};Password={3}", server, BD, user, passwd)
        'Return ConexionBaseDatos
    End Function


End Class

