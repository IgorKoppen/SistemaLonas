Public Class ConsultaMarina
    Dim objMar As New ClsMarina
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable

    Private Sub ConsultaMarina_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objMar.LocalizarFiltro(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "EMBARCACAO" Then
            Embarcacao.txtmarina.Text = DgdGrade.CurrentRow.Cells(0).Value
            Embarcacao.TxtNmar.Text = DgdGrade.CurrentRow.Cells(1).Value
        Else
            Embarcacao.campochave = DgdGrade.CurrentRow.Cells(0).Value
            Embarcacao.quemchamou = Me.Name
            Embarcacao.Show()
        End If
        quemChamou = ""
        Me.Close()
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub ConsultaMarina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class