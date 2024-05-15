<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagamentoModalidade
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAgregado = New System.Windows.Forms.RadioButton()
        Me.cmbIDAgregado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbModalidade = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMensalidade = New System.Windows.Forms.ComboBox()
        Me.cmbIDSocio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Emitir Fatura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAgregado)
        Me.GroupBox1.Controls.Add(Me.cmbIDAgregado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbModalidade)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbMensalidade)
        Me.GroupBox1.Controls.Add(Me.cmbIDSocio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 397)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rbAgregado
        '
        Me.rbAgregado.AutoSize = True
        Me.rbAgregado.Location = New System.Drawing.Point(22, 92)
        Me.rbAgregado.Name = "rbAgregado"
        Me.rbAgregado.Size = New System.Drawing.Size(89, 20)
        Me.rbAgregado.TabIndex = 2
        Me.rbAgregado.TabStop = True
        Me.rbAgregado.Text = "Agregado"
        Me.rbAgregado.UseVisualStyleBackColor = True
        '
        'cmbIDAgregado
        '
        Me.cmbIDAgregado.FormattingEnabled = True
        Me.cmbIDAgregado.Location = New System.Drawing.Point(22, 143)
        Me.cmbIDAgregado.Name = "cmbIDAgregado"
        Me.cmbIDAgregado.Size = New System.Drawing.Size(313, 24)
        Me.cmbIDAgregado.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ID Agregado:"
        '
        'cmbModalidade
        '
        Me.cmbModalidade.FormattingEnabled = True
        Me.cmbModalidade.Location = New System.Drawing.Point(116, 207)
        Me.cmbModalidade.Name = "cmbModalidade"
        Me.cmbModalidade.Size = New System.Drawing.Size(219, 24)
        Me.cmbModalidade.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Modalidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "€"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(116, 329)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 22)
        Me.txtValor.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Valor:"
        '
        'cmbMensalidade
        '
        Me.cmbMensalidade.FormattingEnabled = True
        Me.cmbMensalidade.Location = New System.Drawing.Point(116, 272)
        Me.cmbMensalidade.Name = "cmbMensalidade"
        Me.cmbMensalidade.Size = New System.Drawing.Size(219, 24)
        Me.cmbMensalidade.TabIndex = 8
        '
        'cmbIDSocio
        '
        Me.cmbIDSocio.FormattingEnabled = True
        Me.cmbIDSocio.Location = New System.Drawing.Point(22, 51)
        Me.cmbIDSocio.Name = "cmbIDSocio"
        Me.cmbIDSocio.Size = New System.Drawing.Size(313, 24)
        Me.cmbIDSocio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mensalidade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Sócio:"
        '
        'FormPagamentoModalidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 468)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPagamentoModalidade"
        Me.Text = "Pagamento Modalidade"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbModalidade As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMensalidade As ComboBox
    Friend WithEvents cmbIDSocio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbIDAgregado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbAgregado As RadioButton
End Class
