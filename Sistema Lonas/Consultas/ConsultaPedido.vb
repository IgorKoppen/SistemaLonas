Public Class ConsultaPedido
    Dim objPed As New ClsPedido
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable

    Private Sub ConsultaPedido_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objPed.LocalizarFiltro(TxtCampo.Text)
    End Sub
 
    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "PAGAMENTO" Then
            Pagamento.txtcodped.Text = DgdGrade.CurrentRow.Cells(1).Value
            Pagamento.txtnomecli.Text = DgdGrade.CurrentRow.Cells(3).Value
            Pagamento.txtval.Text = DgdGrade.CurrentRow.Cells(4).Value
        Else
            Cliente.quemchamou = Me.Name
            Cliente.Show()
        End If

        quemChamou = ""
        Me.Close()
    End Sub


    Private Sub ConsultaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
