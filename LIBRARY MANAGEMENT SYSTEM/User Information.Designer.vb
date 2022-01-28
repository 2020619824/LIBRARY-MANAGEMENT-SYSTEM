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
        Me.btnSearchUser = New System.Windows.Forms.Button()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchUser = New System.Windows.Forms.TextBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdListOfUsers = New System.Windows.Forms.Button()
        Me.cmdReturn = New System.Windows.Forms.Button()
        Me.dgvListOfUsers = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListOfUsers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(20, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 257)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User's Detail"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(180, 190)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(174, 31)
        Me.txtPhoneNumber.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Staff name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Staff ID :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Phone number : "
        '
        'txtStaffID
        '
        Me.txtStaffID.Location = New System.Drawing.Point(180, 139)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(174, 31)
        Me.txtStaffID.TabIndex = 8
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(180, 49)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(174, 31)
        Me.txtUsername.TabIndex = 6
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(180, 93)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(174, 31)
        Me.txtStaffName.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearchUser)
        Me.GroupBox2.Controls.Add(Me.cboSearchBy)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSearchUser)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(20, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search User"
        '
        'btnSearchUser
        '
        Me.btnSearchUser.BackColor = System.Drawing.Color.White
        Me.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchUser.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchUser.ForeColor = System.Drawing.Color.Black
        Me.btnSearchUser.Location = New System.Drawing.Point(472, 21)
        Me.btnSearchUser.Name = "btnSearchUser"
        Me.btnSearchUser.Size = New System.Drawing.Size(112, 41)
        Me.btnSearchUser.TabIndex = 18
        Me.btnSearchUser.Text = "Search"
        Me.btnSearchUser.UseVisualStyleBackColor = False
        '
        'cboSearchBy
        '
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Staff ID", "Username"})
        Me.cboSearchBy.Location = New System.Drawing.Point(323, 27)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(119, 32)
        Me.cboSearchBy.TabIndex = 2
        Me.cboSearchBy.Text = "Staff ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "By"
        '
        'txtSearchUser
        '
        Me.txtSearchUser.Location = New System.Drawing.Point(20, 27)
        Me.txtSearchUser.Name = "txtSearchUser"
        Me.txtSearchUser.Size = New System.Drawing.Size(267, 31)
        Me.txtSearchUser.TabIndex = 0
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.Location = New System.Drawing.Point(480, 205)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(142, 50)
        Me.cmdUpdate.TabIndex = 10
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Location = New System.Drawing.Point(480, 269)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(142, 50)
        Me.cmdDelete.TabIndex = 11
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdListOfUsers
        '
        Me.cmdListOfUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdListOfUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdListOfUsers.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListOfUsers.ForeColor = System.Drawing.Color.White
        Me.cmdListOfUsers.Location = New System.Drawing.Point(480, 333)
        Me.cmdListOfUsers.Name = "cmdListOfUsers"
        Me.cmdListOfUsers.Size = New System.Drawing.Size(142, 50)
        Me.cmdListOfUsers.TabIndex = 12
        Me.cmdListOfUsers.Text = "List of Users"
        Me.cmdListOfUsers.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdReturn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.Color.White
        Me.cmdReturn.Location = New System.Drawing.Point(480, 394)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(142, 50)
        Me.cmdReturn.TabIndex = 13
        Me.cmdReturn.Text = "Return"
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'dgvListOfUsers
        '
        Me.dgvListOfUsers.AllowUserToAddRows = False
        Me.dgvListOfUsers.AllowUserToDeleteRows = False
        Me.dgvListOfUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvListOfUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOfUsers.Location = New System.Drawing.Point(21, 470)
        Me.dgvListOfUsers.Name = "dgvListOfUsers"
        Me.dgvListOfUsers.ReadOnly = True
        Me.dgvListOfUsers.RowHeadersWidth = 51
        Me.dgvListOfUsers.RowTemplate.Height = 24
        Me.dgvListOfUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListOfUsers.Size = New System.Drawing.Size(601, 303)
        Me.dgvListOfUsers.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bebas Neue", 52.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(36, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(549, 105)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "USER INFORMATION"
        '
        'UserInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(634, 806)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvListOfUsers)
        Me.Controls.Add(Me.cmdReturn)
        Me.Controls.Add(Me.cmdListOfUsers)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvListOfUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearchUser As Button
    Friend WithEvents cboSearchBy As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchUser As TextBox
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
    Friend WithEvents dgvListOfUsers As DataGridView
    Friend WithEvents Label6 As Label
End Class
