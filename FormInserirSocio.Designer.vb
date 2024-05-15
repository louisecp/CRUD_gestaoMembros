<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInserirSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInserirSocio))
        Me.btnAddAgregado = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtxtNIF = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMorada = New System.Windows.Forms.TextBox()
        Me.mtxtContato = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddAgregado
        '
        Me.btnAddAgregado.Image = CType(resources.GetObject("btnAddAgregado.Image"), System.Drawing.Image)
        Me.btnAddAgregado.Location = New System.Drawing.Point(436, 253)
        Me.btnAddAgregado.Name = "btnAddAgregado"
        Me.btnAddAgregado.Size = New System.Drawing.Size(93, 44)
        Me.btnAddAgregado.TabIndex = 13
        Me.btnAddAgregado.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(416, 370)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 35)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtxtNIF)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.mtxtDataNascimento)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtValor)
        Me.GroupBox3.Controls.Add(Me.txtNome)
        Me.GroupBox3.Controls.Add(Me.btnAddAgregado)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtMorada)
        Me.GroupBox3.Controls.Add(Me.mtxtContato)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 332)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados Sócio"
        '
        'mtxtNIF
        '
        Me.mtxtNIF.Location = New System.Drawing.Point(145, 142)
        Me.mtxtNIF.Mask = "000000000"
        Me.mtxtNIF.Name = "mtxtNIF"
        Me.mtxtNIF.Size = New System.Drawing.Size(106, 22)
        Me.mtxtNIF.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(433, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Add Agregado"
        '
        'mtxtDataNascimento
        '
        Me.mtxtDataNascimento.Location = New System.Drawing.Point(145, 237)
        Me.mtxtDataNascimento.Mask = "00/00/0000"
        Me.mtxtDataNascimento.Name = "mtxtDataNascimento"
        Me.mtxtDataNascimento.Size = New System.Drawing.Size(106, 22)
        Me.mtxtDataNascimento.TabIndex = 9
        Me.mtxtDataNascimento.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(266, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "€"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(145, 281)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(106, 22)
        Me.txtValor.TabIndex = 11
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(150, 39)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(365, 22)
        Me.txtNome.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(85, 281)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Valor:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(80, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nome:"
        '
        'txtMorada
        '
        Me.txtMorada.Location = New System.Drawing.Point(145, 92)
        Me.txtMorada.Name = "txtMorada"
        Me.txtMorada.Size = New System.Drawing.Size(370, 22)
        Me.txtMorada.TabIndex = 3
        '
        'mtxtContato
        '
        Me.mtxtContato.Location = New System.Drawing.Point(145, 191)
        Me.mtxtContato.Mask = "000 000 000"
        Me.mtxtContato.Name = "mtxtContato"
        Me.mtxtContato.Size = New System.Drawing.Size(106, 22)
        Me.mtxtContato.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 237)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Data Nascimento:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(71, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Contato:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(70, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Morada:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(96, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 16)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "NIF:"
        '
        'btnGravar
        '
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(501, 370)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(70, 35)
        Me.btnGravar.TabIndex = 1
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'FormInserirSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 417)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnGravar)
        Me.Name = "FormInserirSocio"
        Me.Text = "Inserir Sócio"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddAgregado As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mtxtDataNascimento As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMorada As TextBox
    Friend WithEvents mtxtContato As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnGravar As Button
    Friend WithEvents mtxtNIF As MaskedTextBox
End Class
