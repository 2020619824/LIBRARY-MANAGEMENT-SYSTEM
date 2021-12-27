Imports System.Data.SqlClient

Public Class BookDetails
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\CS110\SEMESTER 3\CSC301\GROUP PROJECT\PROJECT\LIBRARY MANAGEMENT SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")

    Private Sub DisplayTable()
        Dim query = "select * from Book"
        SQLCommandView(query, DataGridViewListofBook)
    End Sub

    Private Sub DisplayHeader()
        Dim query = "select * from Book where ISBN is null"
        SQLCommandView(query, DataGridViewListofBook)
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

    Private Sub ClearTextBoxes()
        txtISBN.Clear()
        txtYear.Clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtPublisher.Clear()
        txtCategory.Clear()
        DataGridViewListofBook.ClearSelection()
    End Sub

    Private Sub Reset()
        key = 0
        txtISBN.Clear()
        txtYear.Clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtPublisher.Clear()
        txtCategory.Clear()
        txtSearchBook.Clear()
        cboSearchBy.SelectedIndex = 0
        DataGridViewListofBook.DataSource.Clear()
    End Sub
    Private Sub ResetKey()
        key = 0
    End Sub

    Private Function ValidateTextBoxes() As Boolean
        If txtISBN.Text = "" Or txtYear.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtPublisher.Text = "" Or txtCategory.Text = "" Then
            MsgBox("Missing Information")
            Return False
        End If

        Return True
    End Function

    Dim decSearchISBN As Decimal
    Private Function ValidateSearchByISBN() As Boolean
        If Not Decimal.TryParse(txtSearchBook.Text, decSearchISBN) Then
            MsgBox("Please input the ISBN correctly")
            txtSearchBook.Clear()
            txtSearchBook.Focus()
            Return False
        End If
        Return True
    End Function

    Dim decISBN As Decimal
    Private Function ValidateISBN() As Boolean
        If Not Decimal.TryParse(txtISBN.Text, decISBN) Then
            MsgBox("Please input the ISBN correctly")
            Return False
        End If
        Return True
    End Function

    Dim intYear As Integer
    Private Function ValidateYear() As Boolean
        If Not Integer.TryParse(txtYear.Text, intYear) Then
            MsgBox("Please input the Year of Publication correctly")
            Return False
        End If
        Return True
    End Function

    Private Function ValidateAddedBook() As Boolean
        If ValidateTextBoxes() Then
            If ValidateISBN() And ValidateYear() Then
                decISBN = CDec(txtISBN.Text)
                Dim i
                For i = 0 To DataGridViewListofBook.Rows.Count - 1
                    If CDec(DataGridViewListofBook.Rows(i).Cells(0).Value) = decISBN Then
                        MsgBox("Sorry, the book is already exist")
                        Return False
                    End If
                Next
            Else
                Return False
            End If

            Return True
        End If

        Return False
    End Function

    Dim strTitle As String
    Dim strAuthor As String
    Dim strPublisher As String
    Dim strCategory As String
    Private Function ValidateUpdatedBook() As Boolean
        If ValidateTextBoxes() Then
            If ValidateISBN() And ValidateYear() Then
                decISBN = CDec(txtISBN.Text)
                intYear = CInt(txtYear.Text)
                strTitle = txtTitle.Text
                strAuthor = txtAuthor.Text
                strPublisher = txtPublisher.Text
                strCategory = txtCategory.Text

                Dim i
                For i = 0 To DataGridViewListofBook.Rows.Count - 1
                    If CDec(DataGridViewListofBook.Rows(i).Cells(0).Value) = decISBN And CInt(DataGridViewListofBook.Rows(i).Cells(1).Value) = intYear And
                    DataGridViewListofBook.Rows(i).Cells(2).Value.ToString = strTitle And DataGridViewListofBook.Rows(i).Cells(3).Value.ToString = strAuthor And
                    DataGridViewListofBook.Rows(i).Cells(4).Value.ToString = strPublisher And DataGridViewListofBook.Rows(i).Cells(5).Value.ToString = strCategory Then
                        MsgBox("Nothing to update")
                        Return False
                    End If
                Next
            Else
                Return False
            End If

            If key = 0 Then
                MsgBox("Please select the book to update")
                Return False
            End If

            Return True
        End If

        Return False
    End Function

    Private Function ValidateDeletedBook() As Boolean
        If ValidateTextBoxes() Then
            If key = 0 Then
                MsgBox("Please select the book to delete")
                Return False
            Else
                Return True
            End If

            Return True
        End If

        Return False
    End Function

    Private Function ConfirmationOfDeletedBook() As Boolean
        Select Case MsgBox("You will permanently loss the data" & ControlChars.CrLf & "Are you sure to continue?", vbYesNo)

            Case MsgBoxResult.Yes
                Return True
            Case MsgBoxResult.No
                Return False
        End Select
    End Function

    Private Sub BookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayHeader()
    End Sub

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
                If ValidateSearchByISBN() Then
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateAddedBook() Then
            Dim query = "insert into book values(" & txtISBN.Text & "," & txtYear.Text & ",'" & txtTitle.Text & "','" & txtAuthor.Text & "','" & txtPublisher.Text & "','" & txtCategory.Text & "')"
            SQLCommandBasic(query)
            MsgBox("Book Saved")
            DisplayTable()
            ClearTextBoxes()
        End If
        ResetKey()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ValidateUpdatedBook() Then
            Dim query = "update Book set ISBN=" & txtISBN.Text & ",YearofPublication=" & txtYear.Text & ",Title='" & txtTitle.Text & "',Author='" &
                    txtAuthor.Text & "',Publisher='" & txtPublisher.Text & "',Category='" & txtCategory.Text & "' where ISBN=" & key & ""
            SQLCommandBasic(query)
            MsgBox("Book Updated")
            DisplayTable()
            ClearTextBoxes()
        End If
        ResetKey()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ValidateDeletedBook() Then
            If ConfirmationOfDeletedBook() Then
                Dim query = "delete from Book where ISBN=" & key & ""
                SQLCommandBasic(query)
                MsgBox("Book Deleted")
                DisplayTable()
            End If
        End If
        ClearTextBoxes()
        ResetKey()
    End Sub

    Private Sub btnListofBooks_Click(sender As Object, e As EventArgs) Handles btnListofBooks.Click
        DisplayTable()
        ClearTextBoxes()
        ResetKey()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Reset()
        Me.Close()
    End Sub

End Class