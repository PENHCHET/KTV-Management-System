<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.PMenu = New System.Windows.Forms.Panel()
        Me.WrapMainMenu = New System.Windows.Forms.Panel()
        Me.lbCategory = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTopHit = New System.Windows.Forms.Label()
        Me.lbSingers = New System.Windows.Forms.Label()
        Me.lbProduction = New System.Windows.Forms.Label()
        Me.PMenu.SuspendLayout()
        Me.WrapMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PMenu
        '
        Me.PMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PMenu.BackColor = System.Drawing.Color.Transparent
        Me.PMenu.Controls.Add(Me.WrapMainMenu)
        Me.PMenu.Location = New System.Drawing.Point(0, 141)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(1370, 400)
        Me.PMenu.TabIndex = 1
        '
        'WrapMainMenu
        '
        Me.WrapMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.WrapMainMenu.BackgroundImage = CType(resources.GetObject("WrapMainMenu.BackgroundImage"), System.Drawing.Image)
        Me.WrapMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.WrapMainMenu.Controls.Add(Me.lbCategory)
        Me.WrapMainMenu.Controls.Add(Me.Label3)
        Me.WrapMainMenu.Controls.Add(Me.lbTopHit)
        Me.WrapMainMenu.Controls.Add(Me.lbSingers)
        Me.WrapMainMenu.Controls.Add(Me.lbProduction)
        Me.WrapMainMenu.Location = New System.Drawing.Point(295, 20)
        Me.WrapMainMenu.Name = "WrapMainMenu"
        Me.WrapMainMenu.Size = New System.Drawing.Size(850, 380)
        Me.WrapMainMenu.TabIndex = 5
        '
        'lbCategory
        '
        Me.lbCategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCategory.BackColor = System.Drawing.Color.Transparent
        Me.lbCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbCategory.Location = New System.Drawing.Point(206, 37)
        Me.lbCategory.Name = "lbCategory"
        Me.lbCategory.Size = New System.Drawing.Size(139, 308)
        Me.lbCategory.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Location = New System.Drawing.Point(647, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 291)
        Me.Label3.TabIndex = 6
        '
        'lbTopHit
        '
        Me.lbTopHit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTopHit.BackColor = System.Drawing.Color.Transparent
        Me.lbTopHit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbTopHit.Location = New System.Drawing.Point(504, 39)
        Me.lbTopHit.Name = "lbTopHit"
        Me.lbTopHit.Size = New System.Drawing.Size(139, 308)
        Me.lbTopHit.TabIndex = 5
        '
        'lbSingers
        '
        Me.lbSingers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSingers.BackColor = System.Drawing.Color.Transparent
        Me.lbSingers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbSingers.Location = New System.Drawing.Point(348, 30)
        Me.lbSingers.Name = "lbSingers"
        Me.lbSingers.Size = New System.Drawing.Size(154, 328)
        Me.lbSingers.TabIndex = 4
        '
        'lbProduction
        '
        Me.lbProduction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbProduction.BackColor = System.Drawing.Color.Transparent
        Me.lbProduction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbProduction.Location = New System.Drawing.Point(63, 46)
        Me.lbProduction.Name = "lbProduction"
        Me.lbProduction.Size = New System.Drawing.Size(140, 289)
        Me.lbProduction.TabIndex = 3
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 768)
        Me.Controls.Add(Me.PMenu)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmMain"
        Me.Text = "FrmMain"
        Me.Controls.SetChildIndex(Me.PMenu, 0)
        Me.PMenu.ResumeLayout(False)
        Me.WrapMainMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PMenu As System.Windows.Forms.Panel
    Friend WithEvents WrapMainMenu As System.Windows.Forms.Panel
    Friend WithEvents lbCategory As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbTopHit As System.Windows.Forms.Label
    Friend WithEvents lbSingers As System.Windows.Forms.Label
    Friend WithEvents lbProduction As System.Windows.Forms.Label
End Class
