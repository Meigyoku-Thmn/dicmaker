Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite

Public NotInheritable Class frmAddNewAttributes
    Public _mode As Integer
    Dim _projectManager As New ProjectManager
    Dim _indexGroup As New Dictionary(Of Integer, String)
    Dim _idGroup As String
    Private Sub frmAddNewAttributes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btAddNew.Enabled = False
        _indexGroup = _projectManager.ToAttributesGroup2("AttributesGroup", cboGroup, "group1", "id")
        cboGroup.SelectedIndex = 0
        If mUniform.AndNewAtributesMode = 1 Then
            txtGroup.Enabled = True
            txtTittle.Enabled = False
            txtCode.Enabled = False
        ElseIf mUniform.AndNewAtributesMode = 2 Then
            txtGroup.Enabled = False
        End If
    End Sub

    Private Sub txtTittle_Leave(sender As Object, e As EventArgs) Handles txtTittle.Leave
        If txtTittle.Text <> "" And txtCode.Text <> "" Then
            btAddNew.Enabled = True
        End If
    End Sub

    Private Sub txtCode_Leave(sender As Object, e As EventArgs) Handles txtCode.Leave
        If txtTittle.Text <> "" And txtCode.Text <> "" Then
            btAddNew.Enabled = True
        End If
    End Sub

    Private Sub btAddNew_Click(sender As Object, e As EventArgs) Handles btAddNew.Click

        If mUniform.AndNewAtributesMode = 1 Then ' New Group
            Dim filed(1) As String
            filed(0) = "group1"

            Dim value(1) As String
            value(0) = txtGroup.Text

            _projectManager.InsertRow("AttributesGroup", filed, value)
            _indexGroup = _projectManager.ToAttributesGroup2("AttributesGroup", cboGroup, "group1", "id")
            cboGroup.SelectedIndex = 0
            frmIndex.ShowCombo()
        ElseIf mUniform.AndNewAtributesMode = 2 Then
            Dim filed(3) As String
            filed(0) = "idgroup"
            filed(1) = "tittle"
            filed(2) = "code"

            Dim value(3) As String
            value(0) = _idGroup
            value(1) = txtTittle.Text
            value(2) = txtCode.Text
            _projectManager.InsertRow("Attributes", filed, value)
            frmIndex.ShowGrid()
            txtTittle.Text = ""
            txtCode.Text = ""
            txtTittle.Focus()

        End If
    End Sub

    Private Function GetIndexOfVale(_value As String) As Integer
        Dim _index2 As Integer = 0
        For Each w1 In _indexGroup

            If _value = w1.Value Then
                _index2 = w1.Key
            End If
        Next
        Return _index2
    End Function

    Private Sub cboGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGroup.SelectedIndexChanged
        If cboGroup.Items.Count - 1 >= 0 Then
            _idGroup = GetIndexOfVale(cboGroup.Text)

        End If
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        If txtTittle.Text <> "" And txtCode.Text <> "" Then
            btAddNew.Enabled = True
        End If
    End Sub

    Private Sub txtGroup_TextChanged(sender As Object, e As EventArgs) Handles txtGroup.TextChanged
        If txtGroup.Text <> "" Then
            btAddNew.Enabled = True
        End If
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub
End Class
