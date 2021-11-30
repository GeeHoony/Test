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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.imgDisk = New System.Windows.Forms.ImageList(Me.components)
        Me.imgFile = New System.Windows.Forms.ImageList(Me.components)
        Me.msBar = New System.Windows.Forms.MenuStrip()
        Me.tsBar = New System.Windows.Forms.ToolStrip()
        Me.plGroup = New System.Windows.Forms.Panel()
        Me.trDive = New System.Windows.Forms.TreeView()
        Me.lvFolder = New System.Windows.Forms.ListView()
        Me.lvFile = New System.Windows.Forms.ListView()
        Me.sfdFile = New System.Windows.Forms.SaveFileDialog()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.파일ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.새로만들기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장하기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.다른이름으로저장ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.끝내기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.편집ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.되돌리기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.복사ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.자르기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.모두선택ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.왼쪽ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.가운데ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.오른쪽ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.보기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.편집상자ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.파일보기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbRear = New System.Windows.Forms.ToolStripButton()
        Me.tsbFront = New System.Windows.Forms.ToolStripButton()
        Me.tsbLeftAlign = New System.Windows.Forms.ToolStripButton()
        Me.tsbMidAlign = New System.Windows.Forms.ToolStripButton()
        Me.tsbRightAlign = New System.Windows.Forms.ToolStripButton()
        Me.msBar.SuspendLayout()
        Me.tsBar.SuspendLayout()
        Me.plGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgDisk
        '
        Me.imgDisk.ImageStream = CType(resources.GetObject("imgDisk.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgDisk.TransparentColor = System.Drawing.Color.Transparent
        Me.imgDisk.Images.SetKeyName(0, "0.JPG")
        Me.imgDisk.Images.SetKeyName(1, "1.JPG")
        Me.imgDisk.Images.SetKeyName(2, "2.JPG")
        Me.imgDisk.Images.SetKeyName(3, "3.JPG")
        Me.imgDisk.Images.SetKeyName(4, "4.JPG")
        Me.imgDisk.Images.SetKeyName(5, "5.JPG")
        '
        'imgFile
        '
        Me.imgFile.ImageStream = CType(resources.GetObject("imgFile.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgFile.TransparentColor = System.Drawing.Color.Transparent
        Me.imgFile.Images.SetKeyName(0, "bmp.bmp")
        Me.imgFile.Images.SetKeyName(1, "com.bmp")
        Me.imgFile.Images.SetKeyName(2, "doc.bmp")
        Me.imgFile.Images.SetKeyName(3, "etc.bmp")
        Me.imgFile.Images.SetKeyName(4, "exe.bmp")
        Me.imgFile.Images.SetKeyName(5, "Folder.bmp")
        Me.imgFile.Images.SetKeyName(6, "gif.bmp")
        Me.imgFile.Images.SetKeyName(7, "htm.bmp")
        Me.imgFile.Images.SetKeyName(8, "html.bmp")
        Me.imgFile.Images.SetKeyName(9, "hwp.bmp")
        Me.imgFile.Images.SetKeyName(10, "jpg.bmp")
        Me.imgFile.Images.SetKeyName(11, "mp3.bmp")
        Me.imgFile.Images.SetKeyName(12, "mpg.bmp")
        Me.imgFile.Images.SetKeyName(13, "ra.bmp")
        Me.imgFile.Images.SetKeyName(14, "rar.bmp")
        Me.imgFile.Images.SetKeyName(15, "txt.bmp")
        Me.imgFile.Images.SetKeyName(16, "zip.bmp")
        '
        'msBar
        '
        Me.msBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일ToolStripMenuItem, Me.편집ToolStripMenuItem, Me.보기ToolStripMenuItem})
        Me.msBar.Location = New System.Drawing.Point(0, 0)
        Me.msBar.Name = "msBar"
        Me.msBar.Size = New System.Drawing.Size(1049, 24)
        Me.msBar.TabIndex = 2
        Me.msBar.Text = "msBar"
        '
        'tsBar
        '
        Me.tsBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbSave, Me.tsbRear, Me.tsbFront, Me.tsbLeftAlign, Me.tsbMidAlign, Me.tsbRightAlign})
        Me.tsBar.Location = New System.Drawing.Point(0, 24)
        Me.tsBar.Name = "tsBar"
        Me.tsBar.Size = New System.Drawing.Size(1049, 25)
        Me.tsBar.TabIndex = 3
        Me.tsBar.Text = "ToolStrip1"
        '
        'plGroup
        '
        Me.plGroup.Controls.Add(Me.lvFile)
        Me.plGroup.Controls.Add(Me.lvFolder)
        Me.plGroup.Controls.Add(Me.trDive)
        Me.plGroup.Dock = System.Windows.Forms.DockStyle.Left
        Me.plGroup.Location = New System.Drawing.Point(0, 49)
        Me.plGroup.Name = "plGroup"
        Me.plGroup.Size = New System.Drawing.Size(230, 586)
        Me.plGroup.TabIndex = 4
        '
        'trDive
        '
        Me.trDive.ImageIndex = 0
        Me.trDive.ImageList = Me.imgDisk
        Me.trDive.Location = New System.Drawing.Point(3, 3)
        Me.trDive.Name = "trDive"
        Me.trDive.SelectedImageIndex = 0
        Me.trDive.Size = New System.Drawing.Size(224, 139)
        Me.trDive.TabIndex = 0
        '
        'lvFolder
        '
        Me.lvFolder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvFolder.Location = New System.Drawing.Point(3, 148)
        Me.lvFolder.Name = "lvFolder"
        Me.lvFolder.Size = New System.Drawing.Size(224, 184)
        Me.lvFolder.SmallImageList = Me.imgFile
        Me.lvFolder.TabIndex = 1
        Me.lvFolder.UseCompatibleStateImageBehavior = False
        Me.lvFolder.View = System.Windows.Forms.View.Details
        '
        'lvFile
        '
        Me.lvFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lvFile.Location = New System.Drawing.Point(3, 338)
        Me.lvFile.MultiSelect = False
        Me.lvFile.Name = "lvFile"
        Me.lvFile.Size = New System.Drawing.Size(224, 245)
        Me.lvFile.SmallImageList = Me.imgFile
        Me.lvFile.TabIndex = 2
        Me.lvFile.UseCompatibleStateImageBehavior = False
        Me.lvFile.View = System.Windows.Forms.View.Details
        '
        'sfdFile
        '
        Me.sfdFile.FileName = "doc1"
        Me.sfdFile.Filter = "서식파일(*.rtf)|*.rtf|텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "폴더 이름"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "파일 이름"
        Me.ColumnHeader2.Width = 150
        '
        '파일ToolStripMenuItem
        '
        Me.파일ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.새로만들기ToolStripMenuItem, Me.저장하기ToolStripMenuItem, Me.다른이름으로저장ToolStripMenuItem, Me.ToolStripSeparator1, Me.끝내기ToolStripMenuItem})
        Me.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem"
        Me.파일ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.파일ToolStripMenuItem.Text = "파일"
        '
        '새로만들기ToolStripMenuItem
        '
        Me.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem"
        Me.새로만들기ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.새로만들기ToolStripMenuItem.Text = "새로만들기"
        '
        '저장하기ToolStripMenuItem
        '
        Me.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem"
        Me.저장하기ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.저장하기ToolStripMenuItem.Text = "저장하기"
        '
        '다른이름으로저장ToolStripMenuItem
        '
        Me.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem"
        Me.다른이름으로저장ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.다른이름으로저장ToolStripMenuItem.Text = "다른이름으로 저장"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        '끝내기ToolStripMenuItem
        '
        Me.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem"
        Me.끝내기ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.끝내기ToolStripMenuItem.Text = "끝내기"
        '
        '편집ToolStripMenuItem
        '
        Me.편집ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.되돌리기ToolStripMenuItem, Me.ToolStripSeparator2, Me.복사ToolStripMenuItem, Me.자르기ToolStripMenuItem, Me.ToolStripSeparator3, Me.모두선택ToolStripMenuItem, Me.ToolStripSeparator4, Me.왼쪽ToolStripMenuItem, Me.가운데ToolStripMenuItem, Me.오른쪽ToolStripMenuItem})
        Me.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem"
        Me.편집ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.편집ToolStripMenuItem.Text = "편집"
        '
        '되돌리기ToolStripMenuItem
        '
        Me.되돌리기ToolStripMenuItem.Name = "되돌리기ToolStripMenuItem"
        Me.되돌리기ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.되돌리기ToolStripMenuItem.Text = "되돌리기"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        '복사ToolStripMenuItem
        '
        Me.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem"
        Me.복사ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.복사ToolStripMenuItem.Text = "복사"
        '
        '자르기ToolStripMenuItem
        '
        Me.자르기ToolStripMenuItem.Name = "자르기ToolStripMenuItem"
        Me.자르기ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.자르기ToolStripMenuItem.Text = "자르기"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        '모두선택ToolStripMenuItem
        '
        Me.모두선택ToolStripMenuItem.Name = "모두선택ToolStripMenuItem"
        Me.모두선택ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.모두선택ToolStripMenuItem.Text = "모두선택"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        '왼쪽ToolStripMenuItem
        '
        Me.왼쪽ToolStripMenuItem.Name = "왼쪽ToolStripMenuItem"
        Me.왼쪽ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.왼쪽ToolStripMenuItem.Text = "왼쪽"
        '
        '가운데ToolStripMenuItem
        '
        Me.가운데ToolStripMenuItem.Name = "가운데ToolStripMenuItem"
        Me.가운데ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.가운데ToolStripMenuItem.Text = "가운데"
        '
        '오른쪽ToolStripMenuItem
        '
        Me.오른쪽ToolStripMenuItem.Name = "오른쪽ToolStripMenuItem"
        Me.오른쪽ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.오른쪽ToolStripMenuItem.Text = "오른쪽"
        '
        '보기ToolStripMenuItem
        '
        Me.보기ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.편집상자ToolStripMenuItem, Me.파일보기ToolStripMenuItem})
        Me.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem"
        Me.보기ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.보기ToolStripMenuItem.Text = "보기"
        '
        '편집상자ToolStripMenuItem
        '
        Me.편집상자ToolStripMenuItem.Name = "편집상자ToolStripMenuItem"
        Me.편집상자ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.편집상자ToolStripMenuItem.Text = "편집 상자"
        '
        '파일보기ToolStripMenuItem
        '
        Me.파일보기ToolStripMenuItem.Name = "파일보기ToolStripMenuItem"
        Me.파일보기ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.파일보기ToolStripMenuItem.Text = "파일 보기"
        '
        'tsbNew
        '
        Me.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNew.Image = CType(resources.GetObject("tsbNew.Image"), System.Drawing.Image)
        Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(23, 22)
        Me.tsbNew.Text = "새로만들기"
        '
        'tsbSave
        '
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"), System.Drawing.Image)
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(23, 22)
        Me.tsbSave.Text = "저장하기"
        '
        'tsbRear
        '
        Me.tsbRear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRear.Image = CType(resources.GetObject("tsbRear.Image"), System.Drawing.Image)
        Me.tsbRear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRear.Name = "tsbRear"
        Me.tsbRear.Size = New System.Drawing.Size(23, 22)
        Me.tsbRear.Text = "뒤로"
        '
        'tsbFront
        '
        Me.tsbFront.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFront.Image = CType(resources.GetObject("tsbFront.Image"), System.Drawing.Image)
        Me.tsbFront.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFront.Name = "tsbFront"
        Me.tsbFront.Size = New System.Drawing.Size(23, 22)
        Me.tsbFront.Text = "앞으로"
        '
        'tsbLeftAlign
        '
        Me.tsbLeftAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLeftAlign.Image = CType(resources.GetObject("tsbLeftAlign.Image"), System.Drawing.Image)
        Me.tsbLeftAlign.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLeftAlign.Name = "tsbLeftAlign"
        Me.tsbLeftAlign.Size = New System.Drawing.Size(23, 22)
        Me.tsbLeftAlign.Text = "왼쪽정렬"
        '
        'tsbMidAlign
        '
        Me.tsbMidAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMidAlign.Image = CType(resources.GetObject("tsbMidAlign.Image"), System.Drawing.Image)
        Me.tsbMidAlign.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMidAlign.Name = "tsbMidAlign"
        Me.tsbMidAlign.Size = New System.Drawing.Size(23, 22)
        Me.tsbMidAlign.Text = "가운데정렬"
        '
        'tsbRightAlign
        '
        Me.tsbRightAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRightAlign.Image = CType(resources.GetObject("tsbRightAlign.Image"), System.Drawing.Image)
        Me.tsbRightAlign.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRightAlign.Name = "tsbRightAlign"
        Me.tsbRightAlign.Size = New System.Drawing.Size(23, 22)
        Me.tsbRightAlign.Text = "오른쪽정렬"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 635)
        Me.Controls.Add(Me.plGroup)
        Me.Controls.Add(Me.tsBar)
        Me.Controls.Add(Me.msBar)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msBar
        Me.Name = "Form1"
        Me.Text = "텍스트 편집기"
        Me.msBar.ResumeLayout(False)
        Me.msBar.PerformLayout()
        Me.tsBar.ResumeLayout(False)
        Me.tsBar.PerformLayout()
        Me.plGroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgDisk As ImageList
    Friend WithEvents imgFile As ImageList
    Friend WithEvents msBar As MenuStrip
    Friend WithEvents 파일ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 새로만들기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 저장하기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 다른이름으로저장ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 끝내기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 편집ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 되돌리기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 복사ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 자르기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents 모두선택ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents 왼쪽ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 가운데ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 오른쪽ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 보기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 편집상자ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 파일보기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsBar As ToolStrip
    Friend WithEvents tsbNew As ToolStripButton
    Friend WithEvents tsbSave As ToolStripButton
    Friend WithEvents tsbRear As ToolStripButton
    Friend WithEvents tsbFront As ToolStripButton
    Friend WithEvents tsbLeftAlign As ToolStripButton
    Friend WithEvents tsbMidAlign As ToolStripButton
    Friend WithEvents tsbRightAlign As ToolStripButton
    Friend WithEvents plGroup As Panel
    Friend WithEvents lvFile As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents lvFolder As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents trDive As TreeView
    Friend WithEvents sfdFile As SaveFileDialog
End Class
