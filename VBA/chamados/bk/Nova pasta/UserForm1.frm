VERSION 5.00
Begin {C62A69F0-16DC-11CE-9E98-00AA00574A4F} UserForm1 
   Caption         =   "Sistema de Chamados TI - CEA Construtora"
   ClientHeight    =   6495
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   8655.001
   OleObjectBlob   =   "UserForm1.frx":0000
   ShowModal       =   0   'False
   StartUpPosition =   1  'CenterOwner
End
Attribute VB_Name = "UserForm1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'caixa de cria��o de usu�rio de rede

Private Sub CheckBoxRede_Click()

If CheckBoxRede.Value = False Then
CheckBoxRedeEspelho.Enabled = False
cbRedeEspelhoAD.Enabled = False
cbRedeEspelhoAD.BackColor = &H80000004
Else
CheckBoxRedeEspelho.Enabled = True
End If

End Sub

'caixa de usuario espelho

Private Sub CheckBoxRedeEspelho_Click()

If CheckBoxRedeEspelho.Value = False Then
cbRedeEspelhoAD.Text = ""
cbRedeEspelhoAD.Enabled = False
cbRedeEspelhoAD.BackColor = &H80000004
Else
cbRedeEspelhoAD.Enabled = True
cbRedeEspelhoAD.BackColor = &H80000005
End If

End Sub

'caixa cria��o de email

Private Sub CheckBoxEmail_Click()

If CheckBoxEmail.Value = False Then
CheckBoxEmailDirec.Enabled = False
tbEmailDirec.Enabled = False
tbEmailDirec.BackColor = &H80000004
Else
CheckBoxEmailDirec.Enabled = True
End If

End Sub

'caixa de direcionamento do email

Private Sub CheckBoxEmailDirec_Click()

If CheckBoxEmailDirec.Value = False Then
tbEmailDirec.Text = ""
tbEmailDirec.Enabled = False
tbEmailDirec.BackColor = &H80000004
Else
tbEmailDirec.Enabled = True
tbEmailDirec.BackColor = &H80000005
End If

End Sub

Private Sub CheckBoxUAU_Click()

If CheckBoxUAU.Value = False Then
CheckBoxEspelhoUAU.Enabled = False
tbEspelhoUAU.Enabled = False
tbEspelhoUAU.BackColor = &H80000004
Else
CheckBoxEspelhoUAU.Enabled = True
End If

End Sub

Private Sub CheckBoxEspelhoUAU_Click()

If CheckBoxEspelhoUAU.Value = False Then
tbEspelhoUAU.Text = ""
tbEspelhoUAU.Enabled = False
tbEspelhoUAU.BackColor = &H80000004
Else
tbEspelhoUAU.Enabled = True
tbEspelhoUAU.BackColor = &H80000005
End If

End Sub

Private Sub CheckBoxDommus_Click()

If CheckBoxDommus.Value = False Then
CheckBoxEspelhoDommus.Enabled = False
tbEspelhoDommus.Enabled = False
tbEspelhoDommus.BackColor = &H80000004
Else
CheckBoxEspelhoDommus.Enabled = True
End If

End Sub

Private Sub CheckBoxEspelhoDommus_Click()

If CheckBoxEspelhoDommus.Value = False Then
tbEspelhoDommus.Text = ""
tbEspelhoDommus.Enabled = False
tbEspelhoDommus.BackColor = &H80000004
Else
tbEspelhoDommus.Enabled = True
tbEspelhoDommus.BackColor = &H80000005
End If

End Sub

Private Sub CheckBoxConstrutor_Click()

If CheckBoxConstrutor.Value = False Then
CheckBoxEspelhoConstrutor.Enabled = False
tbEspelhoConstrutor.Enabled = False
tbEspelhoConstrutor.BackColor = &H80000004
Else
CheckBoxEspelhoConstrutor.Enabled = True
End If

End Sub

Private Sub CheckBoxEspelhoConstrutor_Click()

If CheckBoxEspelhoConstrutor.Value = False Then
tbEspelhoConstrutor.Text = ""
tbEspelhoConstrutor.Enabled = False
tbEspelhoConstrutor.BackColor = &H80000004
Else
tbEspelhoConstrutor.Enabled = True
tbEspelhoConstrutor.BackColor = &H80000005
End If

End Sub

'Op��o de sele��o Desktop
Private Sub OptionDesktop_Click()

If OptionDesktop = True Then
tbCpf.Visible = False
lbCpf.Visible = False
lbValidaCpf.Visible = False
tbCpf = ""
tbCpf.BackColor = &H80000004
End If

End Sub

'Op��o de sele��o Notebook
Private Sub OptionNotebook_Click()

If OptionNotebook = True Then
tbCpf.Visible = True
lbCpf.Visible = True
lbValidaCpf.Visible = True
tbCpf.BackColor = &H80000005
End If

End Sub

'Incializa��o do form

Private Sub UserForm_Initialize()

'carrega os usuarios do AD no Combobox
M�dulo2.BuscarUsuarioAD

InitMaxMin Me.Caption
Frame1.Visible = False

'Dim arquivoBuscado As String
'arquivoBuscado = "Chamados_cea"
'Workbooks.Open ("C:\chamados\" & arquivoBuscado & ".xlsx")

ActiveWorkbook.Windows.Application.Visible = False

PreencherTipoAtendimento
Mostra

LimpaCampos

End Sub

'Selecionar atendimento

Sub PreencherTipoAtendimento()

On Error GoTo Erro

Set rs = New ADODB.Recordset

ConexaoBanco.ConectarBD

rs.Open "SELECT DISTINCT T_ATEND FROM TIPO_ATEND ORDER BY T_ATEND ASC", Conexao, adOpenKeyset, adLockReadOnly

Do Until rs.EOF

    cbTipoAtendimento.AddItem rs!T_ATEND
    rs.MoveNext

Loop

If Not rs Is Nothing Then
    rs.Close
    Set rs = Nothing
End If

ConexaoBanco.DesconectarBD

Exit Sub
Erro:
MsgBox "Erro!", vbCritical, "ERRO"


End Sub

Private Sub cbTipoAtendimento_Change()

    If cbTipoAtendimento.Value = "ACESSOS" Then
        Frame1.Visible = True
                   
    End If
    If cbTipoAtendimento.Value = "SUPORTE GERAL" Then
        Frame1.Visible = False
    End If

End Sub

Sub emailSimples()

    'Utilizando Late Binding
    Dim OutApp As Object
    Dim OutMail As Object

    Set OutApp = CreateObject("Outlook.Application") 'Objeto para Outlook
    Set OutMail = OutApp.CreateItem(0) 'Objeto para email dentro do Outlook

    With OutMail
        .To = "ti@construtoracea.com.br" 'Substitua o email desta linha
        .Subject = "Sistema de Help-Desk CEA - Chamado para " & cbTipoAtendimento.Text
        .Body = "Data: " & Date & " Hora: " & Time & vbNewLine & _
                "Usuario Solicitante: " & lbSolicitante & vbNewLine & _
                "Nome do contratado(a): " & tbNome.Text & vbNewLine & _
                "Equipamento ser� notebook?" & OptionNotebook & vbNewLine & _
                "CPF: " & tbCpf & vbNewLine & _
                "Acesso � rede: " & CheckBoxRede.Value & vbNewLine & _
                "Usu�rio Espelho: " & cbRedeEspelhoAD.Value & vbNewLine & _
                "Criar email: " & CheckBoxEmail.Value & vbNewLine & _
                "Direcionar e-mail para o atual: " & tbEmailDirec.Text & vbNewLine & _
                "Grupos de Emails:" & vbNewLine & _
                "Todos : " & CheckBoxTodos.Value & vbNewLine & _
                "Administrativo: " & CheckBoxAdm.Value & vbNewLine & _
                "OUTROS: " & tbOutros.Text & vbNewLine & _
                "Acesso UAU: " & CheckBoxUAU.Value & vbNewLine & _
                "Usu�rio Espelho: " & tbEspelhoUAU.Text & vbNewLine & _
                "Acesso Dommus: " & CheckBoxDommus.Value & vbNewLine & _
                "Usu�rio Espelho: " & tbEspelhoDommus.Text & vbNewLine & _
                "Acesso Construtor Vendas: " & CheckBoxConstrutor.Value & vbNewLine & _
                "Usu�rio Espelho: " & tbEspelhoConstrutor.Text & vbNewLine
         .Display 'M�todo para mostrar o conte�do
    End With

    OutMail.Send 'Enviar email

    Set OutMail = Nothing
    Set OutApp = Nothing

End Sub

'Abrindo o chamado
Private Sub btEnviarAcesso_Click()

ConexaoBanco.SalvarAcesso
'emailSimples
LimpaCampos

End Sub

'Inserindo os dados na planilha

Sub SalvaDadosAcessoNaPlanilha()

Dim ProxRegistro As Long
Dim linha, codigo As Integer
Dim conteudoLinha As String

If tbNome.Text = "" Then
MsgBox ("Voc� precisa preencher um nome para continuar")
Else

linha = Range("A1").End(xlDown).Row ' mostra o numero da ultima linha
'conteudoLinha = Worksheets("Acesso").Range("A1").Cells(linha, 1).Value
ProxRegistro = Sheets("Acesso").Range("A1").Cells(linha, 1).Value + 1
linha = linha + 1
Sheets("Acesso").Range("A1").Cells(linha, 1).Value = ProxRegistro 'COD
Sheets("Acesso").Range("A1").Cells(linha, 2).Value = cbTipoAtendimento.Text 'TIPO_ATEND
Sheets("Acesso").Range("A1").Cells(linha, 3).Value = Date 'DATA_ATEND
Sheets("Acesso").Range("A1").Cells(linha, 4).Value = Time 'HORA_ATEND
Sheets("Acesso").Range("A1").Cells(linha, 5).Value = lbSolicitante 'SOLICITANTE
Sheets("Acesso").Range("A1").Cells(linha, 6).Value = tbNome.Text 'NOME
Sheets("Acesso").Range("A1").Cells(linha, 7).Value = tbCpf.Text 'CPF
Sheets("Acesso").Range("A1").Cells(linha, 8).Value = CheckBoxRede.Value 'REDE
Sheets("Acesso").Range("A1").Cells(linha, 9).Value = cbRedeEspelhoAD.Text 'REDE_ESPELHO
Sheets("Acesso").Range("A1").Cells(linha, 10).Value = CheckBoxEmail.Value 'EMAIL
Sheets("Acesso").Range("A1").Cells(linha, 11).Value = tbEmailDirec.Text 'EMAIL_DIR
Sheets("Acesso").Range("A1").Cells(linha, 12).Value = CheckBoxTodos.Value 'GTODOS
Sheets("Acesso").Range("A1").Cells(linha, 13).Value = CheckBoxAdm.Value 'GADMIN
Sheets("Acesso").Range("A1").Cells(linha, 14).Value = tbOutros.Text 'GOUTROS
Sheets("Acesso").Range("A1").Cells(linha, 15).Value = CheckBoxUAU.Value 'UAU
Sheets("Acesso").Range("A1").Cells(linha, 16).Value = tbEspelhoUAU.Text 'ESP_UAU
Sheets("Acesso").Range("A1").Cells(linha, 17).Value = CheckBoxDommus.Value 'DOMMUS
Sheets("Acesso").Range("A1").Cells(linha, 18).Value = tbEspelhoDommus.Text 'ESP_DOMMUS
Sheets("Acesso").Range("A1").Cells(linha, 19).Value = CheckBoxConstrutor.Value 'CONSTRUTOR
Sheets("Acesso").Range("A1").Cells(linha, 20).Value = tbEspelhoConstrutor.Text 'ESP_CONSTR

lbRegistro = ProxRegistro
ActiveWorkbook.Save

MsgBox (" Chamado n�  " & ProxRegistro & " aberto com sucesso")

LimpaCampos
End If

End Sub

Sub LimpaCampos()

cbTipoAtendimento.Text = ""
tbNome.Text = ""
OptionDesktop.Value = False
OptionNotebook.Value = False
tbCpf.Value = ""
CheckBoxRede.Value = False
CheckBoxEmail.Value = False
CheckBoxTodos.Value = False
CheckBoxAdm.Value = False
CheckBoxOutros.Value = False
tbOutros.Text = ""
CheckBoxUAU.Value = False
CheckBoxDommus.Value = False
CheckBoxConstrutor.Value = False

CheckBoxRedeEspelho.Enabled = False
CheckBoxRedeEspelho.Value = False
cbRedeEspelhoAD.BackColor = &H80000004
cbRedeEspelhoAD.Enabled = False
cbRedeEspelhoAD.Value = ""

CheckBoxEmailDirec.Enabled = False
CheckBoxEmailDirec.Value = False
tbEmailDirec.Enabled = False
tbEmailDirec.BackColor = &H80000004
tbEmailDirec.Text = ""

CheckBoxEspelhoUAU.Enabled = False
CheckBoxEspelhoUAU.Value = False
tbEspelhoUAU.BackColor = &H80000004
tbEspelhoUAU.Enabled = False
tbEspelhoUAU.Text = ""

CheckBoxEspelhoDommus.Enabled = False
CheckBoxEspelhoDommus.Value = False
tbEspelhoDommus.BackColor = &H80000004
tbEspelhoDommus.Enabled = False
tbEspelhoDommus.Text = ""

CheckBoxEspelhoConstrutor.Enabled = False
CheckBoxEspelhoConstrutor.Value = False
tbEspelhoConstrutor.BackColor = &H80000004
tbEspelhoConstrutor.Enabled = False
tbEspelhoConstrutor.Text = ""

lbValidaCpf.Visible = False
tbCpf.BackColor = &H80000004
tbCpf.Visible = False
lbCpf.Visible = False



Frame1.Visible = False

End Sub

'Function que retorna o nome do usu�rio de rede logado
 
Function UsuarioRede() As String
    Dim GetUserN
    Dim ObjNetwork
    Set ObjNetwork = CreateObject("WScript.Network")
    GetUserN = ObjNetwork.UserName
    UsuarioRede = GetUserN
End Function

Sub Mostra()

lbSolicitante = UsuarioRede
    'MsgBox UsuarioRede
    
End Sub


Private Sub CommandButton2_Click()

UserForm2.Show

End Sub

Private Sub CommandButton3_Click() ' *************************BOT�O SAIR********************************************

On Error Resume Next
Unload Me

Dim nomePlan2, nomePlan3 As String

Dim qtde As Integer
qtde = Workbooks.Count

If qtde > 2 Then

nomePlan2 = ActiveWorkbook.Name
ActiveWorkbook.Close
Windows("chamados.xlsm").Activate
nomePlan3 = ActiveWorkbook.Name
ActiveWorkbook.Close
Application.Workbook("chamados.xlsm").Close (0)
Application.ThisWorkbook.Close (0)

Else
Application.Quit
End If

planilha.Close

End Sub

Private Sub UserForm_QueryClose(Cancel As Integer, CloseMode As Integer)
If CloseMode = vbFormControlMenu Then
MsgBox "Use o Bot�o Sair Abaixo!"
Cancel = True
End If
End Sub


'''valida�oes do CPF """

Function validaCPF(numCPF)
   If Len(numCPF) < 11 Then numCPF = String(11 - Len(numCPF), "0") & numCPF
   For caracter = 1 To 9
        DV1 = Val(Mid(numCPF, caracter, 1)) * caracter + DV1
        If caracter > 1 Then DV2 = Val(Mid(numCPF, caracter, 1)) * (caracter - 1) + DV2
   Next
   DV1 = Right(DV1 Mod 11, 1)
   DV2 = Right((DV2 + (DV1 * 9)) Mod 11, 1)
   If Mid(numCPF, 10, 1) = DV1 And Mid(numCPF, 11, 1) = DV2 Then validaCPF = "OK"
End Function

Private Sub tbCPF_KeyPress(ByVal KeyAscii As MSForms.ReturnInteger)

If Not IsNumeric(Chr(KeyAscii.Value)) Or Len(tbCpf.Text) >= 14 Then
        KeyAscii.Value = 0
    Else
        If Len(tbCpf.Text) = 3 Or Len(tbCpf.Text) = 7 Then
            tbCpf.Text = tbCpf.Text & "."
        End If
        If Len(tbCpf.Text) = 11 Then
            tbCpf.Text = tbCpf.Text & "-"
        End If
    End If

End Sub

Private Sub tbCpf_Change()

   numCPF = tbCpf.Value
   numCPF = Replace(numCPF, ".", "")
   numCPF = Replace(numCPF, "-", "")

   If Val(numCPF) = 0 Or validaCPF(numCPF) <> "OK" Then
        lbValidaCpf.ForeColor = &HFF&
        lbValidaCpf = "CPF invalido!"
     
      Exit Sub
   Else
      'TextBox1.Value = Left(numCPF, 3) & "." & Mid(numCPF, 4, 3) & "." & Mid(numCPF, 7, 3) & "-" & Right(numCPF, 2)
      lbValidaCpf.ForeColor = &H8000&
      lbValidaCpf = "CPF V�lido!"
   End If
   
   
End Sub

Private Sub tbCpf_Exit(ByVal Cancel As MSForms.ReturnBoolean)

    If OptionDesktop = True Then
        lbValidaCpf.Enabled = False
    End If

End Sub



