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
        Dim lblBorrowerIC As System.Windows.Forms.Label
        Dim lblTotalLateFines As System.Windows.Forms.Label
        Dim lblBorrowerName As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLateReturnFine = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.txtTotalLateReturnFines = New System.Windows.Forms.TextBox()
        Me.txtBorrowerIC = New System.Windows.Forms.TextBox()
        Me.dtpDatePaynment = New System.Windows.Forms.DateTimePicker()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtFinePayment = New System.Windows.Forms.TextBox()
        Me.lblDatePayment = New System.Windows.Forms.Label()
        Me.lblInsertFinePayment = New System.Windows.Forms.Label()
        Me.btnGenerateReceipt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchLateReturnFines = New System.Windows.Forms.Button()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchLateReturnInformation = New System.Windows.Forms.TextBox()
        Me.pdReceipt = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnListLateReturn = New System.Windows.Forms.Button()
        lblBorrowerIC = New System.Windows.Forms.Label()
        lblTotalLateFines = New System.Windows.Forms.Label()
        lblBorrowerName = New System.Windows.Forms.Label()
        CType(Me.dgvLateReturnFine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBorrowerIC
        '
        lblBorrowerIC.AutoSize = True
        lblBorrowerIC.Location = New System.Drawing.Point(75, 86)
        lblBorrowerIC.Name = "lblBorrowerIC"
        lblBorrowerIC.Size = New System.Drawing.Size(103, 19)
        lblBorrowerIC.TabIndex = 8
        lblBorrowerIC.Text = "Borrower IC:"
        '
        'lblTotalLateFines
        '
        lblTotalLateFines.AutoSize = True
        lblTotalLateFines.Location = New System.Drawing.Point(87, 128)
        lblTotalLateFines.Name = "lblTotalLateFines"
        lblTotalLateFines.Size = New System.Drawing.Size(91, 19)
        lblTotalLateFines.TabIndex = 10
        lblTotalLateFines.Text = "Total Fines:"
        '
        'lblBorrowerName
        '
        lblBorrowerName.AutoSize = True
        lblBorrowerName.Location = New System.Drawing.Point(50, 40)
        lblBorrowerName.Name = "lblBorrowerName"
        lblBorrowerName.Size = New System.Drawing.Size(128, 19)
        lblBorrowerName.TabIndex = 12
        lblBorrowerName.Text = "Borrower Name:"
        '
        'dgvLateReturnFine
        '
        Me.dgvLateReturnFine.AllowUserToAddRows = False
        Me.dgvLateReturnFine.AllowUserToDeleteRows = False
        Me.dgvLateReturnFine.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLateReturnFine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLateReturnFine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLateReturnFine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLateReturnFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLateReturnFine.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLateReturnFine.EnableHeadersVisualStyles = False
        Me.dgvLateReturnFine.GridColor = System.Drawing.Color.White
        Me.dgvLateReturnFine.Location = New System.Drawing.Point(24, 237)
        Me.dgvLateReturnFine.Name = "dgvLateReturnFine"
        Me.dgvLateReturnFine.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLateReturnFine.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLateReturnFine.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvLateReturnFine.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLateReturnFine.RowTemplate.Height = 24
        Me.dgvLateReturnFine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLateReturnFine.Size = New System.Drawing.Size(600, 369)
        Me.dgvLateReturnFine.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.txtBalance)
        Me.GroupBox2.Controls.Add(Me.lblBalance)
        Me.GroupBox2.Controls.Add(Me.txtBorrowerName)
        Me.GroupBox2.Controls.Add(lblBorrowerName)
        Me.GroupBox2.Controls.Add(lblTotalLateFines)
        Me.GroupBox2.Controls.Add(Me.txtTotalLateReturnFines)
        Me.GroupBox2.Controls.Add(lblBorrowerIC)
        Me.GroupBox2.Controls.Add(Me.txtBorrowerIC)
        Me.GroupBox2.Controls.Add(Me.dtpDatePaynment)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.txtFinePayment)
        Me.GroupBox2.Controls.Add(Me.lblDatePayment)
        Me.GroupBox2.Controls.Add(Me.lblInsertFinePayment)
        Me.GroupBox2.Controls.Add(Me.btnGenerateReceipt)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(646, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 385)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fines Payment"
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
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(105, 209)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(73, 19)
        Me.lblBalance.TabIndex = 14
        Me.lblBalance.Text = "Balance:"
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
        'txtTotalLateReturnFines
        '
        Me.txtTotalLateReturnFines.BackColor = System.Drawing.Color.Black
        Me.txtTotalLateReturnFines.ForeColor = System.Drawing.Color.White
        Me.txtTotalLateReturnFines.Location = New System.Drawing.Point(194, 120)
        Me.txtTotalLateReturnFines.Name = "txtTotalLateReturnFines"
        Me.txtTotalLateReturnFines.Size = New System.Drawing.Size(241, 27)
        Me.txtTotalLateReturnFines.TabIndex = 11
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
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(91, 304)
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
        'lblDatePayment
        '
        Me.lblDatePayment.AutoSize = True
        Me.lblDatePayment.Location = New System.Drawing.Point(24, 249)
        Me.lblDatePayment.Name = "lblDatePayment"
        Me.lblDatePayment.Size = New System.Drawing.Size(125, 19)
        Me.lblDatePayment.TabIndex = 3
        Me.lblDatePayment.Text = "Date payment : "
        '
        'lblInsertFinePayment
        '
        Me.lblInsertFinePayment.AutoSize = True
        Me.lblInsertFinePayment.Location = New System.Drawing.Point(24, 169)
        Me.lblInsertFinePayment.Name = "lblInsertFinePayment"
        Me.lblInsertFinePayment.Size = New System.Drawing.Size(154, 19)
        Me.lblInsertFinePayment.TabIndex = 2
        Me.lblInsertFinePayment.Text = "Insert fine payment:"
        '
        'btnGenerateReceipt
        '
        Me.btnGenerateReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReceipt.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReceipt.ForeColor = System.Drawing.Color.Black
        Me.btnGenerateReceipt.Location = New System.Drawing.Point(266, 304)
        Me.btnGenerateReceipt.Name = "btnGenerateReceipt"
        Me.btnGenerateReceipt.Size = New System.Drawing.Size(134, 66)
        Me.btnGenerateReceipt.TabIndex = 1
        Me.btnGenerateReceipt.Text = "Generate Receipt"
        Me.btnGenerateReceipt.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchLateReturnFines)
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
        'btnSearchLateReturnFines
        '
        Me.btnSearchLateReturnFines.BackColor = System.Drawing.Color.White
        Me.btnSearchLateReturnFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchLateReturnFines.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLateReturnFines.ForeColor = System.Drawing.Color.Black
        Me.btnSearchLateReturnFines.Location = New System.Drawing.Point(472, 18)
        Me.btnSearchLateReturnFines.Name = "btnSearchLateReturnFines"
        Me.btnSearchLateReturnFines.Size = New System.Drawing.Size(112, 41)
        Me.btnSearchLateReturnFines.TabIndex = 18
        Me.btnSearchLateReturnFines.Text = "Search"
        Me.btnSearchLateReturnFines.UseVisualStyleBackColor = False
        '
        'cboSearchBy
        '
        Me.cboSearchBy.BackColor = System.Drawing.Color.Black
        Me.cboSearchBy.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchBy.ForeColor = System.Drawing.Color.White
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Borrower's name", "IC number"})
        Me.cboSearchBy.Location = New System.Drawing.Point(323, 27)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(119, 27)
        Me.cboSearchBy.TabIndex = 2
        Me.cboSearchBy.Text = "Borrower's name"
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
        Me.txtSearchLateReturnInformation.BackColor = System.Drawing.Color.Black
        Me.txtSearchLateReturnInformation.ForeColor = System.Drawing.Color.White
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
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btnListLateReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents btnGenerateReceipt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearchLateReturnFines As Button
    Friend WithEvents cboSearchBy As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchLateReturnInformation As TextBox
    Friend WithEvents pdReceipt As Printing.PrintDocument
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents dtpDatePaynment As DateTimePicker
    Friend WithEvents btnBack As Button
    Friend WithEvents txtFinePayment As TextBox
    Friend WithEvents lblDatePayment As Label
    Friend WithEvents lblInsertFinePayment As Label
    Friend WithEvents txtTotalLateReturnFines As TextBox
    Friend WithEvents txtBorrowerIC As TextBox
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents btnListLateReturn As Button
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents lblBalance As Label
End Class