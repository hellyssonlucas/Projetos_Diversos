Attribute VB_Name = "SQL"
Sub ExportDataToAccess()

    Dim cn As Object
    Dim strQuery As String
    Dim myDB As String
    Dim creditDate As Date
    Dim regionalTeam As String


    'Initialize Variables
    'creditDate = Worksheets("Treasury").Range("E20").Value
    'regionalTeam = Worksheets("Treasury").Range("e21").Value

    myDB = "C:\chamados\Chamados_cea.accdb"

    Set cn = CreateObject("ADODB.Connection")

    With cn
        .Provider = "Microsoft.ACE.OLEDB.12.0"    'For *.ACCDB Databases
        .connectionString = myDB
        .Open
    End With

    'strQuery = "INSERT INTO Credit ([creditDate], [regionalTeam]) " & "VALUES (""" & creditDate & """, " & regionalTeam & ");"

    'cn.Execute strQuery
    cn.Close
    Set cn = Nothing

End Sub
