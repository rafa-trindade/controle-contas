Public Class clsConta

    Private _id As Integer
    Private _tipoConta As clsContaTipo ''Cheque - Boleto - etc
    Private _credor As clsContaCredor ''Nome Credor
    Private _banco As clsContaBanco ''Nome Banco
    Private _controle As String ''Codigo Cheque - Boleto
    Private _valor As Double
    Private _dataVencimento As DateTime?
    Private _dataCadastro As DateTime?
    Private _status As clsContaStatus ''Pago - Em Aberto - Vencido - etc

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Controle() As String
        Get
            Return _controle
        End Get
        Set(ByVal value As String)
            _controle = value
        End Set
    End Property

    Public Property DataVencimento() As DateTime
        Get
            Return _dataVencimento
        End Get
        Set(ByVal value As DateTime)
            _dataVencimento = value
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

    Public Property Status() As clsContaStatus
        Get
            Return _status
        End Get
        Set(ByVal value As clsContaStatus)
            _status = value
        End Set
    End Property


    Public Property Credor() As clsContaCredor
        Get
            Return _credor
        End Get
        Set(ByVal value As clsContaCredor)
            _credor = value
        End Set
    End Property

    Public Property Banco() As clsContaBanco
        Get
            Return _banco
        End Get
        Set(ByVal value As clsContaBanco)
            _banco = value
        End Set
    End Property

    Public Property TipoConta() As clsContaTipo
        Get
            Return _tipoConta
        End Get
        Set(ByVal value As clsContaTipo)
            _tipoConta = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property

End Class
