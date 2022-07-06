Imports System.Runtime.InteropServices
Imports UniAlgar.Proxy

Public Class Acesso

    Private Sub Acesso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Const NO_ERROR As UInteger = 0
        Public Const RESOURCETYPE_DISK As UInteger = 1
        Public Const CONNECT_UPDATE_PROFILE As UInteger = 1

        <StructLayoutAttribute(LayoutKind.Sequential)> _
        Public Structure NETRESOURCE
            Public dwScope As UInteger
            Public dwType As UInteger
            Public dwDisplayType As UInteger
            Public dwUsage As UInteger
            <MarshalAsAttribute(UnmanagedType.LPWStr)> _
            Public lpLocalName As String
            <MarshalAsAttribute(UnmanagedType.LPWStr)> _
            Public lpRemoteName As String
            <MarshalAsAttribute(UnmanagedType.LPWStr)> _
            Public lpComment As String
            <MarshalAsAttribute(UnmanagedType.LPWStr)> _
            Public lpProvider As String
        End Structure

        <DllImportAttribute("mpr.dll", EntryPoint:="WNetAddConnection2W")> _
        Public Shared Function WNetAddConnection2(ByRef lpNetResource As NETRESOURCE, <InAttribute(), MarshalAsAttribute(UnmanagedType.LPWStr)> ByVal lpPassword As String, <InAttribute(), MarshalAsAttribute(UnmanagedType.LPWStr)> ByVal lpUserName As String, ByVal dwFlags As UInteger) As UInteger
        End Function

        <DllImportAttribute("mpr.dll", EntryPoint:="WNetCancelConnection2W")> _
        Public Shared Function WNetCancelConnection(<InAttribute(), MarshalAsAttribute(UnmanagedType.LPWStr)> ByVal lpName As String, ByVal dwFlags As UInteger, <MarshalAsAttribute(UnmanagedType.Bool)> ByVal fForce As Boolean) As UInteger
        End Function

        Private Function verificaDrives() As Boolean
            For Each drive As IO.DriveInfo In My.Computer.
                FileSystem.Drives()
                'ListBox1.Items.Add(drive)
                If drive.ToString = "H:\" Or drive.ToString = "S:\" Or drive.ToString = "T:\" Then
                    'MsgBox("Unidades já mapeadas")
                    Return False
                End If
            Next drive
            Return True
        End Function

        Public Sub MapNetworkDrive(ByVal UncPath As String, ByVal DriveLetter As Char, ByVal Persistent As Boolean, Optional ByVal ConnectionUsername As String = Nothing, Optional ByVal ConnectionPassword As String = Nothing)

            Dim usuario As String = Logon.txtUsuario.Text
            Dim senha As String = Logon.txtSenha.Text
            ConnectionUsername = usuario
            ConnectionPassword = senha

            Try
                If String.IsNullOrEmpty(UncPath) Then
                    Throw New ArgumentException("No UNC path specified", "UncPath")
                End If
                Dim DriveInfo As New NETRESOURCE
                With DriveInfo
                    .dwType = RESOURCETYPE_DISK
                    .lpLocalName = DriveLetter & ":"
                    .lpRemoteName = UncPath
                End With
                Dim flags As UInteger = 0
                If Persistent Then
                    flags = &H1
                End If
                Dim Result As UInteger = WNetAddConnection2(DriveInfo, ConnectionPassword, ConnectionUsername, flags)
                If Not Result = NO_ERROR Then
                    Throw New System.ComponentModel.Win32Exception(CInt(Result))
                    MsgBox(Result)
                End If
            Catch ex As Exception
                MsgBox("Erro!!!" & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical)
                Logon.txtUsuario.Text = ""
            End Try

        End Sub

        Public Shared Sub RemoveNetworkDrive(ByVal DriveLetter As Char, ByVal Force As Boolean)
            Try
                Dim Result As UInteger = WNetCancelConnection(DriveLetter & ":", CONNECT_UPDATE_PROFILE, Force)
                If Not Result = NO_ERROR Then
                    Throw New System.ComponentModel.Win32Exception(CInt(Result))
                End If
            Catch ex As Exception
                MsgBox("Erro!!!" & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End Try
    End Sub

    Private Sub btnMapear_Click(sender As Object, e As EventArgs) Handles btnMapear.Click
        If verificaDrives() = False Then
            RemoveNetworkDrive("H"c, True)
            RemoveNetworkDrive("S"c, True)
            RemoveNetworkDrive("T"c, True)
            Logon.Show()
            'Exit Sub
        Else
            Logon.Show()
        End If
    End Sub

    Private Sub btnDesconectar_Click(sender As Object, e As EventArgs) Handles btnDesconectar.Click
        If verificaDrives() = False Then
            RemoveNetworkDrive("H"c, True)
            RemoveNetworkDrive("S"c, True)
            RemoveNetworkDrive("T"c, True)
            MsgBox("Desconectado com Sucesso")
            Me.LabelUsuarioConectado.Text = ""
        Else
            MsgBox("Unidades já estão Desconectadas")
            Me.LabelUsuarioConectado.Text = ""
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnProxyEnable_Click(sender As Object, e As EventArgs) Handles btnProxyEnable.Click
        Dim sProxy As New IEProxy
        'set
        sProxy.SetProxy("192.168.135.79:8080") 'Returns True if successful
        MsgBox("Proxy ativado com sucesso!!")
    End Sub

    Private Sub btnProxyDisable_Click(sender As Object, e As EventArgs) Handles btnProxyDisable.Click
        Dim sProxy As New IEProxy
        'disable
        sProxy.DisableProxy() 'Returns True if successful
        MsgBox("Proxy desativado com sucesso!!")
    End Sub
End Class