Public Class Compra
    Private _codigo As Integer
    Public Property codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Private _fechaFactura As Date
    Public Property fechaFactura() As Date
        Get
            Return _fechaFactura
        End Get
        Set(ByVal value As Date)
            _fechaFactura = value
        End Set
    End Property

    Private _fechaAnulacion As Date
    Public Property fechaAnulacion() As Date
        Get
            Return _fechaAnulacion
        End Get
        Set(ByVal value As Date)
            _fechaAnulacion = value
        End Set
    End Property


    Private _fechaPagado As Date
    Public Property fechaPagado() As Date
        Get
            Return _fechaPagado
        End Get
        Set(ByVal value As Date)
            _fechaPagado = value
        End Set
    End Property

    Private _fechaActualizacion As Date
    Public Property fechaActualizacion() As Date
        Get
            Return _fechaActualizacion
        End Get
        Set(ByVal value As Date)
            _fechaActualizacion = value
        End Set
    End Property

    Private _nroFactura As String
    Public Property nroFactura() As String
        Get
            Return _nroFactura
        End Get
        Set(ByVal value As String)
            _nroFactura = value
        End Set
    End Property

    Private _comentario As String
    Public Property comentario() As String
        Get
            Return _comentario
        End Get
        Set(ByVal value As String)
            _comentario = value
        End Set
    End Property

    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
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

    Private _proveedor As String
    Public Property proveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
        End Set
    End Property

    Private _userInsert As String
    Public Property userInsert() As String
        Get
            Return _userInsert
        End Get
        Set(ByVal value As String)
            _userInsert = value
        End Set
    End Property

    Private _fechaInsFactura As Date
    Public Property fechaInsFactura() As Date
        Get
            Return _fechaInsFactura
        End Get
        Set(ByVal value As Date)
            _fechaInsFactura = value
        End Set
    End Property

    Private _saldo As Double
    Public Property saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
        End Set
    End Property
End Class
