Imports System.Data.SqlClient
Public Class InInUC
    Dim c As New Class1
    Private Sub InInUC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.V_InInTableAdapter.Fill(Me.V_inin._V_InIn)
        TextSearch.Select()

    End Sub
    Sub reload()
        Me.V_InInTableAdapter.Fill(Me.V_inin._V_InIn)
    End Sub
    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        If TextSearch.Text = " " Then
            Me.V_InInTableAdapter.Fill(Me.V_inin._V_InIn)
            Exit Sub
        End If
        'If Guna2CustomRadioButton1.Checked = True Then
        '    Me.VInInBindingSource.Filter = ("Convert(DOC_REF,'System.String')like'%" & TextSearch.Text & "%'")
        'End If
        'If Guna2CustomRadioButton2.Checked = True Then
        '    Me.VInInBindingSource.Filter = ("DOC_SUBJECT Like'%" & TextSearch.Text & "%'")
        'End If
        'If Guna2CustomRadioButton4.Checked = True Then
        '    Me.VInInBindingSource.Filter = ("COME_FROM like'%" & TextSearch.Text & "%'")
        'End If
        'If Guna2CustomRadioButton3.Checked = True Then
        '    Me.VInInBindingSource.Filter = ("CAT like'%" & TextSearch.Text & "%'")
        'End If
        'If Guna2CustomRadioButton5.Checked = True Then
        '    Me.VInInBindingSource.Filter = ("STATUS like'%" & TextSearch.Text & "%'")
        'End If
        'If Guna2CustomRadioButton1.Checked = False And Guna2CustomRadioButton2.Checked = False And Guna2CustomRadioButton4.Checked = False And Guna2CustomRadioButton3.Checked = False And Guna2CustomRadioButton5.Checked = False And Guna2CustomRadioButton1.Checked = False Then
        '    Me.VInInBindingSource.Filter = ("Convert(DOC_REF,'System.String')like'%" & TextSearch.Text & "%' or DOC_SUBJECT Like'%" & TextSearch.Text & "%' or COME_FROM like'%" & TextSearch.Text & "%' or CAT like'%" & TextSearch.Text & "%' or STATUS like'%" & TextSearch.Text & "%'")
        'End If
        Me.VInInBindingSource.Filter = ("Convert(DOC_REF,'System.String')like'%" & TextSearch.Text & "%' or DOC_SUBJECT Like'%" & TextSearch.Text & "%' or COME_FROM like'%" & TextSearch.Text & "%' or CAT like'%" & TextSearch.Text & "%' or STATUS like'%" & TextSearch.Text & "%'")
    End Sub
    Private Sub ButtonAddVoter_Click(sender As Object, e As EventArgs) Handles ButtonAddVoter.Click

        Dim frm As New AddInternal_IN
        frm.Location = New Point(CInt((WorkingArea.Width - frm.Width) / 2), 0) 'set popup form in middle of screen
        TransparentBGvb.ShowForm(frm)
        Me.V_InInTableAdapter.Fill(Me.V_inin._V_InIn)
    End Sub

    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        Dim inx As Integer
        Dim res As String = Nothing
        Dim filepath As String = Nothing
        inx = StudentDataGridView.CurrentRow.Index
        Dim file As Byte() = Nothing
        If e.ColumnIndex = 7 Then
            Dim FileName, FileExtension As String
            FileName = "eDMSystem"
            FileExtension = ".pdf"

            Using con As SqlConnection = New SqlConnection("Data Source=10.176.56.16;Initial Catalog=EDMS;Persist Security Info=True;User ID=edms; password=edms@2021")
                con.Open()
                Using cmd As SqlCommand = New SqlCommand("select [FileData] from ICT_INTERNAL_INCOME where id=@a1", con)
                    cmd.Parameters.AddWithValue("@a1", IDTextBox.Text.Trim)
                    Dim adp As New SqlDataAdapter(cmd)
                    Dim ds As New DataTable
                    adp.Fill(ds)
                    If ds.Rows(0).Item(0).ToString = Nothing Then

                    Else
                        file = CType(ds.Rows(0).Item(0), Byte())
                    End If
                End Using
            End Using
            Try
                Dim FullName = My.Computer.FileSystem.SpecialDirectories.Temp & "\eDMSystem" & FileName & FileExtension
                IO.File.WriteAllBytes(FullName, file)
                Process.Start(FullName)

            Catch ex As Exception
                'MessageBox.Show(ex.Message & " - " & ex.Source)
                'NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
                'NotifyIcon1.BalloonTipText = "لا يمكن عرض الملف، البرنامج المشغل للملف غير متوفر في جهازك"
                'NotifyIcon1.ShowBalloonTip(1)
                MsgBox(ex.Message)
                Exit Sub
            End Try


        ElseIf e.ColumnIndex = 8 Then
            Dim dt As New DataSet
            dt = c.FetchDataInIn(CInt(IDTextBox.Text))
            EditInternal_Invb.getValue(dt, CInt(IDTextBox.Text))
            Module2.DocID = CInt(IDTextBox.Text)
            'EditInternal_Invb.ShowDialog()
            EditInternal_Invb.Location = New Point(CInt((WorkingArea.Width - EditInternal_Invb.Width) / 2), 0) 'set popup form in middle of screen
            TransparentBGvb.ShowForm(EditInternal_Invb)
            Me.V_InInTableAdapter.Fill(Me.V_inin._V_InIn)
        ElseIf e.ColumnIndex = 9 Then
            Dim row1 As DataGridViewRow = StudentDataGridView.Rows(e.RowIndex)
            Dim frm As New deleteRecord
            If MessageBox.Show(String.Format("هل تريد مسح الرسالة تحت الرقم الاشاري:{0} ", row1.Cells("DataGridViewTextBoxColumn1").Value), "تأكيد مسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                c.DeleteLetter(CInt(IDTextBox.Text), "ICT_INTERNAL_INCOME", 1, NotifyIcon1)
                Me.V_InInTableAdapter.Fill(Me.V_inin._V_InIn)
            End If
        End If
        Me.V_InInTableAdapter.Fill(Me.V_inin._V_InIn)
    End Sub
End Class
