Imports System.Data.SqlClient

Public Class BookDetails
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\CS110\SEMESTER 3\CSC301\GROUP PROJECT\PROJECT\LIBRARY MANAGEMENT SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")

    Private Sub DisplayTable()
        Dim query = "select * from Book"
        SQLCommandView(query, DataGridViewListofBook)
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

    Private Function ValidatePKBook() As Boolean
        Dim data As Decimal
        data = CDec(txtISBN.Text)
        Dim i
        For i = 0 To DataGridViewListofBook.Rows.Count - 1
            If CDec(DataGridViewListofBook.Rows(i).Cells(0).Value) = data Then
                MsgBox("Sorry, the book is already exist")
                Return False
            End If
        Next
        Return True
    End Function

    Dim decSearchISBN As Decimal
    Private Function ValidateISBN() As Boolean
        If Not Decimal.TryParse(txtSearchBook.Text, decSearchISBN) Then
            MsgBox("Please input the ISBN correctly")
            Return False
        End If
        Return True
    End Function

    Private Function ValidateUpdatedBook() As Boolean
        Dim data As Decimal
        data = CDec(txtISBN.Text)
        Dim i
        For i = 0 To DataGridViewListofBook.Rows.Count - 1
            If DataGridViewListofBook.Rows(i).Index = key Then
                MsgBox("Sorry, the book is already updated")
                Return False
            ElseIf CDec(DataGridViewListofBook.Rows(i).Cells(0).Value) = data Then
                MsgBox("Sorry, the book is already exist")
                Return False
            End If
        Next
        Return True
    End Function

    '!!If same isbn inserted, need to check and tell the user
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtISBN.Text = "" Or txtYear.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtPublisher.Text = "" Or txtCategory.Text = "" Then
            MsgBox("Missing Information")
        Else
            If ValidatePKBook() Then
                Dim query = "insert into book values(" & txtISBN.Text & "," & txtYear.Text & ",'" & txtTitle.Text & "','" & txtAuthor.Text & "','" & txtPublisher.Text & "','" & txtCategory.Text & "')"
                SQLCommandBasic(query)
                MsgBox("Book Saved")
                DisplayTable()
                ClearTextBoxes()
            End If
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
            If ValidateUpdatedBook() Then
                Dim query = "update Book set ISBN=" & txtISBN.Text & ",YearofPublication=" & txtYear.Text & ",Title='" & txtTitle.Text & "',Author='" &
                        txtAuthor.Text & "',Publisher='" & txtPublisher.Text & "',Category='" & txtCategory.Text & "' where ISBN=" & key & ""
                SQLCommandBasic(query)
                MsgBox("Book Updated")
                DisplayTable()
                ClearTextBoxes()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Or (txtISBN.Text = "" Or txtYear.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtPublisher.Text = "" Or txtCategory.Text = "") Then
            MsgBox("Missing Information")
        Else
            Dim query = "delete from Book where ISBN=" & key & ""
            SQLCommandBasic(query)
            MsgBox("Book Deleted")
            DisplayTable()
            ClearTextBoxes()
        End If
    End Sub

    '!!Check validation for search by isbn (!integer tell user to input correctly)
    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        Dim strSearchAuthor As String
        Dim strSearchTitle As String

        Dim blnInvalidISBN As Boolean
        blnInvalidISBN = False

        If txtSearchBook.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim query = ""
            If cboSearchBy.SelectedIndex = 0 Then
                'decSearchISBN = CDec(txtSearchBook.Text)
                If ValidateISBN() Then
                    query = "select * from book where ISBN=" & decSearchISBN & ""
                    SQLCommandView(query, DataGridViewListofBook)
                Else
                    blnInvalidISBN = True
                End If
            ElseIf cboSearchBy.SelectedIndex = 1 Then
                strSearchAuthor = txtSearchBook.Text
                query = "select * from book where Author='" & strSearchAuthor & "'"
                SQLCommandView(query, DataGridViewListofBook)
            ElseIf cboSearchBy.SelectedIndex = 2 Then
                strSearchTitle = txtSearchBook.Text
                query = "select * from book where Title='" & strSearchTitle & "'"
                SQLCommandView(query, DataGridViewListofBook)
            End If

            If blnInvalidISBN = False Then
                If DataGridViewListofBook.Rows.Count = 0 Then
                    MsgBox("Sorry, no book found")
                Else
                    MsgBox(DataGridViewListofBook.Rows.Count & " Book found!")
                End If
            End If

            ClearTextBoxes()
        End If
    End Sub

    Private Sub BookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class