<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInserirAtleta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInserirAtleta))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.cmbIDSocio = New System.Windows.Forms.ComboBox()
        Me.rbAgregado = New System.Windows.Forms.RadioButton()
        Me.cmbIDAgregado = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbModalidade = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(33, 40)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(26, 16)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "ID :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Modalidade:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(12, 376)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(89, 16)
        Me.lblValor.TabIndex = 0
        Me.lblValor.Text = "Valor mensal:"
        '
        'cmbIDSocio
        '
        Me.cmbIDSocio.FormattingEnabled = True
        Me.cmbIDSocio.Location = New System.Drawing.Point(36, 59)
        Me.cmbIDSocio.Name = "cmbIDSocio"
        Me.cmbIDSocio.Size = New System.Drawing.Size(249, 24)
        Me.cmbIDSocio.TabIndex = 1
        '
        'rbAgregado
        '
        Me.rbAgregado.AutoSize = True
        Me.rbAgregado.Location = New System.Drawing.Point(36, 129)
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
        Me.cmbIDAgregado.Location = New System.Drawing.Point(36, 155)
        Me.cmbIDAgregado.Name = "cmbIDAgregado"
        Me.cmbIDAgregado.Size = New System.Drawing.Size(249, 24)
        Me.cmbIDAgregado.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbModalidade)
        Me.GroupBox2.Controls.Add(Me.cmbIDAgregado)
        Me.GroupBox2.Controls.Add(Me.rbAgregado)
        Me.GroupBox2.Controls.Add(Me.cmbIDSocio)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(329, 314)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Atleta"
        '
        'cmbModalidade
        '
        Me.cmbModalidade.FormattingEnabled = True
        Me.cmbModalidade.Location = New System.Drawing.Point(36, 247)
        Me.cmbModalidade.Name = "cmbModalidade"
        Me.cmbModalidade.Size = New System.Drawing.Size(249, 24)
        Me.cmbModalidade.TabIndex = 5
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(108, 376)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(46, 22)
        Me.txtValor.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(195, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(271, 367)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(70, 35)
        Me.btnGravar.TabIndex = 3
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'FormInserirAtleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 418)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.lblValor)
        Me.Name = "FormInserirAtleta"
        Me.Text = "Inserir Atleta"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGravar As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents cmbIDSocio As ComboBox
    Friend WithEvents rbAgregado As RadioButton
    Friend WithEvents cmbIDAgregado As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbModalidade As ComboBox
    Friend WithEvents txtValor As TextBox
End Class
