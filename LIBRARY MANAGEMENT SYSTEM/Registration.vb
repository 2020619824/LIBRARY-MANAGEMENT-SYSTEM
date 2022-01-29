﻿Imports System.Data.SqlClient
Public Class Registration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            If validateStaffID() = True And validatePhoneNo() = True And validatePassword() = True Then
                con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30"
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from Users where StaffID = '" & txtStaffID.Text & "'"
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MyMessageBox.ShowMessage("Staff ID has been registered")
                    txtStaffID.Clear()
                    txtStaffID.Focus()
                    con.Close()
                Else
                    con.Close()
                    con.Open()
                    cmd = New SqlCommand("Insert into Users values('" & txtStaffID.Text & "','" & txtName.Text & "'," & txtPhoneNumber.Text & ",'" & txtUsername.Text & "','" & txtPassword.Text & "')", con)
                    If (txtName.Text = "" And txtStaffID.Text = "" And txtPhoneNumber.Text = "" And txtUsername.Text = "" And txtPassword.Text = "") Then
                        MyMessageBox.ShowMessage("Staff ID has been registered")
                    Else
                        cmd.ExecuteNonQuery()
                        MyMessageBox.ShowMessage("Sucessfully Registered")
                        txtName.Clear()
                        txtStaffID.Clear()
                        txtPhoneNumber.Clear()
                        txtUsername.Clear()
                        txtPassword.Clear()
                        Me.Hide()
                        Login.ShowDialog()
                    End If
                    con.Close()
                End If
                con.Close()
            End If

        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub
    Private Function validateTextBoxes() As Boolean
        If txtName.Text = "" Or txtStaffID.Text = "" Or txtPhoneNumber.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MyMessageBox.ShowMessage("Missing Information")
            txtName.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function validateStaffID() As Boolean
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
                intPW_LettersAndNumbersCount = intPW_LettersAndNumbersCount + 1
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
    Private Function validatePhoneNo() As Boolean
        Dim decPhoneNo As Decimal
        If Not Decimal.TryParse(txtPhoneNumber.Text, decPhoneNo) Then
            MyMessageBox.ShowMessage("Please enter a valid phone number only")
            txtPhoneNumber.Focus()
            Return False
        End If

        Return True

    End Function
    Public Function validatePassword() As Boolean
        Dim strUserPassword As String
        strUserPassword = txtPassword.Text

        If strUserPassword = Nothing Then
            MyMessageBox.ShowMessage("Password Missing")
            txtPassword.Focus()
            Return False
        End If

        If strUserPassword.Length < 8 Or strUserPassword.Length > 12 Then
            MyMessageBox.ShowMessage("Password must be between 8 to 12 charaters")
            Return False
        End If
        'To check if the password has bad characters
        Dim intPW_InvalidCharsCount As Integer = 0
        Dim intPW_LettersAndNumbersCount As Integer = 0

        For i = 0 To strUserPassword.Length - 1
            If (Asc(strUserPassword.Substring(i, 1)) >= 65 _
                And Asc(strUserPassword.Substring(i, 1)) <= 90) _
                Or (Asc(strUserPassword.Substring(i, 1)) >= 97 _
                And Asc(strUserPassword.Substring(i, 1)) <= 122) _
                Or (Asc(strUserPassword.Substring(i, 1)) >= 48 _
                And Asc(strUserPassword.Substring(i, 1)) <= 57) Then

                intPW_LettersAndNumbersCount = intPW_LettersAndNumbersCount + 1
            Else
                intPW_InvalidCharsCount = intPW_InvalidCharsCount
                txtPassword.Focus()
            End If
        Next

        If intPW_InvalidCharsCount > 0 Then
            MyMessageBox.ShowMessage("Password must contain only letters and numbers only")
            txtPassword.Focus()
            Return False
        End If

        Dim intPWLetterCount As Integer = 0

        For i = 0 To strUserPassword.Length - 1
            If Asc(strUserPassword.Substring(i, 1)) >= 65 _
                And Asc(strUserPassword.Substring(i, 1)) <= 90 Then
                intPWLetterCount = intPWLetterCount + 1
            End If

            If Asc(strUserPassword.Substring(i, 1)) >= 97 _
                And Asc(strUserPassword.Substring(i, 1)) <= 122 Then
                intPWLetterCount = intPWLetterCount + 1
            End If
        Next

        If intPWLetterCount = 0 Then
            MyMessageBox.ShowMessage("Password must contain at least one Alphabet Letter")
            txtPassword.Focus()
            Return False
        End If

        Dim intPWNumbersCount As Integer = 0
        For i = 0 To strUserPassword.Length - 1
            If Asc(strUserPassword.Substring(i, 1)) >= 48 _
                And Asc(strUserPassword.Substring(i, 1)) <= 57 Then
                intPWNumbersCount = intPWNumbersCount + 1
            End If
        Next

        If intPWNumbersCount = 0 Then
            MyMessageBox.ShowMessage("Password must contain at least one number")
            txtPassword.Focus()
            Return False
        End If

        Return True

    End Function
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Reset()
        Me.Hide()
        StartUp.ShowDialog()
    End Sub
End Class