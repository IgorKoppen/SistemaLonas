<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaCliente))
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.TxtCampo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InscricaoEstadual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmaCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaiCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CidCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CepCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.CNPJ, Me.InscricaoEstadual, Me.EmaCli, Me.EndCli, Me.ComCli, Me.BaiCli, Me.CidCli, Me.EstCli, Me.CepCli})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(14, 76)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(935, 339)
        Me.DgdGrade.TabIndex = 9
        '
        'TxtCampo
        '
        Me.TxtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCampo.Location = New System.Drawing.Point(14, 30)
        Me.TxtCampo.Name = "TxtCampo"
        Me.TxtCampo.Size = New System.Drawing.Size(477, 26)
        Me.TxtCampo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Digite o código ou nome"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codcli"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Nomcli"
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "tel"
        Me.Column3.HeaderText = "Telefone"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 74
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "cpf"
        Me.Column4.HeaderText = "CPF"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 52
        '
        'CNPJ
        '
        Me.CNPJ.DataPropertyName = "CNPJ"
        Me.CNPJ.HeaderText = "CNPJ"
        Me.CNPJ.Name = "CNPJ"
        Me.CNPJ.Width = 59
        '
        'InscricaoEstadual
        '
        Me.InscricaoEstadual.DataPropertyName = "InscricaoEstadual"
        Me.InscricaoEstadual.HeaderText = "Inscrição Estadual"
        Me.InscricaoEstadual.Name = "InscricaoEstadual"
        Me.InscricaoEstadual.Width = 109
        '
        'EmaCli
        '
        Me.EmaCli.DataPropertyName = "email"
        Me.EmaCli.HeaderText = "Email"
        Me.EmaCli.Name = "EmaCli"
        Me.EmaCli.Width = 57
        '
        'EndCli
        '
        Me.EndCli.DataPropertyName = "ende"
        Me.EndCli.HeaderText = "Endereço"
        Me.EndCli.Name = "EndCli"
        Me.EndCli.Width = 78
        '
        'ComCli
        '
        Me.ComCli.DataPropertyName = "complemento"
        Me.ComCli.HeaderText = "Complemento"
        Me.ComCli.Name = "ComCli"
        Me.ComCli.Width = 96
        '
        'BaiCli
        '
        Me.BaiCli.DataPropertyName = "bairro"
        Me.BaiCli.HeaderText = "Bairro"
        Me.BaiCli.Name = "BaiCli"
        Me.BaiCli.Width = 59
        '
        'CidCli
        '
        Me.CidCli.DataPropertyName = "cidade"
        Me.CidCli.HeaderText = "Cidade"
        Me.CidCli.Name = "CidCli"
        Me.CidCli.Width = 65
        '
        'EstCli
        '
        Me.EstCli.DataPropertyName = "estado"
        Me.EstCli.HeaderText = "Estado"
        Me.EstCli.Name = "EstCli"
        Me.EstCli.Width = 65
        '
        'CepCli
        '
        Me.CepCli.DataPropertyName = "cep"
        Me.CepCli.HeaderText = "CEP"
        Me.CepCli.Name = "CepCli"
        Me.CepCli.Width = 53
        '
        'ConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(965, 446)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.TxtCampo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ConsultaCliente"
        Me.Text = "Consulta de Cliente"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents TxtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNPJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InscricaoEstadual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmaCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BaiCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CidCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CepCli As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
