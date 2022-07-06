Attribute VB_Name = "Módulo2"
Sub BuscarUsuarioAD()

Dim objRootDSE
Dim objDomain
Dim objContainer
Dim objOrganizationalUnit
Dim strExcelPath, objExcel, objSheet, Sheet, intRow

Set objRootDSE = GetObject("LDAP://RootDSE")
Set objDomain = GetObject("LDAP://" & objRootDSE.Get("DefaultNamingContext"))

intRow = 2

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

    UserForm1.cbRedeEspelhoAD.AddItem nome
    
    'Move para o próximo registro
    objRecordSet.MoveNext
Loop
End Sub


