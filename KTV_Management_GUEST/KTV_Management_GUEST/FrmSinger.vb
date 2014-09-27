Public Class FrmSinger

    Private WithEvents BtSingers As DevComponents.DotNetBar.ButtonX
    Private WithEvents BtSingerType As DevComponents.DotNetBar.ButtonX
    Private WithEvents LbSingers As Windows.Forms.Label
    Private WithEvents PanelS As Windows.Forms.Panel

    Dim obj As New DataLayer.ClsSingerTransaction
    Dim ds As New DataSet


    Private Sub FrmSingers_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ds = obj.getAllSingers()
        'For ii = 0 To ds.Tables(0).Rows.Count - 1
        '    MsgBox(ds.Tables(0).Rows(ii)(0) & ds.Tables(0).Rows(ii)(1) & ds.Tables(0).Rows(ii)(2))
        'Next

        Dim imageData As Byte()

        Dim i As Integer
        Dim xStep As Integer = 3
        Dim yStep As Integer = 3

        Dim zStep As Integer = 175 'label

        For i = 1 To ds.Tables(0).Rows.Count

            PanelS = New Windows.Forms.Panel
            PanelS.Size = New System.Drawing.Size(180, 220)
            PanelS.Name = ds.Tables(0).Rows(i - 1)(1)
            PanelS.BackColor = Color.Transparent

            BtSingers = New DevComponents.DotNetBar.ButtonX
            BtSingers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtSingers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtSingers.Font = New System.Drawing.Font("Khmer OS Muol Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            BtSingers.Location = New System.Drawing.Point(xStep, yStep)
            BtSingers.Name = ds.Tables(0).Rows(i - 1)(1)
            BtSingers.Size = New System.Drawing.Size(170, 170)
            BtSingers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtSingers.TabIndex = 0
            imageData = CType(ds.Tables(0).Rows(i - 1)(3), Byte())
            If Not imageData Is Nothing Then
                Dim ms As New System.IO.MemoryStream(imageData)
                BtSingers.Image = Image.FromStream(ms)

            End If

            LbSingers = New Windows.Forms.Label
            LbSingers.Font = New System.Drawing.Font("Khmer OS Muol Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbSingers.ForeColor = System.Drawing.Color.Magenta
            LbSingers.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BGSinger
            LbSingers.Location = New System.Drawing.Point(xStep, zStep)
            LbSingers.Name = ds.Tables(0).Rows(i - 1)(0)
            LbSingers.Size = New System.Drawing.Size(170, 25)
            LbSingers.TabIndex = 3
            LbSingers.Text = ds.Tables(0).Rows(i - 1)(1)
            LbSingers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

            LbSingers.Cursor = Cursors.Hand
            BtSingers.Cursor = Cursors.Hand

            AddHandler BtSingers.Click, AddressOf ButtonClicked
            AddHandler LbSingers.Click, AddressOf ButtonClicked
            PanelS.Controls.Add(BtSingers)
            PanelS.Controls.Add(LbSingers)
            PanelSong.Controls.Add(PanelS)


            ' xStep += 195
            'If i Mod 5 = 0 Then
            '    yStep += 230
            '    zStep += 230
            '    xStep = 3
            'End If

        Next


        lbCountSong.Text = ds.Tables(0).Rows.Count

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        Dim j As Integer
        Dim xStepl As Integer = 30
        Dim yStepl As Integer = 30


        For j = 1 To 5

            BtSingerType = New DevComponents.DotNetBar.ButtonX
            BtSingerType.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtSingerType.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtSingerType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            BtSingerType.Location = New System.Drawing.Point(xStepl, yStepl)
            BtSingerType.Name = "btSingerType" & j
            BtSingerType.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
            BtSingerType.Size = New System.Drawing.Size(100, 100)
            BtSingerType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtSingerType.TabIndex = 0
            BtSingerType.Text = "Camboidan Male Singer" & j


            AddHandler BtSingers.Click, AddressOf ButtonClicked
            PSingerType.Controls.Add(BtSingerType)

            xStepl += 150
            If j Mod 2 = 0 Then
                yStepl += 150
                xStepl = 30
            End If

        Next

    End Sub

    Private Sub ButtonClicked(ByVal sender As Object, ByVal e As EventArgs)
        guestChose = sender.name
        Me.Hide()
        FrmSong.Show()
    End Sub

  
End Class