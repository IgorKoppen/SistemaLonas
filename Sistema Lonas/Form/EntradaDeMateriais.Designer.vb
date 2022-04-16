<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradaDeMateriais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntradaDeMateriais))
        Me.MskVal = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnMat = New System.Windows.Forms.Button()
        Me.DtaBai = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnEst = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.BtnFor = New System.Windows.Forms.Button()
        Me.TxtNomFor = New System.Windows.Forms.TextBox()
        Me.TxtCodFor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNomMat = New System.Windows.Forms.TextBox()
        Me.TxtCodMat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeMinima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoReabastecimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MskVal
        '
        Me.MskVal.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskVal.Location = New System.Drawing.Point(208, 88)
        Me.MskVal.Margin = New System.Windows.Forms.Padding(2)
        Me.MskVal.Mask = "$999999999"
        Me.MskVal.Name = "MskVal"
        Me.MskVal.Size = New System.Drawing.Size(157, 30)
        Me.MskVal.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(97, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 22)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Valor Total:"
        '
        'BtnMat
        '
        Me.BtnMat.BackColor = System.Drawing.Color.Silver
        Me.BtnMat.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnMat.FlatAppearance.BorderSize = 2
        Me.BtnMat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnMat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMat.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMat.Location = New System.Drawing.Point(267, 12)
        Me.BtnMat.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMat.Name = "BtnMat"
        Me.BtnMat.Size = New System.Drawing.Size(47, 30)
        Me.BtnMat.TabIndex = 1
        Me.BtnMat.Text = "..."
        Me.BtnMat.UseVisualStyleBackColor = False
        '
        'DtaBai
        '
        Me.DtaBai.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaBai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaBai.Location = New System.Drawing.Point(208, 126)
        Me.DtaBai.Margin = New System.Windows.Forms.Padding(2)
        Me.DtaBai.Name = "DtaBai"
        Me.DtaBai.Size = New System.Drawing.Size(157, 30)
        Me.DtaBai.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(58, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 22)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Data da Compra:"
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.BackColor = System.Drawing.Color.Silver
        Me.BtnAlt.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAlt.FlatAppearance.BorderSize = 2
        Me.BtnAlt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAlt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlt.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(646, 158)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(124, 43)
        Me.BtnAlt.TabIndex = 9
        Me.BtnAlt.Text = "Sair"
        Me.BtnAlt.UseVisualStyleBackColor = False
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.BackColor = System.Drawing.Color.Silver
        Me.BtnCan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCan.FlatAppearance.BorderSize = 2
        Me.BtnCan.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCan.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(646, 108)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(124, 43)
        Me.BtnCan.TabIndex = 8
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = False
        '
        'BtnEst
        '
        Me.BtnEst.BackColor = System.Drawing.Color.Silver
        Me.BtnEst.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEst.FlatAppearance.BorderSize = 2
        Me.BtnEst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEst.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEst.Location = New System.Drawing.Point(562, 161)
        Me.BtnEst.Name = "BtnEst"
        Me.BtnEst.Size = New System.Drawing.Size(55, 35)
        Me.BtnEst.TabIndex = 6
        Me.BtnEst.Text = "OK"
        Me.BtnEst.UseVisualStyleBackColor = False
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.BackColor = System.Drawing.Color.Silver
        Me.BtnGra.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnGra.FlatAppearance.BorderSize = 2
        Me.BtnGra.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGra.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(646, 59)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(124, 43)
        Me.BtnGra.TabIndex = 7
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = False
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.BackColor = System.Drawing.Color.Silver
        Me.BtnNov.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnNov.FlatAppearance.BorderSize = 2
        Me.BtnNov.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNov.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(646, 8)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(124, 43)
        Me.BtnNov.TabIndex = 0
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = False
        '
        'BtnFor
        '
        Me.BtnFor.BackColor = System.Drawing.Color.Silver
        Me.BtnFor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnFor.FlatAppearance.BorderSize = 2
        Me.BtnFor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnFor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFor.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFor.Location = New System.Drawing.Point(267, 164)
        Me.BtnFor.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFor.Name = "BtnFor"
        Me.BtnFor.Size = New System.Drawing.Size(47, 30)
        Me.BtnFor.TabIndex = 5
        Me.BtnFor.Text = "..."
        Me.BtnFor.UseVisualStyleBackColor = False
        '
        'TxtNomFor
        '
        Me.TxtNomFor.Enabled = False
        Me.TxtNomFor.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomFor.Location = New System.Drawing.Point(319, 165)
        Me.TxtNomFor.Name = "TxtNomFor"
        Me.TxtNomFor.Size = New System.Drawing.Size(223, 30)
        Me.TxtNomFor.TabIndex = 113
        '
        'TxtCodFor
        '
        Me.TxtCodFor.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodFor.Location = New System.Drawing.Point(208, 165)
        Me.TxtCodFor.Name = "TxtCodFor"
        Me.TxtCodFor.Size = New System.Drawing.Size(54, 30)
        Me.TxtCodFor.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 22)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Código do Fornecedor:"
        '
        'TxtCom
        '
        Me.TxtCom.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCom.Location = New System.Drawing.Point(208, 50)
        Me.TxtCom.Name = "TxtCom"
        Me.TxtCom.Size = New System.Drawing.Size(157, 30)
        Me.TxtCom.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 22)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Quantidade Comprada:"
        '
        'TxtNomMat
        '
        Me.TxtNomMat.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomMat.Location = New System.Drawing.Point(319, 13)
        Me.TxtNomMat.Name = "TxtNomMat"
        Me.TxtNomMat.Size = New System.Drawing.Size(298, 30)
        Me.TxtNomMat.TabIndex = 107
        '
        'TxtCodMat
        '
        Me.TxtCodMat.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodMat.Location = New System.Drawing.Point(208, 13)
        Me.TxtCodMat.Name = "TxtCodMat"
        Me.TxtCodMat.Size = New System.Drawing.Size(54, 30)
        Me.TxtCodMat.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 22)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Código do Material:"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Material, Me.QuantidadeMinima, Me.ValorEnt, Me.UltimoReabastecimento, Me.Fornecedor})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(16, 205)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(601, 280)
        Me.DgdGrade.TabIndex = 104
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CodigoEnt"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Material
        '
        Me.Material.HeaderText = "Material"
        Me.Material.Name = "Material"
        Me.Material.Width = 69
        '
        'QuantidadeMinima
        '
        Me.QuantidadeMinima.HeaderText = "Quantidade Comprada"
        Me.QuantidadeMinima.Name = "QuantidadeMinima"
        Me.QuantidadeMinima.Width = 126
        '
        'ValorEnt
        '
        Me.ValorEnt.HeaderText = "Valor do maretial"
        Me.ValorEnt.Name = "ValorEnt"
        Me.ValorEnt.Width = 101
        '
        'UltimoReabastecimento
        '
        Me.UltimoReabastecimento.HeaderText = "Data Comprada"
        Me.UltimoReabastecimento.Name = "UltimoReabastecimento"
        Me.UltimoReabastecimento.Width = 97
        '
        'Fornecedor
        '
        Me.Fornecedor.HeaderText = "Fornecedor"
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.Width = 86
        '
        'EntradaDeMateriais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(782, 502)
        Me.Controls.Add(Me.MskVal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnMat)
        Me.Controls.Add(Me.DtaBai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnEst)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.BtnFor)
        Me.Controls.Add(Me.TxtNomFor)
        Me.Controls.Add(Me.TxtCodFor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNomMat)
        Me.Controls.Add(Me.TxtCodMat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdGrade)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EntradaDeMateriais"
        Me.Text = "Entrada De Materiais"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MskVal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnMat As System.Windows.Forms.Button
    Friend WithEvents DtaBai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnEst As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents BtnFor As System.Windows.Forms.Button
    Friend WithEvents TxtNomFor As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodFor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNomMat As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodMat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeMinima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorEnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimoReabastecimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
