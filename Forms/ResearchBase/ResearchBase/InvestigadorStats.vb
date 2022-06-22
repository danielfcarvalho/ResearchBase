Public Class InvestigadorStats
    Public nome As String
    Public CC As String
    Public instituto As Integer

    Private Sub InvestigadorStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeLabel.Text = nome
        InstitutoLabel.Text = Main.FecthSimpleData("SELECT Nome FROM EntPatronal WHERE Num_Registo = " + instituto.ToString)
        NumEstudosLabel.Text = Main.FecthSimpleData("SELECT Num_Estudos FROM Investigador WHERE CC = " + CC)

        Main.PopulateList(DataGridView1, "SELECT * FROM Estudo WHERE CC_INV = " + CC)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class