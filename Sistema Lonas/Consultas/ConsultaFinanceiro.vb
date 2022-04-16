Public Class ConsultaFinanceiro
    Dim objdes As New ClsDespesa
    Dim objped As New ClsDespesa
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnok.Click
        dgdgradeD.DataSource = objdes.Localizar_porDataD(DtpIni.Text, DtpFin.Text)
        dgdgradeP.DataSource = objped.Localizar_porDataP(DtpIni.Text, DtpFin.Text)
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Dim rpt As New CrpDespesas
        rpt.SetDataSource(dgdgradeD.DataSource)
        rpt.SetDataSource(dgdgradeP.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Despesas"
        'rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub
End Class
