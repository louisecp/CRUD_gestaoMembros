<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListarAtleta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormListarAtleta))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblRegistos = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbModalidade = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(715, 323)
        Me.DataGridView1.TabIndex = 1
        '
        'lblRegistos
        '
        Me.lblRegistos.AutoSize = True
        Me.lblRegistos.Location = New System.Drawing.Point(9, 484)
        Me.lblRegistos.Name = "lblRegistos"
        Me.lblRegistos.Size = New System.Drawing.Size(64, 16)
        Me.lblRegistos.TabIndex = 2
        Me.lblRegistos.Text = "Registos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbModalidade)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnPesquisa)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbModalidade
        '
        Me.cmbModalidade.FormattingEnabled = True
        Me.cmbModalidade.Location = New System.Drawing.Point(107, 61)
        Me.cmbModalidade.Name = "cmbModalidade"
        Me.cmbModalidade.Size = New System.Drawing.Size(226, 24)
        Me.cmbModalidade.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Modalidade:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(596, 32)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 46)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Image = CType(resources.GetObject("btnPesquisa.Image"), System.Drawing.Image)
        Me.btnPesquisa.Location = New System.Drawing.Point(483, 32)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(94, 46)
        Me.btnPesquisa.TabIndex = 3
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(107, 22)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(226, 22)
        Me.txtNome.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nome:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(617, 468)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(110, 48)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'FormListarAtleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 530)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblRegistos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormListarAtleta"
        Me.Text = "Listar Atletas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnImprimir As Button
    Friend WithEvents lblRegistos As Label
    Friend WithEvents GroupBox1 As GroupBox
    Protected Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbModalidade As ComboBox
    Friend WithEvents Label1 As Label
End Class
