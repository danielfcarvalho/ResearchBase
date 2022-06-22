<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Participantes
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CC = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.IBAN = New System.Windows.Forms.TextBox()
        Me.NIF = New System.Windows.Forms.TextBox()
        Me.Localidade = New System.Windows.Forms.TextBox()
        Me.Data_Nasc = New System.Windows.Forms.DateTimePicker()
        Me.Cod_Analises = New System.Windows.Forms.TextBox()
        Me.Genero = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Confirmar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 70)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(705, 577)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(771, 586)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 61)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(943, 586)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 61)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1113, 586)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 61)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Estatísticas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(766, 95)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(53, 25)
        Me.label1.TabIndex = 4
        Me.label1.Text = "CC: "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(766, 153)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 25)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(766, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "IBAN:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(766, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NIF:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(766, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Data Nascimento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(766, 409)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Género:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(768, 463)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Localidade:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(766, 513)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Código Analises:"
        '
        'CC
        '
        Me.CC.Enabled = False
        Me.CC.Location = New System.Drawing.Point(820, 99)
        Me.CC.Name = "CC"
        Me.CC.Size = New System.Drawing.Size(319, 22)
        Me.CC.TabIndex = 12
        '
        'Email
        '
        Me.Email.Enabled = False
        Me.Email.Location = New System.Drawing.Point(838, 157)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(301, 22)
        Me.Email.TabIndex = 13
        '
        'IBAN
        '
        Me.IBAN.Enabled = False
        Me.IBAN.Location = New System.Drawing.Point(838, 222)
        Me.IBAN.Name = "IBAN"
        Me.IBAN.Size = New System.Drawing.Size(301, 22)
        Me.IBAN.TabIndex = 14
        '
        'NIF
        '
        Me.NIF.Enabled = False
        Me.NIF.Location = New System.Drawing.Point(821, 285)
        Me.NIF.Name = "NIF"
        Me.NIF.Size = New System.Drawing.Size(318, 22)
        Me.NIF.TabIndex = 15
        '
        'Localidade
        '
        Me.Localidade.Enabled = False
        Me.Localidade.Location = New System.Drawing.Point(887, 467)
        Me.Localidade.Name = "Localidade"
        Me.Localidade.Size = New System.Drawing.Size(252, 22)
        Me.Localidade.TabIndex = 17
        '
        'Data_Nasc
        '
        Me.Data_Nasc.Enabled = False
        Me.Data_Nasc.Location = New System.Drawing.Point(943, 344)
        Me.Data_Nasc.Name = "Data_Nasc"
        Me.Data_Nasc.Size = New System.Drawing.Size(200, 22)
        Me.Data_Nasc.TabIndex = 18
        '
        'Cod_Analises
        '
        Me.Cod_Analises.Enabled = False
        Me.Cod_Analises.Location = New System.Drawing.Point(939, 517)
        Me.Cod_Analises.Name = "Cod_Analises"
        Me.Cod_Analises.Size = New System.Drawing.Size(200, 22)
        Me.Cod_Analises.TabIndex = 19
        '
        'Genero
        '
        Me.Genero.Enabled = False
        Me.Genero.FormattingEnabled = True
        Me.Genero.Items.AddRange(New Object() {"M", "F", "O"})
        Me.Genero.Location = New System.Drawing.Point(852, 413)
        Me.Genero.Name = "Genero"
        Me.Genero.Size = New System.Drawing.Size(194, 24)
        Me.Genero.TabIndex = 20
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(512, 32)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(227, 22)
        Me.TextBox7.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(333, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Pesquisar por CC:"
        '
        'Confirmar
        '
        Me.Confirmar.Location = New System.Drawing.Point(865, 586)
        Me.Confirmar.Name = "Confirmar"
        Me.Confirmar.Size = New System.Drawing.Size(110, 61)
        Me.Confirmar.TabIndex = 23
        Me.Confirmar.Text = "Confirmar"
        Me.Confirmar.UseVisualStyleBackColor = True
        Me.Confirmar.Visible = False
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(1029, 586)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(110, 61)
        Me.Cancelar.TabIndex = 24
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        Me.Cancelar.Visible = False
        '
        'Participantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Confirmar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Genero)
        Me.Controls.Add(Me.Cod_Analises)
        Me.Controls.Add(Me.Data_Nasc)
        Me.Controls.Add(Me.Localidade)
        Me.Controls.Add(Me.NIF)
        Me.Controls.Add(Me.IBAN)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.CC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Participantes"
        Me.Text = "Participantes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CC As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents IBAN As TextBox
    Friend WithEvents NIF As TextBox
    Friend WithEvents Localidade As TextBox
    Friend WithEvents Data_Nasc As DateTimePicker
    Friend WithEvents Cod_Analises As TextBox
    Friend WithEvents Genero As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Confirmar As Button
    Friend WithEvents Cancelar As Button
End Class
