Imports Contas.Dominio

Public Class CadCredor

    Private db As New DbContexto
    Private credor As clsContaCredor

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click


        If String.IsNullOrEmpty(txtNomeCliente.Text) Then
            MsgBox("Digite o nome do credor.", MsgBoxStyle.Information, "Cadastro de Credor")
            txtNomeCliente.Focus()
            Exit Sub
        End If

        Try
            If Not IsNothing(credor) AndAlso Not String.IsNullOrEmpty(credor.Nome) Then
                With credor
                    .Nome = txtNomeCliente.Text
                    .Telefone = txtTelefone.Text
                    .Celular = txtCelular.Text
                    .Email = txtEmail.Text
                    .CPF = txtObs.Text
                End With
            Else
                Dim dados As New clsContaCredor

                dados.Nome = txtNomeCliente.Text
                dados.Telefone = txtTelefone.Text
                dados.Celular = txtCelular.Text
                dados.Email = txtEmail.Text
                dados.CPF = txtObs.Text

                dados.DataCadastro = Now


                db.Credor.Add(dados)

            End If

            db.SaveChanges()

            MsgBox("Credor cadastrado com sucesso!", MsgBoxStyle.Information, "Cadastro de Credor")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        credor = Nothing
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub txtCelular_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCelular.Validating
        validaCel(sender)
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtEmail.Text = ""
        txtCelular.Text = ""
        txtObs.Text = ""
        txtNomeCliente.Text = ""
        txtTelefone.Text = ""
    End Sub

    Private Sub CadCredor_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class