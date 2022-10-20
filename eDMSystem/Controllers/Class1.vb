Imports System.Data.SqlClient
Public Class Class1

    Public sqlcon As New SqlConnection With {.ConnectionString = "Data Source=10.176.56.16;Initial Catalog=EDMS;Persist Security Info=True;User ID=edms; password=edms@2021"}
    'Public sqlcon As New SqlConnection With {.ConnectionString = "Data Source=localhost;Initial Catalog=EDMS;Integrated Security=True"}
    Public sqlcmd As New SqlCommand
    Public sqlda As SqlDataAdapter
    Public sqldataset As DataSet
    Private enterDate As Date = Nothing

    Public Shared Sub InsertNewUser(username As String, password As String, salt As String)
        If Not DuplicateUser(username) Then
            Using sqlConn As New SqlConnection With {.ConnectionString = "Data Source=10.176.56.16;Initial Catalog=EDMS;Persist Security Info=True;User ID=edms; password=edms@2021"}
                Dim insertNewuser As String = "INSERT INTO ICT_admin (user_name,pass,ustatus,salt) VALUES (@user,@pass,1,@salt)"
                Dim SqlCommand As New SqlCommand(insertNewuser, sqlConn)
                SqlCommand.Parameters.AddWithValue("@user", username)
                SqlCommand.Parameters.AddWithValue("@pass", password)
                SqlCommand.Parameters.AddWithValue("@salt", salt)
                sqlConn.Open()

                SqlCommand.ExecuteNonQuery()
                MessageBox.Show(String.Format("{0} has been added to the system", username))

                Return
                sqlConn.Close()
            End Using
        End If
        MessageBox.Show(String.Format("{0} is already in the system", username))
    End Sub
    Private Shared Function DuplicateUser(username As String) As Boolean
        Using sqlConn As New SqlConnection With {.ConnectionString = "Data Source=10.176.56.16;Initial Catalog=EDMS;Persist Security Info=True;User ID=edms; password=edms@2021"}
            Dim checkUserQuery As String = "SELECT COUNT(user_name) FROM ICT_admin WHERE user_name=@user"
            Dim slqCommand As New SqlCommand(checkUserQuery, sqlConn)
            slqCommand.Parameters.AddWithValue("@user", username)
            sqlConn.Open()
            Dim result As Integer = Convert.ToInt32(slqCommand.ExecuteScalar())
                If result > 0 Then
                    Return True
                Else
                    Return False
                End If
            sqlConn.Close()
        End Using
        Return True
    End Function
    Public Shared Sub Login1(username As String, password As String)
        Dim salt As String = ""

        Using sqlConn As New SqlConnection With {.ConnectionString = "Data Source=10.176.56.16;Initial Catalog=EDMS;Persist Security Info=True;User ID=edms; password=edms@2021"}
            sqlConn.Open()
            Dim readSaltQuery As String = "SELECT * FROM ICT_admin WHERE user_name=@user"
            Dim sqlCommand As New SqlCommand(readSaltQuery, sqlConn)
            sqlCommand.Parameters.AddWithValue("@user", username)


            Dim reader As SqlDataReader = sqlCommand.ExecuteReader()

            While reader.Read()
                    salt = reader("salt").ToString()
                End While
                reader.Close()

                Dim pass = Encryption.HashString(password)
                Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", pass, salt))

                Dim checkLoginQuery As String = "SELECT COUNT(*) FROM ICT_admin WHERE user_name=@user AND pass=@pass"
                Dim sqlCommand0 As New SqlCommand(checkLoginQuery, sqlConn)
                sqlCommand0.Parameters.AddWithValue("@user", username)
                sqlCommand0.Parameters.AddWithValue("@pass", hashedAndSalted)

            Dim results As Integer = Convert.ToInt32(sqlCommand0.ExecuteScalar())
                If results = 1 Then
                    MessageBox.Show("Welcome: " & username)
                Else
                    MessageBox.Show("ur username or password was inccorrect")
                End If
            sqlConn.Close()
        End Using



    End Sub
    Public Shared Async Function ConnectedToServerAsync(sqlConn As SqlConnection) As Task(Of Boolean)
        Try
            Await sqlConn.OpenAsync()

        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
        End Try
        Return CBool(sqlConn.State)
    End Function
    Public Function HasConnection() As Boolean
        Try
            sqlcon.Open()

            sqlcon.Close()
            Return True
        Catch ex As Exception
            MsgBox("لا يمكن الاتصال بالخادم", CType(MsgBoxStyle.Critical + vbOKOnly, MsgBoxStyle), "خطأ في الدخول")
        End Try
    End Function
    Public Sub GetUsers(cb As Guna.UI2.WinForms.Guna2ComboBox)
        Dim cmd As New SqlCommand("SELECT * FROM ICT_admin order by id", sqlcon)
        sqlcon.Open()
        cmd.ExecuteNonQuery()
        sqlcon.Close()
        Dim adp As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adp.Fill(dt)
        cb.DataSource = dt
        cb.ValueMember = "ID"
        cb.DisplayMember = "user_name"
    End Sub
    Public Function SHA256(ByVal Content As String) As String
        Dim MoLeCul3 As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = MoLeCul3.ComputeHash(ByteString)
        Dim FinalString As String = Nothing
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString
    End Function
    Public Function Login(a As Guna.UI2.WinForms.Guna2TextBox, cb As Guna.UI2.WinForms.Guna2ComboBox) As Integer
        Dim salt As String = ""
        Dim results As Integer = 0
        Dim cc As New Class1
        Dim DTUser As New DataTable
        If cc.HasConnection = True Then
            Using sqlConn As New SqlConnection With {.ConnectionString = "Data Source=10.176.56.16;Initial Catalog=EDMS;Persist Security Info=True;User ID=edms; password=edms@2021"}
                sqlConn.Open()
                Dim readSaltQuery As String = "SELECT * FROM [ICT_admin] WHERE [user_name]=@user"
                Dim sqlCommand As New SqlCommand(readSaltQuery, sqlConn)
                sqlCommand.Parameters.AddWithValue("@user", cb.Text)
                Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
                While reader.Read()
                    salt = reader("salt").ToString()
                End While
                reader.Close()
                Dim pass = Encryption.HashString(a.Text)
                Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", pass, salt))
                Dim checkLoginQuery As String = "SELECT COUNT(*) FROM [ICT_admin] WHERE [user_name]=@user AND [pass]=@pass AND [ustatus]=1"
                Dim sqlCommand0 As New SqlCommand(checkLoginQuery, sqlConn)
                sqlCommand0.Parameters.AddWithValue("@user", cb.Text)
                sqlCommand0.Parameters.AddWithValue("@pass", pass)
                results = Convert.ToInt32(sqlCommand0.ExecuteScalar())
                If results = 1 Then
                    'MessageBox.Show("Welcome: " & usename)

                    sqlConn.Close()
                Else
                    'MessageBox.Show("ur username or password was inccorrect")
                    sqlConn.Close()
                End If
            End Using
        End If
        Return results
    End Function
    Public Function GET_LAST_RECORED(tbl As String, orderfield As String, yearid As String, x As Guna.UI2.WinForms.Guna2TextBox) As Integer
        GET_LAST_RECORED = 0
        Dim id As Integer = 0
        Dim str = "select MAX(" & orderfield & ") from " & tbl & " where YearId = " & yearid
        Dim slqcmd As New SqlCommand(str, sqlcon)
        sqlcon.Open()
        Dim read1 As SqlDataReader
        read1 = slqcmd.ExecuteReader()
        While read1.Read()
            x.Text = (read1(0)).ToString
            If x.Text = "" Then
                x.Text = CStr(1)
            Else
                x.Text = CStr((CInt(x.Text) + (1)))
            End If
        End While
        sqlcon.Close()
    End Function
    Public Sub Yaercb(cb As Guna.UI2.WinForms.Guna2ComboBox, tbl As String)
        Dim orderfield As String = "YearNumber"
        Try
            Dim cmd As New SqlCommand("select * from " & tbl & " order by " & orderfield & " desc", sqlcon)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adp.Fill(dt)
            cb.DataSource = dt
            cb.ValueMember = "YearId"
            cb.DisplayMember = "YearNumber"
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub LocationCB(cb As Guna.UI2.WinForms.Guna2ComboBox, tbl As String)
        Dim orderfield As String = "name"
        Try
            Dim cmd As New SqlCommand("select * from " & tbl & " order by " & orderfield & " desc", sqlcon)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adp.Fill(dt)
            cb.DataSource = dt
            cb.ValueMember = "id"
            cb.DisplayMember = "name"
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub GetDep(cb As Guna.UI2.WinForms.Guna2ComboBox, tbl As String, field As String, value As String)
        Dim orderfield As String = field
        Dim valuefield As String = value
        Try
            Dim cmd As New SqlCommand("select * from " & tbl & " order by " & orderfield & " desc", sqlcon)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adp.Fill(dt)
            cb.DataSource = dt
            cb.ValueMember = value
            cb.DisplayMember = field

        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub InsertInInLetter(ByVal docElectRef As Guna.UI2.WinForms.Guna2TextBox, ByVal yearId As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docSubject As Guna.UI2.WinForms.Guna2TextBox, ByVal docDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docRecive As Guna.UI2.WinForms.Guna2DateTimePicker, ByVal docDep As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docCat As Guna.UI2.WinForms.Guna2ComboBox, ByVal docRef As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docStatus As Guna.UI2.WinForms.Guna2ComboBox, ByVal docComment As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docEmpNum As Guna.UI2.WinForms.Guna2TextBox, ByVal docPath As Guna.UI2.WinForms.Guna2TextBox, FileData As Byte())

        Try
            Dim cmd As New SqlCommand("INSERT INTO ICT_INTERNAL_INCOME
           ([DOC_REF]
           ,[YearId]
           ,[DOC_SUBJECT]
           ,[DOC_DATE]
           ,[RECIEVED_DAT]
           ,[ENTRY_DATE]
           ,[COME_FROM]
           ,[CAT]
           ,[RESPONSE_DOC_REF]
           ,[ACTION_DATE]
           ,[STATUS]
           ,[COMMENTS]
           ,[FILE_NO]
           ,[path1]
           ,[FileData])
     VALUES
           (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13,@a14,@a15)", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docElectRef.Text)
            cmd.Parameters.AddWithValue("@a2", yearId.SelectedValue)
            cmd.Parameters.AddWithValue("@a3", docSubject.Text)
            cmd.Parameters.AddWithValue("@a4", docDate.Value.Date)
            cmd.Parameters.AddWithValue("@a5", docRecive.Value.Date)
            cmd.Parameters.AddWithValue("@a6", System.DateTime.Now)
            cmd.Parameters.AddWithValue("@a7", docDep.Text)
            cmd.Parameters.AddWithValue("@a8", docCat.Text)
            cmd.Parameters.AddWithValue("@a9", docRef.Text)
            cmd.Parameters.AddWithValue("@a10", "")
            cmd.Parameters.AddWithValue("@a11", docStatus.Text)
            cmd.Parameters.AddWithValue("@a12", docComment.Text)
            cmd.Parameters.AddWithValue("@a13", docEmpNum.Text)
            cmd.Parameters.AddWithValue("@a14", docPath.Text)
            cmd.Parameters.AddWithValue("@a15", FileData)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try

    End Sub
    Public Sub InsertInOutLetter(ByVal docElectRef As Guna.UI2.WinForms.Guna2TextBox, ByVal yearId As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docSubject As Guna.UI2.WinForms.Guna2TextBox, ByVal docDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docSentDate As Guna.UI2.WinForms.Guna2DateTimePicker, ByVal docDep As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docCat As Guna.UI2.WinForms.Guna2ComboBox, ByVal docRef As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docStatus As Guna.UI2.WinForms.Guna2ComboBox, ByVal docComment As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docEmpNum As Guna.UI2.WinForms.Guna2TextBox, ByVal docPath As Guna.UI2.WinForms.Guna2TextBox, filedata As Byte())
        Try
            Dim cmd As New SqlCommand("INSERT INTO ICT_INTERNAL_OUTGO
           ([DOC_REF]
           ,[YearId]
           ,[DOC_SUBJECT]
           ,[DOC_DATE]
           ,[SENT_DATE]
           ,[ENTRY_DATE]
           ,[SENT_TO]
           ,[CAT]
           ,[RESPONSE_REQ]
           ,[RESPONSE_DOC_REF]
           ,[ACTION_DATE]
           ,[ACTUAL_ACTION_DATE]
           ,[COMMENTS]
           ,[FILE_NO]
           ,[path1]
           ,[UserName]
,[FileData])
     VALUES
           (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a15,@a9,@a10,@a16,@a11,@a12,@a13,@a14,@a17)", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docElectRef.Text)
            cmd.Parameters.AddWithValue("@a2", yearId.SelectedValue)
            cmd.Parameters.AddWithValue("@a3", docSubject.Text)
            cmd.Parameters.AddWithValue("@a4", docDate.Value.Date)
            cmd.Parameters.AddWithValue("@a5", docSentDate.Value.Date)
            cmd.Parameters.AddWithValue("@a6", System.DateTime.Now)
            cmd.Parameters.AddWithValue("@a7", docDep.Text)
            cmd.Parameters.AddWithValue("@a8", docCat.Text)
            cmd.Parameters.AddWithValue("@a15", "")
            cmd.Parameters.AddWithValue("@a9", docRef.Text)
            cmd.Parameters.AddWithValue("@a10", "")
            cmd.Parameters.AddWithValue("@a16", "")
            cmd.Parameters.AddWithValue("@a11", docComment.Text)
            cmd.Parameters.AddWithValue("@a12", docEmpNum.Text)
            cmd.Parameters.AddWithValue("@a13", docPath.Text)
            cmd.Parameters.AddWithValue("@a14", docStatus.Text)
            cmd.Parameters.AddWithValue("@a17", filedata)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub UpdateInInLetter(ByVal docElectRef As Guna.UI2.WinForms.Guna2TextBox, ByVal yearId As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docSubject As Guna.UI2.WinForms.Guna2TextBox, ByVal docDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docRecive As Guna.UI2.WinForms.Guna2DateTimePicker, ByVal docDep As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docCat As Guna.UI2.WinForms.Guna2ComboBox, ByVal docStatus As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docComment As Guna.UI2.WinForms.Guna2TextBox, ByVal docEmpNum As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docPath As Guna.UI2.WinForms.Guna2TextBox, ByVal docActionDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docId As Integer, filedata As Byte())
        Try
            Dim cmd As New SqlCommand("UPDATE [dbo].[ICT_INTERNAL_INCOME]
   SET [DOC_SUBJECT] = @a1
      ,[DOC_DATE] = @a2
      ,[RECIEVED_DAT] = @a3
      ,[ENTRY_DATE] = @a4
      ,[COME_FROM] = @a5
      ,[CAT] = @a6
      ,[RESPONSE_DOC_REF] = @a7
      ,[ACTION_DATE] = @a14
      ,[STATUS] = @a8
      ,[COMMENTS] = @a9
      ,[FILE_NO] = @a10
      ,[path1] = @a11
      ,[FileData] =@PDFFILE
 WHERE [ID] = @a12", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docSubject.Text)
            cmd.Parameters.AddWithValue("@a2", docDate.Value.Date)
            cmd.Parameters.AddWithValue("@a3", docRecive.Value.Date)
            cmd.Parameters.AddWithValue("@a4", System.DateTime.Now)
            cmd.Parameters.AddWithValue("@a5", docDep.Text)
            cmd.Parameters.AddWithValue("@a6", docCat.Text)
            cmd.Parameters.AddWithValue("@a7", docElectRef.Text)
            cmd.Parameters.AddWithValue("@a14", docActionDate.Value.Date)
            cmd.Parameters.AddWithValue("@a8", docStatus.Text)
            cmd.Parameters.AddWithValue("@a9", docComment.Text)
            cmd.Parameters.AddWithValue("@a10", docEmpNum.Text)
            cmd.Parameters.AddWithValue("@a11", docPath.Text)
            cmd.Parameters.AddWithValue("@a12", docId)
            cmd.Parameters.AddWithValue("@PDFFILE", filedata)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub UpdateOutInLetter(ByVal docElectRef As Guna.UI2.WinForms.Guna2TextBox, ByVal yearId As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docSubject As Guna.UI2.WinForms.Guna2TextBox, ByVal docDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docRecive As Guna.UI2.WinForms.Guna2DateTimePicker, ByVal docDep As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docCat As Guna.UI2.WinForms.Guna2ComboBox, ByVal docStatus As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docComment As Guna.UI2.WinForms.Guna2TextBox, ByVal docEmpNum As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docPath As Guna.UI2.WinForms.Guna2TextBox, ByVal docActionDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docId As Integer, filedate As Byte())
        Try
            Dim cmd As New SqlCommand("UPDATE [dbo].[ICT_EXTERNAL_INCOME]
   SET [DOC_SUBJECT] = @a1
      ,[DOC_DATE] = @a2
      ,[RECIEVED_DAT] = @a3
      ,[ENTRY_DATE] = @a4
      ,[COME_FROM] = @a5
      ,[CAT] = @a6
      ,[RESPONSE_DOC_REF] = @a7
      ,[ACTION_DATE] = @a14
      ,[STATUS] = @a8
      ,[COMMENTS] = @a9
      ,[FILE_NO] = @a10
      ,[path1] = @a11
,[FileData]=@PDFFILE
 WHERE [ID] = @a12", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docSubject.Text)
            cmd.Parameters.AddWithValue("@a2", docDate.Value.Date)
            cmd.Parameters.AddWithValue("@a3", docRecive.Value.Date)
            cmd.Parameters.AddWithValue("@a4", System.DateTime.Now)
            cmd.Parameters.AddWithValue("@a5", docDep.Text)
            cmd.Parameters.AddWithValue("@a6", docCat.Text)
            cmd.Parameters.AddWithValue("@a7", docElectRef.Text)
            cmd.Parameters.AddWithValue("@a14", docActionDate.Value.Date)
            cmd.Parameters.AddWithValue("@a8", docStatus.Text)
            cmd.Parameters.AddWithValue("@a9", docComment.Text)
            cmd.Parameters.AddWithValue("@a10", docEmpNum.Text)
            cmd.Parameters.AddWithValue("@a11", docPath.Text)
            cmd.Parameters.AddWithValue("@a12", docId)
            cmd.Parameters.AddWithValue("@PDFFILE", filedate)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Function FetchDataInIn(docRefId As Integer) As DataSet
        Dim dt As New DataSet
        Try
            Dim cmd As New SqlCommand("SELECT [ID]
      ,[DOC_REF]
      ,[YearId]
      ,[DOC_SUBJECT]
      ,[DOC_DATE]
      ,[RECIEVED_DAT]
      ,[ENTRY_DATE]
      ,[COME_FROM]
      ,[CAT]
      ,[RESPONSE_REQ]
      ,[RESPONSE_DOC_REF]
      ,[ACTION_DATE]
      ,[STATUS]
      ,[COMMENTS]
      ,[FILE_NO]
      ,[path1]
,[FileData]
  FROM [dbo].[ICT_INTERNAL_INCOME]
 WHERE [ID]= @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docRefId)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
        Return dt
    End Function
    Public Function FetchDataInOut(docRefId As Integer) As DataSet
        Dim dt As New DataSet
        Try
            Dim cmd As New SqlCommand("SELECT [ID]
      ,[DOC_REF]
      ,[YearId]
      ,[DOC_SUBJECT]
      ,[DOC_DATE]
      ,[SENT_DATE]
      ,[ENTRY_DATE]
      ,[SENT_TO]
      ,[CAT]
      ,[RESPONSE_REQ]
      ,[RESPONSE_DOC_REF]
      ,[ACTION_DATE]
      ,[ACTUAL_ACTION_DATE]
      ,[COMMENTS]
      ,[FILE_NO]
      ,[path1]
      ,[UserName]
      ,[User_EntryDate]
,[FileData]
  FROM [dbo].[ICT_INTERNAL_OUTGO]
  WHERE [ID]= @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docRefId)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
        Return dt
    End Function
    Public Function FetchDataOutIn(docRefId As Integer) As DataSet
        Dim dt As New DataSet
        Try
            Dim cmd As New SqlCommand("SELECT [ID]
      ,[DOC_REF]
      ,[YearId]
      ,[DOC_SUBJECT]
      ,[DOC_DATE]
      ,[RECIEVED_DAT]
      ,[ENTRY_DATE]
      ,[COME_FROM]
      ,[CAT]
      ,[RESPONSE_REQ]
      ,[RESPONSE_DOC_REF]
      ,[ACTION_DATE]
      ,[STATUS]
      ,[COMMENTS]
      ,[FILE_NO]
      ,[path1]
,[FileData]
  FROM [dbo].[ICT_EXTERNAL_INCOME]
 WHERE [ID]= @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docRefId)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
        Return dt
    End Function
    Public Sub UpdateInOutLetter(ByVal docElectRef As Guna.UI2.WinForms.Guna2TextBox, ByVal yearId As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docSubject As Guna.UI2.WinForms.Guna2TextBox, ByVal docDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docRecive As Guna.UI2.WinForms.Guna2DateTimePicker, ByVal docDep As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docCat As Guna.UI2.WinForms.Guna2ComboBox, ByVal docStatus As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docComment As Guna.UI2.WinForms.Guna2TextBox, ByVal docEmpNum As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docPath As Guna.UI2.WinForms.Guna2TextBox, ByVal docActionDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docId As Integer, filedate As Byte())
        Try
            Dim cmd As New SqlCommand("UPDATE [dbo].[ICT_INTERNAL_OUTGO]
   SET [DOC_SUBJECT] = @a1
      ,[DOC_DATE] = @a2
      ,[SENT_DATE] = @a3
      ,[ENTRY_DATE] = @a4
      ,[SENT_TO] = @a5
      ,[CAT] = @a6
      ,[RESPONSE_DOC_REF] = @a7
      ,[ACTION_DATE] = @a14
      ,[ACTUAL_ACTION_DATE] = @a15
      ,[RESPONSE_REQ] = @a16
      ,[UserName] = @a8
      ,[COMMENTS] = @a9
      ,[FILE_NO] = @a10
      ,[path1] = @a11
 ,[FileData]=@a19
 WHERE [ID] = @a12", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docSubject.Text)
            cmd.Parameters.AddWithValue("@a2", docDate.Value.Date)
            cmd.Parameters.AddWithValue("@a3", docRecive.Value.Date)
            cmd.Parameters.AddWithValue("@a4", System.DateTime.Now)
            cmd.Parameters.AddWithValue("@a5", docDep.Text)
            cmd.Parameters.AddWithValue("@a6", docCat.Text)
            cmd.Parameters.AddWithValue("@a7", docElectRef.Text)
            cmd.Parameters.AddWithValue("@a14", docActionDate.Value.Date)
            cmd.Parameters.AddWithValue("@a8", docStatus.Text)
            cmd.Parameters.AddWithValue("@a9", docComment.Text)
            cmd.Parameters.AddWithValue("@a10", docEmpNum.Text)
            cmd.Parameters.AddWithValue("@a11", docPath.Text)
            cmd.Parameters.AddWithValue("@a12", docId)
            cmd.Parameters.AddWithValue("@a15", "")
            cmd.Parameters.AddWithValue("@a16", "")
            cmd.Parameters.AddWithValue("@a19", filedate)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub InsertOutInLetter(ByVal docElectRef As Guna.UI2.WinForms.Guna2TextBox, ByVal yearId As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docSubject As Guna.UI2.WinForms.Guna2TextBox, ByVal docDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docRecive As Guna.UI2.WinForms.Guna2DateTimePicker, ByVal docDep As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docCat As Guna.UI2.WinForms.Guna2ComboBox, ByVal docRef As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docStatus As Guna.UI2.WinForms.Guna2ComboBox, ByVal docComment As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docEmpNum As Guna.UI2.WinForms.Guna2TextBox, ByVal docPath As Guna.UI2.WinForms.Guna2TextBox, filedate As Byte())
        Try
            Dim cmd As New SqlCommand("INSERT INTO ICT_EXTERNAL_INCOME
           ([DOC_REF]
           ,[YearId]
           ,[DOC_SUBJECT]
           ,[DOC_DATE]
           ,[RECIEVED_DAT]
           ,[ENTRY_DATE]
           ,[COME_FROM]
           ,[CAT]
           ,[RESPONSE_REQ]
           ,[RESPONSE_DOC_REF]
           ,[ACTION_DATE]
           ,[STATUS]
           ,[COMMENTS]
           ,[FILE_NO]
           ,[path1]
,[FileData])
     VALUES
           (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a15,@a9,@a10,@a11,@a12,@a13,@a14,@PDFILE)", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docElectRef.Text)
            cmd.Parameters.AddWithValue("@a2", yearId.SelectedValue)
            cmd.Parameters.AddWithValue("@a3", docSubject.Text)
            cmd.Parameters.AddWithValue("@a4", docDate.Value.Date)
            cmd.Parameters.AddWithValue("@a5", docRecive.Value.Date)
            cmd.Parameters.AddWithValue("@a6", System.DateTime.Now)
            cmd.Parameters.AddWithValue("@a7", docDep.Text)
            cmd.Parameters.AddWithValue("@a8", docCat.Text)
            cmd.Parameters.AddWithValue("@a15", "")
            cmd.Parameters.AddWithValue("@a9", docRef.Text)
            cmd.Parameters.AddWithValue("@a10", "")
            cmd.Parameters.AddWithValue("@a11", docStatus.Text)
            cmd.Parameters.AddWithValue("@a12", docComment.Text)
            cmd.Parameters.AddWithValue("@a13", docEmpNum.Text)
            cmd.Parameters.AddWithValue("@a14", docPath.Text)
            cmd.Parameters.AddWithValue("@PDFILE", filedate)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub InsertOutOutLetter(ByVal docElectRef As Guna.UI2.WinForms.Guna2TextBox, ByVal yearId As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docSubject As Guna.UI2.WinForms.Guna2TextBox, ByVal docDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docSentDate As Guna.UI2.WinForms.Guna2DateTimePicker, ByVal docDep As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docCat As Guna.UI2.WinForms.Guna2ComboBox, ByVal docRef As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docStatus As Guna.UI2.WinForms.Guna2ComboBox, ByVal docComment As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docEmpNum As Guna.UI2.WinForms.Guna2TextBox, ByVal docPath As Guna.UI2.WinForms.Guna2TextBox, filedata As Byte())
        Try
            Dim cmd As New SqlCommand("INSERT INTO ICT_EXTERNAL_OUTGO
           ([DOC_REF]
           ,[YearId]
           ,[DOC_SUBJECT]
           ,[DOC_DATE]
           ,[SENT_DATE]
           ,[ENTRY_DATE]
           ,[SENT_TO]
           ,[CAT]
           ,[RESPONSE_REQ]
           ,[RESPONSE_DOC_REF]
           ,[ACTION_DATE]
           ,[STATUS]
           ,[COMMENTS]
           ,[FILE_NO]
           ,[path1]
,[FileData])
     VALUES
           (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13,@a14,@a15,@PDFFILE)", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docElectRef.Text)
            cmd.Parameters.AddWithValue("@a2", yearId.SelectedValue)
            cmd.Parameters.AddWithValue("@a3", docSubject.Text)
            cmd.Parameters.AddWithValue("@a4", docDate.Value.Date)
            cmd.Parameters.AddWithValue("@a5", docSentDate.Value.Date)
            cmd.Parameters.AddWithValue("@a6", System.DateTime.Now)
            cmd.Parameters.AddWithValue("@a7", docDep.Text)
            cmd.Parameters.AddWithValue("@a8", docCat.Text)
            cmd.Parameters.AddWithValue("@a9", "")
            cmd.Parameters.AddWithValue("@a10", docRef.Text)
            cmd.Parameters.AddWithValue("@a11", "")
            cmd.Parameters.AddWithValue("@a12", docStatus.Text)
            cmd.Parameters.AddWithValue("@a13", docComment.Text)
            cmd.Parameters.AddWithValue("@a14", docEmpNum.Text)
            cmd.Parameters.AddWithValue("@a15", docPath.Text)
            cmd.Parameters.AddWithValue("@PDFFILE", filedata)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub UpdateOutOutLetter(ByVal docElectRef As Guna.UI2.WinForms.Guna2TextBox, ByVal yearId As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docSubject As Guna.UI2.WinForms.Guna2TextBox, ByVal docDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docRecive As Guna.UI2.WinForms.Guna2DateTimePicker, ByVal docDep As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docCat As Guna.UI2.WinForms.Guna2ComboBox, ByVal docStatus As Guna.UI2.WinForms.Guna2ComboBox,
     ByVal docComment As Guna.UI2.WinForms.Guna2TextBox, ByVal docEmpNum As Guna.UI2.WinForms.Guna2TextBox,
     ByVal docPath As Guna.UI2.WinForms.Guna2TextBox, ByVal docActionDate As Guna.UI2.WinForms.Guna2DateTimePicker,
     ByVal docId As Integer, filedata As Byte())
        Try
            Dim cmd As New SqlCommand("UPDATE [dbo].[ICT_EXTERNAL_OUTGO]
   SET [DOC_SUBJECT] = @a1
      ,[DOC_DATE] = @a2
      ,[SENT_DATE] = @a3
      ,[ENTRY_DATE] = @a4
      ,[SENT_TO] = @a5
      ,[CAT] = @a6
      ,[RESPONSE_DOC_REF] = @a7
      ,[ACTION_DATE] = @a14
      ,[RESPONSE_REQ] = @a16
      ,[STATUS] = @a8
      ,[COMMENTS] = @a9
      ,[FILE_NO] = @a10
      ,[path1] = @a11
,[FileData]=@PDFFILE
 WHERE [ID] = @a12", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docSubject.Text)
            cmd.Parameters.AddWithValue("@a2", docDate.Value.Date)
            cmd.Parameters.AddWithValue("@a3", docRecive.Value.Date)
            cmd.Parameters.AddWithValue("@a4", System.DateTime.Now)
            cmd.Parameters.AddWithValue("@a5", docDep.Text)
            cmd.Parameters.AddWithValue("@a6", docCat.Text)
            cmd.Parameters.AddWithValue("@a7", docElectRef.Text)
            cmd.Parameters.AddWithValue("@a14", docActionDate.Value.Date)
            cmd.Parameters.AddWithValue("@a8", docStatus.Text)
            cmd.Parameters.AddWithValue("@a9", docComment.Text)
            cmd.Parameters.AddWithValue("@a10", docEmpNum.Text)
            cmd.Parameters.AddWithValue("@a11", docPath.Text)
            cmd.Parameters.AddWithValue("@a12", docId)
            cmd.Parameters.AddWithValue("@a16", "")
            cmd.Parameters.AddWithValue("@PDFFILE", filedata)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Function FetchDataOutOut(docRefId As Integer) As DataSet
        Dim dt As New DataSet
        Try
            Dim cmd As New SqlCommand("SELECT [ID]
      ,[DOC_REF]
      ,[YearId]
      ,[DOC_SUBJECT]
      ,[DOC_DATE]
      ,[SENT_DATE]
      ,[ENTRY_DATE]
      ,[SENT_TO]
      ,[CAT]
      ,[RESPONSE_REQ]
      ,[RESPONSE_DOC_REF]
      ,[ACTION_DATE]
      ,[STATUS]
      ,[COMMENTS]
      ,[FILE_NO]
      ,[path1]
      ,[UserName]
      ,[User_EntryDate]
,[FileData]
  FROM [dbo].[ICT_EXTERNAL_OUTGO]
  WHERE [ID]= @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docRefId)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
        Return dt
    End Function
    Public Sub GetEmpDocPdf(a As Integer, grid As DataGridView)
        Dim dt As New DataTable
        Try
            Dim cmd As New SqlCommand("SELECT ICT_Type.type_name [FILE TYPE], ICT_DOC_TYPE.path [PATH], ICT_DOC_TYPE.rev [REV.]  from ICT_DOC_TYPE,ICT_Type where ICT_DOC_TYPE.type_id =ICT_Type.id and ICT_DOC_TYPE.doc_id = @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", a)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
            grid.DataSource = Nothing
            grid.Rows.Clear()
            grid.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub GetEmpDoc(a As Integer, grid As DataGridView, d As DataTable)
        Dim dt As New DataTable
        Try
            Dim cmd As New SqlCommand("SELECT ICT_Type.type_name [FILE TYPE], ICT_DOC_TYPE.path [PATH], ICT_DOC_TYPE.rev [REV.]  from ICT_DOC_TYPE,ICT_Type where ICT_DOC_TYPE.type_id =ICT_Type.id and ICT_DOC_TYPE.doc_id = @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", a)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    grid.Rows.Add(dt.Rows(i)("FILE TYPE").ToString(), dt.Rows(i)("PATH").ToString(), dt.Rows(i)("REV.").ToString())
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
        Try
            Dim t As New DataTable
            Dim cmd As New SqlCommand(" SELECT [type_id],[path],[rev] FROM [dbo].[ICT_DOC_TYPE] WHERE [doc_id] = @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", a)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(t)
            If t.Rows.Count <> 0 Then
                For i As Integer = 0 To t.Rows.Count - 1
                    d.Rows.Add(t.Rows(i)("type_id").ToString(), t.Rows(i)("path").ToString(), t.Rows(i)("rev").ToString())
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Function FetchEmpData(docRefId As Integer) As DataSet
        Dim dt As New DataSet
        Try
            Dim cmd As New SqlCommand("SELECT [ID] ,[EMP_NAME] ,[TYPE] ,[LOCATION] ,[JOB_DESC],[EMP_NUM] ,[DOC_DATE],[DEGREE] ,[ENTRY_DATE], [COMMENTS], [Qua] FROM [dbo].[ICT_EMPLOYEES] WHERE [ID]= @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", docRefId)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
        Return dt
    End Function
    Public Sub EmpDocTypecb(cb As Guna.UI2.WinForms.Guna2ComboBox, tbl As String)
        Dim orderfield As String = "type_name"
        Try
            Dim cmd As New SqlCommand("select * from " & tbl & " order by " & orderfield & " desc", sqlcon)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adp.Fill(dt)
            cb.DataSource = dt
            cb.ValueMember = "id"
            cb.DisplayMember = "type_name"
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub InsertEmployees(ByVal EmpNum As Guna.UI2.WinForms.Guna2TextBox, ByVal location As Guna.UI2.WinForms.Guna2ComboBox,
   ByVal eveDate As Guna.UI2.WinForms.Guna2DateTimePicker,
   ByVal empName As Guna.UI2.WinForms.Guna2TextBox, ByVal jobDesc As Guna.UI2.WinForms.Guna2TextBox,
   ByVal degree As Guna.UI2.WinForms.Guna2TextBox, dt As DataTable,
   ByVal DegDate As Guna.UI2.WinForms.Guna2DateTimePicker, ByVal Quo As Guna.UI2.WinForms.Guna2TextBox, ByVal commants As Guna.UI2.WinForms.Guna2TextBox)
        Try
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[ICT_EMPLOYEES]
           ([EMP_NUM]
           ,[YearId]
           ,[EMP_NAME]
           ,[TYPE]
           ,[LOCATION]
           ,[JOB_DESC]
           ,[DOC_DATE]
           ,[DEGREE]
           ,[ENTRY_DATE]
           ,[Qua]
           ,[COMMENTS])
     VALUES
           (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11)", sqlcon)
            cmd.Parameters.AddWithValue("@a1", EmpNum.Text)
            cmd.Parameters.AddWithValue("@a2", 4)
            cmd.Parameters.AddWithValue("@a3", empName.Text)
            cmd.Parameters.AddWithValue("@a4", "")
            cmd.Parameters.AddWithValue("@a5", location.Text)
            cmd.Parameters.AddWithValue("@a6", jobDesc.Text)
            cmd.Parameters.AddWithValue("@a7", eveDate.Value.Date)
            cmd.Parameters.AddWithValue("@a8", degree.Text)
            cmd.Parameters.AddWithValue("@a9", DegDate.Value.Date)
            cmd.Parameters.AddWithValue("@a10", Quo.Text)
            cmd.Parameters.AddWithValue("@a11", commants.Text)


            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Dim id As Integer = 0
        Try
            Dim cmd As New SqlCommand("SELECT ID FROM ICT_EMPLOYEES WHERE EMP_NUM = @a1 ", sqlcon)
            cmd.Parameters.AddWithValue("@a1", EmpNum.Text)
            sqlcon.Open()
            id = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Try
            For i As Integer = 0 To dt.Rows.Count() - 1
                Dim c As New SqlCommand("insert into ICT_DOC_TYPE (doc_id,type_id,path,rev) values (@a1,@a2,@a3,@a4)", sqlcon)
                c.Parameters.AddWithValue("@a1", id)
                c.Parameters.AddWithValue("@a2", dt.Rows(i)("type").ToString)
                c.Parameters.AddWithValue("@a3", dt.Rows(i)("path").ToString)
                c.Parameters.AddWithValue("@a4", dt.Rows(i)("rev").ToString)
                sqlcon.Open()
                c.ExecuteNonQuery()
                sqlcon.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub
    Public Function CheckEmpNum(a As Guna.UI2.WinForms.Guna2TextBox) As Integer
        Dim flg As Integer = 0
        Try
            Dim cmd As New SqlCommand("SELECT [EMP_NUM] FROM [dbo].[ICT_EMPLOYEES] WHERE [EMP_NUM]= @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", a.Text)
            sqlcon.Open()
            flg = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
        Return flg
    End Function
    Public Function UpdateEmpDoc(empNum As Guna.UI2.WinForms.Guna2TextBox,
                            ByVal empName As Guna.UI2.WinForms.Guna2TextBox, ByVal location As Guna.UI2.WinForms.Guna2ComboBox, ByVal eveDate As Guna.UI2.WinForms.Guna2DateTimePicker,
                            ByVal jobDesc As Guna.UI2.WinForms.Guna2TextBox, ByVal degree As Guna.UI2.WinForms.Guna2TextBox, ByVal empId As Integer) As Integer
        Dim flg As Integer = 0
        Try
            Dim cmd As New SqlCommand("UPDATE [dbo].[ICT_EMPLOYEES]
      SET [EMP_NUM] = @a1
         ,[YearId] = @a2
         ,[EMP_NAME] = @a3
         ,[TYPE] = @a4
         ,[LOCATION] = @a5
         ,[JOB_DESC] = @a6
         ,[DOC_DATE] = @a7
         ,[DEGREE] = @a8
         ,[ENTRY_DATE] = @a9
         ,[COMMENTS] = @a10
         ,[UserName] = @a11
         ,[User_EntryDate] = @a12
    WHERE [ID] = @a13", sqlcon)
            cmd.Parameters.AddWithValue("@a1", empNum.Text)
            cmd.Parameters.AddWithValue("@a2", 4)
            cmd.Parameters.AddWithValue("@a3", empName.Text)
            cmd.Parameters.AddWithValue("@a4", "")
            cmd.Parameters.AddWithValue("@a5", location.Text)
            cmd.Parameters.AddWithValue("@a6", jobDesc.Text)
            cmd.Parameters.AddWithValue("@a7", eveDate.Value.Date)
            cmd.Parameters.AddWithValue("@a8", degree.Text)
            cmd.Parameters.AddWithValue("@a9", System.DateTime.Now)
            cmd.Parameters.AddWithValue("@a10", "")
            cmd.Parameters.AddWithValue("@a11", "")
            cmd.Parameters.AddWithValue("@a12", "")
            cmd.Parameters.AddWithValue("@a13", empId)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            flg = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
        Return flg
    End Function
    Public Sub UpdateEmpDocTable(ByVal empId As Integer, ddt As DataTable)
        Dim flg As Integer = 0
        Try
            If ddt.Rows.Count = 0 Then
                Try
                    Dim c As New SqlCommand("delete [dbo].[ICT_DOC_TYPE] where [doc_id] =@a1", sqlcon)
                    c.Parameters.AddWithValue("@a1", empId)
                    sqlcon.Open()
                    c.ExecuteNonQuery()
                    sqlcon.Close()
                    flg = 1
                Catch ex As Exception
                    MessageBox.Show(ex.Message & " - " & ex.Source)
                    sqlcon.Close()
                    Exit Sub
                End Try
            Else
                Dim ddddsss As New DataSet
                For i As Integer = 0 To ddt.Rows.Count() - 1
                    Dim c As New SqlCommand("SELECT * FROM ICT_DOC_TYPE WHERE doc_id = @a1 and type_id=@a2 and path=@a3 and rev = @a4", sqlcon)
                    c.Parameters.AddWithValue("@a1", empId)
                    c.Parameters.AddWithValue("@a2", ddt.Rows(i)("type").ToString)
                    c.Parameters.AddWithValue("@a3", ddt.Rows(i)("path").ToString)
                    c.Parameters.AddWithValue("@a4", ddt.Rows(i)("rev").ToString)
                    sqlcon.Open()
                    c.ExecuteNonQuery()
                    sqlcon.Close()
                    Dim adp As New SqlDataAdapter(c)
                    adp.Fill(ddddsss)
                Next
                If ddddsss.Tables(0).Rows.Count <> 0 Then
                    For b As Integer = 0 To ddddsss.Tables(0).Rows.Count - 1
                        ddt.Rows.RemoveAt(0)
                    Next
                End If
                If ddt.Rows.Count = 0 Then
                    flg = 1
                    Exit Sub
                ElseIf ddt.Rows.Count <> 0 Then
                    Try
                        For i As Integer = 0 To ddt.Rows.Count() - 1
                            Dim c As New SqlCommand("insert into ICT_DOC_TYPE (doc_id,type_id,path,rev) values (@a1,@a2,@a3,@a4)", sqlcon)
                            c.Parameters.AddWithValue("@a1", empId)
                            c.Parameters.AddWithValue("@a2", ddt.Rows(i)("type").ToString)
                            c.Parameters.AddWithValue("@a3", ddt.Rows(i)("path").ToString)
                            c.Parameters.AddWithValue("@a4", ddt.Rows(i)("rev").ToString)
                            sqlcon.Open()
                            c.ExecuteNonQuery()
                            sqlcon.Close()
                        Next
                        flg = 1
                    Catch ex As Exception
                        MessageBox.Show(ex.Message & " - " & ex.Source)
                        sqlcon.Close()
                        Exit Sub
                    End Try
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub
    Public Sub DeleteLetter(idremove As Integer, tbl As String, ppp As Integer, noti As NotifyIcon)
        Dim Res As String = ""
        Dim filepath As String = ""
        'Try
        '    Dim cmd As New SqlCommand("select path1 from " & tbl & " where id =@a1", sqlcon)
        '    cmd.Parameters.AddWithValue("@a1", idremove)
        '    sqlcon.Open()
        '    Res = cmd.ExecuteScalar()
        '    sqlcon.Close()
        '    Dim p As New pathClass
        '    Dim path As String = Nothing
        '    path = p.getPath(ppp)
        '    filepath = path + Res
        '    If Res <> Nothing Then
        '        System.IO.File.Delete(filepath + ".pdf")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message & " - " & ex.Source)
        '    sqlcon.Close()
        '    Exit Sub
        'End Try
        Try
            Dim cmd As New SqlCommand("delete " & tbl & " where id = @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", idremove)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            noti.BalloonTipIcon = ToolTipIcon.Warning
            noti.BalloonTipText = "تم الحذف المستند بنجاح "
            noti.ShowBalloonTip(1)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub
    Public Sub DeleteEmpData(idremove As Integer)
        Dim filepath As String = ""
        Dim p As New pathClass
        Dim path As String = Nothing
        Try
            Dim cmd As New SqlCommand("SELECT path FROM [dbo].[ICT_DOC_TYPE] where doc_id = @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", idremove)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adp.Fill(dt)
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    path = p.getPath(5)
                    filepath = path + dt.Rows(i)("path").ToString
                    System.IO.File.Delete(filepath + ".pdf")
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Try
            Dim cmd As New SqlCommand("delete [dbo].[ICT_DOC_TYPE] where doc_id = @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", idremove)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Try
            Dim cmd As New SqlCommand("delete ICT_EMPLOYEES where id = @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", idremove)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Alert("تم مسح بيانات الموظف بنجاح", frmAlert.alertTypeEnum.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub
    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
        'f.ShowDialog()
    End Sub
    Public Sub AddDocType(a As Guna.UI2.WinForms.Guna2TextBox)
        Try
            Dim cmd As New SqlCommand("insert into ICT_Type (type_name) values (@a1)", sqlcon)
            cmd.Parameters.AddWithValue("@a1", a.Text)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub
    Public Sub AddLoc(a As Guna.UI2.WinForms.Guna2TextBox)
        Try
            Dim cmd As New SqlCommand("insert into ICT_LOC (name) values (@a1)", sqlcon)
            cmd.Parameters.AddWithValue("@a1", a.Text)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub AddNewDepCom(tbl As String, name As String, notes As String, text1 As Guna.UI2.WinForms.Guna2TextBox, text2 As Guna.UI2.WinForms.Guna2TextBox)
        If text2.Text = Nothing Then
            text2.Text = ""
        End If
        Try
            Dim cmd As New SqlCommand("INSERT INTO " & tbl & "
           (" & name & "
           ," & notes & ")
          VALUES
                (@a1
                ,@a2)", sqlcon)
            cmd.Parameters.AddWithValue("@a1", text1.Text)
            cmd.Parameters.AddWithValue("@a2", text2.Text)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub UpdateDepCom(colid As String, tbl As String, name As String, notes As String, text1 As Guna.UI2.WinForms.Guna2TextBox, text2 As Guna.UI2.WinForms.Guna2TextBox, id As Integer)
        Try
            Dim cmd As New SqlCommand("UPDATE " & tbl & "
   SET " & name & " = @a1
      ," & notes & " = @a2
 WHERE " & colid & "=@a3", sqlcon)
            cmd.Parameters.AddWithValue("@a1", text1.Text)
            cmd.Parameters.AddWithValue("@a2", text2.Text)
            cmd.Parameters.AddWithValue("@a3", id)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub DeleteDepCom(tbl As String, id As String, idremove As Integer)
        Try
            Dim cmd As New SqlCommand("delete " & tbl & " where " & id & " = @a1", sqlcon)
            cmd.Parameters.AddWithValue("@a1", idremove)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Alert("تم مسح البيانات بنجاح ", frmAlert.alertTypeEnum.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try

    End Sub
    Public Function GetEmpByLocation() As DataTable
        Dim dt As New DataTable
        Try
            Dim cmd As New SqlCommand("SELECT COUNT(dbo.ICT_EMPLOYEES.ID) * 1.0/ (SELECT COUNT(*) FROM dbo.ICT_EMPLOYEES) as 'Total', dbo.ICT_LOC.name AS 'Location'
                                       FROM dbo.ICT_EMPLOYEES INNER JOIN
                                       dbo.ICT_LOC ON dbo.ICT_EMPLOYEES.LOCATION = dbo.ICT_LOC.name
                                       GROUP BY dbo.ICT_LOC.name", sqlcon)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
        Return dt
    End Function
    Public Function GetAlletter() As DataTable
        Dim ddd As New DataTable
        Try
            Dim cmd As New SqlCommand("select
 ( select count([ICT_INTERNAL_INCOME].id) from [dbo].[ICT_INTERNAL_INCOME] ) + ( select count([ICT_INTERNAL_OUTGO].id) from [dbo].[ICT_INTERNAL_OUTGO] ) as total_in, 
 ( select count([ICT_EXTERNAL_INCOME].ID) from  [dbo].[ICT_EXTERNAL_INCOME])+ ( select count([ICT_EXTERNAL_OUTGO].ID) from [dbo].[ICT_EXTERNAL_OUTGO] ) as total_rows
", sqlcon)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(ddd)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
        Return ddd
    End Function
    Public Sub GetOutInByCom(grid As DataGridView)
        Dim dt As New DataTable
        Try
            Dim cmd As New SqlCommand("SELECT  COUNT(dbo.ICT_EXTERNAL_INCOME.ID) AS [عدد الرسائل], dbo.ICT_COM.COM_NAME AS [الجيهة الخارجية]
FROM            dbo.ICT_EXTERNAL_INCOME INNER JOIN
                         dbo.ICT_COM ON dbo.ICT_EXTERNAL_INCOME.COME_FROM = dbo.ICT_COM.COM_NAME
GROUP BY dbo.ICT_COM.COM_NAME", sqlcon)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
            grid.DataSource = Nothing
            grid.Rows.Clear()
            grid.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub GetOutOutByCom(grid As DataGridView)
        Dim dt As New DataTable
        Try
            Dim cmd As New SqlCommand("SELECT        COUNT(dbo.ICT_EXTERNAL_OUTGO.ID) AS [عدد الرسائل], dbo.ICT_COM.COM_NAME AS [الجيهة الخارجية]
FROM            dbo.ICT_EXTERNAL_OUTGO INNER JOIN
                         dbo.ICT_COM ON dbo.ICT_EXTERNAL_OUTGO.SENT_TO = dbo.ICT_COM.COM_NAME
GROUP BY dbo.ICT_COM.COM_NAME", sqlcon)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
            grid.DataSource = Nothing
            grid.Rows.Clear()
            grid.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub GetInInByCom(grid As DataGridView)
        Dim dt As New DataTable
        Try
            Dim cmd As New SqlCommand("sELECT        dbo.ICT_DEP.DEP_NAME AS [الادارة], COUNT(dbo.ICT_INTERNAL_INCOME.ID) AS [عدد الرسائل]
FROM            dbo.ICT_INTERNAL_INCOME INNER JOIN
                         dbo.ICT_DEP ON dbo.ICT_INTERNAL_INCOME.COME_FROM = dbo.ICT_DEP.DEP_NAME
GROUP BY dbo.ICT_DEP.DEP_NAME", sqlcon)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
            grid.DataSource = Nothing
            grid.Rows.Clear()
            grid.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub GetInOutByCom(grid As DataGridView)
        Dim dt As New DataTable
        Try
            Dim cmd As New SqlCommand("SELECT        dbo.ICT_DEP.DEP_NAME AS [الادارة], COUNT(dbo.ICT_INTERNAL_OUTGO.ID) AS [عدد الرسائل]
FROM            dbo.ICT_INTERNAL_OUTGO INNER JOIN
                         dbo.ICT_DEP ON ICT_INTERNAL_OUTGO.SENT_TO = dbo.ICT_DEP.DEP_NAME
GROUP BY dbo.ICT_DEP.DEP_NAME", sqlcon)
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
            grid.DataSource = Nothing
            grid.Rows.Clear()
            grid.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try
    End Sub
    Public Sub GetCompanyDep(a As Label, b As Label)
        Try
            Dim cmd As New SqlCommand("select count(dep_id) from ICT_DEP", sqlcon)
            sqlcon.Open()
            a.Text = CStr(cmd.ExecuteScalar())
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Try
            Dim cmd As New SqlCommand("select count(com_id) from ICT_COM", sqlcon)
            sqlcon.Open()
            b.Text = CStr(cmd.ExecuteScalar())
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub
    Public Sub GetEmp(a As Label)
        Try
            Dim cmd As New SqlCommand("select count(ID) from ICT_EMPLOYEES", sqlcon)
            sqlcon.Open()
            a.Text = CStr(cmd.ExecuteScalar())
            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub
    Public Sub GetIn(a As Label, b As Label)
        Dim aa As Integer = 0
        Dim bb As Integer = 0
        Try
            Dim cmd As New SqlCommand("select count(ID) from ICT_INTERNAL_INCOME", sqlcon)
            sqlcon.Open()
            aa = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            a.Text = CStr(aa)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Try
            Dim cmd As New SqlCommand("select count(id) from ICT_INTERNAL_OUTGO", sqlcon)
            sqlcon.Open()
            bb = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            b.Text = CStr(bb)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub
    Public Sub GetOut(a As Label, b As Label)
        Dim aa As Integer = 0
        Dim bb As Integer = 0

        Try
            Dim cmd As New SqlCommand("select count(ID) from ICT_EXTERNAL_INCOME", sqlcon)
            sqlcon.Open()
            aa = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            a.Text = CStr(aa)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Try
            Dim cmd As New SqlCommand("select count(id) from ICT_EXTERNAL_OUTGO", sqlcon)
            sqlcon.Open()
            bb = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            b.Text = CStr(bb)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub
    Public Sub TotalStatusInIn(label1 As MetroFramework.Controls.MetroLabel, label2 As MetroFramework.Controls.MetroLabel, label3 As MetroFramework.Controls.MetroLabel)
        Dim clo As Integer = 0
        Dim pen As Integer = 0
        Dim total As Integer = 0
        Try
            Dim cmd As New SqlCommand("select count(ID) from [dbo].[ICT_INTERNAL_INCOME] where [dbo].[ICT_INTERNAL_INCOME].STATUS = N'مغلق'", sqlcon)
            sqlcon.Open()
            clo = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            label2.Text = CStr(clo)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Try
            Dim cmd As New SqlCommand("select count(ID) from [dbo].[ICT_INTERNAL_INCOME] where [dbo].[ICT_INTERNAL_INCOME].STATUS = N'في الإنتظار'", sqlcon)
            sqlcon.Open()
            pen = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            label1.Text = CStr(pen)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        total = clo + pen
        label3.Text = CStr(total)
    End Sub
    Public Sub TotalCadInOut(label1 As MetroFramework.Controls.MetroLabel, label2 As MetroFramework.Controls.MetroLabel, label3 As MetroFramework.Controls.MetroLabel)
        Dim Ca As Integer = 0
        Dim Nor As Integer = 0
        Dim total As Integer = 0
        Try
            Dim cmd As New SqlCommand("select count(ID) from [dbo].[ICT_INTERNAL_OUTGO] where [dbo].[ICT_INTERNAL_OUTGO].CAT = N'عادي'", sqlcon)
            sqlcon.Open()
            Ca = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            label2.Text = CStr(Ca)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Try
            Dim cmd As New SqlCommand("select count(ID) from [dbo].[ICT_INTERNAL_OUTGO] where [dbo].[ICT_INTERNAL_OUTGO].CAT = N'سري'", sqlcon)
            sqlcon.Open()
            Nor = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            label1.Text = CStr(Nor)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        total = Ca + Nor
        label3.Text = CStr(total)
    End Sub
    Public Sub TotalStatusOutIn(label1 As MetroFramework.Controls.MetroLabel, label2 As MetroFramework.Controls.MetroLabel, label3 As MetroFramework.Controls.MetroLabel)
        Dim clo As Integer = 0
        Dim pen As Integer = 0
        Dim total As Integer = 0
        Try
            Dim cmd As New SqlCommand("select count(ID) from [dbo].ICT_EXTERNAL_INCOME where [dbo].ICT_EXTERNAL_INCOME.STATUS = N'مغلق'", sqlcon)
            sqlcon.Open()
            clo = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            label2.Text = CStr(clo)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Try
            Dim cmd As New SqlCommand("select count(ID) from [dbo].ICT_EXTERNAL_INCOME where [dbo].ICT_EXTERNAL_INCOME.STATUS = N'في الإنتظار'", sqlcon)
            sqlcon.Open()
            pen = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            label1.Text = CStr(pen)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        total = pen + clo
        label3.Text = CStr(total)
    End Sub
    Public Sub TotalCadOutOut(label1 As MetroFramework.Controls.MetroLabel, label2 As MetroFramework.Controls.MetroLabel, label3 As MetroFramework.Controls.MetroLabel)
        Dim Ca As Integer = 0
        Dim Nor As Integer = 0
        Dim total As Integer = 0
        Try
            Dim cmd As New SqlCommand("select count(ID) from [dbo].ICT_EXTERNAL_OUTGO where [dbo].ICT_EXTERNAL_OUTGO.CAT = N'عادي'", sqlcon)
            sqlcon.Open()
            Ca = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            label2.Text = CStr(Ca)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        Try
            Dim cmd As New SqlCommand("select count(ID) from [dbo].ICT_EXTERNAL_OUTGO where [dbo].ICT_EXTERNAL_OUTGO.CAT = N'سري'", sqlcon)
            'Dim cmd As New SqlCommand("select count(ID) from [dbo].HSEQ_EXTERNAL_OUTGO where [dbo].HSEQ_EXTERNAL_OUTGO.CAT = N'سري'", sqlcon)
            sqlcon.Open()
            Nor = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            label1.Text = CStr(Nor)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
        total = Ca + Nor
        label3.Text = CStr(total)
    End Sub

    Public Sub DeleteDoc(ddt As DataTable, i As Integer, empId As Integer)
        If ddt.Rows.Count <> 0 Then
            Try
                Dim c As New SqlCommand("delete [dbo].[ICT_DOC_TYPE] where [doc_id] =@a1 and path=@a2", sqlcon)
                c.Parameters.AddWithValue("@a1", empId)
                c.Parameters.AddWithValue("@a2", ddt.Rows(i)(1))

                sqlcon.Open()
                c.ExecuteNonQuery()
                sqlcon.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message & " - " & ex.Source)
                sqlcon.Close()
                Exit Sub
            End Try
        End If
    End Sub

    Public Sub LogInTrack(FLG As Integer, USERID As String)
        If FLG = 1 Then
            Try
                Dim c As New SqlCommand("INSERT INTO [dbo].[ICT_ACTIONTBL]  ([ActionID]
           ,[DocID]
           ,[DateStamp]
           ,[comments]
           ,[UserID])
            VALUES (@ACTIONID,@DOCID,GETDATE(),@COMMENTS,@USERID)", sqlcon)
                c.Parameters.AddWithValue("@ACTIONID", 7)
                c.Parameters.AddWithValue("@DOCID", 8)
                c.Parameters.AddWithValue("@COMMENTS", "LOGGED IN FAILED, WRONG PASSWORD")
                c.Parameters.AddWithValue("@USERID", USERID)


                sqlcon.Open()
                c.ExecuteNonQuery()
                sqlcon.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message & " - " & ex.Source)
                sqlcon.Close()
                Exit Sub
            End Try
        ElseIf FLG = 2 Then
            Try
                Dim c As New SqlCommand("INSERT INTO [dbo].[ICT_ACTIONTBL]  ([ActionID]
           ,[DocID]
           ,[DateStamp]
           ,[comments]
           ,[UserID])
            VALUES (@ACTIONID,@DOCID,GETDATE(),@COMMENTS,@USERID)", sqlcon)
                c.Parameters.AddWithValue("@ACTIONID", 1)
                c.Parameters.AddWithValue("@DOCID", 8)
                c.Parameters.AddWithValue("@COMMENTS", "USER HAS LOGGED IN SUCCEFULLY")
                c.Parameters.AddWithValue("@USERID", USERID)


                sqlcon.Open()
                c.ExecuteNonQuery()
                sqlcon.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message & " - " & ex.Source)
                sqlcon.Close()
                Exit Sub
            End Try
        End If


    End Sub

    Public Sub UserTrackingININ(USERID As String, docElectRef As Guna.UI2.WinForms.Guna2TextBox, yearId As Guna.UI2.WinForms.Guna2ComboBox)


        Try
            Dim d As Integer = 0
            Dim cmd As New SqlCommand("select [ID] from ICT_INTERNAL_INCOME where [DOC_REF] = @docref and [YearId]=@yearid", sqlcon)
            cmd.Parameters.AddWithValue("@docref", docElectRef.Text.Trim)
            cmd.Parameters.AddWithValue("@yearid", yearId.SelectedValue)
            sqlcon.Open()
            d = CInt(cmd.ExecuteScalar())
            sqlcon.Close()
            Module2.DocID = d
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
        End Try

        Dim comment As String = "NEW DOC (IN.IN) HAS BEEN CREATED UNDER THE NUMBER " & Module2.DocID & ""
        Try
            Dim c As New SqlCommand("INSERT INTO [dbo].[ICT_ACTIONTBL]  ([ActionID]
           ,[DocID]
           ,[DateStamp]
           ,[comments]
           ,[UserID])
            VALUES (@ACTIONID,@DOCID,GETDATE(),@COMMENTS,@USERID)", sqlcon)
            c.Parameters.AddWithValue("@ACTIONID", 3)
            c.Parameters.AddWithValue("@DOCID", 1)
            c.Parameters.AddWithValue("@COMMENTS", comment)
            c.Parameters.AddWithValue("@USERID", USERID)


            sqlcon.Open()
            c.ExecuteNonQuery()
            sqlcon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub

    Public Sub UserTrackingININEdit(USERID As String, docid As Integer)

        Dim comment As String = "EDIT HAS BEEN MADE TO DOC (IN.IN) UNDER THE NUMBER " & docid & ""
        Try
            Dim c As New SqlCommand("INSERT INTO [dbo].[ICT_ACTIONTBL]  ([ActionID]
           ,[DocID]
           ,[DateStamp]
           ,[comments]
           ,[UserID])
            VALUES (@ACTIONID,@DOCID,GETDATE(),@COMMENTS,@USERID)", sqlcon)
            c.Parameters.AddWithValue("@ACTIONID", 4)
            c.Parameters.AddWithValue("@DOCID", 1)
            c.Parameters.AddWithValue("@COMMENTS", comment)
            c.Parameters.AddWithValue("@USERID", USERID)


            sqlcon.Open()
            c.ExecuteNonQuery()
            sqlcon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            sqlcon.Close()
            Exit Sub
        End Try
    End Sub
End Class
