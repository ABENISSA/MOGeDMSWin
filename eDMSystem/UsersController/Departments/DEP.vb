Public Class DEP
    Private Sub DEP_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FM_DEPTableAdapter.Fill(Me.DepDataSet.FM_DEP)
    End Sub
    Private Sub ButtonAddVoter_Click(sender As Object, e As EventArgs) Handles ButtonAddVoter.Click
        Dim frm As New addNewDep
        frm.ShowDialog()
        Me.FM_DEPTableAdapter.Fill(Me.DepDataSet.FM_DEP)
    End Sub
    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        Dim inx As Integer
        Dim c As New Class1
        inx = StudentDataGridView.CurrentRow.Index
        If e.ColumnIndex = 2 Then
            Dim frm As New editDep
            frm.Guna2TextBox3.Text = DEP_IDTextBox.Text
            frm.Guna2TextBox1.Text = CStr(StudentDataGridView.Item(0, inx).Value)
            frm.Guna2TextBox2.Text = CStr(StudentDataGridView.Item(1, inx).Value)
            frm.ShowDialog()
            Me.FM_DEPTableAdapter.Fill(Me.DepDataSet.FM_DEP)
        ElseIf e.ColumnIndex = 3 Then
            Dim row1 As DataGridViewRow = StudentDataGridView.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("هل تريد مسح بيانات الادارة التاليه:{0} ", row1.Cells("DEPNAMEDataGridViewTextBoxColumn").Value), "تأكيد مسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                c.DeleteDepCom("ICT_DEP", "DEP_ID", CInt(DEP_IDTextBox.Text))
                Me.FM_DEPTableAdapter.Fill(Me.DepDataSet.FM_DEP)
            End If
        End If
    End Sub
End Class
