Imports System.Windows.Forms
Imports WeifenLuo.WinFormsUI.Docking
Partial Public Class frmAttributes
    Inherits DockContent
    Dim _ProjectManager As New ProjectManager
    Dim _value As New Dictionary(Of Integer, String)
    Dim _img As Image
    Dim _id As Integer
    Dim _selected As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmAttributes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _value = _ProjectManager.ToAttributesGroup("AttributesGroup", cboAttributes, "group", "id")
        cboAttributes.Text = cboAttributes.Items(0)

    End Sub

    Private Sub cboAttributes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAttributes.SelectedIndexChanged
        _id = _value.ElementAt(cboAttributes.SelectedIndex).Key
        _ProjectManager.ToAttributes(_id, gridInfo, ImageList1)
    End Sub

    Private Sub gridInfo_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gridInfo.CellEnter
        ' Dim completed As String = gridWords.Item(1, e.RowIndex).Tag
        ' MsgBox()

        _selected = gridInfo.Item(1, e.RowIndex).Value
    End Sub

    Private Sub gridInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridInfo.CellContentClick

        'MsgBox(mUniform.txtCodeActive)
        ' If frmMDI.frmInput.CurrentTextboxLeave = True Then
        Clipboard.SetText(" " & _selected)
        frmMDI.frmInput.txtCode.Paste()
        'Else
        'If frmMDI.frmInput.CurrentTextbox.Text.Length > 0 Then
        'Clipboard.SetText(" " & _selected)
        'Else
        'Clipboard.SetText(_selected)
        'End If
        'frmMDI.frmInput.CurrentTextbox.Paste()
        'End If

    End Sub
End Class
