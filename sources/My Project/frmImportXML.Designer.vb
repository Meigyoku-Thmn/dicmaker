<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImportXML
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btPath = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkIncomplete = New System.Windows.Forms.CheckBox()
        Me.checkDup = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btPath
        '
        Me.btPath.Location = New System.Drawing.Point(350, 15)
        Me.btPath.Margin = New System.Windows.Forms.Padding(4)
        Me.btPath.Name = "btPath"
        Me.btPath.Size = New System.Drawing.Size(86, 24)
        Me.btPath.TabIndex = 18
        Me.btPath.Text = "OPEN"
        Me.btPath.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.ForeColor = System.Drawing.Color.Brown
        Me.txtPath.Location = New System.Drawing.Point(68, 16)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(274, 22)
        Me.txtPath.TabIndex = 17
        Me.txtPath.Text = "C:\"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(8, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "File..."
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(361, 158)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 35)
        Me.btCancel.TabIndex = 22
        Me.btCancel.Text = "CANCEL"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btOK
        '
        Me.btOK.Location = New System.Drawing.Point(276, 158)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(75, 35)
        Me.btOK.TabIndex = 21
        Me.btOK.Text = "OK"
        Me.btOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkIncomplete)
        Me.GroupBox1.Controls.Add(Me.checkDup)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 100)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option"
        '
        'checkIncomplete
        '
        Me.checkIncomplete.AutoSize = True
        Me.checkIncomplete.ForeColor = System.Drawing.Color.YellowGreen
        Me.checkIncomplete.Location = New System.Drawing.Point(11, 61)
        Me.checkIncomplete.Margin = New System.Windows.Forms.Padding(4)
        Me.checkIncomplete.Name = "checkIncomplete"
        Me.checkIncomplete.Size = New System.Drawing.Size(243, 20)
        Me.checkIncomplete.TabIndex = 22
        Me.checkIncomplete.Text = "Mark imported entries as incomplete"
        Me.checkIncomplete.UseVisualStyleBackColor = True
        '
        'checkDup
        '
        Me.checkDup.AutoSize = True
        Me.checkDup.Enabled = False
        Me.checkDup.ForeColor = System.Drawing.Color.YellowGreen
        Me.checkDup.Location = New System.Drawing.Point(11, 33)
        Me.checkDup.Margin = New System.Windows.Forms.Padding(4)
        Me.checkDup.Name = "checkDup"
        Me.checkDup.Size = New System.Drawing.Size(405, 20)
        Me.checkDup.TabIndex = 22
        Me.checkDup.Text = "Always create new entries (i.e do not check if entry already exits)"
        Me.checkDup.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'frmImportXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 203)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.btPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportXML"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import wordlist or XML options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btPath As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btCancel As Button
    Friend WithEvents btOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checkIncomplete As CheckBox
    Friend WithEvents checkDup As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
