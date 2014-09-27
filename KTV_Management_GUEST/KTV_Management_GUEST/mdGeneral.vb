Module mdGeneral
    Dim str As String
    Dim arr() As String
    Dim dtoSong As New DataLayer.ClsSong
    Dim dtoSinger As New DataLayer.ClsSinger


    Public Sub btAddSong(ByVal sender As Object, ByVal e As EventArgs)
        Dim dtoSong As New DataLayer.ClsSong
        Dim dtoSinger As New DataLayer.ClsSinger
        str = sender.name
        arr = str.Split("#")
        addDatatoLsv(FrmSelectedSong.lsvShow, arr)
        If FrmSelectedSong.vlc.playlist.items.count = 0 Then
            FrmSelectedSong.vlc.playlist.add("file:///" & arr(3))
            FrmSelectedSong.vlc.playlist.play()
        Else
            FrmSelectedSong.vlc.playlist.add("file:///" & arr(3))
        End If

        dtoSong.ID = arr(0)
        dtoSong.Title = arr(1)
        dtoSinger.Name = arr(2)
        dtoSong.Singers.Add(dtoSinger)
        dtoSong.Path = arr(3)
        arrSelectedSong.Add(dtoSong)

        FrmFixed.lbShowCurrentSongg.Text = ""
        FrmFixed.lbShowCurrentSongg.Text = MarqueeLeft(arr(1) & "         " & arr(2))
    End Sub


    Public Sub btAddToTopSong(ByVal sender As Object, ByVal e As EventArgs)
        Dim dtoSong As New DataLayer.ClsSong
        Dim dtoSinger As New DataLayer.ClsSinger
        str = sender.name
        arr = str.Split("#")
        insertDatatoLsv(FrmSelectedSong.lsvShow, arr)
        If FrmSelectedSong.vlc.playlist.items.count = 0 Then
            FrmSelectedSong.vlc.playlist.add("file:///" & arr(3))
            FrmSelectedSong.vlc.playlist.play()
        Else
            FrmSelectedSong.vlc.playlist.add("file:///" & arr(3))
        End If

        dtoSong.ID = arr(0)
        dtoSong.Title = arr(1)
        dtoSinger.Name = arr(2)
        dtoSong.Singers.Add(dtoSinger)
        dtoSong.Path = arr(3)
        arrSelectedSong.Add(dtoSong)

        FrmFixed.lbShowCurrentSongg.Text = ""
        FrmFixed.lbShowCurrentSongg.Text = MarqueeLeft(arr(1) & "         " & arr(2))

    End Sub

    'Public Sub btCategoryClicked(ByVal sender As Object, ByVal e As EventArgs)
    '    guestChose = sender.name
    '    FrmCategory.PanelSong.Controls.Clear()
    'End Sub


    Public Function MarqueeLeft(ByVal Text As String)
        Dim Str1 As String = Text.Remove(0, 1)
        Dim Str2 As String = Text(0)
        Return Str1 & Str2
    End Function

    

End Module
