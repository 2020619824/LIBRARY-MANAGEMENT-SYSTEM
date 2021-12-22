<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookReturnInformation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.txtBorrowerIC = New System.Windows.Forms.TextBox()
        Me.cboBorrowerName = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchBorrower = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnLateReturn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrower's Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Borrower's IC :"
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Location = New System.Drawing.Point(160, 105)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(466, 22)
        Me.txtBorrowerName.TabIndex = 2
        '
        'txtBorrowerIC
        '
        Me.txtBorrowerIC.Location = New System.Drawing.Point(160, 148)
        Me.txtBorrowerIC.Name = "txtBorrowerIC"
        Me.txtBorrowerIC.Size = New System.Drawing.Size(466, 22)
        Me.txtBorrowerIC.TabIndex = 3
        '
        'cboBorrowerName
        '
        Me.cboBorrowerName.FormattingEnabled = True
        Me.cboBorrowerName.Location = New System.Drawing.Point(33, 42)
        Me.cboBorrowerName.Name = "cboBorrowerName"
        Me.cboBorrowerName.Size = New System.Drawing.Size(432, 24)
        Me.cboBorrowerName.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBorrowerName)
        Me.GroupBox1.Controls.Add(Me.btnSearchBorrower)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboBorrowerName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBorrowerIC)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 191)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Borrower's Name"
        '
        'btnSearchBorrower
        '
        Me.btnSearchBorrower.Location = New System.Drawing.Point(511, 31)
        Me.btnSearchBorrower.Name = "btnSearchBorrower"
        Me.btnSearchBorrower.Size = New System.Drawing.Size(115, 45)
        Me.btnSearchBorrower.TabIndex = 5
        Me.btnSearchBorrower.Text = "Search"
        Me.btnSearchBorrower.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 218)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(657, 303)
        Me.DataGridView1.TabIndex = 6
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(561, 543)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(130, 66)
        Me.btnReturn.TabIndex = 7
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnReturnBook
        '
        Me.btnReturnBook.Location = New System.Drawing.Point(35, 543)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(161, 66)
        Me.btnReturnBook.TabIndex = 8
        Me.btnReturnBook.Text = "Return Book"
        Me.btnReturnBook.UseVisualStyleBackColor = True
        '
        'btnLateReturn
        '
        Me.btnLateReturn.Location = New System.Drawing.Point(281, 543)
        Me.btnLateReturn.Name = "btnLateReturn"
        Me.btnLateReturn.Size = New System.Drawing.Size(195, 66)
        Me.btnLateReturn.TabIndex = 9
        Me.btnLateReturn.Text = "Go to Late Return Page"
        Me.btnLateReturn.UseVisualStyleBackColor = True
        '
        'BookReturnInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(722, 631)
        Me.Controls.Add(Me.btnLateReturn)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BookReturnInformation"
        Me.Text = "Book Return Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents txtBorrowerIC As TextBox
    Friend WithEvents cboBorrowerName As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearchBorrower As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents btnLateReturn As Button
End Class
