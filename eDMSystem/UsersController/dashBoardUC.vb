Public Class dashBoardUC
    Dim cc As New Class1
    Private Sub dashBoardUC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt, dd As New DataTable

        dd = cc.getEmpByLocation()
        dt = cc.getAlletter()
        cc.getOutInByCom(DataGridView4)
        cc.getOutOutByCom(DataGridView3)
        cc.getInInByCom(DataGridView1)
        cc.getInOutByCom(DataGridView2)
        cc.getCompanyDep(Label6, Label8)
        cc.getIn(Label23, Label20)
        cc.getOut(Label12, Label14)
        cc.GetEmp(Label4)
        cc.TotalCadInOut(MetroLabel14, MetroLabel13, MetroLabel18)
        cc.TotalStatusInIn(MetroLabel20, MetroLabel19, MetroLabel24)
        cc.TotalStatusOutIn(MetroLabel8, MetroLabel5, MetroLabel12)
        cc.TotalCadOutOut(MetroLabel4, MetroLabel3, MetroLabel1)
        Chart1.DataSource = dd
        Chart1.Series("Series1").XValueMember = "Location"
        Chart1.Series("Series1").YValueMembers = "TOTAL"

        'Chart2.Series(0).Points.AddXY("مراسلات الداخلية", dt.Rows(0).Item(0).ToString)
        'Chart2.Series(1).Points.AddXY("مراسلات الخارجية", dt.Rows(0).Item(1).ToString)


    End Sub

    Private Sub MetroPanel2_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel2.Paint

    End Sub

    Private Sub MetroTile6_Click(sender As Object, e As EventArgs) Handles MetroTile6.Click

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub MetroTile7_Click(sender As Object, e As EventArgs) Handles MetroTile7.Click

    End Sub

    Private Sub MetroTile8_Click(sender As Object, e As EventArgs) Handles MetroTile8.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click

    End Sub
End Class
