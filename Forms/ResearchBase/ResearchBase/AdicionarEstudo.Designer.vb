<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdicionarEstudo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Selecionar_Estudo = New System.Windows.Forms.TabControl()
        Me.EC = New System.Windows.Forms.TabPage()
        Me.Tipo_EC = New System.Windows.Forms.ComboBox()
        Me.Num_Tomas = New System.Windows.Forms.TextBox()
        Me.Cod_Proc = New System.Windows.Forms.TextBox()
        Me.Cod_CEIC = New System.Windows.Forms.TextBox()
        Me.Cod_Inf = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Num_Sessoes = New System.Windows.Forms.TextBox()
        Me.Tipo_EI = New System.Windows.Forms.ComboBox()
        Me.EI = New System.Windows.Forms.TabPage()
        Me.CC_Inv = New System.Windows.Forms.TextBox()
        Me.Renum = New System.Windows.Forms.TextBox()
        Me.Num_Vagas = New System.Windows.Forms.TextBox()
        Me.Titulo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Codigo = New System.Windows.Forms.TextBox()
        Me.Follow_up = New System.Windows.Forms.ComboBox()
        Me.Selecionar_Estudo.SuspendLayout()
        Me.EC.SuspendLayout()
        Me.EI.SuspendLayout()
        Me.SuspendLayout()
        '
        'Selecionar_Estudo
        '
        Me.Selecionar_Estudo.Controls.Add(Me.EC)
        Me.Selecionar_Estudo.Controls.Add(Me.EI)
        Me.Selecionar_Estudo.Location = New System.Drawing.Point(0, 176)
        Me.Selecionar_Estudo.Name = "Selecionar_Estudo"
        Me.Selecionar_Estudo.SelectedIndex = 0
        Me.Selecionar_Estudo.Size = New System.Drawing.Size(801, 226)
        Me.Selecionar_Estudo.TabIndex = 2
        '
        'EC
        '
        Me.EC.Controls.Add(Me.Follow_up)
        Me.EC.Controls.Add(Me.Tipo_EC)
        Me.EC.Controls.Add(Me.Num_Tomas)
        Me.EC.Controls.Add(Me.Cod_Proc)
        Me.EC.Controls.Add(Me.Cod_CEIC)
        Me.EC.Controls.Add(Me.Cod_Inf)
        Me.EC.Controls.Add(Me.Label16)
        Me.EC.Controls.Add(Me.Label15)
        Me.EC.Controls.Add(Me.Label14)
        Me.EC.Controls.Add(Me.Label13)
        Me.EC.Controls.Add(Me.Label12)
        Me.EC.Controls.Add(Me.Label11)
        Me.EC.Location = New System.Drawing.Point(4, 25)
        Me.EC.Name = "EC"
        Me.EC.Padding = New System.Windows.Forms.Padding(3)
        Me.EC.Size = New System.Drawing.Size(793, 197)
        Me.EC.TabIndex = 0
        Me.EC.Text = "Ensaio Clínico"
        Me.EC.UseVisualStyleBackColor = True
        '
        'Tipo_EC
        '
        Me.Tipo_EC.FormattingEnabled = True
        Me.Tipo_EC.Items.AddRange(New Object() {"1) Bioequivalência", "2) Interação Medicamentosa"})
        Me.Tipo_EC.Location = New System.Drawing.Point(55, 14)
        Me.Tipo_EC.Name = "Tipo_EC"
        Me.Tipo_EC.Size = New System.Drawing.Size(121, 24)
        Me.Tipo_EC.TabIndex = 20
        '
        'Num_Tomas
        '
        Me.Num_Tomas.Location = New System.Drawing.Point(390, 14)
        Me.Num_Tomas.Name = "Num_Tomas"
        Me.Num_Tomas.Size = New System.Drawing.Size(100, 22)
        Me.Num_Tomas.TabIndex = 19
        '
        'Cod_Proc
        '
        Me.Cod_Proc.Location = New System.Drawing.Point(655, 149)
        Me.Cod_Proc.Name = "Cod_Proc"
        Me.Cod_Proc.Size = New System.Drawing.Size(100, 22)
        Me.Cod_Proc.TabIndex = 18
        '
        'Cod_CEIC
        '
        Me.Cod_CEIC.Location = New System.Drawing.Point(382, 149)
        Me.Cod_CEIC.Name = "Cod_CEIC"
        Me.Cod_CEIC.Size = New System.Drawing.Size(100, 22)
        Me.Cod_CEIC.TabIndex = 17
        '
        'Cod_Inf
        '
        Me.Cod_Inf.Location = New System.Drawing.Point(136, 149)
        Me.Cod_Inf.Name = "Cod_Inf"
        Me.Cod_Inf.Size = New System.Drawing.Size(100, 22)
        Me.Cod_Inf.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Tipo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(280, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Número Tomas:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Follow Up:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(534, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Código Protocolo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(289, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Código CEIC:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Código Infarmed:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(645, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Adicionar Estudo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(490, 408)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Limpar Formulário"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(292, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 16)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Número Sessões:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 16)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Tipo:"
        '
        'Num_Sessoes
        '
        Me.Num_Sessoes.Location = New System.Drawing.Point(413, 19)
        Me.Num_Sessoes.Name = "Num_Sessoes"
        Me.Num_Sessoes.Size = New System.Drawing.Size(100, 22)
        Me.Num_Sessoes.TabIndex = 23
        '
        'Tipo_EI
        '
        Me.Tipo_EI.FormattingEnabled = True
        Me.Tipo_EI.Items.AddRange(New Object() {"1) Questionário", "2) Estudo de Grupo", "3) User Testing", "4) Simulação"})
        Me.Tipo_EI.Location = New System.Drawing.Point(67, 19)
        Me.Tipo_EI.Name = "Tipo_EI"
        Me.Tipo_EI.Size = New System.Drawing.Size(121, 24)
        Me.Tipo_EI.TabIndex = 24
        '
        'EI
        '
        Me.EI.Controls.Add(Me.Tipo_EI)
        Me.EI.Controls.Add(Me.Num_Sessoes)
        Me.EI.Controls.Add(Me.Label17)
        Me.EI.Controls.Add(Me.Label18)
        Me.EI.Location = New System.Drawing.Point(4, 25)
        Me.EI.Name = "EI"
        Me.EI.Padding = New System.Windows.Forms.Padding(3)
        Me.EI.Size = New System.Drawing.Size(793, 197)
        Me.EI.TabIndex = 1
        Me.EI.Text = "Estudo Investigação"
        Me.EI.UseVisualStyleBackColor = True
        '
        'CC_Inv
        '
        Me.CC_Inv.Location = New System.Drawing.Point(157, 127)
        Me.CC_Inv.Name = "CC_Inv"
        Me.CC_Inv.Size = New System.Drawing.Size(100, 22)
        Me.CC_Inv.TabIndex = 19
        '
        'Renum
        '
        Me.Renum.Location = New System.Drawing.Point(398, 127)
        Me.Renum.Name = "Renum"
        Me.Renum.Size = New System.Drawing.Size(100, 22)
        Me.Renum.TabIndex = 18
        '
        'Num_Vagas
        '
        Me.Num_Vagas.Location = New System.Drawing.Point(657, 127)
        Me.Num_Vagas.Name = "Num_Vagas"
        Me.Num_Vagas.Size = New System.Drawing.Size(100, 22)
        Me.Num_Vagas.TabIndex = 17
        '
        'Titulo
        '
        Me.Titulo.Location = New System.Drawing.Point(330, 44)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(380, 22)
        Me.Titulo.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "CC do Investigador:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Remuneração:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(550, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Número Vagas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Título:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Código Estudo:"
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(137, 44)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(100, 22)
        Me.Codigo.TabIndex = 10
        '
        'Follow_up
        '
        Me.Follow_up.AutoCompleteCustomSource.AddRange(New String() {"Yes", "No"})
        Me.Follow_up.FormattingEnabled = True
        Me.Follow_up.Location = New System.Drawing.Point(87, 87)
        Me.Follow_up.Name = "Follow_up"
        Me.Follow_up.Size = New System.Drawing.Size(121, 24)
        Me.Follow_up.TabIndex = 21
        '
        'AdicionarEstudo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CC_Inv)
        Me.Controls.Add(Me.Renum)
        Me.Controls.Add(Me.Num_Vagas)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Codigo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Selecionar_Estudo)
        Me.Name = "AdicionarEstudo"
        Me.Text = "AdicionarEstudo"
        Me.Selecionar_Estudo.ResumeLayout(False)
        Me.EC.ResumeLayout(False)
        Me.EC.PerformLayout()
        Me.EI.ResumeLayout(False)
        Me.EI.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Selecionar_Estudo As TabControl
    Friend WithEvents EC As TabPage
    Friend WithEvents Cod_Proc As TextBox
    Friend WithEvents Cod_CEIC As TextBox
    Friend WithEvents Cod_Inf As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Tipo_EC As ComboBox
    Friend WithEvents Num_Tomas As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents EI As TabPage
    Friend WithEvents Tipo_EI As ComboBox
    Friend WithEvents Num_Sessoes As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents CC_Inv As TextBox
    Friend WithEvents Renum As TextBox
    Friend WithEvents Num_Vagas As TextBox
    Friend WithEvents Titulo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Codigo As TextBox
    Friend WithEvents Follow_up As ComboBox
End Class
