Public Class editCom
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim cc As New Class1
        cc.UpdateDepCom("COM_ID", "ICT_COM", "COM_NAME", "COM_NOTES", Guna2TextBox1, Guna2TextBox2, CInt(Guna2TextBox3.Text))
        Me.Close()
    End Sub
End Class