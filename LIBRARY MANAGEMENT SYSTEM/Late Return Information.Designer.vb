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
        Dim BorrowerICLabel As System.Windows.Forms.Label
        Dim LateReturnFinesLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.dgvLateReturnFine = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.txtLateReturnFines = New System.Windows.Forms.TextBox()
        Me.txtBorrowerIC = New System.Windows.Forms.TextBox()
        Me.dtpDatePaynment = New System.Windows.Forms.DateTimePicker()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtFinePayment = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdGenerateReceipt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSearchLateReturnFines = New System.Windows.Forms.Button()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchLateReturnInformation = New System.Windows.Forms.TextBox()
        Me.pdReceipt = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnListLateReturn = New System.Windows.Forms.Button()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        BorrowerICLabel = New System.Windows.Forms.Label()
        LateReturnFinesLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvLateReturnFine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorrowerICLabel
        '
        BorrowerICLabel.AutoSize = True
        BorrowerICLabel.Location = New System.Drawing.Point(24, 81)
        BorrowerICLabel.Name = "BorrowerICLabel"
        BorrowerICLabel.Size = New System.Drawing.Size(103, 19)
        BorrowerICLabel.TabIndex = 8
        BorrowerICLabel.Text = "Borrower IC:"
        '
        'LateReturnFinesLabel
        '
        LateReturnFinesLabel.AutoSize = True
        LateReturnFinesLabel.Location = New System.Drawing.Point(24, 123)
        LateReturnFinesLabel.Name = "LateReturnFinesLabel"
        LateReturnFinesLabel.Size = New System.Drawing.Size(143, 19)
        LateReturnFinesLabel.TabIndex = 10
        LateReturnFinesLabel.Text = "Late Return Fines:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(24, 40)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(128, 19)
        Label3.TabIndex = 12
        Label3.Text = "Borrower Name:"
        '
        'dgvLateReturnFine
        '
        Me.dgvLateReturnFine.AllowUserToAddRows = False
        Me.dgvLateReturnFine.AllowUserToDeleteRows = False
        Me.dgvLateReturnFine.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLateReturnFine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLateReturnFine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvLateReturnFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLateReturnFine.Location = New System.Drawing.Point(24, 237)
        Me.dgvLateReturnFine.Name = "dgvLateReturnFine"
        Me.dgvLateReturnFine.ReadOnly = True
        Me.dgvLateReturnFine.RowHeadersWidth = 51
        Me.dgvLateReturnFine.RowTemplate.Height = 24
        Me.dgvLateReturnFine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLateReturnFine.Size = New System.Drawing.Size(600, 369)
        Me.dgvLateReturnFine.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.txtBalance)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtBorrowerName)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(LateReturnFinesLabel)
        Me.GroupBox2.Controls.Add(Me.txtLateReturnFines)
        Me.GroupBox2.Controls.Add(BorrowerICLabel)
        Me.GroupBox2.Controls.Add(Me.txtBorrowerIC)
        Me.GroupBox2.Controls.Add(Me.dtpDatePaynment)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.txtFinePayment)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmdGenerateReceipt)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(646, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 398)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fines Payment"
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.BackColor = System.Drawing.Color.Black
        Me.txtBorrowerName.ForeColor = System.Drawing.Color.White
        Me.txtBorrowerName.Location = New System.Drawing.Point(194, 32)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(241, 27)
        Me.txtBorrowerName.TabIndex = 13
        '
        'txtLateReturnFines
        '
        Me.txtLateReturnFines.BackColor = System.Drawing.Color.Black
        Me.txtLateReturnFines.ForeColor = System.Drawing.Color.White
        Me.txtLateReturnFines.Location = New System.Drawing.Point(194, 120)
        Me.txtLateReturnFines.Name = "txtLateReturnFines"
        Me.txtLateReturnFines.Size = New System.Drawing.Size(241, 27)
        Me.txtLateReturnFines.TabIndex = 11
        '
        'txtBorrowerIC
        '
        Me.txtBorrowerIC.BackColor = System.Drawing.Color.Black
        Me.txtBorrowerIC.ForeColor = System.Drawing.Color.White
        Me.txtBorrowerIC.Location = New System.Drawing.Point(194, 78)
        Me.txtBorrowerIC.Name = "txtBorrowerIC"
        Me.txtBorrowerIC.Size = New System.Drawing.Size(241, 27)
        Me.txtBorrowerIC.TabIndex = 9
        '
        'dtpDatePaynment
        '
        Me.dtpDatePaynment.CustomFormat = "dd/mm/yyyy"
        Me.dtpDatePaynment.Location = New System.Drawing.Point(155, 243)
        Me.dtpDatePaynment.Name = "dtpDatePaynment"
        Me.dtpDatePaynment.Size = New System.Drawing.Size(304, 27)
        Me.dtpDatePaynment.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(54, 304)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 66)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtFinePayment
        '
        Me.txtFinePayment.BackColor = System.Drawing.Color.Black
        Me.txtFinePayment.ForeColor = System.Drawing.Color.White
        Me.txtFinePayment.Location = New System.Drawing.Point(194, 161)
        Me.txtFinePayment.Name = "txtFinePayment"
        Me.txtFinePayment.Size = New System.Drawing.Size(241, 27)
        Me.txtFinePayment.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Date payment : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Insert fine payment : "
        '
        'cmdGenerateReceipt
        '
        Me.cmdGenerateReceipt.BackColor = System.Drawing.Color.White
        Me.cmdGenerateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGenerateReceipt.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerateReceipt.ForeColor = System.Drawing.Color.Black
        Me.cmdGenerateReceipt.Location = New System.Drawing.Point(266, 304)
        Me.cmdGenerateReceipt.Name = "cmdGenerateReceipt"
        Me.cmdGenerateReceipt.Size = New System.Drawing.Size(134, 66)
        Me.cmdGenerateReceipt.TabIndex = 1
        Me.cmdGenerateReceipt.Text = "Generate Receipt"
        Me.cmdGenerateReceipt.UseVisualStyleBackColor = False
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
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue", 64.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(97, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(949, 131)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "LATE RETURN INFORMATION"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(971, 540)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(134, 66)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnListLateReturn
        '
        Me.btnListLateReturn.BackColor = System.Drawing.Color.White
        Me.btnListLateReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListLateReturn.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListLateReturn.ForeColor = System.Drawing.Color.Black
        Me.btnListLateReturn.Location = New System.Drawing.Point(661, 540)
        Me.btnListLateReturn.Name = "btnListLateReturn"
        Me.btnListLateReturn.Size = New System.Drawing.Size(134, 66)
        Me.btnListLateReturn.TabIndex = 10
        Me.btnListLateReturn.Text = "List of Late Return Books"
        Me.btnListLateReturn.UseVisualStyleBackColor = False
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Black
        Me.txtBalance.ForeColor = System.Drawing.Color.White
        Me.txtBalance.Location = New System.Drawing.Point(194, 201)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(241, 27)
        Me.txtBalance.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Balance:"
        '
        'LateReturnInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1127, 633)
        Me.Controls.Add(Me.btnListLateReturn)
        Me.Controls.Add(Me.btnBack)
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdSearchLateReturnFines As Button
    Friend WithEvents cboSearchBy As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchLateReturnInformation As TextBox
    Friend WithEvents pdReceipt As Printing.PrintDocument
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents dtpDatePaynment As DateTimePicker
    Friend WithEvents btnBack As Button
    Friend WithEvents txtFinePayment As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLateReturnFines As TextBox
    Friend WithEvents txtBorrowerIC As TextBox
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents btnListLateReturn As Button
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Label6 As Label
End Class
