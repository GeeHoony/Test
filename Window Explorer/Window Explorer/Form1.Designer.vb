<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DriveList = New System.Windows.Forms.ImageList(Me.components)
        Me.FileList = New System.Windows.Forms.ImageList(Me.components)
        Me.lvFile = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.treeDisk = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DriveList
        '
        Me.DriveList.ImageStream = CType(resources.GetObject("DriveList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.DriveList.TransparentColor = System.Drawing.Color.Transparent
        Me.DriveList.Images.SetKeyName(0, "0.JPG")
        Me.DriveList.Images.SetKeyName(1, "1.JPG")
        Me.DriveList.Images.SetKeyName(2, "2.JPG")
        Me.DriveList.Images.SetKeyName(3, "3.JPG")
        Me.DriveList.Images.SetKeyName(4, "4.JPG")
        Me.DriveList.Images.SetKeyName(5, "5.JPG")
        '
        'FileList
        '
        Me.FileList.ImageStream = CType(resources.GetObject("FileList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.FileList.TransparentColor = System.Drawing.Color.Transparent
        Me.FileList.Images.SetKeyName(0, "exe.bmp")
        Me.FileList.Images.SetKeyName(1, "com.bmp")
        Me.FileList.Images.SetKeyName(2, "txt.bmp")
        Me.FileList.Images.SetKeyName(3, "bmp.bmp")
        Me.FileList.Images.SetKeyName(4, "doc.bmp")
        Me.FileList.Images.SetKeyName(5, "gif.bmp")
        Me.FileList.Images.SetKeyName(6, "htm.bmp")
        Me.FileList.Images.SetKeyName(7, "html.bmp")
        Me.FileList.Images.SetKeyName(8, "hwp.bmp")
        Me.FileList.Images.SetKeyName(9, "jpg.bmp")
        Me.FileList.Images.SetKeyName(10, "mp3.bmp")
        Me.FileList.Images.SetKeyName(11, "mpg.bmp")
        Me.FileList.Images.SetKeyName(12, "ra.bmp")
        Me.FileList.Images.SetKeyName(13, "rar.bmp")
        Me.FileList.Images.SetKeyName(14, "zip.bmp")
        Me.FileList.Images.SetKeyName(15, "etc.bmp")
        Me.FileList.Images.SetKeyName(16, "Folder.bmp")
        '
        'lvFile
        '
        Me.lvFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvFile.FullRowSelect = True
        Me.lvFile.Location = New System.Drawing.Point(258, 12)
        Me.lvFile.Name = "lvFile"
        Me.lvFile.Size = New System.Drawing.Size(541, 449)
        Me.lvFile.SmallImageList = Me.FileList
        Me.lvFile.TabIndex = 0
        Me.lvFile.UseCompatibleStateImageBehavior = False
        Me.lvFile.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "파일 이름"
        Me.ColumnHeader1.Width = 140
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "크기"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "파일 폴더"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "최근 수정 날짜"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 170
        '
        'treeDisk
        '
        Me.treeDisk.ImageIndex = 0
        Me.treeDisk.ImageList = Me.DriveList
        Me.treeDisk.Location = New System.Drawing.Point(12, 12)
        Me.treeDisk.Name = "treeDisk"
        Me.treeDisk.SelectedImageIndex = 0
        Me.treeDisk.Size = New System.Drawing.Size(230, 449)
        Me.treeDisk.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.treeDisk)
        Me.Panel1.Controls.Add(Me.lvFile)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 489)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 517)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 541)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "윈도우 탐색기"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DriveList As ImageList
    Friend WithEvents FileList As ImageList
    Friend WithEvents lvFile As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents treeDisk As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
