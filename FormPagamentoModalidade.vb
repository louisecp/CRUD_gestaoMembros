Imports MySqlConnector

Public Class FormPagamentoModalidade
    Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")
    Private ligacao As New DBConnect()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim mensalidade As String = cmbMensalidade.Text
            Dim valor As String = txtValor.Text
            Dim descricao As String = "modalidade"
            Dim nome As String = cmbIDSocio.Text.Split(" | ")(2)
            Dim IDSocio As String = cmbIDSocio.Text.Split(" | ")(0)


            If (rbAgregado.Checked) Then

                Dim IDAgregado As String = cmbIDAgregado.Text.Split(" | ")(0)
                Dim nomeAgregado As String = cmbIDAgregado.Text.Split(" | ")(2)

                BDConnect.Open()

                Dim Command1 As New MySqlCommand("INSERT INTO faturas (IDSocio, Valor, Descricao, Mensalidade, IDAgregado, Nome) VALUES (" & IDSocio & ", " & valor & ", '" & descricao & "', '" & mensalidade & "', " & IDAgregado & ", '" & nomeAgregado & "')", BDConnect)
                Dim reader As MySqlDataReader
                reader = Command1.ExecuteReader()
                MessageBox.Show("Fatura emitida com sucesso!")
                BDConnect.Close()
            Else
                BDConnect.Open()
                Dim Command2 As New MySqlCommand("INSERT INTO faturas (IDSocio, Valor, Descricao, Mensalidade, Nome) VALUES (" & IDSocio & ", " & valor & ", '" & descricao & "', '" & mensalidade & "', '" & nome & "')", BDConnect)
                Dim reader2 As MySqlDataReader
                reader2 = Command2.ExecuteReader()
                MessageBox.Show("Fatura emitida com sucesso!")
                BDConnect.Close()
            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao emitir fatura: " + ex.Message)
        Finally
            BDConnect.Close()
        End Try

        cmbIDSocio.Text = ""
        rbAgregado.Checked = False
        cmbIDAgregado.Text = ""
        cmbModalidade.Text = ""
        cmbMensalidade.Text = ""
        txtValor.Text = ""

    End Sub

    Private Sub FormPagamentoModalidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rbAgregado.Enabled = False
        cmbIDAgregado.Enabled = False
        ligacao.PreenchercmbSocios(cmbIDSocio)
        ligacao.PreenchercmbModalidade(cmbModalidade)
        ligacao.PreenchercmbMensalidade(cmbMensalidade)



    End Sub

    Private Sub cmbIDSocio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDSocio.SelectedIndexChanged

        rbAgregado.Enabled = True

        ligacao.PreenchercmbAgregado(cmbIDAgregado, cmbIDSocio)

    End Sub


    Private Sub cmbMensalidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMensalidade.SelectedIndexChanged

        Dim IDSocio As String = cmbIDSocio.Text.Split(" | ")(0)

        Try
            BDConnect.Open()

            Dim Command As New MySqlCommand("SELECT valor FROM atleta WHERE IDSocio  = '" + IDSocio + "'", BDConnect)

            Dim reader As MySqlDataReader = Command.ExecuteReader()

            While reader.Read()

                txtValor.Text = reader("valor").ToString()

            End While

        Catch ex As Exception

            MsgBox("Erro: " & ex.ToString())
        Finally

            BDConnect.Close()
        End Try
    End Sub

    Private Sub cmbIDAgregado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDAgregado.SelectedIndexChanged

        ligacao.PreenchercmbModalidade(cmbModalidade)
    End Sub

    Private Sub rbAgregado_CheckedChanged(sender As Object, e As EventArgs) Handles rbAgregado.CheckedChanged
        cmbIDAgregado.Enabled = True
    End Sub
End Class


