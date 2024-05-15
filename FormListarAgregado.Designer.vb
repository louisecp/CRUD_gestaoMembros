<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListarAgregado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormListarAgregado))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblRegistos = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbIDAgregado = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(833, 321)
        Me.DataGridView1.TabIndex = 1
        '
        'lblRegistos
        '
        Me.lblRegistos.AutoSize = True
        Me.lblRegistos.Location = New System.Drawing.Point(12, 496)
        Me.lblRegistos.Name = "lblRegistos"
        Me.lblRegistos.Size = New System.Drawing.Size(82, 16)
        Me.lblRegistos.TabIndex = 2
        Me.lblRegistos.Text = "Nº Registos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbIDAgregado)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnPesquisa)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbIDAgregado
        '
        Me.cmbIDAgregado.FormattingEnabled = True
        Me.cmbIDAgregado.Location = New System.Drawing.Point(71, 61)
        Me.cmbIDAgregado.Name = "cmbIDAgregado"
        Me.cmbIDAgregado.Size = New System.Drawing.Size(226, 24)
        Me.cmbIDAgregado.TabIndex = 4
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(719, 22)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 46)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Image = CType(resources.GetObject("btnPesquisa.Image"), System.Drawing.Image)
        Me.btnPesquisa.Location = New System.Drawing.Point(597, 21)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(94, 46)
        Me.btnPesquisa.TabIndex = 5
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(71, 22)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(226, 22)
        Me.txtNome.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(735, 480)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 48)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormListarAgregado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 540)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblRegistos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormListarAgregado"
        Me.Text = "Listar Agregado"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents lblRegistos As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbIDAgregado As ComboBox
    Protected Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
