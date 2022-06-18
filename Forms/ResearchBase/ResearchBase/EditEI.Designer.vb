<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditEI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tipo_EC = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.Num_Tomas = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(521, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tipo_EC
        '
        Me.Tipo_EC.FormattingEnabled = True
        Me.Tipo_EC.Items.AddRange(New Object() {"1) Bioequivalência", "2) Interação Medicamentosa"})
        Me.Tipo_EC.Location = New System.Drawing.Point(74, 182)
        Me.Tipo_EC.Margin = New System.Windows.Forms.Padding(2)
        Me.Tipo_EC.Name = "Tipo_EC"
        Me.Tipo_EC.Size = New System.Drawing.Size(92, 21)
        Me.Tipo_EC.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(27, 185)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Tipo:"
        '
        'CC_Inv
        '
        Me.CC_Inv.Location = New System.Drawing.Point(124, 59)
        Me.CC_Inv.Margin = New System.Windows.Forms.Padding(2)
        Me.CC_Inv.Name = "CC_Inv"
        Me.CC_Inv.Size = New System.Drawing.Size(76, 20)
        Me.CC_Inv.TabIndex = 52
        '
        'Renum
        '
        Me.Renum.Location = New System.Drawing.Point(534, 213)
        Me.Renum.Margin = New System.Windows.Forms.Padding(2)
        Me.Renum.Name = "Renum"
        Me.Renum.Size = New System.Drawing.Size(62, 20)
        Me.Renum.TabIndex = 51
        '
        'Num_Vagas
        '
        Me.Num_Vagas.Location = New System.Drawing.Point(534, 178)
        Me.Num_Vagas.Margin = New System.Windows.Forms.Padding(2)
        Me.Num_Vagas.Name = "Num_Vagas"
        Me.Num_Vagas.Size = New System.Drawing.Size(62, 20)
        Me.Num_Vagas.TabIndex = 50
        '
        'Titulo
        '
        Me.Titulo.Location = New System.Drawing.Point(62, 18)
        Me.Titulo.Margin = New System.Windows.Forms.Padding(2)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(286, 20)
        Me.Titulo.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "CC do Investigador:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(451, 216)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Remuneração:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(451, 181)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Número Vagas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Título:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(451, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Código Estudo:"
        '
        'CodigoLabel
        '
        Me.CodigoLabel.Location = New System.Drawing.Point(534, 18)
        Me.CodigoLabel.Margin = New System.Windows.Forms.Padding(2)
        Me.CodigoLabel.Name = "CodigoLabel"
        Me.CodigoLabel.Size = New System.Drawing.Size(62, 20)
        Me.CodigoLabel.TabIndex = 43
        '
        'Num_Tomas
        '
        Me.Num_Tomas.Location = New System.Drawing.Point(124, 217)
        Me.Num_Tomas.Margin = New System.Windows.Forms.Padding(2)
        Me.Num_Tomas.Name = "Num_Tomas"
        Me.Num_Tomas.Size = New System.Drawing.Size(40, 20)
        Me.Num_Tomas.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 220)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Número de Vagas:"
        '
        'EditEI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 310)
        Me.Controls.Add(Me.Num_Tomas)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tipo_EC)
        Me.Controls.Add(Me.Label16)
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
        Me.Name = "EditEI"
        Me.Text = "EditEI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Tipo_EC As ComboBox
    Friend WithEvents Label16 As Label
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
    Friend WithEvents Num_Tomas As TextBox
    Friend WithEvents Label15 As Label
End Class
