<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntPatronalStats
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
        Me.Entidade = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pagamentos = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.num_estudos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Entidade
        '
        Me.Entidade.AutoSize = True
        Me.Entidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Entidade.Location = New System.Drawing.Point(28, 29)
        Me.Entidade.Name = "Entidade"
        Me.Entidade.Size = New System.Drawing.Size(141, 36)
        Me.Entidade.TabIndex = 3
        Me.Entidade.Text = "Entidade"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 263)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1238, 364)
        Me.DataGridView1.TabIndex = 4
        '
        'pagamentos
        '
        Me.pagamentos.AutoSize = True
        Me.pagamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagamentos.Location = New System.Drawing.Point(326, 189)
        Me.pagamentos.Name = "pagamentos"
        Me.pagamentos.Size = New System.Drawing.Size(30, 32)
        Me.pagamentos.TabIndex = 8
        Me.pagamentos.Text = "0"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(28, 189)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(292, 32)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Total de Pagamentos:"
        '
        'num_estudos
        '
        Me.num_estudos.AutoSize = True
        Me.num_estudos.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_estudos.Location = New System.Drawing.Point(305, 104)
        Me.num_estudos.Name = "num_estudos"
        Me.num_estudos.Size = New System.Drawing.Size(30, 32)
        Me.num_estudos.TabIndex = 10
        Me.num_estudos.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 32)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Número de Estudos:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1113, 635)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EntPatronalStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.num_estudos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pagamentos)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Entidade)
        Me.Name = "EntPatronalStats"
        Me.Text = "EntPatronalStats"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Entidade As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pagamentos As Label
    Friend WithEvents label4 As Label
    Friend WithEvents num_estudos As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
