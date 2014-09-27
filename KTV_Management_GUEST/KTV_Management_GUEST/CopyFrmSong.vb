Public Class CopyFrmSong

    Private WithEvents BtAdd As DevComponents.DotNetBar.ButtonX
    Private WithEvents BtAddToTop As DevComponents.DotNetBar.ButtonX
    Private WithEvents LbTitle As Windows.Forms.Label
    Private WithEvents LbSinger As Windows.Forms.Label

    Private Sub CopyFrmSong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim xBtAdd As Integer = 21
        Dim xBtAddToTop As Integer = 67
        Dim xLbTitle As Integer = 121
        Dim xLbSinger As Integer = 679

        Dim yStep As Integer = 3



        For i = 1 To 9

            BtAdd = New DevComponents.DotNetBar.ButtonX
            BtAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtAdd.Image = Global.KTV_Management_GUEST.My.Resources.Resources.plus
            BtAdd.Location = New System.Drawing.Point(xBtAdd, yStep)
            BtAdd.Name = "btAdd" & i
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
            LbTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbTitle.ForeColor = System.Drawing.Color.DeepSkyBlue
            LbTitle.Location = New System.Drawing.Point(xLbTitle, yStep)
            LbTitle.Name = "lbTitle" & i
            LbTitle.Size = New System.Drawing.Size(540, 35)
            LbTitle.TabIndex = 3
            LbTitle.Text = "I miss you like crazy."


            LbSinger = New Windows.Forms.Label
            LbSinger.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbSinger.ForeColor = System.Drawing.Color.Magenta
            LbSinger.Location = New System.Drawing.Point(xLbSinger, yStep)
            LbSinger.Name = "lbTitle" & i
            LbSinger.Size = New System.Drawing.Size(230, 35)
            LbSinger.TabIndex = 4
            LbSinger.Text = "Preab Sovat"


            AddHandler BtAdd.Click, AddressOf ButtonClicked
            AddHandler BtAddToTop.Click, AddressOf ButtonClicked
            AddHandler LbTitle.Click, AddressOf ButtonClicked
            AddHandler LbSinger.Click, AddressOf ButtonClicked
            PanelSong.Controls.Add(BtAdd)
            PanelSong.Controls.Add(BtAddToTop)
            PanelSong.Controls.Add(LbTitle)
            PanelSong.Controls.Add(LbSinger)


            yStep += 50

        Next
    End Sub

    Private Sub ButtonClicked(ByVal sender As Object, ByVal e As EventArgs)
        MsgBox("You clicked: " & sender.name & vbCrLf & "Button name: " & sender.Text)
    End Sub

    Private Sub btToEng_Click(sender As Object, e As EventArgs) Handles btToEng.Click
        PEngKey.Visible = False
        PKhKey.Visible = True
    End Sub

    Private Sub btToKh_Click(sender As Object, e As EventArgs) Handles btToKh.Click
        PEngKey.Visible = True
        PKhKey.Visible = False
    End Sub





End Class