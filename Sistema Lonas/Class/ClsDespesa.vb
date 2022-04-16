Public Class ClsDespesa
    Dim m_cod As Integer
    Dim m_nome As String

    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objdtLocal As New DataTable

    Public Property Codigo As Integer
        Get
            Return m_cod
        End Get
        Set(value As Integer)
            m_cod = value
        End Set
    End Property
    Public Property Nome As String
        Get
            Return m_nome
        End Get
        Set(value As String)
            m_nome = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into TabDespesa (Nome) values ('" & m_nome & "')"
            objbanco.executar_comando(sql)
            sql = "select max(Codigo) as codigo from TabDespesa"
            m_cod = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update TabDespesa set Nome='" & m_nome & "' where codigo=" & m_cod
            objbanco.executar_comando(sql)
        End If

    End Sub
    Public Function LocalizarFiltro(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from TabDespesa where Codigo=" & campo
        Else
            sql = "select * from TabDespesa where Nome like '" & campo & "%' order by Nome"
        End If
        objdtLocal = objbanco.localizar(sql)
        Return objdtLocal
    End Function

    Public Function LocalizarPorCodigoOuNome(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from TabDespesa where codigo=" & campo
        Else
            sql = "select * from TabDespesa where Nome='" & campo & "'"
        End If
        objdtLocal = objbanco.localizar(sql)
        If objdtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não encontrado")
            Return False
        Else
            Call mostrar_DadosVindosDoBanco()
            Return True
        End If
    End Function
    Public Function Localizar_porData(dataini As Date, datafin As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VwDespesa", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafin

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

    Public Function Localizar_porDataD(dataini As Date, datafin As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("RelatorioFinanceiro", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafin

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

    Public Function Localizar_porDataP(dataini As Date, datafin As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("RelatorioFinanceiro", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafin

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function
    Private Sub mostrar_DadosVindosDoBanco()
        m_cod = objdtLocal.Rows(0).Item(0)
        m_nome = objdtLocal.Rows(0).Item(1)
    End Sub
End Class
