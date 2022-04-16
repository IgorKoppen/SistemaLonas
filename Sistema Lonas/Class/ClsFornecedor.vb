Public Class ClsFornecedor
    Dim m_codi As Integer
    Dim m_nome As String
    Dim m_cnpj As String
    Dim m_tele As String
    Dim m_vend As String
    Dim m_pix As String

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

    Public Property NomeEmpresa() As String
        Get
            Return m_nome
        End Get
        Set(ByVal value As String)
            m_nome = value
        End Set
    End Property

    Public Property CNPJ() As String
        Get
            Return m_cnpj
        End Get
        Set(ByVal value As String)
            m_cnpj = value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return m_tele
        End Get
        Set(ByVal value As String)
            m_tele = value
        End Set
    End Property

    Public Property NomeVendedor() As String
        Get
            Return m_vend
        End Get
        Set(ByVal value As String)
            m_vend = value
        End Set
    End Property

    Public Property Pix() As String
        Get
            Return m_pix
        End Get
        Set(ByVal value As String)
            m_pix = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into tabcadfornecedore (nomemp, tel, nomvend, cnpj, pix) values ('" & m_nome & "', '" & m_tele & "', '" & m_vend & "','" & m_cnpj & "', '" & m_pix & "')"
            objbanco.executar_comando(sql)
            sql = "select max(codigofor) as codigo from tabcadfornecedore"
            m_codi = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update tabcadfornecedore set nomemp='" & m_nome & "', tel= '" & m_tele & "',nomvend= '" & m_vend & "',cnpj='" & m_cnpj & "', pix='" & m_pix & "' where codigofor=" & m_codi
            objbanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabcadfornecedore where codigofor=" & chave
            objbanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function LocalizarPorCodigoOuNome(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from tabcadfornecedore where codigofor=" & campo
        Else
            sql = "select * from tabcadfornecedore where nomemp='" & campo & "'"
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
        m_tele = objdtLocal.Rows(0).Item(2)
        m_cnpj = objdtLocal.Rows(0).Item(3)
        m_vend = objdtLocal.Rows(0).Item(4)
        m_pix = objdtLocal.Rows(0).Item(5)
    End Sub

    Public Function LocalizarFiltro(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from tabcadfornecedore where codigofor=" & campo
        Else
            sql = "select * from tabcadfornecedore where nomemp like '" & campo & "%' order by nomemp"
        End If
        objdtLocal = objbanco.localizar(sql)
        Return objdtLocal
    End Function
End Class
