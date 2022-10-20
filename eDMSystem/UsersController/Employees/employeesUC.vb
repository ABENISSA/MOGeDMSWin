Public Class employeesUC
    Dim c As New Class1
    Private Sub employeesUC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ICT_EMPLOYEESTableAdapter.Fill(Me.EDMSDataSetemplloyees.ICT_EMPLOYEES)
    End Sub

    Private Sub ButtonAddVoter_Click(sender As Object, e As EventArgs) Handles ButtonAddVoter.Click
        addNewEmp.ShowDialog()
        Me.ICT_EMPLOYEESTableAdapter.Fill(Me.EDMSDataSetemplloyees.ICT_EMPLOYEES)

    End Sub
    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        If TextSearch.Text = " " Then
            Me.ICT_EMPLOYEESTableAdapter.Fill(Me.EDMSDataSetemplloyees.ICT_EMPLOYEES)

            Exit Sub
        End If
        If Guna2CustomRadioButton1.Checked = True Then
            Me.ICTEMPLOYEESBindingSource.Filter = ("Convert(EMP_NUM,'System.String')like'%" & TextSearch.Text & "%'")
        End If
        If Guna2CustomRadioButton2.Checked = True Then
            Me.ICTEMPLOYEESBindingSource.Filter = ("EMP_NAME Like'%" & TextSearch.Text & "%'")
        End If
        If Guna2CustomRadioButton3.Checked = True Then
            Me.ICTEMPLOYEESBindingSource.Filter = ("LOCATION like'%" & TextSearch.Text & "%'")
        End If
        If Guna2CustomRadioButton4.Checked = True Then
            Me.ICTEMPLOYEESBindingSource.Filter = ("JOB_DESC like'%" & TextSearch.Text & "%'")
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim inx As Integer
        Dim res As String = Nothing
        Dim filepath As String = Nothing
        inx = dgv.CurrentRow.Index
        If e.ColumnIndex = 7 Then
            empPDF.getValue(CInt(IDTextBox.Text))
            empPDF.ShowDialog()
            Me.ICT_EMPLOYEESTableAdapter.Fill(Me.EDMSDataSetemplloyees.ICT_EMPLOYEES)
        ElseIf e.ColumnIndex = 8 Then
            Dim dt As New DataSet
            dt = c.FetchEmpData(CInt(IDTextBox.Text))
            editEmpInfo.getValue(dt, CInt(IDTextBox.Text))
            editEmpInfo.ShowDialog()
            Me.ICT_EMPLOYEESTableAdapter.Fill(Me.EDMSDataSetemplloyees.ICT_EMPLOYEES)
        ElseIf e.ColumnIndex = 9 Then
            Dim row1 As DataGridViewRow = dgv.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("هل تريد مسح بيانات الموظف تحت الرقم الوظيفي:{0} ", row1.Cells("EMPNUMDataGridViewTextBoxColumn").Value), "تأكيد مسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                c.DeleteEmpData(CInt(IDTextBox.Text))
                Me.ICT_EMPLOYEESTableAdapter.Fill(Me.EDMSDataSetemplloyees.ICT_EMPLOYEES)
            End If
        End If
    End Sub
End Class
