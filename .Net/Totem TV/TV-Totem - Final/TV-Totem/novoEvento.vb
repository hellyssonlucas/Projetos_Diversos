Public Class novoEvento

    Private Sub novoEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.EventosTableAdapter7.Fill(Me.DadosDataSet8.Eventos)
        Me.EventosTableAdapter6.Fill(Me.DadosDataSet7.Eventos)
        Me.EventosTableAdapter5.Fill(Me.DadosDataSet6.Eventos)
        Me.EventosTableAdapter4.Fill(Me.DadosDataSet5.Eventos)
        Me.EventosTableAdapter3.Fill(Me.DadosDataSet4.Eventos)
        Me.EventosTableAdapter2.Fill(Me.DadosDataSet3.Eventos)
        Me.EventosTableAdapter1.Fill(Me.DadosDataSet2.Eventos)
        Me.EventosTableAdapter.Fill(Me.DadosDataSet1.Eventos)

        Me.SalasTableAdapter7.Fill(Me.DadosDataSet8.Salas)
        Me.SalasTableAdapter6.Fill(Me.DadosDataSet7.Salas)
        Me.SalasTableAdapter5.Fill(Me.DadosDataSet6.Salas)
        Me.SalasTableAdapter4.Fill(Me.DadosDataSet5.Salas)
        Me.SalasTableAdapter3.Fill(Me.DadosDataSet4.Salas)
        Me.SalasTableAdapter2.Fill(Me.DadosDataSet3.Salas)
        Me.SalasTableAdapter1.Fill(Me.DadosDataSet2.Salas)
        Me.SalasTableAdapter.Fill(Me.DadosDataSet1.Salas)

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
        Panel8.Visible = False


    End Sub

    Private Sub btProcessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProcessar.Click
        Try
            ocultarTodosLabels()
            mostrarData()
            ImagemTotem1.Show()

            If cbQuantEventos.SelectedItem = "1" Then
                carregarevento1()
                ImagemTotem1.BackgroundImage = My.Resources._1Treinamento
            ElseIf cbQuantEventos.SelectedItem = "2" Then
                carregarevento2()
                ImagemTotem1.BackgroundImage = My.Resources._2Treinamento
            ElseIf cbQuantEventos.SelectedItem = "3" Then
                carregarevento3()
                ImagemTotem1.BackgroundImage = My.Resources._3Treinamento
            ElseIf cbQuantEventos.SelectedItem = "4" Then
                carregarevento4()
                ImagemTotem1.BackgroundImage = My.Resources._4Treinamento
            ElseIf cbQuantEventos.SelectedItem = "5" Then
                carregarevento5()
                ImagemTotem1.BackgroundImage = My.Resources._5Treinamento
            ElseIf cbQuantEventos.SelectedItem = "6" Then
                carregarevento6()
                ImagemTotem1.BackgroundImage = My.Resources._6Treinamento
            ElseIf cbQuantEventos.SelectedItem = "7" Then
                carregarevento7()
                ImagemTotem1.BackgroundImage = My.Resources._7Treinamento
            ElseIf cbQuantEventos.SelectedItem = "8" Then
                carregarevento8()
                ImagemTotem1.BackgroundImage = My.Resources._8Treinamento
            End If
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub btCarregar_Click(sender As Object, e As EventArgs) Handles btCarregar.Click

        If cbQuantEventos.SelectedItem = "1" Then
            Panel1.Visible = True
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
            Panel8.Visible = False
        ElseIf cbQuantEventos.SelectedItem = "2" Then
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
            Panel8.Visible = False
        ElseIf cbQuantEventos.SelectedItem = "3" Then
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = True
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
            Panel8.Visible = False
        ElseIf cbQuantEventos.SelectedItem = "4" Then
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = True
            Panel4.Visible = True
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
            Panel8.Visible = False
        ElseIf cbQuantEventos.SelectedItem = "5" Then
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = True
            Panel4.Visible = True
            Panel5.Visible = True
            Panel6.Visible = False
            Panel7.Visible = False
            Panel8.Visible = False
        ElseIf cbQuantEventos.SelectedItem = "6" Then
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = True
            Panel4.Visible = True
            Panel5.Visible = True
            Panel6.Visible = True
            Panel7.Visible = False
            Panel8.Visible = False
        ElseIf cbQuantEventos.SelectedItem = "7" Then
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = True
            Panel4.Visible = True
            Panel5.Visible = True
            Panel6.Visible = True
            Panel7.Visible = True
            Panel8.Visible = False
        ElseIf cbQuantEventos.SelectedItem = "8" Then
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = True
            Panel4.Visible = True
            Panel5.Visible = True
            Panel6.Visible = True
            Panel7.Visible = True
            Panel8.Visible = True
        Else
            MsgBox("Favor digitar a quantidade de Eventos" + vbCrLf + "Depois clique em Carregar")
        End If

    End Sub

    Private Sub mostrarData()
        Dim dia As Double = DateTimePicker1.Value.Day
        Dim mes As Double = DateTimePicker1.Value.Month.ToString

        If dia >= 10 And mes >= 10 Then
            ImagemTotem1.lbDataEvento.Text = dia.ToString + "." + mes.ToString
        ElseIf dia < 10 And mes >= 10 Then
            ImagemTotem1.lbDataEvento.Text = "0" + dia.ToString + "." + mes.ToString
        ElseIf dia >= 10 And mes < 10 Then
            ImagemTotem1.lbDataEvento.Text = dia.ToString + ".0" + mes.ToString
        ElseIf dia < 10 And mes < 10 Then
            ImagemTotem1.lbDataEvento.Text = "0" + dia.ToString + ".0" + mes.ToString
        End If
    End Sub

    Private Sub carregarevento1()
        ImagemTotem1.lbNomeEvento1.Text = cbNomeEvento1.SelectedValue.ToString
        ImagemTotem1.lbNomeSala1.Text = cbNomeSala1.SelectedValue.ToString
        ImagemTotem1.lbHoraIni1.Text = cbHoraIni1.SelectedItem.ToString
        ImagemTotem1.lbHoraFim1.Text = cbHoraFim1.SelectedItem.ToString
    End Sub
    Private Sub carregarevento2()
        carregarevento1()
        ImagemTotem1.lbNomeEvento2.Text = cbNomeEvento2.SelectedValue.ToString
        ImagemTotem1.lbNomeSala2.Text = cbNomeSala2.SelectedValue.ToString
        ImagemTotem1.lbHoraIni2.Text = cbHoraIni2.SelectedItem.ToString
        ImagemTotem1.lbHoraFim2.Text = cbHoraFim2.SelectedItem.ToString
    End Sub
    Private Sub carregarevento3()
        carregarevento2()
        ImagemTotem1.lbNomeEvento3.Text = cbNomeEvento3.SelectedValue.ToString
        ImagemTotem1.lbNomeSala3.Text = cbNomeSala3.SelectedValue.ToString
        ImagemTotem1.lbHoraIni3.Text = cbHoraIni3.SelectedItem.ToString
        ImagemTotem1.lbHoraFim3.Text = cbHoraFim3.SelectedItem.ToString
    End Sub
    Private Sub carregarevento4()
        carregarevento3()
        ImagemTotem1.lbNomeEvento4.Text = cbNomeEvento4.SelectedValue.ToString
        ImagemTotem1.lbNomeSala4.Text = cbNomeSala4.SelectedValue.ToString
        ImagemTotem1.lbHoraIni4.Text = cbHoraIni4.SelectedItem.ToString
        ImagemTotem1.lbHoraFim4.Text = cbHoraFim4.SelectedItem.ToString
    End Sub
    Private Sub carregarevento5()
        carregarevento4()
        ImagemTotem1.lbNomeEvento5.Text = cbNomeEvento5.SelectedValue.ToString
        ImagemTotem1.lbNomeSala5.Text = cbNomeSala5.SelectedValue.ToString
        ImagemTotem1.lbHoraIni5.Text = cbHoraIni5.SelectedItem.ToString
        ImagemTotem1.lbHoraFim5.Text = cbHoraFim5.SelectedItem.ToString
    End Sub
    Private Sub carregarevento6()
        carregarevento5()
        ImagemTotem1.lbNomeEvento6.Text = cbNomeEvento6.SelectedValue.ToString
        ImagemTotem1.lbNomeSala6.Text = cbNomeSala6.SelectedValue.ToString
        ImagemTotem1.lbHoraIni6.Text = cbHoraIni6.SelectedItem.ToString
        ImagemTotem1.lbHoraFim6.Text = cbHoraFim6.SelectedItem.ToString
    End Sub
    Private Sub carregarevento7()
        carregarevento6()
        ImagemTotem1.lbNomeEvento7.Text = cbNomeEvento7.SelectedValue.ToString
        ImagemTotem1.lbNomeSala7.Text = cbNomeSala7.SelectedValue.ToString
        ImagemTotem1.lbHoraIni7.Text = cbHoraIni7.SelectedItem.ToString
        ImagemTotem1.lbHoraFim7.Text = cbHoraFim7.SelectedItem.ToString
    End Sub
    Private Sub carregarevento8()

        carregarevento7()
        ImagemTotem1.lbNomeEvento8.Text = cbNomeEvento8.SelectedValue.ToString
        ImagemTotem1.lbNomeSala8.Text = cbNomeSala8.SelectedValue.ToString
        ImagemTotem1.lbHoraIni8.Text = cbHoraIni8.SelectedItem.ToString
        ImagemTotem1.lbHoraFim8.Text = cbHoraFim8.SelectedItem.ToString
    End Sub

    Private Sub mostrarLabels1()
        ImagemTotem1.lbNomeEvento1.Visible = True
        ImagemTotem1.lbNomeSala1.Visible = True
        ImagemTotem1.lbHoraIni1.Visible = True
        ImagemTotem1.lbas1.Visible = True
        ImagemTotem1.lbHoraFim1.Visible = True
    End Sub
    Private Sub mostrarLabels2()
        mostrarLabels1()
        ImagemTotem1.lbNomeEvento2.Visible = True
        ImagemTotem1.lbNomeSala2.Visible = True
        ImagemTotem1.lbHoraIni2.Visible = True
        ImagemTotem1.lbas2.Visible = True
        ImagemTotem1.lbHoraFim2.Visible = True
    End Sub
    Private Sub mostrarLabels3()
        mostrarLabels2()
        ImagemTotem1.lbNomeEvento3.Visible = True
        ImagemTotem1.lbNomeSala3.Visible = True
        ImagemTotem1.lbHoraIni3.Visible = True
        ImagemTotem1.lbas3.Visible = True
        ImagemTotem1.lbHoraFim3.Visible = True
    End Sub
    Private Sub mostrarLabels4()
        mostrarLabels3()
        ImagemTotem1.lbNomeEvento4.Visible = True
        ImagemTotem1.lbNomeSala4.Visible = True
        ImagemTotem1.lbHoraIni4.Visible = True
        ImagemTotem1.lbas4.Visible = True
        ImagemTotem1.lbHoraFim4.Visible = True
    End Sub
    Private Sub mostrarLabels5()
        mostrarLabels4()
        ImagemTotem1.lbNomeEvento5.Visible = True
        ImagemTotem1.lbNomeSala5.Visible = True
        ImagemTotem1.lbHoraIni5.Visible = True
        ImagemTotem1.lbas5.Visible = True
        ImagemTotem1.lbHoraFim5.Visible = True
    End Sub
    Private Sub mostrarLabels6()
        mostrarLabels5()
        ImagemTotem1.lbNomeEvento6.Visible = True
        ImagemTotem1.lbNomeSala6.Visible = True
        ImagemTotem1.lbHoraIni6.Visible = True
        ImagemTotem1.lbas6.Visible = True
        ImagemTotem1.lbHoraFim6.Visible = True
    End Sub
    Private Sub mostrarLabels7()
        mostrarLabels6()
        ImagemTotem1.lbNomeEvento7.Visible = True
        ImagemTotem1.lbNomeSala7.Visible = True
        ImagemTotem1.lbHoraIni7.Visible = True
        ImagemTotem1.lbas7.Visible = True
        ImagemTotem1.lbHoraFim7.Visible = True
    End Sub
    Private Sub mostrarLabels8()
        mostrarLabels7()
        ImagemTotem1.lbNomeEvento8.Visible = True
        ImagemTotem1.lbNomeSala8.Visible = True
        ImagemTotem1.lbHoraIni8.Visible = True
        ImagemTotem1.lbas8.Visible = True
        ImagemTotem1.lbHoraFim8.Visible = True
    End Sub

    Private Sub ocultarTodosLabels()
        ImagemTotem1.lbAgendadeHoje.Visible = False
        ImagemTotem1.lbDataEvento.Visible = False
        ImagemTotem1.lbInstrucoes.Visible = False

        ImagemTotem1.lbNomeEvento1.Visible = False
        ImagemTotem1.lbNomeSala1.Visible = False
        ImagemTotem1.lbHoraIni1.Visible = False
        ImagemTotem1.lbas1.Visible = False
        ImagemTotem1.lbHoraFim1.Visible = False

        ImagemTotem1.lbNomeEvento2.Visible = False
        ImagemTotem1.lbNomeSala2.Visible = False
        ImagemTotem1.lbHoraIni2.Visible = False
        ImagemTotem1.lbas2.Visible = False
        ImagemTotem1.lbHoraFim2.Visible = False

        ImagemTotem1.lbNomeEvento3.Visible = False
        ImagemTotem1.lbNomeSala3.Visible = False
        ImagemTotem1.lbHoraIni3.Visible = False
        ImagemTotem1.lbas3.Visible = False
        ImagemTotem1.lbHoraFim3.Visible = False

        ImagemTotem1.lbNomeEvento4.Visible = False
        ImagemTotem1.lbNomeSala4.Visible = False
        ImagemTotem1.lbHoraIni4.Visible = False
        ImagemTotem1.lbas4.Visible = False
        ImagemTotem1.lbHoraFim4.Visible = False

        ImagemTotem1.lbNomeEvento5.Visible = False
        ImagemTotem1.lbNomeSala5.Visible = False
        ImagemTotem1.lbHoraIni5.Visible = False
        ImagemTotem1.lbas5.Visible = False
        ImagemTotem1.lbHoraFim5.Visible = False

        ImagemTotem1.lbNomeEvento6.Visible = False
        ImagemTotem1.lbNomeSala6.Visible = False
        ImagemTotem1.lbHoraIni6.Visible = False
        ImagemTotem1.lbas6.Visible = False
        ImagemTotem1.lbHoraFim6.Visible = False

        ImagemTotem1.lbNomeEvento7.Visible = False
        ImagemTotem1.lbNomeSala7.Visible = False
        ImagemTotem1.lbHoraIni7.Visible = False
        ImagemTotem1.lbas7.Visible = False
        ImagemTotem1.lbHoraFim7.Visible = False

        ImagemTotem1.lbNomeEvento8.Visible = False
        ImagemTotem1.lbNomeSala8.Visible = False
        ImagemTotem1.lbHoraIni8.Visible = False
        ImagemTotem1.lbas8.Visible = False
        ImagemTotem1.lbHoraFim8.Visible = False

    End Sub

    Private Sub BtNomeEvento1_Click(sender As Object, e As EventArgs) Handles BtNomeEvento1.Click

        'Dim cadEventoNome1 As New cadEventoNome
        'cadEventoNome1.Show()
        cadEventoNome.Show()

    End Sub

    Private Sub btNomeSala1_Click(sender As Object, e As EventArgs) Handles btNomeSala1.Click
        cadSalaNome.Show()
    End Sub

    Private Sub btAtualizaCampos_Click(sender As Object, e As EventArgs) Handles btAtualizaCampos.Click
        Me.EventosTableAdapter7.Fill(Me.DadosDataSet8.Eventos)
        Me.EventosTableAdapter6.Fill(Me.DadosDataSet7.Eventos)
        Me.EventosTableAdapter5.Fill(Me.DadosDataSet6.Eventos)
        Me.EventosTableAdapter4.Fill(Me.DadosDataSet5.Eventos)
        Me.EventosTableAdapter3.Fill(Me.DadosDataSet4.Eventos)
        Me.EventosTableAdapter2.Fill(Me.DadosDataSet3.Eventos)
        Me.EventosTableAdapter1.Fill(Me.DadosDataSet2.Eventos)
        Me.EventosTableAdapter.Fill(Me.DadosDataSet1.Eventos)
        Me.SalasTableAdapter7.Fill(Me.DadosDataSet8.Salas)
        Me.SalasTableAdapter6.Fill(Me.DadosDataSet7.Salas)
        Me.SalasTableAdapter5.Fill(Me.DadosDataSet6.Salas)
        Me.SalasTableAdapter4.Fill(Me.DadosDataSet5.Salas)
        Me.SalasTableAdapter3.Fill(Me.DadosDataSet4.Salas)
        Me.SalasTableAdapter2.Fill(Me.DadosDataSet3.Salas)
        Me.SalasTableAdapter1.Fill(Me.DadosDataSet2.Salas)
        Me.SalasTableAdapter.Fill(Me.DadosDataSet1.Salas)
    End Sub

End Class