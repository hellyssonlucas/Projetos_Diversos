Attribute VB_Name = "Módulo2"
'Option Explicit

Sub BuscarUsuarioAD()

'Dim StartTime, EndTime: StartTime = Now
'Dim objShell
'Set objShell = Wscript.CreateObject("WScript.Shell")
'Wscript.Echo "StartTime = " & StartTime

' ***************************************************************** '

Dim objRootDSE
Dim objDomain
Dim objContainer
Dim objOrganizationalUnit
Dim strExcelPath, objExcel, objSheet, Sheet, intRow

'Bind to the Excel object
Set objExcel = CreateObject("Excel.Application")

'Create a new workbook.
objExcel.Workbooks.Add

'Select the first sheet
Sheet = 1

'Bind to worksheet.
Set objSheet = objExcel.ActiveWorkbook.Worksheets(Sheet)

'Name the worksheet
objSheet.Name = "users"

'Set the save location
strExcelPath = "c:\temp\users.xlsx"

' Add header row.
objSheet.Cells(1, 1).Value = "Login"
objSheet.Cells(1, 2).Value = "Name"
objSheet.Cells(1, 3).Value = "Location"
objSheet.Cells(1, 4).Value = "Email"
objSheet.Cells(1, 5).Value = "CC"
objSheet.Cells(1, 6).Value = "Function"

Set objRootDSE = GetObject("LDAP://RootDSE")
Set objDomain = GetObject("LDAP://" & objRootDSE.Get("DefaultNamingContext"))

intRow = 2

' ALTERACOES =========================================================

Const ADS_SCOPE_SUBTREE = 2
' Get domain components
strDomain = objRootDSE.Get("DefaultNamingContext")
' Set ADO connection
Set objConnection = CreateObject("ADODB.Connection")
objConnection.Provider = "ADsDSOObject"
objConnection.Open "Active Directory Provider"
' Set ADO command
Set objCommand = CreateObject("ADODB.Command")
Set objCommand.ActiveConnection = objConnection
objCommand.Properties("Searchscope") = ADS_SCOPE_SUBTREE

strAtributos = "distinguishedName,samAccountName,DisplayName,physicalDeliveryOfficeName,mail,Department,Description"
objCommand.CommandText = "SELECT " & strAtributos & _
        " FROM 'LDAP://" & strDomain & _
        "' WHERE objectCategory='person' AND objectClass='user'"
        
' Set recordset to hold the query result
Set objRecordSet = objCommand.Execute

Do Until objRecordSet.EOF

Dim nome As String
nome = objRecordSet.Fields("sAMAccountName").Value

    'Wscript.Echo objRecordSet.Fields("samAccountName").Value
    'objSheet.Cells(intRow, 1).Value = objRecordSet.Fields("sAMAccountName").Value
    'objSheet.Cells(intRow, 2).Value = objRecordSet.Fields("DisplayName").Value
    'objSheet.Cells(intRow, 3).Value = objRecordSet.Fields("physicalDeliveryOfficeName").Value
    'objSheet.Cells(intRow, 4).Value = objRecordSet.Fields("mail").Value
    'objSheet.Cells(intRow, 5).Value = objRecordSet.Fields("Department").Value
    'objSheet.Cells(intRow, 6).Value = objRecordSet.Fields("Description").Value
    'intRow = intRow + 1
    
    
    UserForm1.cbAdUsers.AddItem nome
    'UserForm1.cbAdUsers.AddItem objRecordSet.Fields("DisplayName").Value
        
    'Move para o próximo registro
    objRecordSet.MoveNext

Loop

' FIM ALTERACOES ==========================================================

objExcel.ActiveWorkbook.SaveAs strExcelPath
objExcel.ActiveWorkbook.Close

objExcel.Application.Quit

Set objSheet = Nothing
Set objExcel = Nothing


End Sub
' ***************************************************************** '
'EndTime = Now
'Wscript.Echo vbCrLf & "EndTime = " & EndTime
'Wscript.Echo "Seconds Elapsed: " & DateDiff("s", StartTime, EndTime)
'Wscript.Echo "Script Complete"
'Wscript.Quit (0)
' ***************************************************************** '

