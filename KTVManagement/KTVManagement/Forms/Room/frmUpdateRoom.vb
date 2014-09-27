Public Class frmUpdateRoom

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        frmAddRoom.Visible = True
        Me.Close()
    End Sub

    Private Sub btnRoomList_Click(sender As Object, e As EventArgs) Handles btnRoomList.Click
        frmRoom.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDiscount.Text = "" Or txtName.Text = "" Or txtUnitPrice.Text = "" Or cboType.Text = "" Or cboStatus.Text = "" Then
            MessageBox.Show("You must fill all the information!!!")
            Exit Sub
        End If
        Try
            Dim room As New DataLayer.ClsRoom
            Dim roomTransaction As New DataLayer.ClsRoomTransaction
            room.ID = CInt(txtID.Text)
            room.RoomName = txtName.Text
            room.RoomType = cboType.Text
            room.Price = CDbl(txtUnitPrice.Text)
            room.Discount = CInt(txtDiscount.Text)
            If cboType.SelectedText.Equals("Free") Then
                room.Status = False
            Else
                room.Status = True
            End If
            If roomTransaction.updateRoom(room) = True Then
                success.Visible = True
            Else
                fail.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmUpdateRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        txtName.Focus()
    End Sub

    Private Sub txtUnitPrice_MouseUp(sender As Object, e As MouseEventArgs) Handles txtUnitPrice.MouseUp, txtUnitPrice.GotFocus, txtDiscount.MouseUp, txtDiscount.GotFocus
        txtUnitPrice.SelectionStart = 0
        txtUnitPrice.SelectionLength = txtUnitPrice.Text.Length
    End Sub

    Private Sub txtUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress, txtDiscount.KeyPress
        If Char.IsControl(e.KeyChar) Then Exit Sub

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("You must enter only the number!!!")
        End If
    End Sub

End Class