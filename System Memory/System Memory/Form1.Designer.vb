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
        Me.plBar = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'plBar
        '
        Me.plBar.BackColor = System.Drawing.Color.White
        Me.plBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plBar.Location = New System.Drawing.Point(31, 31)
        Me.plBar.Name = "plBar"
        Me.plBar.Size = New System.Drawing.Size(395, 27)
        Me.plBar.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 88)
        Me.Controls.Add(Me.plBar)
        Me.Name = "Form1"
        Me.Text = "메모리 체크"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents plBar As Panel
End Class
