Public Class test
    Private Sub test_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim username As String = "ANDREW EBERLE"
        Dim password = Encryption.HashString("password")
        Dim salt = Encryption.GenereateSalt
        Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", password, salt))

        'TextBox1.Text = password
        'TextBox2.Text = salt
        'TextBox3.Text = hashedAndSalted

        Class1.InsertNewUser(username, hashedAndSalted, salt)
        Class1.Login1(username, "password")
    End Sub
End Class