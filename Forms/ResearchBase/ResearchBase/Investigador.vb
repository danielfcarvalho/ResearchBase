Public Class Investigador
    Dim operation As String
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        UpdateGrid()
    End Sub

    Private Sub Investigador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.PopulateList(DataGridView1, "SELECT * FROM Investigador")
        UpdateGrid()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        ClearForm()
        Add.Visible = False
        Edit.Visible = False
        Stats.Visible = False
        Confirm.Visible = True
        Cancel.Visible = True

        CCTextBox.Enabled = True
        NomeTextBox.Enabled = True
        EmailTextBox.Enabled = True
        EPIDTextBox.Enabled = True

        operation = "Add"
    End Sub

    Private Sub UpdateGrid()
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Dim dict As New Dictionary(Of String, Object) From {
                    {"@CC", row.Cells("CC").Value},
                    {"@Email", row.Cells("Email").Value},
                    {"@Nome", row.Cells("Nome").Value},
                    {"@EntPatronal", row.Cells("EntPatronal").Value}
                }

            Dim l = dict.Keys.ToArray

            For Each key As String In l
                If IsDBNull(dict(key)) Then
                    dict(key) = ""
                End If
            Next

            NomeTextBox.Text = dict("@Nome")
            CCTextBox.Text = dict("@CC")
            EmailTextBox.Text = dict("@Email")
            EPIDTextBox.Text = dict("@EntPatronal")

            If EPIDTextBox.Text = "" Then
                EPNomeTextBox.Text = ""
            Else
                EPNomeTextBox.Text = Main.FecthSimpleData("SELECT Nome FROM EntPatronal WHERE Num_Registo = " + row.Cells("EntPatronal").Value.ToString)
            End If

        Next
    End Sub

    Private Sub EPIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles EPIDTextBox.TextChanged
        If EPIDTextBox.Text <> "" Then
            EPNomeTextBox.Text = Main.FecthSimpleData("SELECT Nome FROM EntPatronal WHERE Num_Registo = " + EPIDTextBox.Text)
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim dict As New Dictionary(Of String, Object) From {
            {"@Nome", SearchTextBox.Text}
        }

        Main.PopulateListSP(DataGridView1, "searchInvestigador", dict)
        UpdateGrid()
    End Sub

    Private Sub ClearForm()
        NomeTextBox.Text = ""
        CCTextBox.Text = ""
        EmailTextBox.Text = ""
        EPIDTextBox.Text = ""
        EPNomeTextBox.Text = ""
    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        If operation = "Add" Then
            Dim dict As New Dictionary(Of String, Object) From {
            {"@CC", CCTextBox.Text},
            {"@Nome", NomeTextBox.Text},
            {"@Email", EmailTextBox.Text},
            {"@EntPatronal", EPIDTextBox.Text}
        }

            Dim l = dict.Keys.ToArray

            For Each key As String In l
                If dict(key) Is "" Then
                    dict(key) = Nothing
                End If
            Next

            Dim status As Integer = Main.CallSP("addInvestigador", dict, 2)

            If status = -1 Then
                MessageBox.Show("ERRO: É necessário preencher os campos de CC, Nome e E-Mail!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf status = -2 Then
                MessageBox.Show("ERRO: A Entidade Patronal deve estar inserida na Base de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Main.PopulateList(DataGridView1, "SELECT * FROM Investigador")
        ElseIf operation = "Edit" Then
            Dim dict As New Dictionary(Of String, Object) From {
                {"@CC", CCTextBox.Text},
                {"@Nome", NomeTextBox.Text},
                {"@Email", EmailTextBox.Text},
                {"@EntPatronal", EPIDTextBox.Text}
            }

            Dim l = dict.Keys.ToArray

            For Each key As String In l
                If dict(key) Is "" Then
                    dict(key) = Nothing
                End If
            Next

            Dim status As Integer = Main.CallSP("editInvestigador", dict, 2)

            If status = -1 Then
                MessageBox.Show("ERRO: É necessário preencher os campos de CC, Nome e E-Mail!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf status = -2 Then
                MessageBox.Show("ERRO: A Entidade Patronal deve estar inserida na Base de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Main.PopulateList(DataGridView1, "SELECT * FROM Investigador")
        End If

        CCTextBox.Enabled = False
        NomeTextBox.Enabled = False
        EmailTextBox.Enabled = False
        EPIDTextBox.Enabled = False
        Add.Visible = True
        Edit.Visible = True
        Stats.Visible = True
        Confirm.Visible = False
        Cancel.Visible = False

        operation = Nothing
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        operation = "Edit"

        NomeTextBox.Enabled = True
        EmailTextBox.Enabled = True
        EPIDTextBox.Enabled = True

        Add.Visible = False
        Edit.Visible = False
        Stats.Visible = False
        Confirm.Visible = True
        Cancel.Visible = True
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        ClearForm()
        Add.Visible = True
        Edit.Visible = True
        Stats.Visible = True
        Confirm.Visible = False
        Cancel.Visible = False
        CCTextBox.Enabled = False
        NomeTextBox.Enabled = False
        EmailTextBox.Enabled = False
        EPIDTextBox.Enabled = False

        operation = Nothing
    End Sub

    Private Sub Stats_Click(sender As Object, e As EventArgs) Handles Stats.Click
        Dim selectedRowCount = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim stats_form As New InvestigadorStats

        If selectedRowCount = 0 Then
            MessageBox.Show("Deve seleccionar um investigador!")
            Exit Sub
        ElseIf selectedRowCount = 1 Then

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                stats_form.CC = row.Cells("CC").Value.ToString()
                stats_form.nome = row.Cells("Nome").Value.ToString()
                stats_form.instituto = row.Cells("EntPatronal").Value
            Next

            stats_form.Show()
        End If
    End Sub

End Class