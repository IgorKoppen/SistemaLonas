Public Class ClsPedido
    Dim m_cod As Integer
    Dim m_codcli As Integer
    Dim m_nomcli As String
    Dim m_Vtot As Single
    Dim m_DatP As Date
    Dim m_Pmin As Date
    Dim m_pmax As Date
    Dim m_pedido As String

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

    Public Property Cliente() As Integer
        Get
            Return m_codcli
        End Get
        Set(ByVal value As Integer)
            m_codcli = value
        End Set
    End Property
    Public Property Nomecli() As String
        Get
            Return m_nomcli
        End Get
        Set(ByVal value As String)
            m_nomcli = value
        End Set
    End Property

    Public Property ValorTotal() As Single
        Get
            Return m_Vtot
        End Get
        Set(ByVal value As Single)
            m_Vtot = value
        End Set
    End Property

    Public Property DataDoPedido() As Date
        Get
            Return m_DatP
        End Get
        Set(ByVal value As Date)
            m_DatP = value
        End Set
    End Property

    Public Property PrazoMinimo() As Date
        Get
            Return m_Pmin
        End Get
        Set(ByVal value As Date)
            m_Pmin = value
        End Set
    End Property

    Public Property PrazoMaximo() As Date
        Get
            Return m_pmax
        End Get
        Set(ByVal value As Date)
            m_pmax = value
        End Set
    End Property

    Public Property Pedido() As String
        Get
            Return m_pedido
        End Get
        Set(ByVal value As String)
            m_pedido = value
        End Set
    End Property


    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into tabpedido (codcli, nomcli, Valpedtot, dataped, pramin, pramax, Pedido) values ('" & m_codcli & "', '" & m_nomcli & "', '" & m_Vtot & "', '" & m_DatP & "','" & m_Pmin & "','" & m_pmax & "','" & m_pedido & "')"
            objbanco.executar_comando(sql)
            sql = "select max(codped) as codigo from tabpedido"
            m_cod = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update tabpedido set codcli='" & m_codcli & "', nomcli='" & m_nomcli & "', Valpedtot='" & m_Vtot & "', dataped='" & m_DatP & "', pramin ='" & m_Pmin & "', pramax ='" & m_pmax & "', Pedido='" & m_pedido & "' where codped=" & m_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabpedido where codped=" & chave
            objbanco.executar_comando(sql)
            Return True
        End If
    End Function
    Public Function LocalizarPorCodigoOuNome(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from tabpedido where codped=" & campo
        Else
            sql = "select * from tabpedido where nomcli='" & campo & "'"
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

    Public Function LocalizarFiltro(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from TabPedido where codped=" & campo
        Else
            sql = "select * from TabPedido where nomcli like '" & campo & "%' order by nomcli"
        End If
        objdtLocal = objbanco.localizar(sql)
        Return objdtLocal
    End Function

    Private Sub mostrar_DadosVindosDoBanco()
        m_cod = objdtLocal.Rows(0).Item(0)
        m_codcli = objdtLocal.Rows(0).Item(1)
        m_nomcli = objdtLocal.Rows(0).Item(2)
        m_Vtot = objdtLocal.Rows(0).Item(3)
        m_DatP = objdtLocal.Rows(0).Item(4)
        m_Pmin = objdtLocal.Rows(0).Item(5)
        m_pmax = objdtLocal.Rows(0).Item(6)
        m_pedido = objdtLocal.Rows(0).Item(7)
    End Sub

    Public Function Localizar_porData(dataini As Date, datafin As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrPedidoData", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafin

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

End Class