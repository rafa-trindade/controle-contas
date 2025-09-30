Imports Contas.Dominio
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO

Public Class MDIPrincipal

    Private db As DbContexto
    Private credor As clsContaCredor
    Private listConta As New List(Of clsConta)
    Dim cabecalho As String
    Dim culture As New CultureInfo("pt-BR")
    Dim formataData As DateTimeFormatInfo = culture.DateTimeFormat

    'Private empresa As clsEmpresa
    'Private listcliente As New List(Of clsCliente)
    'Private listhospedagem As New List(Of clsHospedagem)

    Private Sub btCadastrar_Click(sender As Object, e As EventArgs) Handles btCadastrar.Click
        CadConta.ShowDialog(Me)
    End Sub

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbStatusConta.SelectedIndex = 0
        'cbTipoConta.SelectedIndex = 0

        db = New DbContexto

        cabecalho = "CONTAS MÊS DE " + (culture.TextInfo.ToTitleCase(formataData.GetMonthName(Now.Month.ToString))).ToUpper

        Try
            listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                         Where i.Status.Id = 1 And i.DataVencimento.Month <= Now.Month And i.DataVencimento.Year <= Now.Year Select i).ToList
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Exit Sub
        End Try

        lblTotalRel.Visible = True
        lblNumreg.Visible = True
        gbResumo.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelContasItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelContas.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = MontaItens(str1, str)





        Try
            Dim tipoConta = (From c In db.Tipo Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()
            cbTipoConta.Items.Add("Todos")
            For Each item In tipoConta
                cbTipoConta.Items.Add(item)
            Next
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try



        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados



        cbTipoConta.SelectedIndex = 0

        cbTipoConta.DisplayMember = "Nome"
        cbTipoConta.ValueMember = "Id"

        Try
            cbStatusConta.DataSource = (From c In db.Status Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbStatusConta.SelectedIndex = -1

        cbStatusConta.DisplayMember = "Nome"
        cbStatusConta.ValueMember = "Id"


        btContaMes.Text += culture.TextInfo.ToTitleCase(formataData.GetMonthName(Now.Month.ToString))



        'Try
        '    Dim sqlConnection1 As New SqlConnection("Data Source=mssql03.redehost.com.br,5003;Initial Catalog=ControleContas;User ID=rafaeltrindade;Password=Rafatrp1953*;")
        '    Dim cmd As New SqlCommand
        '    Dim reader As SqlDataReader

        '    File.Delete("C:\Users\rafat\Meu Drive\DEV\BACKUP\sistemacontrole.bak")
        '    cmd.CommandText = "BACKUP DATABASE [ControleContas] TO  DISK = N'C:\Users\rafat\Meu Drive\DEV\BACKUP\sistemacontrole.bak'"

        '    cmd.CommandType = CommandType.Text
        '    cmd.Connection = sqlConnection1

        '    sqlConnection1.Open()

        '    reader = cmd.ExecuteReader()
        '    ' Data is accessible through the DataReader object here.



        '    sqlConnection1.Close()
        'Catch ex As Exception
        '    MsgBox("Erro de Conexão", MsgBoxStyle.Critical, "Erro de Conexão")
        'End Try

    End Sub

    Private Sub MDIPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        'Try
        '    Dim sqlConnection1 As New SqlConnection("Data Source=mssql03.redehost.com.br,5003;Initial Catalog=ControleContas;User ID=rafaeltrindade;Password=Rafatrp1953*;")
        '    Dim cmd As New SqlCommand
        '    Dim reader As SqlDataReader

        '    File.Delete("C:\Users\rafat\Meu Drive\DEV\BACKUP\sistemacontrole.bak")
        '    cmd.CommandText = "BACKUP DATABASE [ControleContas] TO  DISK = N'C:\Users\rafat\Meu Drive\DEV\BACKUP\sistemacontrole.bak'"

        '    cmd.CommandType = CommandType.Text
        '    cmd.Connection = sqlConnection1

        '    sqlConnection1.Open()

        '    reader = cmd.ExecuteReader()
        '    ' Data is accessible through the DataReader object here.



        '    sqlConnection1.Close()
        'Catch ex As Exception
        '    MsgBox("Erro de Conexão", MsgBoxStyle.Critical, "Erro de Conexão")
        'End Try

    End Sub

    Private Sub btPesqCliente_Click(sender As Object, e As EventArgs) Handles btPesqCliente.Click
        Try
            Pesquisa.nome = txtNomeCredor.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 2
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
        txtNomeCredor.Enabled = True
        ckPeriodoConta.Checked = True

        dtInicioConta.Value = Now
        dtFimConta.Value = Now

        wbRels.DocumentText = ""

        lblTotalRel.Visible = False
        gbResumo.Visible = False
    End Sub

    Private Sub btGerarCliente_Click(sender As Object, e As EventArgs) Handles btGerarCliente.Click
        'lblNumRegistros.Text = "Número de Registros: "
        db = New DbContexto

        cabecalho = "RELATÓRIO GERADO DE CONTAS"


        listConta = Nothing


        If txtNomeCredor.Text = "" Then

            If Not ckPeriodoConta.Checked Then

                Dim dataIniConta As DateTime = dtInicioConta.Value.ToShortDateString
                Dim dataFimConta As DateTime = dtFimConta.Value.ToShortDateString
                dataIniConta = dataIniConta & " 00:00:00"
                dataFimConta = dataFimConta & " 23:59:59"

                If dataIniConta > dataFimConta Then
                    MsgBox("A Data Fim deve ser maior ou igual que a Data Início.", MsgBoxStyle.Information, "Relatório")
                    dtFimConta.Focus()
                    Exit Sub
                End If

                If cbTipoConta.SelectedIndex <> 0 Then

                    Try
                        listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                                     Where i.Status.Descricao = cbStatusConta.Text And i.TipoConta.Descricao = cbTipoConta.Text And
                                           i.DataVencimento >= dataIniConta And i.DataVencimento <= dataFimConta Select i).ToList
                        If listConta.Count < 1 Then
                            MsgBox("Credor sem contas cadastradas.", MsgBoxStyle.Information, "Relatório")

                        End If
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Exit Sub
                    End Try

                Else

                    Try
                        listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                                     Where i.Status.Descricao = cbStatusConta.Text And
                                           i.DataVencimento >= dataIniConta And i.DataVencimento <= dataFimConta Select i).ToList
                        If listConta.Count < 1 Then
                            MsgBox("Credor sem contas cadastradas.", MsgBoxStyle.Information, "Relatório")

                        End If
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Exit Sub
                    End Try

                End If

            Else

                If cbTipoConta.SelectedIndex <> 0 Then

                    Try
                        listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                                     Where i.Status.Descricao = cbStatusConta.Text And i.TipoConta.Descricao = cbTipoConta.Text).ToList
                        If listConta.Count < 1 Then
                            MsgBox("Credor sem contas cadastradas.", MsgBoxStyle.Information, "Relatório")

                        End If
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Exit Sub
                    End Try

                Else

                    Try
                        listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                                     Where i.Status.Descricao = cbStatusConta.Text).ToList
                        If listConta.Count < 1 Then
                            MsgBox("Credor sem contas cadastradas.", MsgBoxStyle.Information, "Relatório")

                        End If
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Exit Sub
                    End Try

                End If

            End If

        Else

            If Not ckPeriodoConta.Checked Then

                Dim dataIniConta As DateTime = dtInicioConta.Value.ToShortDateString
                Dim dataFimConta As DateTime = dtFimConta.Value.ToShortDateString
                dataIniConta = dataIniConta & " 00:00:00"
                dataFimConta = dataFimConta & " 23:59:59"

                If dataIniConta > dataFimConta Then
                    MsgBox("A Data Fim deve ser maior ou igual que a Data Início.", MsgBoxStyle.Information, "Relatório")
                    dtFimConta.Focus()
                    Exit Sub
                End If

                If cbTipoConta.SelectedIndex <> 0 Then

                    Try
                        listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                                     Where i.Credor.Nome = txtNomeCredor.Text And i.Status.Descricao = cbStatusConta.Text And i.TipoConta.Descricao = cbTipoConta.Text And
                                           i.DataVencimento >= dataIniConta And i.DataVencimento <= dataFimConta Select i).ToList
                        If listConta.Count < 1 Then
                            MsgBox("Credor sem contas cadastradas.", MsgBoxStyle.Information, "Relatório")

                        End If
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Exit Sub
                    End Try

                Else

                    Try
                        listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                                     Where i.Credor.Nome = txtNomeCredor.Text And i.Status.Descricao = cbStatusConta.Text And
                                           i.DataVencimento >= dataIniConta And i.DataVencimento <= dataFimConta Select i).ToList
                        If listConta.Count < 1 Then
                            MsgBox("Credor sem contas cadastradas.", MsgBoxStyle.Information, "Relatório")

                        End If
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Exit Sub
                    End Try

                End If

            Else

                If cbTipoConta.SelectedIndex <> 0 Then

                    Try
                        listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                                     Where i.Credor.Nome = txtNomeCredor.Text And i.Status.Descricao = cbStatusConta.Text And i.TipoConta.Descricao = cbTipoConta.Text).ToList
                        If listConta.Count < 1 Then
                            MsgBox("Credor sem contas cadastradas.", MsgBoxStyle.Information, "Relatório")

                        End If
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Exit Sub
                    End Try

                Else

                    Try
                        listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                                     Where i.Credor.Nome = txtNomeCredor.Text And i.Status.Descricao = cbStatusConta.Text).ToList
                        If listConta.Count < 1 Then
                            MsgBox("Credor sem contas cadastradas.", MsgBoxStyle.Information, "Relatório")

                        End If
                    Catch ex As Exception
                        MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                        Exit Sub
                    End Try

                End If

            End If

        End If

        lblTotalRel.Visible = True
        lblNumreg.Visible = True
        gbResumo.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelContasItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelContas.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = MontaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados




    End Sub

    ''MONTA ITENS"""""""""""""""""""""""""
    Private Function MontaItens(strItens As String, strRel As String) As String
        Dim count As Integer = 1
        Dim ret As String = ""

        Dim totalbruto As Double
        lblTotalRel.Text = ""
        lblNumreg.Text = "Número de Registros: "

        Try
            Dim linha As Double = 1


            For Each d In listConta

                'If d.TipoConta = 0 Then
                '    tipoMov = "Saída"
                'Else
                '    tipoMov = "Entrada"
                'End If

                Dim dataHoje As DateTime = Now.ToShortDateString

                If d.DataVencimento = dataHoje Then

                    linha = count / 2
                    If linha.ToString.Contains(",5") Then
                        ret += strItens.Replace("{{dataVencimento}}", d.DataVencimento) _
                            .Replace("{{Credor}}", d.Credor.Nome) _
                            .Replace("{{TipoConta}}", d.TipoConta.Descricao) _
                            .Replace("{{Banco}}", d.Banco.Descricao) _
                            .Replace("{{Controle}}", d.Controle) _
                            .Replace("{{Valor}}", FormatCurrency(d.Valor, 2)) _
                            .Replace("{{Status}}", d.Status.Descricao) _
                            .Replace("<linha>", "<tr style='background-color: #ccffee; color: black;'>")
                    Else
                        ret += strItens.Replace("{{dataVencimento}}", d.DataVencimento) _
                            .Replace("{{Credor}}", d.Credor.Nome) _
                            .Replace("{{TipoConta}}", d.TipoConta.Descricao) _
                            .Replace("{{Banco}}", d.Banco.Descricao) _
                            .Replace("{{Controle}}", d.Controle) _
                            .Replace("{{Valor}}", FormatCurrency(d.Valor, 2)) _
                            .Replace("{{Status}}", d.Status.Descricao) _
                            .Replace("<linha>", "<tr style='background-color: #cceeff; color: black;'>")
                    End If

                ElseIf d.DataVencimento < dataHoje Then


                    ret += strItens.Replace("{{dataVencimento}}", d.DataVencimento) _
                            .Replace("{{Credor}}", d.Credor.Nome) _
                            .Replace("{{TipoConta}}", d.TipoConta.Descricao) _
                            .Replace("{{Banco}}", d.Banco.Descricao) _
                            .Replace("{{Controle}}", d.Controle) _
                            .Replace("{{Valor}}", FormatCurrency(d.Valor, 2)) _
                            .Replace("{{Status}}", d.Status.Descricao) _
                            .Replace("<linha>", "<tr style='background-color: #ffc0cb ; color: black;'>")


                Else
                    linha = count / 2
                    If linha.ToString.Contains(",5") Then
                        ret += strItens.Replace("{{dataVencimento}}", d.DataVencimento) _
                            .Replace("{{Credor}}", d.Credor.Nome) _
                            .Replace("{{TipoConta}}", d.TipoConta.Descricao) _
                            .Replace("{{Banco}}", d.Banco.Descricao) _
                            .Replace("{{Controle}}", d.Controle) _
                            .Replace("{{Valor}}", FormatCurrency(d.Valor, 2)) _
                            .Replace("{{Status}}", d.Status.Descricao) _
                            .Replace("<linha>", "<tr style='background-color: white; color: black;'>")
                    Else
                        ret += strItens.Replace("{{dataVencimento}}", d.DataVencimento) _
                            .Replace("{{Credor}}", d.Credor.Nome) _
                            .Replace("{{TipoConta}}", d.TipoConta.Descricao) _
                            .Replace("{{Banco}}", d.Banco.Descricao) _
                            .Replace("{{Controle}}", d.Controle) _
                            .Replace("{{Valor}}", FormatCurrency(d.Valor, 2)) _
                            .Replace("{{Status}}", d.Status.Descricao) _
                            .Replace("<linha>", "<tr style='background-color: #dadada; color: black;'>")
                    End If

                End If


                count += 1
                totalbruto += d.Valor

            Next

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try

        ret = strRel.Replace("<dados></dados>", ret).Replace("<cabecalho></cabecalho>", cabecalho)

        lblTotalRel.Text = FormatCurrency(totalbruto, 2).ToString
        lblNumreg.Text += listConta.Count.ToString

        Return ret

    End Function

    Private Sub ckPeriodoConta_CheckedChanged(sender As Object, e As EventArgs) Handles ckPeriodoConta.CheckedChanged
        gbDataInicioCliente.Enabled = Not ckPeriodoConta.Checked
        gbDataFimCliente.Enabled = Not ckPeriodoConta.Checked
    End Sub

    Private Sub btPlanilha_Click(sender As Object, e As EventArgs) Handles btPlanilha.Click
        Dim FILE_NAME As String = "C:\Users\rafat\Google Drive\Dona Nize\PLANILHACONTROLE.ods"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("Arquivo não Encontrado")
        End If
    End Sub

    Private Sub btGerenciar_Click(sender As Object, e As EventArgs) Handles btGerenciar.Click
        EditConta.ShowDialog(Me)
    End Sub

    Private Sub btCtHoje_Click(sender As Object, e As EventArgs) Handles btCtHoje.Click
        db = New DbContexto

        If Now.Day < 10 Then
            cabecalho = "CONTAS ATÉ DIA 0" + Now.Day.ToString + " DE " + (culture.TextInfo.ToTitleCase(formataData.GetMonthName(Now.Month.ToString))).ToUpper
        Else
            cabecalho = "CONTAS ATÉ DIA " + Now.Day.ToString + " DE " + (culture.TextInfo.ToTitleCase(formataData.GetMonthName(Now.Month.ToString))).ToUpper
        End If

        Try

            Dim dataHoje As DateTime = Now.ToShortDateString

            listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                         Where i.Status.Id = 1 And i.DataVencimento <= dataHoje Select i).ToList
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Exit Sub
        End Try

        lblTotalRel.Visible = True
        lblNumreg.Visible = True
        gbResumo.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelContasItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelContas.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = MontaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados

    End Sub

    Private Sub btContaMes_Click(sender As Object, e As EventArgs) Handles btContaMes.Click
        db = New DbContexto

        cabecalho = "CONTAS ATÉ MÊS DE " + (culture.TextInfo.ToTitleCase(formataData.GetMonthName(Now.Month.ToString))).ToUpper


        Try

            Dim dataHoje As DateTime = Now.ToShortDateString

            listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                         Where i.Status.Id = 1 And i.DataVencimento.Month <= Now.Month And i.DataVencimento.Year <= Now.Year Select i).ToList
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Exit Sub
        End Try

        lblTotalRel.Visible = True
        lblNumreg.Visible = True
        gbResumo.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelContasItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelContas.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = MontaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        db = New DbContexto

        cabecalho = "TODAS AS CONTAS"


        Try

            Dim dataHoje As DateTime = Now.ToShortDateString

            listConta = (From i In db.Conta.Include("Credor").Include("TipoConta").Include("Banco").Include("Status") Order By i.DataVencimento
                         Where i.Status.Id = 1 Select i).ToList
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Exit Sub
        End Try

        lblTotalRel.Visible = True
        lblNumreg.Visible = True
        gbResumo.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelContasItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelContas.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = MontaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados
    End Sub
End Class