Imports MySqlConnector

Public Class FormInserirAtleta

    Private ligacao As New DBConnect()

    Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

    Private Sub FormInserirAtleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rbAgregado.Enabled = False
        cmbIDAgregado.Enabled = False


        ligacao.PreenchercmbSocios(cmbIDSocio)
        ligacao.PreenchercmbModalidade(cmbModalidade)

    End Sub

    Private Sub cmbSocio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDSocio.SelectedIndexChanged
        If cmbIDSocio.SelectedIndex <> -1 Then
            rbAgregado.Enabled = True
        End If

        cmbIDAgregado.Items.Clear()

        ligacao.PreenchercmbAgregado(cmbIDAgregado, cmbIDSocio)



    End Sub

    Private Sub rbAgregado_CheckedChanged(sender As Object, e As EventArgs) Handles rbAgregado.CheckedChanged
        cmbIDAgregado.Enabled = rbAgregado.Checked
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Try
            Dim nomeAtleta As String = cmbIDSocio.Text.Split(" | ")(2)
            Dim IDSocio As String = cmbIDSocio.Text.Split(" | ")(0)
            Dim modalidade As String = cmbModalidade.Text.ToString()
            Dim valor As String = txtValor.Text

            Dim nomeAtletaAgregado As String = ""
            Dim IDAgregado As String = ""

            If rbAgregado.Checked Then
                nomeAtletaAgregado = cmbIDAgregado.Text.Split(" | ")(2)
                IDAgregado = cmbIDAgregado.Text.Split(" | ")(0)

                Dim Command1 As New MySqlCommand("INSERT INTO atleta (IDSocio, IDAgregado, nomeAtleta, modalidade, valor) VALUES ('" + IDSocio + "', '" + IDAgregado + "','" + nomeAtletaAgregado + "', '" + modalidade + "', " + valor + ")", BDConnect)

                BDConnect.Open()
                Dim reader1 As MySqlDataReader = Command1.ExecuteReader()
                MessageBox.Show("Atleta inserido com sucesso!")
                BDConnect.Close()
            Else

                Dim Command As New MySqlCommand("INSERT INTO atleta (IDSocio, nomeAtleta, modalidade, valor) VALUES ('" + IDSocio + "', '" + nomeAtleta + "', '" + modalidade + "', " + valor + ")", BDConnect)

                BDConnect.Open()
                Dim reader As MySqlDataReader = Command.ExecuteReader()
                MessageBox.Show("Atleta inserido com sucesso!")
                BDConnect.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir o atleta: " & ex.Message)
        Finally
            BDConnect.Close()
        End Try

        Limpar()

    End Sub

    Private Sub Limpar()

        cmbIDSocio.Text = ""
        cmbIDAgregado.Text = ""
        cmbModalidade.Text = ""
        txtValor.Text = ""
        rbAgregado.Checked = False


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Limpar()

    End Sub

    Private Sub cmbModalidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModalidade.SelectedIndexChanged


        Dim modalidade As String = cmbModalidade.Text.ToString()

        Try
            ' Abrir a conexão com o banco de dados
            BDConnect.Open()

            ' Carregar dados da tabela modalidade
            Dim Command As New MySqlCommand("SELECT valor FROM modalidade WHERE nomeModalidade  = '" + modalidade + "'", BDConnect)
            Dim reader As MySqlDataReader = Command.ExecuteReader()
            While reader.Read()

                txtValor.Text = reader("valor").ToString()

            End While

        Catch ex As Exception
            ' Exibir mensagem de erro em caso de exceção
            MsgBox("Erro: " & ex.ToString())
        Finally
            ' Fechar a conexão com o banco de dados
            BDConnect.Close()
        End Try
    End Sub
End Class