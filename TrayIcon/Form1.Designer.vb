<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.cmsPop = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.열기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsPop.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsPop
        '
        Me.cmsPop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmsPop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.열기ToolStripMenuItem, Me.종료ToolStripMenuItem})
        Me.cmsPop.Name = "cmsPop"
        Me.cmsPop.Size = New System.Drawing.Size(99, 48)
        '
        '열기ToolStripMenuItem
        '
        Me.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem"
        Me.열기ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.열기ToolStripMenuItem.Text = "열기"
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        Me.종료ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.종료ToolStripMenuItem.Text = "종료"
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.cmsPop
        Me.TrayIcon.Text = "NotifyIcon1"
        Me.TrayIcon.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 385)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "트레이 아이콘"
        Me.cmsPop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmsPop As ContextMenuStrip
    Friend WithEvents 열기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrayIcon As NotifyIcon
End Class
