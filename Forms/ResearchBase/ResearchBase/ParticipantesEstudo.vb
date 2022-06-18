Public Class ParticipantesEstudo
    Public nome As String
    Public codigo As Integer
    Public participantes As Integer
    Private Sub ParticipantesEstudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameLabel.Text = nome
        CodigoLabel.Text = codigo
        LabelParticipantes.Text = participantes

        Main.PopulateList(DataGridView1, "SELECT ID, CC, Email, IBAN, NIF, Data_nasc, Genero, Localidade, Renum_Total, Idade, Cod_Analises, Cod_Consentimento FROM Lista_Participantes JOIN Participante ON ID = ID_Participante
WHERE Cod_Estudo = " + codigo.ToString)
    End Sub

    Private Sub Fechar_Click(sender As Object, e As EventArgs) Handles Fechar.Click
        Hide()
    End Sub
End Class