Public Class ConsultaEmbarcaoComClie
    Dim objControle As New ClsControle
    Dim objemb As New ClsEmbarcacao
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable


    Private Sub ConsultaEmbarcaoComClie_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampoEmbarcacao.TextChanged
        DgdGrade.DataSource = objemb.LocalizarFiltro(TxtCampoEmbarcacao.Text)
    End Sub

    Private Sub ConsultaEmbarcaoComClie_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Agendamento.Txtcodcli.TextLength = 0 Then
            TxtCampoEmbarcacao.Text = ""
            DgdGrade.DataSource = ""
        ElseIf Agendamento.Txtcodcli.TextLength > 0 Then
            TxtCampoEmbarcacao.Text = Agendamento.Txtcodcli.Text
        End If
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick


        If quemChamou.ToUpper = "AGENDAMENTO" Then
            Agendamento.txtcodemb.Text = DgdGrade.CurrentRow.Cells(0).Value
            Agendamento.cliEmba = DgdGrade.CurrentRow.Cells(1).Value
            Agendamento.txtEmbarcacao.Text = DgdGrade.CurrentRow.Cells(2).Value
        Else
            Agendamento.quemchamou = Me.Name
            Agendamento.Show()
        End If

        quemChamou = ""
        Me.Close()
    End Sub

    Private Sub ConsultaEmbarcaoComClie_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        DgdGrade.DataSource = ""
    End Sub
   


End Class