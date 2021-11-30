Imports System.IO

Public Class Form2

    Dim txtNoteChange As Boolean = False '내용 변경 체크

    Private Sub rtbText_TextChanged(sender As Object, e As EventArgs) Handles rtbText.TextChanged
        Me.txtNoteChange = True
    End Sub

    Private Sub 글자모양ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 글자모양ToolStripMenuItem1.Click
        If (Me.fontdlg.ShowDialog() = DialogResult.OK) Then
            Me.rtbText.Font = Me.fontdlg.Font
        End If
    End Sub

    Private Sub 글자색상ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 글자색상ToolStripMenuItem.Click
        If (Me.colordlg.ShowDialog = DialogResult.OK) Then
            Me.rtbText.ForeColor = Me.colordlg.Color
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        If (Me.txtNoteChange = True) Then
            Dim msg = Me.Text + " 파일의 내용이 변경되었습니다." & " 변경된 내용을 저장하시겠습니까?"
            Dim dlr = MessageBox.Show(msg, "알림", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            Select Case (dlr)
                Case DialogResult.Yes
                    Dim dr = Me.sfdFile.ShowDialog()
                    If (dr <> DialogResult.Cancel) Then
                        Dim str = Me.sfdFile.FileName
                        Dim sw = New StreamWriter(str, False, System.Text.Encoding.Default)
                        sw.Write(Me.rtbText.Text)
                        sw.Flush()
                        sw.Close()
                        Me.txtNoteChange = False
                    End If
                    Me.Dispose()
                Case DialogResult.No
                    Me.Dispose()
                Case DialogResult.Cancel
                    Exit Sub
            End Select
        Else
            Me.Dispose()
        End If
    End Sub
End Class