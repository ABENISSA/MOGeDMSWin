Imports System.Data.SqlClient
Public Class InOutUC
    Dim c As New Class1
    Private Sub InOutUC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.V_CRINEXTableAdapter.Fill(Me.V_CRINEX._V_CRINEX)
        TextSearch.Select()
    End Sub
    Private Sub ButtonAddVoter_Click(sender As Object, e As EventArgs) Handles ButtonAddVoter.Click
        AddInternal_Out.Location = New Point(CInt((WorkingArea.Width - AddInternal_Out.Width) / 2), 0) 'set popup form in middle of screen
        TransparentBGvb.ShowForm(AddInternal_Out)
        Me.HSEQ_INTERNAL_OUTGOTableAdapter.Fill(Me.INOUT.HSEQ_INTERNAL_OUTGO)
    End Sub
    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        'If TextSearch.Text = " " Then
        '    Me.HSEQ_INTERNAL_OUTGOTableAdapter.Fill(Me.INOUT.HSEQ_INTERNAL_OUTGO)
        '    Exit Sub
        'End If
        'If Guna2CustomRadioButton1.Checked = True Then
        '    Me.HSEQINTERNALOUTGOBindingSource.Filter = ("Convert(DOC_REF,'System.String')like'%" & TextSearch.Text & "%'")
        'End If
        'If Guna2CustomRadioButton2.Checked = True Then
        '    Me.HSEQINTERNALOUTGOBindingSource.Filter = ("DOC_SUBJECT Like'%" & TextSearch.Text & "%'")
        'End If
        'If Guna2CustomRadioButton4.Checked = True Then
        '    Me.HSEQINTERNALOUTGOBindingSource.Filter = ("SENT_TO like'%" & TextSearch.Text & "%'")
        'End If
        'If Guna2CustomRadioButton3.Checked = True Then
        '    Me.HSEQINTERNALOUTGOBindingSource.Filter = ("CAT like'%" & TextSearch.Text & "%'")
        'End If
        'If Guna2CustomRadioButton5.Checked = True Then
        '    Me.HSEQINTERNALOUTGOBindingSource.Filter = ("UserName like'%" & TextSearch.Text & "%'")
        'End If
    End Sub
    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim inx As Integer
        Dim res As String = Nothing
        Dim filepath As String = Nothing
        inx = dgv.CurrentRow.Index
        If e.ColumnIndex = 6 Then
            'Try
            '    Dim dd As New DataSet
            '    Dim p As New pathClass
            '    Dim path As String = Nothing
            '    dd = c.FetchDataInOut(IDTextBox.Text)
            '    path = p.getPath(2)
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
                Using cmd As SqlCommand = New SqlCommand("select [FileData] from ICT_INTERNAL_OUTGO where id=@a1", con)
                    cmd.Parameters.AddWithValue("@a1", IDTextBox.Text.Trim)
                    Dim adp As New SqlDataAdapter(cmd)
                    Dim ds As New DataTable
                    adp.Fill(ds)
                    file = CType(ds.Rows(0).Item(0), Byte())
                End Using
            End Using
            Try
                Dim FullName = My.Computer.FileSystem.SpecialDirectories.Temp & "\eDMSystem" & FileName & FileExtension
                IO.File.WriteAllBytes(FullName, file)
                Process.Start(FullName)

            Catch ex As Exception
                MessageBox.Show(ex.Message & " - " & ex.Source)
            End Try
        ElseIf e.ColumnIndex = 7 Then
            Dim dt As New DataSet
            dt = c.FetchDataInOut(CInt(IDTextBox.Text))
            EditInternal_Out.getValue(dt, CInt(IDTextBox.Text))
            EditInternal_Out.Location = New Point(CInt((WorkingArea.Width - EditInternal_Out.Width) / 2), 0) 'set popup form in middle of screen
            TransparentBGvb.ShowForm(EditInternal_Out)

            Me.HSEQ_INTERNAL_OUTGOTableAdapter.Fill(Me.INOUT.HSEQ_INTERNAL_OUTGO)
        ElseIf e.ColumnIndex = 8 Then
            Dim row1 As DataGridViewRow = dgv.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("هل تريد مسح الرسالة تحت الرقم الاشاري:{0} ", row1.Cells("DOCREFDataGridViewTextBoxColumn").Value), "تأكيد مسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                'c.DeleteLetter(IDTextBox.Text, "CR_INTERNAL_OUTGO", 2)
                Me.V_CRINEXTableAdapter.Fill(Me.V_CRINEX._V_CRINEX)
            End If
        End If
    End Sub
End Class
