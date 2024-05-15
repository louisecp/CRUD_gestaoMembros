<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAtualizarSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAtualizarSocio))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtxtNIFSocio = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtContatoSocio = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtDataNascimentoSocio = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtNomeSocio = New System.Windows.Forms.TextBox()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMoradaSocio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbIDSocio = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbIDAgregado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnPesquisarAgregado = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.mtxtNIFAgregado = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGravarAgregado = New System.Windows.Forms.Button()
        Me.mtxtContatoAgregado = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtDataNascimentoAgregado = New System.Windows.Forms.MaskedTextBox()
        Me.txtNomeAgregado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtxtNIFSocio)
        Me.GroupBox2.Controls.Add(Me.mtxtContatoSocio)
        Me.GroupBox2.Controls.Add(Me.mtxtDataNascimentoSocio)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Controls.Add(Me.txtNomeSocio)
        Me.GroupBox2.Controls.Add(Me.btnGravar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtMoradaSocio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 332)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Sócio"
        '
        'mtxtNIFSocio
        '
        Me.mtxtNIFSocio.Location = New System.Drawing.Point(145, 139)
        Me.mtxtNIFSocio.Mask = "000000000"
        Me.mtxtNIFSocio.Name = "mtxtNIFSocio"
        Me.mtxtNIFSocio.Size = New System.Drawing.Size(106, 22)
        Me.mtxtNIFSocio.TabIndex = 5
        '
        'mtxtContatoSocio
        '
        Me.mtxtContatoSocio.Location = New System.Drawing.Point(145, 191)
        Me.mtxtContatoSocio.Mask = "000 000 000"
        Me.mtxtContatoSocio.Name = "mtxtContatoSocio"
        Me.mtxtContatoSocio.Size = New System.Drawing.Size(106, 22)
        Me.mtxtContatoSocio.TabIndex = 7
        '
        'mtxtDataNascimentoSocio
        '
        Me.mtxtDataNascimentoSocio.Location = New System.Drawing.Point(145, 237)
        Me.mtxtDataNascimentoSocio.Mask = "00/00/0000"
        Me.mtxtDataNascimentoSocio.Name = "mtxtDataNascimentoSocio"
        Me.mtxtDataNascimentoSocio.Size = New System.Drawing.Size(106, 22)
        Me.mtxtDataNascimentoSocio.TabIndex = 9
        Me.mtxtDataNascimentoSocio.ValidatingType = GetType(Date)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(400, 288)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 35)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(257, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "€"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(145, 281)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(106, 22)
        Me.txtValor.TabIndex = 11
        '
        'txtNomeSocio
        '
        Me.txtNomeSocio.Location = New System.Drawing.Point(150, 39)
        Me.txtNomeSocio.Name = "txtNomeSocio"
        Me.txtNomeSocio.Size = New System.Drawing.Size(365, 22)
        Me.txtNomeSocio.TabIndex = 1
        '
        'btnGravar
        '
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.Location = New System.Drawing.Point(481, 287)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(70, 35)
        Me.btnGravar.TabIndex = 14
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Valor:"
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
        'txtMoradaSocio
        '
        Me.txtMoradaSocio.Location = New System.Drawing.Point(145, 92)
        Me.txtMoradaSocio.Name = "txtMoradaSocio"
        Me.txtMoradaSocio.Size = New System.Drawing.Size(370, 22)
        Me.txtMoradaSocio.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Data Nascimento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contato:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Morada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NIF:"
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
        Me.GroupBox1.Text = "Pesquisa ID Sócio"
        '
        'cmbIDSocio
        '
        Me.cmbIDSocio.FormattingEnabled = True
        Me.cmbIDSocio.Location = New System.Drawing.Point(145, 46)
        Me.cmbIDSocio.Name = "cmbIDSocio"
        Me.cmbIDSocio.Size = New System.Drawing.Size(220, 24)
        Me.cmbIDSocio.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ID Sócio:"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbIDAgregado)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.btnPesquisarAgregado)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 464)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 108)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agregados"
        '
        'cmbIDAgregado
        '
        Me.cmbIDAgregado.FormattingEnabled = True
        Me.cmbIDAgregado.Location = New System.Drawing.Point(150, 47)
        Me.cmbIDAgregado.Name = "cmbIDAgregado"
        Me.cmbIDAgregado.Size = New System.Drawing.Size(220, 24)
        Me.cmbIDAgregado.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ID Agregado:"
        '
        'btnPesquisarAgregado
        '
        Me.btnPesquisarAgregado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPesquisarAgregado.Image = CType(resources.GetObject("btnPesquisarAgregado.Image"), System.Drawing.Image)
        Me.btnPesquisarAgregado.Location = New System.Drawing.Point(425, 36)
        Me.btnPesquisarAgregado.Name = "btnPesquisarAgregado"
        Me.btnPesquisarAgregado.Size = New System.Drawing.Size(95, 44)
        Me.btnPesquisarAgregado.TabIndex = 2
        Me.btnPesquisarAgregado.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.mtxtNIFAgregado)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.btnGravarAgregado)
        Me.GroupBox4.Controls.Add(Me.mtxtContatoAgregado)
        Me.GroupBox4.Controls.Add(Me.mtxtDataNascimentoAgregado)
        Me.GroupBox4.Controls.Add(Me.txtNomeAgregado)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 578)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(559, 222)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dados Agregado"
        '
        'mtxtNIFAgregado
        '
        Me.mtxtNIFAgregado.Location = New System.Drawing.Point(150, 81)
        Me.mtxtNIFAgregado.Mask = "000000000"
        Me.mtxtNIFAgregado.Name = "mtxtNIFAgregado"
        Me.mtxtNIFAgregado.Size = New System.Drawing.Size(106, 22)
        Me.mtxtNIFAgregado.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(400, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGravarAgregado
        '
        Me.btnGravarAgregado.Image = CType(resources.GetObject("btnGravarAgregado.Image"), System.Drawing.Image)
        Me.btnGravarAgregado.Location = New System.Drawing.Point(481, 179)
        Me.btnGravarAgregado.Name = "btnGravarAgregado"
        Me.btnGravarAgregado.Size = New System.Drawing.Size(70, 35)
        Me.btnGravarAgregado.TabIndex = 9
        Me.btnGravarAgregado.UseVisualStyleBackColor = True
        '
        'mtxtContatoAgregado
        '
        Me.mtxtContatoAgregado.Location = New System.Drawing.Point(150, 127)
        Me.mtxtContatoAgregado.Mask = "000 000 000"
        Me.mtxtContatoAgregado.Name = "mtxtContatoAgregado"
        Me.mtxtContatoAgregado.Size = New System.Drawing.Size(106, 22)
        Me.mtxtContatoAgregado.TabIndex = 5
        '
        'mtxtDataNascimentoAgregado
        '
        Me.mtxtDataNascimentoAgregado.Location = New System.Drawing.Point(150, 173)
        Me.mtxtDataNascimentoAgregado.Mask = "00/00/0000"
        Me.mtxtDataNascimentoAgregado.Name = "mtxtDataNascimentoAgregado"
        Me.mtxtDataNascimentoAgregado.Size = New System.Drawing.Size(106, 22)
        Me.mtxtDataNascimentoAgregado.TabIndex = 7
        Me.mtxtDataNascimentoAgregado.ValidatingType = GetType(Date)
        '
        'txtNomeAgregado
        '
        Me.txtNomeAgregado.Location = New System.Drawing.Point(150, 39)
        Me.txtNomeAgregado.Name = "txtNomeAgregado"
        Me.txtNomeAgregado.Size = New System.Drawing.Size(365, 22)
        Me.txtNomeAgregado.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(80, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nome:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Data Nascimento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(71, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Contato:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(96, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "NIF:"
        '
        'FormAtualizarSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 808)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormAtualizarSocio"
        Me.Text = "Atualizar Socio"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGravar As Button
    Friend WithEvents txtMoradaSocio As TextBox
    Friend WithEvents txtNomeSocio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbIDSocio As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents mtxtDataNascimentoSocio As MaskedTextBox
    Friend WithEvents mtxtContatoSocio As MaskedTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbIDAgregado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnPesquisarAgregado As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents mtxtContatoAgregado As MaskedTextBox
    Friend WithEvents mtxtDataNascimentoAgregado As MaskedTextBox
    Friend WithEvents txtNomeAgregado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGravarAgregado As Button
    Friend WithEvents mtxtNIFSocio As MaskedTextBox
    Friend WithEvents mtxtNIFAgregado As MaskedTextBox
End Class
