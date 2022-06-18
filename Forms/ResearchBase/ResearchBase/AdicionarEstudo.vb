Public Class AdicionarEstudo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Codigo.Text = ""
        Titulo.Text = ""
        Num_Vagas.Text = ""
        Renum.Text = ""
        CC_Inv.Text = ""
        Cod_Inf.Text = ""
        Cod_CEIC.Text = ""
        Cod_Proc.Text = ""
        Num_Tomas.Text = ""
        Num_Sessoes.Text = ""
        Follow_up.SelectedValue = ""
        Tipo_EC.SelectedValue = ""
        Tipo_EI.SelectedValue = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sel_Est = Selecionar_Estudo.SelectedTab.Name
        Dim dict As New Dictionary(Of String, Object) From {
            {"@Codigo", Codigo.Text},
            {"@Titulo", Titulo.Text},
            {"@Num_Vagas", Num_Vagas.Text},
            {"@Renum", Renum.Text},
            {"@CC", CC_Inv.Text}
        }
        If sel_Est Is "EC" Then
            dict.Add("@Cod_Inf", Cod_Inf.Text)
            dict.Add("@Cod_CEIC", Cod_CEIC.Text)
            dict.Add("@Cod_Proc", Cod_Proc.Text)
            dict.Add("@Follow_up", Follow_up.SelectedIndex)
            dict.Add("@Num_Tomas", Num_Tomas.Text)
            dict.Add("@Cod_Tipo", Tipo_EC.SelectedIndex + 1)
            dict.Add("@Tipo_Est", 1)
        Else
            dict.Add("@Cod_Tipo", Tipo_EI.SelectedIndex + 1)
            dict.Add("@Num_Sessoes", Num_Sessoes.Text)
            dict.Add("@Tipo_Est", 2)
        End If

        Dim l = dict.Keys.ToArray

        For Each key As String In l
            If dict(key) is "" Then
                dict(key) = Nothing
            End If
        Next

        Main.CallSP("insertStudy", dict, 1)
        Main.PopulateList(Estudos.DataGridView1, "SELECT * FROM Estudo")
        Hide()
        Main.Form_Estudos.Update_Estudos()
    End Sub

    Private Sub Follow_up_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Follow_up.SelectedIndexChanged

    End Sub
End Class