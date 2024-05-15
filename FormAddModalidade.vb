Imports MySqlConnector

Public Class FormAddModalidade
    Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")
    Private Sub FormAddArtigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        Try
            Dim nomeModalidade As String = txtNomeModalidade.Text
            Dim valor As String = txtValorModalidade.Text

            BDConnect.Open()

            Dim Command As New MySqlCommand("INSERT INTO modalidade(nomeModalidade, valor) VALUES ('" + nomeModalidade + "'," + valor + ")", BDConnect)

            Dim reader As MySqlDataReader = Command.ExecuteReader()

            MsgBox("Modalidade Inserida com sucesso.")

        Catch ex As Exception

            MessageBox.Show("Erro ao inserir modalidade: " & ex.Message)
        Finally
            BDConnect.Close()

        End Try

        txtNomeModalidade.Text = ""
        txtValorModalidade.Text = ""


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNomeModalidade.Text = ""
        txtValorModalidade.Text = ""

    End Sub
End Class