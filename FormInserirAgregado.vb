Imports MySqlConnector

Public Class FormInserirAgregado


    Private Sub FormInserirAgregado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        txtNome.Enabled = False
        mtxtNIF.Enabled = False
        mtxtContato.Enabled = False
        mtxtDataNascimento.Enabled = False
        txtMorada.Enabled = False

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
        Limpar()

    End Sub

    Private Sub Limpar()
        mtxtNIF.Text = ""
        txtNome.Text = ""
        mtxtContato.Text = ""
        mtxtDataNascimento.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        Try

            Dim ID_Socio As String
            Dim nomeAgregado As String
            Dim nifAgregado As String
            Dim contatoAgregado As String
            Dim dataNascimentoAgregado As String


            ID_Socio = cmbIDSocio.Text.Split(" | ")(0)
            nomeAgregado = txtNome.Text
            nifAgregado = mtxtNIF.Text
            contatoAgregado = mtxtContato.Text
            dataNascimentoAgregado = mtxtDataNascimento.Text


            BDConnect.Open()

            Dim Command As New MySqlCommand("INSERT INTO agregado (IDSocio, Nome, NIF, contato, DataNascimento) VALUES (" + ID_Socio + ",'" + nomeAgregado + "'," + nifAgregado + ",'" + contatoAgregado + "','" + dataNascimentoAgregado + "')", BDConnect)

            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MsgBox("Agregado inserido.")

        Catch ex As Exception
            MessageBox.Show("Erro ao inserir o agregado: " & ex.Message)
        End Try

        Limpar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpar()

    End Sub

    Private Sub cmbIDSocio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDSocio.SelectedIndexChanged
        txtNome.Enabled = True
        mtxtNIF.Enabled = True
        mtxtContato.Enabled = True
        mtxtDataNascimento.Enabled = True
        txtMorada.ReadOnly = True

        Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")

        Dim ID As String = cmbIDSocio.Text.Split(" | ")(0)

        Try
            BDConnect.Open()
            Dim Command As New MySqlCommand("SELECT Morada FROM socio WHERE IDSocio = '" + ID + "'", BDConnect)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            txtMorada.Text = ""
            If reader.Read() Then ' Verifica se há um resultado antes de tentar ler
                txtMorada.Text = reader.GetString("Morada") ' Lê o valor da coluna "Morada"
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        Finally
            BDConnect.Close()
        End Try


    End Sub
End Class