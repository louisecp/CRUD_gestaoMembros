<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInserirAgregado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInserirAgregado))
        Me.cmbIDSocio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtxtNIF = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMorada = New System.Windows.Forms.TextBox()
        Me.mtxtContato = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbIDSocio
        '
        Me.cmbIDSocio.FormattingEnabled = True
        Me.cmbIDSocio.Location = New System.Drawing.Point(153, 32)
        Me.cmbIDSocio.Name = "cmbIDSocio"
        Me.cmbIDSocio.Size = New System.Drawing.Size(240, 24)
        Me.cmbIDSocio.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID Sócio:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(427, 344)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 35)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtxtNIF)
        Me.GroupBox3.Controls.Add(Me.cmbIDSocio)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.mtxtDataNascimento)
        Me.GroupBox3.Controls.Add(Me.txtNome)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtMorada)
        Me.GroupBox3.Controls.Add(Me.mtxtContato)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 326)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados Agregado"
        '
        'mtxtNIF
        '
        Me.mtxtNIF.Location = New System.Drawing.Point(153, 178)
        Me.mtxtNIF.Mask = "000000000"
        Me.mtxtNIF.Name = "mtxtNIF"
        Me.mtxtNIF.Size = New System.Drawing.Size(106, 22)
        Me.mtxtNIF.TabIndex = 6
        '
        'mtxtDataNascimento
        '
        Me.mtxtDataNascimento.Location = New System.Drawing.Point(153, 279)
        Me.mtxtDataNascimento.Mask = "00/00/0000"
        Me.mtxtDataNascimento.Name = "mtxtDataNascimento"
        Me.mtxtDataNascimento.Size = New System.Drawing.Size(106, 22)
        Me.mtxtDataNascimento.TabIndex = 10
        Me.mtxtDataNascimento.ValidatingType = GetType(Date)
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(153, 81)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(365, 22)
        Me.txtNome.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(88, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Nome:"
        '
        'txtMorada
        '
        Me.txtMorada.Location = New System.Drawing.Point(153, 134)
        Me.txtMorada.Name = "txtMorada"
        Me.txtMorada.Size = New System.Drawing.Size(370, 22)
        Me.txtMorada.TabIndex = 4
        '
        'mtxtContato
        '
        Me.mtxtContato.Location = New System.Drawing.Point(153, 233)
        Me.mtxtContato.Mask = "000 000 000"
        Me.mtxtContato.Name = "mtxtContato"
        Me.mtxtContato.Size = New System.Drawing.Size(106, 22)
        Me.mtxtContato.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 279)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 16)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Data Nascimento:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(79, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Contato:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(78, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 16)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Morada:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(104, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "NIF:"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(503, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormInserirAgregado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 390)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormInserirAgregado"
        Me.Text = "Inserir Agregado"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbIDSocio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mtxtDataNascimento As MaskedTextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMorada As TextBox
    Friend WithEvents mtxtContato As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents mtxtNIF As MaskedTextBox
End Class
