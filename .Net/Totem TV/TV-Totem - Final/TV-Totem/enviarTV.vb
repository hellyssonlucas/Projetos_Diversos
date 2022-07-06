Imports System.IO
Public Class enviarTV

    Private Sub btEnviarTV_Click(sender As Object, e As EventArgs) Handles btEnviarTV.Click
        Try
            If Label1.Text = "1" Then
                ImagemTotem1.Converte1()
                ImagemTotem1.Close()
                novoEvento.Close()
                Me.Close()

            ElseIf Label1.Text = "2" Then
                ImagemTotem1.Converte2()
                ImagemTotem1.Close()
                novoEvento.Close()
                Me.Close()

            ElseIf Label1.Text = "3" Then
                ImagemTotem1.Converte3()
                ImagemTotem1.Close()
                novoEvento.Close()
                Me.Close()

            ElseIf Label1.Text = "4" Then
                ImagemTotem1.Converte4()
                ImagemTotem1.Close()
                novoEvento.Close()
                Me.Close()

            ElseIf Label1.Text = "5" Then
                ImagemTotem1.Converte5()
                ImagemTotem1.Close()
                novoEvento.Close()
                Me.Close()

            ElseIf Label1.Text = "6" Then
                ImagemTotem1.Converte6()
                ImagemTotem1.Close()
                novoEvento.Close()
                Me.Close()

            ElseIf Label1.Text = "7" Then
                ImagemTotem1.Converte7()
                ImagemTotem1.Close()
                novoEvento.Close()
                Me.Close()

            ElseIf Label1.Text = "8" Then
                ImagemTotem1.Converte8()
                ImagemTotem1.Close()
                novoEvento.Close()
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub enviarTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class