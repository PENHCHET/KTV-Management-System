<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFixed
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFixed))
        Me.lbShowCurrentSongg = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.btShow = New System.Windows.Forms.Label()
        Me.btHide = New System.Windows.Forms.Label()
        Me.PMenuBottom = New System.Windows.Forms.Panel()
        Me.lbPause = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbPlay = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btApplaud = New DevComponents.DotNetBar.ButtonX()
        Me.btScreen = New DevComponents.DotNetBar.ButtonX()
        Me.btSungList = New DevComponents.DotNetBar.ButtonX()
        Me.btSelectedList = New DevComponents.DotNetBar.ButtonX()
        Me.btLanguage = New DevComponents.DotNetBar.ButtonX()
        Me.btVolOff = New DevComponents.DotNetBar.ButtonX()
        Me.btVolUp = New DevComponents.DotNetBar.ButtonX()
        Me.btVolDown = New DevComponents.DotNetBar.ButtonX()
        Me.btForward = New DevComponents.DotNetBar.ButtonX()
        Me.btReplay = New DevComponents.DotNetBar.ButtonX()
        Me.btNext = New DevComponents.DotNetBar.ButtonX()
        Me.btPlay = New DevComponents.DotNetBar.ButtonX()
        Me.btVocal = New DevComponents.DotNetBar.ButtonX()
        Me.btMain = New DevComponents.DotNetBar.ButtonX()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PMenuBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbShowCurrentSongg
        '
        Me.lbShowCurrentSongg.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbShowCurrentSongg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbShowCurrentSongg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbShowCurrentSongg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShowCurrentSongg.ForeColor = System.Drawing.Color.Yellow
        Me.lbShowCurrentSongg.Location = New System.Drawing.Point(389, 23)
        Me.lbShowCurrentSongg.Name = "lbShowCurrentSongg"
        Me.lbShowCurrentSongg.Size = New System.Drawing.Size(666, 23)
        Me.lbShowCurrentSongg.TabIndex = 4
        Me.lbShowCurrentSongg.Text = "Welcomoe to Dara Penhchet Sokheng KTV"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.BackgroundImage = Global.KTV_Management_GUEST.My.Resources.Resources.Line
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(360, 46)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(720, 10)
        Me.LabelX2.TabIndex = 5
        '
        'btShow
        '
        Me.btShow.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.btShow.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BGHideMenuBottom
        Me.btShow.Location = New System.Drawing.Point(675, 633)
        Me.btShow.Name = "btShow"
        Me.btShow.Size = New System.Drawing.Size(80, 27)
        Me.btShow.TabIndex = 2
        Me.btShow.Visible = False
        '
        'btHide
        '
        Me.btHide.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.btHide.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BGShowMenuBottom
        Me.btHide.Location = New System.Drawing.Point(675, 742)
        Me.btHide.Name = "btHide"
        Me.btHide.Size = New System.Drawing.Size(80, 27)
        Me.btHide.TabIndex = 1
        '
        'PMenuBottom
        '
        Me.PMenuBottom.BackColor = System.Drawing.Color.Transparent
        Me.PMenuBottom.BackgroundImage = Global.KTV_Management_GUEST.My.Resources.Resources.BGMenuBottom
        Me.PMenuBottom.Controls.Add(Me.lbPause)
        Me.PMenuBottom.Controls.Add(Me.Label17)
        Me.PMenuBottom.Controls.Add(Me.Label16)
        Me.PMenuBottom.Controls.Add(Me.Label15)
        Me.PMenuBottom.Controls.Add(Me.Label14)
        Me.PMenuBottom.Controls.Add(Me.Label13)
        Me.PMenuBottom.Controls.Add(Me.Label12)
        Me.PMenuBottom.Controls.Add(Me.Label11)
        Me.PMenuBottom.Controls.Add(Me.Label10)
        Me.PMenuBottom.Controls.Add(Me.Label9)
        Me.PMenuBottom.Controls.Add(Me.Label8)
        Me.PMenuBottom.Controls.Add(Me.lbPlay)
        Me.PMenuBottom.Controls.Add(Me.Label6)
        Me.PMenuBottom.Controls.Add(Me.btApplaud)
        Me.PMenuBottom.Controls.Add(Me.btScreen)
        Me.PMenuBottom.Controls.Add(Me.btSungList)
        Me.PMenuBottom.Controls.Add(Me.btSelectedList)
        Me.PMenuBottom.Controls.Add(Me.btLanguage)
        Me.PMenuBottom.Controls.Add(Me.btVolOff)
        Me.PMenuBottom.Controls.Add(Me.btVolUp)
        Me.PMenuBottom.Controls.Add(Me.btVolDown)
        Me.PMenuBottom.Controls.Add(Me.btForward)
        Me.PMenuBottom.Controls.Add(Me.btReplay)
        Me.PMenuBottom.Controls.Add(Me.btNext)
        Me.PMenuBottom.Controls.Add(Me.btPlay)
        Me.PMenuBottom.Controls.Add(Me.btVocal)
        Me.PMenuBottom.Controls.Add(Me.btMain)
        Me.PMenuBottom.Location = New System.Drawing.Point(2, 650)
        Me.PMenuBottom.Name = "PMenuBottom"
        Me.PMenuBottom.Size = New System.Drawing.Size(1370, 130)
        Me.PMenuBottom.TabIndex = 3
        Me.PMenuBottom.Visible = False
        '
        'lbPause
        '
        Me.lbPause.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPause.ForeColor = System.Drawing.Color.White
        Me.lbPause.Image = Global.KTV_Management_GUEST.My.Resources.Resources.pause
        Me.lbPause.Location = New System.Drawing.Point(221, 88)
        Me.lbPause.Name = "lbPause"
        Me.lbPause.Size = New System.Drawing.Size(63, 19)
        Me.lbPause.TabIndex = 27
        Me.lbPause.Visible = False
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Image = Global.KTV_Management_GUEST.My.Resources.Resources.selectedlist
        Me.Label17.Location = New System.Drawing.Point(1138, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 19)
        Me.Label17.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Image = Global.KTV_Management_GUEST.My.Resources.Resources.sunglist
        Me.Label16.Location = New System.Drawing.Point(1063, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 19)
        Me.Label16.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Image = Global.KTV_Management_GUEST.My.Resources.Resources.screen
        Me.Label15.Location = New System.Drawing.Point(990, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 19)
        Me.Label15.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Image = Global.KTV_Management_GUEST.My.Resources.Resources.applaud
        Me.Label14.Location = New System.Drawing.Point(899, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 19)
        Me.Label14.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Image = Global.KTV_Management_GUEST.My.Resources.Resources.volup
        Me.Label13.Location = New System.Drawing.Point(765, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 19)
        Me.Label13.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Image = Global.KTV_Management_GUEST.My.Resources.Resources.voldown
        Me.Label12.Location = New System.Drawing.Point(680, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 19)
        Me.Label12.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Image = Global.KTV_Management_GUEST.My.Resources.Resources.voloff
        Me.Label11.Location = New System.Drawing.Point(594, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Image = Global.KTV_Management_GUEST.My.Resources.Resources.forward
        Me.Label10.Location = New System.Drawing.Point(452, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 19)
        Me.Label10.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = Global.KTV_Management_GUEST.My.Resources.Resources.replay
        Me.Label9.Location = New System.Drawing.Point(375, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 19)
        Me.Label9.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = Global.KTV_Management_GUEST.My.Resources.Resources._next
        Me.Label8.Location = New System.Drawing.Point(303, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 19)
        Me.Label8.TabIndex = 17
        '
        'lbPlay
        '
        Me.lbPlay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPlay.ForeColor = System.Drawing.Color.White
        Me.lbPlay.Image = Global.KTV_Management_GUEST.My.Resources.Resources.play
        Me.lbPlay.Location = New System.Drawing.Point(228, 89)
        Me.lbPlay.Name = "lbPlay"
        Me.lbPlay.Size = New System.Drawing.Size(63, 19)
        Me.lbPlay.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.KTV_Management_GUEST.My.Resources.Resources.vocal
        Me.Label6.Location = New System.Drawing.Point(149, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 19)
        Me.Label6.TabIndex = 15
        '
        'btApplaud
        '
        Me.btApplaud.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btApplaud.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btApplaud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btApplaud.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtApplaud
        Me.btApplaud.Location = New System.Drawing.Point(910, 31)
        Me.btApplaud.Name = "btApplaud"
        Me.btApplaud.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btApplaud.Size = New System.Drawing.Size(55, 55)
        Me.btApplaud.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btApplaud.TabIndex = 14
        '
        'btScreen
        '
        Me.btScreen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btScreen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btScreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btScreen.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtScreen
        Me.btScreen.Location = New System.Drawing.Point(990, 31)
        Me.btScreen.Name = "btScreen"
        Me.btScreen.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btScreen.Size = New System.Drawing.Size(55, 55)
        Me.btScreen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btScreen.TabIndex = 13
        '
        'btSungList
        '
        Me.btSungList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSungList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSungList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSungList.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtSungList
        Me.btSungList.Location = New System.Drawing.Point(1071, 31)
        Me.btSungList.Name = "btSungList"
        Me.btSungList.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btSungList.Size = New System.Drawing.Size(55, 55)
        Me.btSungList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSungList.TabIndex = 12
        '
        'btSelectedList
        '
        Me.btSelectedList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btSelectedList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btSelectedList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSelectedList.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtSelectedList
        Me.btSelectedList.Location = New System.Drawing.Point(1150, 31)
        Me.btSelectedList.Name = "btSelectedList"
        Me.btSelectedList.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btSelectedList.Size = New System.Drawing.Size(55, 55)
        Me.btSelectedList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btSelectedList.TabIndex = 11
        '
        'btLanguage
        '
        Me.btLanguage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btLanguage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btLanguage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLanguage.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtLanguage
        Me.btLanguage.Location = New System.Drawing.Point(1249, 20)
        Me.btLanguage.Name = "btLanguage"
        Me.btLanguage.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btLanguage.Size = New System.Drawing.Size(88, 88)
        Me.btLanguage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btLanguage.TabIndex = 10
        '
        'btVolOff
        '
        Me.btVolOff.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVolOff.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVolOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVolOff.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtVolOff
        Me.btVolOff.Location = New System.Drawing.Point(601, 31)
        Me.btVolOff.Name = "btVolOff"
        Me.btVolOff.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btVolOff.Size = New System.Drawing.Size(55, 55)
        Me.btVolOff.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btVolOff.TabIndex = 9
        '
        'btVolUp
        '
        Me.btVolUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVolUp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVolUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVolUp.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtVolUp
        Me.btVolUp.Location = New System.Drawing.Point(775, 31)
        Me.btVolUp.Name = "btVolUp"
        Me.btVolUp.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btVolUp.Size = New System.Drawing.Size(55, 55)
        Me.btVolUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btVolUp.TabIndex = 8
        '
        'btVolDown
        '
        Me.btVolDown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVolDown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVolDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVolDown.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtVolDown
        Me.btVolDown.Location = New System.Drawing.Point(689, 31)
        Me.btVolDown.Name = "btVolDown"
        Me.btVolDown.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btVolDown.Size = New System.Drawing.Size(55, 55)
        Me.btVolDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btVolDown.TabIndex = 7
        '
        'btForward
        '
        Me.btForward.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btForward.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btForward.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btForward.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtForward
        Me.btForward.Location = New System.Drawing.Point(456, 31)
        Me.btForward.Name = "btForward"
        Me.btForward.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btForward.Size = New System.Drawing.Size(55, 55)
        Me.btForward.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btForward.TabIndex = 6
        '
        'btReplay
        '
        Me.btReplay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btReplay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btReplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btReplay.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtReplay
        Me.btReplay.Location = New System.Drawing.Point(380, 31)
        Me.btReplay.Name = "btReplay"
        Me.btReplay.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btReplay.Size = New System.Drawing.Size(55, 55)
        Me.btReplay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btReplay.TabIndex = 5
        '
        'btNext
        '
        Me.btNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNext.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtNext
        Me.btNext.Location = New System.Drawing.Point(303, 31)
        Me.btNext.Name = "btNext"
        Me.btNext.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btNext.Size = New System.Drawing.Size(55, 55)
        Me.btNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btNext.TabIndex = 4
        '
        'btPlay
        '
        Me.btPlay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btPlay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPlay.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtPlay
        Me.btPlay.Location = New System.Drawing.Point(227, 31)
        Me.btPlay.Name = "btPlay"
        Me.btPlay.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btPlay.Size = New System.Drawing.Size(55, 55)
        Me.btPlay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btPlay.TabIndex = 3
        '
        'btVocal
        '
        Me.btVocal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVocal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVocal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVocal.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtVocal
        Me.btVocal.Location = New System.Drawing.Point(152, 31)
        Me.btVocal.Name = "btVocal"
        Me.btVocal.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btVocal.Size = New System.Drawing.Size(55, 55)
        Me.btVocal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btVocal.TabIndex = 2
        '
        'btMain
        '
        Me.btMain.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btMain.BackColor = System.Drawing.Color.Transparent
        Me.btMain.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btMain.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BtMain
        Me.btMain.Location = New System.Drawing.Point(22, 20)
        Me.btMain.Name = "btMain"
        Me.btMain.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btMain.Size = New System.Drawing.Size(88, 88)
        Me.btMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btMain.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Khmer OS Muol Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(2, 592)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "ចាក​ Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'FrmFixed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1370, 768)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btHide)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.lbShowCurrentSongg)
        Me.Controls.Add(Me.btShow)
        Me.Controls.Add(Me.PMenuBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFixed"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PMenuBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btHide As System.Windows.Forms.Label
    Friend WithEvents btShow As System.Windows.Forms.Label
    Friend WithEvents PMenuBottom As System.Windows.Forms.Panel
    Friend WithEvents btMain As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btVocal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbShowCurrentSongg As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btForward As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btReplay As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btPlay As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btLanguage As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btVolOff As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btVolUp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btVolDown As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btApplaud As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btScreen As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSungList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btSelectedList As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbPlay As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbPause As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
