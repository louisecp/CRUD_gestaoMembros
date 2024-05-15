<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnularFatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnularFatura))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbNFatura = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMensalidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(343, 376)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 35)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbNFatura)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisa"
        '
        'cmbNFatura
        '
        Me.cmbNFatura.FormattingEnabled = True
        Me.cmbNFatura.Location = New System.Drawing.Point(150, 47)
        Me.cmbNFatura.Name = "cmbNFatura"
        Me.cmbNFatura.Size = New System.Drawing.Size(106, 24)
        Me.cmbNFatura.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nº Fatura:"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(306, 36)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(95, 44)
        Me.btnPesquisar.TabIndex = 2
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNome)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtMensalidade)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtDescricao)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 244)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Fatura"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(150, 78)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(308, 22)
        Me.txtNome.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nome:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(150, 206)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(120, 22)
        Me.txtValor.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Valor:"
        '
        'txtMensalidade
        '
        Me.txtMensalidade.Location = New System.Drawing.Point(150, 163)
        Me.txtMensalidade.Name = "txtMensalidade"
        Me.txtMensalidade.Size = New System.Drawing.Size(308, 22)
        Me.txtMensalidade.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mensalidade:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(150, 116)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(308, 22)
        Me.txtDescricao.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descrição:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(150, 39)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(81, 22)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Sócio:"
        '
        'btnApagar
        '
        Me.btnApagar.Image = CType(resources.GetObject("btnApagar.Image"), System.Drawing.Image)
        Me.btnApagar.Location = New System.Drawing.Point(434, 376)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(70, 35)
        Me.btnApagar.TabIndex = 3
        Me.btnApagar.UseVisualStyleBackColor = True
        '
        'FormAnularFatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 424)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnApagar)
        Me.Name = "FormAnularFatura"
        Me.Text = "Anular Fatura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbNFatura As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnApagar As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMensalidade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label5 As Label
End Class
