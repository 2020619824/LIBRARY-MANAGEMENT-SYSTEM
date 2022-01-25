
Imports System.Data.SqlClient

Public Class UserInformation

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\2020619824\LIBRARY-MANAGEMENT-SYSTEM\LIBRARY MANAGEMENT SYSTEM\Database1.mdf;Integrated Security=True;Connect Timeout=30 ")
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub DisplayTable()
        Dim query = "select * from Users"
        SQLCommandView(query, dgvListOfUsers)
    End Sub
    Private Sub ClearTextBoxes()
        txtUsername.Clear()
        txtStaffID.Clear()
        txtStaffName.Clear()
        txtPhoneNumber.Clear()
        dgvListOfUsers.ClearSelection()
    End Sub

    Private Sub Reset()
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

    Private Sub cmdListOfUsers_Click(sender As Object, e As EventArgs) Handles cmdListOfUsers.Click
        Dim query = "select StaffID, StaffName, PhoneNo, Username from Users"
        SQLCommandView(query, dgvListOfUsers)
        ClearTextBoxes()
    End Sub

    Dim key = 0
    Private Sub DataGridViewListOfUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListOfUsers.CellClick

        Try
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            i = Convert.ToInt32(dgvListOfUsers.SelectedCells.Item(0).Value.ToString())
            key = Convert.ToInt32(dgvListOfUsers.SelectedCells.Item(0).Value.ToString())
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " select * from Users where StaffID = " & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read

                txtStaffID.Text = dr.GetString(0).ToString()
                txtStaffName.Text = dr.GetString(1).ToString()
                txtPhoneNumber.Text = dr.GetSqlDecimal(2).ToString()
                txtUsername.Text = dr.GetString(3).ToString()

            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If txtUsername.Text = "" Or txtStaffID.Text = "" Or txtStaffName.Text = "" Or txtPhoneNumber.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim query = " update Users set StaffID = '" + txtStaffID.Text + "', StaffName = '" + txtStaffName.Text + "', 
                            Username = '" + txtUsername.Text + "', PhoneNo = '" + txtPhoneNumber.Text + "' where StaffID = " & i & ""
            SQLCommandBasic(query)
            MsgBox("User Information Updated")
            query = "select StaffID, StaffName, PhoneNo, Username from Users"
            SQLCommandView(query, dgvListOfUsers)
            ClearTextBoxes()
        End If

    End Sub


    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        If key = 0 Or (txtUsername.Text = "" Or txtStaffID.Text = "" Or txtStaffName.Text = "" Or txtPhoneNumber.Text = "") Then
            MsgBox("Missing Information")
        Else
            Dim query = "delete from Users where StaffID= " & key & ""
            SQLCommandBasic(query)
            MsgBox("User Deleted")
            query = "select StaffID, StaffName, PhoneNo, Username from Users"
            SQLCommandView(query, dgvListOfUsers)
            ClearTextBoxes()
        End If

    End Sub


    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click

        Dim strSearchUsername As String

        Dim blnInvalidStaffID As Boolean
        blnInvalidStaffID = False

        If txtSearchUser.Text = "" Then
            MsgBox("Missing Information")
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
                query = "select StaffID, StaffName, PhoneNo, Username from Users where Username='" & strSearchUsername & ""
                SQLCommandView(query, dgvListOfUsers)
            End If



            If blnInvalidStaffID = False Then
                If dgvListOfUsers.Rows.Count = 0 Then
                    MsgBox("Sorry, no user found")
                Else
                    MsgBox(dgvListOfUsers.Rows.Count & " User found!")
                End If
            End If

            ClearTextBoxes()
        End If
    End Sub
    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        Me.Close()
        Reset()
    End Sub
    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " select * from Users"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvListOfUsers.DataSource = dt

    End Sub

    Private Sub cboSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchBy.SelectedIndexChanged

    End Sub

    Private Sub UserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class