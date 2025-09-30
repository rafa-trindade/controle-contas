Imports Contas.Dominio

Public Class EditConta

    Private db As New DbContexto
    Private credor As clsContaCredor
    Private conta As clsConta

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        MDIPrincipal.btContaMes.PerformClick()

        conta = Nothing

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub EditConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gbDetalhesHosp.Enabled = False
        btPagar.Enabled = False
        btReabrir.Enabled = False
        gbDetalhesConta.Enabled = False


        carregaBanco()
        carregaTipo()

        Try
            Dim tipoConta = (From c In db.Tipo Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()
            cbPesqTipo.Items.Add("Todos")
            For Each item In tipoConta
                cbPesqTipo.Items.Add(item)
            Next
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try

        cbPesqTipo.SelectedIndex = 0

        cbPesqTipo.DisplayMember = "Nome"
        cbPesqTipo.ValueMember = "Id"



        cbTipoConta.SelectedIndex = 1
        cbTipoConta.DisplayMember = "Nome"
        cbTipoConta.ValueMember = "Id"

    End Sub

    Public Sub carregaTipo()
        cbTipoConta.DisplayMember = "Descricao"
        cbTipoConta.ValueMember = "Id"

        Try
            cbTipoConta.DataSource = (From c In db.Tipo Select New With {Key .Id = c.Id, Key .Descricao = c.Descricao}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbTipoConta.SelectedIndex = -1
    End Sub

    Public Sub carregaBanco()
        cbBanco.DisplayMember = "Descricao"
        cbBanco.ValueMember = "Id"

        Try
            cbBanco.DataSource = (From c In db.Banco Select New With {Key .Id = c.Id, Key .Descricao = c.Descricao}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbBanco.SelectedIndex = -1
    End Sub

    Private Sub btPesqCliente_Click(sender As Object, e As EventArgs) Handles btPesqCliente.Click
        Try
            Pesquisa.nome = txtNomeCredor.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 3
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")
        End Try
    End Sub

    Public Sub setaValores(cod As String)
        txtNomeCredor.Text = (From u In db.Conta Where u.Id = cod Select u.Credor.Nome).First + " | " + (From u In db.Conta Where u.Id = cod Select u.TipoConta.Descricao).First
        lbIdConta.Text = cod
        buscaPorNome()
    End Sub

    Private Sub buscaPorNome()
        If txtNomeCredor.Text = "" Then Exit Sub
        carregaTipo()
        carregaBanco()
        Try

            conta = (From u In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Where u.Id = lbIdConta.Text Select u).First

            If cbStatusConta.Checked = False Then

                btReabrir.Enabled = True
                With conta

                    Dim sts As String
                    If .Status.Id = 1 Then
                        sts = "Conta em Aberto"

                    Else
                        sts = "Conta Paga"

                    End If

                    txtControle.Text = conta.Controle
                    txtValor.Text = Format(conta.Valor, "0.00")
                    cbTipoConta.SelectedValue = IIf(IsNothing(.TipoConta), -1, .TipoConta.Id)
                    cbBanco.SelectedValue = IIf(IsNothing(.Banco), -1, .Banco.Id)
                    dtVencimento.Text = conta.DataVencimento
                    lblUltimaMod.Text = Format(.DataCadastro, "dd/MM/yy")

                    lblStatus.Text = sts
                    lblStatus.ForeColor = Color.SteelBlue


                End With

                gbDetalhesConta.Enabled = True
                lblUltimaMod.Visible = True
                lblStatus.Visible = True


                txtNomeCredor.Enabled = False
                btPesqCliente.Enabled = False
                cbStatusConta.Enabled = False
                cbPesqTipo.Enabled = False
                btExcluir.Enabled = True


            Else

                btPagar.Enabled = True

                With conta

                    Dim sts As String
                    If .Status.Id = 1 Then
                        sts = "Conta em Aberto"
                    Else
                        sts = "Conta Paga"
                    End If

                    txtControle.Text = .Controle
                    txtValor.Text = Format(conta.Valor, "0.00")
                    cbTipoConta.SelectedValue = IIf(IsNothing(.TipoConta), -1, .TipoConta.Id)
                    cbBanco.SelectedValue = IIf(IsNothing(.Banco), -1, .Banco.Id)
                    dtVencimento.Text = .DataVencimento
                    lblUltimaMod.Text = Format(.DataCadastro, "dd/MM/yy")


                    lblStatus.Text = sts
                    lblStatus.ForeColor = Color.Tomato

                End With

                gbDetalhesConta.Enabled = True
                lblUltimaMod.Visible = True
                lblStatus.Visible = True

                txtNomeCredor.Enabled = False
                btPesqCliente.Enabled = False
                cbStatusConta.Enabled = False
                cbPesqTipo.Enabled = False
                btExcluir.Enabled = True



            End If

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")

        End Try
    End Sub

    Private Sub btnCadConta_Click(sender As Object, e As EventArgs) Handles btnCadConta.Click
        CadConta.ShowDialog(Me)
    End Sub

    Private Sub btAtualizarValor_Click(sender As Object, e As EventArgs) Handles btAtualizarValor.Click
        Try

            conta = (From u In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Where u.Id = lbIdConta.Text Select u).First


            With conta
                .Valor = txtValor.Text
                db.SaveChanges()
            End With

            db.SaveChanges()

            MsgBox("Valor da conta atualizado com sucesso!", MsgBoxStyle.Information, "Atualizar Valor Conta")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try

        conta = Nothing


    End Sub

    Private Sub btAtualizarControle_Click(sender As Object, e As EventArgs) Handles btAtualizarControle.Click

        conta = (From u In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Where u.Id = lbIdConta.Text Select u).First
        Try

            With conta
                .Controle = txtControle.Text
                db.SaveChanges()
            End With

            db.SaveChanges()

            MsgBox("Controle da conta atualizado com sucesso!", MsgBoxStyle.Information, "Atualizar Controle Conta")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        Me.Dispose()
        Me.Close()
        End Try
        conta = Nothing



    End Sub

    Private Sub btAtualizarBanco_Click(sender As Object, e As EventArgs) Handles btAtualizarBanco.Click
        If cbBanco.Text = "" Then
            MsgBox("Selcione um Banco.", MsgBoxStyle.Information, "Atualizar Banco")
            cbBanco.Focus()
            Exit Sub
        End If

        conta = (From u In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Where u.Id = lbIdConta.Text Select u).First

        Try

            With conta
                Dim bancoId As Integer = .Banco.Id
                Dim Ap1 As New clsContaBanco
                Ap1 = (From b In db.Banco Where b.Id = bancoId Select b).First

                Dim d As Integer = cbBanco.SelectedValue
                .Banco = (From c In db.Banco Where c.Id = d Select c).First

                Dim ap2 As New clsContaBanco
                ap2 = (From f In db.Banco Where f.Id = d Select f).First

                db.SaveChanges()

            End With


            MsgBox("Banco da Conta atualizado com sucesso!", MsgBoxStyle.Information, "Banco Conta")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        conta = Nothing


    End Sub

    Private Sub btAtualizarrTipo_Click(sender As Object, e As EventArgs) Handles btAtualizarrTipo.Click
        If cbTipoConta.Text = "" Then
            MsgBox("Selcione um Tipo.", MsgBoxStyle.Information, "Atualizar Tipo de Conta")
            cbTipoConta.Focus()
            Exit Sub
        End If

        conta = (From u In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Where u.Id = lbIdConta.Text Select u).First

        Try

            With conta
                Dim ContaId As Integer = .TipoConta.Id
                Dim Ap1 As New clsContaTipo
                Ap1 = (From b In db.Tipo Where b.Id = ContaId Select b).First

                Dim d As Integer = cbTipoConta.SelectedValue
                .TipoConta = (From c In db.Tipo Where c.Id = d Select c).First

                Dim ap2 As New clsContaBanco
                ap2 = (From f In db.Banco Where f.Id = d Select f).First

                db.SaveChanges()

            End With


            MsgBox("Tipo de Conta atualizado com sucesso!", MsgBoxStyle.Information, "Tipo de Conta")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        conta = Nothing



    End Sub

    Private Sub btAtualizarVencimento_Click(sender As Object, e As EventArgs) Handles btAtualizarVencimento.Click
        conta = (From u In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Where u.Id = lbIdConta.Text Select u).First
        Try

            With conta
                .DataVencimento = dtVencimento.Value.Date
                db.SaveChanges()
            End With

            db.SaveChanges()

            MsgBox("Vencimento atualizado com sucesso!", MsgBoxStyle.Information, "Atualizar Vencimento Conta")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        conta = Nothing

    End Sub

    Private Sub btPagar_Click(sender As Object, e As EventArgs) Handles btPagar.Click

        conta = (From u In db.Conta Where u.Id = lbIdConta.Text Select u).First
        Try

            With conta
                .Status = (From c In db.Status Where c.Id = 2).FirstOrDefault
                .DataCadastro = Now
                db.SaveChanges()
            End With

            db.SaveChanges()

            MsgBox("Conta paga com sucesso!", MsgBoxStyle.Information, "Confirmar Pagamento")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        conta = Nothing
        MDIPrincipal.btContaMes.PerformClick()

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btReabrir_Click(sender As Object, e As EventArgs) Handles btReabrir.Click
        conta = (From u In db.Conta Where u.Id = lbIdConta.Text Select u).First
        Try

            With conta
                .Status = (From c In db.Status Where c.Id = 1).FirstOrDefault
                .DataCadastro = Now
                db.SaveChanges()
            End With

            db.SaveChanges()

            MsgBox("Conta reaberta com sucesso!", MsgBoxStyle.Information, "Reabrir Conta")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        conta = Nothing
        MDIPrincipal.btContaMes.PerformClick()

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        gbPesqConta.Enabled = True
        gbDetalhesConta.Enabled = False
        btPagar.Enabled = False
        btReabrir.Enabled = False
        txtNomeCredor.Text = ""
        txtControle.Text = ""
        txtValor.Text = "0,00"
        cbBanco.SelectedIndex = -1
        cbTipoConta.SelectedIndex = -1
        cbStatusConta.Checked = True
        lblStatus.Visible = False
        lblUltimaMod.Visible = False
        txtNomeCredor.Enabled = True
        btPesqCliente.Enabled = True
        cbStatusConta.Enabled = True
        cbPesqTipo.Enabled = True
        cbPesqTipo.SelectedIndex = 0
        btExcluir.Enabled = False

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

        ElseIf cbTipoConta.Text = "Boleto" Then
            cbBanco.Enabled = True
            txtControle.Enabled = True
            cbBanco.SelectedIndex = 4
            cbBanco.DisplayMember = "Nome"
            cbBanco.ValueMember = "Id"
        Else
            cbBanco.Enabled = False
            txtControle.Enabled = True
            cbBanco.SelectedIndex = 4
            cbBanco.DisplayMember = "Nome"
            cbBanco.ValueMember = "Id"
            'txtControle.Text = "-"
        End If
    End Sub

    Private Sub EditConta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conta = Nothing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click


        If MsgBox("Deseja realmente excluir Conta de" & txtNomeCredor.Text & " dos registros?", MsgBoxStyle.YesNoCancel, "Gerenciar Contas") = MsgBoxResult.Yes Then

            Try

                Dim cont = (From c In db.Conta Where c.Id = lbIdConta.Text Select c).FirstOrDefault


                db.Conta.Remove(cont)

                db.SaveChanges()

                MsgBox("Registros de Conta excluídos com sucesso.", MsgBoxStyle.Information, "Exclusão de Registro")

            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try
            conta = Nothing

            Me.Dispose()
            Me.Close()
        End If

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        conta = Nothing

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub EditConta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        MDIPrincipal.btContaMes.PerformClick()

        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        If MsgBox("Deseja realmente excluir Conta de " & txtNomeCredor.Text & " dos registros?", MsgBoxStyle.YesNoCancel, "Gerenciar Contas") = MsgBoxResult.Yes Then

            Try

                Dim cont = (From c In db.Conta Where c.Id = lbIdConta.Text Select c).FirstOrDefault


                db.Conta.Remove(cont)

                db.SaveChanges()

                MsgBox("Registros de Conta excluídos com sucesso.", MsgBoxStyle.Information, "Exclusão de Registro")

            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try
            conta = Nothing

            MDIPrincipal.btContaMes.PerformClick()


            Me.Dispose()
            Me.Close()
        End If
    End Sub
End Class