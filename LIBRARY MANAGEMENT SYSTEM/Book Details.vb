Imports System.Data.SqlClient

Public Class BookDetails
    Private Sub BookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'List_Book_Details.Book' table. You can move, or remove it, as needed.

    End Sub

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\CS110\SEMESTER 3\CSC301\GROUP PROJECT\PROJECT\LIBRARY MANAGEMENT SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")

    Private Sub DisplayTable()
        Con.Open()
        Dim query = "select * from Book"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        DataGridViewListofBook.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub ClearTextBoxes()
        txtISBN.Clear()
        txtYear.Clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtPublisher.Clear()
        txtCategory.Clear()
        DataGridViewListofBook.ClearSelection()
    End Sub

    '!!If same isbn inserted, need to check and tell the user
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtISBN.Text = "" Or txtYear.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtPublisher.Text = "" Or txtCategory.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "insert into book values(" & txtISBN.Text & "," & txtYear.Text & ",'" & txtTitle.Text & "','" & txtAuthor.Text & "','" & txtPublisher.Text & "','" & txtCategory.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Saved")
            Con.Close()
            DisplayTable()
            ClearTextBoxes()
        End If
    End Sub


    Private Sub btnListofBooks_Click(sender As Object, e As EventArgs) Handles btnListofBooks.Click
        DisplayTable()
        ClearTextBoxes()
    End Sub

    Dim key = 0
    Private Sub DataGridViewListofBook_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewListofBook.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridViewListofBook.Rows(e.RowIndex)

            txtISBN.Text = row.Cells(0).Value.ToString
            txtYear.Text = row.Cells(1).Value.ToString
            txtTitle.Text = row.Cells(2).Value.ToString
            txtAuthor.Text = row.Cells(3).Value.ToString
            txtPublisher.Text = row.Cells(4).Value.ToString
            txtCategory.Text = row.Cells(5).Value.ToString

            key = Convert.ToInt64(row.Cells(0).Value.ToString)

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtISBN.Text = "" Or txtYear.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtPublisher.Text = "" Or txtCategory.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "update Book set ISBN=" & txtISBN.Text & ",YearofPublication=" & txtYear.Text & ",Title='" & txtTitle.Text & "',Author='" &
                        txtAuthor.Text & "',Publisher='" & txtPublisher.Text & "',Category='" & txtCategory.Text & "' where ISBN=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Edited")
            Con.Close()
            DisplayTable()
            ClearTextBoxes()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Or (txtISBN.Text = "" Or txtYear.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtPublisher.Text = "" Or txtCategory.Text = "") Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "delete from Book where ISBN=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted")
            Con.Close()
            DisplayTable()
            ClearTextBoxes()
        End If
    End Sub

    '!!Check validation for search by isbn (!integer tell user to input correctly)
    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        Dim decSearchISBN As Decimal
        Dim strSearchAuthor As String
        Dim strSearchTitle As String

        If txtSearchBook.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query
            If cboSearchBy.SelectedIndex = 0 Then
                decSearchISBN = CDec(txtSearchBook.Text)
                query = "select * from book where ISBN=" & decSearchISBN & ""
            ElseIf cboSearchBy.SelectedIndex = 1 Then
                strSearchAuthor = txtSearchBook.Text
                query = "select * from book where Author='" & strSearchAuthor & "'"
            ElseIf cboSearchBy.SelectedIndex = 2 Then
                strSearchTitle = txtSearchBook.Text
                query = "select * from book where Title='" & strSearchTitle & "'"

            Else
            End If
            Dim adapter As SqlDataAdapter
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            DataGridViewListofBook.DataSource = ds.Tables(0)
            If DataGridViewListofBook.Rows.Count = 0 Then
                MsgBox("Sorry, not found")
            Else
                MsgBox(DataGridViewListofBook.Rows.Count & " Book found!")
            End If

            Con.Close()
            ClearTextBoxes()
        End If
    End Sub
End Class