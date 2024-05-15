Imports MySqlConnector
Imports System.Windows.Forms

Public Class DBConnect
    Private BDConnect As MySqlConnection

    Public Sub PreencherDataGridViewSocios(ByRef dgv As DataGridView, ByVal IDSocio As String, ByVal Nome As String, ByVal Morada As String, ByVal NIF As String, ByVal Contato As String, ByVal DataNascimento As String, ByVal Valor As String)
        Dim query As String = "SELECT IDSocio, Nome, Morada, NIF, Contato, DataNascimento, Valor FROM socio "

        Dim flag As Boolean = False

        ' Verifica se o parâmetro 'modalidade' tem algum valor e se algum filtro já foi aplicado
        If IDSocio.Length > 0 AndAlso flag = True Then
            ' Se sim, adiciona cláusula AND para filtrar por nome
            query += " AND IDSocio = '" + IDSocio + "'"
        ElseIf IDSocio.Length > 0 Then
            ' Se não, adiciona cláusula WHERE para filtrar por nome
            query += " WHERE IDSocio = '" + IDSocio + "'"
            flag = True
        End If

        ' Verifica se o parâmetro 'nome' tem algum valor e se algum filtro já foi aplicado
        If Nome.Length > 0 AndAlso flag = True Then
            ' Se sim, adiciona cláusula AND para filtrar por nome
            query += " AND Nome LIKE '%" & Nome & "%'"
        ElseIf Nome.Length > 0 Then
            ' Se não, adiciona cláusula WHERE para filtrar por nome
            query += " WHERE Nome LIKE '%" & Nome & "%'"
            flag = True
        End If

        ' Adiciona a cláusula ORDER BY para ordenar os resultados por nome
        query &= " ORDER BY nome;"


        Try
            If (OpenConnection()) Then
                Dim cmd As New MySqlCommand(query, BDConnect)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim idxLinha As Integer = 0

                While dr.Read()
                    dgv.Rows.Add()
                    dgv.Rows(idxLinha).Cells(0).Value = dr("IDSocio").ToString()
                    dgv.Rows(idxLinha).Cells(1).Value = dr("Nome").ToString()
                    dgv.Rows(idxLinha).Cells(2).Value = dr("Morada").ToString()
                    dgv.Rows(idxLinha).Cells(3).Value = dr("NIF").ToString()
                    dgv.Rows(idxLinha).Cells(4).Value = dr("Contato").ToString()
                    dgv.Rows(idxLinha).Cells(5).Value = dr("DataNascimento").ToString()
                    dgv.Rows(idxLinha).Cells(6).Value = dr("Valor").ToString()
                    idxLinha += 1
                End While
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub PreencherDataGridViewAgregado(ByRef dgv As DataGridView, ByVal IDSocio As String, ByVal IDAgregado As String, ByVal Nome As String, ByVal NIF As String, ByVal Contato As String, ByVal DataNascimento As String)

        Dim query As String = "SELECT IDSocio, IDAgregado, Nome, NIF, Contato, DataNascimento FROM agregado "

        Dim flag As Boolean = False


        If IDAgregado.Length > 0 AndAlso flag = True Then

            query += " AND IDAgregado = '" + IDAgregado + "'"

        ElseIf IDAgregado.Length > 0 Then

            query += " WHERE IDAgregado = '" + IDAgregado + "'"

            flag = True
        End If


        If Nome.Length > 0 AndAlso flag = True Then

            query += " AND Nome LIKE '%" & Nome & "%'"
        ElseIf Nome.Length > 0 Then

            query += " WHERE Nome LIKE '%" & Nome & "%'"
            flag = True
        End If


        query &= " ORDER BY nome;"


        Try
            If (OpenConnection()) Then
                Dim cmd As New MySqlCommand(query, BDConnect)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim idxLinha As Integer = 0

                While dr.Read()
                    dgv.Rows.Add()
                    dgv.Rows(idxLinha).Cells(0).Value = dr("IDSocio").ToString()
                    dgv.Rows(idxLinha).Cells(1).Value = dr("IDAgregado").ToString()
                    dgv.Rows(idxLinha).Cells(2).Value = dr("Nome").ToString()
                    dgv.Rows(idxLinha).Cells(3).Value = dr("NIF").ToString()
                    dgv.Rows(idxLinha).Cells(4).Value = dr("Contato").ToString()
                    dgv.Rows(idxLinha).Cells(5).Value = dr("DataNascimento").ToString()
                    idxLinha += 1
                End While
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub PreencherDataGridViewAtleta(ByRef dgv As DataGridView, ByVal IDSocio As String, ByVal IDAgregado As String, ByVal Nome As String, ByVal Modalidade As String, ByVal Valor As String)

        Dim query As String = "SELECT IDSocio, IDAgregado, nomeAtleta, modalidade, valor FROM atleta "

        Dim flag As Boolean = False

        ' Verifica se o parâmetro 'modalidade' tem algum valor e se algum filtro já foi aplicado
        If Modalidade.Length > 0 AndAlso flag = True Then
            ' Se sim, adiciona cláusula AND para filtrar por nome
            query += " AND modalidade = '" + Modalidade + "'"
        ElseIf Modalidade.Length > 0 Then
            ' Se não, adiciona cláusula WHERE para filtrar por nome
            query += " WHERE modalidade = '" + Modalidade + "'"
            flag = True
        End If

        ' Verifica se o parâmetro 'nome' tem algum valor e se algum filtro já foi aplicado
        If Nome.Length > 0 AndAlso flag = True Then
            ' Se sim, adiciona cláusula AND para filtrar por nome
            query += " AND nomeAtleta LIKE '%" + Nome + "%'"
        ElseIf Nome.Length > 0 Then
            ' Se não, adiciona cláusula WHERE para filtrar por nome
            query += " WHERE nomeAtleta LIKE '%" + Nome + "%'"
            flag = True
        End If

        ' Adiciona a cláusula ORDER BY para ordenar os resultados por nome
        query += " ORDER BY nomeAtleta;"


        Try
            If (OpenConnection()) Then
                Dim cmd As New MySqlCommand(query, BDConnect)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim idxLinha As Integer = 0

                While dr.Read()
                    dgv.Rows.Add()
                    dgv.Rows(idxLinha).Cells(0).Value = dr("IDSocio").ToString()
                    dgv.Rows(idxLinha).Cells(1).Value = dr("IDAgregado").ToString()
                    dgv.Rows(idxLinha).Cells(2).Value = dr("nomeAtleta").ToString()
                    dgv.Rows(idxLinha).Cells(3).Value = dr("modalidade").ToString()
                    dgv.Rows(idxLinha).Cells(4).Value = dr("valor").ToString()

                    idxLinha += 1
                End While
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub PreencherDataGridViewNFatura(ByRef dgv As DataGridView, ByVal nFatura As String, ByVal descricao As String, ByVal mensalidade As String, ByVal IDSocio As String, ByVal IDAgregado As String, ByVal nome As String, ByVal valor As String)

        Dim query As String = "SELECT nFatura, Descricao, Mensalidade, IDSocio, IDAgregado, Valor, Nome FROM faturas "

        Dim flag As Boolean = False

        If nFatura.Length > 0 AndAlso flag = True Then

            query += " AND nFatura = '" + nFatura + "'"

        ElseIf nFatura.Length > 0 Then

            query += " WHERE nFatura = '" + nFatura + "'"

            flag = True

        End If


        query += " ORDER BY nFatura;"



        Try
            If (OpenConnection()) Then
                Dim cmd As New MySqlCommand(query, BDConnect)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim idxLinha As Integer = 0

                While dr.Read()
                    dgv.Rows.Add()
                    dgv.Rows(idxLinha).Cells(0).Value = dr("nFatura").ToString()
                    dgv.Rows(idxLinha).Cells(1).Value = dr("Descricao").ToString()
                    dgv.Rows(idxLinha).Cells(2).Value = dr("Mensalidade").ToString()
                    dgv.Rows(idxLinha).Cells(3).Value = dr("IDSocio").ToString()
                    dgv.Rows(idxLinha).Cells(4).Value = dr("IDAgregado").ToString()
                    dgv.Rows(idxLinha).Cells(5).Value = dr("Nome").ToString()
                    dgv.Rows(idxLinha).Cells(6).Value = dr("Valor").ToString()

                    idxLinha += 1
                End While
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub PreenchercmbModalidade(ByRef cmbModalidade As ComboBox)

        Dim connectionString As String = "Server=127.0.0.1;User ID=root;Port=3306;Database=associados"
        BDConnect = New MySqlConnection(connectionString)

        BDConnect.Open()

        Try
            Dim Command As New MySqlCommand("SELECT * FROM modalidade", BDConnect)
            Dim reader As MySqlDataReader = Command.ExecuteReader()
            cmbModalidade.Items.Clear()
            While (reader.Read())
                cmbModalidade.Items.Add(reader.GetValue(0).ToString())
            End While
        Catch ex As Exception
            MsgBox("Erro: " & ex.ToString())
        Finally
            BDConnect.Close()
        End Try


    End Sub

    Public Sub PreenchercmbDescricao(ByRef cmbDescricao As ComboBox)

        Dim connectionString As String = "Server=127.0.0.1;User ID=root;Port=3306;Database=associados"
        BDConnect = New MySqlConnection(connectionString)

        BDConnect.Open()

        Try
            Dim Command As New MySqlCommand("SELECT * FROM faturas", BDConnect)
            Dim reader As MySqlDataReader = Command.ExecuteReader()
            cmbDescricao.Items.Clear()
            While (reader.Read())
                cmbDescricao.Items.Add(reader.GetValue(3).ToString())
            End While
        Catch ex As Exception
            MsgBox("Erro: " & ex.ToString())
        Finally
            BDConnect.Close()
        End Try


    End Sub

    Public Sub PreenchercmbAtleta(ByRef cmbAtleta As ComboBox)

        Dim connectionString As String = "Server=127.0.0.1;User ID=root;Port=3306;Database=associados"
        BDConnect = New MySqlConnection(connectionString)

        Try
            BDConnect.Open()
            Dim Command As New MySqlCommand("SELECT * FROM atleta", BDConnect)
            Dim reader As MySqlDataReader = Command.ExecuteReader()
            cmbAtleta.Items.Clear()
            While (reader.Read())
                cmbAtleta.Items.Add(reader.GetValue(2).ToString() + " | " + reader.GetValue(4).ToString() + " | " + reader.GetValue(0).ToString())

            End While
        Catch ex As Exception
            MsgBox("Erro: " & ex.ToString())
        Finally
            BDConnect.Close()
        End Try


    End Sub

    Public Sub PreenchercmbSocios(ByRef cmbIDSocio As ComboBox)

        Dim connectionString As String = "Server=127.0.0.1;User ID=root;Port=3306;Database=associados"
        BDConnect = New MySqlConnection(connectionString)

        BDConnect.Open()

        Try
            Dim Command As New MySqlCommand("SELECT * FROM socio", BDConnect)
            Dim reader As MySqlDataReader = Command.ExecuteReader()
            cmbIDSocio.Items.Clear()
            While (reader.Read())
                cmbIDSocio.Items.Add(reader.GetInt32(0).ToString + " | " + reader.GetValue(1))
            End While
        Catch ex As Exception
            MsgBox("Erro: " + ex.ToString())
        Finally
            BDConnect.Close()
        End Try


    End Sub
    Public Sub PreenchercmbAgregado(ByRef cmbIDAgregado As ComboBox, ByRef cmbIDSocio As ComboBox)
        Dim connectionString As String = "Server=127.0.0.1;User ID=root;Port=3306;Database=associados"
        Dim BDConnect As New MySqlConnection(connectionString)


        Dim IDSocio As String = cmbIDSocio.Text.Split(" | ")(0)

        Try
            BDConnect.Open()
            Dim Command As New MySqlCommand("SELECT * FROM agregado WHERE IDSocio = '" + IDSocio + "'", BDConnect)
            Dim reader As MySqlDataReader = Command.ExecuteReader()
            cmbIDAgregado.Items.Clear()
            While (reader.Read())
                cmbIDAgregado.Items.Add(reader.GetValue(0).ToString() + " | " + reader.GetValue(1).ToString())
            End While
        Catch ex As Exception
            MsgBox("Erro: " + ex.ToString())
        Finally
            BDConnect.Close()
        End Try

    End Sub

    Public Sub PreenchercmbAgregado2(ByRef cmbIDAgregado As ComboBox)
        Dim connectionString As String = "Server=127.0.0.1;User ID=root;Port=3306;Database=associados"
        Dim BDConnect As New MySqlConnection(connectionString)


        Try
            BDConnect.Open()
            Dim Command As New MySqlCommand("SELECT * FROM agregado", BDConnect)
            Dim reader As MySqlDataReader = Command.ExecuteReader()
            cmbIDAgregado.Items.Clear()
            While (reader.Read())
                cmbIDAgregado.Items.Add(reader.GetValue(0).ToString() + " | " + reader.GetValue(1).ToString())
            End While
        Catch ex As Exception
            MsgBox("Erro: " + ex.ToString())
        Finally
            BDConnect.Close()
        End Try

    End Sub

    Public Sub PreenchercmbMensalidade(ByRef cmbMensalidade As ComboBox)

        Dim connectionString As String = "Server=127.0.0.1;User ID=root;Port=3306;Database=associados"
        BDConnect = New MySqlConnection(connectionString)

        BDConnect.Open()

        Try
            Dim Command As New MySqlCommand("SELECT * FROM mensalidade", BDConnect)
            Dim reader As MySqlDataReader = Command.ExecuteReader()
            cmbMensalidade.Items.Clear()
            While (reader.Read())
                cmbMensalidade.Items.Add(reader.GetValue(0) & " | " & reader.GetValue(1))
            End While
        Catch ex As Exception
            MsgBox("Erro: " & ex.ToString())
        Finally
            BDConnect.Close()
        End Try


    End Sub


    Private Function OpenConnection() As Boolean
        Dim connectionString As String = "Server=127.0.0.1;User ID=root;Port=3306;Database=associados"
        BDConnect = New MySqlConnection(connectionString)

        Try
            BDConnect.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
End Class
