Imports System.Data.SqlClient
Public Class BorrowerInformation
    Private Sub DisplayTable()
        Dim query = "select b.* from Book b, borrow br
                    where b.isbn= br.isbn and br.BorrowerIC = " & txtBorrowerIC.Text & ""
        SQLCommandView(query, dgvBorrowerInfo)
    End Sub
    Private Function ValidateTextBoxes() As Boolean
        If txtBorrowerIC.Text = "" Or txtBorrowerName.Text = "" Or txtPhoneNum.Text = "" Or txtAddress.Text = "" Then
            MyMessageBox.ShowMessage("Missing Information")
            txtBorrowerName.Focus()
            Return False
        End If

        Return True
    End Function
    Private Sub btnSearchBorrower_Click(sender As Object, e As EventArgs) Handles btnSearchBorrower.Click
        Dim Con As New SqlConnection
        Dim cmd As New SqlCommand
        Con.ConnectionString = ""
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing
        Try

            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30")
            objcon.Open()
            Dim query As String = "Select * From Borrower Where BorrowerName = '" &
            txtSearchBorrowersName.Text & "'"
            objcmd = New SqlCommand(query, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                txtBorrowerName.Text = "" + reader(1).ToString
                txtBorrowerIC.Text = "" + reader(0).ToString
                txtPhoneNum.Text = "" + reader(2).ToString
                txtAddress.Text = "" + reader(3).ToString

            Else
                MyMessageBox.ShowMessage("This name is not available.")
            End If
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Reset()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Dim decBorrowerIC As Decimal
    Private Function ValidateBorrowerIC() As Boolean
        If Not Decimal.TryParse(txtBorrowerIC.Text, decBorrowerIC) Then
            MyMessageBox.ShowMessage("Please input the Borrower IC Correctly ")
            txtBorrowerIC.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function ValidateAddBorrower() As Boolean
        If ValidateTextBoxes() Then
            If ValidateBorrowerIC() Then
                decBorrowerIC = CDec(txtBorrowerIC.Text)
                Dim query = "Select * from borrower"
                SQLCommandView(query, dgvBorrowerInfo)
                Dim i
                For i = 0 To dgvBorrowerInfo.Rows.Count - 1
                    If CDec(dgvBorrowerInfo.Rows(i).Cells(0).Value) = decBorrowerIC Then
                        MyMessageBox.ShowMessage("Sorry, the book is already exist")

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
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateAddBorrower() Then
            Dim query = "insert into borrower values(" & txtBorrowerIC.Text & "," & txtBorrowerName.Text & ",'" & txtPhoneNum.Text & "','" & txtAddress.Text & "')"
            SQLCommandBasic(query)
            MyMessageBox.ShowMessage("Borrower Info Saved")
        End If

    End Sub

    Private Sub btnListBook_Click(sender As Object, e As EventArgs) Handles btnListBook.Click
        DisplayTable()
    End Sub
End Class