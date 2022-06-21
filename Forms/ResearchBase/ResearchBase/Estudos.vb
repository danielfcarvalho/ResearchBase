Public Class Estudos
    Dim Estudo = "SELECT * FROM Estudo"
    Dim Tipo = 0

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim ID = ComboBox1.SelectedIndex

        If ID = 0 Then
            Estudo = "SELECT * FROM EC_Total"
            Tipo = 1
        Else
            Estudo = "SELECT * FROM EI_Total"
            Tipo = 2
        End If

        Main.PopulateList(DataGridView1, Estudo)
        ComboBox2.ResetText()
        Button1.Enabled = True
        ComboBox2.Enabled = True
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim Condition = " WHERE Estado = " + (ComboBox2.SelectedIndex + 1).ToString
        Main.PopulateList(DataGridView1, Estudo + Condition)

        If ComboBox2.SelectedIndex > 0 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If

        If ComboBox2.SelectedIndex = 1 Then
            FinalizarEstudo_Button.Visible = True
        Else
            FinalizarEstudo_Button.Visible = False
        End If
    End Sub

    Private Sub Estudos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub Update_Estudos()
        Main.PopulateList(DataGridView1, Estudo)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdicionarEstudo.Show()
    End Sub

    ' Botão Recrutar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim selectedRowCount = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim recrutar_form As New Recrutar

        If selectedRowCount = 0 Then
            MessageBox.Show("Deve seleccionar um estudo!")
            Exit Sub
        ElseIf selectedRowCount = 1 Then

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                recrutar_form.codigo = row.Cells("Codigo").Value
                recrutar_form.nome = row.Cells("Titulo").Value.ToString()
                recrutar_form.vagas = row.Cells("Num_Vagas").Value - row.Cells("Num_Part").Value

                If recrutar_form.vagas = 0 Then
                    MessageBox.Show("O estudo já está preenchido!")
                    Exit Sub
                End If
            Next

            If Tipo = 1 Then
                recrutar_form.tipo = 1
            Else
                recrutar_form.tipo = 2
            End If

            recrutar_form.Show()
        ElseIf selectedRowCount > 1 Then
            MessageBox.Show("Deve seleccionar apenas um estudo!")
            Exit Sub
        End If
    End Sub

    ' Botão Participantes
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim selectedRowCount = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim participantesEstudo_form As New ParticipantesEstudo

        If selectedRowCount = 0 Then
            MessageBox.Show("Deve seleccionar um estudo!")
            Exit Sub
        ElseIf selectedRowCount = 1 Then

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                participantesEstudo_form.codigo = row.Cells("Codigo").Value
                participantesEstudo_form.nome = row.Cells("Titulo").Value.ToString()
                participantesEstudo_form.participantes = row.Cells("Num_Part").Value
            Next

            participantesEstudo_form.Show()
        ElseIf selectedRowCount > 1 Then
            MessageBox.Show("Deve seleccionar apenas um estudo!")
            Exit Sub
        End If
    End Sub

    ' Botão Editar
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim selectedRowCount = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim EditEC As New EditEC
        Dim EditEI As New EditEI

        If selectedRowCount = 0 Then
            MessageBox.Show("Deve seleccionar um estudo!")
            Exit Sub
        ElseIf selectedRowCount = 1 Then

            If Tipo = 1 Then
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    EditEC.codigo = row.Cells("Codigo").Value
                    EditEC.Show()
                Next

            ElseIf Tipo = 2 Then
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    EditEI.codigo = row.Cells("Codigo").Value
                    EditEI.Show()
                Next

            End If

        ElseIf selectedRowCount > 1 Then
            MessageBox.Show("Deve seleccionar apenas um estudo!")
            Exit Sub
        End If
    End Sub

    Private Sub FinalizarEstudo_Button_Click(sender As Object, e As EventArgs) Handles FinalizarEstudo_Button.Click
        Dim selectedRowCount = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount = 0 Then
            MessageBox.Show("Deve seleccionar pelo menos um participante!")
            Exit Sub
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                Dim dict As New Dictionary(Of String, Object) From {
                    {"@Cod_Est", row.Cells("Codigo").Value}
                }

                Dim l = dict.Keys.ToArray

                For Each key As String In l
                    If dict(key) Is "" Then
                        dict(key) = Nothing
                    End If
                Next


                Main.CallSP("completeStudy", dict, 1)
                ComboBox2.ResetText()
                Main.Form_Estudos.Update_Estudos()
            Next

        End If
    End Sub
End Class