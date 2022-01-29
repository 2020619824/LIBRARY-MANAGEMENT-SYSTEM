Imports System.Data.SqlClient
Public Class BookIssueInformation
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")
    Public Sub PutBorrowerName()

        Try
            con.Open()
            Dim query = "select BorrowerName From Borrower"
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
        btnAdd.Visible = True
    End Sub

    Private Sub cboBorrower_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrower.SelectionChangeCommitted
        GetBorrowerName()
    End Sub
    Private Sub DisplayBook()

        Try
            Dim query = "select * from Book"
            SQLCommandView(query, dgvBookIssue)
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub
    Private Sub DisplayHeader()
        Dim query = "select * from Book where ISBN is null"
        SQLCommandView(query, dgvBookIssue)
        dgvBookIssue().Columns(1).HeaderText = "Year"
    End Sub
    Dim key = 0
    Private Sub DataGridViewListofBook_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBookIssue.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBookIssue.Rows(e.RowIndex)

            txtISBN.Text = row.Cells(0).Value.ToString
            txtBookTitle.Text = row.Cells(2).Value.ToString

            key = Convert.ToInt64(row.Cells(0).Value.ToString)

        End If
    End Sub

    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        DisplayBook()
    End Sub

    Private Sub BookIssueInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayHeader()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        BorrowerInformation.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
End Class