<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaidaDeMateriais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaidaDeMateriais))
        Me.BtnMat = New System.Windows.Forms.Button()
        Me.DtaRet = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnEst = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.TxtRet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNomMat = New System.Windows.Forms.TextBox()
        Me.TxtCodMat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeMinima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoReabastecimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnMat.Location = New System.Drawing.Point(264, 11)
        Me.BtnMat.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMat.Name = "BtnMat"
        Me.BtnMat.Size = New System.Drawing.Size(47, 30)
        Me.BtnMat.TabIndex = 1
        Me.BtnMat.Text = "..."
        Me.BtnMat.UseVisualStyleBackColor = False
        '
        'DtaRet
        '
        Me.DtaRet.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaRet.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaRet.Location = New System.Drawing.Point(190, 88)
        Me.DtaRet.Margin = New System.Windows.Forms.Padding(2)
        Me.DtaRet.Name = "DtaRet"
        Me.DtaRet.Size = New System.Drawing.Size(120, 30)
        Me.DtaRet.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(57, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 22)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "Data da Baixa:"
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
        Me.BtnAlt.Location = New System.Drawing.Point(577, 154)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(124, 43)
        Me.BtnAlt.TabIndex = 7
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
        Me.BtnCan.Location = New System.Drawing.Point(577, 105)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(124, 43)
        Me.BtnCan.TabIndex = 6
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
        Me.BtnEst.Location = New System.Drawing.Point(476, 95)
        Me.BtnEst.Name = "BtnEst"
        Me.BtnEst.Size = New System.Drawing.Size(55, 35)
        Me.BtnEst.TabIndex = 4
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
        Me.BtnGra.Location = New System.Drawing.Point(577, 55)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(124, 43)
        Me.BtnGra.TabIndex = 5
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
        Me.BtnNov.Location = New System.Drawing.Point(577, 5)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(124, 43)
        Me.BtnNov.TabIndex = 0
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = False
        '
        'TxtRet
        '
        Me.TxtRet.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRet.Location = New System.Drawing.Point(190, 50)
        Me.TxtRet.Name = "TxtRet"
        Me.TxtRet.Size = New System.Drawing.Size(121, 30)
        Me.TxtRet.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 22)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Quantidade Retirada:"
        '
        'TxtNomMat
        '
        Me.TxtNomMat.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomMat.Location = New System.Drawing.Point(317, 12)
        Me.TxtNomMat.Name = "TxtNomMat"
        Me.TxtNomMat.Size = New System.Drawing.Size(214, 30)
        Me.TxtNomMat.TabIndex = 133
        '
        'TxtCodMat
        '
        Me.TxtCodMat.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodMat.Location = New System.Drawing.Point(190, 11)
        Me.TxtCodMat.Name = "TxtCodMat"
        Me.TxtCodMat.Size = New System.Drawing.Size(68, 30)
        Me.TxtCodMat.TabIndex = 131
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 22)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Código do Material:"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Material, Me.QuantidadeMinima, Me.UltimoReabastecimento})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(9, 135)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(522, 280)
        Me.DgdGrade.TabIndex = 130
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codigo"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Material
        '
        Me.Material.DataPropertyName = "CodProd"
        Me.Material.HeaderText = "Material"
        Me.Material.Name = "Material"
        Me.Material.Width = 69
        '
        'QuantidadeMinima
        '
        Me.QuantidadeMinima.DataPropertyName = "QtdSaida"
        Me.QuantidadeMinima.HeaderText = "Quantidade Retirada"
        Me.QuantidadeMinima.Name = "QuantidadeMinima"
        Me.QuantidadeMinima.Width = 119
        '
        'UltimoReabastecimento
        '
        Me.UltimoReabastecimento.DataPropertyName = "DtSaida"
        Me.UltimoReabastecimento.HeaderText = "Data Da Baixa"
        Me.UltimoReabastecimento.Name = "UltimoReabastecimento"
        Me.UltimoReabastecimento.Width = 93
        '
        'SaidaDeMateriais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(713, 443)
        Me.Controls.Add(Me.BtnMat)
        Me.Controls.Add(Me.DtaRet)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnEst)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.TxtRet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNomMat)
        Me.Controls.Add(Me.TxtCodMat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdGrade)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SaidaDeMateriais"
        Me.Text = "Saída De Materiais"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMat As System.Windows.Forms.Button
    Friend WithEvents DtaRet As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnEst As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents TxtRet As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNomMat As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodMat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeMinima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimoReabastecimento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
