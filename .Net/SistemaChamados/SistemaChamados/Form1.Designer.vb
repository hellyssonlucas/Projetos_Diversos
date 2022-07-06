<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbTipoAtendimento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbSolicitante = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbCpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbValidaCpf = New System.Windows.Forms.Label()
        Me.lbCpf = New System.Windows.Forms.Label()
        Me.btEnviarAcesso = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxConstrutor = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUAU = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbEspelhoConstrutor = New System.Windows.Forms.TextBox()
        Me.CheckBoxEspelhoConstrutor = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDommus = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tbEspelhoDommus = New System.Windows.Forms.TextBox()
        Me.CheckBoxEspelhoDommus = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbEspelhoUAU = New System.Windows.Forms.TextBox()
        Me.CheckBoxEspelhoUAU = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxEmail = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRede = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxTodos = New System.Windows.Forms.CheckBox()
        Me.tbOutros = New System.Windows.Forms.TextBox()
        Me.CheckBoxAdm = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOutros = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbRedeEspelhoAD = New System.Windows.Forms.ComboBox()
        Me.CheckBoxRedeEspelho = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbEmailDirec = New System.Windows.Forms.TextBox()
        Me.CheckBoxEmailDirec = New System.Windows.Forms.CheckBox()
        Me.OptionNotebook = New System.Windows.Forms.RadioButton()
        Me.OptionDesktop = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbTipoAtendimento
        '
        Me.cbTipoAtendimento.FormattingEnabled = True
        Me.cbTipoAtendimento.Items.AddRange(New Object() {"ACESSOS", "SUPORTE GERAL"})
        Me.cbTipoAtendimento.Location = New System.Drawing.Point(343, 6)
        Me.cbTipoAtendimento.Name = "cbTipoAtendimento"
        Me.cbTipoAtendimento.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoAtendimento.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecione o tipo de Atendimento:"
        '
        'lbSolicitante
        '
        Me.lbSolicitante.AutoSize = True
        Me.lbSolicitante.Location = New System.Drawing.Point(86, 11)
        Me.lbSolicitante.Name = "lbSolicitante"
        Me.lbSolicitante.Size = New System.Drawing.Size(39, 13)
        Me.lbSolicitante.TabIndex = 3
        Me.lbSolicitante.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tbCpf)
        Me.Panel1.Controls.Add(Me.lbValidaCpf)
        Me.Panel1.Controls.Add(Me.lbCpf)
        Me.Panel1.Controls.Add(Me.btEnviarAcesso)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.OptionNotebook)
        Me.Panel1.Controls.Add(Me.OptionDesktop)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tbNome)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbSolicitante)
        Me.Panel1.Location = New System.Drawing.Point(12, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 368)
        Me.Panel1.TabIndex = 4
        '
        'tbCpf
        '
        Me.tbCpf.Location = New System.Drawing.Point(241, 70)
        Me.tbCpf.Mask = "999,999,999-99"
        Me.tbCpf.Name = "tbCpf"
        Me.tbCpf.Size = New System.Drawing.Size(89, 20)
        Me.tbCpf.TabIndex = 32
        '
        'lbValidaCpf
        '
        Me.lbValidaCpf.AutoSize = True
        Me.lbValidaCpf.Location = New System.Drawing.Point(310, 93)
        Me.lbValidaCpf.Name = "lbValidaCpf"
        Me.lbValidaCpf.Size = New System.Drawing.Size(0, 13)
        Me.lbValidaCpf.TabIndex = 31
        '
        'lbCpf
        '
        Me.lbCpf.AutoSize = True
        Me.lbCpf.Location = New System.Drawing.Point(208, 73)
        Me.lbCpf.Name = "lbCpf"
        Me.lbCpf.Size = New System.Drawing.Size(27, 13)
        Me.lbCpf.TabIndex = 30
        Me.lbCpf.Text = "CPF"
        '
        'btEnviarAcesso
        '
        Me.btEnviarAcesso.Location = New System.Drawing.Point(444, 322)
        Me.btEnviarAcesso.Name = "btEnviarAcesso"
        Me.btEnviarAcesso.Size = New System.Drawing.Size(110, 32)
        Me.btEnviarAcesso.TabIndex = 28
        Me.btEnviarAcesso.Text = "Abrir Chamado"
        Me.btEnviarAcesso.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CheckBoxConstrutor)
        Me.GroupBox8.Controls.Add(Me.CheckBoxUAU)
        Me.GroupBox8.Controls.Add(Me.GroupBox6)
        Me.GroupBox8.Controls.Add(Me.CheckBoxDommus)
        Me.GroupBox8.Controls.Add(Me.GroupBox5)
        Me.GroupBox8.Controls.Add(Me.GroupBox4)
        Me.GroupBox8.Location = New System.Drawing.Point(9, 234)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(378, 126)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SISTEMAS"
        '
        'CheckBoxConstrutor
        '
        Me.CheckBoxConstrutor.AutoSize = True
        Me.CheckBoxConstrutor.Location = New System.Drawing.Point(253, 33)
        Me.CheckBoxConstrutor.Name = "CheckBoxConstrutor"
        Me.CheckBoxConstrutor.Size = New System.Drawing.Size(113, 17)
        Me.CheckBoxConstrutor.TabIndex = 17
        Me.CheckBoxConstrutor.Text = "Construtor Vendas"
        Me.CheckBoxConstrutor.UseVisualStyleBackColor = True
        '
        'CheckBoxUAU
        '
        Me.CheckBoxUAU.AutoSize = True
        Me.CheckBoxUAU.Location = New System.Drawing.Point(11, 33)
        Me.CheckBoxUAU.Name = "CheckBoxUAU"
        Me.CheckBoxUAU.Size = New System.Drawing.Size(49, 17)
        Me.CheckBoxUAU.TabIndex = 15
        Me.CheckBoxUAU.Text = "UAU"
        Me.CheckBoxUAU.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.tbEspelhoConstrutor)
        Me.GroupBox6.Controls.Add(Me.CheckBoxEspelhoConstrutor)
        Me.GroupBox6.Location = New System.Drawing.Point(253, 46)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(113, 69)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        '
        'tbEspelhoConstrutor
        '
        Me.tbEspelhoConstrutor.Location = New System.Drawing.Point(6, 44)
        Me.tbEspelhoConstrutor.Name = "tbEspelhoConstrutor"
        Me.tbEspelhoConstrutor.Size = New System.Drawing.Size(99, 20)
        Me.tbEspelhoConstrutor.TabIndex = 24
        '
        'CheckBoxEspelhoConstrutor
        '
        Me.CheckBoxEspelhoConstrutor.AutoSize = True
        Me.CheckBoxEspelhoConstrutor.Location = New System.Drawing.Point(6, 19)
        Me.CheckBoxEspelhoConstrutor.Name = "CheckBoxEspelhoConstrutor"
        Me.CheckBoxEspelhoConstrutor.Size = New System.Drawing.Size(102, 17)
        Me.CheckBoxEspelhoConstrutor.TabIndex = 14
        Me.CheckBoxEspelhoConstrutor.Text = "Usuário espelho"
        Me.CheckBoxEspelhoConstrutor.UseVisualStyleBackColor = True
        '
        'CheckBoxDommus
        '
        Me.CheckBoxDommus.AutoSize = True
        Me.CheckBoxDommus.Location = New System.Drawing.Point(133, 33)
        Me.CheckBoxDommus.Name = "CheckBoxDommus"
        Me.CheckBoxDommus.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxDommus.TabIndex = 16
        Me.CheckBoxDommus.Text = "Dommus"
        Me.CheckBoxDommus.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tbEspelhoDommus)
        Me.GroupBox5.Controls.Add(Me.CheckBoxEspelhoDommus)
        Me.GroupBox5.Location = New System.Drawing.Point(133, 46)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(114, 69)
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
        '
        'tbEspelhoDommus
        '
        Me.tbEspelhoDommus.Location = New System.Drawing.Point(6, 44)
        Me.tbEspelhoDommus.Name = "tbEspelhoDommus"
        Me.tbEspelhoDommus.Size = New System.Drawing.Size(99, 20)
        Me.tbEspelhoDommus.TabIndex = 23
        '
        'CheckBoxEspelhoDommus
        '
        Me.CheckBoxEspelhoDommus.AutoSize = True
        Me.CheckBoxEspelhoDommus.Location = New System.Drawing.Point(4, 14)
        Me.CheckBoxEspelhoDommus.Name = "CheckBoxEspelhoDommus"
        Me.CheckBoxEspelhoDommus.Size = New System.Drawing.Size(102, 17)
        Me.CheckBoxEspelhoDommus.TabIndex = 14
        Me.CheckBoxEspelhoDommus.Text = "Usuário espelho"
        Me.CheckBoxEspelhoDommus.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbEspelhoUAU)
        Me.GroupBox4.Controls.Add(Me.CheckBoxEspelhoUAU)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 46)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(116, 69)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        '
        'tbEspelhoUAU
        '
        Me.tbEspelhoUAU.Location = New System.Drawing.Point(6, 42)
        Me.tbEspelhoUAU.Name = "tbEspelhoUAU"
        Me.tbEspelhoUAU.Size = New System.Drawing.Size(99, 20)
        Me.tbEspelhoUAU.TabIndex = 22
        '
        'CheckBoxEspelhoUAU
        '
        Me.CheckBoxEspelhoUAU.AutoSize = True
        Me.CheckBoxEspelhoUAU.Location = New System.Drawing.Point(6, 19)
        Me.CheckBoxEspelhoUAU.Name = "CheckBoxEspelhoUAU"
        Me.CheckBoxEspelhoUAU.Size = New System.Drawing.Size(102, 17)
        Me.CheckBoxEspelhoUAU.TabIndex = 14
        Me.CheckBoxEspelhoUAU.Text = "Usuário espelho"
        Me.CheckBoxEspelhoUAU.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.CheckBoxEmail)
        Me.GroupBox7.Controls.Add(Me.CheckBoxRede)
        Me.GroupBox7.Controls.Add(Me.GroupBox1)
        Me.GroupBox7.Controls.Add(Me.GroupBox2)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Location = New System.Drawing.Point(9, 103)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(584, 125)
        Me.GroupBox7.TabIndex = 27
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GERAL"
        '
        'CheckBoxEmail
        '
        Me.CheckBoxEmail.AutoSize = True
        Me.CheckBoxEmail.Location = New System.Drawing.Point(154, 33)
        Me.CheckBoxEmail.Name = "CheckBoxEmail"
        Me.CheckBoxEmail.Size = New System.Drawing.Size(61, 17)
        Me.CheckBoxEmail.TabIndex = 14
        Me.CheckBoxEmail.Text = "E-MAIL"
        Me.CheckBoxEmail.UseVisualStyleBackColor = True
        '
        'CheckBoxRede
        '
        Me.CheckBoxRede.AutoSize = True
        Me.CheckBoxRede.Location = New System.Drawing.Point(11, 33)
        Me.CheckBoxRede.Name = "CheckBoxRede"
        Me.CheckBoxRede.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxRede.TabIndex = 13
        Me.CheckBoxRede.Text = "REDE"
        Me.CheckBoxRede.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxTodos)
        Me.GroupBox1.Controls.Add(Me.tbOutros)
        Me.GroupBox1.Controls.Add(Me.CheckBoxAdm)
        Me.GroupBox1.Controls.Add(Me.CheckBoxOutros)
        Me.GroupBox1.Location = New System.Drawing.Point(400, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 93)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grupos de E-mails"
        '
        'CheckBoxTodos
        '
        Me.CheckBoxTodos.AutoSize = True
        Me.CheckBoxTodos.Location = New System.Drawing.Point(6, 19)
        Me.CheckBoxTodos.Name = "CheckBoxTodos"
        Me.CheckBoxTodos.Size = New System.Drawing.Size(64, 17)
        Me.CheckBoxTodos.TabIndex = 18
        Me.CheckBoxTodos.Text = "TODOS"
        Me.CheckBoxTodos.UseVisualStyleBackColor = True
        '
        'tbOutros
        '
        Me.tbOutros.Location = New System.Drawing.Point(84, 62)
        Me.tbOutros.Name = "tbOutros"
        Me.tbOutros.Size = New System.Drawing.Size(82, 20)
        Me.tbOutros.TabIndex = 21
        '
        'CheckBoxAdm
        '
        Me.CheckBoxAdm.AutoSize = True
        Me.CheckBoxAdm.Location = New System.Drawing.Point(6, 42)
        Me.CheckBoxAdm.Name = "CheckBoxAdm"
        Me.CheckBoxAdm.Size = New System.Drawing.Size(118, 17)
        Me.CheckBoxAdm.TabIndex = 19
        Me.CheckBoxAdm.Text = "ADMINISTRATIVO"
        Me.CheckBoxAdm.UseVisualStyleBackColor = True
        '
        'CheckBoxOutros
        '
        Me.CheckBoxOutros.AutoSize = True
        Me.CheckBoxOutros.Location = New System.Drawing.Point(6, 65)
        Me.CheckBoxOutros.Name = "CheckBoxOutros"
        Me.CheckBoxOutros.Size = New System.Drawing.Size(72, 17)
        Me.CheckBoxOutros.TabIndex = 20
        Me.CheckBoxOutros.Text = "OUTROS"
        Me.CheckBoxOutros.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbRedeEspelhoAD)
        Me.GroupBox2.Controls.Add(Me.CheckBoxRedeEspelho)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 69)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'cbRedeEspelhoAD
        '
        Me.cbRedeEspelhoAD.FormattingEnabled = True
        Me.cbRedeEspelhoAD.Location = New System.Drawing.Point(6, 42)
        Me.cbRedeEspelhoAD.Name = "cbRedeEspelhoAD"
        Me.cbRedeEspelhoAD.Size = New System.Drawing.Size(121, 21)
        Me.cbRedeEspelhoAD.TabIndex = 15
        '
        'CheckBoxRedeEspelho
        '
        Me.CheckBoxRedeEspelho.AutoSize = True
        Me.CheckBoxRedeEspelho.Location = New System.Drawing.Point(6, 19)
        Me.CheckBoxRedeEspelho.Name = "CheckBoxRedeEspelho"
        Me.CheckBoxRedeEspelho.Size = New System.Drawing.Size(102, 17)
        Me.CheckBoxRedeEspelho.TabIndex = 14
        Me.CheckBoxRedeEspelho.Text = "Usuário espelho"
        Me.CheckBoxRedeEspelho.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbEmailDirec)
        Me.GroupBox3.Controls.Add(Me.CheckBoxEmailDirec)
        Me.GroupBox3.Location = New System.Drawing.Point(154, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 69)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'tbEmailDirec
        '
        Me.tbEmailDirec.Location = New System.Drawing.Point(6, 42)
        Me.tbEmailDirec.Name = "tbEmailDirec"
        Me.tbEmailDirec.Size = New System.Drawing.Size(228, 20)
        Me.tbEmailDirec.TabIndex = 22
        '
        'CheckBoxEmailDirec
        '
        Me.CheckBoxEmailDirec.AutoSize = True
        Me.CheckBoxEmailDirec.Location = New System.Drawing.Point(6, 19)
        Me.CheckBoxEmailDirec.Name = "CheckBoxEmailDirec"
        Me.CheckBoxEmailDirec.Size = New System.Drawing.Size(198, 17)
        Me.CheckBoxEmailDirec.TabIndex = 14
        Me.CheckBoxEmailDirec.Text = "Direcionar e-mail abaixo para o novo"
        Me.CheckBoxEmailDirec.UseVisualStyleBackColor = True
        '
        'OptionNotebook
        '
        Me.OptionNotebook.AutoSize = True
        Me.OptionNotebook.Location = New System.Drawing.Point(98, 73)
        Me.OptionNotebook.Name = "OptionNotebook"
        Me.OptionNotebook.Size = New System.Drawing.Size(85, 17)
        Me.OptionNotebook.TabIndex = 11
        Me.OptionNotebook.TabStop = True
        Me.OptionNotebook.Text = "NOTEBOOK"
        Me.OptionNotebook.UseVisualStyleBackColor = True
        '
        'OptionDesktop
        '
        Me.OptionDesktop.AutoSize = True
        Me.OptionDesktop.Location = New System.Drawing.Point(98, 50)
        Me.OptionDesktop.Name = "OptionDesktop"
        Me.OptionDesktop.Size = New System.Drawing.Size(76, 17)
        Me.OptionDesktop.TabIndex = 10
        Me.OptionDesktop.TabStop = True
        Me.OptionDesktop.Text = "DESKTOP"
        Me.OptionDesktop.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Equipamento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(528, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "* Obrigatório"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NOME COMPLETO"
        '
        'tbNome
        '
        Me.tbNome.Location = New System.Drawing.Point(337, 27)
        Me.tbNome.Name = "tbNome"
        Me.tbNome.Size = New System.Drawing.Size(185, 20)
        Me.tbNome.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Acesso para:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Solicitante:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 412)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbTipoAtendimento)
        Me.Name = "Form1"
        Me.Text = "Sistema de Chamados TI - CEA Construtora (SOLICITANTE)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbTipoAtendimento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbSolicitante As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxTodos As CheckBox
    Friend WithEvents tbOutros As TextBox
    Friend WithEvents CheckBoxAdm As CheckBox
    Friend WithEvents CheckBoxOutros As CheckBox
    Friend WithEvents CheckBoxConstrutor As CheckBox
    Friend WithEvents CheckBoxDommus As CheckBox
    Friend WithEvents CheckBoxUAU As CheckBox
    Friend WithEvents CheckBoxEmail As CheckBox
    Friend WithEvents CheckBoxRede As CheckBox
    Friend WithEvents OptionNotebook As RadioButton
    Friend WithEvents OptionDesktop As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbEmailDirec As TextBox
    Friend WithEvents CheckBoxEmailDirec As CheckBox
    Friend WithEvents cbRedeEspelhoAD As ComboBox
    Friend WithEvents CheckBoxRedeEspelho As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CheckBoxEspelhoConstrutor As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CheckBoxEspelhoDommus As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBoxEspelhoUAU As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btEnviarAcesso As Button
    Friend WithEvents tbEspelhoConstrutor As TextBox
    Friend WithEvents tbEspelhoDommus As TextBox
    Friend WithEvents tbEspelhoUAU As TextBox
    Friend WithEvents lbCpf As Label
    Friend WithEvents lbValidaCpf As Label
    Friend WithEvents tbCpf As MaskedTextBox
End Class
