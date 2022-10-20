Imports System.Data.SqlClient
Public Class InOut_UC

    Dim c As New Class1
    Private Sub InOut_UC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.HSEQ_EXTERNAL_INCOMETableAdapter.Fill(Me.OutIn.HSEQ_EXTERNAL_INCOME)
        TextSearch.Select()
    End Sub
    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        Dim inx As Integer
        Dim res As String = Nothing
        Dim filepath As String = Nothing
        inx = StudentDataGridView.CurrentRow.Index
        If e.ColumnIndex = 6 Then
            'Try
            '    Dim dd As New DataSet
            '    Dim p As New pathClass
            '    Dim path As String = Nothing
            '    dd = c.FetchDataOutIn(IDTextBox.Text)
            '    path = p.getPath(3)
            '    Dim pp As String = path + dd.Tables(0).Rows(0)("path1").ToString()
            '    If My.Computer.FileSystem.FileExists(pp + ".pdf") Then
            '        showPDF.getValue(pp)
            '        showPDF.ShowDialog()
            '    Else
            '        MsgBox("Sorry ...The File Or File Path does not exist.... ")
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
                Using cmd As SqlCommand = New SqlCommand("select [FileData] from ICT_EXTERNAL_INCOME where id=@a1", con)
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
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
                NotifyIcon1.BalloonTipText = "لا يمكن عرض الملف، البرنامج المشغل للملف غير متوفر في جهازك"
                NotifyIcon1.ShowBalloonTip(1)
                Exit Sub
            End Try
        ElseIf e.ColumnIndex = 7 Then
            Dim dt As New DataSet
            dt = c.FetchDataOutIn(CInt(IDTextBox.Text))
            EditExtermel_IN.getValue(dt, CInt(IDTextBox.Text))

            EditExtermel_IN.Location = New Point(CInt((WorkingArea.Width - EditExtermel_IN.Width) / 2), 0) 'set popup form in middle of screen
            TransparentBGvb.ShowForm(EditExtermel_IN)
            Me.HSEQ_EXTERNAL_INCOMETableAdapter.Fill(Me.OutIn.HSEQ_EXTERNAL_INCOME)
        ElseIf e.ColumnIndex = 8 Then
            Dim row1 As DataGridViewRow = StudentDataGridView.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("هل تريد مسح الرسالة تحت الرقم الاشاري:{0} ", row1.Cells("DOCREFDataGridViewTextBoxColumn").Value), "تأكيد مسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                c.DeleteLetter(CInt(IDTextBox.Text), "ICT_EXTERNAL_INCOME", 3, NotifyIcon1)
                Me.HSEQ_EXTERNAL_INCOMETableAdapter.Fill(Me.OutIn.HSEQ_EXTERNAL_INCOME)
            End If
        End If
    End Sub
    Private Sub ButtonAddVoter_Click(sender As Object, e As EventArgs) Handles ButtonAddVoter.Click
        AddExternal_IN.Location = New Point(CInt((WorkingArea.Width - AddExternal_IN.Width) / 2), 0) 'set popup form in middle of screen
        TransparentBGvb.ShowForm(AddExternal_IN)
        Me.HSEQ_EXTERNAL_INCOMETableAdapter.Fill(Me.OutIn.HSEQ_EXTERNAL_INCOME)
    End Sub
    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        If TextSearch.Text = " " Then
            Me.HSEQ_EXTERNAL_INCOMETableAdapter.Fill(Me.OutIn.HSEQ_EXTERNAL_INCOME)
            Exit Sub
        End If
        If Guna2CustomRadioButton1.Checked = True Then
            Me.HSEQEXTERNALINCOMEBindingSource.Filter = ("Convert(DOC_REF,'System.String')like'%" & TextSearch.Text & "%'")
        End If
        If Guna2CustomRadioButton2.Checked = True Then
            Me.HSEQEXTERNALINCOMEBindingSource.Filter = ("DOC_SUBJECT Like'%" & TextSearch.Text & "%'")
        End If
        If Guna2CustomRadioButton4.Checked = True Then
            Me.HSEQEXTERNALINCOMEBindingSource.Filter = ("COME_FROM like'%" & TextSearch.Text & "%'")
        End If
        If Guna2CustomRadioButton3.Checked = True Then
            Me.HSEQEXTERNALINCOMEBindingSource.Filter = ("CAT like'%" & TextSearch.Text & "%'")
        End If
        If Guna2CustomRadioButton5.Checked = True Then
            Me.HSEQEXTERNALINCOMEBindingSource.Filter = ("STATUS like'%" & TextSearch.Text & "%'")
        End If
    End Sub
End Class
