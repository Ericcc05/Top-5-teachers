Public Class frmMain
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            picTeach1.Image = My.Resources.ms_green
        ElseIf ListBox1.SelectedIndex = 1 Then
            picTeach1.Image = My.Resources.ms_seiler
        ElseIf ListBox1.SelectedIndex = 2 Then
            picTeach1.Image = My.Resources.Mr__Nipert
        ElseIf ListBox1.SelectedIndex = 3 Then
            picTeach1.Image = My.Resources.christy
        ElseIf ListBox1.SelectedIndex = 4 Then
            picTeach1.Image = My.Resources.Armstrong
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picTeach3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
