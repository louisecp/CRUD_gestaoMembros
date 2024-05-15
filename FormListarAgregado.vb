Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySqlConnector

Public Class FormListarAgregado

    Private ligacao As New DBConnect()

    Private Sub FormListarAgregado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")
            BDConnect.Open()
            Dim Command As New MySqlCommand("SELECT * FROM agregado", BDConnect)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells 'Tamanho automaticamente ajustado
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells 'Linhas e colunas ajustaveis
            DataGridView1.AllowUserToAddRows = False 'não permite o utilizador add linhas
            DataGridView1.AllowUserToDeleteRows = False 'não permite o utilizador deletar linhas
            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically 'o dataGridView só pode ser alterado a partir da programação
            DataGridView1.Columns.Add("ID SÓCIO", "ID SÓCIO") 'cabeçalho Do dataGridView
            DataGridView1.Columns.Add("ID Agregado", "ID Agregado")
            DataGridView1.Columns.Add("Nome", "Nome")
            DataGridView1.Columns.Add("NIF", "NIF")
            DataGridView1.Columns.Add("Contato", "Contato")
            DataGridView1.Columns.Add("DataNascimento", "DataNascimento")

            ligacao.PreencherDataGridViewAgregado(DataGridView1, "", "", "", "", "", "")

            ligacao.PreenchercmbAgregado2(cmbIDAgregado)

            lblRegistos.Text = "Total: " + DataGridView1.RowCount.ToString()


        Catch ex As Exception
            MsgBox("Erro" + ex.ToString)


        End Try
    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click

        Dim id As String = ""

        DataGridView1.Rows.Clear()

        If cmbIDAgregado.SelectedIndex <> -1 Then

            id = cmbIDAgregado.Text.Substring(cmbIDAgregado.Text.LastIndexOf(0) + 1)

        End If

        txtNome.Text = Geral.TirarEspacos(txtNome.Text)

        ligacao.PreencherDataGridViewAgregado(DataGridView1, "", id, txtNome.Text, "", "", "")

        lblRegistos.Text = "Nº Registos: " + DataGridView1.RowCount.ToString()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        DataGridView1.Rows.Clear()

        txtNome.Text = ""

        ligacao.PreencherDataGridViewAgregado(DataGridView1, "", "", "", "", "", "")

        lblRegistos.Text = "Registos: " + DataGridView1.RowCount.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.Rows.Count > 0 Then
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "PDF (*.pdf)|*.pdf"
            sfd.FileName = "Agregados.pdf"
            Dim fileError As Boolean = False
            If sfd.ShowDialog() = DialogResult.OK Then
                If File.Exists(sfd.FileName) Then
                    Try
                        File.Delete(sfd.FileName)
                    Catch ex As IOException
                        fileError = True
                        MessageBox.Show("Impossível de apagar o ficheiro!")
                    End Try
                End If
                If Not fileError Then
                    Try
                        Dim pdfPTable As New PdfPTable(DataGridView1.Columns.Count)
                        pdfPTable.DefaultCell.Padding = 3
                        pdfPTable.WidthPercentage = 100
                        pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT

                        For Each column As DataGridViewColumn In DataGridView1.Columns
                            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                            pdfPTable.AddCell(cell)
                        Next

                        For Each row As DataGridViewRow In DataGridView1.Rows
                            For Each cell As DataGridViewCell In row.Cells
                                pdfPTable.AddCell(cell.Value.ToString())
                            Next
                        Next

                        Using stream As New FileStream(sfd.FileName, FileMode.Create)
                            Dim pdfDoc As New Document(PageSize.A4, 10.0F, 20.0F, 20.0F, 10.0F)
                            PdfWriter.GetInstance(pdfDoc, stream)
                            pdfDoc.Open()
                            pdfDoc.Add(pdfPTable)
                            pdfDoc.Close()
                        End Using

                        MessageBox.Show("Imprimiu com sucesso!")
                    Catch ex As Exception
                        MessageBox.Show("ERROR: " & ex.Message)
                    End Try
                End If
            End If
        Else
            MessageBox.Show("Não existe registos!")
        End If
    End Sub
End Class