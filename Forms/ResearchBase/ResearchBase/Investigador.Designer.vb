<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Investigador
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
        Me.Add = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Stats = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CCTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EPIDTextBox = New System.Windows.Forms.TextBox()
        Me.EPNomeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(536, 488)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(91, 47)
        Me.Add.TabIndex = 1
        Me.Add.Text = "Adicionar"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.Location = New System.Drawing.Point(678, 488)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(91, 47)
        Me.Edit.TabIndex = 2
        Me.Edit.Text = "Editar"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Stats
        '
        Me.Stats.Location = New System.Drawing.Point(820, 488)
        Me.Stats.Name = "Stats"
        Me.Stats.Size = New System.Drawing.Size(91, 47)
        Me.Stats.TabIndex = 3
        Me.Stats.Text = "Estatísticas"
        Me.Stats.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(516, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(350, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Informação sobre o Investigador"
        '
        'CCTextBox
        '
        Me.CCTextBox.Enabled = False
        Me.CCTextBox.Location = New System.Drawing.Point(598, 59)
        Me.CCTextBox.Name = "CCTextBox"
        Me.CCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CCTextBox.TabIndex = 15
        '
        'NomeTextBox
        '
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(598, 99)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(259, 20)
        Me.NomeTextBox.TabIndex = 16
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(598, 141)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(259, 20)
        Me.EmailTextBox.TabIndex = 17
        '
        'EPIDTextBox
        '
        Me.EPIDTextBox.Enabled = False
        Me.EPIDTextBox.Location = New System.Drawing.Point(598, 208)
        Me.EPIDTextBox.Name = "EPIDTextBox"
        Me.EPIDTextBox.Size = New System.Drawing.Size(37, 20)
        Me.EPIDTextBox.TabIndex = 18
        '
        'EPNomeTextBox
        '
        Me.EPNomeTextBox.Enabled = False
        Me.EPNomeTextBox.Location = New System.Drawing.Point(641, 208)
        Me.EPNomeTextBox.Name = "EPNomeTextBox"
        Me.EPNomeTextBox.Size = New System.Drawing.Size(216, 20)
        Me.EPNomeTextBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(532, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "CC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(532, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(532, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(532, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Entidade Patronal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Pesquisar por Nome:"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(226, 11)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(259, 20)
        Me.SearchTextBox.TabIndex = 26
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 37)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(473, 498)
        Me.DataGridView1.TabIndex = 27
        '
        'Confirm
        '
        Me.Confirm.Location = New System.Drawing.Point(607, 488)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(91, 47)
        Me.Confirm.TabIndex = 28
        Me.Confirm.Text = "Confirmar"
        Me.Confirm.UseVisualStyleBackColor = True
        Me.Confirm.Visible = False
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(748, 488)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(91, 47)
        Me.Cancel.TabIndex = 29
        Me.Cancel.Text = "Cancelar"
        Me.Cancel.UseVisualStyleBackColor = True
        Me.Cancel.Visible = False
        '
        'Investigador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 547)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EPNomeTextBox)
        Me.Controls.Add(Me.EPIDTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.CCTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Stats)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Add)
        Me.Name = "Investigador"
        Me.Text = "Investigador"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Add As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Stats As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CCTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EPIDTextBox As TextBox
    Friend WithEvents EPNomeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Confirm As Button
    Friend WithEvents Cancel As Button
End Class
