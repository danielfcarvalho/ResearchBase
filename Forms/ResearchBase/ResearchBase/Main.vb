Imports System.Data.SqlClient

Public Class Main

    Dim CN As SqlConnection
    Dim CMD As SqlCommand

    Public Form_Estudos As New Estudos
    Public Form_Investigadores As New Investigador
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = GetSGBDConnection()
        If VerifySGBDConnection() Then
            Console.WriteLine("Connection")
        Else
            Dim result As DialogResult
            result = MessageBox.Show("Can't connect to database", "Error!", MessageBoxButtons.OK)
            If result = DialogResult.OK Then
                System.Environment.Exit(1)
            End If
        End If

        CN.Close()
    End Sub

    Private Function GetSGBDConnection()
        ' Dim dbServer = "tcp:mednat.ieeta.pt\\SQLSERVER,8101"
        ' Dim dbName = "p8g1"
        ' Dim userName = "p8g1"
        ' Dim userPass = "77036102477+yaskweenslay"
        ' Return New SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName + "; uid = " + userName + ";" + "password = " + userPass)
        ' Return New SqlConnection("data source=AFARTURPC\SQLEXPRESS;integrated security=true;initial catalog=ResearchBase")
        Return New SqlConnection("data source=DESKTOP-80AK2K2\SQLEXPRESS;integrated security=true;initial catalog=ResearchBase")
    End Function

    Private Function VerifySGBDConnection()
        If CN Is Nothing Then
            CN = GetSGBDConnection()
        End If
        If CN.State <> ConnectionState.Open Then
            CN.Open()
        End If
        Return CN.State = ConnectionState.Open
    End Function

    Public Sub PopulateList(grid As DataGridView, text As String)
        If Not VerifySGBDConnection() Then
            Exit Sub
        End If

        Try
            CMD = New SqlCommand With {
                .Connection = CN,
                .CommandText = text
            }
            Dim adp As New SqlDataAdapter(CMD)
            Dim dt As New DataTable()
            adp.Fill(dt)
            grid.DataSource = dt
        Catch ex As Exception
            Throw New Exception("Unexpected Error: " + ex.Message)
        End Try

    End Sub

    Public Function CallSP(procedureName As String, parameters As Dictionary(Of String, Object), type As Int16)
        ' 1 -> Executa uma SP sem return value (Apenas modifica tuplos na BD)
        ' 2 -> Executa uma SP com return value
        If Not VerifySGBDConnection() Then
            Exit Function
        End If

        Try
            CMD = New SqlCommand With {
                .Connection = CN,
                .CommandText = procedureName,
                .CommandType = CommandType.StoredProcedure
            }

            For Each item In parameters
                CMD.Parameters.AddWithValue(item.Key, item.Value)
            Next

            If type = 1 Then
                CMD.ExecuteNonQuery()
            Else
                Dim status As Integer = CType(CMD.ExecuteScalar(), Integer)
                Debug.Print(status)
                Return status
            End If

        Catch ex As SqlException
            Dim errorMessage = ""
            For Each e As SqlError In ex.Errors
                errorMessage += e.Message
            Next

            MessageBox.Show(errorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            Throw New Exception("Unexpected Error: " + ex.Message)
        End Try

#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Sub PopulateListSP(grid As DataGridView, procedureName As String, parameters As Dictionary(Of String, Object))
        If Not VerifySGBDConnection() Then
            Exit Sub
        End If

        Try
            CMD = New SqlCommand With {
                .Connection = CN,
                .CommandText = procedureName,
                .CommandType = CommandType.StoredProcedure
            }

            For Each item In parameters
                CMD.Parameters.AddWithValue(item.Key, item.Value)
            Next

            CMD.ExecuteNonQuery()

            Dim adp As New SqlDataAdapter(CMD)
            Dim dt As New DataTable()
            adp.Fill(dt)
            grid.DataSource = dt
        Catch ex As SqlException
            Dim errorMessage = ""
            For Each e As SqlError In ex.Errors
                errorMessage += e.Message
            Next

            MessageBox.Show(errorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            Throw New Exception("Unexpected Error: " + ex.Message)
        End Try

    End Sub

    Public Function FecthSimpleData(query As String)
        If Not VerifySGBDConnection() Then
            Exit Function
        End If

        Try
            CMD = New SqlCommand With {
                .Connection = CN,
                .CommandText = query
            }

            Return CMD.ExecuteScalar()
        Catch ex As SqlException
            Dim errorMessage = ""
            For Each e As SqlError In ex.Errors
                errorMessage += e.Message
            Next

            MessageBox.Show(errorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            Throw New Exception("Unexpected Error: " + ex.Message)
        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_Estudos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Form_Investigadores.Show()
    End Sub
End Class
