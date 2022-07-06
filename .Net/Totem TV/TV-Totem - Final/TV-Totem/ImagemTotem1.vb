Imports System.IO
Public Class ImagemTotem1

    Private Sub ImagemTotem1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Evento1_Rotate(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim NewFont = New Font("Dax-Medium", 20, FontStyle.Bold)
        Dim NewFont1 = New Font("Dax-MediumCaps", 28, FontStyle.Bold)
        Dim NewFont2 = New Font("Dax-ExtraBold", 14, FontStyle.Italic)
        Dim NewFont3 = New Font("Dax-ExtraBold", 12, FontStyle.Italic)
        Dim NewFont4 = New Font("Dax-Medium", 16, FontStyle.Italic)

        ' Subroutine to alter text angle. 
        RotateText(e.Graphics, NewFont1, lbAgendadeHoje.Text, -90, Brushes.White, -710, 105)
        RotateText(e.Graphics, NewFont1, lbDataEvento.Text, -90, Brushes.White, -400, 105)

        If novoEvento.cbQuantEventos.Text = "1" Then
            RotateText(e.Graphics, NewFont, lbNomeEvento1.Text, -90, Brushes.DarkBlue, -710, 190)
            RotateText(e.Graphics, NewFont, lbNomeSala1.Text, -90, Brushes.White, -700, 245)
            RotateText(e.Graphics, NewFont2, lbHoraIni1.Text, -90, Brushes.Black, -145, 255)
            RotateText(e.Graphics, NewFont3, lbas1.Text, -90, Brushes.Black, -85, 255)
            RotateText(e.Graphics, NewFont2, lbHoraFim1.Text, -90, Brushes.Black, -65, 255)

            RotateText(e.Graphics, NewFont4, lbInstrucoes.Text, -90, Brushes.Black, -250, 1150)

            enviarTV.Label1.Text = "1"
            SaveFormToFile("c:\Imagens\1Evento.jpeg")
            enviarTV.Show()

        ElseIf novoEvento.cbQuantEventos.Text = "2" Then

            RotateText(e.Graphics, NewFont, lbNomeEvento1.Text, -90, Brushes.DarkBlue, -710, 190)
            RotateText(e.Graphics, NewFont, lbNomeSala1.Text, -90, Brushes.White, -700, 245)
            RotateText(e.Graphics, NewFont2, lbHoraIni1.Text, -90, Brushes.Black, -145, 255)
            RotateText(e.Graphics, NewFont3, lbas1.Text, -90, Brushes.Black, -85, 255)
            RotateText(e.Graphics, NewFont2, lbHoraFim1.Text, -90, Brushes.Black, -65, 255)

            RotateText(e.Graphics, NewFont, lbNomeEvento2.Text, -90, Brushes.DarkBlue, -710, 305)
            RotateText(e.Graphics, NewFont, lbNomeSala2.Text, -90, Brushes.White, -700, 365)
            RotateText(e.Graphics, NewFont2, lbHoraIni2.Text, -90, Brushes.Black, -145, 370)
            RotateText(e.Graphics, NewFont3, lbas2.Text, -90, Brushes.Black, -85, 370)
            RotateText(e.Graphics, NewFont2, lbHoraFim2.Text, -90, Brushes.Black, -65, 370)

            RotateText(e.Graphics, NewFont4, lbInstrucoes.Text, -90, Brushes.Black, -250, 1150)

            enviarTV.Label1.Text = "2"
            SaveFormToFile("c:\Imagens\2Eventos.jpeg")
            enviarTV.Show()

        ElseIf novoEvento.cbQuantEventos.Text = "3" Then

            RotateText(e.Graphics, NewFont, lbNomeEvento1.Text, -90, Brushes.DarkBlue, -710, 190)
            RotateText(e.Graphics, NewFont, lbNomeSala1.Text, -90, Brushes.White, -700, 245)
            RotateText(e.Graphics, NewFont2, lbHoraIni1.Text, -90, Brushes.Black, -145, 255)
            RotateText(e.Graphics, NewFont3, lbas1.Text, -90, Brushes.Black, -85, 255)
            RotateText(e.Graphics, NewFont2, lbHoraFim1.Text, -90, Brushes.Black, -65, 255)

            RotateText(e.Graphics, NewFont, lbNomeEvento2.Text, -90, Brushes.DarkBlue, -710, 305)
            RotateText(e.Graphics, NewFont, lbNomeSala2.Text, -90, Brushes.White, -700, 365)
            RotateText(e.Graphics, NewFont2, lbHoraIni2.Text, -90, Brushes.Black, -145, 370)
            RotateText(e.Graphics, NewFont3, lbas2.Text, -90, Brushes.Black, -85, 370)
            RotateText(e.Graphics, NewFont2, lbHoraFim2.Text, -90, Brushes.Black, -65, 370)

            RotateText(e.Graphics, NewFont, lbNomeEvento3.Text, -90, Brushes.DarkBlue, -710, 430)
            RotateText(e.Graphics, NewFont, lbNomeSala3.Text, -90, Brushes.White, -700, 485)
            RotateText(e.Graphics, NewFont2, lbHoraIni3.Text, -90, Brushes.Black, -145, 490)
            RotateText(e.Graphics, NewFont3, lbas3.Text, -90, Brushes.Black, -85, 490)
            RotateText(e.Graphics, NewFont2, lbHoraFim3.Text, -90, Brushes.Black, -65, 490)

            RotateText(e.Graphics, NewFont4, lbInstrucoes.Text, -90, Brushes.Black, -250, 1150)

            enviarTV.Label1.Text = "3"
            SaveFormToFile("c:\Imagens\3Eventos.jpeg")
            enviarTV.Show()

        ElseIf novoEvento.cbQuantEventos.Text = "4" Then
            RotateText(e.Graphics, NewFont, lbNomeEvento1.Text, -90, Brushes.DarkBlue, -710, 190)
            RotateText(e.Graphics, NewFont, lbNomeSala1.Text, -90, Brushes.White, -700, 245)
            RotateText(e.Graphics, NewFont2, lbHoraIni1.Text, -90, Brushes.Black, -145, 255)
            RotateText(e.Graphics, NewFont3, lbas1.Text, -90, Brushes.Black, -85, 255)
            RotateText(e.Graphics, NewFont2, lbHoraFim1.Text, -90, Brushes.Black, -65, 255)

            RotateText(e.Graphics, NewFont, lbNomeEvento2.Text, -90, Brushes.DarkBlue, -710, 305)
            RotateText(e.Graphics, NewFont, lbNomeSala2.Text, -90, Brushes.White, -700, 365)
            RotateText(e.Graphics, NewFont2, lbHoraIni2.Text, -90, Brushes.Black, -145, 370)
            RotateText(e.Graphics, NewFont3, lbas2.Text, -90, Brushes.Black, -85, 370)
            RotateText(e.Graphics, NewFont2, lbHoraFim2.Text, -90, Brushes.Black, -65, 370)

            RotateText(e.Graphics, NewFont, lbNomeEvento3.Text, -90, Brushes.DarkBlue, -710, 430)
            RotateText(e.Graphics, NewFont, lbNomeSala3.Text, -90, Brushes.White, -700, 485)
            RotateText(e.Graphics, NewFont2, lbHoraIni3.Text, -90, Brushes.Black, -145, 490)
            RotateText(e.Graphics, NewFont3, lbas3.Text, -90, Brushes.Black, -85, 490)
            RotateText(e.Graphics, NewFont2, lbHoraFim3.Text, -90, Brushes.Black, -65, 490)

            RotateText(e.Graphics, NewFont, lbNomeEvento4.Text, -90, Brushes.DarkBlue, -710, 560)
            RotateText(e.Graphics, NewFont, lbNomeSala4.Text, -90, Brushes.White, -700, 615)
            RotateText(e.Graphics, NewFont2, lbHoraIni4.Text, -90, Brushes.Black, -145, 620)
            RotateText(e.Graphics, NewFont3, lbas4.Text, -90, Brushes.Black, -85, 620)
            RotateText(e.Graphics, NewFont2, lbHoraFim4.Text, -90, Brushes.Black, -65, 620)

            RotateText(e.Graphics, NewFont4, lbInstrucoes.Text, -90, Brushes.Black, -250, 1150)

            enviarTV.Label1.Text = "4"
            SaveFormToFile("c:\Imagens\4Eventos.jpeg")
            enviarTV.Show()

        ElseIf novoEvento.cbQuantEventos.Text = "5" Then
            RotateText(e.Graphics, NewFont, lbNomeEvento1.Text, -90, Brushes.DarkBlue, -710, 190)
            RotateText(e.Graphics, NewFont, lbNomeSala1.Text, -90, Brushes.White, -700, 245)
            RotateText(e.Graphics, NewFont2, lbHoraIni1.Text, -90, Brushes.Black, -145, 255)
            RotateText(e.Graphics, NewFont3, lbas1.Text, -90, Brushes.Black, -85, 255)
            RotateText(e.Graphics, NewFont2, lbHoraFim1.Text, -90, Brushes.Black, -65, 255)

            RotateText(e.Graphics, NewFont, lbNomeEvento2.Text, -90, Brushes.DarkBlue, -710, 305)
            RotateText(e.Graphics, NewFont, lbNomeSala2.Text, -90, Brushes.White, -700, 365)
            RotateText(e.Graphics, NewFont2, lbHoraIni2.Text, -90, Brushes.Black, -145, 370)
            RotateText(e.Graphics, NewFont3, lbas2.Text, -90, Brushes.Black, -85, 370)
            RotateText(e.Graphics, NewFont2, lbHoraFim2.Text, -90, Brushes.Black, -65, 370)

            RotateText(e.Graphics, NewFont, lbNomeEvento3.Text, -90, Brushes.DarkBlue, -710, 430)
            RotateText(e.Graphics, NewFont, lbNomeSala3.Text, -90, Brushes.White, -700, 485)
            RotateText(e.Graphics, NewFont2, lbHoraIni3.Text, -90, Brushes.Black, -145, 490)
            RotateText(e.Graphics, NewFont3, lbas3.Text, -90, Brushes.Black, -85, 490)
            RotateText(e.Graphics, NewFont2, lbHoraFim3.Text, -90, Brushes.Black, -65, 490)

            RotateText(e.Graphics, NewFont, lbNomeEvento4.Text, -90, Brushes.DarkBlue, -710, 560)
            RotateText(e.Graphics, NewFont, lbNomeSala4.Text, -90, Brushes.White, -700, 615)
            RotateText(e.Graphics, NewFont2, lbHoraIni4.Text, -90, Brushes.Black, -145, 620)
            RotateText(e.Graphics, NewFont3, lbas4.Text, -90, Brushes.Black, -85, 620)
            RotateText(e.Graphics, NewFont2, lbHoraFim4.Text, -90, Brushes.Black, -65, 620)

            RotateText(e.Graphics, NewFont, lbNomeEvento5.Text, -90, Brushes.DarkBlue, -710, 675)
            RotateText(e.Graphics, NewFont, lbNomeSala5.Text, -90, Brushes.White, -700, 730)
            RotateText(e.Graphics, NewFont2, lbHoraIni5.Text, -90, Brushes.Black, -145, 735)
            RotateText(e.Graphics, NewFont3, lbas5.Text, -90, Brushes.Black, -85, 735)
            RotateText(e.Graphics, NewFont2, lbHoraFim5.Text, -90, Brushes.Black, -65, 735)

            RotateText(e.Graphics, NewFont4, lbInstrucoes.Text, -90, Brushes.Black, -250, 1150)

            enviarTV.Label1.Text = "5"
            SaveFormToFile("c:\Imagens\5Eventos.jpeg")
            enviarTV.Show()

        ElseIf novoEvento.cbQuantEventos.Text = "6" Then
            RotateText(e.Graphics, NewFont, lbNomeEvento1.Text, -90, Brushes.DarkBlue, -710, 190)
            RotateText(e.Graphics, NewFont, lbNomeSala1.Text, -90, Brushes.White, -700, 245)
            RotateText(e.Graphics, NewFont2, lbHoraIni1.Text, -90, Brushes.Black, -145, 255)
            RotateText(e.Graphics, NewFont3, lbas1.Text, -90, Brushes.Black, -85, 255)
            RotateText(e.Graphics, NewFont2, lbHoraFim1.Text, -90, Brushes.Black, -65, 255)

            RotateText(e.Graphics, NewFont, lbNomeEvento2.Text, -90, Brushes.DarkBlue, -710, 305)
            RotateText(e.Graphics, NewFont, lbNomeSala2.Text, -90, Brushes.White, -700, 365)
            RotateText(e.Graphics, NewFont2, lbHoraIni2.Text, -90, Brushes.Black, -145, 370)
            RotateText(e.Graphics, NewFont3, lbas2.Text, -90, Brushes.Black, -85, 370)
            RotateText(e.Graphics, NewFont2, lbHoraFim2.Text, -90, Brushes.Black, -65, 370)

            RotateText(e.Graphics, NewFont, lbNomeEvento3.Text, -90, Brushes.DarkBlue, -710, 430)
            RotateText(e.Graphics, NewFont, lbNomeSala3.Text, -90, Brushes.White, -700, 485)
            RotateText(e.Graphics, NewFont2, lbHoraIni3.Text, -90, Brushes.Black, -145, 490)
            RotateText(e.Graphics, NewFont3, lbas3.Text, -90, Brushes.Black, -85, 490)
            RotateText(e.Graphics, NewFont2, lbHoraFim3.Text, -90, Brushes.Black, -65, 490)

            RotateText(e.Graphics, NewFont, lbNomeEvento4.Text, -90, Brushes.DarkBlue, -710, 560)
            RotateText(e.Graphics, NewFont, lbNomeSala4.Text, -90, Brushes.White, -700, 615)
            RotateText(e.Graphics, NewFont2, lbHoraIni4.Text, -90, Brushes.Black, -145, 620)
            RotateText(e.Graphics, NewFont3, lbas4.Text, -90, Brushes.Black, -85, 620)
            RotateText(e.Graphics, NewFont2, lbHoraFim4.Text, -90, Brushes.Black, -65, 620)

            RotateText(e.Graphics, NewFont, lbNomeEvento5.Text, -90, Brushes.DarkBlue, -710, 675)
            RotateText(e.Graphics, NewFont, lbNomeSala5.Text, -90, Brushes.White, -700, 730)
            RotateText(e.Graphics, NewFont2, lbHoraIni5.Text, -90, Brushes.Black, -145, 735)
            RotateText(e.Graphics, NewFont3, lbas5.Text, -90, Brushes.Black, -85, 735)
            RotateText(e.Graphics, NewFont2, lbHoraFim5.Text, -90, Brushes.Black, -65, 735)

            RotateText(e.Graphics, NewFont, lbNomeEvento6.Text, -90, Brushes.DarkBlue, -710, 800)
            RotateText(e.Graphics, NewFont, lbNomeSala6.Text, -90, Brushes.White, -700, 855)
            RotateText(e.Graphics, NewFont2, lbHoraIni6.Text, -90, Brushes.Black, -145, 860)
            RotateText(e.Graphics, NewFont3, lbas6.Text, -90, Brushes.Black, -85, 860)
            RotateText(e.Graphics, NewFont2, lbHoraFim6.Text, -90, Brushes.Black, -65, 860)

            RotateText(e.Graphics, NewFont4, lbInstrucoes.Text, -90, Brushes.Black, -250, 1150)

            enviarTV.Label1.Text = "6"
            SaveFormToFile("c:\Imagens\6Eventos.jpeg")
            enviarTV.Show()

        ElseIf novoEvento.cbQuantEventos.Text = "7" Then
            RotateText(e.Graphics, NewFont, lbNomeEvento1.Text, -90, Brushes.DarkBlue, -710, 190)
            RotateText(e.Graphics, NewFont, lbNomeSala1.Text, -90, Brushes.White, -700, 245)
            RotateText(e.Graphics, NewFont2, lbHoraIni1.Text, -90, Brushes.Black, -145, 255)
            RotateText(e.Graphics, NewFont3, lbas1.Text, -90, Brushes.Black, -85, 255)
            RotateText(e.Graphics, NewFont2, lbHoraFim1.Text, -90, Brushes.Black, -65, 255)

            RotateText(e.Graphics, NewFont, lbNomeEvento2.Text, -90, Brushes.DarkBlue, -710, 305)
            RotateText(e.Graphics, NewFont, lbNomeSala2.Text, -90, Brushes.White, -700, 365)
            RotateText(e.Graphics, NewFont2, lbHoraIni2.Text, -90, Brushes.Black, -145, 370)
            RotateText(e.Graphics, NewFont3, lbas2.Text, -90, Brushes.Black, -85, 370)
            RotateText(e.Graphics, NewFont2, lbHoraFim2.Text, -90, Brushes.Black, -65, 370)

            RotateText(e.Graphics, NewFont, lbNomeEvento3.Text, -90, Brushes.DarkBlue, -710, 430)
            RotateText(e.Graphics, NewFont, lbNomeSala3.Text, -90, Brushes.White, -700, 485)
            RotateText(e.Graphics, NewFont2, lbHoraIni3.Text, -90, Brushes.Black, -145, 490)
            RotateText(e.Graphics, NewFont3, lbas3.Text, -90, Brushes.Black, -85, 490)
            RotateText(e.Graphics, NewFont2, lbHoraFim3.Text, -90, Brushes.Black, -65, 490)

            RotateText(e.Graphics, NewFont, lbNomeEvento4.Text, -90, Brushes.DarkBlue, -710, 560)
            RotateText(e.Graphics, NewFont, lbNomeSala4.Text, -90, Brushes.White, -700, 615)
            RotateText(e.Graphics, NewFont2, lbHoraIni4.Text, -90, Brushes.Black, -145, 620)
            RotateText(e.Graphics, NewFont3, lbas4.Text, -90, Brushes.Black, -85, 620)
            RotateText(e.Graphics, NewFont2, lbHoraFim4.Text, -90, Brushes.Black, -65, 620)

            RotateText(e.Graphics, NewFont, lbNomeEvento5.Text, -90, Brushes.DarkBlue, -710, 675)
            RotateText(e.Graphics, NewFont, lbNomeSala5.Text, -90, Brushes.White, -700, 730)
            RotateText(e.Graphics, NewFont2, lbHoraIni5.Text, -90, Brushes.Black, -145, 735)
            RotateText(e.Graphics, NewFont3, lbas5.Text, -90, Brushes.Black, -85, 735)
            RotateText(e.Graphics, NewFont2, lbHoraFim5.Text, -90, Brushes.Black, -65, 735)

            RotateText(e.Graphics, NewFont, lbNomeEvento6.Text, -90, Brushes.DarkBlue, -710, 800)
            RotateText(e.Graphics, NewFont, lbNomeSala6.Text, -90, Brushes.White, -700, 855)
            RotateText(e.Graphics, NewFont2, lbHoraIni6.Text, -90, Brushes.Black, -145, 860)
            RotateText(e.Graphics, NewFont3, lbas6.Text, -90, Brushes.Black, -85, 860)
            RotateText(e.Graphics, NewFont2, lbHoraFim6.Text, -90, Brushes.Black, -65, 860)

            RotateText(e.Graphics, NewFont, lbNomeEvento7.Text, -90, Brushes.DarkBlue, -710, 920)
            RotateText(e.Graphics, NewFont, lbNomeSala7.Text, -90, Brushes.White, -700, 975)
            RotateText(e.Graphics, NewFont2, lbHoraIni7.Text, -90, Brushes.Black, -145, 980)
            RotateText(e.Graphics, NewFont3, lbas7.Text, -90, Brushes.Black, -85, 980)
            RotateText(e.Graphics, NewFont2, lbHoraFim7.Text, -90, Brushes.Black, -65, 980)

            RotateText(e.Graphics, NewFont4, lbInstrucoes.Text, -90, Brushes.Black, -250, 1150)

            enviarTV.Label1.Text = "7"
            SaveFormToFile("c:\Imagens\7Eventos.jpeg")
            enviarTV.Show()

        ElseIf novoEvento.cbQuantEventos.Text = "8" Then

            RotateText(e.Graphics, NewFont, lbNomeEvento1.Text, -90, Brushes.DarkBlue, -710, 190)
            RotateText(e.Graphics, NewFont, lbNomeSala1.Text, -90, Brushes.White, -700, 245)
            RotateText(e.Graphics, NewFont2, lbHoraIni1.Text, -90, Brushes.Black, -145, 255)
            RotateText(e.Graphics, NewFont3, lbas1.Text, -90, Brushes.Black, -85, 255)
            RotateText(e.Graphics, NewFont2, lbHoraFim1.Text, -90, Brushes.Black, -65, 255)

            RotateText(e.Graphics, NewFont, lbNomeEvento2.Text, -90, Brushes.DarkBlue, -710, 305)
            RotateText(e.Graphics, NewFont, lbNomeSala2.Text, -90, Brushes.White, -700, 365)
            RotateText(e.Graphics, NewFont2, lbHoraIni2.Text, -90, Brushes.Black, -145, 370)
            RotateText(e.Graphics, NewFont3, lbas2.Text, -90, Brushes.Black, -85, 370)
            RotateText(e.Graphics, NewFont2, lbHoraFim2.Text, -90, Brushes.Black, -65, 370)

            RotateText(e.Graphics, NewFont, lbNomeEvento3.Text, -90, Brushes.DarkBlue, -710, 430)
            RotateText(e.Graphics, NewFont, lbNomeSala3.Text, -90, Brushes.White, -700, 485)
            RotateText(e.Graphics, NewFont2, lbHoraIni3.Text, -90, Brushes.Black, -145, 490)
            RotateText(e.Graphics, NewFont3, lbas3.Text, -90, Brushes.Black, -85, 490)
            RotateText(e.Graphics, NewFont2, lbHoraFim3.Text, -90, Brushes.Black, -65, 490)

            RotateText(e.Graphics, NewFont, lbNomeEvento4.Text, -90, Brushes.DarkBlue, -710, 560)
            RotateText(e.Graphics, NewFont, lbNomeSala4.Text, -90, Brushes.White, -700, 615)
            RotateText(e.Graphics, NewFont2, lbHoraIni4.Text, -90, Brushes.Black, -145, 620)
            RotateText(e.Graphics, NewFont3, lbas4.Text, -90, Brushes.Black, -85, 620)
            RotateText(e.Graphics, NewFont2, lbHoraFim4.Text, -90, Brushes.Black, -65, 620)

            RotateText(e.Graphics, NewFont, lbNomeEvento5.Text, -90, Brushes.DarkBlue, -710, 675)
            RotateText(e.Graphics, NewFont, lbNomeSala5.Text, -90, Brushes.White, -700, 730)
            RotateText(e.Graphics, NewFont2, lbHoraIni5.Text, -90, Brushes.Black, -145, 735)
            RotateText(e.Graphics, NewFont3, lbas5.Text, -90, Brushes.Black, -85, 735)
            RotateText(e.Graphics, NewFont2, lbHoraFim5.Text, -90, Brushes.Black, -65, 735)

            RotateText(e.Graphics, NewFont, lbNomeEvento6.Text, -90, Brushes.DarkBlue, -710, 800)
            RotateText(e.Graphics, NewFont, lbNomeSala6.Text, -90, Brushes.White, -700, 855)
            RotateText(e.Graphics, NewFont2, lbHoraIni6.Text, -90, Brushes.Black, -145, 860)
            RotateText(e.Graphics, NewFont3, lbas6.Text, -90, Brushes.Black, -85, 860)
            RotateText(e.Graphics, NewFont2, lbHoraFim6.Text, -90, Brushes.Black, -65, 860)

            RotateText(e.Graphics, NewFont, lbNomeEvento7.Text, -90, Brushes.DarkBlue, -710, 920)
            RotateText(e.Graphics, NewFont, lbNomeSala7.Text, -90, Brushes.White, -700, 975)
            RotateText(e.Graphics, NewFont2, lbHoraIni7.Text, -90, Brushes.Black, -145, 980)
            RotateText(e.Graphics, NewFont3, lbas7.Text, -90, Brushes.Black, -85, 980)
            RotateText(e.Graphics, NewFont2, lbHoraFim7.Text, -90, Brushes.Black, -65, 980)

            RotateText(e.Graphics, NewFont, lbNomeEvento8.Text, -90, Brushes.DarkBlue, -710, 1040)
            RotateText(e.Graphics, NewFont, lbNomeSala8.Text, -90, Brushes.White, -700, 1100)
            RotateText(e.Graphics, NewFont2, lbHoraIni8.Text, -90, Brushes.Black, -145, 1105)
            RotateText(e.Graphics, NewFont3, lbas8.Text, -90, Brushes.Black, -85, 1105)
            RotateText(e.Graphics, NewFont2, lbHoraFim8.Text, -90, Brushes.Black, -65, 1105)

            lbInstrucoes.Visible = False

            enviarTV.Label1.Text = "8"
            SaveFormToFile("c:\Imagens\8Eventos.jpeg")
            enviarTV.Show()
        End If

    End Sub

    Public Sub RotateText(ByVal g As Graphics, ByVal MyFont As Font, ByVal MyText As String, ByVal Angle As Single, ByVal MyBrush As Brush, ByVal X As Single, ByVal Y As Single)

        While Angle > 360
            Angle = Angle - 360
        End While
        While Angle < 0
            Angle = Angle + 360
        End While

        ' Create a matrix and rotate it n degrees. 
        Dim MyMatrix As New System.Drawing.Drawing2D.Matrix
        MyMatrix.Rotate(Angle, Drawing2D.MatrixOrder.Append)

        ' Draw the text to the screen after applying the transform. 
        g.Transform = MyMatrix
        g.DrawString(MyText, MyFont, MyBrush, X, Y)

    End Sub

    Private Sub SaveFormToFile(ByVal filename As String)

        Try
            Dim bmp As New Bitmap(Me.Width, Me.Height)
            Me.DrawToBitmap(bmp, Me.DisplayRectangle)
            bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Converte1()

        Try
            Dim diames As String = lbDataEvento.Text
            Dim oImgOriginal As System.Drawing.Image
            oImgOriginal = Image.FromFile("C:\Imagens\1Evento.jpeg")
            'REDIMENSIONO O ORIGINAL 
            Dim Tamanho As New Size(1920, 1080)
            oImgOriginal = New Bitmap(oImgOriginal, Tamanho)
            'SALVA A IMAGEM REDIMENSIONADA 
            Dim destino As String = ("C:\Imagens\")
            oImgOriginal.Save(destino + diames.ToString + "-1Evento-1920x1080.jpeg", Imaging.ImageFormat.Jpeg)

            'Dim saveFileDialog1 As New SaveFileDialog()
            'saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
            'saveFileDialog1.Title = "Save an Image File"
            'saveFileDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Converte2()

        Try
            Dim diames As String = lbDataEvento.Text
            Dim oImgOriginal As System.Drawing.Image
            oImgOriginal = Image.FromFile("C:\Imagens\2Eventos.jpeg")
            'REDIMENSIONO O ORIGINAL 
            Dim Tamanho As New Size(1920, 1080)
            oImgOriginal = New Bitmap(oImgOriginal, Tamanho)
            'SALVA A IMAGEM REDIMENSIONADA 
            Dim destino As String = ("C:\Imagens\")
            oImgOriginal.Save(destino + diames.ToString + "-2Eventos-1920x1080.jpeg", Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Converte3()

        Try
            Dim diames As String = lbDataEvento.Text
            Dim oImgOriginal As System.Drawing.Image
            oImgOriginal = Image.FromFile("C:\Imagens\3Eventos.jpeg")
            'REDIMENSIONO O ORIGINAL 
            Dim Tamanho As New Size(1920, 1080)
            oImgOriginal = New Bitmap(oImgOriginal, Tamanho)
            'SALVA A IMAGEM REDIMENSIONADA 
            Dim destino As String = ("C:\Imagens\")
            oImgOriginal.Save(destino + diames.ToString + "-3Eventos-1920x1080.jpeg", Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Converte4()

        Try
            Dim diames As String = lbDataEvento.Text
            Dim oImgOriginal As System.Drawing.Image
            oImgOriginal = Image.FromFile("C:\Imagens\4Eventos.jpeg")
            'REDIMENSIONO O ORIGINAL 
            Dim Tamanho As New Size(1920, 1080)
            oImgOriginal = New Bitmap(oImgOriginal, Tamanho)
            'SALVA A IMAGEM REDIMENSIONADA 
            Dim destino As String = ("C:\Imagens\")
            oImgOriginal.Save(destino + diames.ToString + "-4Eventos-1920x1080.jpeg", Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Converte5()

        Try
            Dim diames As String = lbDataEvento.Text
            Dim oImgOriginal As System.Drawing.Image
            oImgOriginal = Image.FromFile("C:\Imagens\5Eventos.jpeg")
            'REDIMENSIONO O ORIGINAL 
            Dim Tamanho As New Size(1920, 1080)
            oImgOriginal = New Bitmap(oImgOriginal, Tamanho)
            'SALVA A IMAGEM REDIMENSIONADA 
            Dim destino As String = ("C:\Imagens\")
            oImgOriginal.Save(destino + diames.ToString + "-5Eventos-1920x1080.jpeg", Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Converte6()

        Try
            Dim diames As String = lbDataEvento.Text
            Dim oImgOriginal As System.Drawing.Image
            oImgOriginal = Image.FromFile("C:\Imagens\6Eventos.jpeg")
            'REDIMENSIONO O ORIGINAL 
            Dim Tamanho As New Size(1920, 1080)
            oImgOriginal = New Bitmap(oImgOriginal, Tamanho)
            'SALVA A IMAGEM REDIMENSIONADA 
            Dim destino As String = ("C:\Imagens\")
            oImgOriginal.Save(destino + diames.ToString + "-6Eventos-1920x1080.jpeg", Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Converte7()

        Try
            Dim diames As String = lbDataEvento.Text
            Dim oImgOriginal As System.Drawing.Image
            oImgOriginal = Image.FromFile("C:\Imagens\7Eventos.jpeg")
            'REDIMENSIONO O ORIGINAL 
            Dim Tamanho As New Size(1920, 1080)
            oImgOriginal = New Bitmap(oImgOriginal, Tamanho)
            'SALVA A IMAGEM REDIMENSIONADA 
            Dim destino As String = ("C:\Imagens\")
            oImgOriginal.Save(destino + diames.ToString + "-7Eventos-1920x1080.jpeg", Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub Converte8()

        Try
            Dim diames As String = lbDataEvento.Text
            Dim oImgOriginal As System.Drawing.Image
            oImgOriginal = Image.FromFile("C:\Imagens\8Eventos.jpeg")
            'REDIMENSIONO O ORIGINAL 
            Dim Tamanho As New Size(1920, 1080)
            oImgOriginal = New Bitmap(oImgOriginal, Tamanho)
            'SALVA A IMAGEM REDIMENSIONADA 
            Dim destino As String = ("C:\Imagens\")
            oImgOriginal.Save(destino + diames.ToString + "-8Eventos-1920x1080.jpeg", Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Function TakeScreenShot(ByVal Control As Control) As Bitmap
        Dim tmpImg As New Bitmap(Control.Width, Control.Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(Control.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(Control.Width, Control.Height))
        End Using
        Return tmpImg

    End Function
End Class