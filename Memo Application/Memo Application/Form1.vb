Imports System.IO

Public Class Form1
    Private txtNoteChange As Boolean '내용 변경 체크
    Private fWord As String '찾기 문자열

    Private Sub txtNote_TextChanged(sender As Object, e As EventArgs) Handles txtNote.TextChanged
        Me.txtNoteChange = True '데이터 추가
    End Sub

    Private Sub textSave()
        If Me.Text = "제목 없음" Then
            Dim dlr As DialogResult = Me.sfdFile.ShowDialog()
            If dlr <> Windows.Forms.DialogResult.Cancel Then
                Dim str As String = Me.sfdFile.FileName
                Dim sw As StreamWriter = New StreamWriter(str, False, System.Text.Encoding.Default)
                sw.Write(Me.txtNote.Text)
                sw.Flush()
                sw.Close()
                Dim f As FileInfo = New FileInfo(str)
                Me.Text = f.Name
                Me.txtNoteChange = False
            End If
        Else
            Dim strt As String = Me.Text
            Dim sw As StreamWriter = New StreamWriter(strt, False, System.Text.Encoding.Default)
            sw.Write(Me.txtNote.Text)
            sw.Flush()
            sw.Close()
            Me.Text = strt
            Me.txtNoteChange = False
        End If
    End Sub

    Private Sub 새로만들기NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 새로만들기NToolStripMenuItem.Click
        If Me.txtNoteChange = True Then
            Dim dlr As DialogResult
            Dim msg As String = Me.Text + " 파일의 내용이 변경 되었습니다." & Chr(13) & "변경된 내용을 저장하시겠습니까?"
            dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If dlr = Windows.Forms.DialogResult.Yes Then
                textSave()
                Me.txtNote.ResetText()
                Me.Text = "제목 없음"
            ElseIf dlr = Windows.Forms.DialogResult.No Then
                Me.txtNote.ResetText()
                Me.Text = "제목 없음"
                Me.txtNoteChange = False
            ElseIf dlr = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        Else
            Me.txtNote.ResetText()
            Me.Text = "제목 없음"
            Me.txtNoteChange = False
        End If
    End Sub

    Private Sub 열기OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 열기OToolStripMenuItem.Click
        If Me.txtNoteChange = True Then
            Dim dlr As DialogResult
            Dim msg As String = Me.Text + " 파일의 내용이 변경되었습니다." & Chr(13) & "변경된 내용을 저장하시겠습니까?"
            dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If dlr = Windows.Forms.DialogResult.Yes Then
                textSave()
                textOpen()
            ElseIf dlr = Windows.Forms.DialogResult.No Then
                textOpen()
            ElseIf dlr = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        Else
            textOpen()
        End If
    End Sub

    Private Sub textOpen()
        Dim dr As DialogResult = Me.ofdFile.ShowDialog()
        If dr <> Windows.Forms.DialogResult.Cancel Then
            Dim str As String = Me.ofdFile.FileName
            Dim sr As StreamReader = New StreamReader(str, System.Text.Encoding.Default)
            Me.txtNote.Text = sr.ReadToEnd()
            sr.Close()
            Dim f As FileInfo = New FileInfo(str)
            Me.Text = f.Name
            Me.txtNoteChange = False
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        If Me.txtNoteChange = True Then
            Dim dlr As DialogResult
            Dim msg As String = Me.Text + " 파일의 내용이 변경되었습니다." & Chr(13) & "변경된 내용을 저장하시겠습니까?"
            dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If dlr = Windows.Forms.DialogResult.Yes Then
                If Me.Text = "제목 없음" Then
                    Dim dr As DialogResult = Me.sfdFile.ShowDialog()
                    If dr <> Windows.Forms.DialogResult.Cancel Then
                        Dim str As String = Me.sfdFile.FileName
                        Dim sw As StreamWriter = New StreamWriter(str, False, System.Text.Encoding.Default)
                        sw.Write(Me.txtNote.Text)
                        sw.Flush()
                        sw.Close()
                        Me.txtNoteChange = False
                    End If
                Else
                    Dim str As String = Me.Text
                    Dim sw As StreamWriter = New StreamWriter(str, False, System.Text.Encoding.Default)
                    sw.Write(Me.txtNote.Text)
                    sw.Flush()
                    sw.Close()
                    Me.txtNoteChange = False
                End If
                Me.Dispose()
            ElseIf dlr = Windows.Forms.DialogResult.No Then
                Me.Dispose()
            ElseIf dlr = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub 저장SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 저장SToolStripMenuItem.Click
        textSave() '저장함수 호출
    End Sub

    Private Sub 다른이름으로저장SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 다른이름으로저장SToolStripMenuItem.Click
        Dim dlr As DialogResult = Me.sfdFile.ShowDialog()
        If dlr <> Windows.Forms.DialogResult.Cancel Then
            Dim str As String = Me.sfdFile.FileName
            Dim sw As StreamWriter = New StreamWriter(str, False, System.Text.Encoding.Default)
            sw.Write(Me.txtNote.Text)
            sw.Flush()
            sw.Close()
            Dim f As FileInfo = New FileInfo(str)
            Me.Text = f.Name
            Me.txtNoteChange = False
        End If
    End Sub

    Private Sub 찾기FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 찾기FToolStripMenuItem.Click
        If Not (Form2 Is Nothing Or Not Form2.Visible) Then
            Form2.Focus()
            Return
        End If
        If Me.txtNote.SelectionLength = 0 Then
            Form2.txtWord.Text = Me.fWord
        Else
            Form2.txtWord.Text = Me.txtNote.SelectedText
        End If
        AddHandler Form2.btnOK.Click, AddressOf Me.btnOk_Click
        Form2.Show()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim updown As Integer = -1
        Dim str As String = Me.txtNote.Text '본문 저장
        Dim findWord As String = Form2.txtWord.Text '찾을 문자열 저장

        If Form2.chb.Checked = False Then
            str = str.ToUpper() '저장된 본문을 대문자로 변환
            findWord = findWord.ToUpper()
        End If

        If Form2.rdb01.Checked = True Then
            If Me.txtNote.SelectionStart <> 0 Then
                updown = str.LastIndexOf(findWord, Me.txtNote.SelectionStart - 1)
            End If
        Else
            updown = str.IndexOf(findWord, Me.txtNote.SelectionStart + Me.txtNote.SelectionLength)
        End If
        If updown = -1 Then
            MessageBox.Show("더 이상 찾는 문자열이 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Me.txtNote.Select(updown, findWord.Length)
        fWord = Form2.txtWord.Text
        Me.txtNote.Focus()
        Me.txtNote.ScrollToCaret()
    End Sub

    Private Sub 다음찾기NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 다음찾기NToolStripMenuItem.Click
        If Not (Form2 Is Nothing Or Not Form2.Visible) Then
            Form2.txtWord.Text = Me.fWord
            Me.btnOk_Click(Me, EventArgs.Empty) '다음을 찾는다
        End If
    End Sub

    Private Sub 시간날짜DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 시간날짜DToolStripMenuItem.Click
        Dim time As String = DateTime.Now.ToShortTimeString() '현재 시간 얻기
        Dim Tdate As String = DateTime.Today.ToShortDateString() '오늘 날짜 얻기
        Me.txtNote.AppendText(time + " / " + Tdate) '커서가 위차한 곳에 시간/날짜 추가
    End Sub

    Private Sub 끝내기XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 끝내기XToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 실행취소UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 실행취소UToolStripMenuItem.Click
        Me.txtNote.Undo()
    End Sub

    Private Sub 잘라내기TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 잘라내기TToolStripMenuItem.Click
        Me.txtNote.Cut()
    End Sub

    Private Sub 복사CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 복사CToolStripMenuItem.Click
        Me.txtNote.Copy()
    End Sub

    Private Sub 붙여넣기PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 붙여넣기PToolStripMenuItem.Click
        Me.txtNote.Paste()
    End Sub

    Private Sub 삭제LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 삭제LToolStripMenuItem.Click
        Me.txtNote.SelectedText = " "
    End Sub

    Private Sub 모두선택AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 모두선택AToolStripMenuItem.Click
        Me.txtNote.SelectAll()
    End Sub

    Private Sub 자동줄바꿈WToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 자동줄바꿈WToolStripMenuItem.Click
        Me.txtNote.WordWrap = Not (Me.txtNote.WordWrap)
        Me.자동줄바꿈WToolStripMenuItem.Checked = Not (Me.새로만들기NToolStripMenuItem.Checked)
    End Sub

    Private Sub 글꼴FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 글꼴FToolStripMenuItem.Click
        If Me.fdText.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            Me.txtNote.Font = Me.fdText.Font
        End If
    End Sub

    Private Sub 메모장정보AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 메모장정보AToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

End Class
