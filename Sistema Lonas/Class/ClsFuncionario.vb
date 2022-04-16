Public Class ClsFuncionario
    Dim m_cod As Integer
    Dim m_nome As String
    Dim m_hora As String
    Dim m_tel As String
    Dim m_email As String
    Dim m_dtadm As Date
    Dim m_rg As String
    Dim m_atuacao As String


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
    Public Property Horarios As String
        Get
            Return m_hora
        End Get
        Set(value As String)
            m_hora = value
        End Set
    End Property
    Public Property Telefone As String
        Get
            Return m_tel
        End Get
        Set(value As String)
            m_tel = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return m_email
        End Get
        Set(value As String)
            m_email = value
        End Set
    End Property
    Public Property DtAdmissao As Date
        Get
            Return m_dtadm
        End Get
        Set(value As Date)
            m_dtadm = value
        End Set
    End Property
    Public Property RG As String
        Get
            Return m_rg
        End Get
        Set(value As String)
            m_rg = value
        End Set
    End Property
    Public Property Atuacao As String
        Get
            Return m_atuacao
        End Get
        Set(value As String)
            m_atuacao = value
        End Set
    End Property
    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into tabfuncionario (nome, horarios, telefone, contato, dataadmissao, rg, areaatuacao) values ('" & m_nome & "', '" & m_hora & "', '" & m_tel & "', '" & m_email & "', '" & m_dtadm & "', '" & m_rg & "', '" & m_atuacao & "')"
            objbanco.executar_comando(sql)
            sql = "select max(codigo) as codigo from tabfuncionario"
            m_cod = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update tabfuncionario set nome='" & m_nome & "', horarios='" & m_hora & "', telefone='" & m_tel & "', contato='" & m_email & "', dataadmissao='" & m_dtadm & "', rg='" & m_rg & "', areaatuacao='" & m_atuacao & "' where codigo=" & m_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabfuncionario where codigo = " & chave
            objbanco.executar_comando(sql)
            Return True
        End If
    End Function
    Public Function LocalizarPorCodigoOuNome(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from tabfuncionario where codigo=" & campo
        Else
            sql = "select * from tabfuncionario where nome='" & campo & "'"
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
        m_nome = objdtLocal.Rows(0).Item(1)
        m_hora = objdtLocal.Rows(0).Item(2)
        m_tel = objdtLocal.Rows(0).Item(3)
        m_email = objdtLocal.Rows(0).Item(4)
        m_dtadm = objdtLocal.Rows(0).Item(5)
        m_rg = objdtLocal.Rows(0).Item(6)
        m_atuacao = objdtLocal.Rows(0).Item(7)
    End Sub

    Public Function LocalizarFiltro(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from tabfuncionario where codigo=" & campo
        Else
            sql = "select * from tabfuncionario where nome like '" & campo & "%' order by nome"
        End If
        objdtLocal = objbanco.localizar(sql)
        Return objdtLocal
    End Function
End Class
