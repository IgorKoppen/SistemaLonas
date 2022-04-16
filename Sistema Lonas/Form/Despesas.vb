Public Class Despesas
    Dim objControle As New ClsControle
    Dim objDesp As New ClsDespesa
    Dim novo As Boolean

    Private Sub Despesas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub Despesas_Load(sender As Object, e As EventArgs) Handles Me.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
    End Sub
    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = True
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If TxtNom.Text = "" Then
            MsgBox("Digite o nome da despesa!")
            TxtNom.Focus()
        Else
            objDesp.Codigo = Val(TxtCod.Text)
            objDesp.Nome = TxtNom.Text
            objDesp.Gravar(novo)
            TxtCod.Text = objDesp.Codigo

            objControle.habilitar_tela(Me, False)
            objControle.habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        GrpLoc.Visible = True
        TxtLoc.Text = ""
        BtnOK.Enabled = False
        TxtLoc.Focus()
    End Sub


    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objDesp.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            objControle.habilitar_botoes(Me, True)
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Despesas_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub



    Private Sub mostrar_DadosVindosDaClasse()
        TxtCod.Text = objDesp.Codigo
        TxtNom.Text = objDesp.Nome

    End Sub
    Private Sub BtnAlt_Click_1(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        GrpLoc.Visible = False
        TxtCod.Enabled = False
        TxtNom.Focus()
        GrpLoc.Visible = False
        novo = False
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs)

    End Sub
End Class