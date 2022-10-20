Public Class COM
    Private Sub COM_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.HSEQ_COMTableAdapter.Fill(Me.CompaniesDataSet.HSEQ_COM)
    End Sub
    Private Sub ButtonAddVoter_Click(sender As Object, e As EventArgs) Handles ButtonAddVoter.Click
        Dim frm As New addNewCom
        frm.ShowDialog()
        Me.HSEQ_COMTableAdapter.Fill(Me.CompaniesDataSet.HSEQ_COM)
    End Sub
    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        Dim inx As Integer
        Dim c As New Class1
        inx = StudentDataGridView.CurrentRow.Index
        If e.ColumnIndex = 2 Then
            Dim frm As New editCom
            frm.Guna2TextBox3.Text = COM_IDTextBox.Text
            frm.Guna2TextBox1.Text = CStr(StudentDataGridView.Item(0, inx).Value)
            frm.Guna2TextBox2.Text = CStr(StudentDataGridView.Item(1, inx).Value)
            frm.ShowDialog()
            Me.HSEQ_COMTableAdapter.Fill(Me.CompaniesDataSet.HSEQ_COM)
        ElseIf e.ColumnIndex = 3 Then
            Dim row1 As DataGridViewRow = StudentDataGridView.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("هل تريد مسح بيانات الادارة التاليه:{0} ", row1.Cells("COMNAMEDataGridViewTextBoxColumn").Value), "تأكيد مسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                c.DeleteDepCom("ICT_COM", "COM_ID", CInt(COM_IDTextBox.Text))
                Me.HSEQ_COMTableAdapter.Fill(Me.CompaniesDataSet.HSEQ_COM)
            End If
        End If
    End Sub
End Class
