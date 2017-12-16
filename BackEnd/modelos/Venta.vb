Public Class Venta
    Private _codigo As Integer
    Public Property codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property


    Private _vendedor As Integer
    Public Property vendedor() As Integer
        Get
            Return _vendedor
        End Get
        Set(ByVal value As Integer)
            _vendedor = value
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

    Private _estado As String
    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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

    Private _cliente As Integer
    Public Property cliente() As Integer
        Get
            Return _cliente
        End Get
        Set(ByVal value As Integer)
            _cliente = value
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

    Private _userUpdate As String
    Public Property userUpdate() As String
        Get
            Return _userUpdate
        End Get
        Set(ByVal value As String)
            _userUpdate = value
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

    Private _descuento As Double
    Public Property descuento() As Double
        Get
            Return _descuento
        End Get
        Set(ByVal value As Double)
            _descuento = value
        End Set
    End Property

    Private _total As Double
    Public Property total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property
End Class
