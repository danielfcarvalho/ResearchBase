Public Class Participantes
    Public action = 0
    Private Sub Participantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.PopulateList(DataGridView1, "SELECT * FROM Participante")
        UpdateGrid()
    End Sub


    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim dict As New Dictionary(Of String, Object) From {
                    {"@CC", TextBox7.Text}
                }
        Main.PopulateListSP(DataGridView1, "searchParticipant", dict)
        UpdateGrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        UpdateGrid()
    End Sub

    Public Sub UpdateGrid()
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Dim dict As New Dictionary(Of String, Object) From {
                    {"@CC", row.Cells("CC").Value},
                    {"@Email", row.Cells("Email").Value},
                    {"@IBAN", row.Cells("IBAN").Value},
                    {"@NIF", row.Cells("NIF").Value},
                    {"@Data_Nasc", row.Cells("Data_nasc").Value},
                    {"@Genero", row.Cells("Genero").Value},
                    {"@Localidade", row.Cells("Localidade").Value},
                    {"@Codigo_Analises", row.Cells("Cod_Analises").Value}
                }

            Dim l = dict.Keys.ToArray

            For Each key As String In l
                If IsDBNull(dict(key)) Then
                    dict(key) = ""
                End If
            Next

            CC.Text = dict("@CC")
            Email.Text = dict("@Email")
            IBAN.Text = dict("@IBAN")
            NIF.Text = dict("@NIF")
            Data_Nasc.Value = dict("@Data_Nasc")
            Genero.Text = dict("@Genero")
            Localidade.Text = dict("@Localidade")
            Cod_Analises.Text = dict("@Codigo_Analises")
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clearForm()
        CC.Enabled = True
        Email.Enabled = True
        IBAN.Enabled = True
        NIF.Enabled = True
        Data_Nasc.Enabled = True
        Genero.Enabled = True
        Localidade.Enabled = True
        Cod_Analises.Enabled = True

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        Confirmar.Visible = True
        Cancelar.Visible = True

        action = 1
    End Sub

    Public Sub clearForm()
        CC.Text = ""
        Email.Text = ""
        IBAN.Text = ""
        NIF.Text = ""
        Genero.Text = ""
        Localidade.Text = ""
        Cod_Analises.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Email.Enabled = True
        IBAN.Enabled = True
        NIF.Enabled = True
        Data_Nasc.Enabled = True
        Genero.Enabled = True
        Localidade.Enabled = True
        Cod_Analises.Enabled = True

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        Confirmar.Visible = True
        Cancelar.Visible = True

        action = 2
    End Sub

    Private Sub Confirmar_Click(sender As Object, e As EventArgs) Handles Confirmar.Click
        Dim status As Int16

        Dim dict As New Dictionary(Of String, Object) From {
            {"@CC", CC.Text},
            {"@Email", Email.Text},
            {"@IBAN", IBAN.Text},
            {"@NIF", NIF.Text},
            {"@Data_nasc", Data_Nasc.Value},
            {"@Genero", Genero.Text},
            {"@Localidade", Localidade.Text},
            {"@Cod_Analises", Cod_Analises.Text},
            {"@status", 1}
        }

        Dim l = dict.Keys.ToArray

        For Each key As String In l
            If dict(key) Is "" Then
                dict(key) = Nothing
            End If
        Next

        If action = 1 Then
            status = Main.CallSP("addParticipante", dict, 2)
        ElseIf action = 2 Then
            status = Main.CallSP("editParticipante", dict, 2)
        End If

        If status = -1 And action = 1 Then
            MessageBox.Show("ERRO: É necessário CC e Email")
        ElseIf status = -1 And action = 2 Then
            MessageBox.Show("ERRO: É necessário Email")
        Else
            Confirmar.Visible = False
            Cancelar.Visible = False

            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True

            CC.Enabled = False
            Email.Enabled = False
            IBAN.Enabled = False
            NIF.Enabled = False
            Data_Nasc.Enabled = False
            Genero.Enabled = False
            Localidade.Enabled = False
            Cod_Analises.Enabled = False

            Main.PopulateList(DataGridView1, "SELECT * FROM Participante")
            UpdateGrid()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim participantesStats As New ParticipantesStats
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            participantesStats.ID_Participante = row.Cells("ID").Value
        Next
        participantesStats.Show()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Confirmar.Visible = False
        Cancelar.Visible = False

        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True

        CC.Enabled = False
        Email.Enabled = False
        IBAN.Enabled = False
        NIF.Enabled = False
        Data_Nasc.Enabled = False
        Genero.Enabled = False
        Localidade.Enabled = False
        Cod_Analises.Enabled = False

        UpdateGrid()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class