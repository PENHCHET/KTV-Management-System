﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategory
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
        Me.PanelCategory = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbSongCount = New System.Windows.Forms.Label()
        Me.PanelSong = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'PanelCategory
        '
        Me.PanelCategory.AutoScroll = True
        Me.PanelCategory.BackColor = System.Drawing.Color.MediumVioletRed
        Me.PanelCategory.Location = New System.Drawing.Point(997, 106)
        Me.PanelCategory.Name = "PanelCategory"
        Me.PanelCategory.Size = New System.Drawing.Size(330, 500)
        Me.PanelCategory.TabIndex = 27
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
        Me.lbSongCount.Location = New System.Drawing.Point(107, 584)
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
        Me.PanelSong.TabIndex = 35
        '
        'FrmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 690)
        Me.Controls.Add(Me.PanelSong)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbSongCount)
        Me.Controls.Add(Me.PanelCategory)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmCategory"
        Me.Text = "FrmSong"
        Me.Controls.SetChildIndex(Me.PanelCategory, 0)
        Me.Controls.SetChildIndex(Me.lbSongCount, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.PanelSong, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelCategory As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbSongCount As System.Windows.Forms.Label
    Friend WithEvents PanelSong As System.Windows.Forms.FlowLayoutPanel
End Class
