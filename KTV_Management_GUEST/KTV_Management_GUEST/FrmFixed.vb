Public Class FrmFixed

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PMenu.Left = (Me.Width - PMenu.Width) / 2
        'PMenu.Top = (Me.Height - PMenu.Height) / 2
        Timer1.Start()
    End Sub

   

    Public Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lbShowCurrentSongg.Text = MarqueeLeft(lbShowCurrentSongg.Text)

    End Sub

    Private Sub btHide_Click(sender As Object, e As EventArgs) Handles btHide.Click
        btHide.Visible = False
        btShow.Visible = True
        PMenuBottom.Visible = True
    End Sub

    Private Sub btShow_Click(sender As Object, e As EventArgs) Handles btShow.Click
        btHide.Visible = True
        btShow.Visible = False
        PMenuBottom.Visible = False
    End Sub

   
    Private Sub btPlay_Click(sender As Object, e As EventArgs) Handles btPlay.Click
        If btPlay.Name = "btPlay" Then
            FrmSelectedSong.vlc.playlist.togglePause()
            btPlay.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtPause
            btPlay.Name = "btPause"
            lbPause.Visible = True
        Else
            btPlay.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtPlay
            btPlay.Name = "btPlay"
            FrmSelectedSong.vlc.playlist.togglePause()
            lbPause.Visible = False
        End If

    End Sub

    Private Sub btVocal_Click(sender As Object, e As EventArgs) Handles btVocal.Click
        If btVocal.Name = "btVocal" Then
            FrmSelectedSong.vlc.audio.channel = 3
            btVocal.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtVocal_off
            btVocal.Name = "btVocal_off"
        Else
            btVocal.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtVocal
            FrmSelectedSong.vlc.audio.channel = 1
            btVocal.Name = "btVocal"
        End If



    End Sub

    Private Sub btVolOff_Click(sender As Object, e As EventArgs) Handles btVolOff.Click
        If btVolOff.Name = "btVolOff" Then
            btVolOff.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtVolOff_off
            btVolOff.Name = "btVolOff_off"
            FrmSelectedSong.vlc.audio.toggleMute()
        Else
            btVolOff.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtVolOff
            btVolOff.Name = "btVolOff"
            FrmSelectedSong.vlc.audio.toggleMute()
        End If
    End Sub

   
   
    Private Sub btMain_Click(sender As Object, e As EventArgs) Handles btMain.Click
            Me.Hide()
            FrmMain.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.ExitThread()
    End Sub

    Private Sub btSelectedList_Click(sender As Object, e As EventArgs) Handles btSelectedList.Click
        FrmSelectedSong.PanelSong.Controls.Clear()
        FrmSelectedSong.addControl()
        Me.Hide()
        FrmSelectedSong.Show()
    End Sub

    Private Sub btNext_Click(sender As Object, e As EventArgs) Handles btNext.Click
        If FrmSelectedSong.lsvShow.Items.Count > 0 Then
            Dim data(4) As String
            data(0) = FrmSelectedSong.lsvShow.Items(0).Text
            data(1) = FrmSelectedSong.lsvShow.Items(0).SubItems(1).Text
            data(2) = FrmSelectedSong.lsvShow.Items(0).SubItems(2).Text
            data(3) = FrmSelectedSong.lsvShow.Items(0).SubItems(3).Text
            addDatatoLsv(FrmSangSong.lsvSangSong, data)

            FrmSelectedSong.PanelSong.Controls.RemoveAt(0)
            FrmSelectedSong.lsvShow.Items.RemoveAt(0)
            FrmSelectedSong.lbSongCount.Text = FrmSelectedSong.lsvShow.Items.Count()
            FrmSelectedSong.vlc.playlist.stop()
            FrmSelectedSong.vlc.playlist.items.remove(0)
            FrmSelectedSong.vlc.playlist.next()

            FrmSangSong.PanelSong.Controls.Clear()
            FrmSangSong.addControl()
        End If
    End Sub

    Private Sub btForward_Click(sender As Object, e As EventArgs) Handles btForward.Click
        FrmSelectedSong.vlc.input.Position = FrmSelectedSong.vlc.input.Position + 0.1
    End Sub

    Private Sub btVolDown_Click(sender As Object, e As EventArgs) Handles btVolDown.Click
        FrmSelectedSong.vlc.audio.Volume = FrmSelectedSong.vlc.audio.Volume - 10
    End Sub

    Private Sub btVolUp_Click(sender As Object, e As EventArgs) Handles btVolUp.Click
        FrmSelectedSong.vlc.audio.Volume = FrmSelectedSong.vlc.audio.Volume + 10
    End Sub

    Private Sub btScreen_Click(sender As Object, e As EventArgs) Handles btScreen.Click
        FrmSelectedSong.vlc.video.fullscreen = True
        FrmSelectedSong.vlc.video.toggleFullscreen()
    End Sub

    Private Sub btApplaud_Click(sender As Object, e As EventArgs) Handles btApplaud.Click
        FrmSelectedSong.vlc2.playlist.add("file:///" & Application.StartupPath & "\Applause.mp3")
        FrmSelectedSong.vlc2.playlist.play()
    End Sub

    Private Sub btReplay_Click(sender As Object, e As EventArgs) Handles btReplay.Click
        FrmSelectedSong.vlc.playlist.stop()
        FrmSelectedSong.vlc.playlist.play()
    End Sub

    Private Sub btSungList_Click(sender As Object, e As EventArgs) Handles btSungList.Click
        FrmSangSong.PanelSong.Controls.Clear()
        FrmSangSong.addControl()
        Me.Hide()
        FrmSangSong.Show()
    End Sub
End Class
