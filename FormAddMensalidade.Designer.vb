<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddMensalidade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddMensalidade))
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.mtxtAno = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGravar
        '
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(248, 162)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(70, 35)
        Me.btnGravar.TabIndex = 2
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(162, 162)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 35)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMes)
        Me.GroupBox1.Controls.Add(Me.mtxtAno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(93, 36)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(169, 22)
        Me.txtMes.TabIndex = 1
        '
        'mtxtAno
        '
        Me.mtxtAno.Location = New System.Drawing.Point(93, 95)
        Me.mtxtAno.Mask = "0000"
        Me.mtxtAno.Name = "mtxtAno"
        Me.mtxtAno.Size = New System.Drawing.Size(47, 22)
        Me.mtxtAno.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ano:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mês:"
        '
        'FormAddQuota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 214)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormAddQuota"
        Me.Text = "Add Quota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGravar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mtxtAno As MaskedTextBox
    Friend WithEvents txtMes As TextBox
End Class
