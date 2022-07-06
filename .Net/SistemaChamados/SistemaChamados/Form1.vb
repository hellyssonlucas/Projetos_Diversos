Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class Form1

    Private Dados As New Controle

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dados.ExecuteQuery("SELECT * FROM ACESSO")
        'DataGridView1.DataSource = Dados.DBDT
    End Sub

    Sub LimpaCampos()

        cbTipoAtendimento.Text = ""
        tbNome.Text = ""
        OptionDesktop.Checked = False
        OptionNotebook.Checked = False
        tbCpf.Text = CStr("")
        CheckBoxRede.Checked = False
        CheckBoxEmail.Checked = False
        CheckBoxTodos.Checked = False
        CheckBoxAdm.Checked = False
        CheckBoxOutros.Checked = False
        tbOutros.Text = ""
        CheckBoxUAU.Checked = False
        CheckBoxDommus.Checked = False
        CheckBoxConstrutor.Checked = False

        CheckBoxRedeEspelho.Enabled = False
        CheckBoxRedeEspelho.Checked = False
        cbRedeEspelhoAD.Enabled = False
        cbRedeEspelhoAD.Text = CStr("")

        CheckBoxEmailDirec.Enabled = False
        CheckBoxEmailDirec.Checked = False
        tbEmailDirec.Enabled = False
        tbEmailDirec.Text = ""

        CheckBoxEspelhoUAU.Enabled = False
        CheckBoxEspelhoUAU.Checked = False
        tbEspelhoUAU.Enabled = False
        tbEspelhoUAU.Text = ""

        CheckBoxEspelhoDommus.Enabled = False
        CheckBoxEspelhoDommus.Checked = False
        tbEspelhoDommus.Enabled = False
        tbEspelhoDommus.Text = ""

        CheckBoxEspelhoConstrutor.Enabled = False
        CheckBoxEspelhoConstrutor.Checked = False
        tbEspelhoConstrutor.Enabled = False
        tbEspelhoConstrutor.Text = ""

        lbValidaCpf.Visible = False
        tbCpf.Visible = False
        lbCpf.Visible = False
        Panel1.Visible = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LimpaCampos()

        Panel1.Visible = False
        btEnviarAcesso.Enabled = False
        'lbSolicitante.Text = GetCurrent.Name
        lbSolicitante.Text = Environment.UserName

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTipoAtendimento.SelectedValueChanged

        If cbTipoAtendimento.Text = "ACESSOS" Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub CheckBoxRede_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRede.CheckedChanged
        If CheckBoxRede.Checked = False Then
            CheckBoxRedeEspelho.Enabled = False
            cbRedeEspelhoAD.Enabled = False
        Else
            CheckBoxRedeEspelho.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxRedeEspelho_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRedeEspelho.CheckedChanged
        If CheckBoxRedeEspelho.Checked = False Then
            cbRedeEspelhoAD.Text = ""
            cbRedeEspelhoAD.Enabled = False
        Else
            cbRedeEspelhoAD.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxEmail_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEmail.CheckedChanged
        If CheckBoxEmail.Checked = False Then
            CheckBoxEmailDirec.Enabled = False
            tbEmailDirec.Enabled = False
        Else
            CheckBoxEmailDirec.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxEmailDirec_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEmailDirec.CheckedChanged
        If CheckBoxEmailDirec.Checked = False Then
            tbEmailDirec.Text = ""
            tbEmailDirec.Enabled = False
        Else
            tbEmailDirec.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxUAU_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUAU.CheckedChanged
        If CheckBoxUAU.Checked = False Then
            CheckBoxEspelhoUAU.Enabled = False
            tbEspelhoUAU.Enabled = False
        Else
            CheckBoxEspelhoUAU.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxEspelhoUAU_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEspelhoUAU.CheckedChanged
        If CheckBoxEspelhoUAU.Checked = False Then
            tbEspelhoUAU.Text = ""
            tbEspelhoUAU.Enabled = False
        Else
            tbEspelhoUAU.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxDommus_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDommus.CheckedChanged
        If CheckBoxDommus.Checked = False Then
            CheckBoxEspelhoDommus.Enabled = False
            tbEspelhoDommus.Enabled = False
        Else
            CheckBoxEspelhoDommus.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxEspelhoDommus_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEspelhoDommus.CheckedChanged
        If CheckBoxEspelhoDommus.Checked = False Then
            tbEspelhoDommus.Text = ""
            tbEspelhoDommus.Enabled = False
        Else
            tbEspelhoDommus.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxConstrutor_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxConstrutor.CheckedChanged
        If CheckBoxConstrutor.Checked = False Then
            CheckBoxEspelhoConstrutor.Enabled = False
            tbEspelhoConstrutor.Enabled = False
        Else
            CheckBoxEspelhoConstrutor.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxEspelhoConstrutor_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEspelhoConstrutor.CheckedChanged
        If CheckBoxEspelhoConstrutor.Checked = False Then
            tbEspelhoConstrutor.Text = ""
            tbEspelhoConstrutor.Enabled = False
        Else
            tbEspelhoConstrutor.Enabled = True
        End If
    End Sub

    Private Sub OptionDesktop_CheckedChanged(sender As Object, e As EventArgs) Handles OptionDesktop.CheckedChanged
        If OptionDesktop.Checked = True Then
            tbCpf.Visible = False
            lbCpf.Visible = False
            lbValidaCpf.Visible = False
            tbCpf.Text = CStr("")
            'tbCpf.BackColor = &H80000004
        End If
    End Sub

    Private Sub OptionNotebook_CheckedChanged(sender As Object, e As EventArgs) Handles OptionNotebook.CheckedChanged
        Try
            If OptionNotebook.Checked = True Then
                tbCpf.Visible = True
                lbCpf.Visible = True
                lbValidaCpf.Visible = True
                'tbCpf.BackColor = &H80000005
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btEnviarAcesso_Click(sender As Object, e As EventArgs) Handles btEnviarAcesso.Click

        Try

            If tbNome.Text <> CStr("") Then
                Dados.AddParam("@TIPO_ATEND", cbTipoAtendimento.Text)
                'Dados.AddParam("@DATA_ATEND", Date)
                'Dados.AddParam("@HORA_ATEND", Time)
                Dados.AddParam("@SOLICITANTE", lbSolicitante.Text)
                Dados.AddParam("@NOME", tbNome.Text)
                Dados.AddParam("@CPF", tbCpf.Text)
                Dados.AddParam("@REDE", CheckBoxRede.CheckState)
                Dados.AddParam("@REDE_ESPELHO", cbRedeEspelhoAD.Text)
                Dados.AddParam("@EMAIL", CheckBoxEmail.CheckState)
                Dados.AddParam("@EMAIL_DIR", tbEmailDirec.Text)
                Dados.AddParam("@GTODOS", CheckBoxTodos.CheckState)
                Dados.AddParam("@GADMIN", CheckBoxAdm.CheckState)
                Dados.AddParam("@GOUTROS", tbOutros.Text)
                Dados.AddParam("@UAU", CheckBoxUAU.CheckState)
                Dados.AddParam("@ESP_UAU", tbEspelhoUAU.Text)
                Dados.AddParam("@DOMMUS", CheckBoxDommus.CheckState)
                Dados.AddParam("@ESP_DOMMUS", tbEspelhoDommus.Text)
                Dados.AddParam("CONSTRUTOR", CheckBoxConstrutor.CheckState)
                Dados.AddParam("@ESP_CONSTR", tbEspelhoConstrutor.Text)
                Dados.AddParam("@STATUS", "AGUARDANDO ATENDIMENTO")

                Dados.ExecuteQuery("INSERT INTO ACESSO ([TIPO_ATEND],[SOLICITANTE],[NOME],[CPF],[REDE],[REDE_ESPELHO],[EMAIL],[EMAIL_DIR],[GTODOS],[GADMIN],[GOUTROS],[UAU],[ESP_UAU],[DOMMUS],[ESP_DOMMUS],[CONSTRUTOR],[ESP_CONSTR],[STATUS]) VALUES ([@TIPO_ATEND],[@SOLICITANTE],[@NOME], [@CPF],[@REDE],[@REDE_ESPELHO],[@EMAIL],[@EMAIL_DIR],[@GTODOS],[@GADMIN],[@GOUTROS],[@UAU],[@ESP_UAU],[@DOMMUS],[@ESP_DOMMUS],[@CONSTRUTOR],[@ESP_CONSTR],[@STATUS])")
                MsgBox("Chamado aberto com sucesso!!!", vbInformation)
                LimpaCampos()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Close()

        'Else

        'btEnviarAcesso.Enabled = False
        'MsgBox("Você deve preencher os campos para Enviar", vbInformation)



    End Sub

    Private Sub tbNome_TextChanged(sender As Object, e As EventArgs) Handles tbNome.TextChanged
        If tbNome.TextLength > 0 Then btEnviarAcesso.Enabled = True Else btEnviarAcesso.Enabled = False
    End Sub

End Class
