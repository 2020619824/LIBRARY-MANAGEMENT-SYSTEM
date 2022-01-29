Imports System.Data.SqlClient
Public Class BookIssueInformation
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")
    Public Sub PutBorrowerName()

        Try
            con.Open()
            Dim query = "select distinct BorrowerName From Borrower"
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, con)
            adapter = New SqlDataAdapter(cmd)
            Dim tbl = New DataTable()
            adapter.Fill(tbl)
            cboBorrower.DataSource = tbl
            cboBorrower.DisplayMember = "BorrowerName"
            cboBorrower.ValueMember = "BorrowerName"
            con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub
    Public Sub GetBorrowerName()

        Try
            con.Open()
            Dim query = "select BorrowerName from Borrower
                    where BorrowerName='" & cboBorrower.SelectedValue.ToString() & "'"

            Dim cmd = New SqlCommand(query, con)
            Dim dt = New DataTable()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                txtBorrower.Text = "" + reader(0).ToString
            End While
            con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub btnSearchBorrower_Click(sender As Object, e As EventArgs) Handles btnSearchBorrower.Click
        PutBorrowerName()
        txtBorrower.Clear()
        MyMessageBox.ShowMessage(cboBorrower.Items.Count & " Borrower found!")
    End Sub

    Private Sub cboBorrower_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrower.SelectionChangeCommitted
        GetBorrowerName()
    End Sub
End Class