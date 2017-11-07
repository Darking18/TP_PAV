Imports Microsoft.Reporting.WinForms

Public Class Frm_Report

    Private Sub Frm_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_fec_desde.Text = Date.Now.ToString("dd/MM/yyyy")
        txt_fec_hasta.Text = Date.Now.AddDays(1).ToString("dd/MM/yyyy")
        Me.rv_compra.RefreshReport()
    End Sub

    Private Sub btn_consult_Click(sender As Object, e As EventArgs) Handles btn_consult.Click
        Dim rParams As Microsoft.Reporting.WinForms.ReportParameter()
        rv_compra.LocalReport.DataSources.Clear()
        rv_compra.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", BDHelper.getDBHelper.queryReportProduct(txt_fec_desde.Text, txt_fec_hasta.Text)))
        rParams = {New Microsoft.Reporting.WinForms.ReportParameter("fec_desde", txt_fec_desde.Text), New Microsoft.Reporting.WinForms.ReportParameter("fec_hasta", txt_fec_hasta.Text)}
        rv_compra.LocalReport.SetParameters(rParams)
        rv_compra.RefreshReport()

    End Sub
End Class