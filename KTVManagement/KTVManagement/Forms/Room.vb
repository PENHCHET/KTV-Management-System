Public Class Room

    Public Property bActive As Boolean = False
    Public Property dTimeIn As DateTime
    Public Property dTimeOut As DateTime
    Public Property sRemaining As TimeSpan
    Public Property Room As New DataLayer.ClsRoom

    Private Sub lblRoomID_Click(sender As Object, e As EventArgs) Handles lblRoomID.Click, lblRemaining.Click, lblTimeIn.Click, lblTimeOut.Click, Label1.Click, label111.Click, lable2.Click, Me.Click
        If bActive = False Then
            frmCheckIn.Show()
            frmCheckIn.txtRoomID.Text = Room.ID
            frmCheckIn.txtRoom.Text = Room.RoomName
            frmCheckIn.txtRoomType.Text = Room.RoomType
            frmCheckIn.txtPrice.Text = Room.Price
            frmCheckIn.txtDiscount.Text = Room.Discount
        Else
            MessageBox.Show("This room has the guest already!!!")
        End If
    End Sub

    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not IsNothing(dTimeOut) And bActive = True Then
            sRemaining = (dTimeOut - Now)
            If sRemaining.Hours <= 0 And sRemaining.Minutes <= 0 And sRemaining.Seconds <= 0 Then
                lblRemaining.Text = "00:00:00"
                Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
                Me.bActive = False
                Me.sRemaining = Nothing
                Me.dTimeOut = Nothing
                Me.dTimeIn = Nothing
                lblTimeIn.Text = "00:00:00"
                lblTimeOut.Text = "00:00:00"
                Dim guestTransaction As New DataLayer.ClsGuestTransaction
                If guestTransaction.updateGuestRoom(Room.ID) Then
                    'MessageBox.Show("Update Successfully!!!")
                Else
                    'MessageBox.Show("Update failure!!!")
                End If
                MessageBox.Show("The Room ID " & Room.ID & " is time!!!!!!!")
            ElseIf sRemaining.Hours <= 0 And sRemaining.Minutes < 5 Then
                Me.BackColor = Color.Red
                lblRemaining.Text = sRemaining.Hours & ":" & sRemaining.Minutes & ":" & sRemaining.Seconds
            Else
                lblRemaining.Text = sRemaining.Hours & ":" & sRemaining.Minutes & ":" & sRemaining.Seconds
            End If
        End If
    End Sub
End Class
