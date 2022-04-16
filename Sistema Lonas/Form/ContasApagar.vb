Public Class ContasApagar

    Dim objControle As New ClsControle
    Dim objCon As New ClsContasApagar
    Dim novo As Boolean
    Public quemchamou As String = ""
    Private Sub ContasApagar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub ContasApagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        GrpLoc.Visible = False
        BTNtip.Enabled = False
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtCodc.Enabled = False
        BTNtip.Enabled = True
        TxtTip.Enabled = False
        TxtTipName.Enabled = False
        TxtTip.Focus()
        novo = True
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click

        If TxtTip.Text = "" Then
            MsgBox("Selecione o tipo da conta!", vbInformation)
            TxtTip.Focus()
        ElseIf TxtVal.Text = "" Then
            MsgBox("Digite o valor do pagamento!", vbInformation)
            TxtVal.Focus()
        ElseIf DtpVen.Text = "" Then
            MsgBox("Digite o a data co vencimento!", vbInformation)
            DtpVen.Focus()
        Else
            objCon.Codigo = Val(TxtCodc.Text)
            objCon.tipo = TxtTip.Text
            objCon.Valor = TxtVal.Text
            objCon.Vencimento = DtpVen.Text
            objCon.Quitada = CbcVen.Checked
            objCon.Descricao = TxtDes.Text
            objCon.Gravar(novo)
            TxtCodc.Text = objCon.Codigo

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
        ContasApagar_Load(Nothing, Nothing)
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objCon.LocalizarPorCodigo(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            objControle.habilitar_botoes(Me, True)
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub
    Private Sub mostrar_DadosVindosDaClasse()
        TxtCodc.Text = objCon.Codigo
        TxtTip.Text = objCon.tipo
        TxtVal.Text = objCon.Valor
        DtpVen.Text = objCon.Vencimento
        CbcVen.Checked = objCon.Quitada
        TxtDes.Text = objCon.Descricao

    End Sub

    Private Sub BTNtip_Click(sender As Object, e As EventArgs) Handles BTNtip.Click
        ConsultaTipoDespesa.quemChamou = Me.Name
        ConsultaTipoDespesa.ShowDialog()
    End Sub


    Private Sub BtnGravarNovo_Click(sender As Object, e As EventArgs) Handles BtnGravarNovo.Click
        Despesas.Show()
        Despesas.MdiParent = FrmMenu
    End Sub

    Private Sub TxtDes_TextChanged(sender As Object, e As EventArgs) Handles TxtDes.TextChanged

    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        GrpLoc.Visible = False
        TxtCodc.Enabled = False
        TxtTip.Enabled = False
        TxtTipName.Enabled = False
        BTNtip.Enabled = True
        TxtVal.Focus()
        GrpLoc.Visible = False
        novo = False
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objCon.Excluir(TxtCodc.Text) = True Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class