Public Class ClsContasApagar
    Dim m_CodcontPag As Integer
    Dim m_tipo As Integer
    Dim m_valor As Single
    Dim m_vencimento As Date
    Dim m_quitada As Boolean
    Dim m_descricao As String

    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objdtLocal As New DataTable

    Public Property Codigo As Integer
        Get
            Return m_CodcontPag
        End Get
        Set(value As Integer)
            m_CodcontPag = value
        End Set
    End Property

    Public Property tipo As Integer
        Get
            Return m_tipo
        End Get
        Set(value As Integer)
            m_tipo = value
        End Set
    End Property
    Public Property Valor As Single
        Get
            Return m_valor
        End Get
        Set(value As Single)
            m_valor = value
        End Set
    End Property
    Public Property Vencimento As Date
        Get
            Return m_vencimento
        End Get
        Set(value As Date)
            m_vencimento = value
        End Set
    End Property

    Public Property Quitada As Boolean
        Get
            Return m_quitada
        End Get
        Set(value As Boolean)
            m_quitada = value
        End Set
    End Property
    Public Property Descricao As String
        Get
            Return m_descricao
        End Get
        Set(value As String)
            m_descricao = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into TabContPag (tipo, Valor, Venci, Quita, Descricao) values ('" & m_tipo & "', '" & m_valor & "', '" & m_vencimento & "'," & m_quitada & ",'" & m_descricao & "')"
            objbanco.executar_comando(sql)
            sql = "select max(CodcontPag) as codigo from TabContPag"
            m_CodcontPag = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update TabContPag set tipo='" & m_tipo & "', valor='" & m_valor & "', Venci='" & m_vencimento & "', Quita =" & m_quitada & ", Descricao ='" & m_descricao & "' where CodcontPag=" & m_CodcontPag
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from TabContPag where CodcontPag=" & chave
            objbanco.executar_comando(sql)
            Return True
        End If
    End Function
    Public Function LocalizarPorCodigo(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from TabContPag where CodcontPag=" & campo
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
        m_CodcontPag = objdtLocal.Rows(0).Item(0)
        m_tipo = objdtLocal.Rows(0).Item(1)
        m_valor = objdtLocal.Rows(0).Item(2)
        m_vencimento = objdtLocal.Rows(0).Item(3)
        m_quitada = objdtLocal.Rows(0).Item(4)
        m_descricao = objdtLocal.Rows(0).Item(5)
    End Sub
End Class

