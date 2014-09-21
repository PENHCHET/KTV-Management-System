Public Class frmAddLanguage

    Private Photo As Byte()

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If addNew = True Then
            frmAddSong.Show()
            addNew = False
        End If
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmAddLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub

    Private Sub btnLanguage_Click(sender As Object, e As EventArgs) Handles btnLanguage.Click
        frmLanguage.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim language As New DataLayer.ClsLanguage
        Dim languageTransaction As New DataLayer.ClsLanguageTransaction
        Try
            language.Language = txtLanguage.Text
            If languageTransaction.addNewLanguage(language) = True Then
                MessageBox.Show("Successfully!!!")
                If addNew = True Then
                    Dim dsLanguage As New DataSet
                    dsLanguage = languageTransaction.getAllLanguages()
                    AddDataIntoComboBox(frmAddSong.cboLanguage, dsLanguage)
                End If
            Else
                MessageBox.Show("Unsuccessfully!!!")
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class