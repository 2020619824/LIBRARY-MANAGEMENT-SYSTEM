<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookDetails
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchBook = New System.Windows.Forms.TextBox()
        Me.dgvBookDetails = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnListofBooks = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBookDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchBook)
        Me.GroupBox1.Controls.Add(Me.cboSearchBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSearchBook)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(37, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Book"
        '
        'btnSearchBook
        '
        Me.btnSearchBook.BackColor = System.Drawing.Color.White
        Me.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchBook.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBook.ForeColor = System.Drawing.Color.Black
        Me.btnSearchBook.Location = New System.Drawing.Point(507, 18)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(130, 41)
        Me.btnSearchBook.TabIndex = 18
        Me.btnSearchBook.Text = "Search"
        Me.btnSearchBook.UseVisualStyleBackColor = False
        '
        'cboSearchBy
        '
        Me.cboSearchBy.BackColor = System.Drawing.Color.Black
        Me.cboSearchBy.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchBy.ForeColor = System.Drawing.Color.White
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"ISBN", "Author", "Book Title"})
        Me.cboSearchBy.Location = New System.Drawing.Point(349, 26)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(119, 27)
        Me.cboSearchBy.TabIndex = 2
        Me.cboSearchBy.Text = "ISBN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "By"
        '
        'txtSearchBook
        '
        Me.txtSearchBook.BackColor = System.Drawing.Color.Black
        Me.txtSearchBook.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBook.ForeColor = System.Drawing.Color.White
        Me.txtSearchBook.Location = New System.Drawing.Point(20, 27)
        Me.txtSearchBook.Name = "txtSearchBook"
        Me.txtSearchBook.Size = New System.Drawing.Size(286, 27)
        Me.txtSearchBook.TabIndex = 0
        '
        'dgvBookDetails
        '
        Me.dgvBookDetails.AllowUserToAddRows = False
        Me.dgvBookDetails.AllowUserToDeleteRows = False
        Me.dgvBookDetails.AllowUserToResizeColumns = False
        Me.dgvBookDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBookDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBookDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookDetails.BackgroundColor = System.Drawing.Color.Black
        Me.dgvBookDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBookDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBookDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookDetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBookDetails.EnableHeadersVisualStyles = False
        Me.dgvBookDetails.GridColor = System.Drawing.Color.White
        Me.dgvBookDetails.Location = New System.Drawing.Point(37, 526)
        Me.dgvBookDetails.MultiSelect = False
        Me.dgvBookDetails.Name = "dgvBookDetails"
        Me.dgvBookDetails.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBookDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBookDetails.RowHeadersWidth = 51
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBookDetails.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBookDetails.RowTemplate.Height = 24
        Me.dgvBookDetails.Size = New System.Drawing.Size(657, 244)
        Me.dgvBookDetails.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(544, 219)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(130, 46)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(544, 277)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 46)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(544, 335)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 46)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnListofBooks
        '
        Me.btnListofBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnListofBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListofBooks.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListofBooks.Location = New System.Drawing.Point(544, 393)
        Me.btnListofBooks.Name = "btnListofBooks"
        Me.btnListofBooks.Size = New System.Drawing.Size(130, 59)
        Me.btnListofBooks.TabIndex = 5
        Me.btnListofBooks.Text = "List of Books"
        Me.btnListofBooks.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(544, 464)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(130, 46)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCategory)
        Me.GroupBox2.Controls.Add(Me.txtPublisher)
        Me.GroupBox2.Controls.Add(Me.txtAuthor)
        Me.GroupBox2.Controls.Add(Me.txtTitle)
        Me.GroupBox2.Controls.Add(Me.txtYear)
        Me.GroupBox2.Controls.Add(Me.txtISBN)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(37, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 291)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book's Details"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.Black
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.ForeColor = System.Drawing.Color.White
        Me.txtCategory.Location = New System.Drawing.Point(177, 244)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(255, 27)
        Me.txtCategory.TabIndex = 29
        '
        'txtPublisher
        '
        Me.txtPublisher.BackColor = System.Drawing.Color.Black
        Me.txtPublisher.Font = New System.Drawing.Font("Arial", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.ForeColor = System.Drawing.Color.White
        Me.txtPublisher.Location = New System.Drawing.Point(177, 202)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(255, 27)
        Me.txtPublisher.TabIndex = 28
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.Black
        Me.txtAuthor.Font = New System.Drawing.Font("Arial", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.ForeColor = System.Drawing.Color.White
        Me.txtAuthor.Location = New System.Drawing.Point(177, 160)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(255, 27)
        Me.txtAuthor.TabIndex = 27
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Black
        Me.txtTitle.Font = New System.Drawing.Font("Arial", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(177, 118)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(255, 27)
        Me.txtTitle.TabIndex = 26
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.Black
        Me.txtYear.Font = New System.Drawing.Font("Arial", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.Color.White
        Me.txtYear.Location = New System.Drawing.Point(177, 76)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(255, 27)
        Me.txtYear.TabIndex = 25
        '
        'txtISBN
        '
        Me.txtISBN.BackColor = System.Drawing.Color.Black
        Me.txtISBN.Font = New System.Drawing.Font("Arial", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.ForeColor = System.Drawing.Color.White
        Me.txtISBN.Location = New System.Drawing.Point(177, 34)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(255, 27)
        Me.txtISBN.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(36, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Category of Book :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(45, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Publisher Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(103, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Author :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(82, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Book Title :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Year of Publication :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(114, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ISBN :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Bebas Neue", 64.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(12, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(711, 121)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "BOOKS DETAILS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BookDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(735, 805)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnListofBooks)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvBookDetails)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBookDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvBookDetails As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnListofBooks As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents txtSearchBook As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSearchBy As ComboBox
    Friend WithEvents YearOfPublicationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSearchBook As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
End Class
