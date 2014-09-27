Imports DataLayer
Public Class FrmWriting

    Private WithEvents BtAdd As DevComponents.DotNetBar.ButtonX
    Private WithEvents BtAddToTop As DevComponents.DotNetBar.ButtonX
    Private WithEvents LbTitle As Windows.Forms.Label
    Private WithEvents LbSinger As Windows.Forms.Label
    Private WithEvents PanelS As Windows.Forms.Panel

    Dim ds As New DataSet
    Dim dtoSong As New DataLayer.ClsSong
    Dim daoSong As New DataLayer.ClsSongDetailsTransaction
    Dim dtoSinger As New DataLayer.ClsSinger


    Public Sub FrmSong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtoSinger.Name = guestChose
        ds = daoSong.getAllSongDetails(dtoSinger.Name)
        getSongs()
    End Sub


    Private Sub btToEng_Click(sender As Object, e As EventArgs) Handles btToEng.Click
        PEngKey.Visible = False
        PKhKey.Visible = True
    End Sub

    Private Sub btToKh_Click(sender As Object, e As EventArgs) Handles btToKh.Click
        PEngKey.Visible = True
        PKhKey.Visible = False
    End Sub


    Private Sub btToEng_Click_1(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button31.Click, Button3.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        PanelSong.Controls.Clear()
        ds.Tables(0).Rows.Clear()
        ds = daoSong.getAllSongTitleStart(sender.text)
        getSongs()
    End Sub


    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button73.Click, Button72.Click, Button71.Click, Button70.Click, Button68.Click, Button67.Click, Button66.Click, Button65.Click, Button64.Click, Button63.Click, Button62.Click, Button61.Click, Button60.Click, Button59.Click, Button58.Click, Button57.Click, Button56.Click, Button55.Click, Button54.Click, Button53.Click, Button52.Click, Button51.Click, Button50.Click, Button49.Click, Button48.Click, Button47.Click, Button46.Click, Button45.Click, Button44.Click, Button43.Click, Button42.Click, Button41.Click, Button40.Click, Button39.Click, Button38.Click, Button37.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button29.Click, Button28.Click, Button27.Click
        PanelSong.Controls.Clear()
        ds.Tables(0).Rows.Clear()
        ds = daoSong.getAllSongTitleStart(sender.text)
        getSongs()
    End Sub


    Public Sub getSongs()
        Dim i As Integer
        Dim xBtAdd As Integer = 21
        Dim xBtAddToTop As Integer = 67
        Dim xLbTitle As Integer = 121
        Dim xLbSinger As Integer = 679

        Dim yStep As Integer = 3



        For i = 1 To ds.Tables(0).Rows.Count

            PanelS = New Windows.Forms.Panel
            PanelS.Size = New System.Drawing.Size(900, 50)
            PanelS.Name = ds.Tables(0).Rows(i - 1)(1)
            PanelS.BackColor = Color.Transparent

            BtAdd = New DevComponents.DotNetBar.ButtonX
            BtAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtAdd.Image = Global.KTV_Management_GUEST.My.Resources.Resources.plus
            BtAdd.Location = New System.Drawing.Point(xBtAdd, yStep)
            BtAdd.Name = ds.Tables(0).Rows(i - 1)(0) & "#" & ds.Tables(0).Rows(i - 1)(1) & "#" & ds.Tables(0).Rows(i - 1)(6) & "#" & ds.Tables(0).Rows(i - 1)(7)
            BtAdd.Size = New System.Drawing.Size(40, 40)
            BtAdd.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
            BtAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtAdd.TabIndex = 8


            BtAddToTop = New DevComponents.DotNetBar.ButtonX
            BtAddToTop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtAddToTop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtAddToTop.Image = Global.KTV_Management_GUEST.My.Resources.Resources.up
            BtAddToTop.Location = New System.Drawing.Point(xBtAddToTop, yStep)
            BtAddToTop.Name = ds.Tables(0).Rows(i - 1)(0) & "#" & ds.Tables(0).Rows(i - 1)(1) & "#" & ds.Tables(0).Rows(i - 1)(6) & "#" & ds.Tables(0).Rows(i - 1)(7)
            BtAddToTop.Size = New System.Drawing.Size(40, 40)
            BtAddToTop.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
            BtAddToTop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtAddToTop.TabIndex = 9

            LbTitle = New Windows.Forms.Label
            LbTitle.Font = New System.Drawing.Font("Khmer OS Muol Light", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbTitle.ForeColor = System.Drawing.Color.DeepSkyBlue
            LbTitle.Location = New System.Drawing.Point(xLbTitle, yStep)
            LbTitle.Name = ds.Tables(0).Rows(i - 1)(0) & "#" & ds.Tables(0).Rows(i - 1)(1) & "#" & ds.Tables(0).Rows(i - 1)(6) & "#" & ds.Tables(0).Rows(i - 1)(7)
            LbTitle.Size = New System.Drawing.Size(540, 35)
            LbTitle.TabIndex = 3
            LbTitle.Text = ds.Tables(0).Rows(i - 1)(1)


            LbSinger = New Windows.Forms.Label
            LbSinger.Font = New System.Drawing.Font("Khmer OS Muol Light", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbSinger.ForeColor = System.Drawing.Color.Magenta
            LbSinger.Location = New System.Drawing.Point(xLbSinger, yStep)
            LbSinger.Name = ds.Tables(0).Rows(i - 1)(0) & "#" & ds.Tables(0).Rows(i - 1)(1) & "#" & ds.Tables(0).Rows(i - 1)(6) & "#" & ds.Tables(0).Rows(i - 1)(7)
            LbSinger.Size = New System.Drawing.Size(230, 35)
            LbSinger.TabIndex = 4
            LbSinger.Text = ds.Tables(0).Rows(i - 1)(6)


            BtAddToTop.Cursor = Cursors.Hand
            BtAdd.Cursor = Cursors.Hand

            AddHandler BtAdd.Click, AddressOf btAddSong
            AddHandler BtAddToTop.Click, AddressOf btAddToTopSong
            PanelS.Controls.Add(BtAdd)
            PanelS.Controls.Add(BtAddToTop)
            PanelS.Controls.Add(LbTitle)
            PanelS.Controls.Add(LbSinger)
            PanelSong.Controls.Add(PanelS)

            ' yStep += 50

        Next
        lbSongCount.Text = ds.Tables(0).Rows.Count
    End Sub


End Class