Public Class Pagamento
    Dim objControle As New ClsControle
    Dim objPag As New ClsPagamento
    Dim novo As Boolean
    Public quemchamou As String = ""
    Private Sub Pagamento_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub Pagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        btnverificar.Enabled = False
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        GrpLoc.Visible = False

    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If txtcodped.Text = "" Then
            MsgBox("Digite o código do pedido!", vbInformation)
            txtcodped.Focus()
        ElseIf txtval.Text = "" Then
            MsgBox("Digite o valor do pedido!", vbInformation)
            txtval.Focus()
        ElseIf CboPag.Text = "" Then
            MsgBox("Digite a forma de pagamento!", vbInformation)
            CboPag.Focus()
        ElseIf dtpvenc.Text = "" Then
            MsgBox("Digite a data de vencimento!", vbInformation)
            dtpvenc.Focus()
        Else
            objPag.Codigo = Val(txtcod.Text)
            objPag.Pedido = txtcodped.Text
            objPag.Valor = txtval.Text
            objPag.FormaPagamento = CboPag.SelectedItem.ToString
            objPag.Vencimento = dtpvenc.Text
            objPag.Recebimento = chbrec.Checked
            objPag.Vista = ChbVis.Checked
            objPag.Total = TxtPag.Text
            objPag.Gravar(novo)
            txtcod.Text = objPag.Codigo

            objControle.habilitar_tela(Me, False)
            objControle.habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, False)
        dtpvenc.Enabled = True
        chbrec.Enabled = True
        btnverificar.Enabled = True
        CboPag.Enabled = True
        txtval.Enabled = True
        txtval.Focus()
        novo = True
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objPag.Excluir(txtcod.Text) = True Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            TxtPag.Text = ""
        End If
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        GrpLoc.Visible = True
        TxtLoc.Text = ""
        BtnOK.Enabled = False
        TxtLoc.Focus()
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, False)
        GrpLoc.Visible = False
        btnverificar.Enabled = True
        dtpvenc.Enabled = True
        chbrec.Enabled = True
        CboPag.Enabled = True
        txtval.Enabled = True
        txtcodped.Focus()
        novo = False
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Pagamento_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objPag.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            objControle.habilitar_botoes(Me, True)
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub

    Private Sub mostrar_DadosVindosDaClasse()
        txtcod.Text = objPag.Codigo
        txtcodped.Text = objPag.Pedido
        txtval.Text = objPag.Valor
        CboPag.SelectedItem = objPag.FormaPagamento
        dtpvenc.Text = objPag.Vencimento
        chbrec.Checked = objPag.Recebimento
        ChbVis.Checked = objPag.Vista
        TxtPag.Text = objPag.Total
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub btnverificar_Click(sender As Object, e As EventArgs) Handles btnverificar.Click
        ConsultaPedido.quemChamou = Me.Name
        ConsultaPedido.ShowDialog()
    End Sub

    Private Sub CboPag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPag.SelectedIndexChanged
        If CboPag.Text.ToUpper = "DINHEIRO" Or CboPag.Text.ToUpper = "BOLETO" Then
            ChbVis.Enabled = True
        Else
            ChbVis.Enabled = False
            ChbVis.Checked = False
            TxtPag.Text = txtval.Text
        End If
    End Sub
    Private Sub ChbVis_CheckedChanged(sender As Object, e As EventArgs) Handles ChbVis.CheckedChanged
        If ChbVis.Checked = True Then
            TxtPag.Text = txtval.Text * 0.93
        Else
            TxtPag.Text = txtval.Text
        End If
    End Sub
    Private Sub txtval_TextChanged(sender As Object, e As EventArgs) Handles txtval.TextChanged
        If ChbVis.Checked = True Then
            TxtPag.Text = txtval.Text * 0.93
        End If
    End Sub
End Class