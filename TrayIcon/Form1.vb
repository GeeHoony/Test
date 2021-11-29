Public Class Form1
    Private Sub VisibleChange(ByVal FormVisible As Boolean, ByVal TrayIconVisible As Boolean)
        Me.Visible = FormVisible
        Me.TrayIcon.Visible = TrayIconVisible
    End Sub

    Private Sub 열기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 열기ToolStripMenuItem.Click
        VisibleChange(True, False)
    End Sub

    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        VisibleChange(False, True)
    End Sub

    Private Sub TrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TrayIcon.MouseDoubleClick
        VisibleChange(True, False)
    End Sub
End Class
