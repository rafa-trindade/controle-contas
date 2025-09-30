Imports Contas.Dominio


Module Util
    Public Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function

    Public Sub LimparCampos(ByVal controlPai As Object)

        For Each ctl As Control In controlPai.Controls

            If TypeOf (ctl) Is TextBox Then 'TextBox
                DirectCast(ctl, TextBox).Text = String.Empty
            ElseIf TypeOf (ctl) Is CheckBox Then 'CheckBox
                DirectCast(ctl, CheckBox).Checked = False
            ElseIf TypeOf (ctl) Is ComboBox Then 'ComboBox
                DirectCast(ctl, ComboBox).SelectedIndex = -1
            ElseIf TypeOf (ctl) Is DataGrid Then 'Datagrid
                DirectCast(ctl, DataGrid).DataSource = Nothing
            ElseIf ctl.Controls.Count > 0 Then
                LimparCampos(ctl)
            End If

        Next
    End Sub

    Public Sub TextBoxMoeda(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = "000"
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            MessageBox.Show(ex.Message, "TextBoxMoeda")
        End Try
    End Sub

    Public Function TextBoxCpfCnpj(ByRef txt As TextBox) As Boolean
        If Len(txt.Text) = 14 Then
            txt.Text = txt.Text.Substring(0, 2) & "." & txt.Text.Substring(2, 3) & "." & txt.Text.Substring(5, 3) & "/" & txt.Text.Substring(8, 4) & "-" & txt.Text.Substring(12)
        ElseIf Len(txt.Text) = 11 Then
            txt.Text = txt.Text.Substring(0, 3) & "." & txt.Text.Substring(3, 3) & "." & txt.Text.Substring(6, 3) & "-" & txt.Text.Substring(9)
        Else
            MsgBox("Formato inválido, verifique!", vbCritical)
            txt.Focus()
            Return False
        End If

        Return True
    End Function

    Public Function LeNumero(Numero As String) As String
        Dim Tamanho As Integer, RESULTADO As String = "", A As Integer

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Função que pega apenas os valores numericos da string
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If Numero = "" Then
            LeNumero = 0
            Exit Function
        End If

        Tamanho = Len(Trim(Numero))

        For A = 1 To Tamanho
            If Asc(Mid(Numero, A, 1)) >= 48 And Asc(Mid(Numero, A, 1)) <= 57 Then
                RESULTADO = RESULTADO + Mid(Numero, A, 1)
            End If
        Next
        LeNumero = RESULTADO
    End Function

    Public Sub validaCel(ByRef txtCelular As MaskedTextBox)
        Try
            'If Digito9(txtCelular.Text) = True Then
            'Troca a mascara do campo
            If LeNumero(txtCelular.Text).Length = 10 Then
                txtCelular.Mask = "(99) 9999-9999"
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


End Module


