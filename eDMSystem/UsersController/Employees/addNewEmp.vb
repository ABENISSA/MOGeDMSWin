Public Class addNewEmp
    Dim cc As New Class1
    Dim dt As New DataTable
    Dim p As New pathClass
    Dim count As Integer = 0
    Private Sub addNewEmp_Load(sender As Object, e As EventArgs) Handles Me.Load
        cc.EmpDocTypecb(Guna2ComboBox1, "ICT_Type")
        cc.LocationCB(CBDatabaseType, "ICT_LOC")
        dt.Clear()
        dt.Dispose()
        dt.Columns.Clear()
        dt.Columns.Add("type")
        dt.Columns.Add("path")
        dt.Columns.Add("rev")
        Guna2TextBox2.Select()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filestr As String = Nothing
        filestr = p.getPath(5)
        OpenFileDialog1.FileName = Nothing
        OpenFileDialog1.Filter = "PDF Files(*.pdf)|*.pdf|All Files(*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        If Not OpenFileDialog1.FileName = Nothing Then
            Try
                For i As Integer = 0 To StudentDataGridView.Rows.Count - 1
                    If Guna2ComboBox1.Text = StudentDataGridView.Rows(i).Cells(0).Value.ToString Then
                        count += 1
                    End If
                Next
                Guna2TextBox6.Text = OpenFileDialog1.FileName
                Dim fname As String = Guna2TextBox2.Text & "-" & Guna2ComboBox1.SelectedValue.ToString & "-" & count
                FileCopy(Guna2TextBox6.Text, filestr + fname + ".pdf")
                Guna2TextBox6.Text = OpenFileDialog1.FileName
                StudentDataGridView.Rows.Add(Guna2ComboBox1.Text, fname.ToString(), count, Nothing)
                dt.Rows.Add(Guna2ComboBox1.SelectedValue, fname, count)
            Catch ex As Exception
                MessageBox.Show(ex.Message & " - " & ex.Source)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        Dim inx As Integer
        Dim path As String = p.getPath(5)
        Dim filepath As String = Nothing
        inx = StudentDataGridView.CurrentRow.Index
        If e.ColumnIndex = 3 Then
            If StudentDataGridView.Rows.Count = 0 Then
                MsgBox("لا يوجد بيانات", MsgBoxStyle.Exclamation, "مسح")
            End If
            filepath = path + dt.Rows(inx)(1).ToString
            StudentDataGridView.Rows.RemoveAt(inx)
            dt.Rows.RemoveAt(inx)
            System.IO.File.Delete(filepath + ".pdf")
        End If
    End Sub
    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        Guna2CircleProgressBar2.Value = 0
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2CircleProgressBar2.Increment(3)
        If Guna2CircleProgressBar2.Value <= 10 Then
            If Guna2TextBox2.Text = "" Then
                MsgBox(" يجب ادخال عنوان الرسالة قبل تسجيلها")
                Exit Sub
            ElseIf Guna2TextBox4.Text = "" Then
                MsgBox(" يجب اختيار الادارة قبل تسجيل الرسالة")
                Exit Sub
            End If
        ElseIf Guna2CircleProgressBar2.Value = 100 Then
            Timer1.Dispose()
            Try
                cc.InsertEmployees(Guna2TextBox2, CBDatabaseType, Guna2DateTimePicker3, Guna2TextBox4, Guna2TextBox1, Guna2TextBox3, dt, Guna2DateTimePicker1, Guna2TextBox7, Guna2TextBox5)
                Alert("تم تسجيل رسالة جديده بنجاح", frmAlert.alertTypeEnum.Success)
                Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message & " - " & ex.Source)
                Exit Sub
            End Try
        End If
    End Sub
    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
        'f.ShowDialog()
    End Sub
    Private Sub Guna2TextBox2_Leave(sender As Object, e As EventArgs) Handles Guna2TextBox2.Leave
        Dim flg = 0
        flg = cc.checkEmpNum(Guna2TextBox2)
        If flg <> 0 Then
            MsgBox("الرقم الوظيفي موجود ، ادخل رقم وظيفي جديد")
            Guna2TextBox2.Select()
        End If
    End Sub
    Private Sub Guna2ComboBox1_DropDownClosed(sender As Object, e As EventArgs) Handles Guna2ComboBox1.DropDownClosed
        count = 0
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim frm As New docEmpType
        frm.ShowDialog()
        cc.EmpDocTypecb(Guna2ComboBox1, "ICT_Type")
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim frm As New locationEmp
        frm.ShowDialog()
        cc.LocationCB(CBDatabaseType, "ICT_LOC")
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Close()
    End Sub
End Class