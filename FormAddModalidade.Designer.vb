<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddModalidade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddModalidade))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValorModalidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeModalidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtValorModalidade)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNomeModalidade)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "€"
        '
        'txtValorModalidade
        '
        Me.txtValorModalidade.Location = New System.Drawing.Point(200, 110)
        Me.txtValorModalidade.Name = "txtValorModalidade"
        Me.txtValorModalidade.Size = New System.Drawing.Size(112, 22)
        Me.txtValorModalidade.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor:"
        '
        'txtNomeModalidade
        '
        Me.txtNomeModalidade.Location = New System.Drawing.Point(198, 51)
        Me.txtNomeModalidade.Name = "txtNomeModalidade"
        Me.txtNomeModalidade.Size = New System.Drawing.Size(174, 22)
        Me.txtNomeModalidade.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nome da Modalidade:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(275, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 35)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(351, 210)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(70, 35)
        Me.btnGravar.TabIndex = 2
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'FormAddModalidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 261)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormAddModalidade"
        Me.Text = "Add Modalidade"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNomeModalidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValorModalidade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGravar As Button
End Class
