﻿Public Class Recrutar
    Public tipo As Int16
    Public nome As String
    Public codigo As Int16
    Public vagas As Int16

    Private Sub Recrutar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameLabel.Text = nome
        CodigoLabel.Text = codigo
        VagasBox.Text = vagas
    End Sub

    ' Pesquisar Participantes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IdMin = IdadeMinBox.Text
        Dim IdMax = IdadeMaxBox.Text
        Dim Genero = ComboBox1.SelectedValue

        Dim dict As New Dictionary(Of String, Object) From {
            {"@MinAge", IdMin},
            {"@MaxAge", IdMax},
            {"@Gender", Genero}
        }

        Dim l = dict.Keys.ToArray

        For Each key As String In l
            If dict(key) Is "" Then
                dict(key) = Nothing
            End If
        Next

        If tipo = 1 Then
            Main.PopulateListSP(DataGridView1, "Select_Valid_ParticipantsEC", dict)
        ElseIf tipo = 2 Then
            Main.PopulateListSP(DataGridView1, "Select_Valid_ParticipantsEI", dict)
        End If

    End Sub

    ' Adicionar Participante
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedRowCount = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim status As Int16

        If selectedRowCount = 0 Then
            MessageBox.Show("Deve seleccionar pelo menos um participante!")
            Exit Sub
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                status = Nothing
                Dim dict As New Dictionary(Of String, Object) From {
                    {"@ID_Part", row.Cells("ID").Value},
                    {"@Cod_Est", codigo},
                    {"@status", status}
                }

                Dim l = dict.Keys.ToArray

                For Each key As String In l
                    If dict(key) Is "" Then
                        dict(key) = Nothing
                    End If
                Next

                If tipo = 1 Then
                    status = Main.CallSP("Add_ParticipantEC", dict, 2)
                ElseIf tipo = 2 Then
                    status = Main.CallSP("Add_ParticipantEI", dict, 2)
                End If

                If status = 1 Then
                    vagas -= 1
                    VagasBox.Text = Convert.ToString(vagas)
                ElseIf status = -1 Then
                    MessageBox.Show("ERRO: O total de vagas para este estudo já foi preenchido!")
                    Button2.Enabled = False
                End If
            Next

        End If
    End Sub

    ' Terminar Recrutamento
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim status As Int16

        status = Nothing

        Dim dict As New Dictionary(Of String, Object) From {
                   {"@Cod_Est", codigo},
                   {"@status", status}
               }

        Dim l = dict.Keys.ToArray

        For Each key As String In l
            If dict(key) Is "" Then
                dict(key) = Nothing
            End If
        Next

        status = Main.CallSP("finishRecruiting", dict, 2)

        If status = -1 Then
            MessageBox.Show("ERRO: O estudo ainda não tem participantes recrutados!")
        Else
            Hide()
            Main.Form_Estudos.Update_Estudos()
        End If
    End Sub

End Class