Imports Microsoft.VisualBasic.Devices
Imports MySqlConnector

Public Class FormApagarSocio

    Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

    Private ligacao As New DBConnect()
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim nome As String
        Dim nif As String
        Dim contato As String
        Dim morada As String
        Dim dataNascimento As String
        Dim valor As String
        Dim ID As String = cmbIDSocio.Text.Split(" | ")(0)

        Try
            BDConnect.Open()

            Dim Command As New MySqlCommand("SELECT Nome, NIF, Contato, Morada, DataNascimento, valor FROM socio WHERE IDSocio = '" + ID + "'", BDConnect)

            Dim reader As MySqlDataReader = Command.ExecuteReader()

            If reader.Read() Then

                mtxtNIF.Enabled = True
                txtNome.Enabled = True
                mtxtContato.Enabled = True
                txtMorada.Enabled = True
                mtxtDataNascimento.Enabled = True
                txtValor.Enabled = True
                btnApagar.Enabled = True

                nome = reader("nome").ToString()
                nif = reader("nif").ToString()
                contato = reader("contato").ToString()
                morada = reader("morada").ToString()
                dataNascimento = reader("dataNascimento").ToString()
                valor = reader("valor").ToString()

                txtNome.Text = nome
                mtxtNIF.Text = nif
                mtxtContato.Text = contato
                txtMorada.Text = morada
                mtxtDataNascimento.Text = dataNascimento
                txtValor.Text = valor
            Else
                MessageBox.Show("Sócio não encontrado!")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar o sócio: " & ex.Message)
        Finally
            BDConnect.Close()
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpar()
        mtxtNIF.Enabled = False
        txtNome.Enabled = False
        mtxtContato.Enabled = False
        txtMorada.Enabled = False
        mtxtDataNascimento.Enabled = False
        txtValor.Enabled = False
        btnApagar.Enabled = False
    End Sub
    Private Sub Limpar()
        cmbIDSocio.SelectedIndex = -1
        mtxtNIF.Text = ""
        txtNome.Text = ""
        mtxtContato.Text = ""
        txtMorada.Text = ""
        mtxtDataNascimento.Text = ""
        txtValor.Text = ""
    End Sub
    Private Sub DesabilitarControles()
        mtxtNIF.Enabled = False
        txtNome.Enabled = False
        mtxtContato.Enabled = False
        txtMorada.Enabled = False
        mtxtDataNascimento.Enabled = False
        txtValor.Enabled = False
        btnApagar.Enabled = False
    End Sub

    Private Sub FormApagarSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DesabilitarControles()

        ligacao.PreenchercmbSocios(cmbIDSocio)

    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click

        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        Try

            Dim ID As String = cmbIDSocio.Text.Split(" | ")(0)

            BDConnect.Open()

            Dim deleteAgregadoCommand As New MySqlCommand("DELETE FROM agregado WHERE IDSocio = '" + ID + "'", BDConnect)
            deleteAgregadoCommand.ExecuteNonQuery()

            ' Deletar o sócio
            Dim deleteSocioCommand As New MySqlCommand("DELETE FROM socio WHERE IDSocio = '" + ID + "'", BDConnect)
            deleteSocioCommand.ExecuteNonQuery()

            MessageBox.Show("Sócio e associados deletados com sucesso.")

        Catch ex As Exception
            MessageBox.Show("Erro ao deletar sócio: " & ex.Message)
        Finally
            ' Fechar a conexão com o banco de dados
            BDConnect.Close()
        End Try

        Limpar()
    End Sub


    Private Sub cmbIDSocio_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbIDSocio.SelectedIndexChanged

        ligacao.PreenchercmbAgregado(cmbIDAgregado, cmbIDSocio)

    End Sub

    Private Sub btnPesquisarAgregado_Click(sender As Object, e As EventArgs) Handles btnPesquisarAgregado.Click
        Dim nomeAgregado As String
        Dim nifAgregado As String
        Dim contatoAgregado As String
        Dim dataNascimentoAgregado As String
        Dim IDAgregado As String = cmbIDAgregado.Text.Split(" | ")(0)

        Try
            BDConnect.Open()

            Dim Command As New MySqlCommand("SELECT Nome, NIF, Contato, DataNascimento FROM agregado WHERE IDAgregado = '" + IDAgregado + "'", BDConnect)

            Dim reader As MySqlDataReader = Command.ExecuteReader()

            If reader.Read() Then

                mtxtNIFAgregado.Enabled = True
                txtNomeAgregado.Enabled = True
                mtxtContatoAgregado.Enabled = True
                mtxtDataNascimentoAgregado.Enabled = True
                btnApagar.Enabled = True

                nomeAgregado = reader("nome").ToString()
                nifAgregado = reader("nif").ToString()
                contatoAgregado = reader("contato").ToString()
                dataNascimentoAgregado = reader("dataNascimento").ToString()

                txtNomeAgregado.Text = nomeAgregado
                mtxtNIFAgregado.Text = nifAgregado
                mtxtContatoAgregado.Text = contatoAgregado
                mtxtDataNascimentoAgregado.Text = dataNascimentoAgregado
            Else
                MessageBox.Show("Sócio não encontrado!")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar o sócio: " & ex.Message)
        Finally
            BDConnect.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        Try
            Dim ID As String = cmbIDAgregado.Text.Split(" | ")(0)

            BDConnect.Open()

            Dim deleteAgregadoCommand As New MySqlCommand("DELETE FROM agregado WHERE IDAgregado = '" + ID + "'", BDConnect)
            deleteAgregadoCommand.ExecuteNonQuery()

            MessageBox.Show("Agregado deletado com sucesso.")

        Catch ex As Exception
            MessageBox.Show("Erro ao deletar agregado: " & ex.Message)
        Finally

            BDConnect.Close()
        End Try

        cmbIDAgregado.SelectedIndex = -1
        mtxtNIFAgregado.Text = ""
        txtNomeAgregado.Text = ""
        mtxtContatoAgregado.Text = ""
        mtxtDataNascimentoAgregado.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmbIDAgregado.SelectedIndex = -1
        mtxtNIFAgregado.Text = ""
        txtNomeAgregado.Text = ""
        mtxtContatoAgregado.Text = ""
        mtxtDataNascimentoAgregado.Text = ""
    End Sub
End Class