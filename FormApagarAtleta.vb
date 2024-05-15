Imports MySqlConnector

Public Class FormApagarAtleta
    Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")
    Private ligacao As New DBConnect()
    Private Sub FormApagarAtleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ligacao.PreenchercmbAtleta(cmbAtleta)
    End Sub

    Private Sub cmbAtleta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAtleta.SelectedIndexChanged

        'Dim BDConnect As New MySqlConnection(connectionString)

    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click

        Dim IDSocio As String = cmbAtleta.Text.Split(" | ")(0)
        Dim modalidade As String = cmbAtleta.Text.Split(" | ")(4)

        Try
            BDConnect.Open()

            Dim Command As New MySqlCommand("DELETE FROM atleta WHERE IDSocio = '" + IDSocio + "' AND modalidade = '" + modalidade + "'", BDConnect)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()

            MessageBox.Show("Atleta com o ID: " + IDSocio + " foi deletado com sucesso!")
            cmbAtleta.Text = ""
        Catch ex As Exception
            MessageBox.Show("Erro ao deletar atleta: " + ex.Message)
        Finally
            BDConnect.Close()
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cmbAtleta.Text = ""
    End Sub
End Class
