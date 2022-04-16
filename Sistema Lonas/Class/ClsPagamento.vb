Public Class ClsPagamento
    Dim m_cod As Integer
    Dim m_ped As Integer
    Dim m_val As Single
    Dim m_forma As String
    Dim m_venc As Date
    Dim m_rec As Boolean
    Dim m_vis As Boolean
    Dim m_tot As Single

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

    Public Property Pedido() As Integer
        Get
            Return m_ped
        End Get
        Set(ByVal value As Integer)
            m_ped = value
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

    Public Property FormaPagamento() As String
        Get
            Return m_forma
        End Get
        Set(ByVal value As String)
            m_forma = value
        End Set
    End Property

    Public Property Vencimento() As Date
        Get
            Return m_venc
        End Get
        Set(ByVal value As Date)
            m_venc = value
        End Set
    End Property

    Public Property Vista() As Boolean
        Get
            Return m_vis
        End Get
        Set(ByVal value As Boolean)
            m_vis = value
        End Set
    End Property

    Public Property Total() As Single
        Get
            Return m_tot
        End Get
        Set(ByVal value As Single)
            m_tot = value
        End Set
    End Property

    Public Property Recebimento() As Boolean
        Get
            Return m_rec
        End Get
        Set(ByVal value As Boolean)
            m_rec = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into TabContReceb (pedido, valor, FormadePagamento, venc, rec, total, vista) values ('" & m_ped & "', '" & m_val & "','" & m_forma & "','" & m_venc & "'," & m_rec & ", '" & m_tot & "', " & m_vis & ")"
            objbanco.executar_comando(sql)
            sql = "select max(CodContReceb) as codigo from TabContReceb"
            m_cod = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update TabContReceb set pedido='" & m_ped & "', valor='" & m_val & "', FormadePagamento='" & m_forma & "', venc='" & m_venc & "', rec =" & m_rec & ", total='" & m_tot & "', vista=" & m_vis & " where CodContReceb=" & m_cod
            objbanco.executar_comando(sql)
        End If

    End Sub
    Public Function Excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabcontreceb where codcontreceb=" & chave
            objbanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function LocalizarPorCodigoOuNome(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from tabcontreceb where codcontreceb=" & campo
        Else
            sql = "select * from tabcontreceb where pedido='" & campo & "'"
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

    Private Sub mostrar_DadosVindosDoBanco()
        m_cod = objdtLocal.Rows(0).Item(0)
        m_ped = objdtLocal.Rows(0).Item(1)
        m_val = objdtLocal.Rows(0).Item(2)
        m_forma = objdtLocal.Rows(0).Item(3)
        m_venc = objdtLocal.Rows(0).Item(4)
        m_rec = objdtLocal.Rows(0).Item(5)
        m_tot = objdtLocal.Rows(0).Item(6)
        m_vis = objdtLocal.Rows(0).Item(7)
    End Sub
End Class
