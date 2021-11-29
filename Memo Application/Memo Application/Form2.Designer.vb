<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancle = New System.Windows.Forms.Button()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.chb = New System.Windows.Forms.CheckBox()
        Me.rdb01 = New System.Windows.Forms.RadioButton()
        Me.rdb02 = New System.Windows.Forms.RadioButton()
        Me.groupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "찾을 내용 : "
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(98, 33)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(273, 21)
        Me.txtWord.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(399, 33)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "다음 찾기"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancle
        '
        Me.btnCancle.Location = New System.Drawing.Point(399, 83)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(75, 23)
        Me.btnCancle.TabIndex = 3
        Me.btnCancle.Text = "취소"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'groupBox
        '
        Me.groupBox.Controls.Add(Me.rdb02)
        Me.groupBox.Controls.Add(Me.rdb01)
        Me.groupBox.Location = New System.Drawing.Point(173, 62)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(198, 65)
        Me.groupBox.TabIndex = 4
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "방향"
        '
        'chb
        '
        Me.chb.AutoSize = True
        Me.chb.Location = New System.Drawing.Point(26, 89)
        Me.chb.Name = "chb"
        Me.chb.Size = New System.Drawing.Size(106, 16)
        Me.chb.TabIndex = 5
        Me.chb.Text = "대/소문자 구분"
        Me.chb.UseVisualStyleBackColor = True
        '
        'rdb01
        '
        Me.rdb01.AutoSize = True
        Me.rdb01.Location = New System.Drawing.Point(7, 26)
        Me.rdb01.Name = "rdb01"
        Me.rdb01.Size = New System.Drawing.Size(47, 16)
        Me.rdb01.TabIndex = 0
        Me.rdb01.TabStop = True
        Me.rdb01.Text = "위쪽"
        Me.rdb01.UseVisualStyleBackColor = True
        '
        'rdb02
        '
        Me.rdb02.AutoSize = True
        Me.rdb02.Location = New System.Drawing.Point(96, 26)
        Me.rdb02.Name = "rdb02"
        Me.rdb02.Size = New System.Drawing.Size(59, 16)
        Me.rdb02.TabIndex = 1
        Me.rdb02.TabStop = True
        Me.rdb02.Text = "아래쪽"
        Me.rdb02.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 139)
        Me.Controls.Add(Me.chb)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "찾기"
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancle As Button
    Friend WithEvents groupBox As GroupBox
    Friend WithEvents rdb02 As RadioButton
    Friend WithEvents rdb01 As RadioButton
    Friend WithEvents chb As CheckBox
End Class
