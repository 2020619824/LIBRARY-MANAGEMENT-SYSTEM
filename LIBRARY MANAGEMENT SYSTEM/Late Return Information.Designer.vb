<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LateReturnInformation
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.List_Borrowed_Book = New LIBRARY_MANAGEMENT_SYSTEM.List_Borrowed_Book()
        Me.ListBorrowedBookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchBook = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.List_Borrowed_Book, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListBorrowedBookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.DataSource = Me.ListBorrowedBookBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 151)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(762, 369)
        Me.DataGridView1.TabIndex = 0
        '
        'List_Borrowed_Book
        '
        Me.List_Borrowed_Book.DataSetName = "List_Borrowed_Book"
        Me.List_Borrowed_Book.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListBorrowedBookBindingSource
        '
        Me.ListBorrowedBookBindingSource.DataSource = Me.List_Borrowed_Book
        Me.ListBorrowedBookBindingSource.Position = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(818, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 483)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fines Payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total amount late fine : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(94, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Generate Receipt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Insert fine payment : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Date payment : "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 22)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 162)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(241, 22)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(17, 233)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(241, 22)
        Me.TextBox3.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchBook)
        Me.GroupBox1.Controls.Add(Me.cboSearchBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSearchBook)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 72)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Late Return Information"
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Location = New System.Drawing.Point(472, 18)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(112, 41)
        Me.btnSearchBook.TabIndex = 18
        Me.btnSearchBook.Text = "Search"
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'cboSearchBy
        '
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Borrower's name", "IC number"})
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
        'LateReturnInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 576)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "LateReturnInformation"
        Me.Text = "Late Return Information"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.List_Borrowed_Book, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListBorrowedBookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ListBorrowedBookBindingSource As BindingSource
    Friend WithEvents List_Borrowed_Book As List_Borrowed_Book
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearchBook As Button
    Friend WithEvents cboSearchBy As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchBook As TextBox
End Class
