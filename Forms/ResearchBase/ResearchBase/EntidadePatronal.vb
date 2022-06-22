Public Class EntidadePatronal
    Private Sub EntidadePatronal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.PopulateList(DataGridView1, "SELECT * FROM EntPatronal")
        UpdateGrid()
    End Sub

    Public Sub UpdateGrid()
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Dim dict As New Dictionary(Of String, Object) From {
                    {"@Nome", row.Cells("Nome").Value},
                    {"@Endereco", row.Cells("Endereco").Value},
                    {"@IBAN", row.Cells("IBAN").Value},
                    {"@NIF", row.Cells("NIF").Value},
                    {"@Num_telefone", row.Cells("Num_telefone").Value},
                    {"@Tipo_EntPatronal", row.Cells("Tipo_EntPatronal").Value}
                }

            Dim l = dict.Keys.ToArray

            For Each key As String In l
                If IsDBNull(dict(key)) Then
                    dict(key) = ""
                End If
            Next

            nome.Text = dict("@Nome")
            endereco.Text = dict("@Endereco")
            IBAN.Text = dict("@IBAN")
            NIF.Text = dict("@NIF")
            telefone.Text = dict("@Num_telefone")
            Tipo.Text = dict("@Tipo_EntPatronal")
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        UpdateGrid()
    End Sub

    Public Sub clearForm()
        nome.Text = ""
        endereco.Text = ""
        IBAN.Text = ""
        NIF.Text = ""
        telefone.Text = ""
        Tipo.Text = ""
    End Sub

    Private Sub Adicionar_Click(sender As Object, e As EventArgs) Handles Adicionar.Click
        clearForm()
        nome.Enabled = True
        endereco.Enabled = True
        IBAN.Enabled = True
        NIF.Enabled = True
        telefone.Enabled = True
        Tipo.Enabled = True

        Adicionar.Visible = False
        Estatisticas.Visible = False

        Confirmar.Visible = True
        Cancelar.Visible = True
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Confirmar.Visible = False
        Cancelar.Visible = False

        Adicionar.Visible = True
        Estatisticas.Visible = True

        nome.Enabled = False
        endereco.Enabled = False
        IBAN.Enabled = False
        NIF.Enabled = False
        telefone.Enabled = False
        Tipo.Enabled = False

        UpdateGrid()
    End Sub

    Private Sub Confirmar_Click(sender As Object, e As EventArgs) Handles Confirmar.Click
        Dim status As Int16

        Dim dict As New Dictionary(Of String, Object) From {
            {"@Nome", nome.Text},
            {"@Endereco", endereco.Text},
            {"@IBAN", IBAN.Text},
            {"@NIF", NIF.Text},
            {"@Num_telefone", telefone.Text},
            {"@Tipo_EntPatronal", Tipo.Text},
            {"@status", 1}
        }

        Dim l = dict.Keys.ToArray

        For Each key As String In l
            If dict(key) Is "" Then
                dict(key) = Nothing
            End If
        Next

        status = Main.CallSP("addEntPatronal", dict, 2)

        If status = -1 Then
            MessageBox.Show("ERRO: É necessário Nome")
        Else
            Confirmar.Visible = False
            Cancelar.Visible = False

            Adicionar.Visible = True
            Estatisticas.Visible = True

            nome.Enabled = False
            endereco.Enabled = False
            IBAN.Enabled = False
            NIF.Enabled = False
            telefone.Enabled = False
            Tipo.Enabled = False

            Main.PopulateList(DataGridView1, "SELECT * FROM EntPatronal")
            UpdateGrid()
        End If
    End Sub

    Private Sub Estatisticas_Click(sender As Object, e As EventArgs) Handles Estatisticas.Click
        Dim Form_EntPatronalStats As New EntPatronalStats
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Form_EntPatronalStats.nome = row.Cells("Nome").Value
            Form_EntPatronalStats.ID = row.Cells("Num_Registo").Value
        Next

        Form_EntPatronalStats.Show()
    End Sub

    Private Sub Pesquisa_TextChanged(sender As Object, e As EventArgs) Handles Pesquisa.TextChanged
        Dim dict As New Dictionary(Of String, Object) From {
                    {"@Nome", Pesquisa.Text}
                }
        Main.PopulateListSP(DataGridView1, "searchEntPatronal", dict)
        UpdateGrid()
    End Sub
End Class