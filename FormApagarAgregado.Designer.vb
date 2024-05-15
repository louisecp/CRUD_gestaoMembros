<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormApagarAgregado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormApagarAgregado))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbIDSocio = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtxtNIF = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtContato = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(425, 354)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 35)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbIDSocio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisa"
        '
        'cmbIDSocio
        '
        Me.cmbIDSocio.FormattingEnabled = True
        Me.cmbIDSocio.Location = New System.Drawing.Point(150, 47)
        Me.cmbIDSocio.Name = "cmbIDSocio"
        Me.cmbIDSocio.Size = New System.Drawing.Size(220, 24)
        Me.cmbIDSocio.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(110, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ID:"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(425, 36)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(95, 44)
        Me.btnPesquisar.TabIndex = 2
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtxtNIF)
        Me.GroupBox2.Controls.Add(Me.mtxtContato)
        Me.GroupBox2.Controls.Add(Me.mtxtDataNascimento)
        Me.GroupBox2.Controls.Add(Me.txtNome)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 222)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Agregado"
        '
        'mtxtNIF
        '
        Me.mtxtNIF.Location = New System.Drawing.Point(150, 84)
        Me.mtxtNIF.Mask = "000000000"
        Me.mtxtNIF.Name = "mtxtNIF"
        Me.mtxtNIF.Size = New System.Drawing.Size(100, 22)
        Me.mtxtNIF.TabIndex = 3
        '
        'mtxtContato
        '
        Me.mtxtContato.Location = New System.Drawing.Point(150, 127)
        Me.mtxtContato.Mask = "000 000 000"
        Me.mtxtContato.Name = "mtxtContato"
        Me.mtxtContato.Size = New System.Drawing.Size(106, 22)
        Me.mtxtContato.TabIndex = 5
        '
        'mtxtDataNascimento
        '
        Me.mtxtDataNascimento.Location = New System.Drawing.Point(150, 173)
        Me.mtxtDataNascimento.Mask = "00/00/0000"
        Me.mtxtDataNascimento.Name = "mtxtDataNascimento"
        Me.mtxtDataNascimento.Size = New System.Drawing.Size(106, 22)
        Me.mtxtDataNascimento.TabIndex = 7
        Me.mtxtDataNascimento.ValidatingType = GetType(Date)
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(150, 39)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(365, 22)
        Me.txtNome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Data Nascimento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIF:"
        '
        'btnDeletar
        '
        Me.btnDeletar.Image = CType(resources.GetObject("btnDeletar.Image"), System.Drawing.Image)
        Me.btnDeletar.Location = New System.Drawing.Point(501, 354)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(70, 35)
        Me.btnDeletar.TabIndex = 3
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'FormApagarAgregado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 402)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnDeletar)
        Me.Name = "FormApagarAgregado"
        Me.Text = "Apagar Agregado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbIDSocio As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents mtxtContato As MaskedTextBox
    Friend WithEvents mtxtDataNascimento As MaskedTextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDeletar As Button
    Friend WithEvents mtxtNIF As MaskedTextBox
End Class
