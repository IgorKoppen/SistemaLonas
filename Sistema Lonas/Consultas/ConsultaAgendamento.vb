Public Class ConsultaAgendamento

    Dim objAgen As New ClsAgendamento
    Dim objdtLimpo As New DataTable
    Private Sub ConsultaAgendamento_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objAgen.LocalizarFiltro(TxtCampo.Text)
    End Sub
End Class