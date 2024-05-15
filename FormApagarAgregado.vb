Imports MySqlConnector

Public Class FormApagarAgregado

    Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click

        Dim nome As String
        Dim nif As String
        Dim contato As String
        Dim dataNascimento As String
        Dim ID As String = cmbIDSocio.Text.Split(" | ")(0)

        Try
            BDConnect.Open()

            Dim Command As New MySqlCommand("SELECT Nome, NIF, Contato, DataNascimento FROM agregado WHERE IDSocio = '" + ID + "'", BDConnect)

            Dim reader As MySqlDataReader = Command.ExecuteReader()

            If reader.Read() Then

                mtxtNIF.Enabled = True
                txtNome.Enabled = True
                mtxtContato.Enabled = True
                mtxtDataNascimento.Enabled = True
                btnDeletar.Enabled = True

                nome = reader("nome").ToString()
                nif = reader("nif").ToString()
                contato = reader("contato").ToString()
                dataNascimento = reader("dataNascimento").ToString()

                txtNome.Text = nome
                mtxtNIF.Text = nif
                mtxtContato.Text = contato
                mtxtDataNascimento.Text = dataNascimento
            Else
                MessageBox.Show("Sócio não encontrado!")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar o sócio: " & ex.Message)
        Finally
            BDConnect.Close()
        End Try
    End Sub

    Private Sub FormApagarAgregado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtxtNIF.Enabled = False
        txtNome.Enabled = False
        mtxtContato.Enabled = False
        mtxtDataNascimento.Enabled = False
        btnDeletar.Enabled = False

        Try
            BDConnect.Open()
            Dim Command As New MySqlCommand("SELECT * FROM socio", BDConnect)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            cmbIDSocio.Items.Clear()
            While (reader.Read)
                cmbIDSocio.Items.Add(reader.GetValue(0).ToString + " | " + reader.GetValue(1).ToString)
            End While
        Catch ex As Exception
            MsgBox("Erro" + ex.ToString)

        End Try
        mtxtNIF.Text = ""
        txtNome.Text = ""
        mtxtContato.Text = ""
        mtxtDataNascimento.Text = ""
    End Sub

    Private Sub Limpar()
        cmbIDSocio.SelectedIndex = -1
        mtxtNIF.Text = ""
        txtNome.Text = ""
        mtxtContato.Text = ""
        mtxtDataNascimento.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpar()
        mtxtNIF.Enabled = False
        txtNome.Enabled = False
        mtxtContato.Enabled = False
        mtxtDataNascimento.Enabled = False
        btnDeletar.Enabled = False
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click

        Dim nome As String = txtNome.Text
        Dim nif As String = mtxtNIF.Text
        Dim contato As String = mtxtContato.Text
        Dim dataNascimento As String = mtxtDataNascimento.Text
        Dim ID As String = cmbIDSocio.Text.Split(" | ")(0)

        Try
            BDConnect.Open()

            Dim Command As New MySqlCommand("DELETE FROM agregado WHERE IDSocio = '" + ID + "'", BDConnect)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MessageBox.Show("Agregado com ID " + ID + " deletado com sucesso!")
            Limpar()
        Catch ex As Exception
            MessageBox.Show("Erro ao deletar agregado: " + ex.Message)
        Finally
            BDConnect.Close()
        End Try

    End Sub
End Class