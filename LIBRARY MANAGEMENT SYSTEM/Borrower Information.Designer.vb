<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowerInformation
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lbllblBorrowerName = New System.Windows.Forms.Label()
        Me.lbllblBorrowerIC = New System.Windows.Forms.Label()
        Me.lbllblPhoneNum = New System.Windows.Forms.Label()
        Me.lbllblAddress = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchBorrower = New System.Windows.Forms.Button()
        Me.txtSearchBorrowersName = New System.Windows.Forms.TextBox()
        Me.dgvBorrowerInfo = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtBorrowerIC = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNoBooksBorrow = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnListBook = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBorrowerInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.Black
        Me.btnReturn.Location = New System.Drawing.Point(577, 410)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(118, 54)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lbllblBorrowerName
        '
        Me.lbllblBorrowerName.AutoSize = True
        Me.lbllblBorrowerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllblBorrowerName.ForeColor = System.Drawing.Color.White
        Me.lbllblBorrowerName.Location = New System.Drawing.Point(63, 31)
        Me.lbllblBorrowerName.Name = "lbllblBorrowerName"
        Me.lbllblBorrowerName.Size = New System.Drawing.Size(53, 17)
        Me.lbllblBorrowerName.TabIndex = 8
        Me.lbllblBorrowerName.Text = "Name :"
        '
        'lbllblBorrowerIC
        '
        Me.lbllblBorrowerIC.AutoSize = True
        Me.lbllblBorrowerIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllblBorrowerIC.ForeColor = System.Drawing.Color.White
        Me.lbllblBorrowerIC.Location = New System.Drawing.Point(88, 69)
        Me.lbllblBorrowerIC.Name = "lbllblBorrowerIC"
        Me.lbllblBorrowerIC.Size = New System.Drawing.Size(28, 17)
        Me.lbllblBorrowerIC.TabIndex = 9
        Me.lbllblBorrowerIC.Text = "IC :"
        '
        'lbllblPhoneNum
        '
        Me.lbllblPhoneNum.AutoSize = True
        Me.lbllblPhoneNum.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbllblPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllblPhoneNum.ForeColor = System.Drawing.Color.White
        Me.lbllblPhoneNum.Location = New System.Drawing.Point(7, 113)
        Me.lbllblPhoneNum.Name = "lbllblPhoneNum"
        Me.lbllblPhoneNum.Size = New System.Drawing.Size(111, 17)
        Me.lbllblPhoneNum.TabIndex = 10
        Me.lbllblPhoneNum.Text = "Phone Number :"
        '
        'lbllblAddress
        '
        Me.lbllblAddress.AutoSize = True
        Me.lbllblAddress.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbllblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllblAddress.ForeColor = System.Drawing.Color.White
        Me.lbllblAddress.Location = New System.Drawing.Point(48, 157)
        Me.lbllblAddress.Name = "lbllblAddress"
        Me.lbllblAddress.Size = New System.Drawing.Size(68, 17)
        Me.lbllblAddress.TabIndex = 11
        Me.lbllblAddress.Text = "Address :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.btnSearchBorrower)
        Me.GroupBox1.Controls.Add(Me.txtSearchBorrowersName)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(35, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 72)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Borrower's Name"
        '
        'btnSearchBorrower
        '
        Me.btnSearchBorrower.BackColor = System.Drawing.Color.White
        Me.btnSearchBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBorrower.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBorrower.ForeColor = System.Drawing.Color.Black
        Me.btnSearchBorrower.Location = New System.Drawing.Point(384, 18)
        Me.btnSearchBorrower.Name = "btnSearchBorrower"
        Me.btnSearchBorrower.Size = New System.Drawing.Size(122, 40)
        Me.btnSearchBorrower.TabIndex = 18
        Me.btnSearchBorrower.Text = "Search"
        Me.btnSearchBorrower.UseVisualStyleBackColor = False
        '
        'txtSearchBorrowersName
        '
        Me.txtSearchBorrowersName.BackColor = System.Drawing.Color.Black
        Me.txtSearchBorrowersName.ForeColor = System.Drawing.Color.White
        Me.txtSearchBorrowersName.Location = New System.Drawing.Point(47, 27)
        Me.txtSearchBorrowersName.Name = "txtSearchBorrowersName"
        Me.txtSearchBorrowersName.Size = New System.Drawing.Size(323, 22)
        Me.txtSearchBorrowersName.TabIndex = 0
        '
        'dgvBorrowerInfo
        '
        Me.dgvBorrowerInfo.AllowUserToAddRows = False
        Me.dgvBorrowerInfo.AllowUserToDeleteRows = False
        Me.dgvBorrowerInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBorrowerInfo.BackgroundColor = System.Drawing.Color.Black
        Me.dgvBorrowerInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBorrowerInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrowerInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBorrowerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrowerInfo.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvBorrowerInfo.EnableHeadersVisualStyles = False
        Me.dgvBorrowerInfo.Location = New System.Drawing.Point(35, 482)
        Me.dgvBorrowerInfo.Name = "dgvBorrowerInfo"
        Me.dgvBorrowerInfo.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrowerInfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBorrowerInfo.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBorrowerInfo.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvBorrowerInfo.RowTemplate.Height = 24
        Me.dgvBorrowerInfo.Size = New System.Drawing.Size(660, 219)
        Me.dgvBorrowerInfo.TabIndex = 17
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(577, 183)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 56)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(577, 118)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 56)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtBorrowerIC
        '
        Me.txtBorrowerIC.BackColor = System.Drawing.Color.Black
        Me.txtBorrowerIC.ForeColor = System.Drawing.Color.White
        Me.txtBorrowerIC.Location = New System.Drawing.Point(122, 69)
        Me.txtBorrowerIC.Name = "txtBorrowerIC"
        Me.txtBorrowerIC.Size = New System.Drawing.Size(384, 22)
        Me.txtBorrowerIC.TabIndex = 19
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.BackColor = System.Drawing.Color.Black
        Me.txtPhoneNum.ForeColor = System.Drawing.Color.White
        Me.txtPhoneNum.Location = New System.Drawing.Point(122, 113)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(384, 22)
        Me.txtPhoneNum.TabIndex = 20
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.BackColor = System.Drawing.Color.Black
        Me.txtBorrowerName.ForeColor = System.Drawing.Color.White
        Me.txtBorrowerName.Location = New System.Drawing.Point(122, 31)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(384, 22)
        Me.txtBorrowerName.TabIndex = 21
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.Black
        Me.txtAddress.ForeColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(122, 152)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(384, 64)
        Me.txtAddress.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNoBooksBorrow)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.txtBorrowerName)
        Me.GroupBox2.Controls.Add(Me.lbllblPhoneNum)
        Me.GroupBox2.Controls.Add(Me.txtPhoneNum)
        Me.GroupBox2.Controls.Add(Me.lbllblBorrowerIC)
        Me.GroupBox2.Controls.Add(Me.txtBorrowerIC)
        Me.GroupBox2.Controls.Add(Me.lbllblAddress)
        Me.GroupBox2.Controls.Add(Me.lbllblBorrowerName)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(35, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 273)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrower's Details"
        '
        'txtNoBooksBorrow
        '
        Me.txtNoBooksBorrow.BackColor = System.Drawing.Color.Black
        Me.txtNoBooksBorrow.ForeColor = System.Drawing.Color.White
        Me.txtNoBooksBorrow.Location = New System.Drawing.Point(406, 228)
        Me.txtNoBooksBorrow.Name = "txtNoBooksBorrow"
        Me.txtNoBooksBorrow.Size = New System.Drawing.Size(100, 22)
        Me.txtNoBooksBorrow.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "No. of Books Borrow :"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(577, 245)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 56)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnListBook
        '
        Me.btnListBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnListBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListBook.ForeColor = System.Drawing.Color.Black
        Me.btnListBook.Location = New System.Drawing.Point(577, 307)
        Me.btnListBook.Name = "btnListBook"
        Me.btnListBook.Size = New System.Drawing.Size(118, 73)
        Me.btnListBook.TabIndex = 21
        Me.btnListBook.Text = "List of Books Borrow"
        Me.btnListBook.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(686, 96)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "BORROWER'S INFORMATION"
        '
        'BorrowerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(711, 717)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnListBook)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvBorrowerInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReturn)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BorrowerInformation"
        Me.Text = "Borrower Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBorrowerInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents lbllblBorrowerName As Label
    Friend WithEvents lbllblBorrowerIC As Label
    Friend WithEvents lbllblPhoneNum As Label
    Friend WithEvents lbllblAddress As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearchBorrower As Button
    Friend WithEvents txtSearchBorrowersName As TextBox
    Friend WithEvents dgvBorrowerInfo As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtBorrowerIC As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNoBooksBorrow As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnListBook As Button
    Friend WithEvents Label2 As Label
End Class