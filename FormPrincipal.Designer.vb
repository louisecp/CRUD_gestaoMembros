<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SócioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAgregadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarSóciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarAgregadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserirToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApagarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmitirFaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagamentoQuotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagamentoModalidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarFaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularFaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtigosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddModalidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddModalidadeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddQuotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SócioToolStripMenuItem, Me.AtletaToolStripMenuItem, Me.FaturasToolStripMenuItem, Me.ArtigosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1006, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SócioToolStripMenuItem
        '
        Me.SócioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InserirToolStripMenuItem, Me.AddAgregadoToolStripMenuItem, Me.AtualizarToolStripMenuItem, Me.ListarToolStripMenuItem, Me.ListarToolStripMenuItem1})
        Me.SócioToolStripMenuItem.Image = CType(resources.GetObject("SócioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SócioToolStripMenuItem.Name = "SócioToolStripMenuItem"
        Me.SócioToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.SócioToolStripMenuItem.Text = "Sócio"
        '
        'InserirToolStripMenuItem
        '
        Me.InserirToolStripMenuItem.Image = CType(resources.GetObject("InserirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InserirToolStripMenuItem.Name = "InserirToolStripMenuItem"
        Me.InserirToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.InserirToolStripMenuItem.Text = "Inserir"
        '
        'AddAgregadoToolStripMenuItem
        '
        Me.AddAgregadoToolStripMenuItem.Image = CType(resources.GetObject("AddAgregadoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddAgregadoToolStripMenuItem.Name = "AddAgregadoToolStripMenuItem"
        Me.AddAgregadoToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.AddAgregadoToolStripMenuItem.Text = "Add Agregado"
        '
        'AtualizarToolStripMenuItem
        '
        Me.AtualizarToolStripMenuItem.Image = CType(resources.GetObject("AtualizarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AtualizarToolStripMenuItem.Name = "AtualizarToolStripMenuItem"
        Me.AtualizarToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.AtualizarToolStripMenuItem.Text = "Atualizar"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Image = CType(resources.GetObject("ListarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.ListarToolStripMenuItem.Text = "Apagar"
        '
        'ListarToolStripMenuItem1
        '
        Me.ListarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarSóciosToolStripMenuItem, Me.ListarAgregadosToolStripMenuItem1})
        Me.ListarToolStripMenuItem1.Image = CType(resources.GetObject("ListarToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ListarToolStripMenuItem1.Name = "ListarToolStripMenuItem1"
        Me.ListarToolStripMenuItem1.Size = New System.Drawing.Size(191, 26)
        Me.ListarToolStripMenuItem1.Text = "Listagens"
        '
        'ListarSóciosToolStripMenuItem
        '
        Me.ListarSóciosToolStripMenuItem.Name = "ListarSóciosToolStripMenuItem"
        Me.ListarSóciosToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.ListarSóciosToolStripMenuItem.Text = "Listar Sócios"
        '
        'ListarAgregadosToolStripMenuItem1
        '
        Me.ListarAgregadosToolStripMenuItem1.Name = "ListarAgregadosToolStripMenuItem1"
        Me.ListarAgregadosToolStripMenuItem1.Size = New System.Drawing.Size(204, 26)
        Me.ListarAgregadosToolStripMenuItem1.Text = "Listar Agregados"
        '
        'AtletaToolStripMenuItem
        '
        Me.AtletaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InserirToolStripMenuItem2, Me.ApagarToolStripMenuItem1, Me.ListarToolStripMenuItem3})
        Me.AtletaToolStripMenuItem.Image = CType(resources.GetObject("AtletaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AtletaToolStripMenuItem.Name = "AtletaToolStripMenuItem"
        Me.AtletaToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.AtletaToolStripMenuItem.Text = "Atleta"
        '
        'InserirToolStripMenuItem2
        '
        Me.InserirToolStripMenuItem2.Image = CType(resources.GetObject("InserirToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.InserirToolStripMenuItem2.Name = "InserirToolStripMenuItem2"
        Me.InserirToolStripMenuItem2.Size = New System.Drawing.Size(141, 26)
        Me.InserirToolStripMenuItem2.Text = "Inserir"
        '
        'ApagarToolStripMenuItem1
        '
        Me.ApagarToolStripMenuItem1.Image = CType(resources.GetObject("ApagarToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ApagarToolStripMenuItem1.Name = "ApagarToolStripMenuItem1"
        Me.ApagarToolStripMenuItem1.Size = New System.Drawing.Size(141, 26)
        Me.ApagarToolStripMenuItem1.Text = "Apagar"
        '
        'ListarToolStripMenuItem3
        '
        Me.ListarToolStripMenuItem3.Image = CType(resources.GetObject("ListarToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ListarToolStripMenuItem3.Name = "ListarToolStripMenuItem3"
        Me.ListarToolStripMenuItem3.Size = New System.Drawing.Size(141, 26)
        Me.ListarToolStripMenuItem3.Text = "Listar"
        '
        'FaturasToolStripMenuItem
        '
        Me.FaturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmitirFaturaToolStripMenuItem, Me.ConsultarFaturaToolStripMenuItem, Me.AnularFaturaToolStripMenuItem})
        Me.FaturasToolStripMenuItem.Image = CType(resources.GetObject("FaturasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FaturasToolStripMenuItem.Name = "FaturasToolStripMenuItem"
        Me.FaturasToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.FaturasToolStripMenuItem.Text = "Faturas"
        '
        'EmitirFaturaToolStripMenuItem
        '
        Me.EmitirFaturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagamentoQuotaToolStripMenuItem, Me.PagamentoModalidadeToolStripMenuItem})
        Me.EmitirFaturaToolStripMenuItem.Image = CType(resources.GetObject("EmitirFaturaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmitirFaturaToolStripMenuItem.Name = "EmitirFaturaToolStripMenuItem"
        Me.EmitirFaturaToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.EmitirFaturaToolStripMenuItem.Text = "Pagamento"
        '
        'PagamentoQuotaToolStripMenuItem
        '
        Me.PagamentoQuotaToolStripMenuItem.Name = "PagamentoQuotaToolStripMenuItem"
        Me.PagamentoQuotaToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.PagamentoQuotaToolStripMenuItem.Text = "Pagamento Quota"
        '
        'PagamentoModalidadeToolStripMenuItem
        '
        Me.PagamentoModalidadeToolStripMenuItem.Name = "PagamentoModalidadeToolStripMenuItem"
        Me.PagamentoModalidadeToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.PagamentoModalidadeToolStripMenuItem.Text = "Pagamento Modalidade"
        '
        'ConsultarFaturaToolStripMenuItem
        '
        Me.ConsultarFaturaToolStripMenuItem.Image = CType(resources.GetObject("ConsultarFaturaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarFaturaToolStripMenuItem.Name = "ConsultarFaturaToolStripMenuItem"
        Me.ConsultarFaturaToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.ConsultarFaturaToolStripMenuItem.Text = "Anular Fatura"
        '
        'AnularFaturaToolStripMenuItem
        '
        Me.AnularFaturaToolStripMenuItem.Image = CType(resources.GetObject("AnularFaturaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AnularFaturaToolStripMenuItem.Name = "AnularFaturaToolStripMenuItem"
        Me.AnularFaturaToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.AnularFaturaToolStripMenuItem.Text = "Listar Fatura"
        '
        'ArtigosToolStripMenuItem
        '
        Me.ArtigosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddModalidadeToolStripMenuItem})
        Me.ArtigosToolStripMenuItem.Image = CType(resources.GetObject("ArtigosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ArtigosToolStripMenuItem.Name = "ArtigosToolStripMenuItem"
        Me.ArtigosToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.ArtigosToolStripMenuItem.Text = "Artigos"
        '
        'AddModalidadeToolStripMenuItem
        '
        Me.AddModalidadeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddModalidadeToolStripMenuItem1, Me.AddQuotaToolStripMenuItem})
        Me.AddModalidadeToolStripMenuItem.Image = CType(resources.GetObject("AddModalidadeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddModalidadeToolStripMenuItem.Name = "AddModalidadeToolStripMenuItem"
        Me.AddModalidadeToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.AddModalidadeToolStripMenuItem.Text = "Add Artigo"
        '
        'AddModalidadeToolStripMenuItem1
        '
        Me.AddModalidadeToolStripMenuItem1.Name = "AddModalidadeToolStripMenuItem1"
        Me.AddModalidadeToolStripMenuItem1.Size = New System.Drawing.Size(205, 26)
        Me.AddModalidadeToolStripMenuItem1.Text = "Add Modalidade"
        '
        'AddQuotaToolStripMenuItem
        '
        Me.AddQuotaToolStripMenuItem.Name = "AddQuotaToolStripMenuItem"
        Me.AddQuotaToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.AddQuotaToolStripMenuItem.Text = "Add Mes/Ano"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1006, 542)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPrincipal"
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SócioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InserirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AtletaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InserirToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ApagarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents FaturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtigosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAgregadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddModalidadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarSóciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarAgregadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddModalidadeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddQuotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmitirFaturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarFaturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnularFaturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagamentoQuotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagamentoModalidadeToolStripMenuItem As ToolStripMenuItem
End Class
