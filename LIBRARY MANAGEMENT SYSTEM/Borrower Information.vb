Imports System.Data.SqlClient
Public Class BorrowerInformation
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True")
    Private Sub DisplayHeader() 'header for datagrid'
        Dim query = "select * from Borrower where BorrowerIC is null"
        SQLCommandView(query, dgvBorrowerInfo)
    End Sub

    Private Sub DisplayTableBorrower() 'to get the borrower information from database and show it at the datagrid'
        Dim query = "select * from borrower where borrowername = '" & txtSearchBorrowersName.Text & "'"
        SQLCommandView(query, dgvBorrowerInfo)
    End Sub
    Private Sub DisplayTableBook() 'to get the numbers of book from book table at database'
        Dim query = "select b.* from Book b, borrow br
                    where b.isbn= br.isbn and br.BorrowerIC = " & txtBorrowerIC.Text & ""
        SQLCommandView(query, dgvBorrowerInfo)
    End Sub
    Private Function ValidateTextBoxes() As Boolean 'to inform user to put the full information'
        If txtBorrowerIC.Text = "" Or txtBorrowerName.Text = "" Or txtPhoneNum.Text = "" Or txtAddress.Text = "" Then
            MyMessageBox.ShowMessage("Missing Information")
            txtBorrowerName.Focus()
            Return False
        End If

        Return True
    End Function

    Dim key = 0 'sellected key bu the user'

    Private Sub resetKey() 'reset the key equal to 0 = no sellected key from user'
        key = 0
    End Sub
    'order the text box by the row from borrower table at database'
    Private Sub DataGridViewListofBook_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBorrowerInfo.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBorrowerInfo.Rows(e.RowIndex)

            txtBorrowerIC.Text = row.Cells(0).Value.ToString
            txtBorrowerName.Text = row.Cells(1).Value.ToString
            txtPhoneNum.Text = row.Cells(2).Value.ToString
            txtAddress.Text = row.Cells(3).Value.ToString

            key = Convert.ToInt64(row.Cells(0).Value.ToString)
            noBooksBorrowed()
        End If
    End Sub

    Private Sub ValidateSearch() 'to remind the user to put the name before system do the searching'
        If txtSearchBorrowersName.Text = ("") Then
            MyMessageBox.ShowMessage("Please input the name to search")
        End If
    End Sub
    'button searchborrower display after get click (search by name)'
    Private Sub btnSearchBorrower_Click(sender As Object, e As EventArgs) Handles btnSearchBorrower.Click
        ValidateSearch()
        DisplayTableBorrower()
        dgvBorrowerInfo.Enabled = True
    End Sub

    Private Sub reset() 'clear all the display'
        txtAddress.Clear()
        txtBorrowerIC.Clear()
        txtBorrowerName.Clear()
        txtPhoneNum.Clear()
        txtNoBooksBorrow.Clear()
        dgvBorrowerInfo.DataSource.clear()
        txtSearchBorrowersName.Clear()
        key = 0
    End Sub
    'button return function'
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click 'button for return to menu page'
        reset()
        Me.Close()
    End Sub

    Dim decBorrowerIC As Decimal 'declare the primary key'
    Private Function ValidateBorrowerIC() As Boolean 'inform the user to put the correct datatype'
        If Not Decimal.TryParse(txtBorrowerIC.Text, decBorrowerIC) Then
            MyMessageBox.ShowMessage("Please input the Borrower IC Correctly")
            txtBorrowerIC.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function ValidateAddBorrower() As Boolean 'inform the user that the number ic (pk) has been used'
        If ValidateTextBoxes() Then
            If ValidateBorrowerIC() Then
                Try
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim dr As SqlDataReader

                    con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30"
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from Borrower where BorrowerIC = " & decBorrowerIC & ""
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        MyMessageBox.ShowMessage("Sorry, the borrower is already exist")
                        con.Close()
                        Return False
                    End If
                    con.Close()
                Catch ex As Exception
                    MyMessageBox.ShowMessage("Connection Error")
                End Try
            Else
                Return False
            End If

            Return True
        End If

        Return False
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click 'function for button add'
        If ValidateAddBorrower() = True Then
            Dim query = "insert into borrower values(" & txtBorrowerIC.Text & ",'" & txtBorrowerName.Text & "'," & txtPhoneNum.Text & ",'" & txtAddress.Text & "')"
            SQLCommandBasic(query)
            MyMessageBox.ShowMessage("Borrower Info Saved")
            clearTextBox()
        End If
        resetKey()
    End Sub

    Private Sub noBooksBorrowed() 'function on get the num of books that has been borrowed by the borrower'

        Try
            Con.Open()
            Dim query = "select count(b.ISBN) from book b, borrow c
        where b.ISBN = c.ISBN  
        and c.borrowerIC = " & key & ""

            Dim cmd = New SqlCommand(query, Con)
            Dim dt = New DataTable()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                txtNoBooksBorrow.Text = "" + reader(0).ToString
            End While
            Con.Close()
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub
    Private Sub btnListBook_Click(sender As Object, e As EventArgs) Handles btnListBook.Click 'dispay the list of books that borrower borrowed'
        If ValidateTextBoxes() Then
            DisplayTableBook()
            dgvBorrowerInfo.Enabled = False
            dgvBorrowerInfo.ClearSelection()
        End If
        resetKey()
    End Sub

    Private Sub clearTextBox() 'function on clear the data that has been store by the user'
        txtAddress.Clear()
        txtBorrowerIC.Clear()
        txtBorrowerName.Clear()
        txtPhoneNum.Clear()
        txtNoBooksBorrow.Clear()
        dgvBorrowerInfo.ClearSelection()
    End Sub

    Private Function ConfirmationOfDeletedInfo() As Boolean 'funtion to warning the user that he will lost the borrower info permanently'
        Select Case MyMessageBox.ShowConfirmation("You will permanently loss this information" & ControlChars.CrLf & "Are you sure to continue?")
            Case DialogResult.Yes
                Return True
            Case DialogResult.No
                Return False
        End Select
        Return False
    End Function

    Private Function ValidateDeleteInfo() As Boolean 'remind the user to sellect the borrower to delete'
        If key = 0 Then
            MyMessageBox.ShowMessage("Please select the information to delete")

            Return False
        Else
            Return True
        End If

        Return True

        Return False

    End Function
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'function on delete the borrower'
        If ValidateDeleteInfo() Then
            If ConfirmationOfDeletedInfo() Then
                Dim query = "delete from Borrower where borrowerIC=" & key & ""
                SQLCommandBasic(query)
                MyMessageBox.ShowMessage("Information Deleted")

            End If
        End If
        clearTextBox()
        resetKey()
    End Sub
    Private Function ValidateUpdatedBorrowerInfo() As Boolean 'inform the user to sellect info from the data grid to do update action'
        If ValidateTextBoxes() Then

            If key = 0 Then
                MyMessageBox.ShowMessage("Please select the info to update")
                dgvBorrowerInfo.ClearSelection()
                Return False
            End If

            Return True
        End If

        Return False
    End Function
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click 'update action recall the function involve'
        If ValidateUpdatedBorrowerInfo() Then
            Dim query = "update Borrower set borrowerIC=" & txtBorrowerIC.Text & ",borrowerName='" & txtBorrowerName.Text & "',phoneNum=" & txtPhoneNum.Text & ",Address='" & txtAddress.Text & "' where borrowerIC = " & key & ""
            SQLCommandBasic(query)
            MyMessageBox.ShowMessage("Borrower Information Updated")
            DisplayTableBorrower()
            clearTextBox()
        End If
        resetKey()
    End Sub

    Private Sub BorrowerInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'display table from database at datagrid header'
        DisplayHeader()
    End Sub
End Class