<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblDepositDate = New System.Windows.Forms.Label()
        Me.lblBirthDay = New System.Windows.Forms.Label()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.dtBitrhDay = New System.Windows.Forms.DateTimePicker()
        Me.dtDepositDate = New System.Windows.Forms.DateTimePicker()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnApplyDeposit = New System.Windows.Forms.Button()
        Me.dgTiful = New System.Windows.Forms.DataGridView()
        Me.btnViewDeposit = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnUpdateDeposit = New System.Windows.Forms.Button()
        Me.txtDepositID = New System.Windows.Forms.TextBox()
        Me.lblDepositId = New System.Windows.Forms.Label()
        Me.btnDeleteDeposit = New System.Windows.Forms.Button()
        CType(Me.dgTiful, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTitle.Location = New System.Drawing.Point(271, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(158, 42)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "תפעול גמל"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAmount.Location = New System.Drawing.Point(33, 258)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(65, 20)
        Me.lblAmount.TabIndex = 2
        Me.lblAmount.Text = "Amount"
        '
        'lblDepositDate
        '
        Me.lblDepositDate.AutoSize = True
        Me.lblDepositDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepositDate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDepositDate.Location = New System.Drawing.Point(33, 220)
        Me.lblDepositDate.Name = "lblDepositDate"
        Me.lblDepositDate.Size = New System.Drawing.Size(103, 20)
        Me.lblDepositDate.TabIndex = 3
        Me.lblDepositDate.Text = "Deposit Date"
        '
        'lblBirthDay
        '
        Me.lblBirthDay.AutoSize = True
        Me.lblBirthDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDay.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblBirthDay.Location = New System.Drawing.Point(33, 182)
        Me.lblBirthDay.Name = "lblBirthDay"
        Me.lblBirthDay.Size = New System.Drawing.Size(74, 20)
        Me.lblBirthDay.TabIndex = 4
        Me.lblBirthDay.Text = "Birth Day"
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblIDNumber.Location = New System.Drawing.Point(33, 144)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(86, 20)
        Me.lblIDNumber.TabIndex = 5
        Me.lblIDNumber.Text = "ID Number"
        '
        'dtBitrhDay
        '
        Me.dtBitrhDay.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBitrhDay.CustomFormat = " "
        Me.dtBitrhDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBitrhDay.Location = New System.Drawing.Point(198, 182)
        Me.dtBitrhDay.Name = "dtBitrhDay"
        Me.dtBitrhDay.Size = New System.Drawing.Size(200, 20)
        Me.dtBitrhDay.TabIndex = 8
        '
        'dtDepositDate
        '
        Me.dtDepositDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDepositDate.CustomFormat = " "
        Me.dtDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDepositDate.Location = New System.Drawing.Point(198, 220)
        Me.dtDepositDate.Name = "dtDepositDate"
        Me.dtDepositDate.Size = New System.Drawing.Size(200, 20)
        Me.dtDepositDate.TabIndex = 9
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.Location = New System.Drawing.Point(198, 143)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(200, 22)
        Me.txtIDNumber.TabIndex = 11
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(198, 257)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(200, 22)
        Me.txtAmount.TabIndex = 12
        '
        'btnApplyDeposit
        '
        Me.btnApplyDeposit.BackColor = System.Drawing.Color.Silver
        Me.btnApplyDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyDeposit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnApplyDeposit.Location = New System.Drawing.Point(521, 149)
        Me.btnApplyDeposit.Name = "btnApplyDeposit"
        Me.btnApplyDeposit.Size = New System.Drawing.Size(146, 37)
        Me.btnApplyDeposit.TabIndex = 13
        Me.btnApplyDeposit.Text = "Apply Deposit"
        Me.btnApplyDeposit.UseVisualStyleBackColor = False
        '
        'dgTiful
        '
        Me.dgTiful.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTiful.Location = New System.Drawing.Point(33, 315)
        Me.dgTiful.Name = "dgTiful"
        Me.dgTiful.ReadOnly = True
        Me.dgTiful.Size = New System.Drawing.Size(634, 193)
        Me.dgTiful.TabIndex = 14
        '
        'btnViewDeposit
        '
        Me.btnViewDeposit.BackColor = System.Drawing.Color.Silver
        Me.btnViewDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDeposit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnViewDeposit.Location = New System.Drawing.Point(521, 98)
        Me.btnViewDeposit.Name = "btnViewDeposit"
        Me.btnViewDeposit.Size = New System.Drawing.Size(146, 37)
        Me.btnViewDeposit.TabIndex = 15
        Me.btnViewDeposit.Text = "View Deposits"
        Me.btnViewDeposit.UseVisualStyleBackColor = False
        '
        'btnClearForm
        '
        Me.btnClearForm.BackColor = System.Drawing.Color.Silver
        Me.btnClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClearForm.Location = New System.Drawing.Point(281, 527)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(139, 37)
        Me.btnClearForm.TabIndex = 16
        Me.btnClearForm.Text = "Clear"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'btnUpdateDeposit
        '
        Me.btnUpdateDeposit.BackColor = System.Drawing.Color.Silver
        Me.btnUpdateDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDeposit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateDeposit.Location = New System.Drawing.Point(521, 200)
        Me.btnUpdateDeposit.Name = "btnUpdateDeposit"
        Me.btnUpdateDeposit.Size = New System.Drawing.Size(146, 37)
        Me.btnUpdateDeposit.TabIndex = 17
        Me.btnUpdateDeposit.Text = "Update Deposits"
        Me.btnUpdateDeposit.UseVisualStyleBackColor = False
        '
        'txtDepositID
        '
        Me.txtDepositID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepositID.Location = New System.Drawing.Point(198, 105)
        Me.txtDepositID.Name = "txtDepositID"
        Me.txtDepositID.Size = New System.Drawing.Size(88, 22)
        Me.txtDepositID.TabIndex = 19
        '
        'lblDepositId
        '
        Me.lblDepositId.AutoSize = True
        Me.lblDepositId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepositId.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDepositId.Location = New System.Drawing.Point(33, 106)
        Me.lblDepositId.Name = "lblDepositId"
        Me.lblDepositId.Size = New System.Drawing.Size(85, 20)
        Me.lblDepositId.TabIndex = 18
        Me.lblDepositId.Text = "Deposit ID"
        '
        'btnDeleteDeposit
        '
        Me.btnDeleteDeposit.BackColor = System.Drawing.Color.Silver
        Me.btnDeleteDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteDeposit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeleteDeposit.Location = New System.Drawing.Point(521, 251)
        Me.btnDeleteDeposit.Name = "btnDeleteDeposit"
        Me.btnDeleteDeposit.Size = New System.Drawing.Size(146, 37)
        Me.btnDeleteDeposit.TabIndex = 20
        Me.btnDeleteDeposit.Text = "Delete Deposits"
        Me.btnDeleteDeposit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(745, 600)
        Me.Controls.Add(Me.btnDeleteDeposit)
        Me.Controls.Add(Me.txtDepositID)
        Me.Controls.Add(Me.lblDepositId)
        Me.Controls.Add(Me.btnUpdateDeposit)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnViewDeposit)
        Me.Controls.Add(Me.dgTiful)
        Me.Controls.Add(Me.btnApplyDeposit)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtIDNumber)
        Me.Controls.Add(Me.dtDepositDate)
        Me.Controls.Add(Me.dtBitrhDay)
        Me.Controls.Add(Me.lblIDNumber)
        Me.Controls.Add(Me.lblBirthDay)
        Me.Controls.Add(Me.lblDepositDate)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.Text = "מבחן בית - אילן שחורי"
        CType(Me.dgTiful, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblDepositDate As Label
    Friend WithEvents lblBirthDay As Label
    Friend WithEvents lblIDNumber As Label
    Friend WithEvents dtBitrhDay As DateTimePicker
    Friend WithEvents dtDepositDate As DateTimePicker
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnApplyDeposit As Button
    Friend WithEvents dgTiful As DataGridView
    Friend WithEvents btnViewDeposit As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnUpdateDeposit As Button
    Friend WithEvents txtDepositID As TextBox
    Friend WithEvents lblDepositId As Label
    Friend WithEvents btnDeleteDeposit As Button
End Class
