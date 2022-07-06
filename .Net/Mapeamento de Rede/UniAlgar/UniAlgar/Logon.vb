Public Class Logon

    Private Sub Logon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function validaCampos() As Boolean

        If txtUsuario.Text = "" Then
            MsgBox("Preencha o campo Usuário", MsgBoxStyle.Information)
            txtUsuario.Focus()
            Return False
        End If
        If txtSenha.Text = "" Then
            MsgBox("Preencha o campo Senha", MsgBoxStyle.Information)
            txtSenha.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub btnConfirma_Click(sender As Object, e As EventArgs) Handles btnConfirma.Click
        Dim usuarioConectado As String

        If validaCampos() = False Then
            Exit Sub
        Else
            Acesso.MapNetworkDrive("\\srv01\Historico$", "H"c, True)
            Acesso.MapNetworkDrive("\\srv01\Compartimento_para_Fotos$", "S"c, True)
            Acesso.MapNetworkDrive("\\srv01\Unialgar$", "T"c, True)
            usuarioConectado = txtUsuario.Text
            Acesso.LabelUsuarioConectado.Visible = True
            Acesso.LabelUsuarioConectado.Text = usuarioConectado.ToString
            txtUsuario.Clear()
            txtSenha.Clear()
            Me.Close()
            'Process.Start("Explorer.exe")
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    
End Class