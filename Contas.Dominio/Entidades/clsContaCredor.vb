Public Class clsContaCredor

    Private _id As Integer
    Private _nome As String
    Private _obs As String
    Private _telefone As String
    Private _celular As String
    Private _email As String
    Private _dataCadastro As DateTime?

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property DataCadastro() As DateTime
        Get
            Return _dataCadastro
        End Get
        Set(ByVal value As DateTime)
            _dataCadastro = value
        End Set
    End Property

    Public Property Celular() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return _telefone
        End Get
        Set(ByVal value As String)
            _telefone = value
        End Set
    End Property

    Public Property CPF() As String
        Get
            Return _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property


End Class
