Imports MySqlConnector

Public Class FormAddAgregado

    Private ligacao As New DBConnect()

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        Try

            Dim IDSocio As String = cmbIDSocio.Text.Split(" | ")(0)
            Dim nomeAgregado As String = txtNome.Text
            Dim nifAgregado As String = mtxtNIF.Text
            Dim contatoAgregado As String = mtxtContato.Text
            Dim dataNascimentoAgregado As String = mtxtDataNascimento.Text

            BDConnect.Open()

            Dim Command As New MySqlCommand("INSERT INTO agregado (IDSocio, Nome, NIF, Contato, DataNascimento) VALUES (" + IDSocio + ",'" + nomeAgregado + "','" + nifAgregado + "','" + contatoAgregado + "','" + dataNascimentoAgregado + "')", BDConnect)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MessageBox.Show("Agregado inserido com sucesso.")
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir o agregado: " & ex.Message)
        End Try
        ' Limpar campos de entrada após a inserção
        txtNome.Text = ""
        mtxtNIF.Text = ""
        mtxtContato.Text = ""
        mtxtDataNascimento.Text = ""
        cmbIDSocio.Text = ""
    End Sub

    Private Sub FormAddAgregado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        ligacao.PreenchercmbSocios(cmbIDSocio)

        mtxtNIF.Text = ""
        txtNome.Text = ""
        mtxtContato.Text = ""
        mtxtDataNascimento.Text = ""
    End Sub


End Class