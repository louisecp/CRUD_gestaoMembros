Imports System.Data.Common
Imports System.Text.RegularExpressions ' Importa o namespace necessário para a classe Regex.
Imports MySqlConnector

Public Class Geral

    Public BDConnect As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=associados")


    Public Shared Function TirarEspacos(texto As String) As String
        texto = texto.Trim() ' Remove os espaços em branco do início e do final da string
        texto = Regex.Replace(texto, "\s", "") ' Usa expressão regular para substituir todos os espaços em branco dentro da string por uma string vazia
        Return texto
    End Function



End Class

