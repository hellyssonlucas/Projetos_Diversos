Attribute VB_Name = "Conectar"
Option Explicit

'Function ConectarBanco()
Sub ConectarBanco()

Dim conexao As ADODB.Connection

Dim Provider As String
Dim dataSource As String
Dim connectionString As String
Dim caminho As String

Set conexao = CreateObject("ADODB.Connection")

'With conexao
'.connectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};dqb=C:\chamados\Chamados_cea.accdb"
'.Open


'End With


caminho = ThisWorkbook.Path & "\Chamados_cea.accdb;"

Provider = "Microsoft.ACE.OLEDB.12.0;"
dataSource = "Data Source=" & caminho

connectionString = Provider & dataSource

conexao.Open connectionString

End Sub
