Public Class Form1
    Dim isBusy As Boolean

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        If (isBusy) Then
            webClient.CancelAsync()
            isBusy = False
        Else
            Try
                Dim form1 As Form1 = Me
                Dim strFileName = form1.txtUrl.Text.Split((New Char() {"/"}))
                System.Array.Reverse(strFileName)
                Dim Uri As Uri = New Uri(Me.txtUrl.Text)
                Dim str = webClient.DownloadString(Uri)
                '파일의 유효성 검사를 위한 코드
                webClient.DownloadFileAsync(Uri, strFileName(0))
                isBusy = True
            Catch
                MessageBox.Show("다운로드가 실패 하였습니다.", "에러",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub webClient_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles webClient.DownloadFileCompleted
        isBusy = False
        If (e.Error Is Nothing) Then
            MessageBox.Show("다운로드가 완료 되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("다운로드가 실패 하였습니다. : ", e.Error.Message.ToString())
        End If
    End Sub

    Private Sub webClient_DownloadProgressChanged(sender As Object, e As Net.DownloadProgressChangedEventArgs) Handles webClient.DownloadProgressChanged
        Me.pgbDown.Value = e.ProgressPercentage
    End Sub
End Class
