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
'caixa de criação de usuário de rede

Private Sub CheckBoxRede_Click()

If CheckBoxRede.Value = False Then
CheckBoxRedeEspelho.Enabled = False
tbRedeEspelho.Enabled = False
tbRedeEspelho.BackColor = &H80000004
Else
CheckBoxRedeEspelho.Enabled = True
End If

End Sub

'caixa de usuario espelho

Private Sub CheckBoxRedeEspelho_Click()

If CheckBoxRedeEspelho.Value = False Then
tbRedeEspelho.Enabled = False
tbRedeEspelho.BackColor = &H80000004
Else
tbRedeEspelho.Enabled = True
tbRedeEspelho.BackColor = &H80000005
End If

End Sub

'caixa criação de email

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
tbEspelhoConstrutor.Enabled = False
tbEspelhoConstrutor.BackColor = &H80000004
Else
tbEspelhoConstrutor.Enabled = True
tbEspelhoConstrutor.BackColor = &H80000005
End If

End Sub

'Opção de seleção Desktop
Private Sub OptionDesktop_Click()

If OptionDesktop = True Then
tbCpf.Visible = False
lbCpf.Visible = False
lbValidaCpf.Visible = False
tbCpf = ""
tbCpf.BackColor = &H80000004
End If

End Sub

'Opção de seleção Notebook
Private Sub OptionNotebook_Click()

If OptionNotebook = True Then
tbCpf.Visible = True
lbCpf.Visible = True
lbValidaCpf.Visible = True
tbCpf.BackColor = &H80000005
End If

End Sub

'Incialização do form

Private Sub UserForm_Initialize()

InitMaxMin Me.Caption
Frame1.Visible = False

'Dim arquivoBuscado As String

'arquivoBuscado = "Chamados_cea"

'Workbooks.Open ("C:\chamados\" & arquivoBuscado & ".xlsx")
ActiveWorkbook.Windows.Application.Visible = False

PreencherTipoAtendimento
Mostra

CheckBoxRedeEspelho.Enabled = False
tbRedeEspelho.BackColor = &H80000004
tbRedeEspelho.Enabled = False

CheckBoxEmailDirec.Enabled = False
tbEmailDirec.Enabled = False
tbEmailDirec.BackColor = &H80000004

CheckBoxEspelhoUAU.Enabled = False
tbEspelhoUAU.BackColor = &H80000004
tbEspelhoUAU.Enabled = False

CheckBoxEspelhoDommus.Enabled = False
tbEspelhoDommus.BackColor = &H80000004
tbEspelhoDommus.Enabled = False

CheckBoxEspelhoConstrutor.Enabled = False
tbEspelhoConstrutor.BackColor = &H80000004
tbEspelhoConstrutor.Enabled = False

tbCpf.BackColor = &H80000004
tbCpf.Visible = False
lbCpf.Visible = False


End Sub

'Selecionar atendimento

Sub PreencherTipoAtendimento()

cbTipoAtendimento.Clear

Dim Lin, Item, Itens As Long
Lin = 2

Do Until Sheets("Filtros").Range("A" & Lin) = Empty

    Itens = cbTipoAtendimento.ListCount
    For Item = 0 To Itens - 1
        If cbTipoAtendimento.List(Item, 0) = Sheets("Filtros").Range("A" & Lin) Then
            GoTo Continuar
        End If
    Next

    cbTipoAtendimento.AddItem Sheets("Filtros").Range("A" & Lin)
    
Continuar:
    Lin = Lin + 1
Loop
     
Call OrdenarComboBox(cbTipoAtendimento)

End Sub

Private Sub cbTipoAtendimento_Change()

    If cbTipoAtendimento.Text = "ACESSOS" Then
        Frame1.Visible = True
                   
    End If
    If cbTipoAtendimento.Text = "SUPORTE GERAL" Then
        Frame1.Visible = False
    End If

End Sub

'Abrindo o chamado
Private Sub btEnviarAcesso_Click()

SalvarAcesso

End Sub

'Inserindo os dados na planilha

Sub SalvaDadosAcessoNaPlanilha()

Dim ProxRegistro As Long
Dim linha, codigo As Integer
Dim conteudoLinha As String

If tbNome.Text = "" Then
MsgBox ("Você precisa preencher um nome para continuar")
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
Sheets("Acesso").Range("A1").Cells(linha, 9).Value = tbRedeEspelho.Text 'REDE_ESPELHO
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

MsgBox (" Chamado nº  " & ProxRegistro & " aberto com sucesso")

LimpaCampos
End If

End Sub

Sub LimpaCampos()

cbTipoAtendimento.Text = ""
Frame1.Visible = False

End Sub

'Function que retorna o nome do usuário de rede logado
 
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

Private Sub CommandButton3_Click() ' *************************BOTÃO SAIR********************************************

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
MsgBox "Use o Botão Sair Abaixo!"
Cancel = True
End If
End Sub


'''validaçoes do CPF """

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
      lbValidaCpf = "CPF Válido!"
   End If
   
   
End Sub

Private Sub tbCpf_Exit(ByVal Cancel As MSForms.ReturnBoolean)

    If OptionDesktop = True Then
        lbValidaCpf.Enabled = False
    End If

End Sub

