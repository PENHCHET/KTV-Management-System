Public Class CopyFrmSinger

    Private WithEvents BtSingers As DevComponents.DotNetBar.ButtonX
    Private WithEvents BtSingerType As DevComponents.DotNetBar.ButtonX
    Private WithEvents LbSingers As Windows.Forms.Label

    Private Sub CopyFrmSingers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim xStep As Integer = 3
        Dim yStep As Integer = 3

        Dim zStep As Integer = 175 'label

        For i = 1 To 9

            BtSingers = New DevComponents.DotNetBar.ButtonX
            BtSingers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            BtSingers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            BtSingers.Location = New System.Drawing.Point(xStep, yStep)
            BtSingers.Name = "btSinger" & i
            BtSingers.Size = New System.Drawing.Size(170, 170)
            BtSingers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            BtSingers.TabIndex = 0
            BtSingers.Text = "Preab Sovat" & i

            LbSingers = New Windows.Forms.Label
            LbSingers.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            LbSingers.ForeColor = System.Drawing.Color.Magenta
            LbSingers.Image = Global.KTV_Management_GUEST.My.Resources.Resources.BGSinger
            LbSingers.Location = New System.Drawing.Point(xStep, zStep)
            LbSingers.Name = "lbSinger" & i
            LbSingers.Size = New System.Drawing.Size(170, 25)
            LbSingers.TabIndex = 3
            LbSingers.Text = "Preab Sovat" & i
            LbSingers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter


            AddHandler BtSingers.Click, AddressOf ButtonClicked
            Me.Controls.Add(BtSingers)
            PanelSinger.Controls.Add(BtSingers)
            PanelSinger.Controls.Add(LbSingers)

            xStep += 195
            If i Mod 5 = 0 Then
                yStep += 230
                zStep += 230
                xStep = 3
            End If

        Next


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        Dim j As Integer
        Dim xStepl As Integer = 50
        Dim yStepl As Integer = 23


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

            xStepl += 130
            If j Mod 2 = 0 Then
                yStepl += 130
                xStepl = 50
            End If

        Next

    End Sub

    Private Sub ButtonClicked(ByVal sender As Object, ByVal e As EventArgs)
        MsgBox("You clicked: " & sender.name & vbCrLf & "Button name: " & sender.Text)
        Me.Hide()
        FrmSong.Show()
    End Sub

End Class