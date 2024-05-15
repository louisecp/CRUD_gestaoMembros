<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormApagarAtleta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormApagarAtleta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbAtleta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbAtleta)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisa"
        '
        'cmbAtleta
        '
        Me.cmbAtleta.FormattingEnabled = True
        Me.cmbAtleta.Location = New System.Drawing.Point(77, 50)
        Me.cmbAtleta.Name = "cmbAtleta"
        Me.cmbAtleta.Size = New System.Drawing.Size(306, 24)
        Me.cmbAtleta.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nome:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(289, 126)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 35)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnApagar
        '
        Me.btnApagar.Image = CType(resources.GetObject("btnApagar.Image"), System.Drawing.Image)
        Me.btnApagar.Location = New System.Drawing.Point(365, 126)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(70, 35)
        Me.btnApagar.TabIndex = 2
        Me.btnApagar.UseVisualStyleBackColor = True
        '
        'FormApagarAtleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 178)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnApagar)
        Me.Name = "FormApagarAtleta"
        Me.Text = "Apagar Atleta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbAtleta As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnApagar As Button
End Class
