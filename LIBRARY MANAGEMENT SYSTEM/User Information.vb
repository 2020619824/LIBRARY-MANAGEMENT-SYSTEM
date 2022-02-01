﻿Imports System.Data.SqlClient
Public Class UserInformation

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30 ")
    Dim key = 0

    Private Sub DisplayHeader()
        Dim query = "select StaffID, StaffName, PhoneNo, Username from Users where StaffID is null"
        SQLCommandView(query, dgvListOfUsers)
    End Sub
    Private Sub ClearTextBoxes()
        ' This function will empty the textBox of Username, StaffID, StaffName, PhoneNumber and list of user in DataGridView
        txtUsername.Clear()
        txtStaffID.Clear()
        txtStaffName.Clear()
        txtPhoneNumber.Clear()
        dgvListOfUsers.ClearSelection()
    End Sub

    ' This function will be used in return button 
    Private Sub Reset()
        txtUsername.Clear()
        txtStaffID.Clear()
        txtStaffName.Clear()
        txtPhoneNumber.Clear()
        txtSearchUser.Clear()
        cboSearchBy.SelectedIndex = 0
        dgvListOfUsers.DataSource.Clear()
    End Sub

    Private Sub UserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayHeader()
    End Sub

    Dim decSearchStaffID As Decimal
    Private Function ValidateStaffID() As Boolean
        Dim strStaffID As String
        strStaffID = txtStaffID.Text

        Dim intPW_InvalidCharsCount As Integer = 0
        Dim intPW_LettersAndNumbersCount As Integer = 0

        For i = 0 To strStaffID.Length - 1
            If (Asc(strStaffID.Substring(i, 1)) >= 65 _
                And Asc(strStaffID.Substring(i, 1)) <= 90) _
                Or (Asc(strStaffID.Substring(i, 1)) >= 97 _
                And Asc(strStaffID.Substring(i, 1)) <= 122) _
                Or (Asc(strStaffID.Substring(i, 1)) >= 48 _
                And Asc(strStaffID.Substring(i, 1)) <= 57) Then
                intPW_LettersAndNumbersCount = intPW_LettersAndNumbersCount + 1
            Else
                intPW_InvalidCharsCount = intPW_InvalidCharsCount + 1
                txtStaffID.Focus()
            End If
        Next

        If intPW_InvalidCharsCount > 0 Then
            MyMessageBox.ShowMessage("Staff ID must contain letters and numbers only")
            txtStaffID.Focus()
            Return False
        End If

        Dim intPWLetterCount As Integer = 0

        For i = 0 To strStaffID.Length - 1
            If Asc(strStaffID.Substring(i, 1)) >= 65 _
                And Asc(strStaffID.Substring(i, 1)) <= 90 Then
                intPWLetterCount = intPWLetterCount + 1
            End If

            If Asc(strStaffID.Substring(i, 1)) >= 97 _
                And Asc(strStaffID.Substring(i, 1)) <= 122 Then
                intPWLetterCount = intPWLetterCount + 1
            End If
        Next

        If intPWLetterCount = 0 Then
            MyMessageBox.ShowMessage("Staff ID must contain at least one Alphabet Letter")
            txtStaffID.Focus()
            Return False
        End If

        Dim intPWNumbersCount As Integer = 0

        For i = 0 To strStaffID.Length - 1
            If Asc(strStaffID.Substring(i, 1)) >= 48 _
                And Asc(strStaffID.Substring(i, 1)) <= 57 Then
                intPWNumbersCount = intPWNumbersCount + 1
            End If
        Next

        If intPWNumbersCount = 0 Then
            MyMessageBox.ShowMessage("Staff ID must contain at least one number")
            txtStaffID.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnSearchUser_Click(sender As Object, e As EventArgs) Handles btnSearchUser.Click


        If txtSearchUser.Text = "" Then
            MyMessageBox.ShowMessage("Missing Information")
        Else
            Dim query = ""
            If cboSearchBy.SelectedIndex = 0 Then
                query = "select StaffID, StaffName, PhoneNo, Username from Users where StaffID='" & txtSearchUser.Text & "'"
                SQLCommandView(query, dgvListOfUsers)
            ElseIf cboSearchBy.SelectedIndex = 1 Then
                query = "select StaffID, StaffName, PhoneNo, Username from Users where Username='" & txtSearchUser.Text & "'"
                SQLCommandView(query, dgvListOfUsers)
            End If

            If dgvListOfUsers.Rows.Count = 0 Then
                MyMessageBox.ShowMessage("Sorry, no user found")
            Else
                MyMessageBox.ShowMessage(dgvListOfUsers.Rows.Count & " User found!")
            End If

            ClearTextBoxes()
        End If

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtUsername.Text = "" Or txtStaffID.Text = "" Or txtStaffName.Text = "" Or txtPhoneNumber.Text = "" Then
            MyMessageBox.ShowMessage("Missing Information")
        ElseIf ValidateStaffID() Then
            Dim query = " update Users set StaffID = '" + txtStaffID.Text + "', StaffName = '" + txtStaffName.Text + "', 
                            Username = '" + txtUsername.Text + "', PhoneNo = '" + txtPhoneNumber.Text + "' where StaffID = '" & key & "'"
            SQLCommandBasic(query)
            MyMessageBox.ShowMessage("User Information Updated")
            query = "select StaffID, StaffName, PhoneNo, Username from Users"
            SQLCommandView(query, dgvListOfUsers)
            ClearTextBoxes()
        End If
        key = ""
    End Sub

    ' To inform and get confirmation from the user to delete user in database (To avoid human error)
    Private Function ConfirmationOfDeletedUser() As Boolean
        Select Case MyMessageBox.ShowConfirmation("You will permanently loss the data" & ControlChars.CrLf & "Are you sure to continue?")
            Case DialogResult.Yes
                Return True
            Case DialogResult.No
                Return False
        End Select

        Return False
    End Function

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If key = "" Then
            MyMessageBox.ShowMessage("Missing Information")
        ElseIf ConfirmationOfDeletedUser() Then
            Dim query = "delete from Users where StaffID= '" & key & "'"
            SQLCommandBasic(query)
            MyMessageBox.ShowMessage("User Deleted")
            query = "select StaffID, StaffName, PhoneNo, Username from Users"
            SQLCommandView(query, dgvListOfUsers)
        End If
        ClearTextBoxes()
        key = ""
    End Sub

    Private Sub cmdListOfUsers_Click(sender As Object, e As EventArgs) Handles btnListOfUsers.Click
        Dim query = "select StaffID, StaffName, PhoneNo, Username from Users"
        SQLCommandView(query, dgvListOfUsers)
        ClearTextBoxes()
        key = ""
    End Sub

    Private Sub DataGridViewListOfUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListOfUsers.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvListOfUsers.Rows(e.RowIndex)

            txtStaffID.Text = row.Cells(0).Value.ToString()
            txtStaffName.Text = row.Cells(1).Value.ToString()
            txtPhoneNumber.Text = row.Cells(2).Value.ToString()
            txtUsername.Text = row.Cells(3).Value.ToString()

            key = row.Cells(0).Value.ToString

        End If
    End Sub

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        Reset()
    End Sub

End Class