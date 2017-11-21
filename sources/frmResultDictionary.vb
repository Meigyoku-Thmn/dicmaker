Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Diagnostics
Partial Public Class frmResultDictionary
    Dim TummoPath As New TummoPath

    <StructLayout(LayoutKind.Sequential)>
    Public Structure RECT
        Public Left As UInteger
        Public Top As UInteger
        Public Right As UInteger
        Public Bottom As UInteger
    End Structure

    ' Required by user32.dll
    <StructLayout(LayoutKind.Sequential)>
    Public Structure GUITHREADINFO
        Public cbSize As UInteger
        Public flags As UInteger
        Public hwndActive As IntPtr
        Public hwndFocus As IntPtr
        Public hwndCapture As IntPtr
        Public hwndMenuOwner As IntPtr
        Public hwndMoveSize As IntPtr
        Public hwndCaret As IntPtr
        Public rcCaret As RECT
    End Structure

    Private startPosition As New Point()
    ' Point required for ToolTip movement by Mouse
    Private guiInfo As GUITHREADINFO
    ' To store GUI Thread Information
    Private caretPosition As Point
    ' To store Caret Position  


    '- Retrieves Title Information of the specified window -

    <DllImport("user32.dll")>
    Private Shared Function GetWindowText(hWnd As Integer, text As StringBuilder, count As Integer) As Integer
    End Function

    '- Retrieves Id of the thread that created the specified window -

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowThreadProcessId(hWnd As Integer, ByRef lpdwProcessId As UInteger) As UInteger
    End Function

    '- Retrieves information about active window or any specific GUI thread -

    <DllImport("user32.dll", EntryPoint:="GetGUIThreadInfo")>
    Public Shared Function GetGUIThreadInfo(tId As UInteger, ByRef threadInfo As GUITHREADINFO) As Boolean
    End Function

    '- Retrieves Handle to the ForeGroundWindow -

    <DllImport("user32.dll")>
    Public Shared Function GetForegroundWindow() As IntPtr
    End Function

    '- Converts window specific point to screen specific -

    <DllImport("user32.dll")>
    Public Shared Function ClientToScreen(hWnd As IntPtr, ByRef position As Point) As Boolean
    End Function

    Public Sub New(top As Integer, left As Integer, width As Integer)
        InitializeComponent()
        ' Processing events from Hooks involves message queue complexities.
        'Timer1.Start()
        AdjustUI(top, left, width)



        ' Me.Top = top
        ' Me.Left = left


    End Sub
    Private Sub frmResultDictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WebBrowser1.Url = New System.Uri(TummoPath.PathOfStyle & "\keywords.html", System.UriKind.Absolute)
        'KryptonPanel1.BackColor = Color.Blue
        'lblWord.Text = "Ghānaviññāṇadhatu"
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs)
        ' If Tooltip window is active window (Suppose user clicks on the Tooltip Window)
        If GetForegroundWindow() = Me.Handle Then
            ' then do no processing
            Return
        End If

        ' Get Current active Process
        Dim activeProcess As String = GetActiveProcess()

        ' If window explorer is active window (eg. user has opened any drive)
        ' Or for any failure when activeProcess is nothing               
        If (activeProcess.ToLower().Contains("explorer") Or (activeProcess = String.Empty)) Then
            ' Dissappear Tooltip
            Me.Visible = False
        Else
            ' Otherwise Calculate Caret position
            EvaluateCaretPosition()

            ' Adjust ToolTip according to the Caret
            'AdjustUI()

            ' Display current active Process on Tooltip
            ' lblCurrentApp.Text = " You are Currently inside : " & activeProcess
            Me.Visible = True
        End If
    End Sub

    Private Sub imgClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub lblWord_MouseEnter(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.SizeAll
    End Sub

    Private Sub lblWord_MouseDown(sender As Object, e As MouseEventArgs)
        startPosition = e.Location
    End Sub

    Private Sub lblWord_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ' then move the Tooltip
            Me.Left += e.Location.X - startPosition.X
            Me.Top += e.Location.Y - startPosition.Y
        End If
    End Sub

    Private Sub AdjustUI(top As Integer, left As Integer, width As Integer)
        ' Get Current Screen Resolution
        Dim workingArea As Rectangle = SystemInformation.WorkingArea
        Dim x, y As Integer
        ' If current caret position throws Tooltip outside of screen area
        ' then do some UI adjustment.
        If left + width + Me.Width > workingArea.Width Then
            x = left - Me.Width
        Else
            x = left + width + 2
        End If

        If top + width > workingArea.Height Then
            top = top - width - 50
        End If

        Me.Left = x
        Me.Top = top
    End Sub

    Private Sub EvaluateCaretPosition()
        caretPosition = New Point()

        ' Fetch GUITHREADINFO
        GetCaretPosition()

        caretPosition.X = CInt(guiInfo.rcCaret.Left) + 25
        caretPosition.Y = CInt(guiInfo.rcCaret.Bottom) + 25

        ClientToScreen(guiInfo.hwndCaret, caretPosition)

        ' txtCaretX.Text = (caretPosition.X).ToString()
        ' txtCaretY.Text = caretPosition.Y.ToString()

    End Sub

    ''' <summary>
    ''' Get the caret position
    ''' </summary>
    Public Sub GetCaretPosition()
        guiInfo = New GUITHREADINFO()
        guiInfo.cbSize = CUInt(Marshal.SizeOf(guiInfo))

        ' Get GuiThreadInfo into guiInfo
        GetGUIThreadInfo(0, guiInfo)
    End Sub

    ''' <summary>
    ''' Retrieves name of active Process.
    ''' </summary>
    ''' <returns>Active Process Name</returns>
    Private Function GetActiveProcess() As String
        Const nChars As Integer = 256
        Dim handle As Integer = 0
        Dim Buff As New StringBuilder(nChars)
        handle = CInt(GetForegroundWindow())

        ' If Active window has some title info
        If GetWindowText(handle, Buff, nChars) > 0 Then
            Dim lpdwProcessId As UInteger
            Dim dwCaretID As UInteger = GetWindowThreadProcessId(handle, lpdwProcessId)
            Dim dwCurrentID As UInteger = CUInt(Thread.CurrentThread.ManagedThreadId)
            Return Process.GetProcessById(CInt(lpdwProcessId)).ProcessName
        End If
        ' Otherwise either error or non client region
        Return [String].Empty
    End Function

    Private Sub frmResultDictionary_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub
End Class
