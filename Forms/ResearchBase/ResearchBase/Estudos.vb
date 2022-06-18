Public Class Estudos
    Dim Estudo = "SELECT * FROM Estudo"

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
        Else
            Estudo = "SELECT * FROM EI_Total"
            Main.PopulateList(DataGridView1, Estudo)
            ComboBox2.ResetText()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim Condition = " WHERE Estado = " + (ComboBox2.SelectedIndex + 1).ToString
        Main.PopulateList(DataGridView1, Estudo + Condition)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Estudos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.PopulateList(DataGridView1, Estudo)
    End Sub

    Public Sub Update_Estudos()
        Main.PopulateList(DataGridView1, Estudo)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdicionarEstudo.Show()
    End Sub

End Class