Public Class Form1
    Private Sub sourceFolder_TextChanged(sender As Object, e As EventArgs) Handles sourceFolder.TextChanged

    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(sourceFolder.Text)
            Try
                Dim bmp As New Bitmap(foundFile.ToString)

                Dim destFile As String = ""

                ' If a side of the picture is too small, copy it to destination folder
                If Convert.ToInt32(bmp.Width.ToString()) < Convert.ToInt32(minSizeWidth.Text) Or Convert.ToInt32(bmp.Height.ToString()) < Convert.ToInt32(minSizeHeight.Text) Then
                    destFile = destinationFolder.Text + foundFile.ToString.Split("\"c).Last()
                    FileCopy(foundFile, destFile)
                End If
            Catch ex As Exception

            End Try
        Next

    End Sub

    Private Sub searchSource_Click(sender As Object, e As EventArgs) Handles searchSource.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            sourceFolder.Text = FolderBrowserDialog1.SelectedPath + "\"
        End If
    End Sub

    Private Sub searchDestination_Click(sender As Object, e As EventArgs) Handles searchDestination.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            destinationFolder.Text = FolderBrowserDialog1.SelectedPath + "\"
        End If
    End Sub
End Class
