Imports MySqlConnector

Public Class FormAnularFatura
    Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click


        Dim nFatura As String = cmbNFatura.Text
        Dim nome As String
        Dim descricao As String
        Dim mensalidade As String
        Dim valor As String
        Dim ID As String

        Try
            BDConnect.Open()

            Dim Command As New MySqlCommand("SELECT  IDSocio, Descricao, Mensalidade, Valor, nome FROM faturas WHERE nFatura = '" + nFatura + "'", BDConnect)

            Dim reader As MySqlDataReader = Command.ExecuteReader()

            If reader.Read() Then

                txtID.Enabled = True
                txtNome.Enabled = True
                txtDescricao.Enabled = True
                txtMensalidade.Enabled = True
                txtValor.Enabled = True
                btnApagar.Enabled = True

                ID = reader("IDSocio").ToString()
                nome = reader("nome").ToString()
                descricao = reader("descricao").ToString()
                mensalidade = reader("mensalidade").ToString()
                valor = reader("valor").ToString()

                txtID.Text = ID
                txtNome.Text = nome
                txtDescricao.Text = descricao
                txtMensalidade.Text = mensalidade
                txtValor.Text = valor

            Else
                MessageBox.Show("Fatura não encontrada!")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar fatura: " & ex.Message)
        Finally
            BDConnect.Close()
        End Try
    End Sub

    Private Sub FormAnularFatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionString As String = "Server=127.0.0.1;User ID=root;Port=3306;Database=associados"
        BDConnect = New MySqlConnection(connectionString)

        Try
            BDConnect.Open()
            Dim Command As New MySqlCommand("SELECT * FROM faturas", BDConnect)
            Dim reader As MySqlDataReader = Command.ExecuteReader()
            cmbNFatura.Items.Clear()
            While (reader.Read())

                cmbNFatura.Items.Add(reader.GetValue(0).ToString())

            End While
        Catch ex As Exception
            MsgBox("Erro: " & ex.ToString())
        Finally
            BDConnect.Close()
        End Try
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click

        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        Dim nFatura As String = cmbNFatura.Text

        Try
            BDConnect.Open()

            Dim Command As New MySqlCommand("DELETE FROM faturas WHERE nFatura = '" + nFatura + "'", BDConnect)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MessageBox.Show("Fatura com o número " + nFatura + " foi anulada com sucesso!")
            Limpar()
        Catch ex As Exception
            MessageBox.Show("Erro ao anular fatura: " + ex.Message)
        Finally
            BDConnect.Close()
        End Try


    End Sub

    Private Sub Limpar()
        cmbNFatura.Text = ""
        txtNome.Text = ""
        txtID.Text = ""
        txtDescricao.Text = ""
        txtMensalidade.Text = ""
        txtValor.Text = ""

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Limpar()
    End Sub
End Class