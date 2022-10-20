Public Class empPDF
    Dim id As Integer = 0
    Dim cc As New Class1
    Dim d As New DataTable
    Sub getValue(docid As Integer)
        id = docid
    End Sub
    Private Sub empPDF_Load(sender As Object, e As EventArgs) Handles Me.Load
        cc.getEmpDocPdf(id, DataGridView1)
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim inx As Integer
        Dim res As String = Nothing
        Dim filepath As String = Nothing
        inx = DataGridView1.CurrentRow.Index
        Try
            Dim p As New pathClass
            Dim path As String = Nothing
            path = p.getPath(5)
            Dim pp As String = path + DataGridView1.Item(1, inx).Value.ToString
            If My.Computer.FileSystem.FileExists(pp + ".pdf") Then
                AxAcroPDF1.src = (pp + ".pdf")
            Else
                MsgBox("Sorry ...The File Or File Path does not exist.... ")

                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            Exit Sub
        End Try
    End Sub
End Class