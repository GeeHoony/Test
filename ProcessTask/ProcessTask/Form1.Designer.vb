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
        Me.lvView = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMemor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnKill = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lvView
        '
        Me.lvView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chPid, Me.chStatus, Me.chMemor})
        Me.lvView.FullRowSelect = True
        Me.lvView.GridLines = True
        Me.lvView.Location = New System.Drawing.Point(26, 25)
        Me.lvView.Name = "lvView"
        Me.lvView.Size = New System.Drawing.Size(752, 368)
        Me.lvView.TabIndex = 0
        Me.lvView.UseCompatibleStateImageBehavior = False
        Me.lvView.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "프로세스 이름"
        '
        'chPid
        '
        Me.chPid.Text = "PID"
        '
        'chStatus
        '
        Me.chStatus.Text = "상태"
        '
        'chMemor
        '
        Me.chMemor.Text = "메모리 사용"
        '
        'btnKill
        '
        Me.btnKill.Location = New System.Drawing.Point(555, 409)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(223, 23)
        Me.btnKill.TabIndex = 1
        Me.btnKill.Text = "프로세스 끝내기"
        Me.btnKill.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnKill)
        Me.Controls.Add(Me.lvView)
        Me.Name = "Form1"
        Me.Text = "프로세스 관리"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvView As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chPid As ColumnHeader
    Friend WithEvents chStatus As ColumnHeader
    Friend WithEvents chMemor As ColumnHeader
    Friend WithEvents btnKill As Button
    Friend WithEvents Timer1 As Timer
End Class
