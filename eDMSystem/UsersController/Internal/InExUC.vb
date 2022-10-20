Imports System.Data.SqlClient
Public Class InExUC
    Private ReadOnly c As New Class1

    Private Sub InExUC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.V_INEXTableAdapter.Fill(Me.V_INEX._V_INEX)
        TextSearch.Focus()
    End Sub

    Private Sub ButtonAddVoter_Click(sender As Object, e As EventArgs) Handles ButtonAddVoter.Click
        AddInternal_Out.Location = New Point(CInt((WorkingArea.Width - AddInternal_Out.Width) / 2), 0) 'set popup form in middle of screen
        TransparentBGvb.ShowForm(AddInternal_Out)
        Me.V_INEXTableAdapter.Fill(Me.V_INEX._V_INEX)
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim inx As Integer
        Dim res As String = Nothing
        Dim filepath As String = Nothing
        inx = dgv.CurrentRow.Index
        If e.ColumnIndex = 6 Then
            'Try
            '    Dim dd As New DataSet
            '    Dim p As New pathClass
            '    Dim path As String = Nothing
            '    dd = c.FetchDataInOut(IDTextBox1.Text)
            '    path = p.getPath(2)
            '    Dim pp As String = path + dd.Tables(0).Rows(0)("path1").ToString()
            '    If My.Computer.FileSystem.FileExists(pp + ".pdf") Then
            '        showPDF.getValue(pp)
            '        showPDF.ShowDialog()
            '    Else
            '        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
            '        NotifyIcon1.BalloonTipText = "لا يمكن عرض الملف، البرنامج المشغل للملف غير متوفر في جهازك"
            '        NotifyIcon1.ShowBalloonTip(1)
            '        Exit Sub
            '    End If
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message & " - " & ex.Source)
            '    Exit Sub
            'End Try
            Dim FileName, FileExtension As String
            FileName = "eDMSystem"
            FileExtension = ".pdf"
            Dim file As Byte()
            Using con As SqlConnection = New SqlConnection("Data Source=10.176.56.16;Initial Catalog=EDMS;Persist Security Info=True;User ID=edms; password=edms@2021")
                con.Open()
                Using cmd As SqlCommand = New SqlCommand("select [FileData] from ICT_INTERNAL_OUTGO where id=@a1", con)
                    cmd.Parameters.AddWithValue("@a1", IDTextBox1.Text.Trim)
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
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
                NotifyIcon1.BalloonTipText = "لا يمكن عرض الملف، البرنامج المشغل للملف غير متوفر في جهازك"
                NotifyIcon1.ShowBalloonTip(1)
                Exit Sub
            End Try
        ElseIf e.ColumnIndex = 7 Then
            Dim dt As New DataSet
            dt = c.FetchDataInOut(CInt(IDTextBox1.Text))
            EditInternal_Out.getValue(dt, CInt(IDTextBox1.Text))
            EditInternal_Out.Location = New Point(CInt((WorkingArea.Width - EditExternal_OUT.Width) / 2), 0) 'set popup form in middle of screen
            TransparentBGvb.ShowForm(EditInternal_Out)
            Me.V_INEXTableAdapter.Fill(Me.V_INEX._V_INEX)
        ElseIf e.ColumnIndex = 8 Then
            Dim row1 As DataGridViewRow = dgv.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("هل تريد مسح الرسالة تحت الرقم الاشاري:{0} ", row1.Cells("DOCREFDataGridViewTextBoxColumn").Value), "تأكيد مسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                c.DeleteLetter(CInt(IDTextBox1.Text), "ICT_INTERNAL_OUTGO", 2, NotifyIcon1)
                Me.V_INEXTableAdapter.Fill(Me.V_INEX._V_INEX)
            End If
        End If
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        If TextSearch.Text = " " Then
            Me.V_INEXTableAdapter.Fill(Me.V_INEX._V_INEX)
            Exit Sub
        End If
        Me.VINEXBindingSource.Filter = ("Convert(DOC_REF,'System.String')like'%" & TextSearch.Text & "%' or DOC_SUBJECT Like'%" & TextSearch.Text & "%' or SENT_TO like'%" & TextSearch.Text & "%' or CAT like'%" & TextSearch.Text & "%'")

    End Sub
End Class
