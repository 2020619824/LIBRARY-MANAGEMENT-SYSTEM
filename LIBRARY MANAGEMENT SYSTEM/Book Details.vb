Imports System.Data.SqlClient

Public Class BookDetails
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\CS110\SEMESTER 3\CSC301\GROUP PROJECT\PROJECT\LIBRARY MANAGEMENT SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")

    Private Sub DisplayTable()
        Dim query = "select * from Book"
        SQLCommandView(query, dgvBookDetails)
    End Sub

    Private Sub DisplayHeader()
        Dim query = "select * from Book where ISBN is null"
        SQLCommandView(query, dgvBookDetails)
        dgvBookDetails().Columns(1).HeaderText = "Year"
    End Sub

    Dim key = 0
    Private Sub DataGridViewListofBook_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBookDetails.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBookDetails.Rows(e.RowIndex)

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
        dgvBookDetails.ClearSelection()
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
        dgvBookDetails.DataSource.Clear()
    End Sub
    Private Sub ResetKey()
        key = 0
    End Sub

    Private Function ValidateTextBoxes() As Boolean
        If txtISBN.Text = "" Or txtYear.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtPublisher.Text = "" Or txtCategory.Text = "" Then
            MyMessageBox.ShowMessage("Missing Information")
            txtISBN.Focus()
            Return False
        End If

        Return True
    End Function

    Dim decSearchISBN As Decimal
    Private Function ValidateSearchByISBN() As Boolean
        If Not Decimal.TryParse(txtSearchBook.Text, decSearchISBN) Then
            MyMessageBox.ShowMessage("Please input the ISBN correctly")
            txtSearchBook.Clear()
            txtSearchBook.Focus()
            Return False
        End If
        Return True
    End Function

    Dim decISBN As Decimal
    Private Function ValidateISBN() As Boolean
        If Not Decimal.TryParse(txtISBN.Text, decISBN) Then
            MyMessageBox.ShowMessage("Please input the ISBN correctly")
            txtISBN.Focus()
            Return False
        End If
        Return True
    End Function

    Dim intYear As Integer
    Private Function ValidateYear() As Boolean
        If Not Integer.TryParse(txtYear.Text, intYear) Then
            MyMessageBox.ShowMessage("Please input the Year of Publication correctly")
            txtYear.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function ValidateAddedBook() As Boolean
        If ValidateTextBoxes() Then
            If ValidateISBN() And ValidateYear() Then
                decISBN = CDec(txtISBN.Text)
                Dim i
                For i = 0 To dgvBookDetails.Rows.Count - 1
                    If CDec(dgvBookDetails.Rows(i).Cells(0).Value) = decISBN Then
                        MyMessageBox.ShowMessage("Sorry, the book is already exist")
                        ClearTextBoxes()
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
                For i = 0 To dgvBookDetails.Rows.Count - 1
                    If CDec(dgvBookDetails.Rows(i).Cells(0).Value) = decISBN And CInt(dgvBookDetails.Rows(i).Cells(1).Value) = intYear And
                    dgvBookDetails.Rows(i).Cells(2).Value.ToString = strTitle And dgvBookDetails.Rows(i).Cells(3).Value.ToString = strAuthor And
                    dgvBookDetails.Rows(i).Cells(4).Value.ToString = strPublisher And dgvBookDetails.Rows(i).Cells(5).Value.ToString = strCategory Then
                        MyMessageBox.ShowMessage("Nothing to update")
                        dgvBookDetails.ClearSelection()
                        Return False
                    End If
                Next
            Else
                Return False
            End If

            If key = 0 Then
                MyMessageBox.ShowMessage("Please select the book to update")
                dgvBookDetails.ClearSelection()
                Return False
            End If

            Return True
        End If

        Return False
    End Function

    Private Function ValidateDeletedBook() As Boolean
        If key = 0 Then
            MyMessageBox.ShowMessage("Please select the book to delete")
            Return False
        Else
            Return True
            End If

        Return True

        Return False
    End Function

    Private Function ConfirmationOfDeletedBook() As Boolean
        Select Case MyMessageBox.ShowConfirmation("You will permanently loss the data" & ControlChars.CrLf & "Are you sure to continue?")
            Case DialogResult.Yes
                Return True
            Case DialogResult.No
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
            MyMessageBox.ShowMessage("Missing Information")
            txtSearchBook.Focus()
        Else
            Dim query = ""
            If cboSearchBy.SelectedIndex = 0 Then
                If ValidateSearchByISBN() Then
                    query = "select * from book where ISBN=" & decSearchISBN & ""
                    SQLCommandView(query, dgvBookDetails)
                Else
                    blnInvalidISBN = True
                End If
            ElseIf cboSearchBy.SelectedIndex = 1 Then
                strSearchAuthor = txtSearchBook.Text
                query = "select * from book where Author='" & strSearchAuthor & "'"
            SQLCommandView(query, dgvBookDetails)
            ElseIf cboSearchBy.SelectedIndex = 2 Then
                strSearchTitle = txtSearchBook.Text
                query = "select * from book where Title='" & strSearchTitle & "'"
                SQLCommandView(query, dgvBookDetails)
            End If

            If blnInvalidISBN = False Then
                If dgvBookDetails.Rows.Count = 0 Then
                    MyMessageBox.ShowMessage("Sorry, no book found")
                Else
                    MyMessageBox.ShowMessage(dgvBookDetails.Rows.Count & " Book found!")
                End If
            End If
            key = 0
            ClearTextBoxes()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateAddedBook() Then
            Dim query = "insert into book values(" & txtISBN.Text & "," & txtYear.Text & ",'" & txtTitle.Text & "','" & txtAuthor.Text & "','" & txtPublisher.Text & "','" & txtCategory.Text & "')"
            SQLCommandBasic(query)
            MyMessageBox.ShowMessage("Book Saved")
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
            MyMessageBox.ShowMessage("Book Updated")
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
                MyMessageBox.ShowMessage("Book Deleted")
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