Public Class frmCheckIn

    Dim guest As New DataLayer.ClsGuest
    Dim guestTransaction As New DataLayer.ClsGuestTransaction
    Dim bnSave As Boolean = False

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDuration.Text = "" Then
            MessageBox.Show("You must enter the duration!!!")
            Exit Sub
        End If

        Try
            For Each Room As Room In frmMainAdmin.pnlRooms.Controls
                If Room.Name.Equals("pn" & txtRoom.Text) Then
                    Dim currentDate As Date = DateTime.Now
                    Room.dTimeIn = currentDate
                    Try
                        Room.dTimeOut = DateAdd(DateInterval.Hour, CInt(txtDuration.Text), currentDate)
                    Catch ex As Exception
                        MessageBox.Show("Please enter the correct duration")
                        txtDuration.Focus()
                        Exit Sub
                    End Try

                    Room.lblTimeIn.Text = Format(Room.dTimeIn, "hh:mm:ss tt")
                    Room.lblTimeOut.Text = Format(Room.dTimeOut, "hh:mm:ss tt")
                    TimeIn.Text = Room.lblTimeIn.Text
                    TimeOut.Text = Room.lblTimeOut.Text
                    Room.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
                    Room.Timer1.Enabled = True
                    Room.Timer1.Start()
                    Room.Timer1.Interval = 1000
                    Room.bActive = True
                    guest.Room = Room.Room
                    Try
                        guest.Duration = CInt(txtDuration.Text)
                    Catch ex As Exception
                        Exit Sub
                    End Try

                    guest.Amount = CDbl(txtAmount.Text)
                    guest.TimeIn = Room.lblTimeIn.Text
                    If guestTransaction.addNewGuest(guest) Then
                        success.Visible = True
                        frmGuestInvoice.Show()
                        bnSave = True
                        btnPrint.Visible = True
                        btnSave.Visible = False
                    Else
                        fail.Visible = True
                    End If
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Show()
        Me.Close()
    End Sub

    Private Sub txtDuration_TextChanged(sender As Object, e As EventArgs) Handles txtDuration.TextChanged
        Try
            If txtDuration.Text.Equals("") Then
                txtAmount.Text = "0"
                Exit Sub
            End If
            txtAmount.Text = (CDbl(txtPrice.Text) * CInt(txtDuration.Text)) - (CDbl(txtDuration.Text) * CInt(txtDuration.Text) * CInt(txtDiscount.Text)) / 100
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If bnSave Then
            frmGuestInvoice.Show()
        Else
            MessageBox.Show("You must save first!!!")
        End If

    End Sub

    'Private Sub TextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtDuration.Validating
    '    Dim ctl As Control = CType(sender, Control)
    '    If ctl.Text = "" Then
    '        e.Cancel = True
    '        ErrorProvider1.SetError(ctl, "Please enter a value")
    '    End If
    'End Sub

    Private Sub txtDuration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDuration.KeyPress
        If Char.IsControl(e.KeyChar) Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("You can enter only the number")
        End If
    End Sub
End Class