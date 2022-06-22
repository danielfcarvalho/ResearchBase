Public Class ParticipantesStats
    Public ID_Participante As Integer


    Private Sub ParticipantesStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ID.Text = ID_Participante.ToString
        Label1.Text = Main.FecthSimpleData("SELECT COUNT(ID_Participante) AS Num_Estudos FROM Lista_Participantes WHERE ID_Participante = " + ID_Participante.ToString)
        Label2.Text = Main.FecthSimpleData("SELECT COUNT(ID_Participante) AS Num_Estudos FROM Estudo JOIN Lista_Participantes ON Codigo = Cod_Estudo  WHERE Estado = 3 AND ID_Participante = " + ID_Participante.ToString)
        Label3.Text = Main.FecthSimpleData("SELECT Renum_Total FROM Participante WHERE ID = " + ID_Participante.ToString).ToString + " €"
        Main.PopulateList(DataGridView1, "SELECT Codigo, Titulo, Estado, Num_Part, Num_Vagas, Renum, CC_Inv, Phase_StartDate, Cod_Consentimento FROM Estudo JOIN Lista_Participantes ON Codigo = Cod_Estudo WHERE ID_Participante = " + ID_Participante.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class