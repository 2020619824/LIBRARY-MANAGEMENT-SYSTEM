Imports System.Data.SqlClient

Public Class Registration
    Dim blnPasswordValid As Boolean = False
    Dim blnAllInputDataIsValid As Boolean = False
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        StartUp.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            blnPasswordValid = False
            DoValidations()

            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Users where StaffID = ' " & txtStaffID.Text & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MyMessageBox.ShowMessage("Staff ID has been registered")
                con.Close()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("Insert into Users values(' " & txtStaffID.Text & "','" & txtName.Text & "','" & txtPhoneNumber.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "')", con)
                If (txtName.Text = "" And txtStaffID.Text = "" And txtPhoneNumber.Text = "" And txtUsername.Text = "" And txtPassword.Text = "") Then
                    MyMessageBox.ShowMessage("Please enter the details")
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
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub
    Public Sub validatePassword()
        Dim strUserPassword As String
        strUserPassword = txtPassword.Text

        Dim blnPasswordNotBlank As Boolean = False
        Dim blnPasswordLengthValid As Boolean = False
        Dim blnLettersAndNumbersOnly As Boolean = False
        Dim blnPasswordContainsLetters As Boolean = False
        Dim blnPasswordContainsNumbers As Boolean = False
        Dim blnPasswordValid As Boolean = False

        blnPasswordValid = False

        'To chack if the password is not left blank
        If strUserPassword = Nothing Then
            blnPasswordNotBlank = False
            MyMessageBox.ShowMessage("Password Missing")
            txtPassword.Focus()
        Else
            blnPasswordNotBlank = True
        End If

        'To check if the password is 8 charachters or longer 
        If strUserPassword.Length < 8 Then
            blnPasswordLengthValid = False
            MyMessageBox.ShowMessage("Password must be between 8 to 12 charachters")
            txtPassword.Focus()
        Else
            blnPasswordLengthValid = True
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
                intPW_InvalidCharsCount = intPW_InvalidCharsCount + 1
                txtPassword.Focus()
            End If
        Next

        If intPW_InvalidCharsCount > 0 Then
            blnLettersAndNumbersOnly = False
            MyMessageBox.ShowMessage("Password must contain only letters and numbers only")
            txtPassword.Focus()
        Else
            blnLettersAndNumbersOnly = True
        End If

        Dim intPWNumbersCount As Integer = 0

        For i = 0 To strUserPassword.Length - 1
            If Asc(strUserPassword.Substring(i, 1)) >= 48 _
                And Asc(strUserPassword.Substring(i, 1)) <= 57 Then
                intPWNumbersCount = intPWNumbersCount + 1
            End If
        Next

        If intPW_LettersAndNumbersCount = 0 Then
            blnPasswordContainsLetters = False
            MyMessageBox.ShowMessage("Password must contain Leter")
            txtPassword.Focus()
        Else
            blnPasswordContainsLetters = True
        End If

        For i = 0 To strUserPassword.Length - 1
            If Asc(strUserPassword.Substring(i, 1)) >= 48 _
                And Asc(strUserPassword.Substring(i, 1)) <= 57 Then
                intPWNumbersCount = intPWNumbersCount + 1
            End If
        Next

        If intPWNumbersCount = 0 Then
            blnPasswordContainsNumbers = False
            MyMessageBox.ShowMessage("Password must contain at least one number")
            txtPassword.Focus()
        Else
            blnPasswordContainsNumbers = True
        End If

        If blnPasswordNotBlank = True _
            And blnPasswordLengthValid = True _
            And blnLettersAndNumbersOnly = True _
            And blnPasswordContainsLetters = True _
            And blnPasswordContainsNumbers = True Then

            blnPasswordValid = True

        End If

    End Sub
    Public Sub DoValidations()
        If blnPasswordValid = False Then
            validatePassword()
        End If
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Reset()
        Me.Close()
    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class