Public Class Funcionarios
    Dim objControle As New ClsControle
    Dim objFun As New ClsFuncionario
    Dim novo As Boolean

    Public quemchamou As String = ""
    Public campochave As Integer
    Private Sub Funcionarios_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        BtnImp.Enabled = False
    End Sub
    Private Sub BtnNov_Click_1(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = True
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click

        If TxtNom.Text = "" Then
            MsgBox("Digite o nome do funcionario!", vbInformation)
            TxtNom.Focus()
        ElseIf TxtHor.Text = "" Then
            MsgBox("Digite o horario do funcionario!", vbInformation)
            TxtHor.Focus()
        ElseIf MskTel.Text = "(  )      -" Then
            MsgBox("Digite o telefone do funcionario!", vbInformation)
            MskTel.Focus()
        ElseIf TxtEma.Text = "" Then
            MsgBox("Digite o email do funcionario!", vbInformation)
            TxtEma.Focus()
        ElseIf TxtRg.Text = "" Then
            MsgBox("Digite o RG do funcionario!", vbInformation)
            TxtRg.Focus()
        ElseIf dtpadmissao.Text = "" Then
            MsgBox("Digite a data de adimissão do funcionario!", vbInformation)
            dtpadmissao.Focus()
        ElseIf TxtAra.Text = "" Then
            MsgBox("Digite a área de atuação do funcionario!", vbInformation)
            TxtAra.Focus()
        Else
            objFun.Codigo = Val(TxtCod.Text)
            objFun.Nome = TxtNom.Text
            objFun.Horarios = TxtHor.Text
            objFun.Telefone = MskTel.Text
            objFun.Email = TxtEma.Text
            objFun.RG = TxtRg.Text
            objFun.DtAdmissao = dtpadmissao.Text
            objFun.Atuacao = TxtAra.Text
            objFun.Email = TxtEma.Text
            objFun.Gravar(novo)
            TxtCod.Text = objFun.Codigo

            objControle.habilitar_tela(Me, False)
            objControle.habilitar_botoes(Me, True)
        End If
    End Sub
    Private Sub BtnExc_Click_1(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objFun.Excluir(TxtCod.Text) = True Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If
    End Sub
    Private Sub BtnLoc_Click_1(sender As Object, e As EventArgs) Handles BtnLoc.Click
        GrpLoc.Visible = True
        TxtLoc.Text = ""
        BtnOK.Enabled = False
        TxtLoc.Focus()
    End Sub
    Private Sub BtnAlt_Click_1(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        GrpLoc.Visible = False
        TxtNom.Focus()
        novo = False
    End Sub
    Private Sub BtnCan_Click_1(sender As Object, e As EventArgs) Handles BtnCan.Click
        Me.Funcionarios_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click

    End Sub

    Private Sub BtnSai_Click_1(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub
    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objFun.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            objControle.habilitar_botoes(Me, True)
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub
    Private Sub mostrar_DadosVindosDaClasse()
        TxtCod.Text = objFun.Codigo
        TxtNom.Text = objFun.Nome
        TxtHor.Text = objFun.Horarios
        MskTel.Text = objFun.Telefone
        TxtEma.Text = objFun.Email
        TxtRg.Text = objFun.RG
        dtpadmissao.Text = objFun.DtAdmissao
        TxtAra.Text = objFun.Atuacao
    End Sub
End Class