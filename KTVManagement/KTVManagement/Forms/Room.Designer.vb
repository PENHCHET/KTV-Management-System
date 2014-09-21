<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblRoomID = New System.Windows.Forms.Label()
        Me.lable2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTimeIn = New System.Windows.Forms.Label()
        Me.lblTimeOut = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.label111 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRoomID
        '
        Me.lblRoomID.AutoSize = True
        Me.lblRoomID.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomID.ForeColor = System.Drawing.Color.White
        Me.lblRoomID.Location = New System.Drawing.Point(67, 3)
        Me.lblRoomID.Name = "lblRoomID"
        Me.lblRoomID.Size = New System.Drawing.Size(25, 28)
        Me.lblRoomID.TabIndex = 0
        Me.lblRoomID.Text = "1"
        Me.lblRoomID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lable2
        '
        Me.lable2.AutoSize = True
        Me.lable2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable2.ForeColor = System.Drawing.Color.White
        Me.lable2.Location = New System.Drawing.Point(3, 70)
        Me.lable2.Name = "lable2"
        Me.lable2.Size = New System.Drawing.Size(77, 20)
        Me.lable2.TabIndex = 1
        Me.lable2.Text = "Time Out:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Time In:"
        '
        'lblTimeIn
        '
        Me.lblTimeIn.AutoSize = True
        Me.lblTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeIn.ForeColor = System.Drawing.Color.White
        Me.lblTimeIn.Location = New System.Drawing.Point(38, 47)
        Me.lblTimeIn.Name = "lblTimeIn"
        Me.lblTimeIn.Size = New System.Drawing.Size(79, 20)
        Me.lblTimeIn.TabIndex = 3
        Me.lblTimeIn.Text = "00:00:00"
        Me.lblTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeOut
        '
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.ForeColor = System.Drawing.Color.White
        Me.lblTimeOut.Location = New System.Drawing.Point(38, 93)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(79, 20)
        Me.lblTimeOut.TabIndex = 4
        Me.lblTimeOut.Text = "00:00:00"
        Me.lblTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.ForeColor = System.Drawing.Color.White
        Me.lblRemaining.Location = New System.Drawing.Point(38, 139)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(79, 20)
        Me.lblRemaining.TabIndex = 6
        Me.lblRemaining.Text = "00:00:00"
        Me.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label111
        '
        Me.label111.AutoSize = True
        Me.label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label111.ForeColor = System.Drawing.Color.White
        Me.label111.Location = New System.Drawing.Point(3, 116)
        Me.label111.Name = "label111"
        Me.label111.Size = New System.Drawing.Size(89, 20)
        Me.label111.TabIndex = 5
        Me.label111.Text = "Remaining:"
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.label111)
        Me.Controls.Add(Me.lblTimeOut)
        Me.Controls.Add(Me.lblTimeIn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lable2)
        Me.Controls.Add(Me.lblRoomID)
        Me.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Room"
        Me.Size = New System.Drawing.Size(160, 160)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRoomID As System.Windows.Forms.Label
    Friend WithEvents lable2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTimeIn As System.Windows.Forms.Label
    Friend WithEvents lblTimeOut As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents label111 As System.Windows.Forms.Label

End Class
