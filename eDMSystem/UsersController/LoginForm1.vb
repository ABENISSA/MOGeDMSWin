Imports ShowMessage
Imports System.Data.SqlClient


Public Class LoginForm1
    Dim cc As New Class1
    Public sqlcon As New SqlConnection With {.ConnectionString = "Data Source=10.176.56.16;Initial Catalog=EDMS;Persist Security Info=True;User ID=edms; password=edms@2021"}

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Public Shared Sub UpdateNewUser(usrId As Integer, password As String, salt As String, usrName As String)


        Using sqlConn As New SqlConnection With {.ConnectionString = "Data Source=10.176.56.16;Initial Catalog=EDMS;Persist Security Info=True;User ID=edms; password=edms@2021"}
            Dim insertNewuser As String = "update ICT_admin set pass=@a1, salt=@a2 where id = @a3"
            Dim SqlCommand As New SqlCommand(insertNewuser, sqlConn)
            SqlCommand.Parameters.AddWithValue("@a1", password)
            SqlCommand.Parameters.AddWithValue("@a2", salt)
            SqlCommand.Parameters.AddWithValue("@a3", usrId)
            sqlConn.Open()
            SqlCommand.ExecuteNonQuery()
            MessageBox.Show(String.Format("{0} has been added to the system", usrName))
            Return
            sqlConn.Close()
        End Using


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'Dim username As String = Guna2ComboBox1.Text
        'Dim password = Encryption.HashString(Guna2TextBox1.Text.Trim)
        'Dim salt = Encryption.GenereateSalt
        'Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", password, salt))

        'UpdateNewUser(Guna2ComboBox1.SelectedValue, password, salt, Guna2ComboBox1.Text)


        Application.Exit()
        Me.Close()
        Me.Dispose()
    End Sub
    'Public Sub checkForUpdate()
    '    Dim newVersion As String = ""
    '    Dim cmd As New SqlCommand("SELECT TOP 1 [version] FROM [update] ORDER BY ID DESC", sqlcon)
    '    sqlcon.Open()
    '    newVersion = CStr(cmd.ExecuteScalar)
    '    sqlcon.Close()
    '    Dim currentVersion As String = Application.ProductVersion
    '    Label4.Text = currentVersion
    '    If newVersion > currentVersion Then
    '        MsgBox("يوجد نسخة جديدة")
    '    Else
    '        MsgBox("لا يوجد تحديث")
    '    End If
    'End Sub
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If cc.HasConnection = True Then
            cc.GetUsers(Guna2ComboBox1)
            Guna2TextBox1.Select()
            Guna2TextBox1.UseSystemPasswordChar = True
            'Label4.Text = Application.ProductVersion
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim dd As New Integer
        If cc.HasConnection = True Then
            dd = cc.Login(Guna2TextBox1, Guna2ComboBox1)
            If dd = 0 Then

                Dim frm As New LoginWarning
                frm.Location = New Point(CInt((WorkingArea.Width - frm.Width) / 2), 0) 'set popup form in middle of screen
                TransparentBGvb.ShowForm(frm)
                cc.LogInTrack(1, Guna2ComboBox1.Text.Trim)
                Exit Sub
            Else
                cc.LogInTrack(2, Guna2ComboBox1.Text.Trim)
                Me.Hide()
                Dim frm As New Form1
                frm.getValue(Guna2ComboBox1.Text)

                frm.ShowDialog()

                Me.Close()
                Me.Dispose()
            End If
        Else
            Exit Sub
        End If

    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dd As New Integer
            If cc.HasConnection = True Then
                dd = cc.Login(Guna2TextBox1, Guna2ComboBox1)
                If dd = 0 Then
                    'MsgBox("Sorry The user or password is not exist")
                    Dim frm As New LoginWarning
                    frm.Location = New Point(CInt((WorkingArea.Width - frm.Width) / 2), 0) 'set popup form in middle of screen
                    TransparentBGvb.ShowForm(frm)
                    cc.LogInTrack(1, Guna2ComboBox1.Text.Trim)
                    Exit Sub
                Else
                    cc.LogInTrack(2, Guna2ComboBox1.Text.Trim)
                    Module2.Number = Guna2ComboBox1.Text.Trim
                    Me.Hide()
                    Dim frm As New Form1
                    frm.getValue(Guna2ComboBox1.Text)

                    frm.ShowDialog()

                    Me.Close()
                    Me.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub Guna2TextBox1_IconRightClick(sender As Object, e As EventArgs) Handles Guna2TextBox1.IconRightClick
        If Guna2TextBox1.UseSystemPasswordChar = True Then
            Guna2TextBox1.IconRight = My.Resources.visibility
            Guna2TextBox1.UseSystemPasswordChar = False
        Else
            Guna2TextBox1.IconRight = My.Resources.visibility__1_
            Guna2TextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If MsgBox("هل تريد إغلاق المنظومة", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, Global.Microsoft.VisualBasic.MsgBoxStyle), "تأكيد طلب إغلاق") = MsgBoxResult.Yes Then
            Application.Exit()
            End
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        FRMInfo.ShowDialog()
    End Sub
End Class
