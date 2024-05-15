<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddAgregado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddAgregado))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtxtNIF = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.cmbIDSocio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtxtContato = New System.Windows.Forms.MaskedTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtxtNIF)
        Me.GroupBox2.Controls.Add(Me.mtxtDataNascimento)
        Me.GroupBox2.Controls.Add(Me.cmbIDSocio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.mtxtContato)
        Me.GroupBox2.Controls.Add(Me.txtNome)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 311)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Agregado"
        '
        'mtxtNIF
        '
        Me.mtxtNIF.Location = New System.Drawing.Point(170, 144)
        Me.mtxtNIF.Mask = "000000000"
        Me.mtxtNIF.Name = "mtxtNIF"
        Me.mtxtNIF.Size = New System.Drawing.Size(94, 22)
        Me.mtxtNIF.TabIndex = 5
        '
        'mtxtDataNascimento
        '
        Me.mtxtDataNascimento.Location = New System.Drawing.Point(170, 253)
        Me.mtxtDataNascimento.Mask = "00/00/0000"
        Me.mtxtDataNascimento.Name = "mtxtDataNascimento"
        Me.mtxtDataNascimento.Size = New System.Drawing.Size(94, 22)
        Me.mtxtDataNascimento.TabIndex = 9
        '
        'cmbIDSocio
        '
        Me.cmbIDSocio.FormattingEnabled = True
        Me.cmbIDSocio.Location = New System.Drawing.Point(170, 38)
        Me.cmbIDSocio.Name = "cmbIDSocio"
        Me.cmbIDSocio.Size = New System.Drawing.Size(240, 24)
        Me.cmbIDSocio.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID Sócio:"
        '
        'mtxtContato
        '
        Me.mtxtContato.Location = New System.Drawing.Point(170, 196)
        Me.mtxtContato.Mask = "000 000 000"
        Me.mtxtContato.Name = "mtxtContato"
        Me.mtxtContato.Size = New System.Drawing.Size(94, 22)
        Me.mtxtContato.TabIndex = 7
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(170, 91)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(240, 22)
        Me.txtNome.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Data Nascimento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NIF:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome:"
        '
        'btnGravar
        '
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(396, 329)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(70, 35)
        Me.btnGravar.TabIndex = 1
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'FormAddAgregado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 374)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGravar)
        Me.Name = "FormAddAgregado"
        Me.Text = "Add Agregado"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbIDSocio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGravar As Button
    Friend WithEvents mtxtContato As MaskedTextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtxtDataNascimento As MaskedTextBox
    Friend WithEvents mtxtNIF As MaskedTextBox
End Class
