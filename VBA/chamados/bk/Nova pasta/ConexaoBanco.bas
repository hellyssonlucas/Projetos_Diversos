Attribute VB_Name = "ConexaoBanco"
Public Conexao As ADODB.Connection
Public rs As ADODB.Recordset

Sub ConectarBD()

On Error GoTo Erro
Dim strConexao As String

Set Conexao = New ADODB.Connection

strConexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\chamados\Chamados_cea.accdb;Persist Security Info=false"
Conexao.Open strConexao

Exit Sub
Erro:
MsgBox "Erro!", vbCritical, "ERRO"

End Sub

Sub DesconectarBD()

    If Not Conexao Is Nothing Then
    
        Conexao.Close
        Set Conexao = Nothing
        
     End If
     
End Sub

Sub SalvarAcesso()

On Error GoTo Erro

If UserForm1.tbNome.Text = "" Then
MsgBox ("Você precisa preencher um nome para continuar")

Else

Set rs = New ADODB.Recordset

ConectarBD

rs.Open "SELECT * FROM ACESSO", Conexao, adOpenKeyset, adLockPessimistic
rs.AddNew
rs!TIPO_ATEND = UserForm1.cbTipoAtendimento.Text
rs!DATA_ATEND = Date
rs!HORA_ATEND = Time
rs!SOLICITANTE = UserForm1.lbSolicitante
rs!nome = UserForm1.tbNome.Text
rs!CPF = UserForm1.tbCpf
rs!REDE = UserForm1.CheckBoxRede.Value
rs!REDE_ESPELHO = UserForm1.cbRedeEspelhoAD.Value
rs!Email = UserForm1.CheckBoxEmail.Value
rs!EMAIL_DIR = UserForm1.tbEmailDirec.Text
rs!GTODOS = UserForm1.CheckBoxTodos.Value
rs!GADMIN = UserForm1.CheckBoxAdm.Value
rs!GOUTROS = UserForm1.tbOutros.Text
rs!UAU = UserForm1.CheckBoxUAU.Value
rs!ESP_UAU = UserForm1.tbEspelhoUAU.Text
rs!DOMMUS = UserForm1.CheckBoxDommus.Value
rs!ESP_DOMMUS = UserForm1.tbEspelhoDommus.Text
rs!CONSTRUTOR = UserForm1.CheckBoxConstrutor.Value
rs!ESP_CONSTR = UserForm1.tbEspelhoConstrutor.Text

rs.Update

MsgBox "Chamado aberto com sucesso", vbInformation, "SALVAR"

If Not rs Is Nothing Then
    rs.Close
    Set rs = Nothing
End If

DesconectarBD

End If
Exit Sub
Erro:
MsgBox "Erro!", vbCritical, "ERRO"

End Sub
