Public Class frmUpdateLanguage

    Private Photo As Byte()
    Private Sub btnAddLanguage_Click(sender As Object, e As EventArgs) Handles btnAddLanguage.Click
        frmAddLanguage.Show()
        Me.Close()
    End Sub

    Private Sub btnLanguageList_Click(sender As Object, e As EventArgs) Handles btnLanguageList.Click
        frmLanguage.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If addNew = True Then
            frmAddSong.Show()
            addNew = False
        End If
        Me.Close()
    End Sub

    Private Sub frmUpdateLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        txtLanguage.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtLanguage.Text = "" Then
            MessageBox.Show("You must fill all the information!!!")
            Exit Sub
        End If
        Try
            Dim language As New DataLayer.ClsLanguage
            Dim languageTransaction As New DataLayer.ClsLanguageTransaction
            language.ID = CInt(txtID.Text)
            language.Language = txtLanguage.Text
            If languageTransaction.updateLanguage(language) = True Then
                Message.Visible = True
            Else
                Message.Visible = True
                Message.ForeColor = Color.Red
                Message.Text = "Your updating is not successful!!"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class