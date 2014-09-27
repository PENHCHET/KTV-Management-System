<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectedSong
    ' Inherits System.Windows.Forms.Form
    Inherits FrmFixed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelectedSong))
        Me.PKhKey = New System.Windows.Forms.Panel()
        Me.vlc2 = New AxAXVLC.AxVLCPlugin2()
        Me.vlc = New AxAXVLC.AxVLCPlugin2()
        Me.lsvShow = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbSongCount = New System.Windows.Forms.Label()
        Me.PanelSong = New System.Windows.Forms.FlowLayoutPanel()
        Me.PKhKey.SuspendLayout()
        CType(Me.vlc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PKhKey
        '
        Me.PKhKey.BackColor = System.Drawing.Color.MediumVioletRed
        Me.PKhKey.Controls.Add(Me.vlc2)
        Me.PKhKey.Controls.Add(Me.vlc)
        Me.PKhKey.Location = New System.Drawing.Point(997, 106)
        Me.PKhKey.Name = "PKhKey"
        Me.PKhKey.Size = New System.Drawing.Size(330, 500)
        Me.PKhKey.TabIndex = 27
        '
        'vlc2
        '
        Me.vlc2.Enabled = True
        Me.vlc2.Location = New System.Drawing.Point(16, 279)
        Me.vlc2.Name = "vlc2"
        Me.vlc2.OcxState = CType(resources.GetObject("vlc2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlc2.Size = New System.Drawing.Size(300, 200)
        Me.vlc2.TabIndex = 33
        Me.vlc2.Visible = False
        '
        'vlc
        '
        Me.vlc.Enabled = True
        Me.vlc.Location = New System.Drawing.Point(14, 35)
        Me.vlc.Name = "vlc"
        Me.vlc.OcxState = CType(resources.GetObject("vlc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlc.Size = New System.Drawing.Size(300, 200)
        Me.vlc.TabIndex = 1
        '
        'lsvShow
        '
        Me.lsvShow.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvShow.FullRowSelect = True
        Me.lsvShow.GridLines = True
        Me.lsvShow.Location = New System.Drawing.Point(232, 557)
        Me.lsvShow.Name = "lsvShow"
        Me.lsvShow.Size = New System.Drawing.Size(500, 100)
        Me.lsvShow.TabIndex = 0
        Me.lsvShow.UseCompatibleStateImageBehavior = False
        Me.lsvShow.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Title"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Singer"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Location"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = Global.KTV_Management_GUEST.My.Resources.Resources.bgNext
        Me.Label7.Location = New System.Drawing.Point(749, 578)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 30)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "First"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = Global.KTV_Management_GUEST.My.Resources.Resources.bgNext
        Me.Label5.Location = New System.Drawing.Point(831, 578)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 30)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Previous"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.KTV_Management_GUEST.My.Resources.Resources.bgNext
        Me.Label4.Location = New System.Drawing.Point(913, 578)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 30)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Next"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'lbSongCount
        '
        Me.lbSongCount.AutoSize = True
        Me.lbSongCount.BackColor = System.Drawing.Color.Transparent
        Me.lbSongCount.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSongCount.ForeColor = System.Drawing.Color.Magenta
        Me.lbSongCount.Location = New System.Drawing.Point(95, 590)
        Me.lbSongCount.Name = "lbSongCount"
        Me.lbSongCount.Size = New System.Drawing.Size(119, 22)
        Me.lbSongCount.TabIndex = 29
        Me.lbSongCount.Text = "1 / 200 Pages"
        '
        'PanelSong
        '
        Me.PanelSong.AutoScroll = True
        Me.PanelSong.BackColor = System.Drawing.Color.Transparent
        Me.PanelSong.Location = New System.Drawing.Point(28, 106)
        Me.PanelSong.Name = "PanelSong"
        Me.PanelSong.Size = New System.Drawing.Size(960, 450)
        Me.PanelSong.TabIndex = 34
        '
        'FrmSelectedSong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 690)
        Me.Controls.Add(Me.PanelSong)
        Me.Controls.Add(Me.lsvShow)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbSongCount)
        Me.Controls.Add(Me.PKhKey)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmSelectedSong"
        Me.Text = "FrmSelectedSong"
        Me.Controls.SetChildIndex(Me.PKhKey, 0)
        Me.Controls.SetChildIndex(Me.lbSongCount, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.lsvShow, 0)
        Me.Controls.SetChildIndex(Me.PanelSong, 0)
        Me.PKhKey.ResumeLayout(False)
        CType(Me.vlc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PKhKey As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbSongCount As System.Windows.Forms.Label
    Friend WithEvents lsvShow As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents vlc As AxAXVLC.AxVLCPlugin2
    Friend WithEvents vlc2 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents PanelSong As System.Windows.Forms.FlowLayoutPanel
End Class
