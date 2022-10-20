Public Class Form1
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Panel2.Controls.Clear()
        Dim u1 As New InternalControl
        Panel2.Controls.Add(u1)
        'AbrirFormEnPanel(New AddInternal_IN)
    End Sub
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        If MsgBox("هل تريد إغلاق المنظومة", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, Global.Microsoft.VisualBasic.MsgBoxStyle), "تأكيد طلب إغلاق") = MsgBoxResult.Yes Then
            Application.Exit()
            End
            Me.Close()
            Me.Dispose()
        End If
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Panel2.Controls.Clear()
        Dim u1 As New employeesUC
        Panel2.Controls.Add(u1)
    End Sub

    Sub getValue(a As String)
        GunaLabel2.Text = a
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Alert("تسجيل الدخول بنجاح", frmAlert.alertTypeEnum.Success)
        Panel2.Controls.Clear()
        Dim u1 As New dashBoardUC
        Panel2.Controls.Add(u1)
    End Sub
    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
        'f.ShowDialog()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Panel2.Controls.Clear()
        Dim u1 As New Center
        Panel2.Controls.Add(u1)
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Panel2.Controls.Clear()
        Dim u1 As New dashBoardUC
        Panel2.Controls.Add(u1)
    End Sub

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)

        If Me.Panel2.Controls.Count > 0 Then Me.Panel2.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(fh)
        Me.Panel2.Tag = fh
        fh.Show()

    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Panel2.Controls.Clear()
        Dim u1 As New InInUC
        Panel2.Controls.Add(u1)
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Panel2.Controls.Clear()
        Dim u1 As New InExUC
        Panel2.Controls.Add(u1)
    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs) Handles Guna2Button13.Click
        Panel2.Controls.Clear()
        Dim u1 As New InOut_UC
        Panel2.Controls.Add(u1)
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs) Handles Guna2Button12.Click
        Panel2.Controls.Clear()
        Dim u1 As New OutOut_UC
        Panel2.Controls.Add(u1)
    End Sub
End Class
