Public Class EditEC
    Public codigo As Int16
    Public Titulo As String
    Public Num_Vagas As Integer
    Public Renum As Double
    Public CC_Inv As String

    Public Cod_Inf As String
    Public Cod_CEIC As String
    Public Cod_Proc As String
    Public Follow_up As Integer
    Public Num_Tomas As Integer
    Public Cod_Tipo As Integer


    Private Sub EditEC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CodigoLabel.Text = codigo
        TituloLabel.Text = Titulo
        Num_VagasLabel.Text = Num_Vagas
        RenumLabel.Text = Renum
        CC_InvLabel.Text = CC_Inv

        Cod_InfLabel.Text = Cod_Inf
        Cod_CEICLabel.Text = Cod_CEIC
        Cod_ProcLabel.Text = Cod_Proc
        Follow_upLabel.SelectedIndex = Follow_up
        Num_TomasLabel.Text = Num_Tomas
        Tipo_ECLabel.SelectedIndex = Cod_Tipo - 1


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dict As New Dictionary(Of String, Object) From {
            {"@Codigo", codigo},
            {"@Titulo", TituloLabel.Text},
            {"@Num_Vagas", Num_VagasLabel.Text},
            {"@Renum", RenumLabel.Text},
            {"@CC", CC_InvLabel.Text},
            {"@Cod_Inf", Cod_InfLabel.Text},
            {"@Cod_CEIC", Cod_CEICLabel.Text},
            {"@Cod_Proc", Cod_ProcLabel.Text},
            {"@Follow_up", Follow_upLabel.SelectedIndex},
            {"@Num_Tomas", Num_TomasLabel.Text},
            {"@Cod_Tipo", Tipo_ECLabel.SelectedIndex + 1},
            {"@Tipo_Est", 1}
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