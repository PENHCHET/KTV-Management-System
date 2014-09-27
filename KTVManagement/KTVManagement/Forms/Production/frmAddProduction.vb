﻿Public Class frmAddProduction

    Private Photo As Byte()
    Private productionTransaction As New DataLayer.ClsProductionTransaction
    Private Sub btnProductionList_Click(sender As Object, e As EventArgs) Handles btnProductionList.Click
        frmProduction.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        If addNew = True Then
            addNew = False
            frmAddSong.Show()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProduction.Text = "" Then
            MessageBox.Show("You must fill all the information!!!")
            Exit Sub
        End If
        Try
            Dim production As New DataLayer.ClsProduction
            production.Production = txtProduction.Text
            production.Photo = Photo
            If productionTransaction.addNewProduction(production) = True Then
                Message.Visible = True
                If addNew = True Then
                    Dim dsProduction As New DataSet
                    dsProduction = productionTransaction.getAllProductions()
                    AddDataIntoComboBox(frmAddSong.cboProduction, dsProduction)
                End If
            Else
                Message.Visible = True
                Message.Text = "Inserting is failure!!!"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbPhoto_Click(sender As Object, e As EventArgs) Handles pbPhoto.Click
        Try
            If OpenPhoto.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
                pbPhoto.Image = Image.FromFile(OpenPhoto.FileName)
                Photo = getMemoryStream(pbPhoto)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmAddProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2
    End Sub
End Class