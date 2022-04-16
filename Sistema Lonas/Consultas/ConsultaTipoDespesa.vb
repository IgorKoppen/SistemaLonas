Public Class ConsultaTipoDespesa

    Dim objDes As New ClsDespesa
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable

    Private Sub ConsultaTipoDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objDes.LocalizarFiltro(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "CONTASAPAGAR" Then
            ContasApagar.TxtTip.Text = DgdGrade.CurrentRow.Cells(0).Value
            ContasApagar.TxtTipName.Text = DgdGrade.CurrentRow.Cells(1).Value
        Else
            ContasApagar.quemchamou = Me.Name
            ContasApagar.Show()
            ContasApagar.MdiParent = FrmMenu
        End If

        quemChamou = ""
        Me.Close()

    End Sub


End Class