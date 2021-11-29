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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblUrl = New System.Windows.Forms.Label()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.pgbDown = New System.Windows.Forms.ProgressBar()
        Me.webClient = New System.Net.WebClient()
        Me.SuspendLayout()
        '
        'lblUrl
        '
        Me.lblUrl.AutoSize = True
        Me.lblUrl.Location = New System.Drawing.Point(70, 25)
        Me.lblUrl.Name = "lblUrl"
        Me.lblUrl.Size = New System.Drawing.Size(29, 12)
        Me.lblUrl.TabIndex = 0
        Me.lblUrl.Text = "주소"
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(117, 22)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(294, 21)
        Me.txtUrl.TabIndex = 1
        '
        'btnDown
        '
        Me.btnDown.AutoSize = True
        Me.btnDown.Location = New System.Drawing.Point(424, 20)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 23)
        Me.btnDown.TabIndex = 2
        Me.btnDown.Text = "다운로드"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'pgbDown
        '
        Me.pgbDown.Location = New System.Drawing.Point(52, 63)
        Me.pgbDown.Name = "pgbDown"
        Me.pgbDown.Size = New System.Drawing.Size(447, 23)
        Me.pgbDown.TabIndex = 3
        '
        'webClient
        '
        'Me.webClient.AllowReadStreamBuffering = False
        'Me.webClient.AllowWriteStreamBuffering = False
        Me.webClient.BaseAddress = ""
        Me.webClient.CachePolicy = Nothing
        Me.webClient.Credentials = Nothing
        Me.webClient.Encoding = CType(resources.GetObject("webClient.Encoding"), System.Text.Encoding)
        Me.webClient.Headers = CType(resources.GetObject("webClient.Headers"), System.Net.WebHeaderCollection)
        Me.webClient.QueryString = CType(resources.GetObject("webClient.QueryString"), System.Collections.Specialized.NameValueCollection)
        Me.webClient.UseDefaultCredentials = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 112)
        Me.Controls.Add(Me.pgbDown)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.lblUrl)
        Me.Name = "Form1"
        Me.Text = "다운로드"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUrl As Label
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents btnDown As Button
    Friend WithEvents pgbDown As ProgressBar
    Friend WithEvents webClient As Net.WebClient
End Class
