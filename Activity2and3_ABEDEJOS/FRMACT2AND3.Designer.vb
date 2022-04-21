<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMACT2AND3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.TXTADD = New System.Windows.Forms.TextBox()
        Me.CBOBRAND = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CHKM1 = New System.Windows.Forms.CheckBox()
        Me.CHKM2 = New System.Windows.Forms.CheckBox()
        Me.CHKM3 = New System.Windows.Forms.CheckBox()
        Me.CBOQTY1 = New System.Windows.Forms.ComboBox()
        Me.CBOQTY2 = New System.Windows.Forms.ComboBox()
        Me.CBOQTY3 = New System.Windows.Forms.ComboBox()
        Me.LBLAMT1 = New System.Windows.Forms.Label()
        Me.LBLAMT2 = New System.Windows.Forms.Label()
        Me.LBLAMT3 = New System.Windows.Forms.Label()
        Me.LBLSUB = New System.Windows.Forms.Label()
        Me.BTNSUB = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBTCASH = New System.Windows.Forms.RadioButton()
        Me.RBTINSTALLMENT = New System.Windows.Forms.RadioButton()
        Me.RBT6MOS = New System.Windows.Forms.RadioButton()
        Me.RBT1YR = New System.Windows.Forms.RadioButton()
        Me.RBT2YRS = New System.Windows.Forms.RadioButton()
        Me.LBLTOTAL = New System.Windows.Forms.Label()
        Me.LBLTOTALDUE = New System.Windows.Forms.Label()
        Me.GRPINSTALLMENT = New System.Windows.Forms.GroupBox()
        Me.GRPMODE = New System.Windows.Forms.GroupBox()
        Me.BTNRESET = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GRPINSTALLMENT.SuspendLayout()
        Me.GRPMODE.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Brand"
        '
        'TXTNAME
        '
        Me.TXTNAME.Location = New System.Drawing.Point(249, 56)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(419, 33)
        Me.TXTNAME.TabIndex = 3
        '
        'TXTADD
        '
        Me.TXTADD.Location = New System.Drawing.Point(249, 99)
        Me.TXTADD.Name = "TXTADD"
        Me.TXTADD.Size = New System.Drawing.Size(419, 33)
        Me.TXTADD.TabIndex = 4
        '
        'CBOBRAND
        '
        Me.CBOBRAND.FormattingEnabled = True
        Me.CBOBRAND.Location = New System.Drawing.Point(249, 145)
        Me.CBOBRAND.Name = "CBOBRAND"
        Me.CBOBRAND.Size = New System.Drawing.Size(254, 36)
        Me.CBOBRAND.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBOBRAND)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXTADD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTNAME)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 209)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(68, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 28)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Unit Model"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(273, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 28)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(510, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 28)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Amount"
        '
        'CHKM1
        '
        Me.CHKM1.AutoSize = True
        Me.CHKM1.Location = New System.Drawing.Point(24, 94)
        Me.CHKM1.Name = "CHKM1"
        Me.CHKM1.Size = New System.Drawing.Size(112, 32)
        Me.CHKM1.TabIndex = 7
        Me.CHKM1.Text = "Model 1"
        Me.CHKM1.UseVisualStyleBackColor = True
        Me.CHKM1.Visible = False
        '
        'CHKM2
        '
        Me.CHKM2.AutoSize = True
        Me.CHKM2.Location = New System.Drawing.Point(24, 141)
        Me.CHKM2.Name = "CHKM2"
        Me.CHKM2.Size = New System.Drawing.Size(112, 32)
        Me.CHKM2.TabIndex = 8
        Me.CHKM2.Text = "Model 2"
        Me.CHKM2.UseVisualStyleBackColor = True
        Me.CHKM2.Visible = False
        '
        'CHKM3
        '
        Me.CHKM3.AutoSize = True
        Me.CHKM3.Location = New System.Drawing.Point(24, 185)
        Me.CHKM3.Name = "CHKM3"
        Me.CHKM3.Size = New System.Drawing.Size(112, 32)
        Me.CHKM3.TabIndex = 9
        Me.CHKM3.Text = "Model 3"
        Me.CHKM3.UseVisualStyleBackColor = True
        Me.CHKM3.Visible = False
        '
        'CBOQTY1
        '
        Me.CBOQTY1.Enabled = False
        Me.CBOQTY1.FormattingEnabled = True
        Me.CBOQTY1.Location = New System.Drawing.Point(249, 94)
        Me.CBOQTY1.Name = "CBOQTY1"
        Me.CBOQTY1.Size = New System.Drawing.Size(153, 36)
        Me.CBOQTY1.TabIndex = 6
        '
        'CBOQTY2
        '
        Me.CBOQTY2.Enabled = False
        Me.CBOQTY2.FormattingEnabled = True
        Me.CBOQTY2.Location = New System.Drawing.Point(249, 141)
        Me.CBOQTY2.Name = "CBOQTY2"
        Me.CBOQTY2.Size = New System.Drawing.Size(153, 36)
        Me.CBOQTY2.TabIndex = 10
        '
        'CBOQTY3
        '
        Me.CBOQTY3.Enabled = False
        Me.CBOQTY3.FormattingEnabled = True
        Me.CBOQTY3.Location = New System.Drawing.Point(249, 187)
        Me.CBOQTY3.Name = "CBOQTY3"
        Me.CBOQTY3.Size = New System.Drawing.Size(153, 36)
        Me.CBOQTY3.TabIndex = 11
        '
        'LBLAMT1
        '
        Me.LBLAMT1.BackColor = System.Drawing.Color.White
        Me.LBLAMT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLAMT1.Location = New System.Drawing.Point(437, 94)
        Me.LBLAMT1.Name = "LBLAMT1"
        Me.LBLAMT1.Size = New System.Drawing.Size(231, 36)
        Me.LBLAMT1.TabIndex = 12
        Me.LBLAMT1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LBLAMT2
        '
        Me.LBLAMT2.BackColor = System.Drawing.Color.White
        Me.LBLAMT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLAMT2.Location = New System.Drawing.Point(437, 143)
        Me.LBLAMT2.Name = "LBLAMT2"
        Me.LBLAMT2.Size = New System.Drawing.Size(231, 36)
        Me.LBLAMT2.TabIndex = 13
        Me.LBLAMT2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LBLAMT3
        '
        Me.LBLAMT3.BackColor = System.Drawing.Color.White
        Me.LBLAMT3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLAMT3.Location = New System.Drawing.Point(437, 189)
        Me.LBLAMT3.Name = "LBLAMT3"
        Me.LBLAMT3.Size = New System.Drawing.Size(231, 36)
        Me.LBLAMT3.TabIndex = 14
        Me.LBLAMT3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LBLSUB
        '
        Me.LBLSUB.BackColor = System.Drawing.Color.White
        Me.LBLSUB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLSUB.Location = New System.Drawing.Point(437, 277)
        Me.LBLSUB.Name = "LBLSUB"
        Me.LBLSUB.Size = New System.Drawing.Size(231, 36)
        Me.LBLSUB.TabIndex = 15
        Me.LBLSUB.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BTNSUB
        '
        Me.BTNSUB.Enabled = False
        Me.BTNSUB.Location = New System.Drawing.Point(246, 273)
        Me.BTNSUB.Name = "BTNSUB"
        Me.BTNSUB.Size = New System.Drawing.Size(162, 45)
        Me.BTNSUB.TabIndex = 16
        Me.BTNSUB.Text = "Sub-Total"
        Me.BTNSUB.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.LBLAMT2)
        Me.GroupBox2.Controls.Add(Me.BTNSUB)
        Me.GroupBox2.Controls.Add(Me.CHKM1)
        Me.GroupBox2.Controls.Add(Me.LBLSUB)
        Me.GroupBox2.Controls.Add(Me.CHKM2)
        Me.GroupBox2.Controls.Add(Me.LBLAMT3)
        Me.GroupBox2.Controls.Add(Me.CHKM3)
        Me.GroupBox2.Controls.Add(Me.CBOQTY1)
        Me.GroupBox2.Controls.Add(Me.LBLAMT1)
        Me.GroupBox2.Controls.Add(Me.CBOQTY2)
        Me.GroupBox2.Controls.Add(Me.CBOQTY3)
        Me.GroupBox2.Location = New System.Drawing.Point(66, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 334)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Model"
        '
        'RBTCASH
        '
        Me.RBTCASH.AutoSize = True
        Me.RBTCASH.Location = New System.Drawing.Point(56, 42)
        Me.RBTCASH.Name = "RBTCASH"
        Me.RBTCASH.Size = New System.Drawing.Size(77, 32)
        Me.RBTCASH.TabIndex = 18
        Me.RBTCASH.TabStop = True
        Me.RBTCASH.Text = "Cash"
        Me.RBTCASH.UseVisualStyleBackColor = True
        '
        'RBTINSTALLMENT
        '
        Me.RBTINSTALLMENT.AutoSize = True
        Me.RBTINSTALLMENT.Location = New System.Drawing.Point(56, 80)
        Me.RBTINSTALLMENT.Name = "RBTINSTALLMENT"
        Me.RBTINSTALLMENT.Size = New System.Drawing.Size(140, 32)
        Me.RBTINSTALLMENT.TabIndex = 19
        Me.RBTINSTALLMENT.TabStop = True
        Me.RBTINSTALLMENT.Text = "Installment"
        Me.RBTINSTALLMENT.UseVisualStyleBackColor = True
        '
        'RBT6MOS
        '
        Me.RBT6MOS.AutoSize = True
        Me.RBT6MOS.Location = New System.Drawing.Point(74, 39)
        Me.RBT6MOS.Name = "RBT6MOS"
        Me.RBT6MOS.Size = New System.Drawing.Size(123, 32)
        Me.RBT6MOS.TabIndex = 20
        Me.RBT6MOS.TabStop = True
        Me.RBT6MOS.Text = "6 Months"
        Me.RBT6MOS.UseVisualStyleBackColor = True
        '
        'RBT1YR
        '
        Me.RBT1YR.AutoSize = True
        Me.RBT1YR.Location = New System.Drawing.Point(74, 77)
        Me.RBT1YR.Name = "RBT1YR"
        Me.RBT1YR.Size = New System.Drawing.Size(93, 32)
        Me.RBT1YR.TabIndex = 21
        Me.RBT1YR.TabStop = True
        Me.RBT1YR.Text = "1 Year"
        Me.RBT1YR.UseVisualStyleBackColor = True
        '
        'RBT2YRS
        '
        Me.RBT2YRS.AutoSize = True
        Me.RBT2YRS.Location = New System.Drawing.Point(74, 115)
        Me.RBT2YRS.Name = "RBT2YRS"
        Me.RBT2YRS.Size = New System.Drawing.Size(102, 32)
        Me.RBT2YRS.TabIndex = 22
        Me.RBT2YRS.TabStop = True
        Me.RBT2YRS.Text = "2 Years"
        Me.RBT2YRS.UseVisualStyleBackColor = True
        '
        'LBLTOTAL
        '
        Me.LBLTOTAL.BackColor = System.Drawing.Color.White
        Me.LBLTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTOTAL.Location = New System.Drawing.Point(35, 183)
        Me.LBLTOTAL.Name = "LBLTOTAL"
        Me.LBLTOTAL.Size = New System.Drawing.Size(231, 36)
        Me.LBLTOTAL.TabIndex = 17
        Me.LBLTOTAL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LBLTOTAL.Visible = False
        '
        'LBLTOTALDUE
        '
        Me.LBLTOTALDUE.AutoSize = True
        Me.LBLTOTALDUE.Location = New System.Drawing.Point(30, 141)
        Me.LBLTOTALDUE.Name = "LBLTOTALDUE"
        Me.LBLTOTALDUE.Size = New System.Drawing.Size(187, 28)
        Me.LBLTOTALDUE.TabIndex = 6
        Me.LBLTOTALDUE.Text = "Total Amount Due"
        Me.LBLTOTALDUE.Visible = False
        '
        'GRPINSTALLMENT
        '
        Me.GRPINSTALLMENT.Controls.Add(Me.RBT1YR)
        Me.GRPINSTALLMENT.Controls.Add(Me.RBT6MOS)
        Me.GRPINSTALLMENT.Controls.Add(Me.RBT2YRS)
        Me.GRPINSTALLMENT.Location = New System.Drawing.Point(278, 42)
        Me.GRPINSTALLMENT.Name = "GRPINSTALLMENT"
        Me.GRPINSTALLMENT.Size = New System.Drawing.Size(307, 175)
        Me.GRPINSTALLMENT.TabIndex = 23
        Me.GRPINSTALLMENT.TabStop = False
        Me.GRPINSTALLMENT.Text = "Installment Plan"
        Me.GRPINSTALLMENT.Visible = False
        '
        'GRPMODE
        '
        Me.GRPMODE.Controls.Add(Me.RBTINSTALLMENT)
        Me.GRPMODE.Controls.Add(Me.GRPINSTALLMENT)
        Me.GRPMODE.Controls.Add(Me.RBTCASH)
        Me.GRPMODE.Controls.Add(Me.LBLTOTALDUE)
        Me.GRPMODE.Controls.Add(Me.LBLTOTAL)
        Me.GRPMODE.Location = New System.Drawing.Point(66, 567)
        Me.GRPMODE.Name = "GRPMODE"
        Me.GRPMODE.Size = New System.Drawing.Size(608, 243)
        Me.GRPMODE.TabIndex = 24
        Me.GRPMODE.TabStop = False
        Me.GRPMODE.Text = "Mode of Payment"
        Me.GRPMODE.Visible = False
        '
        'BTNRESET
        '
        Me.BTNRESET.Enabled = False
        Me.BTNRESET.Location = New System.Drawing.Point(694, 657)
        Me.BTNRESET.Name = "BTNRESET"
        Me.BTNRESET.Size = New System.Drawing.Size(112, 66)
        Me.BTNRESET.TabIndex = 25
        Me.BTNRESET.Text = "Reset"
        Me.BTNRESET.UseVisualStyleBackColor = True
        '
        'FRMACT2AND3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(854, 820)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNRESET)
        Me.Controls.Add(Me.GRPMODE)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FRMACT2AND3"
        Me.Text = "King Dot Com Cellphone Store: Cellphone Transaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GRPINSTALLMENT.ResumeLayout(False)
        Me.GRPINSTALLMENT.PerformLayout()
        Me.GRPMODE.ResumeLayout(False)
        Me.GRPMODE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTNAME As System.Windows.Forms.TextBox
    Friend WithEvents TXTADD As System.Windows.Forms.TextBox
    Friend WithEvents CBOBRAND As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CHKM1 As System.Windows.Forms.CheckBox
    Friend WithEvents CHKM2 As System.Windows.Forms.CheckBox
    Friend WithEvents CHKM3 As System.Windows.Forms.CheckBox
    Friend WithEvents CBOQTY1 As System.Windows.Forms.ComboBox
    Friend WithEvents CBOQTY2 As System.Windows.Forms.ComboBox
    Friend WithEvents CBOQTY3 As System.Windows.Forms.ComboBox
    Friend WithEvents LBLAMT1 As System.Windows.Forms.Label
    Friend WithEvents LBLAMT2 As System.Windows.Forms.Label
    Friend WithEvents LBLAMT3 As System.Windows.Forms.Label
    Friend WithEvents LBLSUB As System.Windows.Forms.Label
    Friend WithEvents BTNSUB As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBTCASH As System.Windows.Forms.RadioButton
    Friend WithEvents RBTINSTALLMENT As System.Windows.Forms.RadioButton
    Friend WithEvents RBT6MOS As System.Windows.Forms.RadioButton
    Friend WithEvents RBT1YR As System.Windows.Forms.RadioButton
    Friend WithEvents RBT2YRS As System.Windows.Forms.RadioButton
    Friend WithEvents LBLTOTAL As System.Windows.Forms.Label
    Friend WithEvents LBLTOTALDUE As System.Windows.Forms.Label
    Friend WithEvents GRPINSTALLMENT As System.Windows.Forms.GroupBox
    Friend WithEvents GRPMODE As System.Windows.Forms.GroupBox
    Friend WithEvents BTNRESET As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
