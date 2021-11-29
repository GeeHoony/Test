Public Class Form2
    Private Sub txtWord_TextChanged(sender As Object, e As EventArgs) Handles txtWord.TextChanged
        If Me.txtWord.Text = " " Then
            Me.btnOK.Enabled = False
        Else
            Me.btnOK.Enabled = True
        End If
    End Sub
End Class