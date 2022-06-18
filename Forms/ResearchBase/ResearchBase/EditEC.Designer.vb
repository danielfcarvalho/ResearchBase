<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEC
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
        Me.CC_Inv = New System.Windows.Forms.TextBox()
        Me.Renum = New System.Windows.Forms.TextBox()
        Me.Num_Vagas = New System.Windows.Forms.TextBox()
        Me.Titulo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodigoLabel = New System.Windows.Forms.TextBox()
        Me.Follow_up = New System.Windows.Forms.ComboBox()
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
        Me.SuspendLayout()
        '
        'CC_Inv
        '
        Me.CC_Inv.Location = New System.Drawing.Point(119, 58)
        Me.CC_Inv.Margin = New System.Windows.Forms.Padding(2)
        Me.CC_Inv.Name = "CC_Inv"
        Me.CC_Inv.Size = New System.Drawing.Size(76, 20)
        Me.CC_Inv.TabIndex = 29
        '
        'Renum
        '
        Me.Renum.Location = New System.Drawing.Point(529, 212)
        Me.Renum.Margin = New System.Windows.Forms.Padding(2)
        Me.Renum.Name = "Renum"
        Me.Renum.Size = New System.Drawing.Size(62, 20)
        Me.Renum.TabIndex = 28
        '
        'Num_Vagas
        '
        Me.Num_Vagas.Location = New System.Drawing.Point(529, 177)
        Me.Num_Vagas.Margin = New System.Windows.Forms.Padding(2)
        Me.Num_Vagas.Name = "Num_Vagas"
        Me.Num_Vagas.Size = New System.Drawing.Size(62, 20)
        Me.Num_Vagas.TabIndex = 27
        '
        'Titulo
        '
        Me.Titulo.Location = New System.Drawing.Point(57, 17)
        Me.Titulo.Margin = New System.Windows.Forms.Padding(2)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(286, 20)
        Me.Titulo.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 61)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "CC do Investigador:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(446, 215)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Remuneração:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(446, 180)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Número Vagas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Título:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(446, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Código Estudo:"
        '
        'CodigoLabel
        '
        Me.CodigoLabel.Location = New System.Drawing.Point(529, 17)
        Me.CodigoLabel.Margin = New System.Windows.Forms.Padding(2)
        Me.CodigoLabel.Name = "CodigoLabel"
        Me.CodigoLabel.Size = New System.Drawing.Size(62, 20)
        Me.CodigoLabel.TabIndex = 20
        '
        'Follow_up
        '
        Me.Follow_up.AutoCompleteCustomSource.AddRange(New String() {"Yes", "No"})
        Me.Follow_up.FormattingEnabled = True
        Me.Follow_up.Items.AddRange(New Object() {"No", "Yes"})
        Me.Follow_up.Location = New System.Drawing.Point(83, 225)
        Me.Follow_up.Margin = New System.Windows.Forms.Padding(2)
        Me.Follow_up.Name = "Follow_up"
        Me.Follow_up.Size = New System.Drawing.Size(63, 21)
        Me.Follow_up.TabIndex = 41
        '
        'Tipo_EC
        '
        Me.Tipo_EC.FormattingEnabled = True
        Me.Tipo_EC.Items.AddRange(New Object() {"1) Bioequivalência", "2) Interação Medicamentosa"})
        Me.Tipo_EC.Location = New System.Drawing.Point(69, 181)
        Me.Tipo_EC.Margin = New System.Windows.Forms.Padding(2)
        Me.Tipo_EC.Name = "Tipo_EC"
        Me.Tipo_EC.Size = New System.Drawing.Size(92, 21)
        Me.Tipo_EC.TabIndex = 40
        '
        'Num_Tomas
        '
        Me.Num_Tomas.Location = New System.Drawing.Point(285, 181)
        Me.Num_Tomas.Margin = New System.Windows.Forms.Padding(2)
        Me.Num_Tomas.Name = "Num_Tomas"
        Me.Num_Tomas.Size = New System.Drawing.Size(40, 20)
        Me.Num_Tomas.TabIndex = 39
        '
        'Cod_Proc
        '
        Me.Cod_Proc.Location = New System.Drawing.Point(529, 114)
        Me.Cod_Proc.Margin = New System.Windows.Forms.Padding(2)
        Me.Cod_Proc.Name = "Cod_Proc"
        Me.Cod_Proc.Size = New System.Drawing.Size(62, 20)
        Me.Cod_Proc.TabIndex = 38
        '
        'Cod_CEIC
        '
        Me.Cod_CEIC.Location = New System.Drawing.Point(529, 81)
        Me.Cod_CEIC.Margin = New System.Windows.Forms.Padding(2)
        Me.Cod_CEIC.Name = "Cod_CEIC"
        Me.Cod_CEIC.Size = New System.Drawing.Size(62, 20)
        Me.Cod_CEIC.TabIndex = 37
        '
        'Cod_Inf
        '
        Me.Cod_Inf.Location = New System.Drawing.Point(529, 47)
        Me.Cod_Inf.Margin = New System.Windows.Forms.Padding(2)
        Me.Cod_Inf.Name = "Cod_Inf"
        Me.Cod_Inf.Size = New System.Drawing.Size(62, 20)
        Me.Cod_Inf.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 184)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Tipo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(199, 184)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Número Tomas:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 233)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Follow Up:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(434, 117)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Código Protocolo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(455, 84)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Código CEIC:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(438, 50)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Código Infarmed:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(512, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 311)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Follow_up)
        Me.Controls.Add(Me.Tipo_EC)
        Me.Controls.Add(Me.Num_Tomas)
        Me.Controls.Add(Me.Cod_Proc)
        Me.Controls.Add(Me.Cod_CEIC)
        Me.Controls.Add(Me.Cod_Inf)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CC_Inv)
        Me.Controls.Add(Me.Renum)
        Me.Controls.Add(Me.Num_Vagas)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CodigoLabel)
        Me.Name = "EditEC"
        Me.Text = "EditEC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CC_Inv As TextBox
    Friend WithEvents Renum As TextBox
    Friend WithEvents Num_Vagas As TextBox
    Friend WithEvents Titulo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CodigoLabel As TextBox
    Friend WithEvents Follow_up As ComboBox
    Friend WithEvents Tipo_EC As ComboBox
    Friend WithEvents Num_Tomas As TextBox
    Friend WithEvents Cod_Proc As TextBox
    Friend WithEvents Cod_CEIC As TextBox
    Friend WithEvents Cod_Inf As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
End Class
