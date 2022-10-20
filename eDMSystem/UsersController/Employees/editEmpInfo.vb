Public Class editEmpInfo
    Dim dtt As New DataSet
    Dim cc As New Class1
    Dim id As Integer = 0
    Dim comp As String = ""
    Dim count As Integer = 0
    Dim dt As New DataTable
    Dim p As New pathClass
    Sub getValue(dt As DataSet, docid As Integer)
        dtt = dt
        id = docid
    End Sub
    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
        'f.ShowDialog()
    End Sub
    Sub loadDataToControles()
        Dim p As New pathClass
        Dim filestr As String = Nothing
        filestr = p.getPath(5)
        'Dim path As String = filestr + dtt.Tables(0).Rows(0)("path1").ToString()
        Guna2TextBox2.Text = dtt.Tables(0).Rows(0)("EMP_NUM").ToString()
        CBDatabaseType.Text = dtt.Tables(0).Rows(0)("LOCATION").ToString()
        Guna2TextBox4.Text = dtt.Tables(0).Rows(0)("EMP_NAME").ToString()
        Guna2DateTimePicker3.Value = CDate(dtt.Tables(0).Rows(0)("DOC_DATE").ToString())
        Guna2TextBox1.Text = dtt.Tables(0).Rows(0)("JOB_DESC").ToString()
        Guna2TextBox3.Text = dtt.Tables(0).Rows(0)("DEGREE").ToString()
        Guna2DateTimePicker1.Value = CDate(dtt.Tables(0).Rows(0)("ENTRY_DATE").ToString())
        Guna2TextBox5.Text = dtt.Tables(0).Rows(0)("Qua").ToString()
        Guna2TextBox7.Text = dtt.Tables(0).Rows(0)("COMMENTS").ToString()
        cc.GetEmpDoc(id, StudentDataGridView, dt)
    End Sub
    Private Sub editEmpInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        cc.EmpDocTypecb(Guna2ComboBox1, "ICT_Type")
        cc.LocationCB(CBDatabaseType, "ICT_LOC")
        dt.Clear()
        dt.Dispose()
        dt.Columns.Clear()
        dt.Columns.Add("type")
        dt.Columns.Add("path")
        dt.Columns.Add("rev")
        Guna2TextBox2.Select()
        loadDataToControles()
    End Sub
    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Close()
    End Sub
    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        Guna2CircleProgressBar2.Value = 0
        Timer1.Start()
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
            cc.DeleteDoc(dt, inx, id)
            StudentDataGridView.Rows.RemoveAt(inx)
            dt.Rows.RemoveAt(inx)
            System.IO.File.Delete(filepath + ".pdf")
        End If
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
                Dim f As Integer = 0
                f = cc.UpdateEmpDoc(Guna2TextBox2, Guna2TextBox4, CBDatabaseType, Guna2DateTimePicker3,
                           Guna2TextBox1, Guna2TextBox3, id)
                If f <> 0 Then
                    cc.UpdateEmpDocTable(id, dt)
                End If
                Alert("تم تعديل بيانات الموظف بنجاح", frmAlert.alertTypeEnum.Info)
                Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message & " - " & ex.Source)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim frm As New locationEmp
        frm.ShowDialog()
        cc.LocationCB(CBDatabaseType, "ICT_LOC")
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim frm As New docEmpType
        frm.ShowDialog()
        cc.EmpDocTypecb(Guna2ComboBox1, "ICT_Type")
    End Sub
End Class