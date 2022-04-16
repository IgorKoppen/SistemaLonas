Public Class ClsCadastroMateriais
    Dim m_codi As Integer
    Dim m_nome As String
    Dim m_uni As String
    Dim m_min As String
    Dim m_max As String
    Dim m_desc As String

    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objdtLocal As New DataTable

    Public Property Codigo() As String
        Get
            Return m_codi
        End Get
        Set(ByVal value As String)
            m_codi = value
        End Set
    End Property

    Public Property NomeMaterial() As String
        Get
            Return m_nome
        End Get
        Set(ByVal value As String)
            m_nome = value
        End Set
    End Property

    Public Property UnidadeMedida() As String
        Get
            Return m_uni
        End Get
        Set(ByVal value As String)
            m_uni = value
        End Set
    End Property

    Public Property QuantidadeMinima() As String
        Get
            Return m_min
        End Get
        Set(ByVal value As String)
            m_min = value
        End Set
    End Property

    Public Property QuantidadeMaxima() As String
        Get
            Return m_max
        End Get
        Set(ByVal value As String)
            m_max = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return m_desc
        End Get
        Set(ByVal value As String)
            m_desc = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into tabitensfornecido (produto, unimed, despro, qtdmin, qtdmax) values ('" & m_nome & "', '" & m_uni & "', '" & m_desc & "', '" & m_min & "', '" & m_max & "')"
            objbanco.executar_comando(sql)
            sql = "select max(codigomat) as codigo from tabitensfornecido"
            m_codi = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update tabitensfornecido set produto='" & m_nome & "', unimed='" & m_uni & "', despro='" & m_desc & "', qtdmin='" & m_min & "', qtdmax='" & m_max & "' where codigomat=" & m_codi
            objbanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabitensfornecido where codigomat=" & chave
            objbanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function LocalizarPorCodigoOuNome(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from tabitensfornecido where codigomat=" & campo
        Else
            sql = "select * from tabitensfornecido where produto='" & campo & "'"
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
        m_codi = objdtLocal.Rows(0).Item(0)
        m_nome = objdtLocal.Rows(0).Item(1)
        m_uni = objdtLocal.Rows(0).Item(2)
        m_desc = objdtLocal.Rows(0).Item(3)
        m_min = objdtLocal.Rows(0).Item(4)
        m_max = objdtLocal.Rows(0).Item(5)
    End Sub

    Public Function LocalizarFiltro(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from tabitensfornecido where codigomat=" & campo
        Else
            sql = "select * from tabitensfornecido where Produto like '" & campo & "%' order by Produto"
        End If
        objdtLocal = objbanco.localizar(sql)
        Return objdtLocal
    End Function

    Public Sub atualizarEstoque(codpro As Integer, qtd As Integer)
        sql = "update tabitensfornecido set qtdatu=qtdatu+" & qtd & " where codigomat=" & codpro
        objbanco.executar_comando(sql)
    End Sub

    Public Sub baixarEstoque(codpro As Integer, qtd As Integer)
        sql = "update tabitensfornecido set qtdatu=qtdatu-" & qtd & " where codigomat=" & codpro
        objbanco.executar_comando(sql)
    End Sub


End Class
