Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports Microsoft.Win32

Public Class Form1

    Private Server As TcpListener 'TCP 네트워크 클라이언트에서 연결 수신
    Private SerClient, client As TcpClient 'TCP 네트워크 서비스에 대한 클라이언트 연결 제공
    Private myStream As NetworkStream '네트워크 스트림
    Private myRead As StreamReader '스트림 읽기
    Private myWrite As StreamWriter '스트림 쓰기
    Private Start As Boolean = False '서버 시작
    Private ClientCon As Boolean = False '클라이언트 시작
    Private myPort As Integer '포트
    Private myName As String '별칭
    Private myReader, myServer As Thread '스레드

    Private key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\.NETFramework", True) '레지스트리 쓰기 읽기

    Private Delegate Sub AddTextDelegate(ByVal strText As String)

    Private AddText As AddTextDelegate = Nothing

    Private Sub 닫기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 닫기ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (Me.cbServer.Checked = True) Then
            ControlCheck()
        Else
            If (Me.txtIp.Text = "") Then
                Me.txtIp.Focus()
            Else
                ControlCheck()
            End If
        End If
    End Sub

    Private Sub ControlCheck()
        If (Me.txtId.Text = "") Then
            Me.txtId.Focus()
        ElseIf (Me.txtPort.Text = "") Then
            Me.txtPort.Focus()
        Else
            Try
                Dim Name = Me.txtId.Text
                Dim port = Me.txtPort.Text
                key.SetValue("Message_name", Name)
                key.SetValue("Message_port", port)
                Me.plOption.Visible = False
                Me.설정ToolStripMenuItem.Enabled = True
                Me.tsbtnConn.Enabled = True
            Catch
                MessageBox.Show("설정이 저장되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.설정ToolStripMenuItem.Enabled = True
        Me.plOption.Visible = False
        Me.txtMessage.Focus()
    End Sub

    Private Sub cbServer_CheckedChanged(sender As Object, e As EventArgs) Handles cbServer.CheckedChanged
        If (Me.cbServer.Checked) Then
            Me.txtIp.Enabled = False
        Else
            Me.txtIp.Enabled = True
        End If
    End Sub

    Private Sub tsbtnConn_Click(sender As Object, e As EventArgs) Handles tsbtnConn.Click
        AddText = New AddTextDelegate(AddressOf MessageView)
        If (Me.cbServer.Checked = True) Then
            Dim addr = New IPAddress(0)
            Try
                Me.myName = key.GetValue("Message_name")
                Me.myPort = Convert.ToInt32(key.GetValue("Message_port"))
            Catch
                Me.myName = Me.txtId.Text
                Me.myPort = Convert.ToInt32(Me.txtPort.Text)
            End Try

            If Not (Me.Start) Then
                Try
                    Server = New TcpListener(addr, Me.myPort)
                    Server.Start()

                    Me.Start = True
                    Me.txtMessage.Enabled = True
                    Me.btnSend.Enabled = True
                    Me.txtMessage.Focus()
                    Me.tsbtnDisconn.Enabled = True
                    Me.tsbtnConn.Enabled = False
                    Me.cbServer.Enabled = False

                    myServer = New Thread(AddressOf ServerStart)
                    myServer.Start()

                    Me.설정ToolStripMenuItem.Enabled = False

                Catch
                    Invoke(AddText, "서버를 실행할 수 없습니다.")
                End Try
            Else
                ServerStop()
            End If
        Else
            If Not (Me.ClientCon) Then
                Me.myName = key.GetValue("Message_name") '별칭 설정
                Me.myPort = Convert.ToInt32(key.GetValue("Message_port")) '서버측 포트 설정
                ClientConnection()
            Else
                Me.txtMessage.Enabled = False
                Me.btnSend.Enabled = False
                Disconnection()
            End If
        End If
    End Sub

    Private Sub MessageView(ByVal strText As String)
        Me.rtbText.AppendText(strText + Chr(13) + Chr(10))
        Me.rtbText.Focus()
        Me.rtbText.ScrollToCaret()
        Me.txtMessage.Focus()
    End Sub

    Private Sub ServerStart()
        Invoke(AddText, "서버 실행 : 챗 상대의 접속을 기다립니다...")
        While (Start)
            Try
                SerClient = Server.AcceptTcpClient()
                Invoke(AddText, "챗 상대 접속..")
                myStream = SerClient.GetStream()

                myRead = New StreamReader(myStream)
                myWrite = New StreamWriter(myStream)
                Me.ClientCon = True

                myReader = New Thread(AddressOf Receive)
                myReader.Start()

            Catch
            End Try
        End While
    End Sub

    Private Sub ClientConnection()
        Try
            client = New TcpClient(Me.txtIp.Text, Me.myPort)
            Invoke(AddText, "서버에 접속 했습니다.")
            myStream = client.GetStream()

            myRead = New StreamReader(myStream)
            myWrite = New StreamWriter(myStream)
            Me.ClientCon = True
            Me.tsbtnConn.Enabled = False
            Me.tsbtnDisconn.Enabled = True
            Me.txtMessage.Enabled = True
            Me.btnSend.Enabled = True
            Me.txtMessage.Focus()

            myReader = New Thread(AddressOf Receive)
            myReader.Start()

        Catch
            Me.ClientCon = False
            Invoke(AddText, "서버에 접속하지 못 했습니다.")
        End Try
    End Sub

    Private Sub Receive()
        Try
            While (Me.ClientCon)
                If (myStream.CanRead) Then
                    Dim msg = myRead.ReadLine()
                    Dim Smsg = msg.Split("&")
                    If (msg.Length > 0) Then
                        Invoke(AddText, Smsg(0) + " : " + Smsg(1))
                    End If
                    Me.tsslblTime.Text = "마지막으로 받은 시각: " + Smsg(2)
                End If
            End While
        Catch
        End Try
    End Sub

    Private Sub txtMessage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMessage.KeyPress
        If (e.KeyChar = Chr(13)) Then '엔터키 누를 때
            e.Handled = True '소리 없앰
            If (Me.txtMessage.Text = "") Then
                Me.txtMessage.Focus()
            Else
                Msg_send()
            End If
        End If
    End Sub

    Private Sub Msg_send()
        Try
            Dim dt = Convert.ToString(DateTime.Now)
            myWrite.WriteLine(Me.myName + "&" + dt)
            myWrite.Flush()
            MessageView(Me.myName + ": " + Me.txtMessage.Text)
            Me.txtMessage.Clear()

        Catch
            Invoke(AddText, "데이터를 보내는 동안 오류가 발생하였습니다.")
            Me.txtMessage.Clear()
        End Try
    End Sub

    Private Sub tsbtnDisconn_Click(sender As Object, e As EventArgs) Handles tsbtnDisconn.Click
        Try
            If (Me.cbServer.Checked) Then
                If (Me.SerClient.Connected) Then
                    Dim dt = Convert.ToString(DateTime.Now)
                    myWrite.WriteLine(Me.myName + "&" + "채팅 APP이 종료 되었습니다." + "&" + dt)
                    myWrite.Flush()
                End If
            Else
                If (Me.client.Connected) Then
                    Dim dt = Convert.ToString(DateTime.Now)
                    myWrite.WriteLine(Me.myName + "&" + "채팅 APP이 종료 되었습니다." + "&" + dt)
                    myWrite.Flush()

                End If
            End If
        Catch
        End Try
        ServerStop()
        Me.설정ToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ServerStop()
        Catch
            DisConnection()
        End Try
    End Sub

    Private Sub ServerStop()
        Me.Start = False
        Me.txtMessage.Enabled = False
        Me.txtMessage.Clear()
        Me.btnSend.Enabled = False
        Me.tsbtnConn.Enabled = True
        Me.tsbtnDisconn.Enabled = False
        Me.cbServer.Enabled = True
        Me.ClientCon = False

        If Not (myRead Is Nothing) Then myRead.Close()
        If Not (myWrite Is Nothing) Then myWrite.Close()
        If Not (myStream Is Nothing) Then myStream.Close()
        If Not (SerClient Is Nothing) Then SerClient.Close()
        If Not (Server Is Nothing) Then Server.Stop()
        If Not (myReader Is Nothing) Then myReader.Abort()
        If Not (myServer Is Nothing) Then myServer.Abort()
        If Not (AddText Is Nothing) Then
            Invoke(AddText, "연결이 끊어졌습니다.")
        End If
    End Sub


    Private Sub Disconnection()
        Me.ClientCon = False
        Try
            If Not (myRead Is Nothing) Then myRead.Close()
            If Not (myWrite Is Nothing) Then myWrite.Close()
            If Not (myStream Is Nothing) Then myStream.Close()
            If Not (client Is Nothing) Then SerClient.Close()
            If Not (myReader Is Nothing) Then myReader.Abort()
        Catch
            Return
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (key.GetValue("Message_name") = "") Then
            Me.myName = Me.txtId.Text
            Me.myPort = Convert.ToInt32(Me.txtPort.Text)
        Else
            Try
                Me.myName = key.GetValue("Message_name")
                Me.myPort = Convert.ToInt32(key.GetValue("Message_port"))
            Catch
                Me.myName = Me.txtId.Text
                Me.myPort = Convert.ToInt32(Me.txtPort.Text)
            End Try
        End If
    End Sub

    Private Sub 설정ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 설정ToolStripMenuItem.Click
        Me.설정ToolStripMenuItem.Enabled = False
        Me.plOption.Visible = True
        Me.txtId.Focus()
        Me.txtId.Text = key.GetValue("Message_name") '별칭 입력
        Me.txtPort.Text = key.GetValue("Message_port") '포트 입력
    End Sub

End Class
