Imports System.Data.SqlClient
Module CommandSQL

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")

    Public Sub SQLCommandBasic(ByVal strQuery As String)
        Try
            Con.Open()
            Dim query = strQuery
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            Con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Public Sub SQLCommandView(ByVal strQuery As String, ByVal TempDataGridView As DataGridView)
        Try
            Con.Open()
            Dim query = strQuery
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            TempDataGridView.DataSource = ds.Tables(0)
            Con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Public Function TodayDate() As String
        'SQL Date Format: YYYY-MM-DD
        Dim dateSQLFormat = Date.Today.Year.ToString & "-"
        dateSQLFormat += Date.Today.Month.ToString & "-"
        dateSQLFormat += Date.Today.Day.ToString

        Return dateSQLFormat
    End Function
End Module
