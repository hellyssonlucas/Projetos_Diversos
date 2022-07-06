Imports System.IO
Public Class Apaga_Arquivo

    Private Sub Apaga_Arquivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        File.Delete("C:\Imagens\1Evento.jpeg")
        Me.Close()
    End Sub
End Class