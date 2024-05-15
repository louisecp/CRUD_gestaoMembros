<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListarFatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormListarFatura))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblRegistos = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.txtNFatura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(831, 309)
        Me.DataGridView1.TabIndex = 1
        '
        'lblRegistos
        '
        Me.lblRegistos.AutoSize = True
        Me.lblRegistos.Location = New System.Drawing.Point(12, 510)
        Me.lblRegistos.Name = "lblRegistos"
        Me.lblRegistos.Size = New System.Drawing.Size(64, 16)
        Me.lblRegistos.TabIndex = 2
        Me.lblRegistos.Text = "Registos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnPesquisa)
        Me.GroupBox1.Controls.Add(Me.txtNFatura)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(721, 32)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 46)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Image = CType(resources.GetObject("btnPesquisa.Image"), System.Drawing.Image)
        Me.btnPesquisa.Location = New System.Drawing.Point(608, 32)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(94, 46)
        Me.btnPesquisa.TabIndex = 3
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'txtNFatura
        '
        Me.txtNFatura.Location = New System.Drawing.Point(89, 44)
        Me.txtNFatura.Name = "txtNFatura"
        Me.txtNFatura.Size = New System.Drawing.Size(87, 22)
        Me.txtNFatura.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nº Fatura:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(733, 494)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(110, 48)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'FormListarFatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 554)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblRegistos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormListarFatura"
        Me.Text = "Listar Fatura"
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
    Friend WithEvents txtNFatura As TextBox
    Friend WithEvents Label2 As Label
End Class
