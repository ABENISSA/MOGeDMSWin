Public Class addNewDep
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim cc As New Class1
        cc.AddNewDepCom("ICT_DEP", "DEP_NAME", "DEP_NOTES", Guna2TextBox1, Guna2TextBox2)
        Me.Close()
    End Sub
End Class