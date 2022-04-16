Public Class ClsEmbarcacao
    Dim m_cod As Integer
    Dim m_nmbarco As String
    Dim m_marca As String
    Dim m_modelo As String
    Dim m_anofab As Integer
    Dim m_cliente As Integer
    Dim m_marina As Integer
    Dim m_ncliente As String
    Dim m_nmarina As String

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
    Public Property Marca As String
        Get
            Return m_marca
        End Get
        Set(value As String)
            m_marca = value
        End Set
    End Property
    Public Property Modelo As String
        Get
            Return m_modelo
        End Get
        Set(value As String)
            m_modelo = value
        End Set
    End Property
    Public Property NomeBarco As String
        Get
            Return m_nmbarco
        End Get
        Set(value As String)
            m_nmbarco = value
        End Set
    End Property
    Public Property AnoFab As Integer
        Get
            Return m_anofab
        End Get
        Set(value As Integer)
            m_anofab = value
        End Set
    End Property
    Public Property Cliente As Integer
        Get
            Return m_cliente
        End Get
        Set(value As Integer)
            m_cliente = value
        End Set
    End Property
    Public Property Ncliente As String
        Get
            Return m_ncliente
        End Get
        Set(value As String)
            m_ncliente = value
        End Set
    End Property
    Public Property Marina As Integer
        Get
            Return m_marina
        End Get
        Set(value As Integer)
            m_marina = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo = True Then
            sql = "insert into tabembarcaçao (nomebarco, marca, modelo, anofab, cliente, Marina) values ('" & m_nmbarco & "', '" & m_marca & "', '" & m_modelo & "', '" & m_anofab & "', '" & m_cliente & "', '" & m_marina & "')"
            objbanco.executar_comando(sql)
            sql = "select max(codigo) as codigo from tabembarcaçao"
            m_cod = objbanco.buscar_ultimoRegistro(sql)
        Else
            sql = "Update tabembarcaçao set nomebarco='" & m_nmbarco & "', marca='" & m_marca & "', modelo='" & m_modelo & "', anofab='" & m_anofab & "', cliente='" & m_cliente & "', marina='" & m_marina & "'  where codigo=" & m_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabembarcaçao where codigo = " & chave
            objbanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function LocalizarPorCodigoOuNome(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "select * from vwembarcaçao where codigo=" & campo
        Else
            sql = "select * from vwembarcaçao where nomebarco='" & campo & "'"
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
    Public Function LocalizarFiltroB(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from TabEmbarcaçao where codigo=" & campo
        Else
            sql = "select * from TabEmbarcaçao where nomeBarco like '" & campo & "%' order by nomeBarco"
        End If
        objdtLocal = objbanco.localizar(sql)
        Return objdtLocal
    End Function
    Public Function LocalizarFiltro(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from VwClienteEmbarcao where Cliente=" & campo
        End If
        objdtLocal = objbanco.localizar(sql)
        Return objdtLocal
    End Function
    Private Sub mostrar_DadosVindosDoBanco()
        m_cod = objdtLocal.Rows(0).Item(0)
        m_nmbarco = objdtLocal.Rows(0).Item(1)
        m_marca = objdtLocal.Rows(0).Item(2)
        m_modelo = objdtLocal.Rows(0).Item(3)
        m_anofab = objdtLocal.Rows(0).Item(4)
        m_cliente = objdtLocal.Rows(0).Item(5)
        m_ncliente = objdtLocal.Rows(0).Item(6)
        m_marina = objdtLocal.Rows(0).Item(7)
        m_nmarina = objdtLocal.Rows(0).Item(8)
    End Sub
End Class
