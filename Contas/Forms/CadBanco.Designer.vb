<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadBanco
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadBanco))
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gbDetalhesApartamento = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescrição = New System.Windows.Forms.TextBox()
        Me.grdBancos = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalhesApartamento.SuspendLayout()
        CType(Me.grdBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btLimpar
        '
        Me.btLimpar.BackgroundImage = CType(resources.GetObject("btLimpar.BackgroundImage"), System.Drawing.Image)
        Me.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Location = New System.Drawing.Point(12, 346)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(92, 23)
        Me.btLimpar.TabIndex = 85
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'btSalvar
        '
        Me.btSalvar.BackgroundImage = CType(resources.GetObject("btSalvar.BackgroundImage"), System.Drawing.Image)
        Me.btSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.ForeColor = System.Drawing.SystemColors.Window
        Me.btSalvar.Location = New System.Drawing.Point(231, 346)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(92, 23)
        Me.btSalvar.TabIndex = 84
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Contas.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Contas.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(329, 346)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(81, 23)
        Me.btSair.TabIndex = 86
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Contas.My.Resources.Resources.bg_headerprinc1
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 376)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(422, 17)
        Me.PictureBox2.TabIndex = 88
        Me.PictureBox2.TabStop = False
        '
        'gbDetalhesApartamento
        '
        Me.gbDetalhesApartamento.Controls.Add(Me.Label1)
        Me.gbDetalhesApartamento.Controls.Add(Me.txtDescrição)
        Me.gbDetalhesApartamento.Location = New System.Drawing.Point(12, 282)
        Me.gbDetalhesApartamento.Name = "gbDetalhesApartamento"
        Me.gbDetalhesApartamento.Size = New System.Drawing.Size(398, 58)
        Me.gbDetalhesApartamento.TabIndex = 87
        Me.gbDetalhesApartamento.TabStop = False
        Me.gbDetalhesApartamento.Text = "INFORMAÇÕES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Descrição:"
        '
        'txtDescrição
        '
        Me.txtDescrição.Location = New System.Drawing.Point(92, 23)
        Me.txtDescrição.MaxLength = 9999
        Me.txtDescrição.Name = "txtDescrição"
        Me.txtDescrição.Size = New System.Drawing.Size(300, 20)
        Me.txtDescrição.TabIndex = 1
        '
        'grdBancos
        '
        Me.grdBancos.AllowUserToDeleteRows = False
        Me.grdBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBancos.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdBancos.Location = New System.Drawing.Point(0, 0)
        Me.grdBancos.MultiSelect = False
        Me.grdBancos.Name = "grdBancos"
        Me.grdBancos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdBancos.Size = New System.Drawing.Size(422, 276)
        Me.grdBancos.TabIndex = 83
        '
        'CadBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Contas.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(422, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gbDetalhesApartamento)
        Me.Controls.Add(Me.grdBancos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "CadBanco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Bancos"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalhesApartamento.ResumeLayout(False)
        Me.gbDetalhesApartamento.PerformLayout()
        CType(Me.grdBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btLimpar As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btSair As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gbDetalhesApartamento As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescrição As TextBox
    Friend WithEvents grdBancos As DataGridView
End Class
