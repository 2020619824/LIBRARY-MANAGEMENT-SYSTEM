<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchBook = New System.Windows.Forms.TextBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdListOfUsers = New System.Windows.Forms.Button()
        Me.cmdReturn = New System.Windows.Forms.Button()
        Me.DataGridViewListOfUsers = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewListOfUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtStaffID)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.txtStaffName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 257)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User's Detail"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(143, 192)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(174, 22)
        Me.txtPhoneNumber.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Staff name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Staff ID :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Phone number : "
        '
        'txtStaffID
        '
        Me.txtStaffID.Location = New System.Drawing.Point(143, 142)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(174, 22)
        Me.txtStaffID.TabIndex = 8
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(143, 52)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(174, 22)
        Me.txtUsername.TabIndex = 6
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(143, 93)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(174, 22)
        Me.txtStaffName.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearchBook)
        Me.GroupBox2.Controls.Add(Me.cboSearchBy)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSearchBook)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search User"
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Location = New System.Drawing.Point(472, 27)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(112, 41)
        Me.btnSearchBook.TabIndex = 18
        Me.btnSearchBook.Text = "Search"
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'cboSearchBy
        '
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Staff ID", "Username"})
        Me.cboSearchBy.Location = New System.Drawing.Point(323, 27)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(119, 24)
        Me.cboSearchBy.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "By"
        '
        'txtSearchBook
        '
        Me.txtSearchBook.Location = New System.Drawing.Point(20, 27)
        Me.txtSearchBook.Name = "txtSearchBook"
        Me.txtSearchBook.Size = New System.Drawing.Size(267, 22)
        Me.txtSearchBook.TabIndex = 0
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(454, 114)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(142, 50)
        Me.cmdUpdate.TabIndex = 10
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(454, 178)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(142, 50)
        Me.cmdDelete.TabIndex = 11
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdListOfUsers
        '
        Me.cmdListOfUsers.Location = New System.Drawing.Point(454, 242)
        Me.cmdListOfUsers.Name = "cmdListOfUsers"
        Me.cmdListOfUsers.Size = New System.Drawing.Size(142, 50)
        Me.cmdListOfUsers.TabIndex = 12
        Me.cmdListOfUsers.Text = "List of Users"
        Me.cmdListOfUsers.UseVisualStyleBackColor = True
        '
        'cmdReturn
        '
        Me.cmdReturn.Location = New System.Drawing.Point(454, 303)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(142, 50)
        Me.cmdReturn.TabIndex = 13
        Me.cmdReturn.Text = "Return"
        Me.cmdReturn.UseVisualStyleBackColor = True
        '
        'DataGridViewListOfUsers
        '
        Me.DataGridViewListOfUsers.AllowUserToAddRows = False
        Me.DataGridViewListOfUsers.AllowUserToDeleteRows = False
        Me.DataGridViewListOfUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewListOfUsers.Location = New System.Drawing.Point(13, 382)
        Me.DataGridViewListOfUsers.Name = "DataGridViewListOfUsers"
        Me.DataGridViewListOfUsers.ReadOnly = True
        Me.DataGridViewListOfUsers.RowHeadersWidth = 51
        Me.DataGridViewListOfUsers.RowTemplate.Height = 24
        Me.DataGridViewListOfUsers.Size = New System.Drawing.Size(601, 303)
        Me.DataGridViewListOfUsers.TabIndex = 14
        '
        'UserInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 697)
        Me.Controls.Add(Me.DataGridViewListOfUsers)
        Me.Controls.Add(Me.cmdReturn)
        Me.Controls.Add(Me.cmdListOfUsers)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserInformation"
        Me.Text = "User Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewListOfUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearchBook As Button
    Friend WithEvents cboSearchBy As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchBook As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdListOfUsers As Button
    Friend WithEvents cmdReturn As Button
    Friend WithEvents DataGridViewListOfUsers As DataGridView
End Class
