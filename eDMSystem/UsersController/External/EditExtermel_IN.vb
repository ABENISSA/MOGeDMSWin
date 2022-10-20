Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Path
Public Class EditExtermel_IN
    Dim dtt As New DataSet
    Dim cc As New Class1
    Dim id As Integer = 0
    Dim comp As String = ""
    Private FileData As Byte()

    Sub getValue(dt As DataSet, docid As Integer)
        dtt = dt
        id = docid
    End Sub
    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
        'f.ShowDialog()
    End Sub
    Private Sub EditExtermel_IN_Load(sender As Object, e As EventArgs) Handles Me.Load
        cc.GetDep(Guna2ComboBox3, "ICT_COM", "COM_NAME", "COM_ID")
        cc.Yaercb(CBDatabaseType, "ICT_YearTable")
        loadDataToControles()
    End Sub
    Sub loadDataToControles()
        Dim p As New pathClass
        Dim filestr As String = Nothing
        filestr = p.getPath(3)
        Dim path As String = filestr + dtt.Tables(0).Rows(0)("path1").ToString()
        Guna2TextBox2.Text = dtt.Tables(0).Rows(0)("DOC_REF").ToString()
        Guna2TextBox1.Text = dtt.Tables(0).Rows(0)("RESPONSE_DOC_REF").ToString()
        Guna2TextBox3.Text = dtt.Tables(0).Rows(0)("FILE_NO").ToString()
        CBDatabaseType.SelectedValue = dtt.Tables(0).Rows(0)("YearId")
        Guna2TextBox4.Text = dtt.Tables(0).Rows(0)("DOC_SUBJECT").ToString()
        Guna2DateTimePicker1.Value = CDate(dtt.Tables(0).Rows(0)("DOC_DATE").ToString())
        Guna2DateTimePicker2.Value = CDate(dtt.Tables(0).Rows(0)("RECIEVED_DAT").ToString())
        Guna2ComboBox1.Text = dtt.Tables(0).Rows(0)("CAT").ToString()
        Guna2ComboBox2.Text = dtt.Tables(0).Rows(0)("STATUS").ToString()
        Guna2ComboBox3.Text = dtt.Tables(0).Rows(0)("COME_FROM").ToString()
        Guna2TextBox6.Text = path
        comp = Guna2TextBox6.Text
        FileData = CType(dtt.Tables(0).Rows(0)("FileData"), Byte())
        Guna2TextBox5.Text = dtt.Tables(0).Rows(0)("COMMENTS").ToString()
    End Sub
    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Close()
    End Sub
    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        Guna2CircleProgressBar2.Value = 0
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2CircleProgressBar2.Increment(3)
        If Guna2CircleProgressBar2.Value <= 10 Then
            If Guna2TextBox4.Text = "" Then
                MsgBox(" يجب ادخال عنوان الرسالة قبل تسجيلها")
                Exit Sub
            ElseIf Guna2ComboBox3.Text = "" Then
                MsgBox(" يجب اختيار الادارة قبل تسجيل الرسالة")
                Exit Sub
            ElseIf Guna2ComboBox1.Text = "" Then
                MsgBox("يجب اختيار فئة الرسالة قبل تسجيلها")
                Exit Sub
            End If
        ElseIf Guna2CircleProgressBar2.Value = 100 Then
            Timer1.Dispose()
            If Guna2TextBox6.Text <> comp Then
                'Dim p As New pathClass
                'Dim filestr As String = Nothing
                'filestr = p.getPath(3)
                'Dim fname As String = Guna2TextBox2.Text + "-" + CBDatabaseType.Text
                'FileCopy(Guna2TextBox6.Text, filestr + fname + ".pdf")
                'Guna2TextBox6.Text = fname
            Else
                Guna2TextBox6.Text = dtt.Tables(0).Rows(0)("path1").ToString()
            End If
            cc.UpdateOutInLetter(Guna2TextBox1, CBDatabaseType, Guna2TextBox4, Guna2DateTimePicker1, Guna2DateTimePicker2, Guna2ComboBox3,
                                Guna2ComboBox1, Guna2ComboBox2, Guna2TextBox5, Guna2TextBox3, Guna2TextBox6, Guna2DateTimePicker3, id, FileData)
            Alert("تم تعديل الرسالة بنجاح", frmAlert.alertTypeEnum.Info)
            Me.Dispose()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'OpenFileDialog1.FileName = Nothing
        'OpenFileDialog1.Filter = "PDF Files(*.pdf)|*.pdf|All Files(*.*)|*.*"
        'OpenFileDialog1.ShowDialog()
        'If Not OpenFileDialog1.FileName = Nothing Then
        '    Guna2TextBox6.Text = OpenFileDialog1.FileName
        'End If
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "PDF Files(*.pdf)|*.pdf|All Files(*.*)|*.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Guna2TextBox6.Text = GetFileNameWithoutExtension(OpenFileDialog1.FileName)
            FileData = File.ReadAllBytes(OpenFileDialog1.FileName)
        Else
            Guna2TextBox6.ReadOnly = True
        End If
    End Sub
End Class