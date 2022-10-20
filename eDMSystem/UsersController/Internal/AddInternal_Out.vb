Imports System.IO.Path
Imports System.IO
Public Class AddInternal_Out
    Private ReadOnly cs As New Class1
    Private FileData As Byte()
    'Private ReadOnly val As String = ""
    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
        'f.ShowDialog()
    End Sub
    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Close()
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
            If Guna2TextBox6.Text <> "" Then
                'Dim p As New pathClass
                'Dim filestr As String = Nothing
                'filestr = p.getPath(2)
                'Dim fname As String = Guna2TextBox2.Text + "-" + CBDatabaseType.Text
                'FileCopy(Guna2TextBox6.Text, filestr + fname + ".pdf")
                'Guna2TextBox6.Text = fname
            End If
            cs.InsertInOutLetter(Guna2TextBox2, CBDatabaseType, Guna2TextBox4, Guna2DateTimePicker1, Guna2DateTimePicker2, Guna2ComboBox3,
            Guna2ComboBox1, Guna2TextBox1, Guna2ComboBox2, Guna2TextBox5, Guna2TextBox3, Guna2TextBox6, FileData)
            Alert("تم تسجيل رسالة جديده بنجاح", frmAlert.alertTypeEnum.Success)
            Dispose()
        End If
    End Sub
    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        Guna2CircleProgressBar2.Value = 0
        Timer1.Start()
    End Sub
    Private Sub AddInternal_Out_Load(sender As Object, e As EventArgs) Handles Me.Load
        cs.Yaercb(CBDatabaseType, "ICT_YearTable")
        Dim id As Integer = cs.GET_LAST_RECORED("ICT_INTERNAL_OUTGO", "[DOC_REF]", CStr(CBDatabaseType.SelectedValue), Guna2TextBox2)
        cs.GetDep(Guna2ComboBox3, "ICT_DEP", "DEP_NAME", "DEP_ID")
    End Sub
    Private Sub CBDatabaseType_DropDownClosed(sender As Object, e As EventArgs) Handles CBDatabaseType.DropDownClosed
        Dim id As Integer = cs.GET_LAST_RECORED("ICT_INTERNAL_OUTGO", "[DOC_REF]", CStr(CBDatabaseType.SelectedValue), Guna2TextBox2)
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