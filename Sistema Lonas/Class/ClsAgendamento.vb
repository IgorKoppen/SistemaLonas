Public Class ClsAgendamento
    Dim m_codi As Integer
    Dim m_clie As String
    Dim m_pmax As String
    Dim m_pmin As String
    Dim m_medi As String
    Dim m_emba As Integer

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

    Public Property Cli() As String
        Get
            Return m_clie
        End Get
        Set(ByVal value As String)
            m_clie = value
        End Set
    End Property

    Public Property PrazoMaximo() As String
        Get
            Return m_pmax
        End Get
        Set(ByVal value As String)
            m_pmax = value
        End Set
    End Property

    Public Property PrazoMinimo() As String
        Get
            Return m_pmin
        End Get
        Set(ByVal value As String)
            m_pmin = value
        End Set
    End Property

    Public Property Medicao() As String
        Get
            Return m_medi
        End Get
        Set(ByVal value As String)
            m_medi = value
        End Set
    End Property

    Public Property Embarcacao() As String
        Get
            Return m_emba
        End Get
        Set(ByVal value As String)
            m_emba = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into tabagendamentomedicao (codcli, dtamax, dtamin, dtmed, codbarco) values ('" & m_clie & "', '" & m_pmax & "', '" & m_pmin & "', '" & m_medi & "', '" & m_emba & "')"
            objbanco.executar_comando(sql)
            sql = "select max(codag) as codigo from tabagendamentomedicao"
            m_codi = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update tabagendamentomedicao set codcli='" & m_clie & "', dtamax='" & m_pmax & "', dtamin='" & m_pmin & "', dtmed='" & m_medi & "', codbarco='" & m_emba & "' where codag=" & m_codi
            objbanco.executar_comando(sql)
        End If
    End Sub

    Public Function Excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabagendamentomedicao where codag=" & chave
            objbanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function LocalizarPorCodigoOuNome(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from tabagendamentomedicao where codag=" & campo
        Else
            sql = "select * from tabagendamentomedicao where codcli='" & campo & "'"
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
        m_clie = objdtLocal.Rows(0).Item(1)
        m_pmax = objdtLocal.Rows(0).Item(2)
        m_pmin = objdtLocal.Rows(0).Item(3)
        m_medi = objdtLocal.Rows(0).Item(4)
        m_emba = objdtLocal.Rows(0).Item(5)
    End Sub
    Public Function LocalizarFiltro(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from VwAgendamento where codag=" & campo
        Else
            sql = "select * from VwAgendamento where nomcli like '" & campo & "%' order by nomcli"
        End If
        objdtLocal = objbanco.localizar(sql)
        Return objdtLocal
    End Function
End Class
