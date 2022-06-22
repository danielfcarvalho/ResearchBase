<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvestigadorStats
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomeLabel = New System.Windows.Forms.Label()
        Me.EstudosInvLabel = New System.Windows.Forms.Label()
        Me.NumEstudosLabel = New System.Windows.Forms.Label()
        Me.InstitutoLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(776, 233)
        Me.DataGridView1.TabIndex = 0
        '
        'NomeLabel
        '
        Me.NomeLabel.AutoSize = True
        Me.NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeLabel.Location = New System.Drawing.Point(12, 9)
        Me.NomeLabel.Name = "NomeLabel"
        Me.NomeLabel.Size = New System.Drawing.Size(72, 25)
        Me.NomeLabel.TabIndex = 15
        Me.NomeLabel.Text = "Nome"
        '
        'EstudosInvLabel
        '
        Me.EstudosInvLabel.AutoSize = True
        Me.EstudosInvLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstudosInvLabel.Location = New System.Drawing.Point(307, 140)
        Me.EstudosInvLabel.Name = "EstudosInvLabel"
        Me.EstudosInvLabel.Size = New System.Drawing.Size(187, 20)
        Me.EstudosInvLabel.TabIndex = 16
        Me.EstudosInvLabel.Text = "Estudos Coordenados"
        '
        'NumEstudosLabel
        '
        Me.NumEstudosLabel.AutoSize = True
        Me.NumEstudosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumEstudosLabel.Location = New System.Drawing.Point(353, 32)
        Me.NumEstudosLabel.Name = "NumEstudosLabel"
        Me.NumEstudosLabel.Size = New System.Drawing.Size(99, 108)
        Me.NumEstudosLabel.TabIndex = 17
        Me.NumEstudosLabel.Text = "0"
        '
        'InstitutoLabel
        '
        Me.InstitutoLabel.AutoSize = True
        Me.InstitutoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstitutoLabel.Location = New System.Drawing.Point(13, 34)
        Me.InstitutoLabel.Name = "InstitutoLabel"
        Me.InstitutoLabel.Size = New System.Drawing.Size(67, 20)
        Me.InstitutoLabel.TabIndex = 18
        Me.InstitutoLabel.Text = "Instituto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(702, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 26)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Voltar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InvestigadorStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.InstitutoLabel)
        Me.Controls.Add(Me.NumEstudosLabel)
        Me.Controls.Add(Me.EstudosInvLabel)
        Me.Controls.Add(Me.NomeLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "InvestigadorStats"
        Me.Text = "InvestigadorStats"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NomeLabel As Label
    Friend WithEvents EstudosInvLabel As Label
    Friend WithEvents NumEstudosLabel As Label
    Friend WithEvents InstitutoLabel As Label
    Friend WithEvents Button1 As Button
End Class
