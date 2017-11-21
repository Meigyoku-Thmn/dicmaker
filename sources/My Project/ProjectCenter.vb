Imports ComponentFactory.Krypton.Toolkit
Public Class ProjectCenter
    Dim loadData As New ProjectManager
    Dim _id As Integer
    Dim _tittle1 As String
    Dim _table As String
    Private WithEvents _frmNewProject As frmNewProject
    Private _frmNewProjecta As frmNewProject
    Public Event Opening(ByVal isOpening As Boolean)

    Private Sub ProjectCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData.LoadInfoProject(gridInfo, ImageList1)
    End Sub

    Public Sub LoadInfo()
        loadData.LoadInfoProject(gridInfo, ImageList1)
    End Sub
    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Dim _msgbox As MessageBoxButtons = MessageBoxButtons.YesNo
        If KryptonMessageBox.Show(Me, "Are you sure you want to delete " & _tittle1, "Delete", _msgbox) = DialogResult.Yes Then
            loadData.DeleteProject(_id)
            loadData.DeleteTable(_table)
            gridInfo.Rows.Clear()
            loadData.LoadInfoProject(gridInfo, ImageList1)
        End If
    End Sub

    Private Sub gridInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridInfo.CellContentClick

    End Sub

    Private Sub gridInfo_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gridInfo.CellEnter
        Try
            _id = e.RowIndex
            If loadData.listProject.Count - 1 >= 0 Then
                Dim str1 As String = loadData.listProject(_id)
                Dim arr() As String = str1.Split("|")
                _id = arr(0)
                _tittle1 = arr(1)
                _table = arr(2)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btNew_Click(sender As Object, e As EventArgs) Handles btNew.Click
        _frmNewProject = New frmNewProject
        _frmNewProject.Show()
    End Sub

    Private Sub btOpen_Click(sender As Object, e As EventArgs) Handles btOpen.Click
        loadData.ChangeCurrentProject(_table)

        mUniform.ProjectTable = _table
        frmMDI.Text = "Tummo Dictionary Maker - [" & mUniform.ProjectName & "]"
        frmMDI.frmWordList.ImportWordList("", 0)
        RaiseEvent Opening(True)
        Me.Close()
    End Sub

    Private Sub _frmNewProject_Finished(isFinish As Boolean) Handles _frmNewProject.Finished
        If isFinish = True Then
            RaiseEvent Opening(True)
            Me.Close()
        End If

    End Sub
End Class