Imports Contas.Dominio


Public Class Pesquisa

    Public nome As String
    Public pai As Object
    Public tipo As Integer

    Public Sub carregaGridCredores()
        Dim db As New DbContexto

        If String.IsNullOrWhiteSpace(nome) Then
            Try
                grdPesquisa.DataSource = (From c In db.Credor Order By c.Nome Select New With {Key .Nome = c.Nome}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 0

        Else
            Try
                grdPesquisa.DataSource = (From c In db.Credor Order By c.Nome Where c.Nome.Contains(nome) Select New With {Key .Nome = c.Nome}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try


            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 0

        End If

    End Sub

    Public Sub carregaGridContas()
        Dim db As New DbContexto


        If EditConta.cbPesqTipo.SelectedIndex = 0 Then

            If EditConta.cbStatusConta.Checked = False Then

                If String.IsNullOrWhiteSpace(nome) Then
                    Try
                        grdPesquisa.DataSource = (From c In db.Conta.Include("Credor").Include("TipoConta") Order By c.DataCadastro Descending Where c.Status.Id = 2 Select New With {Key .Id = c.Id, Key .DataPagamento = c.DataCadastro, Key .Tipo = c.TipoConta.Descricao, Key .Nome = c.Credor.Nome, Key .Valor = c.Valor}).ToList()
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Me.Dispose()
                        Me.Close()
                    End Try

                    grdPesquisa.Columns("DataPagamento").Width = grdPesquisa.Width - 455
                    grdPesquisa.Columns("Tipo").Width = 78
                    grdPesquisa.Columns("Nome").Width = 265
                    grdPesquisa.Columns("Valor").Width = 75

                    grdPesquisa.Columns("Valor").ValueType = GetType(Decimal)
                    grdPesquisa.Columns("Valor").DefaultCellStyle.Format = "N2"

                    grdPesquisa.Columns("DataPagamento").HeaderText = "Data Pagamento"
                    grdPesquisa.Columns("Nome").HeaderText = "Credor"
                    grdPesquisa.Columns("Valor").HeaderText = "Valor R$"

                    grdPesquisa.Columns("Id").Visible = False

                Else
                    Try
                        grdPesquisa.DataSource = (From c In db.Conta.Include("Credor") Order By c.DataCadastro Descending Where c.Credor.Nome.Contains(nome) And c.Status.Id = 2 Select New With {Key .Id = c.Id, Key .DataPagamento = c.DataCadastro, Key .Tipo = c.TipoConta.Descricao, Key .Nome = c.Credor.Nome, Key .Valor = c.Valor}).ToList()
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Me.Dispose()
                        Me.Close()
                    End Try


                    grdPesquisa.Columns("DataPagamento").Width = grdPesquisa.Width - 455
                    grdPesquisa.Columns("Tipo").Width = 78
                    grdPesquisa.Columns("Nome").Width = 265
                    grdPesquisa.Columns("Valor").Width = 75

                    grdPesquisa.Columns("Valor").ValueType = GetType(Decimal)
                    grdPesquisa.Columns("Valor").DefaultCellStyle.Format = "N2"

                    grdPesquisa.Columns("DataPagamento").HeaderText = "Data Pagamento"
                    grdPesquisa.Columns("Nome").HeaderText = "Credor"
                    grdPesquisa.Columns("Valor").HeaderText = "Valor R$"

                    grdPesquisa.Columns("Id").Visible = False


                End If

            Else

                If String.IsNullOrWhiteSpace(nome) Then
                    Try
                        grdPesquisa.DataSource = (From c In db.Conta.Include("Credor").Include("TipoConta") Order By c.DataVencimento Where c.Status.Id = 1 Select New With {Key .Id = c.Id, Key .Vencimento = c.DataVencimento, Key .Tipo = c.TipoConta.Descricao, Key .Nome = c.Credor.Nome, Key .Valor = c.Valor}).ToList()
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Me.Dispose()
                        Me.Close()
                    End Try

                    grdPesquisa.Columns("Vencimento").Width = grdPesquisa.Width - 485
                    grdPesquisa.Columns("Tipo").Width = 78
                    grdPesquisa.Columns("Nome").Width = 275
                    grdPesquisa.Columns("Valor").Width = 75

                    grdPesquisa.Columns("Valor").ValueType = GetType(Decimal)
                    grdPesquisa.Columns("Valor").DefaultCellStyle.Format = "N2"

                    grdPesquisa.Columns("Nome").HeaderText = "Credor"
                    grdPesquisa.Columns("Valor").HeaderText = "Valor R$"

                    grdPesquisa.Columns("Id").Visible = False


                Else
                    Try
                        grdPesquisa.DataSource = (From c In db.Conta.Include("Credor") Order By c.DataVencimento Where c.Credor.Nome.Contains(nome) And c.Status.Id = 1 Select New With {Key .Id = c.Id, Key .Vencimento = c.DataVencimento, Key .Tipo = c.TipoConta.Descricao, Key .Nome = c.Credor.Nome, Key .Valor = c.Valor}).ToList()
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Me.Dispose()
                        Me.Close()
                    End Try

                    grdPesquisa.Columns("Vencimento").Width = grdPesquisa.Width - 485
                    grdPesquisa.Columns("Tipo").Width = 78
                    grdPesquisa.Columns("Nome").Width = 275
                    grdPesquisa.Columns("Valor").Width = 75

                    grdPesquisa.Columns("Valor").ValueType = GetType(Decimal)
                    grdPesquisa.Columns("Valor").DefaultCellStyle.Format = "N2"

                    grdPesquisa.Columns("Nome").HeaderText = "Credor"
                    grdPesquisa.Columns("Valor").HeaderText = "Valor R$"

                    grdPesquisa.Columns("Id").Visible = False


                End If

            End If

        Else

            If EditConta.cbStatusConta.Checked = False Then

                If String.IsNullOrWhiteSpace(nome) Then
                    Try
                        grdPesquisa.DataSource = (From c In db.Conta.Include("Credor").Include("TipoConta") Order By c.DataVencimento Where c.Status.Id = 2 And c.TipoConta.Id = EditConta.cbPesqTipo.SelectedIndex Select New With {Key .Id = c.Id, Key .Vencimento = c.DataVencimento, Key .Tipo = c.TipoConta.Descricao, Key .Nome = c.Credor.Nome, Key .Valor = c.Valor}).ToList()
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Me.Dispose()
                        Me.Close()
                    End Try

                    grdPesquisa.Columns("Vencimento").Width = grdPesquisa.Width - 485
                    grdPesquisa.Columns("Tipo").Width = 78
                    grdPesquisa.Columns("Nome").Width = 275
                    grdPesquisa.Columns("Valor").Width = 75

                    grdPesquisa.Columns("Valor").ValueType = GetType(Decimal)
                    grdPesquisa.Columns("Valor").DefaultCellStyle.Format = "N2"

                    grdPesquisa.Columns("Nome").HeaderText = "Credor"
                    grdPesquisa.Columns("Valor").HeaderText = "Valor R$"

                    grdPesquisa.Columns("Id").Visible = False

                Else
                    Try
                        grdPesquisa.DataSource = (From c In db.Conta.Include("Credor") Order By c.DataVencimento Where c.Credor.Nome.Contains(nome) And c.Status.Id = 2 And c.TipoConta.Id = EditConta.cbPesqTipo.SelectedIndex Select New With {Key .Id = c.Id, Key .Vencimento = c.DataVencimento, Key .Tipo = c.TipoConta.Descricao, Key .Nome = c.Credor.Nome, Key .Valor = c.Valor}).ToList()
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Me.Dispose()
                        Me.Close()
                    End Try

                    grdPesquisa.Columns("Vencimento").Width = grdPesquisa.Width - 485
                    grdPesquisa.Columns("Tipo").Width = 78
                    grdPesquisa.Columns("Nome").Width = 275
                    grdPesquisa.Columns("Valor").Width = 75

                    grdPesquisa.Columns("Valor").ValueType = GetType(Decimal)
                    grdPesquisa.Columns("Valor").DefaultCellStyle.Format = "N2"

                    grdPesquisa.Columns("Nome").HeaderText = "Credor"
                    grdPesquisa.Columns("Valor").HeaderText = "Valor R$"

                    grdPesquisa.Columns("Id").Visible = False


                End If

            Else

                If String.IsNullOrWhiteSpace(nome) Then
                    Try
                        grdPesquisa.DataSource = (From c In db.Conta.Include("Credor").Include("TipoConta") Order By c.DataVencimento Where c.Status.Id = 1 And c.TipoConta.Id = EditConta.cbPesqTipo.SelectedIndex Select New With {Key .Id = c.Id, Key .Vencimento = c.DataVencimento, Key .Tipo = c.TipoConta.Descricao, Key .Nome = c.Credor.Nome, Key .Valor = c.Valor}).ToList()
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Me.Dispose()
                        Me.Close()
                    End Try

                    grdPesquisa.Columns("Vencimento").Width = grdPesquisa.Width - 485
                    grdPesquisa.Columns("Tipo").Width = 78
                    grdPesquisa.Columns("Nome").Width = 275
                    grdPesquisa.Columns("Valor").Width = 75

                    grdPesquisa.Columns("Valor").ValueType = GetType(Decimal)
                    grdPesquisa.Columns("Valor").DefaultCellStyle.Format = "N2"

                    grdPesquisa.Columns("Nome").HeaderText = "Credor"
                    grdPesquisa.Columns("Valor").HeaderText = "Valor R$"

                    grdPesquisa.Columns("Id").Visible = False


                Else
                    Try
                        grdPesquisa.DataSource = (From c In db.Conta.Include("Credor") Order By c.DataVencimento Where c.Credor.Nome.Contains(nome) And c.Status.Id = 1 And c.TipoConta.Id = EditConta.cbPesqTipo.SelectedIndex Select New With {Key .Id = c.Id, Key .Vencimento = c.DataVencimento, Key .Tipo = c.TipoConta.Descricao, Key .Nome = c.Credor.Nome, Key .Valor = c.Valor}).ToList()
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Me.Dispose()
                        Me.Close()
                    End Try

                    grdPesquisa.Columns("Vencimento").Width = grdPesquisa.Width - 485
                    grdPesquisa.Columns("Tipo").Width = 78
                    grdPesquisa.Columns("Nome").Width = 275
                    grdPesquisa.Columns("Valor").Width = 75

                    grdPesquisa.Columns("Valor").ValueType = GetType(Decimal)
                    grdPesquisa.Columns("Valor").DefaultCellStyle.Format = "N2"

                    grdPesquisa.Columns("Nome").HeaderText = "Credor"
                    grdPesquisa.Columns("Valor").HeaderText = "Valor R$"

                    grdPesquisa.Columns("Id").Visible = False


                End If

            End If

        End If







    End Sub

    Private Sub PesquisaProdNome_Load(sender As Object, e As EventArgs) Handles Me.Load
        If tipo = 1 Or tipo = 2 Then
            carregaGridCredores()
        ElseIf tipo = 3 Then
            carregaGridContas()
            'ElseIf tipo = 3 Or tipo = 10 Or tipo = 11 Then
            '    carregaGridProdutos()
            'ElseIf tipo = 4 Or tipo = 6 Then
            '    carregaGridClientesCadastrados()
            'ElseIf tipo = 5 Then
            '    carregaGridHospedagens()
            'ElseIf tipo = 8 Then
            '    carregaGridReserva()
        End If
    End Sub

    Private Sub grdProdutos_DoubleClick(sender As Object, e As EventArgs) Handles grdPesquisa.DoubleClick
        If tipo = 1 Then
            CType(pai, CadConta).setaValores(grdPesquisa.SelectedRows(0).Cells("Nome").Value)
            Me.Close()
        ElseIf tipo = 2 Then
            CType(pai, MDIPrincipal).setaValores(grdPesquisa.SelectedRows(0).Cells("Nome").Value)
            Me.Close()
        ElseIf tipo = 3 Then
            CType(pai, EditConta).setaValores(grdPesquisa.SelectedRows(0).Cells("Id").Value)
            Me.Close()
            'ElseIf tipo = 4 Then
            '    CType(pai, CadHospedagem).setaValores(grdPesquisa.SelectedRows(0).Cells("CPF").Value)
            '    Me.Close()
            'ElseIf tipo = 5 Then
            '    CType(pai, EditHospedagem).setaValores(grdPesquisa.SelectedRows(0).Cells("Codigo").Value)
            '    Me.Close()
            'ElseIf tipo = 6 Then
            '    CType(pai, MostraRelHospedagens).setaValores(grdPesquisa.SelectedRows(0).Cells("CPF").Value)
            '    Me.Close()
            'ElseIf tipo = 7 Then
            '    CType(pai, CadReserva).setaValores(grdPesquisa.SelectedRows(0).Cells("CPF").Value)
            '    Me.Close()
            'ElseIf tipo = 8 Then
            '    CType(pai, EditReserva).setaValores(grdPesquisa.SelectedRows(0).Cells("Codigo").Value)
            '    Me.Close()
            'ElseIf tipo = 9 Then
            '    CType(pai, MostraRelReservas).setaValores(grdPesquisa.SelectedRows(0).Cells("CPF").Value)
            '    Me.Close()
            'ElseIf tipo = 10 Then
            '    CType(pai, MostraRelEstoque).setaValores(grdPesquisa.SelectedRows(0).Cells("Codigo").Value)
            '    Me.Close()
            'ElseIf tipo = 11 Then
            '    CType(pai, MostraRelVendas).setaValores(grdPesquisa.SelectedRows(0).Cells("Codigo").Value)
            '    Me.Close()
        End If
    End Sub

    Private Sub Pesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub

    Private Sub Pesquisa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class