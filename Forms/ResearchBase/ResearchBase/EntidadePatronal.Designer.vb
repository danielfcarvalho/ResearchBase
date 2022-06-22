<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntidadePatronal
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
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Confirmar = New System.Windows.Forms.Button()
        Me.Estatisticas = New System.Windows.Forms.Button()
        Me.Adicionar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nome = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.endereco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.telefone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IBAN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NIF = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tipo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Pesquisa = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(1032, 450)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(110, 61)
        Me.Cancelar.TabIndex = 48
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        Me.Cancelar.Visible = False
        '
        'Confirmar
        '
        Me.Confirmar.Location = New System.Drawing.Point(870, 450)
        Me.Confirmar.Name = "Confirmar"
        Me.Confirmar.Size = New System.Drawing.Size(110, 61)
        Me.Confirmar.TabIndex = 47
        Me.Confirmar.Text = "Confirmar"
        Me.Confirmar.UseVisualStyleBackColor = True
        Me.Confirmar.Visible = False
        '
        'Estatisticas
        '
        Me.Estatisticas.Location = New System.Drawing.Point(1032, 541)
        Me.Estatisticas.Name = "Estatisticas"
        Me.Estatisticas.Size = New System.Drawing.Size(110, 61)
        Me.Estatisticas.TabIndex = 28
        Me.Estatisticas.Text = "Estatísticas"
        Me.Estatisticas.UseVisualStyleBackColor = True
        '
        'Adicionar
        '
        Me.Adicionar.Location = New System.Drawing.Point(870, 541)
        Me.Adicionar.Name = "Adicionar"
        Me.Adicionar.Size = New System.Drawing.Size(110, 61)
        Me.Adicionar.TabIndex = 26
        Me.Adicionar.Text = "Adicionar"
        Me.Adicionar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 68)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(705, 577)
        Me.DataGridView1.TabIndex = 25
        '
        'nome
        '
        Me.nome.Enabled = False
        Me.nome.Location = New System.Drawing.Point(855, 86)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(345, 22)
        Me.nome.TabIndex = 50
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(769, 83)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 25)
        Me.label1.TabIndex = 49
        Me.label1.Text = "Nome:"
        '
        'endereco
        '
        Me.endereco.Enabled = False
        Me.endereco.Location = New System.Drawing.Point(881, 142)
        Me.endereco.Name = "endereco"
        Me.endereco.Size = New System.Drawing.Size(319, 22)
        Me.endereco.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(769, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Endereço:"
        '
        'telefone
        '
        Me.telefone.Enabled = False
        Me.telefone.Location = New System.Drawing.Point(870, 204)
        Me.telefone.Name = "telefone"
        Me.telefone.Size = New System.Drawing.Size(330, 22)
        Me.telefone.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(769, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Telefone:"
        '
        'IBAN
        '
        Me.IBAN.Enabled = False
        Me.IBAN.Location = New System.Drawing.Point(839, 262)
        Me.IBAN.Name = "IBAN"
        Me.IBAN.Size = New System.Drawing.Size(361, 22)
        Me.IBAN.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(769, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 25)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "IBAN:"
        '
        'NIF
        '
        Me.NIF.Enabled = False
        Me.NIF.Location = New System.Drawing.Point(824, 316)
        Me.NIF.Name = "NIF"
        Me.NIF.Size = New System.Drawing.Size(376, 22)
        Me.NIF.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(769, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 25)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "NIF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(769, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 25)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Tipo:"
        '
        'Tipo
        '
        Me.Tipo.Enabled = False
        Me.Tipo.FormattingEnabled = True
        Me.Tipo.Items.AddRange(New Object() {"1", "2"})
        Me.Tipo.Location = New System.Drawing.Point(832, 367)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(121, 24)
        Me.Tipo.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(311, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 25)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Pesquisar por Nome:"
        '
        'Pesquisa
        '
        Me.Pesquisa.Location = New System.Drawing.Point(515, 29)
        Me.Pesquisa.Name = "Pesquisa"
        Me.Pesquisa.Size = New System.Drawing.Size(227, 22)
        Me.Pesquisa.TabIndex = 61
        '
        'EntidadePatronal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Pesquisa)
        Me.Controls.Add(Me.Tipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NIF)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IBAN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.telefone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.endereco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Confirmar)
        Me.Controls.Add(Me.Estatisticas)
        Me.Controls.Add(Me.Adicionar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "EntidadePatronal"
        Me.Text = "EntidadePatronal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancelar As Button
    Friend WithEvents Confirmar As Button
    Friend WithEvents Estatisticas As Button
    Friend WithEvents Adicionar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nome As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents endereco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents telefone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IBAN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NIF As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Tipo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Pesquisa As TextBox
End Class
