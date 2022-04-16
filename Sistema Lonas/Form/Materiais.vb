Public Class Materiais
    Dim objEst As New ClsEstoque
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable
    Private Sub Materiais_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        DgdGrade.DataSource = objEst.LocalizarFiltro(txtCampo.Text)
    End Sub
End Class