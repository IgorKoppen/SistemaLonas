<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaPedido))
        Me.TxtCampo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.CodPed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValPedTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataPet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PraMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PraMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCampo
        '
        Me.TxtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCampo.Location = New System.Drawing.Point(16, 65)
        Me.TxtCampo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCampo.Name = "TxtCampo"
        Me.TxtCampo.Size = New System.Drawing.Size(304, 30)
        Me.TxtCampo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Digite o código do pedido"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodPed, Me.CodCli, Me.NomCli, Me.Tel, Me.ValPedTot, Me.DataPet, Me.PraMin, Me.PraMax, Me.Column1})
        Me.DgdGrade.Location = New System.Drawing.Point(16, 117)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(4)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.ReadOnly = True
        Me.DgdGrade.Size = New System.Drawing.Size(1143, 325)
        Me.DgdGrade.TabIndex = 9
        '
        'CodPed
        '
        Me.CodPed.DataPropertyName = "CodPed"
        Me.CodPed.HeaderText = "Código do Pedido"
        Me.CodPed.Name = "CodPed"
        Me.CodPed.ReadOnly = True
        '
        'CodCli
        '
        Me.CodCli.DataPropertyName = "CodCli"
        Me.CodCli.HeaderText = "Código do Cliente"
        Me.CodCli.Name = "CodCli"
        Me.CodCli.ReadOnly = True
        '
        'NomCli
        '
        Me.NomCli.DataPropertyName = "NomCli"
        Me.NomCli.HeaderText = "Nome do Cliente"
        Me.NomCli.Name = "NomCli"
        Me.NomCli.ReadOnly = True
        '
        'Tel
        '
        Me.Tel.DataPropertyName = "Tel"
        Me.Tel.HeaderText = "Telefone do Cliente"
        Me.Tel.Name = "Tel"
        Me.Tel.ReadOnly = True
        '
        'ValPedTot
        '
        Me.ValPedTot.DataPropertyName = "ValPedTot"
        Me.ValPedTot.HeaderText = "Valor Total"
        Me.ValPedTot.Name = "ValPedTot"
        Me.ValPedTot.ReadOnly = True
        '
        'DataPet
        '
        Me.DataPet.DataPropertyName = "DataPed"
        Me.DataPet.HeaderText = "Data do Pedido"
        Me.DataPet.Name = "DataPet"
        Me.DataPet.ReadOnly = True
        '
        'PraMin
        '
        Me.PraMin.DataPropertyName = "PraMin"
        Me.PraMin.HeaderText = "Prazo Mínimo"
        Me.PraMin.Name = "PraMin"
        Me.PraMin.ReadOnly = True
        '
        'PraMax
        '
        Me.PraMax.DataPropertyName = "PraMax"
        Me.PraMax.HeaderText = "Prazo Máximo"
        Me.PraMax.Name = "PraMax"
        Me.PraMax.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Pedido"
        Me.Column1.HeaderText = "Pedido"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'ConsultaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(1211, 480)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.TxtCampo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ConsultaPedido"
        Me.Text = "Consulta de Pedido"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents CodPed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValPedTot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataPet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PraMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PraMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
