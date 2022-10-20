Public Class Center
    Private Sub Center_Load(sender As Object, e As EventArgs) Handles Me.Load
        If TabControl1.SelectedIndex = 0 Then
            TabPage1.Controls.Clear()
            Dim u1 As New DEP
            TabPage1.Controls.Add(u1)
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            TabPage1.Controls.Clear()
            Dim u1 As New DEP
            TabPage1.Controls.Add(u1)
        ElseIf TabControl1.SelectedIndex = 1 Then
            TabPage2.Controls.Clear()
            Dim u1 As New COM
            TabPage2.Controls.Add(u1)
        End If
    End Sub
End Class
