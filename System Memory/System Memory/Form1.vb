Imports System.Threading
Imports System.Diagnostics

Public Class Form1

    Dim oCPU As PerformanceCounter = New PerformanceCounter("Processor", "% Processor Time", "_Total") '시스템 성능 카운터
    Dim bExit As Boolean = False '실시간 체크를 위한 While 조건
    Dim iCPU As Integer = 0 'cpu 초기 사용률
    Dim F As Font = New Font("굴림", 9) '폰트 모양
    Dim checkThread As Thread '스레드 개체 생성

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkThread = New Thread(AddressOf getCPU_Info)
        checkThread.Start() 'checkThread 스레드 프로세스 시작
    End Sub

    Private Sub getCPU_Info()
        While Not bExit
            iCPU = oCPU.NextValue()
            Me.Text = "CPU 사용: " + iCPU.ToString() + "%"
            iCPU = iCPU * 3
            plBar.Invalidate()
            Thread.Sleep(1000)
        End While
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim G As Graphics = e.Graphics

        If (iCPU <= 60) Then
            G.FillRectangle(Brushes.BlanchedAlmond, 0, 0, iCPU, plBar.Height)
        ElseIf (iCPU <= 120) Then
            G.FillRectangle(Brushes.Wheat, 0, 0, iCPU, plBar.Height)
        ElseIf (iCPU <= 180) Then
            G.FillRectangle(Brushes.NavajoWhite, 0, 0, iCPU, plBar.Height)
        ElseIf (iCPU <= 240) Then
            G.FillRectangle(Brushes.Orange, 0, 0, iCPU, plBar.Height)
        Else
            G.FillRectangle(Brushes.DarkOrange, 0, 0, iCPU, plBar.Height)
        End If

        iCPU = iCPU / 3

        G.DrawString(iCPU.ToString() + " %", F, Brushes.DarkRed, plBar.Width / 2 - 17, plBar.Height / 4)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        checkThread.Abort()
    End Sub
End Class
