
Imports System.Data.SqlClient
Public Class Login

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If (Me.chkShowPassword.Checked = False) Then
            Me.txtGetPassword.PasswordChar = "*"c
        Else
            Me.txtGetPassword.PasswordChar = ""
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Con As New SqlConnection
        Dim cmd As New SqlCommand
        Con.ConnectionString = ""
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing
        Try

            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30")
            objcon.Open()
            Dim query As String = "Select * From Users Where Username = '" &
            txtGetUserName.Text & "' AND Password = '" &
            txtGetPassword.Text & "'"

            objcmd = New SqlCommand(query, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MyMessageBox.ShowMessage("Login Successfully")
                Me.Hide()
                MenuList.ShowDialog()
            Else
                MyMessageBox.ShowMessage("Invalid Login. Please try Again.")
                txtGetUserName.Clear()
                txtGetPassword.Clear()
            End If
        Catch ex As Exception
            MyMessageBox.ShowMessage("Connection Error")
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Reset()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtGetPassword.PasswordChar = "*"c
    End Sub
End Class