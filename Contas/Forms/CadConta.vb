Imports Contas.Dominio

Public Class CadConta

    Private db As New DbContexto
    Private credor As clsContaCredor
    Private conta As clsConta



    Private Sub btnNovoCredor_Click(sender As Object, e As EventArgs) Handles btnNovoCredor.Click
        CadCredor.ShowDialog(Me)
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        MDIPrincipal.btContaMes.PerformClick()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        CadBanco.ShowDialog(Me)
    End Sub

    Private Sub btNovoTipo_Click(sender As Object, e As EventArgs) Handles btNovoTipo.Click
        CadTipoConta.ShowDialog(Me)
    End Sub

    Private Sub CadConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            cbBanco.DataSource = (From c In db.Banco Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()
            cbTipoConta.DataSource = (From c In db.Tipo Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbBanco.SelectedIndex = 0
        cbBanco.DisplayMember = "Nome"
        cbBanco.ValueMember = "Id"

        cbTipoConta.SelectedIndex = 0
        cbTipoConta.DisplayMember = "Nome"
        cbTipoConta.ValueMember = "Id"


        'dtVencimentoConta.Format = DateTimePickerFormat.Custom
        'dtVencimentoConta.CustomFormat = "dd MMM yy"

    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        TextBoxMoeda(sender)
    End Sub

    Private Sub cbTipoConta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoConta.SelectedIndexChanged
        If cbTipoConta.Text = "Cheque" Then
            cbBanco.Enabled = True
            txtControle.Enabled = True
            cbBanco.SelectedIndex = 0
            cbBanco.DisplayMember = "Nome"
            cbBanco.ValueMember = "Id"
            txtControle.Text = ""

        ElseIf cbTipoConta.Text = "Boleto" Then
            cbBanco.Enabled = False
            txtControle.Enabled = True
            cbBanco.SelectedIndex = 4
            cbBanco.DisplayMember = "Nome"
            cbBanco.ValueMember = "Id"
            txtControle.Text = "-"
        Else
            cbBanco.Enabled = False
            txtControle.Enabled = True
            cbBanco.SelectedIndex = 4
            cbBanco.DisplayMember = "Nome"
            cbBanco.ValueMember = "Id"
            txtControle.Text = "-"
        End If
    End Sub

    Private Sub txtControle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtControle.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        CadTipoConta.ShowDialog(Me)
    End Sub

    Private Sub btPesqCliente_Click(sender As Object, e As EventArgs) Handles btPesqCliente.Click
        Try
            Pesquisa.nome = txtNomeCredor.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 1
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")
        End Try
    End Sub

    Public Sub setaValores(cod As String)
        txtNomeCredor.Text = cod
        buscaPorNome()
    End Sub

    Private Sub buscaPorNome()
        If txtNomeCredor.Text = "" Then Exit Sub

        Try
            credor = (From u In db.Credor Where u.Nome = txtNomeCredor.Text Select u).First

            With credor
                txtNomeCredor.Text = .Nome
            End With

            txtNomeCredor.Enabled = False

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtNomeCredor.Text = ""
        txtValor.Text = ""
        txtControle.Text = ""
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        If IsNothing(credor) Then
            MsgBox("Selecione um credor.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            btPesqCliente.PerformClick()
            Exit Sub
        End If


        Try
            If Not IsNothing(conta) AndAlso Not String.IsNullOrEmpty(credor.Nome) Then
                With conta

                    Dim i As Integer = cbTipoConta.SelectedValue
                    .TipoConta = (From c In db.Tipo Where c.Id = i Select c).First

                    .Credor = credor

                    Dim j As Integer = cbBanco.SelectedValue
                    .Banco = (From c In db.Banco Where c.Id = j Select c).First

                    .Controle = txtControle.Text

                    .Valor = txtValor.Text

                    .DataVencimento = dtVencimentoConta.Value.Date

                    .DataCadastro = Now

                    .Status = (From c In db.Status Where c.Id = 1).FirstOrDefault


                End With
            Else
                Dim dados As New clsConta

                Dim i As Integer = cbTipoConta.SelectedValue
                dados.TipoConta = (From c In db.Tipo Where c.Id = i Select c).First

                dados.Credor = credor

                Dim j As Integer = cbBanco.SelectedValue
                dados.Banco = (From c In db.Banco Where c.Id = j Select c).First

                dados.Controle = txtControle.Text

                dados.Valor = txtValor.Text

                dados.DataVencimento = dtVencimentoConta.Value.Date

                dados.DataCadastro = Now

                dados.Status = (From c In db.Status Where c.Id = 1).FirstOrDefault

                db.Conta.Add(dados)

            End If

            db.SaveChanges()

            MsgBox("Conta cadastrada com sucesso!", MsgBoxStyle.Information, "Cadastro de Cliente")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        conta = Nothing
        MDIPrincipal.btContaMes.PerformClick()

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CadConta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        MDIPrincipal.btContaMes.PerformClick()

        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class