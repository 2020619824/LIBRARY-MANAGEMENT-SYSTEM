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
        Me.btnReturn = New System.Windows.Forms.Button()
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
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnLateReturnPage = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewBorrower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.Black
        Me.btnReturn.Location = New System.Drawing.Point(434, 599)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(118, 54)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lblTitleBorrower
        '
        Me.lblTitleBorrower.AutoSize = True
        Me.lblTitleBorrower.Font = New System.Drawing.Font("Bebas Neue", 39.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleBorrower.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitleBorrower.Location = New System.Drawing.Point(22, 20)
        Me.lblTitleBorrower.Name = "lblTitleBorrower"
        Me.lblTitleBorrower.Size = New System.Drawing.Size(546, 79)
        Me.lblTitleBorrower.TabIndex = 7
        Me.lblTitleBorrower.Text = "BORROWERS INFORMATION"
        '
        'lbllblBorrowerName
        '
        Me.lbllblBorrowerName.AutoSize = True
        Me.lbllblBorrowerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllblBorrowerName.Location = New System.Drawing.Point(42, 72)
        Me.lbllblBorrowerName.Name = "lbllblBorrowerName"
        Me.lbllblBorrowerName.Size = New System.Drawing.Size(53, 17)
        Me.lbllblBorrowerName.TabIndex = 8
        Me.lbllblBorrowerName.Text = "Name :"
        '
        'lbllblBorrowerIC
        '
        Me.lbllblBorrowerIC.AutoSize = True
        Me.lbllblBorrowerIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllblBorrowerIC.Location = New System.Drawing.Point(67, 110)
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
        Me.lbllblPhoneNum.Location = New System.Drawing.Point(40, 290)
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
        Me.lbllblAddress.Location = New System.Drawing.Point(81, 334)
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
        Me.lblBorrowerAddress.Location = New System.Drawing.Point(151, 333)
        Me.lblBorrowerAddress.Name = "lblBorrowerAddress"
        Me.lblBorrowerAddress.Size = New System.Drawing.Size(401, 67)
        Me.lblBorrowerAddress.TabIndex = 12
        '
        'lblBorrowerPhoneNumber
        '
        Me.lblBorrowerPhoneNumber.BackColor = System.Drawing.Color.White
        Me.lblBorrowerPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorrowerPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerPhoneNumber.ForeColor = System.Drawing.Color.Black
        Me.lblBorrowerPhoneNumber.Location = New System.Drawing.Point(151, 289)
        Me.lblBorrowerPhoneNumber.Name = "lblBorrowerPhoneNumber"
        Me.lblBorrowerPhoneNumber.Size = New System.Drawing.Size(401, 31)
        Me.lblBorrowerPhoneNumber.TabIndex = 13
        '
        'lblBorrowerIC
        '
        Me.lblBorrowerIC.BackColor = System.Drawing.Color.White
        Me.lblBorrowerIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorrowerIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerIC.ForeColor = System.Drawing.Color.Black
        Me.lblBorrowerIC.Location = New System.Drawing.Point(101, 110)
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
        Me.lblBorrowerName.Location = New System.Drawing.Point(101, 71)
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
        Me.GroupBox1.Location = New System.Drawing.Point(36, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 155)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Borrower's Name"
        '
        'btnSearchBorrower
        '
        Me.btnSearchBorrower.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearchBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBorrower.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBorrower.ForeColor = System.Drawing.Color.Black
        Me.btnSearchBorrower.Location = New System.Drawing.Point(375, 18)
        Me.btnSearchBorrower.Name = "btnSearchBorrower"
        Me.btnSearchBorrower.Size = New System.Drawing.Size(122, 40)
        Me.btnSearchBorrower.TabIndex = 18
        Me.btnSearchBorrower.Text = "Search"
        Me.btnSearchBorrower.UseVisualStyleBackColor = False
        '
        'txtSearchBorrowersName
        '
        Me.txtSearchBorrowersName.ForeColor = System.Drawing.Color.Black
        Me.txtSearchBorrowersName.Location = New System.Drawing.Point(28, 27)
        Me.txtSearchBorrowersName.Name = "txtSearchBorrowersName"
        Me.txtSearchBorrowersName.Size = New System.Drawing.Size(331, 22)
        Me.txtSearchBorrowersName.TabIndex = 0
        '
        'DataGridViewBorrower
        '
        Me.DataGridViewBorrower.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBorrower.Location = New System.Drawing.Point(36, 415)
        Me.DataGridViewBorrower.Name = "DataGridViewBorrower"
        Me.DataGridViewBorrower.RowHeadersWidth = 51
        Me.DataGridViewBorrower.RowTemplate.Height = 24
        Me.DataGridViewBorrower.Size = New System.Drawing.Size(516, 178)
        Me.DataGridViewBorrower.TabIndex = 17
        '
        'btnReturnBook
        '
        Me.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.ForeColor = System.Drawing.Color.Black
        Me.btnReturnBook.Location = New System.Drawing.Point(36, 599)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(118, 54)
        Me.btnReturnBook.TabIndex = 18
        Me.btnReturnBook.Text = "Return Book"
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'btnLateReturnPage
        '
        Me.btnLateReturnPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLateReturnPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLateReturnPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLateReturnPage.ForeColor = System.Drawing.Color.Black
        Me.btnLateReturnPage.Location = New System.Drawing.Point(160, 599)
        Me.btnLateReturnPage.Name = "btnLateReturnPage"
        Me.btnLateReturnPage.Size = New System.Drawing.Size(118, 54)
        Me.btnLateReturnPage.TabIndex = 19
        Me.btnLateReturnPage.Text = "Go to late return page "
        Me.btnLateReturnPage.UseVisualStyleBackColor = False
        '
        'BorrowerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(578, 676)
        Me.Controls.Add(Me.btnLateReturnPage)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.DataGridViewBorrower)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblBorrowerPhoneNumber)
        Me.Controls.Add(Me.lblBorrowerAddress)
        Me.Controls.Add(Me.lbllblAddress)
        Me.Controls.Add(Me.lbllblPhoneNum)
        Me.Controls.Add(Me.lblTitleBorrower)
        Me.Controls.Add(Me.btnReturn)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BorrowerInformation"
        Me.Text = "Borrower Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewBorrower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
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
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents btnLateReturnPage As Button
End Class
