Public Class EditEI
    Public codigo As Int16
    Public Titulo As String
    Public Num_Vagas As Integer
    Public Renum As Double
    Public CC_Inv As String

    Public Cod_Tipo As Integer
    Public Num_Sessoes As Integer


    Private Sub EditEI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CodigoLabel.Text = codigo
        TituloLabel.Text = Titulo
        Num_VagasLabel.Text = Num_Vagas
        RenumLabel.Text = Renum
        CC_InvLabel.Text = CC_Inv

        Num_SessoesLabel.Text = Num_Sessoes
        Tipo_EILabel.SelectedIndex = Cod_Tipo - 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dict As New Dictionary(Of String, Object) From {
            {"@Codigo", codigo},
            {"@Titulo", TituloLabel.Text},
            {"@Num_Vagas", Num_VagasLabel.Text},
            {"@Renum", RenumLabel.Text},
            {"@CC", CC_InvLabel.Text},
            {"@Cod_Tipo", Tipo_EILabel.SelectedIndex + 1},
            {"@Num_Sessoes", Num_SessoesLabel.Text},
            {"@Tipo_Est", 2}
        }

        Dim l = dict.Keys.ToArray

        For Each key As String In l
            If dict(key) Is "" Then
                dict(key) = Nothing
            End If
        Next

        Dim status As Integer = Main.CallSP("editStudy", dict, 2)

        If status = -1 Then
            MessageBox.Show("ERRO: É necessário preencher o campo do Título!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf status = -2 Then
            MessageBox.Show("ERRO: É necessário preencher o número de vagas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf status = -3 Then
            MessageBox.Show("ERRO: É necessário atribuir uma Remuneração!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf status = -4 Then
            MessageBox.Show("ERRO: O Investigador associado deve estar inserido na Base de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Close()
        Main.Form_Estudos.Update_Estudos()
    End Sub
End Class