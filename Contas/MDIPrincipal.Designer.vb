<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btCadastrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.wbRels = New System.Windows.Forms.WebBrowser()
        Me.gbCliente = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbTipoConta = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbStatusConta = New System.Windows.Forms.ComboBox()
        Me.ckPeriodoConta = New System.Windows.Forms.CheckBox()
        Me.gbDataFimCliente = New System.Windows.Forms.GroupBox()
        Me.dtFimConta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.txtNomeCredor = New System.Windows.Forms.TextBox()
        Me.btPesqCliente = New System.Windows.Forms.Button()
        Me.gbDataInicioCliente = New System.Windows.Forms.GroupBox()
        Me.dtInicioConta = New System.Windows.Forms.DateTimePicker()
        Me.btGerarCliente = New System.Windows.Forms.Button()
        Me.gbResumo = New System.Windows.Forms.GroupBox()
        Me.lblNumreg = New System.Windows.Forms.Label()
        Me.lblTotalRel = New System.Windows.Forms.Label()
        Me.btPlanilha = New System.Windows.Forms.Button()
        Me.btGerenciar = New System.Windows.Forms.Button()
        Me.btCtHoje = New System.Windows.Forms.Button()
        Me.btContaMes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCliente.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDataFimCliente.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbDataInicioCliente.SuspendLayout()
        Me.gbResumo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Image = Global.Contas.My.Resources.Resources.bg_headerprinc
        Me.Label2.Location = New System.Drawing.Point(107, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 28)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "|"
        '
        'btCadastrar
        '
        Me.btCadastrar.BackgroundImage = Global.Contas.My.Resources.Resources.btn_azul
        Me.btCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCadastrar.ForeColor = System.Drawing.SystemColors.Window
        Me.btCadastrar.Location = New System.Drawing.Point(12, 17)
        Me.btCadastrar.Name = "btCadastrar"
        Me.btCadastrar.Size = New System.Drawing.Size(92, 23)
        Me.btCadastrar.TabIndex = 5
        Me.btCadastrar.Text = "Cadastrar"
        Me.btCadastrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Contas.My.Resources.Resources.bg_headerprinc
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1496, 43)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.Contas.My.Resources.Resources.bg_headerprinc
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 741)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1496, 22)
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'wbRels
        '
        Me.wbRels.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbRels.Location = New System.Drawing.Point(-1, 173)
        Me.wbRels.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbRels.Name = "wbRels"
        Me.wbRels.Size = New System.Drawing.Size(1496, 567)
        Me.wbRels.TabIndex = 84
        Me.wbRels.Url = New System.Uri("", System.UriKind.Relative)
        '
        'gbCliente
        '
        Me.gbCliente.Controls.Add(Me.GroupBox2)
        Me.gbCliente.Controls.Add(Me.GroupBox1)
        Me.gbCliente.Controls.Add(Me.ckPeriodoConta)
        Me.gbCliente.Controls.Add(Me.gbDataFimCliente)
        Me.gbCliente.Controls.Add(Me.GroupBox4)
        Me.gbCliente.Controls.Add(Me.gbDataInicioCliente)
        Me.gbCliente.Controls.Add(Me.btGerarCliente)
        Me.gbCliente.Location = New System.Drawing.Point(12, 56)
        Me.gbCliente.Name = "gbCliente"
        Me.gbCliente.Size = New System.Drawing.Size(650, 111)
        Me.gbCliente.TabIndex = 86
        Me.gbCliente.TabStop = False
        Me.gbCliente.Text = "FILTRAR RELATÓRIO DE CONTAS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbTipoConta)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(107, 43)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Conta"
        '
        'cbTipoConta
        '
        Me.cbTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoConta.FormattingEnabled = True
        Me.cbTipoConta.Location = New System.Drawing.Point(6, 16)
        Me.cbTipoConta.Name = "cbTipoConta"
        Me.cbTipoConta.Size = New System.Drawing.Size(90, 21)
        Me.cbTipoConta.TabIndex = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbStatusConta)
        Me.GroupBox1.Location = New System.Drawing.Point(431, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(102, 43)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'cbStatusConta
        '
        Me.cbStatusConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatusConta.FormattingEnabled = True
        Me.cbStatusConta.Items.AddRange(New Object() {"Todos", "Pago", "Em Aberto"})
        Me.cbStatusConta.Location = New System.Drawing.Point(6, 16)
        Me.cbStatusConta.Name = "cbStatusConta"
        Me.cbStatusConta.Size = New System.Drawing.Size(90, 21)
        Me.cbStatusConta.TabIndex = 69
        '
        'ckPeriodoConta
        '
        Me.ckPeriodoConta.AutoSize = True
        Me.ckPeriodoConta.Checked = True
        Me.ckPeriodoConta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckPeriodoConta.Location = New System.Drawing.Point(16, 74)
        Me.ckPeriodoConta.Name = "ckPeriodoConta"
        Me.ckPeriodoConta.Size = New System.Drawing.Size(70, 30)
        Me.ckPeriodoConta.TabIndex = 92
        Me.ckPeriodoConta.Text = "Todas as" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Datas"
        Me.ckPeriodoConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ckPeriodoConta.UseVisualStyleBackColor = True
        '
        'gbDataFimCliente
        '
        Me.gbDataFimCliente.Controls.Add(Me.dtFimConta)
        Me.gbDataFimCliente.Location = New System.Drawing.Point(205, 65)
        Me.gbDataFimCliente.Name = "gbDataFimCliente"
        Me.gbDataFimCliente.Size = New System.Drawing.Size(107, 43)
        Me.gbDataFimCliente.TabIndex = 91
        Me.gbDataFimCliente.TabStop = False
        Me.gbDataFimCliente.Text = "Data Fim:"
        '
        'dtFimConta
        '
        Me.dtFimConta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFimConta.Location = New System.Drawing.Point(5, 19)
        Me.dtFimConta.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtFimConta.Name = "dtFimConta"
        Me.dtFimConta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtFimConta.Size = New System.Drawing.Size(96, 20)
        Me.dtFimConta.TabIndex = 43
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btLimpar)
        Me.GroupBox4.Controls.Add(Me.txtNomeCredor)
        Me.GroupBox4.Controls.Add(Me.btPesqCliente)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(526, 43)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CREDOR"
        '
        'btLimpar
        '
        Me.btLimpar.BackgroundImage = CType(resources.GetObject("btLimpar.BackgroundImage"), System.Drawing.Image)
        Me.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Location = New System.Drawing.Point(431, 14)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(89, 23)
        Me.btLimpar.TabIndex = 59
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'txtNomeCredor
        '
        Me.txtNomeCredor.Location = New System.Drawing.Point(9, 15)
        Me.txtNomeCredor.Name = "txtNomeCredor"
        Me.txtNomeCredor.Size = New System.Drawing.Size(309, 20)
        Me.txtNomeCredor.TabIndex = 55
        '
        'btPesqCliente
        '
        Me.btPesqCliente.BackgroundImage = Global.Contas.My.Resources.Resources.btn_cinza
        Me.btPesqCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btPesqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesqCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesqCliente.Image = Global.Contas.My.Resources.Resources.search_folder
        Me.btPesqCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPesqCliente.Location = New System.Drawing.Point(324, 14)
        Me.btPesqCliente.Name = "btPesqCliente"
        Me.btPesqCliente.Size = New System.Drawing.Size(101, 23)
        Me.btPesqCliente.TabIndex = 58
        Me.btPesqCliente.Text = "Pesquisar"
        Me.btPesqCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesqCliente.UseVisualStyleBackColor = True
        '
        'gbDataInicioCliente
        '
        Me.gbDataInicioCliente.Controls.Add(Me.dtInicioConta)
        Me.gbDataInicioCliente.Location = New System.Drawing.Point(92, 65)
        Me.gbDataInicioCliente.Name = "gbDataInicioCliente"
        Me.gbDataInicioCliente.Size = New System.Drawing.Size(107, 43)
        Me.gbDataInicioCliente.TabIndex = 90
        Me.gbDataInicioCliente.TabStop = False
        Me.gbDataInicioCliente.Text = "Data Início:"
        '
        'dtInicioConta
        '
        Me.dtInicioConta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicioConta.Location = New System.Drawing.Point(5, 19)
        Me.dtInicioConta.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtInicioConta.Name = "dtInicioConta"
        Me.dtInicioConta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtInicioConta.Size = New System.Drawing.Size(96, 20)
        Me.dtInicioConta.TabIndex = 43
        '
        'btGerarCliente
        '
        Me.btGerarCliente.BackgroundImage = CType(resources.GetObject("btGerarCliente.BackgroundImage"), System.Drawing.Image)
        Me.btGerarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btGerarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerarCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.btGerarCliente.Location = New System.Drawing.Point(539, 81)
        Me.btGerarCliente.Name = "btGerarCliente"
        Me.btGerarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btGerarCliente.Size = New System.Drawing.Size(104, 23)
        Me.btGerarCliente.TabIndex = 68
        Me.btGerarCliente.Text = "Gerar Relatório"
        Me.btGerarCliente.UseVisualStyleBackColor = True
        '
        'gbResumo
        '
        Me.gbResumo.Controls.Add(Me.lblNumreg)
        Me.gbResumo.Controls.Add(Me.lblTotalRel)
        Me.gbResumo.Location = New System.Drawing.Point(668, 56)
        Me.gbResumo.Name = "gbResumo"
        Me.gbResumo.Size = New System.Drawing.Size(186, 111)
        Me.gbResumo.TabIndex = 112
        Me.gbResumo.TabStop = False
        Me.gbResumo.Text = "TOTAL A PAGAR"
        Me.gbResumo.Visible = False
        '
        'lblNumreg
        '
        Me.lblNumreg.AutoSize = True
        Me.lblNumreg.Location = New System.Drawing.Point(6, 42)
        Me.lblNumreg.Name = "lblNumreg"
        Me.lblNumreg.Size = New System.Drawing.Size(112, 13)
        Me.lblNumreg.TabIndex = 91
        Me.lblNumreg.Text = "Número de Registros: "
        Me.lblNumreg.Visible = False
        '
        'lblTotalRel
        '
        Me.lblTotalRel.AutoSize = True
        Me.lblTotalRel.Location = New System.Drawing.Point(6, 22)
        Me.lblTotalRel.Name = "lblTotalRel"
        Me.lblTotalRel.Size = New System.Drawing.Size(51, 13)
        Me.lblTotalRel.TabIndex = 90
        Me.lblTotalRel.Text = "Total: R$"
        Me.lblTotalRel.Visible = False
        '
        'btPlanilha
        '
        Me.btPlanilha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btPlanilha.BackgroundImage = Global.Contas.My.Resources.Resources.btn_azul
        Me.btPlanilha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btPlanilha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPlanilha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPlanilha.ForeColor = System.Drawing.SystemColors.Window
        Me.btPlanilha.Location = New System.Drawing.Point(1290, 17)
        Me.btPlanilha.Name = "btPlanilha"
        Me.btPlanilha.Size = New System.Drawing.Size(92, 23)
        Me.btPlanilha.TabIndex = 54
        Me.btPlanilha.Text = "Planilha"
        Me.btPlanilha.UseVisualStyleBackColor = True
        Me.btPlanilha.Visible = False
        '
        'btGerenciar
        '
        Me.btGerenciar.BackgroundImage = Global.Contas.My.Resources.Resources.btn_azul
        Me.btGerenciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerenciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerenciar.ForeColor = System.Drawing.SystemColors.Window
        Me.btGerenciar.Location = New System.Drawing.Point(125, 17)
        Me.btGerenciar.Name = "btGerenciar"
        Me.btGerenciar.Size = New System.Drawing.Size(92, 23)
        Me.btGerenciar.TabIndex = 113
        Me.btGerenciar.Text = "Gerenciar"
        Me.btGerenciar.UseVisualStyleBackColor = True
        '
        'btCtHoje
        '
        Me.btCtHoje.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCtHoje.BackgroundImage = CType(resources.GetObject("btCtHoje.BackgroundImage"), System.Drawing.Image)
        Me.btCtHoje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btCtHoje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCtHoje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCtHoje.ForeColor = System.Drawing.SystemColors.Window
        Me.btCtHoje.Location = New System.Drawing.Point(1379, 140)
        Me.btCtHoje.Name = "btCtHoje"
        Me.btCtHoje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btCtHoje.Size = New System.Drawing.Size(104, 23)
        Me.btCtHoje.TabIndex = 94
        Me.btCtHoje.Text = "Contas Hoje"
        Me.btCtHoje.UseVisualStyleBackColor = True
        '
        'btContaMes
        '
        Me.btContaMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btContaMes.BackgroundImage = CType(resources.GetObject("btContaMes.BackgroundImage"), System.Drawing.Image)
        Me.btContaMes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btContaMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btContaMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btContaMes.ForeColor = System.Drawing.SystemColors.Window
        Me.btContaMes.Location = New System.Drawing.Point(1378, 111)
        Me.btContaMes.Name = "btContaMes"
        Me.btContaMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btContaMes.Size = New System.Drawing.Size(104, 23)
        Me.btContaMes.TabIndex = 114
        Me.btContaMes.Text = "Contas "
        Me.btContaMes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(1378, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 115
        Me.Button1.Text = "Contas Geral"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Contas.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(1494, 761)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btContaMes)
        Me.Controls.Add(Me.btCtHoje)
        Me.Controls.Add(Me.btGerenciar)
        Me.Controls.Add(Me.gbResumo)
        Me.Controls.Add(Me.gbCliente)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.wbRels)
        Me.Controls.Add(Me.btPlanilha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btCadastrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MDIPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CONTAS A PAGAR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCliente.ResumeLayout(False)
        Me.gbCliente.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbDataFimCliente.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbDataInicioCliente.ResumeLayout(False)
        Me.gbResumo.ResumeLayout(False)
        Me.gbResumo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btCadastrar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents wbRels As WebBrowser
    Friend WithEvents gbCliente As GroupBox
    Friend WithEvents ckPeriodoConta As CheckBox
    Friend WithEvents gbDataFimCliente As GroupBox
    Friend WithEvents dtFimConta As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btLimpar As Button
    Friend WithEvents txtNomeCredor As TextBox
    Friend WithEvents btPesqCliente As Button
    Friend WithEvents cbStatusConta As ComboBox
    Friend WithEvents gbDataInicioCliente As GroupBox
    Friend WithEvents dtInicioConta As DateTimePicker
    Friend WithEvents btGerarCliente As Button
    Friend WithEvents gbResumo As GroupBox
    Friend WithEvents lblTotalRel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbTipoConta As ComboBox
    Friend WithEvents btPlanilha As Button
    Friend WithEvents btGerenciar As Button
    Friend WithEvents lblNumreg As Label
    Friend WithEvents btCtHoje As Button
    Friend WithEvents btContaMes As Button
    Friend WithEvents Button1 As Button
End Class
