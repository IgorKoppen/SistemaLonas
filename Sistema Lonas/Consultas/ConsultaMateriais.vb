Public Class ConsultaMateriais
    Dim objCad As New ClsCadastroMateriais
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objCad.LocalizarFiltro(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "ENTRADADEMATERIAIS" Then
            EntradaDeMateriais.TxtCodMat.Text = DgdGrade.CurrentRow.Cells(0).Value
            EntradaDeMateriais.TxtNomMat.Text = DgdGrade.CurrentRow.Cells(1).Value

        ElseIf quemChamou.ToUpper = "SAIDADEMATERIAIS" Then
            SaidaDeMateriais.TxtCodMat.Text = DgdGrade.CurrentRow.Cells(0).Value
            SaidaDeMateriais.TxtNomMat.Text = DgdGrade.CurrentRow.Cells(1).Value
        Else
            EntradaDeMateriais.quemchamou = Me.Name
            EntradaDeMateriais.Show()
        End If
        quemChamou = ""
        Me.Close()
    End Sub
End Class