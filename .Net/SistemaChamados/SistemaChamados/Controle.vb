Imports System.Data.OleDb

Public Class Controle

    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SistemaChamados\Chamados_cea.accdb")
    Private DBCmd As OleDbCommand
    Private DBDA As OleDbDataAdapter
    Public DBDT As DataTable
    Public Params As New List(Of OleDbParameter)

    Public Sub ExecuteQuery(ByVal Query As String)
        Try

            DBCon.Open() 'abre conexao
            DBCmd = New OleDbCommand(Query, DBCon) 'cria o comando
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
            Params.Clear()
            DBDT = New DataTable ' Cria tabela
            DBDA = New OleDbDataAdapter(DBCmd) 'Executa
            DBDA.Fill(DBDT) ' Preenche DataTable

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        End Try



    End Sub
    Public Sub AddParam(ByVal Nome As String, ByVal Valor As Object)
        Dim Novo As New OleDbParameter(Nome, Valor)
        Params.Add(Novo)
    End Sub



End Class
