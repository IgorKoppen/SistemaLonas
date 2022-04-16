Public Class Fornecedor
    Dim objControle As New ClsControle
    Dim objFor As New ClsFornecedor
    Dim novo As Boolean
    Public quemchamou As String = ""
    Public campochave As Integer

    Private Sub Fornecedor_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub Fornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        GrpLoc.Visible = False
        mskCnpj.Mask = "00,000,000/0000-00"
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        txtcod.Enabled = False
        txtnom.Focus()
        novo = True
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click

        If txtnom.Text = "" Then
            MsgBox("Digite o nome da empresa!", vbInformation)
            txtnom.Focus()
        ElseIf txttel.Text = "" Then
            MsgBox("Digite o telefone de contato da empresa!", vbInformation)
            txttel.Focus()
        ElseIf txtven.Text = "" Then
            MsgBox("Digite o nome do vendedor que atendeu a Lonas Timoneiro!", vbInformation)
            txtven.Focus()
        ElseIf mskCnpj.Text = "  .   .   /    -" Then
            MsgBox("Digite o CNPJ do Fornecedor!", vbInformation)
            mskCnpj.Focus()
        Else
            objFor.Codigo = Val(txtcod.Text)
            objFor.NomeEmpresa = txtnom.Text
            objFor.CNPJ = mskCnpj.Text
            objFor.Telefone = txttel.Text
            objFor.NomeVendedor = txtven.Text
            objFor.Pix = TxtPix.Text
            objFor.Gravar(novo)
            txtcod.Text = objFor.Codigo
            objControle.habilitar_tela(Me, False)
            objControle.habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        GrpLoc.Visible = True
        TxtLoc.Text = ""
        BtnOK.Enabled = False
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Fornecedor_Load(Nothing, Nothing)
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objFor.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            objControle.habilitar_botoes(Me, True)
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub

    Private Sub mostrar_DadosVindosDaClasse()
        txtcod.Text = objFor.Codigo
        txtnom.Text = objFor.NomeEmpresa
        txttel.Text = objFor.Telefone
        mskCnpj.Text = objFor.CNPJ
        txtven.Text = objFor.NomeVendedor
        TxtPix.Text = objFor.Pix

    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        Try
            If objFor.Excluir(txtcod.Text) = True Then
                objControle.Limpar_tela(Me)
                BtnExc.Enabled = False
                BtnAlt.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Você não pode excluir um fornecedor já que tem uma entrada registrada", vbInformation)
        End Try
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        txtcod.Enabled = False
        GrpLoc.Visible = False
        txtnom.Focus()
        novo = False
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs)
        Dim rpt As New CrpFornecedor
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Embarcação "
        rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub mskCnpj_Validated(sender As Object, e As EventArgs) Handles mskCnpj.Validated
        Dim Valida As New ClsValidadorCPFeCNPJ
        Valida.cnpj = mskCnpj.Text
        If Valida.isCnpjValido = False Then
            MsgBox("CNPJ inválido!", vbOK & vbInformation)
            mskCnpj.Text = ""
        Else
            mskCnpj.Mask = "00,000,000/0000-00"
        End If
    End Sub
End Class