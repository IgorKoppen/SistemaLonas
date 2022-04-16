Public Class Pedidos
    Dim objControle As New ClsControle
    Dim objPed As New ClsPedido
    Dim objCli As New ClsCliente
    Dim novo As Boolean

    Public quemchamou As String = ""
    Public campochave As Integer
    Private Sub Pedidos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtCodCli.Enabled = False
        TxtCli.Enabled = False
        GroupBox1.Enabled = True
        TxtCodCli.Focus()
        novo = True
    End Sub

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        GrpLoc.Visible = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If CboPed.Text = "" Then
            MsgBox("Digite qual foi o pedido!", vbInformation)
            CboPed.Focus()
        ElseIf TxtCodCli.Text = "" Then
            MsgBox("Digite o código do cliente!", vbInformation)
            TxtCodCli.Focus()
        ElseIf MskVal.Text = "" Then
            MsgBox("Digite o valor do pedido!", vbInformation)
            MskVal.Focus()
        ElseIf MskVal.Text = "" Then
            MsgBox("Digite o valor do pedido!", vbInformation)
            MskVal.Focus()
        Else
            objPed.Codigo = Val(TxtCod.Text)
            objPed.Nomecli = TxtCli.Text
            objPed.Cliente = TxtCodCli.Text
            objPed.ValorTotal = MskVal.Text
            objPed.DataDoPedido = DtaPed.Text
            objPed.PrazoMinimo = DtaMin.Text
            objPed.PrazoMaximo = DtaMax.Text
            objPed.Pedido = CboPed.SelectedItem.ToString
            objPed.Gravar(novo)

            TxtCod.Text = objPed.Codigo
            GroupBox1.Enabled = False
            TxtCodCli.Enabled = False
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
        Pedidos_Load(Nothing, Nothing)
        CboPed.Text = ""
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objPed.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            lblCli.Visible = True
            TxtCli.Visible = True
            objControle.habilitar_botoes(Me, True)
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub

    Private Sub mostrar_DadosVindosDaClasse()
        TxtCod.Text = objPed.Codigo
        TxtCodCli.Text = objPed.Cliente
        TxtCli.Text = objPed.Nomecli
        MskVal.Text = objPed.ValorTotal
        DtaPed.Text = objPed.DataDoPedido
        DtaMin.Text = objPed.PrazoMinimo
        DtaMax.Text = objPed.PrazoMaximo
        CboPed.SelectedItem = objPed.Pedido

    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        Try
            If objPed.Excluir(TxtCod.Text) = True Then
                objControle.Limpar_tela(Me)
                BtnExc.Enabled = False
                BtnAlt.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Você não pode excluir um pedido pois já tem registro de pagamento", vbInformation)
        End Try
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtCli.Enabled = False
        TxtCodCli.Enabled = False
        GroupBox1.Enabled = True
        GrpLoc.Visible = False
        DtaMax.Enabled = True
        DtaMin.Enabled = True
        TxtCodCli.Focus()
        novo = False
    End Sub

    Private Sub BtnCli_Click(sender As Object, e As EventArgs) Handles BtnCli.Click
        ConsultaCliente.quemChamou = Me.Name
        ConsultaCliente.ShowDialog()
    End Sub

    Private Sub CboVdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPed.SelectedIndexChanged

    End Sub

    Private Sub TxtCodCli_Validated(sender As Object, e As EventArgs)
        If TxtCli.Text <> "" Then
            If objCli.LocalizarPorCodigoOuNome(TxtCodCli.Text) = True Then
                TxtCodCli.Text = objCli.Nome
            Else
                TxtCli.Text = ""
                TxtCodCli.Text = ""
                TxtCli.Focus()
            End If
        End If
    End Sub



End Class