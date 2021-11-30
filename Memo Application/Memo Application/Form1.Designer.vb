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
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.파일FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.새로만들기NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.열기OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.다른이름으로저장SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.끝내기XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.편집EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.실행취소UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.잘라내기TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.복사CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.붙여넣기PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.삭제LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.찾기FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.다음찾기NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.모두선택AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.시간날짜DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.서식OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.자동줄바꿈WToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.글꼴FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.메모장정보AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fdText = New System.Windows.Forms.FontDialog()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdFile = New System.Windows.Forms.SaveFileDialog()
        Me.menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuBar
        '
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일FToolStripMenuItem, Me.편집EToolStripMenuItem, Me.서식OToolStripMenuItem, Me.도움말HToolStripMenuItem})
        Me.menuBar.Location = New System.Drawing.Point(0, 0)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(800, 24)
        Me.menuBar.TabIndex = 0
        Me.menuBar.Text = "MenuStrip1"
        '
        '파일FToolStripMenuItem
        '
        Me.파일FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.새로만들기NToolStripMenuItem, Me.열기OToolStripMenuItem, Me.저장SToolStripMenuItem, Me.다른이름으로저장SToolStripMenuItem, Me.ToolStripSeparator1, Me.끝내기XToolStripMenuItem})
        Me.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem"
        Me.파일FToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.파일FToolStripMenuItem.Text = "파일(&F)"
        '
        '새로만들기NToolStripMenuItem
        '
        Me.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem"
        Me.새로만들기NToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.새로만들기NToolStripMenuItem.Text = "새로 만들기(&N)"
        '
        '열기OToolStripMenuItem
        '
        Me.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem"
        Me.열기OToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.열기OToolStripMenuItem.Text = "열기(&O)"
        '
        '저장SToolStripMenuItem
        '
        Me.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem"
        Me.저장SToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.저장SToolStripMenuItem.Text = "저장(&S)"
        '
        '다른이름으로저장SToolStripMenuItem
        '
        Me.다른이름으로저장SToolStripMenuItem.Name = "다른이름으로저장SToolStripMenuItem"
        Me.다른이름으로저장SToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.다른이름으로저장SToolStripMenuItem.Text = "다른 이름으로 저장(&A)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        '끝내기XToolStripMenuItem
        '
        Me.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem"
        Me.끝내기XToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.끝내기XToolStripMenuItem.Text = "끝내기(&X)"
        '
        '편집EToolStripMenuItem
        '
        Me.편집EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.실행취소UToolStripMenuItem, Me.ToolStripSeparator2, Me.잘라내기TToolStripMenuItem, Me.복사CToolStripMenuItem, Me.붙여넣기PToolStripMenuItem, Me.삭제LToolStripMenuItem, Me.ToolStripSeparator3, Me.찾기FToolStripMenuItem, Me.다음찾기NToolStripMenuItem, Me.ToolStripSeparator4, Me.모두선택AToolStripMenuItem, Me.시간날짜DToolStripMenuItem})
        Me.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem"
        Me.편집EToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.편집EToolStripMenuItem.Text = "편집(&E)"
        '
        '실행취소UToolStripMenuItem
        '
        Me.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem"
        Me.실행취소UToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.실행취소UToolStripMenuItem.Text = "실행 취소(&U)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(141, 6)
        '
        '잘라내기TToolStripMenuItem
        '
        Me.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem"
        Me.잘라내기TToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.잘라내기TToolStripMenuItem.Text = "잘라내기(&T)"
        '
        '복사CToolStripMenuItem
        '
        Me.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem"
        Me.복사CToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.복사CToolStripMenuItem.Text = "복사(&C)"
        '
        '붙여넣기PToolStripMenuItem
        '
        Me.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem"
        Me.붙여넣기PToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.붙여넣기PToolStripMenuItem.Text = "붙여넣기(&P)"
        '
        '삭제LToolStripMenuItem
        '
        Me.삭제LToolStripMenuItem.Name = "삭제LToolStripMenuItem"
        Me.삭제LToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.삭제LToolStripMenuItem.Text = "삭제(&L)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        '찾기FToolStripMenuItem
        '
        Me.찾기FToolStripMenuItem.Name = "찾기FToolStripMenuItem"
        Me.찾기FToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.찾기FToolStripMenuItem.Text = "찾기(&F)"
        '
        '다음찾기NToolStripMenuItem
        '
        Me.다음찾기NToolStripMenuItem.Name = "다음찾기NToolStripMenuItem"
        Me.다음찾기NToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.다음찾기NToolStripMenuItem.Text = "다음 찾기(&N)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        '모두선택AToolStripMenuItem
        '
        Me.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem"
        Me.모두선택AToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.모두선택AToolStripMenuItem.Text = "모두 선택(&A)"
        '
        '시간날짜DToolStripMenuItem
        '
        Me.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem"
        Me.시간날짜DToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.시간날짜DToolStripMenuItem.Text = "시간/날짜(&D)"
        '
        '서식OToolStripMenuItem
        '
        Me.서식OToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.자동줄바꿈WToolStripMenuItem, Me.글꼴FToolStripMenuItem})
        Me.서식OToolStripMenuItem.Name = "서식OToolStripMenuItem"
        Me.서식OToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.서식OToolStripMenuItem.Text = "서식(&O)"
        '
        '자동줄바꿈WToolStripMenuItem
        '
        Me.자동줄바꿈WToolStripMenuItem.Name = "자동줄바꿈WToolStripMenuItem"
        Me.자동줄바꿈WToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.자동줄바꿈WToolStripMenuItem.Text = "자동 줄 바꿈(&W)"
        '
        '글꼴FToolStripMenuItem
        '
        Me.글꼴FToolStripMenuItem.Name = "글꼴FToolStripMenuItem"
        Me.글꼴FToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.글꼴FToolStripMenuItem.Text = "글꼴(&F)"
        '
        '도움말HToolStripMenuItem
        '
        Me.도움말HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.메모장정보AToolStripMenuItem})
        Me.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem"
        Me.도움말HToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.도움말HToolStripMenuItem.Text = "도움말(&H)"
        '
        '메모장정보AToolStripMenuItem
        '
        Me.메모장정보AToolStripMenuItem.Name = "메모장정보AToolStripMenuItem"
        Me.메모장정보AToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.메모장정보AToolStripMenuItem.Text = "메모장 정보(&A)"
        '
        'txtNote
        '
        Me.txtNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNote.Location = New System.Drawing.Point(0, 24)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNote.Size = New System.Drawing.Size(800, 426)
        Me.txtNote.TabIndex = 1
        '
        'ofdFile
        '
        Me.ofdFile.FileName = "OpenFileDialog1"
        Me.ofdFile.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*"
        '
        'sfdFile
        '
        Me.sfdFile.FileName = "텍스트"
        Me.sfdFile.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.menuBar)
        Me.MainMenuStrip = Me.menuBar
        Me.Name = "Form1"
        Me.Text = "제목 없음"
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents 파일FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 편집EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 서식OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 도움말HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents fdText As FontDialog
    Friend WithEvents 새로만들기NToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 열기OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 저장SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 다른이름으로저장SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtNote As TextBox
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents sfdFile As SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 끝내기XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 실행취소UToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 잘라내기TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 복사CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 붙여넣기PToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 삭제LToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents 찾기FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 다음찾기NToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents 모두선택AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 시간날짜DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 자동줄바꿈WToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 글꼴FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 메모장정보AToolStripMenuItem As ToolStripMenuItem
End Class
