'clase para poducto con cada una de sus propiedades

Public Class Producto
    Private _codigo As String
    Public Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _espesor As Decimal
    Public Property espesor() As Decimal
        Get
            Return _espesor
        End Get
        Set(ByVal value As Decimal)
            _espesor = value
        End Set
    End Property

    Private _largo As Decimal
    Public Property largo() As Decimal
        Get
            Return _largo
        End Get
        Set(ByVal value As Decimal)
            _largo = value
        End Set
    End Property

    Private _alto As Decimal
    Public Property alto() As Decimal
        Get
            Return _alto
        End Get
        Set(ByVal value As Decimal)
            _alto = value
        End Set
    End Property

    Private _m2 As Decimal
    Public Property m2() As Decimal
        Get
            Return _m2
        End Get
        Set(ByVal value As Decimal)
            _m2 = value
        End Set
    End Property

    Private _venta As Double
    Public Property venta() As Double
        Get
            Return _venta
        End Get
        Set(ByVal value As Double)
            _venta = value
        End Set
    End Property

    Private _color As Char
    Public Property color() As Char
        Get
            Return _color
        End Get
        Set(ByVal value As Char)
            _color = value
        End Set
    End Property

    Private _stock As Integer
    Public Property stock() As Integer
        Get
            Return _stock
        End Get
        Set(ByVal value As Integer)
            _stock = value
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
End Class
