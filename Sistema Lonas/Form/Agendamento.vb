Public Class Agendamento
    Dim objControle As New ClsControle
    Dim objAg As New ClsAgendamento
    Dim novo As Boolean
    Dim Cli As New ConsultaEmbarcaoComClie
    Public quemchamou As String = ""
    Public cliEmba As String
    Private Sub Agendamento_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub Agendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        btnalt.Enabled = False
        btnexc.Enabled = False
        GrpLoc.Visible = False
        BtnNom.Enabled = False
        GrpDat.Enabled = False
        dtpprazomin.Enabled = False
        dtpprazomax.Enabled = False
        btnEmbarcacao.Enabled = False

    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles btnnov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        BtnNom.Enabled = True
        GrpDat.Enabled = True
        Txtcodcli.Enabled = False
        txtnomcli.Enabled = False
        txtcodemb.Enabled = False
        dtpprazomin.Enabled = True
        dtpprazomax.Enabled = True
        txtEmbarcacao.Enabled = False
        btnEmbarcacao.Enabled = True
        Txtcodcli.Focus()
        novo = True
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles btngra.Click
        If Txtcodcli.Text = "" Then
            MsgBox("Digite o código do cliente!", vbInformation)
            Txtcodcli.Focus()
        ElseIf dtpmed.Value > dtpprazomax.Value Or dtpmed.Value < dtpprazomin.Value Then
            MsgBox("Não é possivel que a data da medicao seja essa data!", vbInformation)
            Txtcodcli.Focus()
        ElseIf txtcodemb.Text = "" Then
            MsgBox("Digite o código da embarcação!", vbInformation)
            txtcodemb.Focus()
        ElseIf Txtcodcli.Text <> cliEmba Then
            MsgBox("Cliente não condiz com embarcação", MsgBoxStyle.Exclamation, "Aviso")
        Else
            objAg.Codigo = Val(TxtCod.Text)
            objAg.Cli = Txtcodcli.Text
            objAg.PrazoMaximo = dtpprazomax.Text
            objAg.PrazoMinimo = dtpprazomin.Text
            objAg.Medicao = dtpmed.Text
            objAg.Embarcacao = txtcodemb.Text
            objAg.Gravar(novo)
            TxtCod.Text = objAg.Codigo
            dtpprazomin.Enabled = False
            dtpprazomax.Enabled = False
            objControle.habilitar_tela(Me, False)
            objControle.habilitar_botoes(Me, True)
            BtnNom.Enabled = False
            btnEmbarcacao.Enabled = False
        End If
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles btnloc.Click
        GrpLoc.Visible = True
        TxtLoc.Text = ""
        BtnOK.Enabled = False
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles btncan.Click
        Agendamento_Load(Nothing, Nothing)
    End Sub
    Private Sub mostrar_DadosVindosDaClasse()
        TxtCod.Text = objAg.Codigo
        Txtcodcli.Text = objAg.Cli
        dtpprazomax.Text = objAg.PrazoMaximo
        dtpprazomin.Text = objAg.PrazoMinimo
        dtpmed.Text = objAg.Medicao
        txtcodemb.Text = objAg.Embarcacao
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles btnexc.Click
        If objAg.Excluir(TxtCod.Text) = True Then
            objControle.Limpar_tela(Me)
            btnexc.Enabled = False
            btnalt.Enabled = False

        End If
    End Sub

    Private Sub btnalt_Click(sender As Object, e As EventArgs) Handles btnalt.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        GrpDat.Enabled = True
        GrpLoc.Visible = False
        TxtCod.Enabled = False
        txtnomcli.Enabled = False
        txtcodemb.Enabled = False
        BtnNom.Enabled = True
        btnEmbarcacao.Enabled = True
        txtEmbarcacao.Enabled = False
        Txtcodcli.Enabled = False
        dtpprazomin.Enabled = True
        dtpprazomax.Enabled = True
        Txtcodcli.Focus()
        novo = True
        GrpLoc.Visible = False
    End Sub

    Private Sub BtnNom_Click(sender As Object, e As EventArgs) Handles BtnNom.Click
        ConsultaCliente.quemChamou = Me.Name
        ConsultaCliente.ShowDialog()
    End Sub

   
    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objAg.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            objControle.habilitar_botoes(Me, True)
            btnEmbarcacao.Enabled = False
            BtnNom.Enabled = False
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub

    Private Sub btnEmbarcacao_Click(sender As Object, e As EventArgs) Handles btnEmbarcacao.Click
        If Txtcodcli.TextLength > 0 Then
            ConsultaEmbarcaoComClie.quemChamou = Me.Name
            ConsultaEmbarcaoComClie.ShowDialog()
        ElseIf Txtcodcli.TextLength = 0 Then
            MsgBox("Colocar o cliente primeiro", MsgBoxStyle.Exclamation, "Aviso")
        End If
        If MsgBoxResult.Ok Then
            ConsultaEmbarcaoComClie.Close()
        End If

    End Sub
End Class