Public Class ClsEntradaMateriais
    Dim m_cod As Integer
    Dim m_codmat As Integer
    Dim m_val As Single
    Dim m_for As Integer
    Dim m_qtd As Integer
    Dim m_data As Date

    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objdtLocal As New DataTable


    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property Material() As Integer
        Get
            Return m_codmat
        End Get
        Set(ByVal value As Integer)
            m_codmat = value
        End Set
    End Property

    Public Property Valor() As Single
        Get
            Return m_val
        End Get
        Set(ByVal value As Single)
            m_val = value
        End Set
    End Property

    Public Property Fornecedor() As Integer
        Get
            Return m_for
        End Get
        Set(ByVal value As Integer)
            m_for = value
        End Set
    End Property

    Public Property Quantidade() As Integer
        Get
            Return m_qtd
        End Get
        Set(ByVal value As Integer)
            m_qtd = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return m_data
        End Get
        Set(ByVal value As Date)
            m_data = value
        End Set
    End Property

    Public Sub Gravar()

        sql = "insert into tabentprod (codprod, qtdent, valorent, dtent, codforn) values ('" & m_codmat & "', '" & m_qtd & "', '" & m_val & "', '" & m_data & "', '" & m_for & "')"
        objbanco.executar_comando(sql)

    End Sub

    Public Sub EntradaEstoque(codigo As Integer)
        sql = "Update Tabestoque set qtdestoque=qtdestoque+" & 1 & " where codigo=" & codigo
        objbanco.executar_comando(sql)
    End Sub
    Public Function Localizar_porData(ini As Date, fin As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("RelatEntradaMat", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = ini
        objda.SelectCommand.Parameters("campo2").Value = fin

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function
End Class
