Imports MySqlConnector

Public Class FormAddMensalidade

    Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")
    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Try
            Dim mes As String = txtMes.Text
            Dim ano As String = mtxtAno.Text

            BDConnect.Open()

            Dim Command As New MySqlCommand("INSERT INTO mensalidade(mes, ano) VALUES ('" + mes + "'," + ano + ")", BDConnect)

            Dim reader As MySqlDataReader = Command.ExecuteReader()

            MsgBox("Quota Inserida com sucesso.")

        Catch ex As Exception

            MessageBox.Show("Erro ao inserir a quota: " & ex.Message)
        Finally
            BDConnect.Close()
        End Try

        txtMes.Text = ""
        mtxtAno.Text = ""

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtMes.Text = ""
        mtxtAno.Text = ""
    End Sub
End Class