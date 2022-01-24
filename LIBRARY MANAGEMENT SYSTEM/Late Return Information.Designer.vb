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
        Me.dgvLateReturnFine = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtTotalAmountLateFine = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdGenerateReceipt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSearchLateReturnFines = New System.Windows.Forms.Button()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchLateReturnInformation = New System.Windows.Forms.TextBox()
        Me.pdReceipt = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvLateReturnFine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLateReturnFine
        '
        Me.dgvLateReturnFine.AllowUserToOrderColumns = True
        Me.dgvLateReturnFine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLateReturnFine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvLateReturnFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLateReturnFine.Location = New System.Drawing.Point(24, 237)
        Me.dgvLateReturnFine.Name = "dgvLateReturnFine"
        Me.dgvLateReturnFine.RowHeadersWidth = 51
        Me.dgvLateReturnFine.RowTemplate.Height = 24
        Me.dgvLateReturnFine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLateReturnFine.Size = New System.Drawing.Size(600, 369)
        Me.dgvLateReturnFine.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.txtTotalAmountLateFine)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmdGenerateReceipt)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(646, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 470)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fines Payment"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(23, 190)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(241, 27)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(23, 119)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(241, 27)
        Me.TextBox2.TabIndex = 5
        '
        'txtTotalAmountLateFine
        '
        Me.txtTotalAmountLateFine.Location = New System.Drawing.Point(23, 45)
        Me.txtTotalAmountLateFine.Name = "txtTotalAmountLateFine"
        Me.txtTotalAmountLateFine.Size = New System.Drawing.Size(241, 27)
        Me.txtTotalAmountLateFine.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Date payment : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Insert fine payment : "
        '
        'cmdGenerateReceipt
        '
        Me.cmdGenerateReceipt.BackColor = System.Drawing.Color.White
        Me.cmdGenerateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGenerateReceipt.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerateReceipt.ForeColor = System.Drawing.Color.Black
        Me.cmdGenerateReceipt.Location = New System.Drawing.Point(184, 419)
        Me.cmdGenerateReceipt.Name = "cmdGenerateReceipt"
        Me.cmdGenerateReceipt.Size = New System.Drawing.Size(134, 45)
        Me.cmdGenerateReceipt.TabIndex = 1
        Me.cmdGenerateReceipt.Text = "Generate Receipt"
        Me.cmdGenerateReceipt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdGenerateReceipt.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total amount late fine : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSearchLateReturnFines)
        Me.GroupBox1.Controls.Add(Me.cboSearchBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSearchLateReturnInformation)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(24, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 72)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Late Return Information"
        '
        'cmdSearchLateReturnFines
        '
        Me.cmdSearchLateReturnFines.BackColor = System.Drawing.Color.White
        Me.cmdSearchLateReturnFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearchLateReturnFines.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearchLateReturnFines.ForeColor = System.Drawing.Color.Black
        Me.cmdSearchLateReturnFines.Location = New System.Drawing.Point(472, 18)
        Me.cmdSearchLateReturnFines.Name = "cmdSearchLateReturnFines"
        Me.cmdSearchLateReturnFines.Size = New System.Drawing.Size(112, 41)
        Me.cmdSearchLateReturnFines.TabIndex = 18
        Me.cmdSearchLateReturnFines.Text = "Search"
        Me.cmdSearchLateReturnFines.UseVisualStyleBackColor = False
        '
        'cboSearchBy
        '
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Borrower's name", "IC number"})
        Me.cboSearchBy.Location = New System.Drawing.Point(323, 27)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(119, 30)
        Me.cboSearchBy.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "By"
        '
        'txtSearchLateReturnInformation
        '
        Me.txtSearchLateReturnInformation.Location = New System.Drawing.Point(20, 27)
        Me.txtSearchLateReturnInformation.Name = "txtSearchLateReturnInformation"
        Me.txtSearchLateReturnInformation.Size = New System.Drawing.Size(267, 27)
        Me.txtSearchLateReturnInformation.TabIndex = 0
        '
        'pdReceipt
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue", 64.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(97, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(949, 131)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "LATE RETURN INFORMATION"
        '
        'LateReturnInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1127, 633)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvLateReturnFine)
        Me.Name = "LateReturnInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Late Return Information"
        CType(Me.dgvLateReturnFine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLateReturnFine As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdGenerateReceipt As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtTotalAmountLateFine As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdSearchLateReturnFines As Button
    Friend WithEvents cboSearchBy As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchLateReturnInformation As TextBox
    Friend WithEvents pdReceipt As Printing.PrintDocument
    Friend WithEvents Label2 As Label
End Class
