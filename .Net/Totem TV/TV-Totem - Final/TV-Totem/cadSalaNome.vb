Public Class cadSalaNome

    Private Sub cadSalaNome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SalasTableAdapter.Fill(Me.DadosDataSet.Salas)
        NomeTextBox.Enabled = False
    End Sub

    Private Sub btNovaSala_Click(sender As Object, e As EventArgs) Handles btNovaSala.Click

        btApagarSala.Enabled = False
        btEditarNomeSala.Visible = False
        btDesfazer.Visible = True
        Try
            NomeTextBox.Enabled = True
            NomeTextBox.Focus()
            Me.SalasBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub btApagarSala_Click(sender As Object, e As EventArgs) Handles btApagarSala.Click

        SalasBindingSource.RemoveCurrent()
        Me.Validate()
        Me.SalasBindingSource.EndEdit()
        Me.SalasTableAdapter.Update(Me.DadosDataSet.Salas)
        atualizaNomesSalas()

    End Sub

    Private Sub btSalvarNomeSala_Click(sender As Object, e As EventArgs) Handles btSalvarNomeSala.Click

        Dim TbSala As DataTable = Nothing
        TbSala = SalasTableAdapter.GetDataByNome(NomeTextBox.Text)

        If TbSala.Rows.Count <> 0 Then
            MessageBox.Show("Nome de Sala ja Cadastrado!! " & vbCrLf & "Digite outro Nome!!")
            NomeTextBox.Focus()
        Else
            Me.Validate()
            Me.SalasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DadosDataSet)
            Me.SalasTableAdapter.Fill(Me.DadosDataSet.Salas)
            btApagarSala.Enabled = True
        End If
        NomeTextBox.Enabled = False
        btEditarNomeSala.Visible = True
        atualizaNomesSalas()

    End Sub

    Private Sub btEditarNomeSala_Click(sender As Object, e As EventArgs) Handles btEditarNomeSala.Click
        Try
            btEditarNomeSala.Visible = False
            btDesfazer.Visible = True
            SalasBindingNavigator.Enabled = False
            NomeTextBox.Enabled = True

            Dim RegistroAtual As DataRowView = Me.SalasBindingSource.Current()

        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try

    End Sub

    Private Sub btDesfazer_Click(sender As Object, e As EventArgs) Handles btDesfazer.Click
        Try
            btEditarNomeSala.Visible = True
            btDesfazer.Visible = False
            Me.SalasBindingSource.CancelEdit()

        Catch EX As Exception
            MessageBox.Show("Erro: " + EX.Message)
        End Try
        Me.SalasTableAdapter.Fill(Me.DadosDataSet.Salas)
        NomeTextBox.Enabled = False
        btApagarSala.Enabled = True
        SalasBindingNavigator.Enabled = True

    End Sub

    Private Sub atualizaTodasSalas()
        novoEvento.SalasTableAdapter7.Fill(novoEvento.DadosDataSet8.Salas)
        novoEvento.SalasTableAdapter6.Fill(novoEvento.DadosDataSet7.Salas)
        novoEvento.SalasTableAdapter5.Fill(novoEvento.DadosDataSet6.Salas)
        novoEvento.SalasTableAdapter4.Fill(novoEvento.DadosDataSet5.Salas)
        novoEvento.SalasTableAdapter3.Fill(novoEvento.DadosDataSet4.Salas)
        novoEvento.SalasTableAdapter2.Fill(novoEvento.DadosDataSet3.Salas)
        novoEvento.SalasTableAdapter1.Fill(novoEvento.DadosDataSet2.Salas)
        novoEvento.SalasTableAdapter.Fill(novoEvento.DadosDataSet1.Salas)
    End Sub

    Private Sub atualizaNomesSalas()

        Try
            If novoEvento.cbNomeSala1.SelectedIndex = Nothing Then
                novoEvento.SalasTableAdapter.Fill(novoEvento.DadosDataSet1.Salas)
            End If
            If novoEvento.cbNomeSala2.SelectedIndex = Nothing Then
                novoEvento.SalasTableAdapter1.Fill(novoEvento.DadosDataSet2.Salas)
            End If
            If novoEvento.cbNomeSala3.SelectedIndex = Nothing Then
                novoEvento.SalasTableAdapter2.Fill(novoEvento.DadosDataSet3.Salas)
            End If
            If novoEvento.cbNomeSala4.SelectedIndex = Nothing Then
                novoEvento.SalasTableAdapter3.Fill(novoEvento.DadosDataSet4.Salas)
            End If
            If novoEvento.cbNomeSala5.SelectedIndex = Nothing Then
                novoEvento.SalasTableAdapter4.Fill(novoEvento.DadosDataSet5.Salas)
            End If
            If novoEvento.cbNomeSala6.SelectedIndex = Nothing Then
                novoEvento.SalasTableAdapter5.Fill(novoEvento.DadosDataSet6.Salas)
            End If
            If novoEvento.cbNomeSala7.SelectedIndex = Nothing Then
                novoEvento.SalasTableAdapter6.Fill(novoEvento.DadosDataSet7.Salas)
            End If
            If novoEvento.cbNomeSala8.SelectedIndex = Nothing Then
                novoEvento.SalasTableAdapter7.Fill(novoEvento.DadosDataSet8.Salas)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub SalasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DadosDataSet)

    End Sub
End Class