Public Class Estudos
    Dim Estudo = "SELECT * FROM Estudo"
    Dim Tipo = 0

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim ID = ComboBox1.SelectedIndex
        If ID = 0 Then
            Estudo = "SELECT * FROM Estudo"
            Main.PopulateList(DataGridView1, Estudo)
            ComboBox2.ResetText()
        ElseIf ID = 1 Then
            Estudo = "SELECT * FROM EC_Total"
            Main.PopulateList(DataGridView1, Estudo)
            ComboBox2.ResetText()
            Button1.Enabled = True
            Tipo = 1
        Else
            Estudo = "SELECT * FROM EI_Total"
            Main.PopulateList(DataGridView1, Estudo)
            ComboBox2.ResetText()
            Button1.Enabled = True
            Tipo = 2
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim Condition = " WHERE Estado = " + (ComboBox2.SelectedIndex + 1).ToString
        Main.PopulateList(DataGridView1, Estudo + Condition)

        If ComboBox2.SelectedIndex > 0 Then
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Estudos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.PopulateList(DataGridView1, Estudo)
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

        If selectedRowCount = 0 Then
            MessageBox.Show("Deve seleccionar um estudo!")
            Exit Sub
        ElseIf selectedRowCount = 1 Then

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                Recrutar.codigo = row.Cells("Codigo").Value
                Recrutar.nome = row.Cells("Titulo").Value.ToString()
                Recrutar.vagas = row.Cells("Num_Vagas").Value - row.Cells("Num_Part").Value

                If Recrutar.vagas = 0 Then
                    MessageBox.Show("O estudo já está preenchido!")
                    Exit Sub
                End If
            Next

            If Tipo = 1 Then
                Recrutar.tipo = 1
            Else
                Recrutar.tipo = 2
            End If

            Recrutar.Show()
        ElseIf selectedRowCount > 1 Then
            MessageBox.Show("Deve seleccionar apenas um estudo!")
            Exit Sub
        End If
    End Sub

    ' Botão Participantes
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim selectedRowCount = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount = 0 Then
            MessageBox.Show("Deve seleccionar um estudo!")
            Exit Sub
        ElseIf selectedRowCount = 1 Then

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                ParticipantesEstudo.codigo = row.Cells("Codigo").Value
                ParticipantesEstudo.nome = row.Cells("Titulo").Value.ToString()
            Next


            ParticipantesEstudo.Show()
        ElseIf selectedRowCount > 1 Then
            MessageBox.Show("Deve seleccionar apenas um estudo!")
            Exit Sub
        End If
    End Sub

    ' Botão Editar
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim selectedRowCount = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)

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
End Class