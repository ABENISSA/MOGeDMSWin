Public Class locationEmp
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim c As New Class1
        c.AddLoc(Guna2TextBox1)
        Me.Close()
    End Sub
End Class