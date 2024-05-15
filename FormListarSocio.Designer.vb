<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListarSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormListarSocio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbIDSocio = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRegistos = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbIDSocio)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnPesquisa)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbIDSocio
        '
        Me.cmbIDSocio.FormattingEnabled = True
        Me.cmbIDSocio.Location = New System.Drawing.Point(71, 61)
        Me.cmbIDSocio.Name = "cmbIDSocio"
        Me.cmbIDSocio.Size = New System.Drawing.Size(226, 24)
        Me.cmbIDSocio.TabIndex = 3
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
        Me.btnPesquisa.TabIndex = 4
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(71, 22)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(226, 22)
        Me.txtNome.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nome:"
        '
        'lblRegistos
        '
        Me.lblRegistos.AutoSize = True
        Me.lblRegistos.Location = New System.Drawing.Point(25, 507)
        Me.lblRegistos.Name = "lblRegistos"
        Me.lblRegistos.Size = New System.Drawing.Size(82, 16)
        Me.lblRegistos.TabIndex = 2
        Me.lblRegistos.Text = "Nº Registos:"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(735, 491)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 48)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(833, 321)
        Me.DataGridView1.TabIndex = 1
        '
        'FormListarSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(859, 551)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblRegistos)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "FormListarSocio"
        Me.Text = "Listagem Sócio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblRegistos As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Protected Friend WithEvents btnRefresh As Button
    Friend WithEvents cmbIDSocio As ComboBox
End Class
