Imports Microsoft.Reporting.WinForms

Public Class Frm_Report_Stock

    Private Sub Frm_Report_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rv_stock.LocalReport.DataSources.Clear()
        rv_stock.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", BDHelper.getDBHelper.queryreportstock()))
        Me.rv_stock.RefreshReport()
    End Sub
End Class