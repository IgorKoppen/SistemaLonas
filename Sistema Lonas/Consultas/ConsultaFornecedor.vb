Public Class ConsultaFornecedor
    Dim objFor As New ClsFornecedor
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable
    Private Sub ConsultaFornecedor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objFor.LocalizarFiltro(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "ENTRADADEMATERIAIS" Then
            EntradaDeMateriais.TxtCodFor.Text = DgdGrade.CurrentRow.Cells(0).Value
            EntradaDeMateriais.TxtNomFor.Text = DgdGrade.CurrentRow.Cells(1).Value

        Else
            Fornecedor.quemchamou = Me.Name
            Fornecedor.Show()
        End If
        quemChamou = ""
        Me.Close()
    End Sub

    Private Sub DgdGradefornecedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class