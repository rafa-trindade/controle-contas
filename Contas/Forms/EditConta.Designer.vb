<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditConta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditConta))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btPagar = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnCadConta = New System.Windows.Forms.Button()
        Me.gbPesqConta = New System.Windows.Forms.GroupBox()
        Me.cbPesqTipo = New System.Windows.Forms.ComboBox()
        Me.lbIdConta = New System.Windows.Forms.Label()
        Me.cbStatusConta = New System.Windows.Forms.CheckBox()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeCredor = New System.Windows.Forms.TextBox()
        Me.btPesqCliente = New System.Windows.Forms.Button()
        Me.gbDetalhesConta = New System.Windows.Forms.GroupBox()
        Me.btAtualizarControle = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtControle = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btAtualizarBanco = New System.Windows.Forms.Button()
        Me.cbBanco = New System.Windows.Forms.ComboBox()
        Me.btAtualizarValor = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btAtualizarrTipo = New System.Windows.Forms.Button()
        Me.cbTipoConta = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUltimaMod = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbDataEntrada = New System.Windows.Forms.GroupBox()
        Me.btAtualizarVencimento = New System.Windows.Forms.Button()
        Me.dtVencimento = New System.Windows.Forms.DateTimePicker()
        Me.btReabrir = New System.Windows.Forms.Button()
        Me.cmsExcluirConta = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btExcluir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPesqConta.SuspendLayout()
        Me.gbDetalhesConta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbDataEntrada.SuspendLayout()
        Me.cmsExcluirConta.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(367, 57)
        Me.PictureBox1.TabIndex = 230
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 456)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(367, 17)
        Me.PictureBox2.TabIndex = 229
        Me.PictureBox2.TabStop = False
        '
        'btPagar
        '
        Me.btPagar.BackgroundImage = Global.Contas.My.Resources.Resources.btn_azul
        Me.btPagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPagar.ForeColor = System.Drawing.SystemColors.Window
        Me.btPagar.Location = New System.Drawing.Point(8, 425)
        Me.btPagar.Name = "btPagar"
        Me.btPagar.Size = New System.Drawing.Size(67, 23)
        Me.btPagar.TabIndex = 232
        Me.btPagar.Text = "Pagar"
        Me.btPagar.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Contas.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Contas.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(264, 425)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(95, 23)
        Me.btSair.TabIndex = 233
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblStatus.Location = New System.Drawing.Point(12, 71)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 13)
        Me.lblStatus.TabIndex = 235
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Visible = False
        '
        'btnCadConta
        '
        Me.btnCadConta.BackgroundImage = Global.Contas.My.Resources.Resources.btn_azul
        Me.btnCadConta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCadConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadConta.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCadConta.Location = New System.Drawing.Point(245, 66)
        Me.btnCadConta.Name = "btnCadConta"
        Me.btnCadConta.Size = New System.Drawing.Size(114, 23)
        Me.btnCadConta.TabIndex = 234
        Me.btnCadConta.Text = "Cadastrar Conta"
        Me.btnCadConta.UseVisualStyleBackColor = True
        '
        'gbPesqConta
        '
        Me.gbPesqConta.Controls.Add(Me.cbPesqTipo)
        Me.gbPesqConta.Controls.Add(Me.lbIdConta)
        Me.gbPesqConta.Controls.Add(Me.cbStatusConta)
        Me.gbPesqConta.Controls.Add(Me.btLimpar)
        Me.gbPesqConta.Controls.Add(Me.Label3)
        Me.gbPesqConta.Controls.Add(Me.txtNomeCredor)
        Me.gbPesqConta.Controls.Add(Me.btPesqCliente)
        Me.gbPesqConta.Location = New System.Drawing.Point(8, 93)
        Me.gbPesqConta.Name = "gbPesqConta"
        Me.gbPesqConta.Size = New System.Drawing.Size(351, 81)
        Me.gbPesqConta.TabIndex = 236
        Me.gbPesqConta.TabStop = False
        Me.gbPesqConta.Text = "PESQUISAR CONTA"
        '
        'cbPesqTipo
        '
        Me.cbPesqTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPesqTipo.FormattingEnabled = True
        Me.cbPesqTipo.Location = New System.Drawing.Point(127, 19)
        Me.cbPesqTipo.Name = "cbPesqTipo"
        Me.cbPesqTipo.Size = New System.Drawing.Size(114, 21)
        Me.cbPesqTipo.TabIndex = 238
        '
        'lbIdConta
        '
        Me.lbIdConta.AutoSize = True
        Me.lbIdConta.Location = New System.Drawing.Point(203, 22)
        Me.lbIdConta.Name = "lbIdConta"
        Me.lbIdConta.Size = New System.Drawing.Size(39, 13)
        Me.lbIdConta.TabIndex = 223
        Me.lbIdConta.Text = "Label1"
        Me.lbIdConta.Visible = False
        '
        'cbStatusConta
        '
        Me.cbStatusConta.AutoSize = True
        Me.cbStatusConta.Checked = True
        Me.cbStatusConta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbStatusConta.Location = New System.Drawing.Point(11, 22)
        Me.cbStatusConta.Name = "cbStatusConta"
        Me.cbStatusConta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbStatusConta.Size = New System.Drawing.Size(110, 17)
        Me.cbStatusConta.TabIndex = 222
        Me.cbStatusConta.Text = "Contas em Aberto"
        Me.cbStatusConta.UseVisualStyleBackColor = True
        '
        'btLimpar
        '
        Me.btLimpar.BackgroundImage = Global.Contas.My.Resources.Resources.btn_azul
        Me.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Location = New System.Drawing.Point(248, 18)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(87, 23)
        Me.btLimpar.TabIndex = 53
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Credor:"
        '
        'txtNomeCredor
        '
        Me.txtNomeCredor.Location = New System.Drawing.Point(50, 47)
        Me.txtNomeCredor.Name = "txtNomeCredor"
        Me.txtNomeCredor.Size = New System.Drawing.Size(191, 20)
        Me.txtNomeCredor.TabIndex = 2
        '
        'btPesqCliente
        '
        Me.btPesqCliente.BackgroundImage = Global.Contas.My.Resources.Resources.btn_cinza
        Me.btPesqCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btPesqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesqCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesqCliente.Image = Global.Contas.My.Resources.Resources.search_folder
        Me.btPesqCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPesqCliente.Location = New System.Drawing.Point(247, 46)
        Me.btPesqCliente.Name = "btPesqCliente"
        Me.btPesqCliente.Size = New System.Drawing.Size(88, 23)
        Me.btPesqCliente.TabIndex = 49
        Me.btPesqCliente.Text = "Pesquisar"
        Me.btPesqCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesqCliente.UseVisualStyleBackColor = True
        '
        'gbDetalhesConta
        '
        Me.gbDetalhesConta.Controls.Add(Me.btAtualizarControle)
        Me.gbDetalhesConta.Controls.Add(Me.Label4)
        Me.gbDetalhesConta.Controls.Add(Me.txtControle)
        Me.gbDetalhesConta.Controls.Add(Me.GroupBox1)
        Me.gbDetalhesConta.Controls.Add(Me.btAtualizarValor)
        Me.gbDetalhesConta.Controls.Add(Me.txtValor)
        Me.gbDetalhesConta.Controls.Add(Me.GroupBox3)
        Me.gbDetalhesConta.Controls.Add(Me.GroupBox2)
        Me.gbDetalhesConta.Controls.Add(Me.Label5)
        Me.gbDetalhesConta.Controls.Add(Me.gbDataEntrada)
        Me.gbDetalhesConta.Location = New System.Drawing.Point(8, 180)
        Me.gbDetalhesConta.Name = "gbDetalhesConta"
        Me.gbDetalhesConta.Size = New System.Drawing.Size(351, 239)
        Me.gbDetalhesConta.TabIndex = 53
        Me.gbDetalhesConta.TabStop = False
        Me.gbDetalhesConta.Text = "DADOS DA CONTA"
        '
        'btAtualizarControle
        '
        Me.btAtualizarControle.BackgroundImage = CType(resources.GetObject("btAtualizarControle.BackgroundImage"), System.Drawing.Image)
        Me.btAtualizarControle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btAtualizarControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAtualizarControle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtualizarControle.ForeColor = System.Drawing.SystemColors.Window
        Me.btAtualizarControle.Location = New System.Drawing.Point(12, 148)
        Me.btAtualizarControle.Name = "btAtualizarControle"
        Me.btAtualizarControle.Size = New System.Drawing.Size(137, 23)
        Me.btAtualizarControle.TabIndex = 107
        Me.btAtualizarControle.Text = "Atualizar Controle"
        Me.btAtualizarControle.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Controle:"
        '
        'txtControle
        '
        Me.txtControle.Location = New System.Drawing.Point(60, 123)
        Me.txtControle.Name = "txtControle"
        Me.txtControle.Size = New System.Drawing.Size(89, 20)
        Me.txtControle.TabIndex = 105
        Me.txtControle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btAtualizarBanco)
        Me.GroupBox1.Controls.Add(Me.cbBanco)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 46)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Banco"
        '
        'btAtualizarBanco
        '
        Me.btAtualizarBanco.BackgroundImage = CType(resources.GetObject("btAtualizarBanco.BackgroundImage"), System.Drawing.Image)
        Me.btAtualizarBanco.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btAtualizarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAtualizarBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtualizarBanco.ForeColor = System.Drawing.SystemColors.Window
        Me.btAtualizarBanco.Location = New System.Drawing.Point(194, 17)
        Me.btAtualizarBanco.Name = "btAtualizarBanco"
        Me.btAtualizarBanco.Size = New System.Drawing.Size(134, 23)
        Me.btAtualizarBanco.TabIndex = 80
        Me.btAtualizarBanco.Text = "Atalizar Banco"
        Me.btAtualizarBanco.UseVisualStyleBackColor = True
        '
        'cbBanco
        '
        Me.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Location = New System.Drawing.Point(6, 19)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(182, 21)
        Me.cbBanco.TabIndex = 46
        '
        'btAtualizarValor
        '
        Me.btAtualizarValor.BackgroundImage = CType(resources.GetObject("btAtualizarValor.BackgroundImage"), System.Drawing.Image)
        Me.btAtualizarValor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btAtualizarValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAtualizarValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtualizarValor.ForeColor = System.Drawing.SystemColors.Window
        Me.btAtualizarValor.Location = New System.Drawing.Point(205, 148)
        Me.btAtualizarValor.Name = "btAtualizarValor"
        Me.btAtualizarValor.Size = New System.Drawing.Size(130, 23)
        Me.btAtualizarValor.TabIndex = 81
        Me.btAtualizarValor.Text = "Atualizar Valor"
        Me.btAtualizarValor.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(253, 123)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(82, 20)
        Me.txtValor.TabIndex = 65
        Me.txtValor.Text = "0,00"
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btAtualizarrTipo)
        Me.GroupBox3.Controls.Add(Me.cbTipoConta)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 46)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pagamento"
        '
        'btAtualizarrTipo
        '
        Me.btAtualizarrTipo.BackgroundImage = CType(resources.GetObject("btAtualizarrTipo.BackgroundImage"), System.Drawing.Image)
        Me.btAtualizarrTipo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btAtualizarrTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAtualizarrTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtualizarrTipo.ForeColor = System.Drawing.SystemColors.Window
        Me.btAtualizarrTipo.Location = New System.Drawing.Point(194, 17)
        Me.btAtualizarrTipo.Name = "btAtualizarrTipo"
        Me.btAtualizarrTipo.Size = New System.Drawing.Size(135, 23)
        Me.btAtualizarrTipo.TabIndex = 80
        Me.btAtualizarrTipo.Text = "Atalizar Tipo"
        Me.btAtualizarrTipo.UseVisualStyleBackColor = True
        '
        'cbTipoConta
        '
        Me.cbTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoConta.FormattingEnabled = True
        Me.cbTipoConta.Location = New System.Drawing.Point(6, 19)
        Me.cbTipoConta.Name = "cbTipoConta"
        Me.cbTipoConta.Size = New System.Drawing.Size(182, 21)
        Me.cbTipoConta.TabIndex = 46
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUltimaMod)
        Me.GroupBox2.Location = New System.Drawing.Point(219, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(123, 49)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Última Modificação"
        '
        'lblUltimaMod
        '
        Me.lblUltimaMod.AutoSize = True
        Me.lblUltimaMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimaMod.ForeColor = System.Drawing.Color.Teal
        Me.lblUltimaMod.Location = New System.Drawing.Point(25, 23)
        Me.lblUltimaMod.Name = "lblUltimaMod"
        Me.lblUltimaMod.Size = New System.Drawing.Size(75, 13)
        Me.lblUltimaMod.TabIndex = 236
        Me.lblUltimaMod.Text = "01/06/2020"
        Me.lblUltimaMod.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Valor: R$"
        '
        'gbDataEntrada
        '
        Me.gbDataEntrada.Controls.Add(Me.btAtualizarVencimento)
        Me.gbDataEntrada.Controls.Add(Me.dtVencimento)
        Me.gbDataEntrada.Location = New System.Drawing.Point(7, 183)
        Me.gbDataEntrada.Name = "gbDataEntrada"
        Me.gbDataEntrada.Size = New System.Drawing.Size(206, 49)
        Me.gbDataEntrada.TabIndex = 49
        Me.gbDataEntrada.TabStop = False
        Me.gbDataEntrada.Text = "Vencimento"
        '
        'btAtualizarVencimento
        '
        Me.btAtualizarVencimento.BackgroundImage = CType(resources.GetObject("btAtualizarVencimento.BackgroundImage"), System.Drawing.Image)
        Me.btAtualizarVencimento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btAtualizarVencimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAtualizarVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtualizarVencimento.ForeColor = System.Drawing.SystemColors.Window
        Me.btAtualizarVencimento.Location = New System.Drawing.Point(113, 18)
        Me.btAtualizarVencimento.Name = "btAtualizarVencimento"
        Me.btAtualizarVencimento.Size = New System.Drawing.Size(87, 23)
        Me.btAtualizarVencimento.TabIndex = 108
        Me.btAtualizarVencimento.Text = "Atualizar"
        Me.btAtualizarVencimento.UseVisualStyleBackColor = True
        '
        'dtVencimento
        '
        Me.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVencimento.Location = New System.Drawing.Point(5, 19)
        Me.dtVencimento.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtVencimento.Name = "dtVencimento"
        Me.dtVencimento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtVencimento.Size = New System.Drawing.Size(102, 20)
        Me.dtVencimento.TabIndex = 43
        '
        'btReabrir
        '
        Me.btReabrir.BackgroundImage = Global.Contas.My.Resources.Resources.btn_azul
        Me.btReabrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btReabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReabrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReabrir.ForeColor = System.Drawing.SystemColors.Window
        Me.btReabrir.Location = New System.Drawing.Point(81, 425)
        Me.btReabrir.Name = "btReabrir"
        Me.btReabrir.Size = New System.Drawing.Size(67, 23)
        Me.btReabrir.TabIndex = 237
        Me.btReabrir.Text = "Reabrir"
        Me.btReabrir.UseVisualStyleBackColor = True
        '
        'cmsExcluirConta
        '
        Me.cmsExcluirConta.AllowDrop = True
        Me.cmsExcluirConta.BackgroundImage = Global.Contas.My.Resources.Resources.bg_header
        Me.cmsExcluirConta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.cmsExcluirConta.Name = "Excluir"
        Me.cmsExcluirConta.Size = New System.Drawing.Size(207, 48)
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir Registro de Conta"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'btExcluir
        '
        Me.btExcluir.BackgroundImage = Global.Contas.My.Resources.Resources.btn_azul
        Me.btExcluir.Enabled = False
        Me.btExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExcluir.ForeColor = System.Drawing.SystemColors.Window
        Me.btExcluir.Location = New System.Drawing.Point(154, 425)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(67, 23)
        Me.btExcluir.TabIndex = 238
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.UseVisualStyleBackColor = True
        '
        'EditConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Contas.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(367, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.btReabrir)
        Me.Controls.Add(Me.gbDetalhesConta)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCadConta)
        Me.Controls.Add(Me.gbPesqConta)
        Me.Controls.Add(Me.btPagar)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Contas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPesqConta.ResumeLayout(False)
        Me.gbPesqConta.PerformLayout()
        Me.gbDetalhesConta.ResumeLayout(False)
        Me.gbDetalhesConta.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbDataEntrada.ResumeLayout(False)
        Me.cmsExcluirConta.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btPagar As Button
    Friend WithEvents btSair As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnCadConta As Button
    Friend WithEvents gbPesqConta As GroupBox
    Friend WithEvents cbStatusConta As CheckBox
    Friend WithEvents btLimpar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomeCredor As TextBox
    Friend WithEvents btPesqCliente As Button
    Friend WithEvents gbDetalhesConta As GroupBox
    Friend WithEvents btAtualizarValor As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btAtualizarrTipo As Button
    Friend WithEvents cbTipoConta As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents gbDataEntrada As GroupBox
    Friend WithEvents dtVencimento As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btAtualizarBanco As Button
    Friend WithEvents cbBanco As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtControle As TextBox
    Friend WithEvents btAtualizarControle As Button
    Friend WithEvents lblUltimaMod As Label
    Friend WithEvents btAtualizarVencimento As Button
    Friend WithEvents btReabrir As Button
    Friend WithEvents lbIdConta As Label
    Friend WithEvents cmsExcluirConta As ContextMenuStrip
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbPesqTipo As ComboBox
    Friend WithEvents btExcluir As Button
End Class
