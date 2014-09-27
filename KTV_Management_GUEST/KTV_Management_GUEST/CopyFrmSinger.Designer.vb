<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopyFrmSinger
    'Inherits System.Windows.Forms.Form
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
        Me.PSingerType = New System.Windows.Forms.Panel()
        Me.PanelSinger = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PSingerType
        '
        Me.PSingerType.BackColor = System.Drawing.Color.MediumVioletRed
        Me.PSingerType.Location = New System.Drawing.Point(997, 106)
        Me.PSingerType.Name = "PSingerType"
        Me.PSingerType.Size = New System.Drawing.Size(330, 500)
        Me.PSingerType.TabIndex = 8
        '
        'PanelSinger
        '
        Me.PanelSinger.BackColor = System.Drawing.Color.Transparent
        Me.PanelSinger.Location = New System.Drawing.Point(29, 106)
        Me.PanelSinger.Name = "PanelSinger"
        Me.PanelSinger.Size = New System.Drawing.Size(960, 450)
        Me.PanelSinger.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Magenta
        Me.Label3.Location = New System.Drawing.Point(305, 572)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "1 / 200 Pages"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.KTV_Management_GUEST.My.Resources.Resources.bgNext
        Me.Label4.Location = New System.Drawing.Point(914, 572)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 30)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Next"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = Global.KTV_Management_GUEST.My.Resources.Resources.bgNext
        Me.Label5.Location = New System.Drawing.Point(832, 572)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 30)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Previous"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = Global.KTV_Management_GUEST.My.Resources.Resources.bgNext
        Me.Label7.Location = New System.Drawing.Point(750, 572)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 30)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "First"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmSinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 729)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PanelSinger)
        Me.Controls.Add(Me.PSingerType)
        Me.Controls.Add(Me.Label3)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmSinger"
        Me.Text = "FrmSingers"
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.PSingerType, 0)
        Me.Controls.SetChildIndex(Me.PanelSinger, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PSingerType As System.Windows.Forms.Panel
    Friend WithEvents PanelSinger As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
