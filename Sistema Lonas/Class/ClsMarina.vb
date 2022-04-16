Public Class ClsMarina
    Dim m_cod As Integer
    Dim m_nomemp As String
    Dim m_endereco As String
    Dim m_Comp As String
    Dim m_bairro As String
    Dim m_cidade As String
    Dim m_estado As String
    Dim m_Cep As String

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

    Public Property NomeEmpresa() As String
        Get
            Return m_nomemp
        End Get
        Set(ByVal value As String)
            m_nomemp = value
        End Set
    End Property
    Public Property Endereco() As String
        Get
            Return m_endereco
        End Get
        Set(ByVal value As String)
            m_endereco = value
        End Set
    End Property
    Public Property Complemento() As String
        Get
            Return m_Comp
        End Get
        Set(ByVal value As String)
            m_Comp = value
        End Set
    End Property

    Public Property bairro() As String
        Get
            Return m_bairro
        End Get
        Set(ByVal value As String)
            m_bairro = value
        End Set
    End Property

    Public Property cidade() As String
        Get
            Return m_cidade
        End Get
        Set(ByVal value As String)
            m_cidade = value
        End Set
    End Property

    Public Property estado() As String
        Get
            Return m_estado
        End Get
        Set(ByVal value As String)
            m_estado = value
        End Set
    End Property

    Public Property CEP() As String
        Get
            Return m_Cep
        End Get
        Set(ByVal value As String)
            m_Cep = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into tabmarina ( nomemarina, Endereco, Compl, Bairro, Cidade, Estado, CEP) values ('" & m_nomemp & "','" & m_endereco & "', '" & m_Comp & "', '" & m_bairro & "','" & m_cidade & "','" & m_estado & "','" & m_Cep & "')"
            objbanco.executar_comando(sql)
            sql = "select max(codigo) as codigo from tabmarina"
            m_cod = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update tabmarina set nomemarina='" & m_nomemp & "', Endereco='" & m_endereco & "', Compl='" & m_Comp & "', Bairro='" & m_bairro & "', Cidade ='" & m_cidade & "', Estado ='" & m_estado & "', CEP='" & m_Cep & "' where codigo=" & m_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabmarina where codigo=" & chave
            objbanco.executar_comando(sql)
            Return True
        End If
    End Function
    Public Function LocalizarPorCodigoOuNome(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from tabmarina where codigo=" & campo
        Else
            sql = "select * from tabmarina where nomemarina='" & campo & "'"
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
            sql = "select * from tabmarina where codigo=" & campo
        Else
            sql = "select * from tabmarina where nomemarina like '" & campo & "%' order by nomemarina"
        End If
        objdtLocal = objbanco.localizar(sql)
        Return objdtLocal
    End Function
    Private Sub mostrar_DadosVindosDoBanco()
        m_cod = objdtLocal.Rows(0).Item(0)
        m_nomemp = objdtLocal.Rows(0).Item(1)
        m_endereco = objdtLocal.Rows(0).Item(2)
        m_Comp = objdtLocal.Rows(0).Item(3)
        m_bairro = objdtLocal.Rows(0).Item(4)
        m_cidade = objdtLocal.Rows(0).Item(5)
        m_estado = objdtLocal.Rows(0).Item(6)
        m_Cep = objdtLocal.Rows(0).Item(7)
    End Sub
End Class
