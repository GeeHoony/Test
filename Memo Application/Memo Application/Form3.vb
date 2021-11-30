Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label3.Text = Me.Label3.Text & SystemInformation.UserName
        Me.Label4.Text = Me.Label4.Text & SystemInformation.ComputerName
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class