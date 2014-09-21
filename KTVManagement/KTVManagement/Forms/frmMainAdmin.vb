Public Class frmMainAdmin

    Dim tbRoom As New DataTable
    Dim roomTransaction As New DataLayer.ClsRoomTransaction
    Dim guestTransaction As New DataLayer.ClsGuestTransaction

    Private Sub frmMainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        lblUsername.Text = DataLayer.ClsConnection.UserLogin.Username
        lblUsername.TextAlign = ContentAlignment.MiddleRight

        tbRoom = roomTransaction.getAllRooms().Tables(0)

        For Each row As DataRow In tbRoom.Rows
            Dim room As New Room
            room.Room.ID = row(0)
            room.Room.RoomName = row(1)
            room.Room.RoomType = row(2)
            room.Room.Price = row(3)
            room.Room.Discount = row(4)
            room.Room.Status = row(5)
            If room.Room.Status = True Then
                room.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
                Dim guest As New DataLayer.ClsGuest
                guest = guestTransaction.getGuestById(room.Room.ID)
                room.dTimeIn = guest.TimeIn
                room.dTimeOut = guest.TimeOut
                room.lblTimeIn.Text = Format(room.dTimeIn, "hh:mm:ss")
                room.lblTimeOut.Text = Format(room.dTimeOut, "hh:mm:ss")
                room.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
                room.Timer1.Enabled = True
                room.Timer1.Start()
                room.Timer1.Interval = 1000
                room.bActive = True
            End If
            room.lblRoomID.Text = row(1)
            room.Name = "pn" & row(0).ToString
            pnlRooms.Controls.Add(room)
        Next
    End Sub


    Private Sub btnExitMain_Click(sender As Object, e As EventArgs) Handles btnExitMain.Click
        Me.Close()
        DataLayer.ClsConnection.closeConnection()
        DataLayer.ClsConnection.UserLogin = Nothing
        frmLogin.Visible = True
    End Sub

    Private Sub btnSongInformation_Click(sender As Object, e As EventArgs) Handles btnSongInformation.Click
        frmSongMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnUserInformation_Click(sender As Object, e As EventArgs) Handles btnUserInformation.Click
        frmUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        frmAboutus.Show()
    End Sub

    Private Sub btnRoomInformation_Click(sender As Object, e As EventArgs) Handles btnRoomInformation.Click
        frmRoom.Show()
        Me.Close()
    End Sub


    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        frmGuestHistory.Show()
        Me.Hide()
    End Sub

End Class