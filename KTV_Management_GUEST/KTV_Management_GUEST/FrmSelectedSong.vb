Public Class FrmSelectedSong

    Private WithEvents BtAdd As DevComponents.DotNetBar.ButtonX
    Private WithEvents BtAddToTop As DevComponents.DotNetBar.ButtonX
    Private WithEvents LbTitle As Windows.Forms.Label
    Private WithEvents LbSinger As Windows.Forms.Label
    Private WithEvents PanelS As Windows.Forms.Panel

    Public Sub FrmSelectedSong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' addControl()
    End Sub

    Private Sub ButtonClicked(ByVal sender As Object, ByVal e As EventArgs)
        MsgBox("You clicked: " & sender.name & vbCrLf & "Button name: " & sender.Text)
    End Sub

    Private Sub ButtonDelete(ByVal sender As Object, ByVal e As EventArgs)
        ' MsgBox("You clicked: " & sender.name)
        PanelSong.Controls.RemoveAt(CInt(sender.name))
        lsvShow.Items.RemoveAt(CInt(sender.name))
        vlc.playlist.items.remove(CInt(sender.name))
    End Sub
   

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        vlc.playlist.items.clear()
        vlc.playlist.add("file:///" & lsvShow.Items(0).SubItems(3).Text)
        vlc.playlist.play()
    End Sub


    Public Sub addControl()
        Dim i As Integer
        Dim xBtAdd As Integer = 21
        Dim xBtAddToTop As Integer = 67
        Dim xLbTitle As Integer = 121
        Dim xLbSinger As Integer = 679

        Dim yStep As Integer = 3

        'For i = 0 To lsvShow.Items.Count - 1
        '    MsgBox(lsvShow.Items(i).Text & lsvShow.Items(i).SubItems(1).Text & lsvShow.Items(i).SubItems(2).Text & lsvShow.Items(i).SubItems(3).Text)
        'Next




        For i = 0 To lsvShow.Items.Count - 1
            'Dim song As New DataLayer.ClsSong
            'song = arrSelectedSong.Item(i)

            PanelS = New Windows.Forms.Panel
            PanelS.Size = New System.Drawing.Size(900, 50)
            PanelS.Name = i
            PanelS.BackColor = Color.MediumSlateBlue


            BtAdd = New DevComponents.DotNetBar.ButtonX
            BtAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtAdd.Image = Global.KTV_Management_GUEST.My.Resources.Resources.Delete
            BtAdd.Location = New System.Drawing.Point(xBtAdd, yStep)
            BtAdd.Name = i
            BtAdd.Size = New System.Drawing.Size(40, 40)
            BtAdd.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
            BtAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtAdd.TabIndex = 8


            BtAddToTop = New DevComponents.DotNetBar.ButtonX
            BtAddToTop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtAddToTop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtAddToTop.Image = Global.KTV_Management_GUEST.My.Resources.Resources.up
            BtAddToTop.Location = New System.Drawing.Point(xBtAddToTop, yStep)
            BtAddToTop.Name = "btAddToTop" & i
            BtAddToTop.Size = New System.Drawing.Size(40, 40)
            BtAddToTop.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
            BtAddToTop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtAddToTop.TabIndex = 9

            LbTitle = New Windows.Forms.Label
            LbTitle.Font = New System.Drawing.Font("Khmer OS Muol Light", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbTitle.ForeColor = System.Drawing.Color.DeepSkyBlue
            LbTitle.Location = New System.Drawing.Point(xLbTitle, yStep)
            LbTitle.Name = "lbTitle" & i
            LbTitle.Size = New System.Drawing.Size(540, 35)
            LbTitle.TabIndex = 3
            LbTitle.Text = lsvShow.Items(i).SubItems(1).Text

            LbSinger = New Windows.Forms.Label
            LbSinger.Font = New System.Drawing.Font("Khmer OS Muol Light", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbSinger.ForeColor = System.Drawing.Color.Magenta
            LbSinger.Location = New System.Drawing.Point(xLbSinger, yStep)
            LbSinger.Name = "lbTitle" & i
            LbSinger.Size = New System.Drawing.Size(230, 35)
            LbSinger.TabIndex = 4

            'Dim str As String = ""
            'For Each singer As DataLayer.ClsSinger In song.Singers
            '    str = str & singer.Name & ","
            'Next
            'str = str.Substring(0, str.Length - 1)


            LbSinger.Text = lsvShow.Items(i).SubItems(2).Text
            BtAddToTop.Cursor = Cursors.Hand
            BtAdd.Cursor = Cursors.Hand

            AddHandler BtAdd.Click, AddressOf ButtonDelete
            'AddHandler BtAddToTop.Click, AddressOf btAddToTopSong
            PanelS.Controls.Add(BtAdd)
            PanelS.Controls.Add(BtAddToTop)
            PanelS.Controls.Add(LbTitle)
            PanelS.Controls.Add(LbSinger)
            PanelSong.Controls.Add(PanelS)


            'yStep += 50

        Next

        lbSongCount.Text = lsvShow.Items.Count & " Songs"

    End Sub

    Private Sub vlc_MediaPlayerEndReached(sender As Object, e As EventArgs) Handles vlc.MediaPlayerEndReached
        If lsvShow.Items.Count > 0 Then
            Dim data(4) As String
            data(0) = lsvShow.Items(0).Text
            data(1) = lsvShow.Items(0).SubItems(1).Text
            data(2) = lsvShow.Items(0).SubItems(2).Text
            data(3) = lsvShow.Items(0).SubItems(3).Text
            addDatatoLsv(FrmSangSong.lsvSangSong, data)

            PanelSong.Controls.RemoveAt(0)
            lsvShow.Items.RemoveAt(0)
            vlc.playlist.items.remove(0)
            lbSongCount.Text = lsvShow.Items.Count & " Songs"
        End If
    End Sub

End Class