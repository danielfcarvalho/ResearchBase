Imports System.Data.SqlClient

Public Class Main

    Dim CN As SqlConnection
    Dim CMD As SqlCommand

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
        Return New SqlConnection("data source=AFARTURPC\SQLEXPRESS;integrated security=true;initial catalog=ResearchBase")
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


    Public Sub InsertIntoDB(procedureName As String, parameters As Dictionary(Of String, Object))
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

        Catch ex As Exception
            Throw New Exception("Unexpected Error: " + ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As New Estudos
        form2.Show()
        Me.Hide()
    End Sub
End Class
