Module mdVaraible
    Public guestChose
    Public arrSelectedSong As New ArrayList
    Public selectedSongFrm As Boolean = False


    Public Sub addDatatoLsv(ByVal lsv As ListView, ByVal data() As String)
        Dim lstItem As New ListViewItem
        lstItem.Text = data(0)
        For i = 1 To UBound(data)
            lstItem.SubItems.Add(data(i))
        Next
        lsv.Items.Add(lstItem)
    End Sub

    Public Sub insertDatatoLsv(ByVal lsv As ListView, ByVal data() As String)
        Dim lstItem As New ListViewItem
        lstItem.Text = data(0)
        For i = 1 To UBound(data)
            lstItem.SubItems.Add(data(i))
        Next
        lsv.Items.Insert(0, lstItem)
    End Sub

End Module
