Public Class MovimientoInterno
    Private _nroMov
    Public Property nroMov() As Integer
        Get
            Return _nroMov
        End Get
        Set(ByVal value As Integer)
            _nroMov = value
        End Set
    End Property

    Private _solicitante As String
    Public Property solicitante() As String
        Get
            Return _solicitante
        End Get
        Set(ByVal value As String)
            _solicitante = value
        End Set
    End Property

    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Private _fechaIns As Date
    Public Property fechaIns() As Date
        Get
            Return _fechaIns
        End Get
        Set(ByVal value As Date)
            _fechaIns = value
        End Set
    End Property


    Private _autorizado As String
    Public Property autorizado() As String
        Get
            Return _autorizado
        End Get
        Set(ByVal value As String)
            _autorizado = value
        End Set
    End Property


    Private _proveedor As Integer
    Public Property proveedor() As Integer
        Get
            Return _proveedor
        End Get
        Set(ByVal value As Integer)
            _proveedor = value
        End Set
    End Property

    Private _linea As Integer
    Public Property linea() As Integer
        Get
            Return _linea
        End Get
        Set(ByVal value As Integer)
            _linea = value
        End Set
    End Property

    Private _producto As Integer
    Public Property producto() As Integer
        Get
            Return _producto
        End Get
        Set(ByVal value As Integer)
            _producto = value
        End Set
    End Property

    Private _productoCantidad As Integer
    Public Property productoCantidad() As Integer
        Get
            Return _productoCantidad
        End Get
        Set(ByVal value As Integer)
            _productoCantidad = value
        End Set
    End Property

    Private _tipo As String
    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set

    End Property

    Private _userIns As String
    Public Property userIns() As String
        Get
            Return _userIns
        End Get
        Set(ByVal value As String)
            _userIns = value
        End Set


    End Property

End Class
