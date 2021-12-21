Imports System.Data.SqlClient
Module CommandSQL

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\CS110\SEMESTER 3\CSC301\GROUP PROJECT\PROJECT\LIBRARY MANAGEMENT SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")
    Public Sub SQLCommandBasic(ByVal strQuery As String)
        Con.Open()
        Dim query = strQuery
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
    End Sub

    Public Sub SQLCommandView(ByVal strQuery As String, ByVal TempDataGridView As DataGridView)
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
    End Sub

End Module
