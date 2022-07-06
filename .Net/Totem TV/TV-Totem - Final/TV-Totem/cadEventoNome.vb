Public Class cadEventoNome

    Private Sub cadEventoNome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim novoEvento As New novoEvento

        Me.EventosTableAdapter.Fill(Me.DadosDataSet.Eventos)
        NomeTextBox.Enabled = False

    End Sub

    Private Sub btNovoEvento_Click(sender As Object, e As EventArgs) Handles btNovoEvento.Click

        btApagarNomeEvento.Enabled = False
        btEditarNomeEvento.Visible = False
        btDesfazer.Visible = True
        Try
            NomeTextBox.Enabled = True
            NomeTextBox.Focus()
            Me.EventosBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub btApagarNomeEvento_Click(sender As Object, e As EventArgs) Handles btApagarNomeEvento.Click

        Me.EventosBindingSource.RemoveCurrent()
        Me.Validate()
        Me.EventosBindingSource.EndEdit()
        Me.EventosTableAdapter.Update(Me.DadosDataSet.Eventos)
        'atualizaNomesEventos()

    End Sub

    Private Sub btSalvarNomeEvento_Click(sender As Object, e As EventArgs) Handles btSalvarNomeEvento.Click

        Dim TbEvento As DataTable = Nothing
        TbEvento = EventosTableAdapter.GetDataByNome(NomeTextBox.Text)

        If TbEvento.Rows.Count <> 0 Then
            MessageBox.Show("Nome de Evento ja Cadastrado!! " & vbCrLf & "Digite outro Nome!!")
            NomeTextBox.Focus()
        Else
            Me.Validate()
            Me.EventosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DadosDataSet)
            Me.EventosTableAdapter.Fill(Me.DadosDataSet.Eventos)
            btApagarNomeEvento.Enabled = True
            'atualizaNomesEventos()
        End If
        NomeTextBox.Enabled = False
        btEditarNomeEvento.Visible = True

    End Sub

    Private Sub btEditarNomeEvento_Click(sender As Object, e As EventArgs) Handles btEditarNomeEvento.Click
        Try
            btEditarNomeEvento.Visible = False
            btDesfazer.Visible = True
            EventosBindingNavigator.Enabled = False
            NomeTextBox.Enabled = True

            Dim RegistroAtual As DataRowView = Me.EventosBindingSource.Current()

        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub btDesfazer_Click(sender As Object, e As EventArgs) Handles btDesfazer.Click
        Try
            btEditarNomeEvento.Visible = True
            btDesfazer.Visible = False
            Me.EventosBindingSource.CancelEdit()

        Catch EX As Exception
            MessageBox.Show("Erro: " + EX.Message)
        End Try
        Me.EventosTableAdapter.Fill(Me.DadosDataSet.Eventos)
        NomeTextBox.Enabled = False
        btApagarNomeEvento.Enabled = True
        EventosBindingNavigator.Enabled = True

    End Sub

    Private Sub atualizaTodosEventos()
        novoEvento.EventosTableAdapter7.Fill(novoEvento.DadosDataSet8.Eventos)
        novoEvento.EventosTableAdapter6.Fill(novoEvento.DadosDataSet7.Eventos)
        novoEvento.EventosTableAdapter5.Fill(novoEvento.DadosDataSet6.Eventos)
        novoEvento.EventosTableAdapter4.Fill(novoEvento.DadosDataSet5.Eventos)
        novoEvento.EventosTableAdapter3.Fill(novoEvento.DadosDataSet4.Eventos)
        novoEvento.EventosTableAdapter2.Fill(novoEvento.DadosDataSet3.Eventos)
        novoEvento.EventosTableAdapter1.Fill(novoEvento.DadosDataSet2.Eventos)
        novoEvento.EventosTableAdapter.Fill(novoEvento.DadosDataSet1.Eventos)
    End Sub

    Private Sub atualizaNomesEventos()

        Try
            If novoEvento.cbNomeEvento1.SelectedValue.ToString = Nothing Then
                'MsgBox("Valor Evento 1 em Branco")
                novoEvento.EventosTableAdapter.Fill(novoEvento.DadosDataSet1.Eventos)
            End If
            If novoEvento.cbNomeEvento2.SelectedValue.ToString = Nothing Then
                'MsgBox("Valor Evento 2 em Branco")
                novoEvento.EventosTableAdapter1.Fill(novoEvento.DadosDataSet2.Eventos)
            End If
            If novoEvento.cbNomeEvento3.SelectedValue.ToString = Nothing Then
                'MsgBox("Valor Evento 3 em Branco")
                novoEvento.EventosTableAdapter2.Fill(novoEvento.DadosDataSet3.Eventos)
            End If
            If novoEvento.cbNomeEvento4.SelectedValue.ToString = Nothing Then
                'MsgBox("Valor Evento 4 em Branco")
                novoEvento.EventosTableAdapter3.Fill(novoEvento.DadosDataSet4.Eventos)
            End If
            If novoEvento.cbNomeEvento5.SelectedValue.ToString = Nothing Then
                'MsgBox("Valor Evento 5 em Branco")
                novoEvento.EventosTableAdapter4.Fill(novoEvento.DadosDataSet5.Eventos)
            End If
            If novoEvento.cbNomeEvento6.SelectedValue.ToString = Nothing Then
                'MsgBox("Valor Evento 6 em Branco")
                novoEvento.EventosTableAdapter5.Fill(novoEvento.DadosDataSet6.Eventos)
            End If
            If novoEvento.cbNomeEvento7.SelectedValue.ToString = Nothing Then
                'MsgBox("Valor Evento 7 em Branco")
                novoEvento.EventosTableAdapter6.Fill(novoEvento.DadosDataSet7.Eventos)
            End If
            If novoEvento.cbNomeEvento8.SelectedValue.ToString = Nothing Then
                'MsgBox("Valor Evento 8 em Branco")
                novoEvento.EventosTableAdapter7.Fill(novoEvento.DadosDataSet8.Eventos)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        'atualizaNomesEventos()
        Me.Close()
    End Sub
End Class