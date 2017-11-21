Imports System.IO
Public Class frmCSS
    Dim path1 As New TummoPath
    Dim _projectManager As New ProjectManager
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim strHTML(5) As String
        strHTML(0) = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>"
        strHTML(1) = "<html xmlns='http://www.w3.org/1999/xhtml'>"
        strHTML(2) = "<head><title>Tummo Dictionary</title><meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>"
        strHTML(4) = "</head><body>"

        Using oWrite As StreamWriter = New StreamWriter(path1.PathOfStyle & "\test1.html")
            oWrite.WriteLine(strHTML(0))
            oWrite.WriteLine(strHTML(1))
            oWrite.WriteLine(strHTML(2))
            oWrite.WriteLine(txtCSS.Text)
            oWrite.WriteLine(strHTML(4))
            oWrite.WriteLine(txtHTML.Text)
            oWrite.WriteLine("</body></html>")
        End Using

        webView.Url = New System.Uri(path1.PathOfStyle & "\test1.html", System.UriKind.Absolute)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        txtHTML.Text = _projectManager.ExtractTable("")
    End Sub
End Class