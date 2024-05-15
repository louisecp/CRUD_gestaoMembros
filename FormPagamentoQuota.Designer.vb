<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPagamentoQuota
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMensalidade = New System.Windows.Forms.ComboBox()
        Me.cmbIDSocio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbMensalidade)
        Me.GroupBox1.Controls.Add(Me.cmbIDSocio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "€"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(116, 171)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(105, 22)
        Me.txtValor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valor:"
        '
        'cmbMensalidade
        '
        Me.cmbMensalidade.FormattingEnabled = True
        Me.cmbMensalidade.Location = New System.Drawing.Point(116, 114)
        Me.cmbMensalidade.Name = "cmbMensalidade"
        Me.cmbMensalidade.Size = New System.Drawing.Size(219, 24)
        Me.cmbMensalidade.TabIndex = 3
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
        Me.Label2.Location = New System.Drawing.Point(19, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 2
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Emitir Fatura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormPagamentoQuota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 322)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPagamentoQuota"
        Me.Text = "Pagamento Quota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMensalidade As ComboBox
    Friend WithEvents cmbIDSocio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label4 As Label
End Class
