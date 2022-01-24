<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowerInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cnbReturn = New System.Windows.Forms.Button()
        Me.lblTitleBorrower = New System.Windows.Forms.Label()
        Me.lbllblBorrowerName = New System.Windows.Forms.Label()
        Me.lbllblBorrowerIC = New System.Windows.Forms.Label()
        Me.lbllblPhoneNum = New System.Windows.Forms.Label()
        Me.lbllblAddress = New System.Windows.Forms.Label()
        Me.lblBorrowerAddress = New System.Windows.Forms.Label()
        Me.lblBorrowerPhoneNumber = New System.Windows.Forms.Label()
        Me.lblBorrowerIC = New System.Windows.Forms.Label()
        Me.lblBorrowerName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchBorrower = New System.Windows.Forms.Button()
        Me.txtSearchBorrowersName = New System.Windows.Forms.TextBox()
        Me.DataGridViewBorrower = New System.Windows.Forms.DataGridView()
        Me.cnbReturnBook = New System.Windows.Forms.Button()
        Me.cnbLateReturnPage = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewBorrower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cnbReturn
        '
        Me.cnbReturn.BackColor = System.Drawing.Color.Red
        Me.cnbReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cnbReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnbReturn.ForeColor = System.Drawing.Color.Black
        Me.cnbReturn.Location = New System.Drawing.Point(509, 574)
        Me.cnbReturn.Name = "cnbReturn"
        Me.cnbReturn.Size = New System.Drawing.Size(118, 54)
        Me.cnbReturn.TabIndex = 6
        Me.cnbReturn.Text = "Return"
        Me.cnbReturn.UseVisualStyleBackColor = False
        '
        'lblTitleBorrower
        '
        Me.lblTitleBorrower.AutoSize = True
        Me.lblTitleBorrower.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleBorrower.ForeColor = System.Drawing.Color.White
        Me.lblTitleBorrower.Location = New System.Drawing.Point(34, 23)
        Me.lblTitleBorrower.Name = "lblTitleBorrower"
        Me.lblTitleBorrower.Size = New System.Drawing.Size(158, 32)
        Me.lblTitleBorrower.TabIndex = 7
        Me.lblTitleBorrower.Text = "Borrower's"
        '
        'lbllblBorrowerName
        '
        Me.lbllblBorrowerName.AutoSize = True
        Me.lbllblBorrowerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllblBorrowerName.Location = New System.Drawing.Point(87, 78)
        Me.lbllblBorrowerName.Name = "lbllblBorrowerName"
        Me.lbllblBorrowerName.Size = New System.Drawing.Size(53, 17)
        Me.lbllblBorrowerName.TabIndex = 8
        Me.lbllblBorrowerName.Text = "Name :"
        '
        'lbllblBorrowerIC
        '
        Me.lbllblBorrowerIC.AutoSize = True
        Me.lbllblBorrowerIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllblBorrowerIC.Location = New System.Drawing.Point(112, 116)
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
        Me.lbllblPhoneNum.Location = New System.Drawing.Point(40, 248)
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
        Me.lbllblAddress.Location = New System.Drawing.Point(82, 290)
        Me.lbllblAddress.Name = "lbllblAddress"
        Me.lbllblAddress.Size = New System.Drawing.Size(68, 17)
        Me.lbllblAddress.TabIndex = 11
        Me.lbllblAddress.Text = "Address :"
        '
        'lblBorrowerAddress
        '
        Me.lblBorrowerAddress.BackColor = System.Drawing.Color.White
        Me.lblBorrowerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorrowerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerAddress.ForeColor = System.Drawing.Color.Black
        Me.lblBorrowerAddress.Location = New System.Drawing.Point(155, 290)
        Me.lblBorrowerAddress.Name = "lblBorrowerAddress"
        Me.lblBorrowerAddress.Size = New System.Drawing.Size(472, 67)
        Me.lblBorrowerAddress.TabIndex = 12
        '
        'lblBorrowerPhoneNumber
        '
        Me.lblBorrowerPhoneNumber.BackColor = System.Drawing.Color.White
        Me.lblBorrowerPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorrowerPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerPhoneNumber.ForeColor = System.Drawing.Color.Black
        Me.lblBorrowerPhoneNumber.Location = New System.Drawing.Point(157, 248)
        Me.lblBorrowerPhoneNumber.Name = "lblBorrowerPhoneNumber"
        Me.lblBorrowerPhoneNumber.Size = New System.Drawing.Size(470, 31)
        Me.lblBorrowerPhoneNumber.TabIndex = 13
        '
        'lblBorrowerIC
        '
        Me.lblBorrowerIC.BackColor = System.Drawing.Color.White
        Me.lblBorrowerIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorrowerIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerIC.ForeColor = System.Drawing.Color.Black
        Me.lblBorrowerIC.Location = New System.Drawing.Point(146, 116)
        Me.lblBorrowerIC.Name = "lblBorrowerIC"
        Me.lblBorrowerIC.Size = New System.Drawing.Size(396, 23)
        Me.lblBorrowerIC.TabIndex = 14
        '
        'lblBorrowerName
        '
        Me.lblBorrowerName.BackColor = System.Drawing.Color.White
        Me.lblBorrowerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorrowerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerName.ForeColor = System.Drawing.Color.Black
        Me.lblBorrowerName.Location = New System.Drawing.Point(146, 77)
        Me.lblBorrowerName.Name = "lblBorrowerName"
        Me.lblBorrowerName.Size = New System.Drawing.Size(396, 25)
        Me.lblBorrowerName.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.btnSearchBorrower)
        Me.GroupBox1.Controls.Add(Me.lblBorrowerIC)
        Me.GroupBox1.Controls.Add(Me.lblBorrowerName)
        Me.GroupBox1.Controls.Add(Me.txtSearchBorrowersName)
        Me.GroupBox1.Controls.Add(Me.lbllblBorrowerName)
        Me.GroupBox1.Controls.Add(Me.lbllblBorrowerIC)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(40, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 155)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Borrower's Name"
        '
        'btnSearchBorrower
        '
        Me.btnSearchBorrower.BackColor = System.Drawing.Color.Red
        Me.btnSearchBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBorrower.ForeColor = System.Drawing.Color.Black
        Me.btnSearchBorrower.Location = New System.Drawing.Point(430, 18)
        Me.btnSearchBorrower.Name = "btnSearchBorrower"
        Me.btnSearchBorrower.Size = New System.Drawing.Size(112, 41)
        Me.btnSearchBorrower.TabIndex = 18
        Me.btnSearchBorrower.Text = "Search"
        Me.btnSearchBorrower.UseVisualStyleBackColor = False
        '
        'txtSearchBorrowersName
        '
        Me.txtSearchBorrowersName.ForeColor = System.Drawing.Color.Black
        Me.txtSearchBorrowersName.Location = New System.Drawing.Point(42, 27)
        Me.txtSearchBorrowersName.Name = "txtSearchBorrowersName"
        Me.txtSearchBorrowersName.Size = New System.Drawing.Size(376, 22)
        Me.txtSearchBorrowersName.TabIndex = 0
        '
        'DataGridViewBorrower
        '
        Me.DataGridViewBorrower.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBorrower.Location = New System.Drawing.Point(40, 373)
        Me.DataGridViewBorrower.Name = "DataGridViewBorrower"
        Me.DataGridViewBorrower.RowHeadersWidth = 51
        Me.DataGridViewBorrower.RowTemplate.Height = 24
        Me.DataGridViewBorrower.Size = New System.Drawing.Size(587, 178)
        Me.DataGridViewBorrower.TabIndex = 17
        '
        'cnbReturnBook
        '
        Me.cnbReturnBook.BackColor = System.Drawing.Color.Red
        Me.cnbReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cnbReturnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnbReturnBook.ForeColor = System.Drawing.Color.Black
        Me.cnbReturnBook.Location = New System.Drawing.Point(43, 575)
        Me.cnbReturnBook.Name = "cnbReturnBook"
        Me.cnbReturnBook.Size = New System.Drawing.Size(118, 54)
        Me.cnbReturnBook.TabIndex = 18
        Me.cnbReturnBook.Text = "Return Book"
        Me.cnbReturnBook.UseVisualStyleBackColor = False
        '
        'cnbLateReturnPage
        '
        Me.cnbLateReturnPage.BackColor = System.Drawing.Color.Red
        Me.cnbLateReturnPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cnbLateReturnPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnbLateReturnPage.ForeColor = System.Drawing.Color.Black
        Me.cnbLateReturnPage.Location = New System.Drawing.Point(167, 575)
        Me.cnbLateReturnPage.Name = "cnbLateReturnPage"
        Me.cnbLateReturnPage.Size = New System.Drawing.Size(118, 54)
        Me.cnbLateReturnPage.TabIndex = 19
        Me.cnbLateReturnPage.Text = "Go to late return page "
        Me.cnbLateReturnPage.UseVisualStyleBackColor = False
        '
        'BorrowerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(671, 658)
        Me.Controls.Add(Me.cnbLateReturnPage)
        Me.Controls.Add(Me.cnbReturnBook)
        Me.Controls.Add(Me.DataGridViewBorrower)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblBorrowerPhoneNumber)
        Me.Controls.Add(Me.lblBorrowerAddress)
        Me.Controls.Add(Me.lbllblAddress)
        Me.Controls.Add(Me.lbllblPhoneNum)
        Me.Controls.Add(Me.lblTitleBorrower)
        Me.Controls.Add(Me.cnbReturn)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "BorrowerInformation"
        Me.Text = "Borrower Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewBorrower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cnbReturn As Button
    Friend WithEvents lblTitleBorrower As Label
    Friend WithEvents lbllblBorrowerName As Label
    Friend WithEvents lbllblBorrowerIC As Label
    Friend WithEvents lbllblPhoneNum As Label
    Friend WithEvents lbllblAddress As Label
    Friend WithEvents lblBorrowerAddress As Label
    Friend WithEvents lblBorrowerPhoneNumber As Label
    Friend WithEvents lblBorrowerIC As Label
    Friend WithEvents lblBorrowerName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearchBorrower As Button
    Friend WithEvents txtSearchBorrowersName As TextBox
    Friend WithEvents DataGridViewBorrower As DataGridView
    Friend WithEvents cnbReturnBook As Button
    Friend WithEvents cnbLateReturnPage As Button
End Class
