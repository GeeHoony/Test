<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.colordlg = New System.Windows.Forms.ColorDialog()
        Me.fontdlg = New System.Windows.Forms.FontDialog()
        Me.sfdFile = New System.Windows.Forms.SaveFileDialog()
        Me.msBar = New System.Windows.Forms.MenuStrip()
        Me.rtbText = New System.Windows.Forms.RichTextBox()
        Me.글자모양ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.글자모양ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.글자색상ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'sfdFile
        '
        Me.sfdFile.FileName = "text.txt"
        Me.sfdFile.Filter = "서식파일(*.rtf)|*.rtf|텍스트 파일(*.txt)|*.txt|모든파일(*.*)|*.*"
        '
        'msBar
        '
        Me.msBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.글자모양ToolStripMenuItem})
        Me.msBar.Location = New System.Drawing.Point(0, 0)
        Me.msBar.Name = "msBar"
        Me.msBar.Size = New System.Drawing.Size(350, 24)
        Me.msBar.TabIndex = 0
        Me.msBar.Text = "MenuStrip1"
        Me.msBar.Visible = False
        '
        'rtbText
        '
        Me.rtbText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbText.Location = New System.Drawing.Point(0, 0)
        Me.rtbText.Name = "rtbText"
        Me.rtbText.Size = New System.Drawing.Size(350, 342)
        Me.rtbText.TabIndex = 1
        Me.rtbText.Text = ""
        '
        '글자모양ToolStripMenuItem
        '
        Me.글자모양ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.글자모양ToolStripMenuItem1, Me.글자색상ToolStripMenuItem})
        Me.글자모양ToolStripMenuItem.Name = "글자모양ToolStripMenuItem"
        Me.글자모양ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.글자모양ToolStripMenuItem.Text = "모양"
        '
        '글자모양ToolStripMenuItem1
        '
        Me.글자모양ToolStripMenuItem1.Name = "글자모양ToolStripMenuItem1"
        Me.글자모양ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.글자모양ToolStripMenuItem1.Text = "글자모양"
        '
        '글자색상ToolStripMenuItem
        '
        Me.글자색상ToolStripMenuItem.Name = "글자색상ToolStripMenuItem"
        Me.글자색상ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.글자색상ToolStripMenuItem.Text = "글자색상"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 342)
        Me.Controls.Add(Me.rtbText)
        Me.Controls.Add(Me.msBar)
        Me.MainMenuStrip = Me.msBar
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Text Editor"
        Me.msBar.ResumeLayout(False)
        Me.msBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents colordlg As ColorDialog
    Friend WithEvents fontdlg As FontDialog
    Friend WithEvents sfdFile As SaveFileDialog
    Friend WithEvents msBar As MenuStrip
    Friend WithEvents rtbText As RichTextBox
    Friend WithEvents 글자모양ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 글자모양ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 글자색상ToolStripMenuItem As ToolStripMenuItem
End Class
