Imports System.IO
Imports WeifenLuo.WinFormsUI.Docking
Partial Public Class frmImageViewer
    Inherits DockContent
    Private Sub mnCliboard_Click(sender As Object, e As EventArgs) Handles mnCliboard.Click
        If My.Computer.Clipboard.ContainsImage Then
            PictureBox1.Image = My.Computer.Clipboard.GetImage
        End If
    End Sub

    Private Sub mnOpen_Click(sender As Object, e As EventArgs) Handles mnOpen.Click
        OpenFileDialog1.Filter = "Image Documents *.png|*.jpg|*.jpeg|*.gif"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fullpath As String = OpenFileDialog1.FileName

            PictureBox1.Image = Image.FromFile(fullpath)
        End If
    End Sub
End Class