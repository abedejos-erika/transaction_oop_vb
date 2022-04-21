Public Class FRMACT2AND3
    Const IP11 = 45000
    Const IP10 = 37000
    Const IP8 = 28000
    Const SGN10 = 36000
    Const SGS10 = 33000
    Const SGA21 = 10500
    Const HM30P = 39000
    Const HM20P = 19800
    Const HP30 = 13900
    Dim amt1
    Dim amt2
    Dim amt3
    Dim subtotal

    Private Sub TXTNAME_TextChanged(sender As Object, e As EventArgs) Handles TXTNAME.TextChanged
        If TXTNAME.Text = "" Then
            BTNRESET.Enabled = False
        Else
            BTNRESET.Enabled = True
        End If
    End Sub

    Private Sub FRMACT2AND3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBOBRAND.Items.Clear()
        CBOBRAND.Items.Add("Iphone")
        CBOBRAND.Items.Add("Samsung")
        CBOBRAND.Items.Add("Huawei")

        For q = 1 To 10
            CBOQTY1.Items.Add(q)
            CBOQTY2.Items.Add(q)
            CBOQTY3.Items.Add(q)
        Next
    End Sub

    Private Sub CBOBRAND_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOBRAND.SelectedIndexChanged
        CHKM1.Checked = False
        CHKM2.Checked = False
        CHKM3.Checked = False
        CHKM1.Visible = True
        CHKM2.Visible = True
        CHKM3.Visible = True
        GRPMODE.Visible = False

        Select Case CBOBRAND.Text
            Case "Iphone"
                CHKM1.Text = "Iphone 11"
                CHKM2.Text = "Iphone 10"
                CHKM3.Text = "Iphone 8"
            Case "Samsung"
                CHKM1.Text = "Samsung Galaxy Note 10"
                CHKM2.Text = "Samsung Galaxy S10"
                CHKM3.Text = "Samsung Galaxy A21"
            Case "Huawei"
                CHKM1.Text = "Huawei Mate 30 Pro"
                CHKM2.Text = "Huawei Mate 20 Pro"
                CHKM3.Text = "Huawei P30"
        End Select
    End Sub

    Private Sub CHKM1_CheckedChanged(sender As Object, e As EventArgs) Handles CHKM1.CheckedChanged
        If CHKM1.Checked = True Then
            CBOQTY1.Enabled = True
        Else
            CBOQTY1.Enabled = False
            CBOQTY1.Text = ""
            LBLAMT1.Text = ""
            LBLSUB.Text = ""
            GRPMODE.Visible = False
            BTNSUB.Enabled = False
        End If
    End Sub

    Private Sub CHKM2_CheckedChanged(sender As Object, e As EventArgs) Handles CHKM2.CheckedChanged
        If CHKM2.Checked = True Then
            CBOQTY2.Enabled = True
        Else
            CBOQTY2.Enabled = False
            CBOQTY2.Text = ""
            LBLAMT2.Text = ""
            LBLSUB.Text = ""
            GRPMODE.Visible = False
            BTNSUB.Enabled = False
        End If
    End Sub

    Private Sub CHKM3_CheckedChanged(sender As Object, e As EventArgs) Handles CHKM3.CheckedChanged
        If CHKM3.Checked = True Then
            CBOQTY3.Enabled = True
        Else
            CBOQTY3.Enabled = False
            CBOQTY3.Text = ""
            LBLAMT3.Text = ""
            LBLSUB.Text = ""
            GRPMODE.Visible = False
            BTNSUB.Enabled = False
        End If
    End Sub

    Private Sub CBOQTY1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOQTY1.SelectedIndexChanged
        LBLSUB.Text = ""
        GRPMODE.Visible = False
        If CHKM1.Text = "Iphone 11" Then
            amt1 = IP11 * Val(CBOQTY1.Text)
        ElseIf CHKM1.Text = "Samsung Galaxy Note 10" Then
            amt1 = SGN10 * Val(CBOQTY1.Text)
        ElseIf CHKM1.Text = "Huawei Mate 30 Pro" Then
            amt1 = HM30P * Val(CBOQTY1.Text)
        End If

        LBLAMT1.Text = Format(amt1, "#,###,##0.00")
    End Sub

    Private Sub CBOQTY2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOQTY2.SelectedIndexChanged
        LBLSUB.Text = ""
        GRPMODE.Visible = False
        If CHKM2.Text = "Iphone 10" Then
            amt2 = IP10 * Val(CBOQTY2.Text)
        ElseIf CHKM2.Text = "Samsung Galaxy S10" Then
            amt2 = SGS10 * Val(CBOQTY2.Text)
        ElseIf CHKM2.Text = "Huawei Mate 20 Pro" Then
            amt2 = HM20P * Val(CBOQTY2.Text)
        End If

        LBLAMT2.Text = Format(amt2, "#,###,##0.00")
    End Sub

    Private Sub CBOQTY3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOQTY3.SelectedIndexChanged
        LBLSUB.Text = ""
        GRPMODE.Visible = False
        If CHKM3.Text = "Iphone 8" Then
            amt3 = IP8 * Val(CBOQTY3.Text)
        ElseIf CHKM3.Text = "Samsung Galaxy A21" Then
            amt3 = SGA21 * Val(CBOQTY3.Text)
        ElseIf CHKM3.Text = "Huawei P30" Then
            amt3 = HP30 * Val(CBOQTY3.Text)
        End If

        LBLAMT3.Text = Format(amt3, "#,###,##0.00")
    End Sub

    Private Sub LBLAMT1_TextChanged(sender As Object, e As EventArgs) Handles LBLAMT1.TextChanged
        If LBLAMT1.Text = "" Then
            BTNSUB.Enabled = False
        ElseIf LBLAMT1.Text = "0.00" Then
            BTNSUB.Enabled = False
        Else
            BTNSUB.Enabled = True
            LBLSUB.Text = Format("0.00")
        End If
    End Sub

    Private Sub LBLAMT2_TextChanged(sender As Object, e As EventArgs) Handles LBLAMT2.TextChanged
        If LBLAMT2.Text = "" Then
            BTNSUB.Enabled = False
        ElseIf LBLAMT2.Text = "0.00" Then
            BTNSUB.Enabled = False
        Else
            BTNSUB.Enabled = True
            LBLSUB.Text = Format("0.00")
        End If
    End Sub

    Private Sub LBLAMT3_TextChanged(sender As Object, e As EventArgs) Handles LBLAMT3.TextChanged
        If LBLAMT3.Text = "" Then
            BTNSUB.Enabled = False
        ElseIf LBLAMT3.Text = "0.00" Then
            BTNSUB.Enabled = False
        Else
            BTNSUB.Enabled = True
            LBLSUB.Text = Format("0.00")
        End If
    End Sub

    Private Sub BTNSUB_Click(sender As Object, e As EventArgs) Handles BTNSUB.Click
        subtotal = amt1 + amt2 + amt3
        LBLSUB.Text = Format(subtotal, "#,###,##0.00")

        GRPMODE.Visible = True
        RBTCASH.Enabled = True
        RBTINSTALLMENT.Enabled = True
        LBLTOTAL.Visible = False
        LBLTOTALDUE.Visible = False
        RBTCASH.Checked = False
        RBTINSTALLMENT.Checked = False
        RBT6MOS.Checked = False
        RBT1YR.Checked = False
        RBT2YRS.Checked = False
        LBLTOTAL.Text = ""
        GRPINSTALLMENT.Visible = False
    End Sub

    Private Sub RBTCASH_CheckedChanged(sender As Object, e As EventArgs) Handles RBTCASH.CheckedChanged
        Dim cash

        LBLTOTALDUE.Visible = True
        LBLTOTAL.Visible = True
        GRPINSTALLMENT.Visible = False

        cash = subtotal - subtotal * 0.1
        LBLTOTAL.Text = Format(cash, "#,###,##0.00")
    End Sub

    Private Sub RBTINSTALLMENT_CheckedChanged(sender As Object, e As EventArgs) Handles RBTINSTALLMENT.CheckedChanged
        GRPINSTALLMENT.Visible = True
        LBLTOTAL.Visible = False
        LBLTOTALDUE.Visible = False
        RBT6MOS.Enabled = True
        RBT1YR.Enabled = True
        RBT2YRS.Enabled = True
        LBLTOTAL.Text = ""
        RBT6MOS.Checked = False
        RBT1YR.Checked = False
        RBT2YRS.Checked = False
    End Sub

    Private Sub RBT6MOS_CheckedChanged(sender As Object, e As EventArgs) Handles RBT6MOS.CheckedChanged
        Dim installment1

        LBLTOTAL.Visible = True
        LBLTOTALDUE.Visible = True

        installment1 = subtotal + subtotal * 0.1
        LBLTOTAL.Text = Format(installment1, "#,###,##0.00")
    End Sub

    Private Sub RBT1YR_CheckedChanged(sender As Object, e As EventArgs) Handles RBT1YR.CheckedChanged
        Dim installment2

        LBLTOTAL.Visible = True
        LBLTOTALDUE.Visible = True

        installment2 = subtotal + subtotal * 0.15
        LBLTOTAL.Text = Format(installment2, "#,###,##0.00")
    End Sub

    Private Sub RBT2YRS_CheckedChanged(sender As Object, e As EventArgs) Handles RBT2YRS.CheckedChanged
        Dim installment3

        LBLTOTAL.Visible = True
        LBLTOTALDUE.Visible = True

        installment3 = subtotal + subtotal * 0.2
        LBLTOTAL.Text = Format(installment3, "#,###,##0.00")
    End Sub

    Private Sub BTNRESET_Click(sender As Object, e As EventArgs) Handles BTNRESET.Click
        TXTNAME.Text = ""
        TXTADD.Text = ""
        CBOBRAND.Text = ""
        CHKM1.Visible = False
        CHKM2.Visible = False
        CHKM3.Visible = False
        CBOQTY1.Enabled = False
        CBOQTY2.Enabled = False
        CBOQTY3.Enabled = False
        CBOQTY1.Text = ""
        CBOQTY2.Text = ""
        CBOQTY3.Text = ""
        LBLAMT1.Text = ""
        LBLAMT2.Text = ""
        LBLAMT3.Text = ""
        BTNSUB.Enabled = False
        LBLSUB.Text = ""
        LBLTOTAL.Visible = False
        LBLTOTALDUE.Visible = False
        GRPMODE.Visible = False
        RBTCASH.Checked = False
        RBTINSTALLMENT.Checked = False
        RBT6MOS.Checked = False
        RBT1YR.Checked = False
        RBT2YRS.Checked = False
        RBTCASH.Enabled = False
        RBTINSTALLMENT.Enabled = False
        RBT6MOS.Enabled = False
        RBT1YR.Enabled = False
        RBT2YRS.Enabled = False
        BTNRESET.Enabled = False
    End Sub
End Class
