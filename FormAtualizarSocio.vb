Imports Microsoft.VisualBasic.Devices
Imports System.Windows.Forms.MonthCalendar
Imports MySqlConnector
Imports Org.BouncyCastle.Ocsp

Public Class FormAtualizarSocio

    Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")


    Private ligacao As New DBConnect()

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click

        Dim nome As String
        Dim nif As String
        Dim contato As String
        Dim morada As String
        Dim dataNascimento As String
        Dim valor As String
        Dim IDSocio As String = cmbIDSocio.Text.Split(" | ")(0)

        Try

            BDConnect.Open()

            Dim Command As New MySqlCommand("SELECT Nome, NIF, Contato, Morada, DataNascimento, valor FROM socio WHERE IDSocio = '" + IDSocio + "'", BDConnect)

            Dim reader As MySqlDataReader = Command.ExecuteReader()

            If reader.Read() Then

                mtxtNIFSocio.Enabled = True
                txtNomeSocio.Enabled = True
                mtxtContatoSocio.Enabled = True
                txtMoradaSocio.Enabled = True
                mtxtDataNascimentoSocio.Enabled = True
                txtValor.Enabled = True
                btnGravar.Enabled = True

                nome = reader("nome").ToString()
                nif = reader("nif").ToString()
                contato = reader("contato").ToString()
                morada = reader("morada").ToString()
                dataNascimento = reader("dataNascimento").ToString()
                valor = reader("valor").ToString()

                txtNomeSocio.Text = nome
                mtxtNIFSocio.Text = nif
                mtxtContatoSocio.Text = contato
                txtMoradaSocio.Text = morada
                mtxtDataNascimentoSocio.Text = dataNascimento
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



    Private Sub FormAtualizarSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Desabilitar todos os controles
        DesabilitarControles()

        Try
            ' Abrir a conexão com o banco de dados
            BDConnect.Open()

            ' Carregar dados da tabela socio
            Dim CommandSocio As New MySqlCommand("SELECT * FROM socio", BDConnect)
            Dim readerSocio As MySqlDataReader = CommandSocio.ExecuteReader()
            While readerSocio.Read()
                cmbIDSocio.Items.Add(readerSocio.GetValue(0).ToString() & " | " & readerSocio.GetValue(1).ToString())


            End While


        Catch ex As Exception
            ' Exibir mensagem de erro em caso de exceção
            MsgBox("Erro: " & ex.ToString())
        Finally
            ' Fechar a conexão com o banco de dados
            BDConnect.Close()
        End Try

        ' Limpar todos os campos de texto
        Limpar()
    End Sub

    Private Sub DesabilitarControles()

        mtxtNIFSocio.Enabled = False
        txtNomeSocio.Enabled = False
        mtxtContatoSocio.Enabled = False
        txtMoradaSocio.Enabled = False
        mtxtDataNascimentoSocio.Enabled = False
        txtValor.Enabled = False
        cmbIDAgregado.Enabled = False
        txtNomeAgregado.Enabled = False
        mtxtNIFAgregado.Enabled = False
        mtxtContatoAgregado.Enabled = False
        mtxtDataNascimentoAgregado.Enabled = False
        btnGravar.Enabled = False
        btnGravarAgregado.Enabled = False

    End Sub

    Private Sub Limpar()
        ' Limpar todos os campos de texto
        cmbIDSocio.Text = ""
        mtxtNIFSocio.Text = ""
        txtNomeSocio.Text = ""
        mtxtContatoSocio.Text = ""
        txtMoradaSocio.Text = ""
        mtxtDataNascimentoSocio.Text = ""
        txtValor.Text = ""
        cmbIDAgregado.Text = ""
        mtxtNIFAgregado.Text = ""
        txtNomeAgregado.Text = ""
        mtxtContatoAgregado.Text = ""
        mtxtDataNascimentoAgregado.Text = ""
    End Sub


    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        Dim nome As String = txtNomeSocio.Text
        Dim nif As String = mtxtNIFSocio.Text
        Dim contato As String = mtxtContatoSocio.Text
        Dim morada As String = txtMoradaSocio.Text
        Dim dataNascimento As String = mtxtDataNascimentoSocio.Text
        Dim valor As String = txtValor.Text
        Dim ID As String = cmbIDSocio.Text.Split(" | ")(0)


        Try
            BDConnect.Open()

            Dim Command As New MySqlCommand("UPDATE socio SET Nome = '" + nome + "', NIF = '" + nif + "', Morada = '" + morada + "', Contato = '" + contato + "', DataNascimento = '" + dataNascimento + "', Valor = " + valor + " WHERE IDSocio = '" + ID + "'", BDConnect)

            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MessageBox.Show("Dados atualizados com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar dados." & ex.Message)
        Finally
            BDConnect.Close()
        End Try

        Limpar()
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpar()
        mtxtNIFSocio.Enabled = False
        txtNomeSocio.Enabled = False
        mtxtContatoSocio.Enabled = False
        txtMoradaSocio.Enabled = False
        mtxtDataNascimentoSocio.Enabled = False
        txtValor.Enabled = False
        mtxtNIFAgregado.Enabled = False
        txtNomeAgregado.Enabled = False
        mtxtContatoAgregado.Enabled = False
        mtxtDataNascimentoAgregado.Enabled = False
        btnGravar.Enabled = False
    End Sub

    Private Sub cmbIDSocio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDSocio.SelectedIndexChanged

        cmbIDAgregado.Enabled = True

        cmbIDAgregado.Items.Clear()

        Dim IDSocio As String = cmbIDSocio.Text.Split(" | ")(0)

        Try
            ' Abrir a conexão com o banco de dados
            BDConnect.Open()

            ' Carregar dados da tabela socio
            Dim CommandAgregado As New MySqlCommand("SELECT * FROM agregado WHERE IDSocio = " + IDSocio, BDConnect)
            Dim readerAgregado As MySqlDataReader = CommandAgregado.ExecuteReader()
            While readerAgregado.Read()
                cmbIDAgregado.Items.Add(readerAgregado.GetValue(0).ToString() + " | " + readerAgregado.GetValue(1).ToString())

            End While

        Catch ex As Exception
            ' Exibir mensagem de erro em caso de exceção
            MsgBox("Erro: " & ex.ToString())
        Finally
            ' Fechar a conexão com o banco de dados
            BDConnect.Close()
        End Try

        Limpar()
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
                btnGravarAgregado.Enabled = True

                nomeAgregado = reader("nome").ToString()
                nifAgregado = reader("nif").ToString()
                contatoAgregado = reader("contato").ToString()
                dataNascimentoAgregado = reader("dataNascimento").ToString()

                txtNomeAgregado.Text = nomeAgregado
                mtxtNIFAgregado.Text = nifAgregado
                mtxtContatoAgregado.Text = contatoAgregado
                mtxtDataNascimentoAgregado.Text = dataNascimentoAgregado
            Else
                MessageBox.Show("Agregado não encontrado!")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar o agregado: " & ex.Message)
        Finally
            BDConnect.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGravarAgregado.Click

        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        Dim nomeAgregado As String = txtNomeAgregado.Text
        Dim nifAgregado As String = mtxtNIFAgregado.Text
        Dim contatoAgregado As String = mtxtContatoAgregado.Text
        Dim dataNascimentoAgregado As String = mtxtDataNascimentoAgregado.Text
        Dim IDAgregado As String = cmbIDAgregado.Text.Split(" | ")(0)
        Try
            BDConnect.Open()

            Dim Command As New MySqlCommand("UPDATE agregado SET Nome = '" + nomeAgregado + "', NIF = '" + nifAgregado + "', Contato = '" + contatoAgregado + "', DataNascimento = '" + dataNascimentoAgregado + "' WHERE IDAgregado = '" + IDAgregado + "'", BDConnect)

            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MessageBox.Show("Dados atualizados com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar dados." & ex.Message)
        Finally
            BDConnect.Close()
        End Try

        Limpar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpar()
        mtxtNIFAgregado.Enabled = False
        txtNomeAgregado.Enabled = False
        mtxtContatoAgregado.Enabled = False
        mtxtDataNascimentoAgregado.Enabled = False
        btnGravarAgregado.Enabled = False
    End Sub
End Class