VERSION 5.00
Begin {C62A69F0-16DC-11CE-9E98-00AA00574A4F} UserForm2 
   ClientHeight    =   1125
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   1800
   OleObjectBlob   =   "UserForm2.frx":0000
   StartUpPosition =   1  'CenterOwner
End
Attribute VB_Name = "UserForm2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CommandButton1_Click()

Senha = "191920"
If TextBox1.Value <> Senha Then
MsgBox (" A senha esta incorreta ")
ActiveWindow.Close
Exit Sub
ElseIf TextBox1.Value = Senha Then
Application.Visible = True
End If

TextBox1.Value = ""
Windows("Chamados_cea.xlsx").Activate
ActiveWindow.Close
Windows("chamados.xlsm").Activate
Unload Me
Unload UserForm1

End Sub

