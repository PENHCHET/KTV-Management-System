Imports DataLayer
Public Class FrmCategory

    Private WithEvents BtAdd As DevComponents.DotNetBar.ButtonX
    Private WithEvents BtAddToTop As DevComponents.DotNetBar.ButtonX
    Private WithEvents LbTitle As Windows.Forms.Label
    Private WithEvents LbSinger As Windows.Forms.Label
    Private WithEvents btCategory As DevComponents.DotNetBar.ButtonX
    Private WithEvents PanelS As Windows.Forms.Panel

    Dim dsSongByCate As New DataSet
    Dim dtoCate As New ClsCategory
    Dim daoCate As New ClsCategoryTransaction

    Dim dsSong As New DataSet
    Dim dtoSong As New ClsSong
    Dim daoSong As New ClsSongDetailsTransaction
    Dim dtoSinger As New ClsSinger

    Public Sub FrmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If guestChose = "" Then
            dsSong = daoSong.getAllSongDetails("")
        Else
            dsSong = daoSong.getAllSongDetails(guestChose)
        End If

        Dim i As Integer
        Dim xBtAdd As Integer = 21
        Dim xBtAddToTop As Integer = 67
        Dim xLbTitle As Integer = 121
        Dim xLbSinger As Integer = 679

        Dim yStep As Integer = 3

        For i = 1 To dsSong.Tables(0).Rows.Count


            PanelS = New Windows.Forms.Panel
            PanelS.Size = New System.Drawing.Size(900, 50)
            PanelS.Name = dsSong.Tables(0).Rows(i - 1)(1)
            PanelS.BackColor = Color.Transparent

            BtAdd = New DevComponents.DotNetBar.ButtonX
            BtAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtAdd.Image = Global.KTV_Management_GUEST.My.Resources.Resources.plus
            BtAdd.Location = New System.Drawing.Point(xBtAdd, yStep)
            BtAdd.Name = dsSong.Tables(0).Rows(i - 1)(0) & "#" & dsSong.Tables(0).Rows(i - 1)(1) & "#" & dsSong.Tables(0).Rows(i - 1)(6) & "#" & dsSong.Tables(0).Rows(i - 1)(7)
            BtAdd.Size = New System.Drawing.Size(40, 40)
            BtAdd.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
            BtAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtAdd.TabIndex = 8

            BtAddToTop = New DevComponents.DotNetBar.ButtonX
            BtAddToTop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtAddToTop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtAddToTop.Image = Global.KTV_Management_GUEST.My.Resources.Resources.up
            BtAddToTop.Location = New System.Drawing.Point(xBtAddToTop, yStep)
            BtAddToTop.Name = dsSong.Tables(0).Rows(i - 1)(0) & "#" & dsSong.Tables(0).Rows(i - 1)(1) & "#" & dsSong.Tables(0).Rows(i - 1)(6) & "#" & dsSong.Tables(0).Rows(i - 1)(7)
            BtAddToTop.Size = New System.Drawing.Size(40, 40)
            BtAddToTop.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
            BtAddToTop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtAddToTop.TabIndex = 9

            LbTitle = New Windows.Forms.Label
            LbTitle.Font = New System.Drawing.Font("Khmer OS Muol Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbTitle.ForeColor = System.Drawing.Color.DeepSkyBlue
            LbTitle.Location = New System.Drawing.Point(xLbTitle, yStep)
            LbTitle.Name = "lbTitle" & i
            LbTitle.Size = New System.Drawing.Size(540, 35)
            LbTitle.TabIndex = 3
            LbTitle.Text = dsSong.Tables(0).Rows(i - 1)(1)


            LbSinger = New Windows.Forms.Label
            LbSinger.Font = New System.Drawing.Font("Khmer OS Muol Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbSinger.ForeColor = System.Drawing.Color.Magenta
            LbSinger.Location = New System.Drawing.Point(xLbSinger, yStep)
            LbSinger.Name = "lbTitle" & i
            LbSinger.Size = New System.Drawing.Size(230, 35)
            LbSinger.TabIndex = 4
            LbSinger.Text = dsSong.Tables(0).Rows(i - 1)(6)

            BtAddToTop.Cursor = Cursors.Hand
            BtAdd.Cursor = Cursors.Hand

            AddHandler BtAdd.Click, AddressOf btAddSong
            AddHandler BtAddToTop.Click, AddressOf btAddToTopSong
            PanelS.Controls.Add(BtAdd)
            PanelS.Controls.Add(BtAddToTop)
            PanelS.Controls.Add(LbTitle)
            PanelS.Controls.Add(LbSinger)
            PanelSong.Controls.Add(PanelS)


            '   yStep += 50

        Next


        lbSongCount.Text = dsSong.Tables(0).Rows.Count

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        dsSongByCate = daoCate.getAllCategory()

        Dim j As Integer
        Dim xStepl As Integer = 50
        Dim yStepl As Integer = 23


        For j = 1 To dsSongByCate.Tables(0).Rows.Count

            btCategory = New DevComponents.DotNetBar.ButtonX
            btCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            btCategory.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            btCategory.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btCategory.Location = New System.Drawing.Point(xStepl, yStepl)
            btCategory.Name = dsSongByCate.Tables(0).Rows(j - 1)(1)
            btCategory.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
            btCategory.Size = New System.Drawing.Size(100, 100)
            btCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            btCategory.TabIndex = 0
            btCategory.Text = dsSongByCate.Tables(0).Rows(j - 1)(1) & " Singer"

            AddHandler btCategory.Click, AddressOf btCategoryClicked
            PanelCategory.Controls.Add(btCategory)

            xStepl += 130
            If j Mod 2 = 0 Then
                yStepl += 130
                xStepl = 50
            End If

        Next


    End Sub

    
    Public Sub btCategoryClicked(ByVal sender As Object, ByVal e As EventArgs)
        PanelSong.Controls.Clear()
        dsSong.Tables(0).Rows.Clear()
        dsSong = daoSong.getAllSongDetails(sender.name)

        Dim i As Integer
        Dim xBtAdd As Integer = 21
        Dim xBtAddToTop As Integer = 67
        Dim xLbTitle As Integer = 121
        Dim xLbSinger As Integer = 679

        Dim yStep As Integer = 3

        For i = 1 To dsSong.Tables(0).Rows.Count


            PanelS = New Windows.Forms.Panel
            PanelS.Size = New System.Drawing.Size(900, 50)
            PanelS.Name = dsSong.Tables(0).Rows(i - 1)(1)
            PanelS.BackColor = Color.Transparent

            BtAdd = New DevComponents.DotNetBar.ButtonX
            BtAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtAdd.Image = Global.KTV_Management_GUEST.My.Resources.Resources.plus
            BtAdd.Location = New System.Drawing.Point(xBtAdd, yStep)
            BtAdd.Name = dsSong.Tables(0).Rows(i - 1)(0) & "#" & dsSong.Tables(0).Rows(i - 1)(1) & "#" & dsSong.Tables(0).Rows(i - 1)(6) & "#" & dsSong.Tables(0).Rows(i - 1)(7)
            BtAdd.Size = New System.Drawing.Size(40, 40)
            BtAdd.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
            BtAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtAdd.TabIndex = 8

            BtAddToTop = New DevComponents.DotNetBar.ButtonX
            BtAddToTop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtAddToTop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtAddToTop.Image = Global.KTV_Management_GUEST.My.Resources.Resources.up
            BtAddToTop.Location = New System.Drawing.Point(xBtAddToTop, yStep)
            BtAddToTop.Name = dsSong.Tables(0).Rows(i - 1)(0) & "#" & dsSong.Tables(0).Rows(i - 1)(1) & "#" & dsSong.Tables(0).Rows(i - 1)(6) & "#" & dsSong.Tables(0).Rows(i - 1)(7)
            BtAddToTop.Size = New System.Drawing.Size(40, 40)
            BtAddToTop.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
            BtAddToTop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtAddToTop.TabIndex = 9

            LbTitle = New Windows.Forms.Label
            LbTitle.Font = New System.Drawing.Font("Khmer OS Muol Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbTitle.ForeColor = System.Drawing.Color.DeepSkyBlue
            LbTitle.Location = New System.Drawing.Point(xLbTitle, yStep)
            LbTitle.Name = "lbTitle" & i
            LbTitle.Size = New System.Drawing.Size(540, 35)
            LbTitle.TabIndex = 3
            LbTitle.Text = dsSong.Tables(0).Rows(i - 1)(1)


            LbSinger = New Windows.Forms.Label
            LbSinger.Font = New System.Drawing.Font("Khmer OS Muol Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbSinger.ForeColor = System.Drawing.Color.Magenta
            LbSinger.Location = New System.Drawing.Point(xLbSinger, yStep)
            LbSinger.Name = "lbTitle" & i
            LbSinger.Size = New System.Drawing.Size(230, 35)
            LbSinger.TabIndex = 4
            LbSinger.Text = dsSong.Tables(0).Rows(i - 1)(6)


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
    End Sub


End Class