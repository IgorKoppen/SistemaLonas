Imports System.Data.OleDb

Module MdlAcesso

    Public Function GetConnection() As OleDbConnection
        Dim conexao As String = "Provider=microsoft.ace.oledb.12.0;data source=timoneiros2020_2000C.mdb"
        Return New OleDbConnection(conexao)
    End Function
End Module
