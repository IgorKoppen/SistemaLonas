Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class FrmLogin
    Private Sub PLogin(ByVal login As String, ByVal senha As String)
        Dim dr As OleDbDataReader = Nothing
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "select * from TabUsuario where login = '" & login & "' and senha = '" & senha & "'"
                Dim cmd As New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    Me.Hide()
                    FrmMenu.Show()
                Else
                    MsgBox("Usuário e/ou senha inválidos", vbInformation)
                    txtusuario.Text = ""
                    txtsenha.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                dr.Close()
                con.Close()

            End Try
        End Using
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        PLogin(txtusuario.Text, txtsenha.Text)
    End Sub

    Private Sub cbcSenha_CheckedChanged(sender As Object, e As EventArgs) Handles cbcSenha.CheckedChanged
        If cbcSenha.Checked = True Then
            txtsenha.PasswordChar = ""
        Else
            txtsenha.PasswordChar = "*"
        End If
    End Sub
    Private Sub FrmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                SendKeys.Send("{Tab}")

        End Select

    End Sub
End Class