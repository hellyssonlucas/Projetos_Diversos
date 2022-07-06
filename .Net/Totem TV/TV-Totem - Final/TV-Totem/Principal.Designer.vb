<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.btNovoEvento = New System.Windows.Forms.Button()
        Me.btCadastroNome = New System.Windows.Forms.Button()
        Me.btCadastroSala = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btNovoEvento
        '
        Me.btNovoEvento.Location = New System.Drawing.Point(88, 126)
        Me.btNovoEvento.Name = "btNovoEvento"
        Me.btNovoEvento.Size = New System.Drawing.Size(106, 54)
        Me.btNovoEvento.TabIndex = 0
        Me.btNovoEvento.Text = "Criar Evento"
        Me.btNovoEvento.UseVisualStyleBackColor = True
        '
        'btCadastroNome
        '
        Me.btCadastroNome.Location = New System.Drawing.Point(28, 66)
        Me.btCadastroNome.Name = "btCadastroNome"
        Me.btCadastroNome.Size = New System.Drawing.Size(108, 54)
        Me.btCadastroNome.TabIndex = 1
        Me.btCadastroNome.Text = "Cadastro Nome Eventos"
        Me.btCadastroNome.UseVisualStyleBackColor = True
        '
        'btCadastroSala
        '
        Me.btCadastroSala.Location = New System.Drawing.Point(142, 66)
        Me.btCadastroSala.Name = "btCadastroSala"
        Me.btCadastroSala.Size = New System.Drawing.Size(108, 54)
        Me.btCadastroSala.TabIndex = 2
        Me.btCadastroSala.Text = "Cadastro Nome Salas"
        Me.btCadastroSala.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.Location = New System.Drawing.Point(114, 186)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(51, 25)
        Me.btSair.TabIndex = 3
        Me.btSair.Text = "Sair"
        Me.btSair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Developed by Hellysson Lucas                                     v1.0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(65, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btCadastroSala)
        Me.Controls.Add(Me.btCadastroNome)
        Me.Controls.Add(Me.btNovoEvento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TV - TOTEM "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btNovoEvento As System.Windows.Forms.Button
    Friend WithEvents btCadastroNome As System.Windows.Forms.Button
    Friend WithEvents btCadastroSala As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
