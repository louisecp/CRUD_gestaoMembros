Imports MySqlConnector

Public Class FormPagamentoQuota
    Private ligacao As New DBConnect()

    Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

    Private Sub FormEmitirFatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ligacao.PreenchercmbSocios(cmbIDSocio)
        ligacao.PreenchercmbMensalidade(cmbMensalidade)

    End Sub

    Private Sub cmbIDSocio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDSocio.SelectedIndexChanged

        Dim IDSocio As String = cmbIDSocio.Text.Split(" | ")(0)

        Try

            BDConnect.Open()


            Dim Command As New MySqlCommand("SELECT * FROM socio WHERE IDSocio = " + IDSocio, BDConnect)
            Dim reader As MySqlDataReader = Command.ExecuteReader()
            While reader.Read()
                txtValor.Text = reader.GetValue(6).ToString()

            End While

        Catch ex As Exception

            MsgBox("Erro: " & ex.ToString())
        Finally

            BDConnect.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        Try

            Dim IDSocio As String = cmbIDSocio.Text.Split(" | ")(0)
            Dim mensalidade As String = cmbMensalidade.Text
            Dim valor As String = txtValor.Text
            Dim descricao As String = "quota"
            Dim nome As String = cmbIDSocio.Text.Split(" | ")(2)

            BDConnect.Open()

            Dim Command As New MySqlCommand("INSERT INTO faturas (IDSocio, Valor, Descricao, Mensalidade, Nome) VALUES (" + IDSocio + "," + valor + ",'" + descricao + "','" + mensalidade + "', '" + nome + "')", BDConnect)

            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MessageBox.Show("Fatura emitida com sucesso!")

        Catch ex As Exception
            MessageBox.Show("Erro ao emitir fatura: " & ex.Message)
        Finally
            BDConnect.Close()
        End Try

        cmbIDSocio.Text = ""
        cmbMensalidade.Text = ""
        txtValor.Text = ""

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class