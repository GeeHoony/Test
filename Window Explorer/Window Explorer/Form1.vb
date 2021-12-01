Imports System.IO
Imports System.Management

Public Class Form1

    Dim path As String = "C:\\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView()
    End Sub

    Private Sub TreeView() 'Management Base Object, Management Object Searcher 클래스 이용하여
                           '단말기의 디스크 장치를 검색하여 treeDisk 컨트롤에 나타나게 하는 메서드
        Dim RootNode, SubNode As TreeNode
        Dim ImageIndex As Integer = 5
        Dim selectIndex As Integer = 5

        'const Unknown = 0
        'const NoRootDirectory = 1
        Const RemovableDisk = 2
        Const LocalDisk = 3
        'const NetworkDrive = 4
        Const CompactDisc = 5
        Const RAMDisk = 6


        Dim query = New ManagementObjectSearcher("SELECT * From Win32_LogicalDisk")
        Dim queryCollection = query.Get()

        Me.treeDisk.BeginUpdate()
        RootNode = New TreeNode("내 컴퓨터", ImageIndex, selectIndex)
        Me.treeDisk.Nodes.Add(RootNode)

        For Each drive In queryCollection
            Select Case Convert.ToInt32(drive("DriveType").ToString())
                Case RemovableDisk
                    ImageIndex = 0
                    selectIndex = 0
                Case LocalDisk
                    ImageIndex = 1
                    selectIndex = 1
                Case CompactDisc
                    ImageIndex = 2
                    selectIndex = 2
                Case RAMDisk
                    ImageIndex = 3
                    selectIndex = 3
                Case Else
                    ImageIndex = 0
                    selectIndex = 0
            End Select

            SubNode = New TreeNode("(" + drive("Name").ToString() + ")", ImageIndex, selectIndex)
            Me.treeDisk.Nodes(0).Nodes.Add(SubNode)
        Next
        Me.treeDisk.EndUpdate()
    End Sub

    Private Sub View(ByVal dr As String)
        Me.Text = path
        Me.lvFile.Items.Clear()
        Dim imageNum As Integer = 15
        Try
            If (Directory.Exists(dr) = False) Then
                MessageBox.Show(dr + " 드라이브는 읽을 수 없습니다.", "디스크 삽입", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim di = New DirectoryInfo(dr)

                For Each d In di.GetDirectories()
                    Dim lvItem = New ListViewItem(New String() {d.Name, "", "폴더", d.LastWriteTime.ToShortDateString()}, 16) 'ListViewItem(String(),ImageIndex) 16번 폴더아이콘
                    Me.lvFile.Items.Add(lvItem)
                Next

                For Each d In di.GetFiles()
                    Dim Str = d.Extension
                    Str = Str.ToLower()
                    Select Case Str.ToString()
                        Case ".exe"
                            imageNum = 0
                        Case ".com"
                            imageNum = 1
                        Case ".txt"
                            imageNum = 2
                        Case ".bmp"
                            imageNum = 3
                        Case ".doc"
                            imageNum = 4
                        Case ".gif"
                            imageNum = 5
                        Case ".htm"
                            imageNum = 6
                        Case ".html"
                            imageNum = 7
                        Case ".hwp"
                            imageNum = 8
                        Case ".jpg"
                            imageNum = 9
                        Case ".mp3"
                            imageNum = 10
                        Case ".mpg"
                            imageNum = 11
                        Case ".ra"
                            imageNum = 12
                        Case ".rar"
                            imageNum = 13
                        Case ".zip"
                            imageNum = 14
                        Case Else
                            imageNum = 15
                    End Select
                    Dim lvi = New ListViewItem(New String() {d.Name, d.Length.ToString(), d.Extension, d.LastWriteTime.ToShortDateString()}, imageNum)
                    Me.lvFile.Items.Add(lvi)
                Next
            End If
        Catch
            MessageBox.Show("오류 메시지 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub treeDisk_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeDisk.AfterSelect
        If Me.treeDisk.SelectedNode.Text <> "내 컴퓨터" Then
            Dim str = Me.treeDisk.SelectedNode.Text.Substring(1, 1)
            path = str + ":\" 'tree view 컨트롤에 현재 선택되어 있는 트리 노드를 가져오거나 설정합니다.
            View(path) 'view 메서드 호출
        End If
    End Sub

    Private Sub lvFile_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvFile.DoubleClick
        If (Me.lvFile.SelectedItems.Count <> 0) Then
            If (Me.lvFile.SelectedItems(0).SubItems(2).Text = "폴더") Then
                path = path + Me.lvFile.SelectedItems(0).SubItems(0).Text + "\"
                View(path)
            Else
                Dim myProcess = New Process()
                myProcess.StartInfo.FileName = path + Me.lvFile.SelectedItems(0).SubItems(0).Text
                myProcess.Start()
            End If
        Else
            MessageBox.Show("디렉토리를 선택해 주세요.", "디렉토리 선택", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub lvFile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lvFile.KeyPress
        If (e.KeyChar = Chr(8)) Then
            'String을 이용
            Dim p() As String = Strings.Split(path, "\")
            Dim newPath As String = ""

            For Each s In p
                ' newPath = newPath + 
            Next

        End If
    End Sub
End Class
