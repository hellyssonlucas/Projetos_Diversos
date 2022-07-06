<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acesso
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
        Me.btnProxyEnable = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.LabelUsuarioConectado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnDesconectar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMapear = New System.Windows.Forms.Button()
        Me.btnProxyDisable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProxyEnable
        '
        Me.btnProxyEnable.Location = New System.Drawing.Point(25, 39)
        Me.btnProxyEnable.Name = "btnProxyEnable"
        Me.btnProxyEnable.Size = New System.Drawing.Size(84, 45)
        Me.btnProxyEnable.TabIndex = 29
        Me.btnProxyEnable.Text = "Ativar Proxy"
        Me.btnProxyEnable.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(165, 143)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(68, 35)
        Me.btnSair.TabIndex = 28
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'LabelUsuarioConectado
        '
        Me.LabelUsuarioConectado.AutoSize = True
        Me.LabelUsuarioConectado.Location = New System.Drawing.Point(155, 197)
        Me.LabelUsuarioConectado.Name = "LabelUsuarioConectado"
        Me.LabelUsuarioConectado.Size = New System.Drawing.Size(39, 13)
        Me.LabelUsuarioConectado.TabIndex = 27
        Me.LabelUsuarioConectado.Text = "Label4"
        Me.LabelUsuarioConectado.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Usuario Conectado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Developed by Hellysson Lucas                         v1.0"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 240)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "Developed by Hellysson Lucas"
        '
        'btnDesconectar
        '
        Me.btnDesconectar.Location = New System.Drawing.Point(25, 143)
        Me.btnDesconectar.Name = "btnDesconectar"
        Me.btnDesconectar.Size = New System.Drawing.Size(108, 35)
        Me.btnDesconectar.TabIndex = 23
        Me.btnDesconectar.Text = "Desconectar "
        Me.btnDesconectar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 24)
        Me.Label3.TabIndex = 22
        '
        'btnMapear
        '
        Me.btnMapear.Location = New System.Drawing.Point(25, 90)
        Me.btnMapear.Name = "btnMapear"
        Me.btnMapear.Size = New System.Drawing.Size(208, 47)
        Me.btnMapear.TabIndex = 21
        Me.btnMapear.Text = "Mapear Unidades T  S  H"
        Me.btnMapear.UseVisualStyleBackColor = True
        '
        'btnProxyDisable
        '
        Me.btnProxyDisable.Location = New System.Drawing.Point(149, 39)
        Me.btnProxyDisable.Name = "btnProxyDisable"
        Me.btnProxyDisable.Size = New System.Drawing.Size(84, 45)
        Me.btnProxyDisable.TabIndex = 30
        Me.btnProxyDisable.Text = "Desativar Proxy"
        Me.btnProxyDisable.UseVisualStyleBackColor = True
        '
        'Acesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnProxyDisable)
        Me.Controls.Add(Me.btnProxyEnable)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.LabelUsuarioConectado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnDesconectar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMapear)
        Me.Name = "Acesso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UniAlgar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProxyEnable As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents LabelUsuarioConectado As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnDesconectar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMapear As System.Windows.Forms.Button
    Friend WithEvents btnProxyDisable As System.Windows.Forms.Button
End Class
