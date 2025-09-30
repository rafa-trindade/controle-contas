Imports System.Data.Entity
Imports System.Configuration
Imports Contas.Dominio

Public Class DbContexto
    Inherits DbContext

    Public Sub New()
        MyBase.New("Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ControleContas;")
    End Sub

    Private m_Conta As DbSet(Of clsConta)
    Private m_Banco As DbSet(Of clsContaBanco)
    Private m_Credor As DbSet(Of clsContaCredor)
    Private m_Status As DbSet(Of clsContaStatus)
    Private m_Tipo As DbSet(Of clsContaTipo)

    Public Property Conta() As DbSet(Of clsConta)
        Get
            Return m_Conta
        End Get
        Set(value As DbSet(Of clsConta))
            m_Conta = value
        End Set
    End Property

    Public Property Banco() As DbSet(Of clsContaBanco)
        Get
            Return m_Banco
        End Get
        Set(value As DbSet(Of clsContaBanco))
            m_Banco = value
        End Set
    End Property

    Public Property Credor() As DbSet(Of clsContaCredor)
        Get
            Return m_Credor
        End Get
        Set(value As DbSet(Of clsContaCredor))
            m_Credor = value
        End Set
    End Property

    Public Property Status() As DbSet(Of clsContaStatus)
        Get
            Return m_Status
        End Get
        Set(value As DbSet(Of clsContaStatus))
            m_Status = value
        End Set
    End Property

    Public Property Tipo() As DbSet(Of clsContaTipo)
        Get
            Return m_Tipo
        End Get
        Set(value As DbSet(Of clsContaTipo))
            m_Tipo = value
        End Set
    End Property

End Class

