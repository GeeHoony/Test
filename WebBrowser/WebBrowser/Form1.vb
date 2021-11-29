Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ControlCheck() = True Then
            Dim strArray = New String() {Me.txtName.Text, Me.txtPhonNum.Text}
            Dim lvt = New ListViewItem(strArray)
            Me.lvCall.Items.Add(lvt)
            Me.txtName.Clear()
            Me.txtPhonNum.Clear()
        End If
    End Sub

    Private Function ControlCheck() As Boolean
        If (Me.txtName.Text = " ") Then
            MessageBox.Show("이름을 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtName.Focus()
            Return False

        ElseIf (Me.txtPhonNum.Text = " ") Then
            MessageBox.Show("전화번호를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtPhonNum.Focus()
            Return False

        Else
            Return True
        End If
    End Function

    Private Sub lvCall_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvCall.ColumnClick
        lvCall.ListViewItemSorter = New ListViewItemComparer(e.Column)
    End Sub
End Class

Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Public Sub New()
        col = 0
    End Sub

    Public Sub New(ByVal column As Integer)
        col = column
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Return [String].Compare(CType(x, ListViewItem).SubItems(col).Text,
        CType(y, ListViewItem).SubItems(col).Text)
    End Function
End Class
