Public Class ClsCliente
    Dim m_cod As Integer
    Dim m_nome As String
    Dim m_tel As String
    Dim m_cpf As String
    Dim m_cnpj As String
    Dim m_ins As String
    Dim m_mail As String
    Dim m_end As String
    Dim m_comp As String
    Dim m_bair As String
    Dim m_cid As String
    Dim m_est As String
    Dim m_cep As String

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
    Public Property Telefone As String
        Get
            Return m_tel
        End Get
        Set(value As String)
            m_tel = value
        End Set
    End Property
    Public Property Cpf As String
        Get
            Return m_cpf
        End Get
        Set(value As String)
            m_cpf = value
        End Set
    End Property
    Public Property CNPJ As String
        Get
            Return m_cnpj
        End Get
        Set(value As String)
            m_cnpj = value
        End Set
    End Property
    Public Property Inscricao As String
        Get
            Return m_ins
        End Get
        Set(value As String)
            m_ins = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return m_mail
        End Get
        Set(value As String)
            m_mail = value
        End Set
    End Property
    Public Property Endereco As String
        Get
            Return m_end
        End Get
        Set(value As String)
            m_end = value
        End Set
    End Property
    Public Property Complemento As String
        Get
            Return m_comp
        End Get
        Set(value As String)
            m_comp = value
        End Set
    End Property
    Public Property Bairro As String
        Get
            Return m_bair
        End Get
        Set(value As String)
            m_bair = value
        End Set
    End Property
    Public Property Cidade As String
        Get
            Return m_cid
        End Get
        Set(value As String)
            m_cid = value
        End Set
    End Property
    Public Property Estado As String
        Get
            Return m_est
        End Get
        Set(value As String)
            m_est = value
        End Set
    End Property
    Public Property Cep As String
        Get
            Return m_cep
        End Get
        Set(value As String)
            m_cep = value
        End Set
    End Property
    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into tabcliente (nomcli, tel, email, cpf, ende, complemento, bairro, cidade, estado, cep, cnpj, inscricaoestadual) values ('" & m_nome & "', '" & m_tel & "', '" & m_mail & "','" & m_cpf & "','" & m_end & "','" & m_comp & "','" & m_bair & "','" & m_cid & "','" & m_est & "','" & m_cep & "', '" & m_cnpj & "', '" & m_ins & "')"
            objbanco.executar_comando(sql)
            sql = "select max(codcli) as codigo from tabcliente"
            m_cod = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update tabcliente set nomcli='" & m_nome & "', tel='" & m_tel & "', email='" & m_mail & "', cpf ='" & m_cpf & "', ende ='" & m_end & "', complemento='" & m_comp & "', bairro='" & m_bair & "', cidade='" & m_cid & "', estado='" & m_est & "', cep='" & m_cep & "', cnpj='" & m_cnpj & "', inscricaoestadual='" & m_ins & "' where codcli=" & m_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Excluir(chave As Integer) As Boolean

        If MessageBox.Show("Deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabcliente where codcli=" & chave
            objbanco.executar_comando(sql)
            Return True
        End If
    End Function
    Public Function LocalizarPorCodigoOuNome(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from tabcliente where codcli=" & campo
        Else
            sql = "select * from tabcliente where nomcli='" & campo & "'"
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
        m_tel = objdtLocal.Rows(0).Item(2)
        m_cpf = objdtLocal.Rows(0).Item(3)
        m_mail = objdtLocal.Rows(0).Item(4)
        m_end = objdtLocal.Rows(0).Item(5)
        m_comp = objdtLocal.Rows(0).Item(6)
        m_bair = objdtLocal.Rows(0).Item(7)
        m_cid = objdtLocal.Rows(0).Item(8)
        m_est = objdtLocal.Rows(0).Item(9)
        m_cep = objdtLocal.Rows(0).Item(10)
        m_cnpj = objdtLocal.Rows(0).Item(11)
        m_ins = objdtLocal.Rows(0).Item(12)
    End Sub

    Public Function LocalizarFiltro(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from tabcliente where codcli=" & campo
        Else
            sql = "select * from tabcliente where nomcli like '" & campo & "%' order by nomcli"
        End If
        objdtLocal = objbanco.localizar(sql)
        Return objdtLocal
    End Function
End Class