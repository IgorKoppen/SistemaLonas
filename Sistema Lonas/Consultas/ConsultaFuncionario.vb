Public Class ConsultaFuncionario
    Dim objFun As New ClsFuncionario
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable
    Private Sub ConsultaFuncionario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objFun.LocalizarFiltro(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        ' If quemChamou.ToUpper = "ENTRADADEMATERIAIS" Then
        'EntradaDeMateriais.TxtCodFun.Text = DgdGrade.CurrentRow.Cells(0).Value
        ''EntradaDeMateriais.TxtNomFun.Text = DgdGrade.CurrentRow.Cells(1).Value

        '' Else
        ''Funcionarios.quemchamou = Me.Name
        ''Funcionarios.Show()
        ''End If
        '' quemChamou = ""
        ''Me.Close()
    End Sub

    Private Sub DgdGradefuncionario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class