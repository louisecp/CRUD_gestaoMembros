
Imports MySqlConnector

Public Class FormInserirSocio

    Private Sub btnAddAgregado_Click(sender As Object, e As EventArgs) Handles btnAddAgregado.Click
        Dim f1 = New FormInserirAgregado
        f1.Show()
    End Sub

    Private Sub FormInserirSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAddAgregado.Enabled = False

    End Sub
    Private Sub Limpar()
        mtxtNIF.Text = ""
        txtNome.Text = ""
        mtxtContato.Text = ""
        txtMorada.Text = ""
        mtxtDataNascimento.Text = ""
        txtValor.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpar()
    End Sub

    Private Sub btnGravar_Click_1(sender As Object, e As EventArgs) Handles btnGravar.Click
        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        Try

            Dim nome As String = txtNome.Text
            Dim nif As String = mtxtNIF.Text
            Dim morada As String = txtMorada.Text
            Dim contato As String = mtxtContato.Text
            Dim dataNascimento As String = mtxtDataNascimento.Text
            Dim valor As Integer = txtValor.Text

            BDConnect.Open()

            Dim Command As New MySqlCommand("INSERT INTO socio (Nome, NIF, Morada, Contato, DataNascimento, Valor) VALUES ('" + nome + "','" + nif + "','" + morada + "','" + contato + "','" + dataNascimento + "', " + valor.ToString() + ")", BDConnect)

            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MessageBox.Show("Sócio inserido com sucesso!")
            btnAddAgregado.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir o sócio: " & ex.Message)
        Finally
            BDConnect.Close()
        End Try
    End Sub
End Class