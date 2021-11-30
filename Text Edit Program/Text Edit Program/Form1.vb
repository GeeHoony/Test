Imports System.IO
Imports System.Management


Public Class Form1
    Dim path As String = "c:\\" '기본 경로

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeView() 'treeView() 메소드 호출
    End Sub

    Private Sub TreeView()
        Dim RootNode, SubNode
        Dim imageIndex = 5
        Dim selectIndex = 5

        'Const Unknown = 0
        'Const NoRootDirectory = 1
        Const RemovableDisk = 2
        Const LocalDisk = 3
        'Const NetworkDrive = 4
        Const CompactDisc = 5
        Const RAMDisk = 6


        Dim query = New ManagementObjectSearcher("SELECT * From Win32_LogicalDisk")
        Dim queryCollection = query.Get()

        Me.trDive.BeginUpdate()
        RootNode = New TreeNode("내 컴퓨터", imageIndex, selectIndex)
        Me.trDive.Nodes.Add(RootNode)

        For Each drive In queryCollection
            Select Case Convert.ToInt32(drive("DriveType").ToString())
                Case RemovableDisk
                    imageIndex = 0
                    selectIndex = 0
                Case LocalDisk
                    imageIndex = 1
                    selectIndex = 1
                Case CompactDisc
                    imageIndex = 2
                    selectIndex = 2
                Case RAMDisk
                    imageIndex = 3
                    selectIndex = 3
                Case Else
                    imageIndex = 0
                    selectIndex = 0
            End Select

            SubNode = New TreeNode("(" + drive("Name").ToString() + ")", imageIndex, selectIndex)
            Me.trDive.Nodes(0).Nodes.Add(SubNode)
        Next
        Me.trDive.EndUpdate()
    End Sub

    Private Sub View(ByVal dr As String)
        Me.Text = path
        Me.lvFolder.Items.Clear()
        Me.lvFile.Items.Clear()
        Dim imageNum = 15
        Try
            If (Directory.Exists(dr) = False) Then
                MessageBox.Show(dr + " 드라이브는 읽을 수 없습니다.", "디스크 삽입", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim lvItema = New ListViewItem(New String() {"..", "폴더"}, 16)
                Me.lvFolder.Items.Add(lvItema)
                Dim di = New DirectoryInfo(dr)

                For Each d In di.GetDirectories()
                    Dim lvItem = New ListViewItem(New String() {d.Name, "폴더", d.LastWriteTime.ToShortDateString()}, 16)
                    Me.lvFolder.Items.Add(lvItem)
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
                    Dim lvi = New ListViewItem(New String() {d.Name, "파일"}, imageNum)
                    Me.lvFile.Items.Add(lvi)
                Next
            End If
        Catch
            MessageBox.Show("오류 메시지 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub trDive_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trDive.AfterSelect
        If (Me.trDive.SelectedNode.Text <> "내 컴퓨터") Then
            Dim str = Me.trDive.SelectedNode.Text.Substring(1, 1)
            path = str + ":\" 'Treeview 컨트롤에 현재 선택되어 있는 트리 노드를 가져오거나 설정합니다.
            View(path) 'view 메서드 호출
        End If
    End Sub

    Private Sub lvFolder_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvFolder.DoubleClick
        If (Me.lvFolder.SelectedItems.Count <> 0) Then
            If (Me.lvFolder.SelectedItems(0).SubItems(1).Text = "폴더" And Me.lvFolder.SelectedItems(0).SubItems(0).Text <> "..") Then
                path = path + Me.lvFolder.SelectedItems(0).SubItems(0).Text + "\"
                View(path)
            Else
                Try
                    Dim str = ""
                    Dim astr = Me.path.Split("\\")
                    Dim p = astr.Length
                    If (p > 2) Then
                        For i = 0 To p - 3
                            str += astr(i) + "\"
                        Next i
                        Me.path = str
                        View(str)
                    Else
                        MessageBox.Show("상위 폴더로 이동할 수 없습니다.", "오류 메시지", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch
                    MessageBox.Show("상위 폴더로 이동할 수 없습니다.", "오류 메시지", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        Else
            MessageBox.Show("디렉토리를 선택해 주세요.", "디렉토리 선택", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub lvFile_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvFile.DoubleClick
        If (Form2.Visible = True) Then
            Dim FilePath = path + Me.lvFile.SelectedItems(0).SubItems(0).Text
            ShowForm2(FilePath)
        End If
    End Sub

    Private Sub ShowForm2(ByVal FilePath As String)
        Dim extendOp = FilePath.Substring(FilePath.ToString().LastIndexOf(".") + 1)
        Dim fileName = FilePath.ToString().Substring(FilePath.ToString().LastIndexOf("\") + 1)
        Form2.rtbText.Text = FilePath
        Form2.rtbText.LoadFile(Form2.rtbText.Text, GetRichType(extendOp))
        Form2.rtbText.Tag = FilePath
    End Sub

    Function GetRichType(ByVal inValue As String) As String
        Dim rt As RichTextBoxStreamType = RichTextBoxStreamType.PlainText
        Select Case inValue
            Case "txt"
                Exit Select
            Case "rtf"
                rt = RichTextBoxStreamType.RichText
            Case "vb"
                rt = RichTextBoxStreamType.PlainText
            Case "html"
                rt = RichTextBoxStreamType.PlainText
        End Select
        Return rt
    End Function

    Private Sub 새로만들기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 새로만들기ToolStripMenuItem.Click
        NewForm()
    End Sub

    Private Sub NewForm()
        Try
            Form2.MdiParent = Me
            Form2.Show()
        Catch
        End Try
    End Sub

    Private Sub 저장하기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 저장하기ToolStripMenuItem.Click
        Save()
    End Sub

    Private Sub Save()
        If (Form2.Visible = True) Then
            Dim dlr = Me.sfdFile.ShowDialog()
            If (dlr <> DialogResult.Cancel) Then
                Dim Str = Me.sfdFile.FileName
                Dim sw = New StreamWriter(Str, False, System.Text.Encoding.Default)
                sw.Write(Form2.rtbText.Text)
                sw.Flush()
                sw.Close()
            End If
        End If
    End Sub

    Private Sub 다른이름으로저장ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 다른이름으로저장ToolStripMenuItem.Click
        Save()
    End Sub

    Private Sub 끝내기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 끝내기ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TextControl1(ByVal Action As String)
        If (Form2.Visible = True) Then
            Try
                Select Case Action
                    Case "undo"
                        Form2.rtbText.Undo()
                    Case "copy"
                        Form2.rtbText.Copy()
                    Case "cut"
                        Form2.rtbText.Cut()
                    Case "all"
                        Form2.rtbText.SelectAll()
                    Case "redo"
                        Form2.rtbText.Redo()
                End Select
            Catch
            End Try
        End If
    End Sub

    Private Sub 되돌리기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 되돌리기ToolStripMenuItem.Click
        TextControl1("undo")
    End Sub

    Private Sub 복사ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 복사ToolStripMenuItem.Click
        TextControl1("copy")
    End Sub

    Private Sub 자르기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 자르기ToolStripMenuItem.Click
        TextControl1("cut")
    End Sub

    Private Sub 모두선택ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 모두선택ToolStripMenuItem.Click
        TextControl1("all")
    End Sub

    Private Sub TextControl2(ByVal Action As String)
        If (Form2.Visible = True) Then
            Try
                Select Case Action
                    Case "left"
                        Form2.rtbText.SelectionAlignment = HorizontalAlignment.Left
                    Case "center"
                        Form2.rtbText.SelectionAlignment = HorizontalAlignment.Center
                    Case "right"
                        Form2.rtbText.SelectionAlignment = HorizontalAlignment.Right
                End Select
            Catch
            End Try
        End If
    End Sub

    Private Sub 왼쪽ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 왼쪽ToolStripMenuItem.Click
        TextControl2("left")
    End Sub

    Private Sub 가운데ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 가운데ToolStripMenuItem.Click
        TextControl2("center")
    End Sub

    Private Sub 오른쪽ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 오른쪽ToolStripMenuItem.Click
        TextControl2("right")
    End Sub

    Private Sub 편집상자ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 편집상자ToolStripMenuItem.Click
        If (편집상자ToolStripMenuItem.Checked) Then
            Me.tsBar.Visible = False
            Me.편집상자ToolStripMenuItem.Checked = False
        Else
            Me.tsBar.Visible = True
            Me.편집상자ToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub 파일보기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 파일보기ToolStripMenuItem.Click
        If (파일보기ToolStripMenuItem.Checked) Then
            Me.plGroup.Visible = False
            Me.파일보기ToolStripMenuItem.Checked = False
        Else
            Me.plGroup.Visible = True
            Me.파일보기ToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub tsbNew_Click(sender As Object, e As EventArgs) Handles tsbNew.Click
        NewForm()
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        Save()
    End Sub

    Private Sub tsbRear_Click(sender As Object, e As EventArgs) Handles tsbRear.Click
        TextControl1("undo")
    End Sub

    Private Sub tsbFront_Click(sender As Object, e As EventArgs) Handles tsbFront.Click
        TextControl1("redo")
    End Sub

    Private Sub tsbLeftAlign_Click(sender As Object, e As EventArgs) Handles tsbLeftAlign.Click
        TextControl2("left")
    End Sub

    Private Sub tsbMidAlign_Click(sender As Object, e As EventArgs) Handles tsbMidAlign.Click
        TextControl2("center")
    End Sub

    Private Sub tsbRightAlign_Click(sender As Object, e As EventArgs) Handles tsbRightAlign.Click
        TextControl2("right")
    End Sub
End Class

