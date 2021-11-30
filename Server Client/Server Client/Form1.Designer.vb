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
        Me.ssBar = New System.Windows.Forms.StatusStrip()
        Me.tsslblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsBar = New System.Windows.Forms.ToolStrip()
        Me.tsddbtnOption = New System.Windows.Forms.ToolStripDropDownButton()
        Me.설정ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.닫기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbtnConn = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDisconn = New System.Windows.Forms.ToolStripButton()
        Me.rtbText = New System.Windows.Forms.RichTextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.plGroup = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.plOption = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbServer = New System.Windows.Forms.CheckBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.ssBar.SuspendLayout()
        Me.tsBar.SuspendLayout()
        Me.plGroup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.plOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssBar
        '
        Me.ssBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblTime})
        Me.ssBar.Location = New System.Drawing.Point(0, 469)
        Me.ssBar.Name = "ssBar"
        Me.ssBar.Size = New System.Drawing.Size(409, 22)
        Me.ssBar.TabIndex = 0
        Me.ssBar.Text = "ssBar"
        '
        'tsslblTime
        '
        Me.tsslblTime.Name = "tsslblTime"
        Me.tsslblTime.Size = New System.Drawing.Size(127, 17)
        Me.tsslblTime.Text = "메세지 받은 시간 출력"
        '
        'tsBar
        '
        Me.tsBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsddbtnOption, Me.tsbtnConn, Me.tsbtnDisconn})
        Me.tsBar.Location = New System.Drawing.Point(0, 0)
        Me.tsBar.Name = "tsBar"
        Me.tsBar.Size = New System.Drawing.Size(409, 25)
        Me.tsBar.TabIndex = 1
        Me.tsBar.Text = "tsBar"
        '
        'tsddbtnOption
        '
        Me.tsddbtnOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsddbtnOption.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.설정ToolStripMenuItem, Me.ToolStripSeparator1, Me.닫기ToolStripMenuItem})
        Me.tsddbtnOption.Image = CType(resources.GetObject("tsddbtnOption.Image"), System.Drawing.Image)
        Me.tsddbtnOption.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsddbtnOption.Name = "tsddbtnOption"
        Me.tsddbtnOption.Size = New System.Drawing.Size(29, 22)
        Me.tsddbtnOption.Text = "아이템 추가/삭제"
        Me.tsddbtnOption.ToolTipText = "환경설정"
        '
        '설정ToolStripMenuItem
        '
        Me.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem"
        Me.설정ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.설정ToolStripMenuItem.Text = "설정"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        '닫기ToolStripMenuItem
        '
        Me.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem"
        Me.닫기ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.닫기ToolStripMenuItem.Text = "닫기"
        '
        'tsbtnConn
        '
        Me.tsbtnConn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnConn.Enabled = False
        Me.tsbtnConn.Image = CType(resources.GetObject("tsbtnConn.Image"), System.Drawing.Image)
        Me.tsbtnConn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnConn.Name = "tsbtnConn"
        Me.tsbtnConn.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnConn.Text = "연결"
        '
        'tsbtnDisconn
        '
        Me.tsbtnDisconn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnDisconn.Enabled = False
        Me.tsbtnDisconn.Image = CType(resources.GetObject("tsbtnDisconn.Image"), System.Drawing.Image)
        Me.tsbtnDisconn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDisconn.Name = "tsbtnDisconn"
        Me.tsbtnDisconn.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnDisconn.Text = "끊기"
        '
        'rtbText
        '
        Me.rtbText.BackColor = System.Drawing.Color.White
        Me.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbText.Location = New System.Drawing.Point(0, 28)
        Me.rtbText.Name = "rtbText"
        Me.rtbText.ReadOnly = True
        Me.rtbText.Size = New System.Drawing.Size(408, 343)
        Me.rtbText.TabIndex = 2
        Me.rtbText.TabStop = False
        Me.rtbText.Text = ""
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.Color.White
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMessage.Enabled = False
        Me.txtMessage.Location = New System.Drawing.Point(12, 31)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(304, 47)
        Me.txtMessage.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(0, 1)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 47)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "보내기"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'plGroup
        '
        Me.plGroup.BackColor = System.Drawing.Color.RoyalBlue
        Me.plGroup.Controls.Add(Me.Panel1)
        Me.plGroup.Controls.Add(Me.txtMessage)
        Me.plGroup.Location = New System.Drawing.Point(0, 368)
        Me.plGroup.Name = "plGroup"
        Me.plGroup.Size = New System.Drawing.Size(408, 100)
        Me.plGroup.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Location = New System.Drawing.Point(322, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(76, 48)
        Me.Panel1.TabIndex = 5
        '
        'plOption
        '
        Me.plOption.BackColor = System.Drawing.Color.AliceBlue
        Me.plOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plOption.Controls.Add(Me.btnClose)
        Me.plOption.Controls.Add(Me.btnSave)
        Me.plOption.Controls.Add(Me.cbServer)
        Me.plOption.Controls.Add(Me.txtPort)
        Me.plOption.Controls.Add(Me.txtId)
        Me.plOption.Controls.Add(Me.txtIp)
        Me.plOption.Controls.Add(Me.lblPort)
        Me.plOption.Controls.Add(Me.lblID)
        Me.plOption.Controls.Add(Me.lblIP)
        Me.plOption.Location = New System.Drawing.Point(69, 84)
        Me.plOption.Name = "plOption"
        Me.plOption.Size = New System.Drawing.Size(267, 213)
        Me.plOption.TabIndex = 5
        Me.plOption.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(144, 159)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "닫기"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(56, 159)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "설정"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbServer
        '
        Me.cbServer.AutoSize = True
        Me.cbServer.Location = New System.Drawing.Point(56, 137)
        Me.cbServer.Name = "cbServer"
        Me.cbServer.Size = New System.Drawing.Size(72, 16)
        Me.cbServer.TabIndex = 6
        Me.cbServer.Text = "서버실행"
        Me.cbServer.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(119, 110)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 21)
        Me.txtPort.TabIndex = 5
        Me.txtPort.Text = "2011"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(119, 77)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 21)
        Me.txtId.TabIndex = 4
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(119, 45)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(100, 21)
        Me.txtIp.TabIndex = 3
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(54, 113)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(50, 12)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "PORT : "
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(54, 80)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(28, 12)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID : "
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(54, 48)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(28, 12)
        Me.lblIP.TabIndex = 0
        Me.lblIP.Text = "IP : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 491)
        Me.Controls.Add(Me.plOption)
        Me.Controls.Add(Me.rtbText)
        Me.Controls.Add(Me.tsBar)
        Me.Controls.Add(Me.ssBar)
        Me.Controls.Add(Me.plGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "1:1 채팅"
        Me.ssBar.ResumeLayout(False)
        Me.ssBar.PerformLayout()
        Me.tsBar.ResumeLayout(False)
        Me.tsBar.PerformLayout()
        Me.plGroup.ResumeLayout(False)
        Me.plGroup.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.plOption.ResumeLayout(False)
        Me.plOption.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ssBar As StatusStrip
    Friend WithEvents tsBar As ToolStrip
    Friend WithEvents tsbtnConn As ToolStripButton
    Friend WithEvents tsbtnDisconn As ToolStripButton
    Friend WithEvents rtbText As RichTextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents plGroup As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents plOption As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cbServer As CheckBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtIp As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblIP As Label
    Friend WithEvents tsddbtnOption As ToolStripDropDownButton
    Friend WithEvents tsslblTime As ToolStripStatusLabel
    Friend WithEvents 설정ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 닫기ToolStripMenuItem As ToolStripMenuItem
End Class
