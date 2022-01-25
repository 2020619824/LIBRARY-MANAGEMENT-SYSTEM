Imports System.Data.SqlClient

Public Class Registration
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

            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Users where StaffID = ' " & txtStaffID.Text & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Staff ID has been registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("Insert into Users values(' " & txtName.Text & "','" & txtStaffID.Text & "','" & txtPhoneNumber.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "')", con)
                If (txtName.Text = "" And txtStaffID.Text = "" And txtPhoneNumber.Text = "" And txtUsername.Text = "" And txtPassword.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Sucessfully Registered", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    Login.Show()
                    txtName.Clear()
                    txtStaffID.Clear()
                    txtPhoneNumber.Clear()
                    txtUsername.Clear()
                    txtPassword.Clear()

                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Please Enter Correct Details")
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Reset()
        Me.Close()
    End Sub
End Class