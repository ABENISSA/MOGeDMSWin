Imports System.IO.Path
Imports System.IO
Public Class AddInternal_IN
    Dim YLocation As Integer = CInt((WorkingArea.Height - Me.Height) / 3) 'Final popup form location from top of screen


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
        ElseIf Guna2CircleProgressBar2.Value = 100 Then
            Timer1.Stop()
            MsgBox(Module2.Number)
            cs.InsertInInLetter(Guna2TextBox2, CBDatabaseType, Guna2TextBox4, Guna2DateTimePicker1, Guna2DateTimePicker2, Guna2ComboBox3,
            Guna2ComboBox1, Guna2TextBox1, Guna2ComboBox2, Guna2TextBox5, Guna2TextBox3, Guna2TextBox6, FileData)
            cs.UserTrackingININ(Module2.Number, Guna2TextBox2, CBDatabaseType)
            Alert("تم تسجيل رسالة جديده بنجاح", frmAlert.alertTypeEnum.Success)
            Dispose()
        End If
    End Sub
    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        If Guna2TextBox4.Text = "" Then
            MsgBox(" يجب ادخال عنوان الرسالة قبل تسجيلها")
            Guna2TextBox4.Focus()
            Exit Sub
        ElseIf Guna2ComboBox3.Text = "" Then
            MsgBox(" يجب اختيار الادارة قبل تسجيل الرسالة")
            Guna2ComboBox3.Focus()
            Exit Sub
        ElseIf Guna2ComboBox1.Text = "" Then
            MsgBox("يجب اختيار فئة الرسالة قبل تسجيلها")
            Guna2ComboBox1.Focus()
            Exit Sub
        ElseIf Guna2TextBox6.Text = "" Then
            MsgBox("يجب ارفاق الرسالة")
            Guna2TextBox6.Focus()
            Exit Sub
        ElseIf Guna2ComboBox2.Text = "" Then
            MsgBox("يجب اختيار حالة الرسالة قبل تسجيلها")
            Guna2ComboBox2.Focus()
            Exit Sub
        Else
            Guna2CircleProgressBar2.Value = 0
            Timer1.Start()
        End If
    End Sub
    Private Sub AddInternal_IN_Load(sender As Object, e As EventArgs) Handles Me.Load
        cs.Yaercb(CBDatabaseType, "ICT_YearTable")
        Dim id As Integer = cs.GET_LAST_RECORED("ICT_INTERNAL_INCOME", "[DOC_REF]", CStr(CBDatabaseType.SelectedValue), Guna2TextBox2)
        cs.GetDep(Guna2ComboBox3, "ICT_DEP", "DEP_NAME", "DEP_ID")
        MsgBox(Module2.Number)
    End Sub
    Private Sub CBDatabaseType_DropDownClosed(sender As Object, e As EventArgs) Handles CBDatabaseType.DropDownClosed
        Dim id As Integer = cs.GET_LAST_RECORED("ICT_INTERNAL_INCOME", "[DOC_REF]", CStr(CBDatabaseType.SelectedValue), Guna2TextBox2)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "PDF Files(*.pdf)|*.pdf|All Files(*.*)|*.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Guna2TextBox6.Text = GetFileNameWithoutExtension(OpenFileDialog1.FileName)
            FileData = File.ReadAllBytes(OpenFileDialog1.FileName)
        Else
            Guna2TextBox6.ReadOnly = True
        End If
    End Sub

    Private Sub Open_Timer_Tick(sender As Object, e As EventArgs) Handles Open_Timer.Tick
        If Me.Location.Y >= YLocation Then
            'Stop timer when popup form Y location reached to final location
            Open_Timer.Stop()
        Else
            'Increase popup form Y Location gradully
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)
        End If
    End Sub
End Class
