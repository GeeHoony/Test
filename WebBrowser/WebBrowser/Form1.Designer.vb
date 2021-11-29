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
        Me.lvCall = New System.Windows.Forms.ListView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhonNum = New System.Windows.Forms.TextBox()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPhone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvCall
        '
        Me.lvCall.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chPhone})
        Me.lvCall.GridLines = True
        Me.lvCall.Location = New System.Drawing.Point(12, 12)
        Me.lvCall.Name = "lvCall"
        Me.lvCall.Size = New System.Drawing.Size(441, 286)
        Me.lvCall.TabIndex = 0
        Me.lvCall.UseCompatibleStateImageBehavior = False
        Me.lvCall.View = System.Windows.Forms.View.Details
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(320, 328)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 81)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "입력"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "이름"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "전화번호"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(163, 328)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(120, 21)
        Me.txtName.TabIndex = 4
        '
        'txtPhonNum
        '
        Me.txtPhonNum.Location = New System.Drawing.Point(163, 388)
        Me.txtPhonNum.Name = "txtPhonNum"
        Me.txtPhonNum.Size = New System.Drawing.Size(120, 21)
        Me.txtPhonNum.TabIndex = 5
        '
        'chName
        '
        Me.chName.Text = "이름"
        Me.chName.Width = 100
        '
        'chPhone
        '
        Me.chPhone.Text = "전화번호"
        Me.chPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chPhone.Width = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 450)
        Me.Controls.Add(Me.txtPhonNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lvCall)
        Me.Name = "Form1"
        Me.Text = "전화번호 부"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvCall As ListView
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhonNum As TextBox
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chPhone As ColumnHeader
End Class
