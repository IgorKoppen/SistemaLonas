Public Class CoEmbarcacao
    Dim objemb As New ClsEmbarcacao
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable
    Private Sub ConsultaEmbarcao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCampo.Text = Agendamento.Txtcodcli.Text
    End Sub
    Private Sub ConsultaEmbarcao_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objemb.LocalizarFiltroB(TxtCampo.Text)
    End Sub


End Class