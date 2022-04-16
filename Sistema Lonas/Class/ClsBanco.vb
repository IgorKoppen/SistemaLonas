Imports System.Data.OleDb

Public Class ClsBanco
    Dim conexao As String = "Provider=microsoft.ace.oledb.12.0;data source=timoneiros2020_2000C.mdb"
    Public objcon As New OleDb.OleDbConnection(conexao)
    Private Sub abrir_banco()
        objcon.Open()
    End Sub
    Private Sub fechar_banco()
        objcon.Close()
    End Sub
    Public Sub executar_comando(sql As String)
        Call abrir_banco()
        Dim objcmd As New OleDb.OleDbCommand(sql, objcon)
        objcmd.ExecuteNonQuery()
        Call fechar_banco()
    End Sub
    Public Function buscar_ultimoRegistro(sql As String) As Integer
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataTable
        objda.Fill(objdt)
        Return objdt.Rows(0).Item(0)
    End Function

    Public Function localizar(sql As String) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataTable
        objda.Fill(objdt)
        Return objdt
    End Function

    

End Class
