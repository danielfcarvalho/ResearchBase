Public Class EntPatronalStats
    Public nome As String
    Public ID As Integer
    Private Sub EntPatronalStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Entidade.Text = nome
        num_estudos.Text = Main.FecthSimpleData("SELECT count(cc) FROM Estudo JOIN (SELECT Num_Registo, CC FROM EntPatronal JOIN Investigador ON Num_Registo = EntPatronal) AS Something ON CC_Inv = CC WHERE Num_Registo = " + ID.ToString)
        pagamentos.Text = Main.FecthSimpleData("SELECT SUM(Renum*Num_Part) FROM Estudo JOIN (SELECT Num_Registo, CC FROM EntPatronal JOIN Investigador ON Num_Registo = EntPatronal) AS Something ON CC_Inv = CC WHERE Estado = 3 AND Num_Registo = " + ID.ToString).ToString + " €"
        Main.PopulateList(DataGridView1, "SELECT * FROM Estudo JOIN (SELECT Num_Registo, CC FROM EntPatronal JOIN Investigador ON Num_Registo = EntPatronal) AS Something ON CC_Inv = CC WHERE Num_Registo = " + ID.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class