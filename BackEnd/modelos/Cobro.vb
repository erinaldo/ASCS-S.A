Public Class Cobro
    Private _efectivo As Double
    Public Property efectivo() As Double
        Get
            Return _efectivo
        End Get
        Set(ByVal value As Double)
            _efectivo = value
        End Set
    End Property

    Private _cheque As Double
    Public Property cheque() As Double
        Get
            Return _cheque
        End Get
        Set(ByVal value As Double)
            _cheque = value
        End Set
    End Property

    Private _banco As String
    Public Property banco() As String
        Get
            Return _banco
        End Get
        Set(ByVal value As String)
            _banco = value
        End Set
    End Property

    Private _chequeNro As String
    Public Property chequeNro() As String
        Get
            Return _chequeNro
        End Get
        Set(ByVal value As String)
            _chequeNro = value
        End Set
    End Property

    Private _recibo As String
    Public Property recibo() As String
        Get
            Return _recibo
        End Get
        Set(ByVal value As String)
            _recibo = value
        End Set
    End Property

    Private _tipo As Integer
    Public Property tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
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


    Private _fechaCheque As Date
    Public Property fechaCheque() As Date
        Get
            Return _fechaCheque
        End Get
        Set(ByVal value As Date)
            _fechaCheque = value
        End Set
    End Property
End Class
