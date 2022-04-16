Public Class Embarcacao
    Dim objControle As New ClsControle
    Dim objEmb As New ClsEmbarcacao
    Dim objCli As New ClsCliente
    Dim novo As Boolean
    Public quemchamou As String = ""
    Public campochave As Integer
    Private Sub Embarcacao_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub Embarcacao_Load(sender As Object, e As EventArgs) Handles Me.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        BtnMar.Enabled = False
       
    End Sub
    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        txtcodigo.Enabled = False
        txtcliente.Enabled = False
        TxtNcli.Enabled = False
        txtmarina.Enabled = False
        TxtNmar.Enabled = False
        txtnome.Focus()
        BtnMar.Enabled = True

        novo = True
    End Sub
    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If txtnome.Text = "" Then
            MsgBox("Digite o nome da embarcação!", vbInformation)
            txtnome.Focus()
        ElseIf txtmarca.Text = "" Then
            MsgBox("Digite o nome da marca do barco!", vbInformation)
            txtmarca.Focus()
        ElseIf txtmodelo.Text = "" Then
            MsgBox("Digite o nome do modelo!", vbInformation)
            txtmodelo.Focus()
        ElseIf txtfabricacao.Text = "" Then
            MsgBox("Digite o nome do ano de fabricação!", vbInformation)
            txtfabricacao.Focus()
        ElseIf txtcliente.Text = "" Then
            MsgBox("Digite o código do cliente!", vbInformation)
            txtcliente.Focus()
        ElseIf txtmarina.Text = "" Then
            MsgBox("Digite o código da marina!", vbInformation)
            txtmarina.Focus()
        Else
            objEmb.Codigo = Val(txtcodigo.Text)
            objEmb.NomeBarco = txtnome.Text
            objEmb.Marca = txtmarca.Text
            objEmb.Modelo = txtmodelo.Text
            objEmb.AnoFab = txtfabricacao.Text
            objEmb.Cliente = txtcliente.Text
            objEmb.Marina = txtmarina.Text
            objEmb.Gravar(novo)
            txtcodigo.Text = objEmb.Codigo

            objControle.habilitar_tela(Me, False)
            objControle.habilitar_botoes(Me, True)

            BtnMar.Enabled = False
        End If
    End Sub
    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        Try
            If objEmb.Excluir(txtcodigo.Text) = True Then
                objControle.Limpar_tela(Me)
                BtnExc.Enabled = False
                BtnAlt.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Você não pode excluir essa embarcação devido ela ter um pedidos registrados", vbInformation)
        End Try
    End Sub
    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        GrpLoc.Visible = False
        txtcodigo.Enabled = False
        txtcliente.Enabled = False
        TxtNcli.Enabled = False
        txtmarina.Enabled = False
        TxtNmar.Enabled = False
        txtnome.Focus()
        BtnMar.Enabled = True
        novo = False
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Me.Embarcacao_Load(Nothing, Nothing)
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

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objEmb.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            TxtNcli.Text = ""
            TxtNmar.Text = ""
            objControle.habilitar_botoes(Me, True)
            BtnMar.Enabled = False
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub

    Private Sub mostrar_DadosVindosDaClasse()
        txtcodigo.Text = objEmb.Codigo
        txtmarca.Text = objEmb.Marca
        txtmodelo.Text = objEmb.Modelo
        txtnome.Text = objEmb.NomeBarco
        txtfabricacao.Text = objEmb.AnoFab
        txtcliente.Text = objEmb.Cliente
        txtmarina.Text = objEmb.Marina
    End Sub

    Private Sub BtnMar_Click(sender As Object, e As EventArgs) Handles BtnMar.Click
        ConsultaMarina.quemChamou = Me.Name
        ConsultaMarina.ShowDialog()
    End Sub

    Private Sub BtnCli_Click(sender As Object, e As EventArgs) Handles BtnCli.Click
        ConsultaCliente.quemChamou = Me.Name
        ConsultaCliente.ShowDialog()
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs)

        Dim rpt As New CrpEmbarcacao
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Embarcação "
        rpt.Refresh()
        FrmImp.ShowDialog()

    End Sub

    Private Sub txtfabricacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfabricacao.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub txtfabricacao_TextChanged(sender As Object, e As EventArgs) Handles txtfabricacao.TextChanged

    End Sub

    Private Sub txtcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcliente.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged

    End Sub

    Private Sub txtmarina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmarina.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub txtmarina_TextChanged(sender As Object, e As EventArgs) Handles txtmarina.TextChanged

    End Sub

    Private Sub txtmodelo_TextChanged(sender As Object, e As EventArgs) Handles txtmodelo.TextChanged

    End Sub

    
End Class