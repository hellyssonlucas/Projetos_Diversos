Attribute VB_Name = "SQL"
Sub ExportDataToAccess()

    Dim Conexao As Object
    Dim strQuery As String
    Dim myDB As String
    Dim tipoAtendimento As String
    Dim dataAtendimento As Date
       
    tipoAtendimento
    dataAtendimento = Date
    
    myDB = "C:\chamados\Chamados_cea.accdb"

    Set Conexao = CreateObject("ADODB.Connection")

    With Conexao
        .Provider = "Microsoft.ACE.OLEDB.12.0"    'For *.ACCDB Databases
        .connectionString = myDB
        .Open
    End With

    strQuery = "INSERT INTO ACESSO ([TIPO_ATEND], [DATA_ATEND]) " & "VALUES (""" & tipoAtendimento & """, " & dataAtendimento & ");"

    cn.Execute strQuery
    Conexao.Close
    Set Conexao = Nothing

End Sub
