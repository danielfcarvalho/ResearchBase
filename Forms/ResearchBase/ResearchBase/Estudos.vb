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
        ComboBox2.Enabled = True
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim Condition = " WHERE Estado = " + (ComboBox2.SelectedIndex + 1).ToString
        Main.PopulateList(DataGridView1, Estudo + Condition)


        If ComboBox2.SelectedIndex = 1 Then
            FinalizarEstudo_Button.Visible = True
        Else
            FinalizarEstudo_Button.Visible = False
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Debug.Write("HERE")

        For Each row As DataGridViewRow In DataGridView1.SelectedRows

            Debug.Write(row.Cells("Estado").Value)
            If row.Cells("Estado").Value = 1 Then
                Button1.Enabled = True
                EditButton.Enabled = True
                Button4.Enabled = False
                FinalizarEstudo_Button.Visible = False
                FinalizarEstudo_Button.Enabled = False
            ElseIf row.Cells("Estado").Value = 2 Then
                Button1.Enabled = False
                EditButton.Enabled = False
                Button4.Enabled = True
                FinalizarEstudo_Button.Visible = True
                FinalizarEstudo_Button.Enabled = True
            Else
                Button1.Enabled = False
                EditButton.Enabled = False
                FinalizarEstudo_Button.Visible = False
                FinalizarEstudo_Button.Enabled = False
                Button4.Enabled = True
            End If

        Next
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
                    EditEC.Titulo = row.Cells("Titulo").Value
                    EditEC.Num_Vagas = row.Cells("Num_Vagas").Value
                    EditEC.Renum = row.Cells("Renum").Value
                    EditEC.CC_Inv = row.Cells("CC_Inv").Value

                    EditEC.Cod_Inf = row.Cells("Cod_Inf").Value
                    EditEC.Cod_CEIC = row.Cells("Cod_CEIC").Value
                    EditEC.Cod_Proc = row.Cells("Cod_Proc").Value
                    EditEC.Follow_up = row.Cells("Follow_up").Value
                    EditEC.Num_Tomas = row.Cells("Num_Tomas").Value
                    EditEC.Cod_Tipo = row.Cells("Cod_Tipo").Value
                    EditEC.Show()
                Next

            ElseIf Tipo = 2 Then
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    EditEI.codigo = row.Cells("Codigo").Value
                    EditEI.Titulo = row.Cells("Titulo").Value
                    EditEI.Num_Vagas = row.Cells("Num_Vagas").Value
                    EditEI.Renum = row.Cells("Renum").Value
                    EditEI.CC_Inv = row.Cells("CC_Inv").Value

                    EditEI.Cod_Tipo = row.Cells("Cod_Tipo").Value
                    EditEI.Num_Sessoes = row.Cells("Num_Sessoes").Value
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

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim dict As New Dictionary(Of String, Object) From {
            {"@Nome", SearchTextBox.Text}
        }

        Main.PopulateListSP(DataGridView1, "searchEstudo", dict)
    End Sub


End Class