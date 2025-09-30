Imports Contas.Dominio

Public Class CadTipoConta

    Private db As New DbContexto
    Private id As Integer = 0
    Private anterior As String

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CadTipoConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            grdTipoConta.DataSource = (From c In db.Tipo Select New With {Key .Codigo = c.Id, Key .Descricao = c.Descricao}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        grdTipoConta.Columns("Descricao").HeaderText = "FORMA DE PAGAMENTO"
        grdTipoConta.Columns("Codigo").HeaderText = "Código"

        grdTipoConta.Columns("Codigo").Width = 50
        grdTipoConta.Columns("Descricao").Width = 380

        grdTipoConta.Columns("Codigo").Visible = False
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim dados As clsContaTipo

        If String.IsNullOrWhiteSpace(txtDescrição.Text) Then
            MsgBox("Digite a Descrição da Conta.", MsgBoxStyle.Information, "Atenção")
            txtDescrição.Focus()
            Exit Sub
        End If

        Try
            If id > 0 Then
                If MsgBox("Deseja atualizar o tipo '" & txtDescrição.Text & "'?", MsgBoxStyle.YesNoCancel, "Atenção") = MsgBoxResult.Yes Then
                    dados = (From c In db.Tipo Where c.Id = id Select c).First
                    dados.Descricao = txtDescrição.Text
                End If
            Else
                dados = New clsContaTipo
                dados.Descricao = txtDescrição.Text
                db.Tipo.Add(dados)
            End If

            db.SaveChanges()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try

        id = 0
        txtDescrição.Text = ""

        Try
            grdTipoConta.DataSource = (From c In db.Tipo Select New With {Key .Codigo = c.Id, Key .Descricao = c.Descricao}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
    End Sub

    Private Sub grdTipoConta_DoubleClick(sender As Object, e As EventArgs) Handles grdTipoConta.DoubleClick
        id = grdTipoConta.SelectedRows(0).Cells(0).Value()
        txtDescrição.Text = grdTipoConta.SelectedRows(0).Cells(1).Value()
        anterior = txtDescrição.Text
    End Sub

    Private Sub CadTipoConta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class