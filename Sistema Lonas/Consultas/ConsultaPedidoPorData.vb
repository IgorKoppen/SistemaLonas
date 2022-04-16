Public Class ConsultaPedidoPorData
    Dim objpedi As New ClsPedido
    Private Sub ConsultaPedidoPorData_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If DtpIni.Value > DtpFin.Value Then
            MsgBox("data inicial não pode ser maior que a data final", vbInformation)
        Else
            DgdGrade.DataSource = objpedi.Localizar_porData(DtpIni.Text, DtpFin.Text)
        End If

    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Dim rpt As New CrpPedidos
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Pedidos"
        rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

End Class
