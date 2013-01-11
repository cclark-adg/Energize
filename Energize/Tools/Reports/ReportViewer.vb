Public Class ReportViewer

    Private Sub ReportViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.tbl_History' table. You can move, or remove it, as needed.
        Me.tbl_HistoryTableAdapter.Fill(Me.HotelDataSet.tbl_History)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class