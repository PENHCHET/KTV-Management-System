Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataLayer.ClsConnection.OpenConnection()
    End Sub


    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub lbSingers_Click(sender As Object, e As EventArgs) Handles lbSingers.Click
        Me.Hide()
        FrmSinger.Show()
    End Sub

    Private Sub lbCategory_Click(sender As Object, e As EventArgs) Handles lbCategory.Click
        Me.Hide()
        FrmCategory.Show()
    End Sub

   
  
    Private Sub lbProduction_Click(sender As Object, e As EventArgs) Handles lbProduction.Click
        Me.Hide()
        FrmProduction.Show()
    End Sub

  
    Private Sub lbTopHit_Click(sender As Object, e As EventArgs) Handles lbTopHit.Click
        Me.Hide()
        FrmTopHits.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        FrmWriting.Show()
    End Sub

    
End Class