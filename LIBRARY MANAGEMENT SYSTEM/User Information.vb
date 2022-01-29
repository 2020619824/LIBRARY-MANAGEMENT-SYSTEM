Imports System.Data.SqlClient
Public Class UserInformation

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30 ")
    Dim cmd As New SqlCommand
    Dim key = 0


    Private Sub ClearTextBoxes()
        ' This procedure will clear or empty the textBox of Username, StaffID, StaffName, PhoneNumber and list of user in DataGridView
        txtUsername.Clear()
        txtStaffID.Clear()
        txtStaffName.Clear()
        txtPhoneNumber.Clear()
        dgvListOfUsers.ClearSelection()
    End Sub

    Private Sub Reset()
        ' This procedure will clear the textBox and set the index for 
        txtUsername.Clear()
        txtStaffID.Clear()
        txtStaffName.Clear()
        txtPhoneNumber.Clear()
        txtSearchUser.Clear()
        cboSearchBy.SelectedIndex = 0
        dgvListOfUsers.DataSource.Clear()
    End Sub


    Dim decSearchStaffID As Decimal
    Private Function ValidateStaffID() As Boolean
        If Not Decimal.TryParse(txtSearchUser.Text, decSearchStaffID) Then
            MsgBox("Please input the ID correctly")
            Return False
        End If
        Return True
    End Function

    Private Sub btnSearchUser_Click(sender As Object, e As EventArgs) Handles btnSearchUser.Click

        Dim strSearchUsername As String

        Dim blnInvalidStaffID As Boolean
        blnInvalidStaffID = False

        If txtSearchUser.Text = "" Then
            MyMessageBox.ShowMessage("Missing Information")
        Else
            Dim query = ""
            If cboSearchBy.SelectedIndex = 0 Then

                If ValidateStaffID() Then
                    query = "select StaffID, StaffName, PhoneNo, Username from Users where StaffID=" & decSearchStaffID & ""
                    SQLCommandView(query, dgvListOfUsers)
                Else
                    blnInvalidStaffID = True
                End If
            ElseIf cboSearchBy.SelectedIndex = 1 Then
                strSearchUsername = txtSearchUser.Text
                query = "select StaffID, StaffName, PhoneNo, Username from Users where Username='" & strSearchUsername & "'"
                SQLCommandView(query, dgvListOfUsers)
            End If

            If blnInvalidStaffID = False Then
                If dgvListOfUsers.Rows.Count = 0 Then
                    MyMessageBox.ShowMessage("Sorry, no user found")
                Else
                    MyMessageBox.ShowMessage(dgvListOfUsers.Rows.Count & " User found!")
                End If
            End If

            ClearTextBoxes()
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If txtUsername.Text = "" Or txtStaffID.Text = "" Or txtStaffName.Text = "" Or txtPhoneNumber.Text = "" Then
            MyMessageBox.ShowMessage("Missing Information")
        Else
            Dim query = " update Users set StaffID = '" + txtStaffID.Text + "', StaffName = '" + txtStaffName.Text + "', 
                            Username = '" + txtUsername.Text + "', PhoneNo = '" + txtPhoneNumber.Text + "' where StaffID = " & key & ""
            SQLCommandBasic(query)
            MyMessageBox.ShowMessage("User Information Updated")
            query = "select StaffID, StaffName, PhoneNo, Username from Users"
            SQLCommandView(query, dgvListOfUsers)
            ClearTextBoxes()
        End If
    End Sub


    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        If key = 0 Or (txtUsername.Text = "" Or txtStaffID.Text = "" Or txtStaffName.Text = "" Or txtPhoneNumber.Text = "") Then
            MyMessageBox.ShowMessage("Missing Information")
        Else
            Dim query = "delete from Users where StaffID= " & key & ""
            SQLCommandBasic(query)
            MyMessageBox.ShowMessage("User Deleted")
            query = "select StaffID, StaffName, PhoneNo, Username from Users"
            SQLCommandView(query, dgvListOfUsers)
            ClearTextBoxes()
        End If
    End Sub

    Private Sub cmdListOfUsers_Click(sender As Object, e As EventArgs) Handles cmdListOfUsers.Click
        Dim query = "select StaffID, StaffName, PhoneNo, Username from Users"
        SQLCommandView(query, dgvListOfUsers)
        ClearTextBoxes()
    End Sub

    Private Sub DataGridViewListOfUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListOfUsers.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvListOfUsers.Rows(e.RowIndex)

            txtStaffID.Text = row.Cells(0).Value.ToString()
            txtStaffName.Text = row.Cells(1).Value.ToString()
            txtPhoneNumber.Text = row.Cells(2).Value.ToString()
            txtUsername.Text = row.Cells(3).Value.ToString()

            key = Convert.ToInt64(row.Cells(0).Value.ToString)

        End If
    End Sub

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        Me.Close()
        Reset()
    End Sub
End Class