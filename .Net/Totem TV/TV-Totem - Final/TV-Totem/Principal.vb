Public Class Principal

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btNovoEvento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovoEvento.Click
        novoEvento.Show()
    End Sub

    Private Sub btCadastroNome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCadastroNome.Click
        cadEventoNome.Show()
    End Sub

    Private Sub btCadastroSala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCadastroSala.Click
        cadSalaNome.Show()
    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

End Class