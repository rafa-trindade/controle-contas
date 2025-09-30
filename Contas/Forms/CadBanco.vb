Imports Contas.Dominio

Public Class CadBanco

    Private db As New DbContexto
    Private id As Integer = 0
    Private anterior As String

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtDescrição.Text = ""
    End Sub

    Private Sub CadBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            grdBancos.DataSource = (From c In db.Banco Select New With {Key .Codigo = c.Id, Key .Descricao = c.Descricao}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        grdBancos.Columns("Descricao").HeaderText = "BANCOS"
        grdBancos.Columns("Codigo").HeaderText = "Código"

        grdBancos.Columns("Codigo").Width = 50
        grdBancos.Columns("Descricao").Width = 380

        grdBancos.Columns("Codigo").Visible = False

    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        Dim dados As clsContaBanco

        If String.IsNullOrWhiteSpace(txtDescrição.Text) Then
            MsgBox("Digite a Descrição do Banco.", MsgBoxStyle.Information, "Atenção")
            txtDescrição.Focus()
            Exit Sub
        End If

        Try
            If id > 0 Then
                If MsgBox("Deseja atualizar o tipo '" & txtDescrição.Text & "'?", MsgBoxStyle.YesNoCancel, "Atenção") = MsgBoxResult.Yes Then
                    dados = (From c In db.Banco Where c.Id = id Select c).First
                    dados.Descricao = txtDescrição.Text
                End If
            Else
                dados = New clsContaBanco
                dados.Descricao = txtDescrição.Text
                db.Banco.Add(dados)
            End If

            db.SaveChanges()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try

        id = 0
        txtDescrição.Text = ""

        Try
            grdBancos.DataSource = (From c In db.Banco Select New With {Key .Codigo = c.Id, Key .Descricao = c.Descricao}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try

    End Sub


    Private Sub grdBancos_DoubleClick(sender As Object, e As EventArgs) Handles grdBancos.DoubleClick
        id = grdBancos.SelectedRows(0).Cells(0).Value()
        txtDescrição.Text = grdBancos.SelectedRows(0).Cells(1).Value()
        anterior = txtDescrição.Text
    End Sub

    Private Sub CadBanco_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
End Class