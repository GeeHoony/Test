Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProcessView()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProcessView()
    End Sub

    Private Sub ProcessView()
        Me.lvView.Items.Clear()
        For Each proc In Process.GetProcesses()
            Dim Str = " "
            If (proc.Responding) Then
                Str = "실행"
            Else
                Str = "중지"
            End If
            Dim strArray = New String() {proc.ProcessName.ToString(),
                proc.Id.ToString(), Str, proc.WorkingSet64.ToString()}
            Dim lvt = New ListViewItem(strArray)
            Me.lvView.Items.Add(lvt)
        Next
    End Sub

    Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        Try
            Dim PName = Me.lvView.SelectedItems(0).SubItems(0).Text
            Dim tProcess = Process.GetProcessesByName(PName)
            If (tProcess.Length = 1) Then
                Dim dlr = MessageBox.Show(PName + " 프로세스를 끝내시겠습니까?",
                    "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If (dlr = DialogResult.Yes) Then
                    tProcess(0).Kill()
                    ProcessView()
                End If
            Else
                MessageBox.Show(Me.lvView.SelectedItems(0).SubItems(0).Text + " 프로세스는 존재하지 않습니다.",
                 "알림", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ProcessView()
            End If
        Catch
            Return
        End Try
    End Sub
End Class