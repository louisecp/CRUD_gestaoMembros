Imports Org.BouncyCastle.Math.EC

Public Class FormPrincipal

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim f4 = New FormInserirAtleta
        f4.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Dim f6 = New FormListagemAtleta
        'f6.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim f7 = New FormAddAgregado
        f7.Show()
    End Sub

    Private Sub btnEmitir_Click(sender As Object, e As EventArgs)
        Dim f8 = New FormPagamentoQuota
        f8.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Dim f9 = New FormAddModalidade
        f9.Show()
    End Sub

    Private Sub InserirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InserirToolStripMenuItem.Click
        Dim f1 = New FormInserirSocio
        f1.Show()
    End Sub

    Private Sub AtualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtualizarToolStripMenuItem.Click
        Dim f2 = New FormAtualizarSocio
        f2.Show()
    End Sub
    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        Dim f3 = New FormApagarSocio
        f3.Show()
    End Sub
    Private Sub ListarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem1.Click

    End Sub

    Private Sub InserirToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim f5 = New FormInserirAgregado
        f5.Show()
    End Sub

    Private Sub AtualizarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim f6 = New FormAtualizarAgregado
        f6.Show()
    End Sub

    Private Sub ApagarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f7 = New FormApagarAgregado
        f7.Show()
    End Sub

    Private Sub InserirToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InserirToolStripMenuItem2.Click
        Dim f8 = New FormInserirAtleta
        f8.Show()
    End Sub

    Private Sub ApagarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ApagarToolStripMenuItem1.Click
        Dim f10 = New FormApagarAtleta
        f10.Show()
    End Sub

    Private Sub ListarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem3.Click
        Dim f11 = New FormListarAtleta
        f11.Show()
    End Sub

    Private Sub AddAgregadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAgregadoToolStripMenuItem.Click
        Dim f12 = New FormAddAgregado
        f12.Show()
    End Sub



    Private Sub ListarSóciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarSóciosToolStripMenuItem.Click
        Dim f4 = New FormListarSocio
        f4.Show()
    End Sub

    Private Sub ArtigosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtigosToolStripMenuItem.Click

    End Sub

    Private Sub AddModalidadeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddModalidadeToolStripMenuItem1.Click
        Dim f13 = New FormAddModalidade
        f13.Show()
    End Sub

    Private Sub AddQuotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddQuotaToolStripMenuItem.Click
        Dim f14 = New FormAddMensalidade
        f14.Show()
    End Sub

    Private Sub PagamentoQuotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagamentoQuotaToolStripMenuItem.Click
        Dim f15 = New FormPagamentoQuota
        f15.Show()
    End Sub

    Private Sub PagamentoModalidadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagamentoModalidadeToolStripMenuItem.Click
        Dim f16 = New FormPagamentoModalidade
        f16.Show()
    End Sub

    Private Sub ConsultarFaturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarFaturaToolStripMenuItem.Click
        Dim f17 = New FormAnularFatura
        f17.Show()
    End Sub

    Private Sub AnularFaturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularFaturaToolStripMenuItem.Click
        Dim f18 = New FormListarFatura
        f18.Show()
    End Sub

    Private Sub SócioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SócioToolStripMenuItem.Click

    End Sub

    Private Sub ListarAgregadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListarAgregadosToolStripMenuItem1.Click
        Dim f19 = New FormListarAgregado
        f19.Show()
    End Sub
End Class