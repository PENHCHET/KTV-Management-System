Imports System.IO

Public Class CopySong

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Destination As String = "\\197.7.7.7\d"

        Try
            If Not Directory.Exists(Destination) Then
                Directory.CreateDirectory(Destination)
            End If
            Dim file = New FileInfo(TextBox1.Text)
            'song.Path = Path.Combine(Destination, file.Name)
            file.CopyTo(Path.Combine(Destination, file.Name), True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Destination As String = "\\197.7.7.7\d\HelloWorld"

        Try
            If Not Directory.Exists(Destination) Then
                Directory.CreateDirectory(Destination)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class