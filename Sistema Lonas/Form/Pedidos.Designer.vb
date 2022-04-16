<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos))
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.MskVal = New System.Windows.Forms.MaskedTextBox()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.lblCli = New System.Windows.Forms.Label()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.DtaMax = New System.Windows.Forms.DateTimePicker()
        Me.DtaMin = New System.Windows.Forms.DateTimePicker()
        Me.DtaPed = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboPed = New System.Windows.Forms.ComboBox()
        Me.BtnCli = New System.Windows.Forms.Button()
        Me.TxtCli = New System.Windows.Forms.TextBox()
        Me.TxtCodCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrpLoc.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(176, 12)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(127, 30)
        Me.TxtCod.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(97, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 22)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Valor do orçamento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 22)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Data do Pedido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Mínimo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(254, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 23)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Maximo:"
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
        Me.BtnAlt.Location = New System.Drawing.Point(556, 210)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(124, 43)
        Me.BtnAlt.TabIndex = 10
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = False
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.BackColor = System.Drawing.Color.Silver
        Me.BtnSai.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnSai.FlatAppearance.BorderSize = 2
        Me.BtnSai.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSai.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(556, 312)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(124, 43)
        Me.BtnSai.TabIndex = 12
        Me.BtnSai.Text = "Sai&r"
        Me.BtnSai.UseVisualStyleBackColor = False
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
        Me.BtnCan.Location = New System.Drawing.Point(556, 259)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(124, 43)
        Me.BtnCan.TabIndex = 11
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = False
        '
        'BtnLoc
        '
        Me.BtnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoc.BackColor = System.Drawing.Color.Silver
        Me.BtnLoc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnLoc.FlatAppearance.BorderSize = 2
        Me.BtnLoc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoc.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(556, 160)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(124, 44)
        Me.BtnLoc.TabIndex = 8
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = False
        '
        'BtnExc
        '
        Me.BtnExc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExc.BackColor = System.Drawing.Color.Silver
        Me.BtnExc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnExc.FlatAppearance.BorderSize = 2
        Me.BtnExc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExc.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExc.Location = New System.Drawing.Point(556, 111)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(124, 43)
        Me.BtnExc.TabIndex = 7
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = False
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
        Me.BtnGra.Location = New System.Drawing.Point(556, 61)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(124, 43)
        Me.BtnGra.TabIndex = 6
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
        Me.BtnNov.Location = New System.Drawing.Point(556, 11)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(124, 43)
        Me.BtnNov.TabIndex = 0
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = False
        '
        'MskVal
        '
        Me.MskVal.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskVal.Location = New System.Drawing.Point(175, 127)
        Me.MskVal.Margin = New System.Windows.Forms.Padding(2)
        Me.MskVal.Name = "MskVal"
        Me.MskVal.Size = New System.Drawing.Size(152, 30)
        Me.MskVal.TabIndex = 3
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.BtnOK)
        Me.GrpLoc.Controls.Add(Me.lblCli)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.ForeColor = System.Drawing.Color.White
        Me.GrpLoc.Location = New System.Drawing.Point(295, 289)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(236, 96)
        Me.GrpLoc.TabIndex = 9
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Text = "Localizar"
        Me.GrpLoc.Visible = False
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.Color.Silver
        Me.BtnOK.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnOK.FlatAppearance.BorderSize = 2
        Me.BtnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOK.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.ForeColor = System.Drawing.Color.Black
        Me.BtnOK.Location = New System.Drawing.Point(160, 52)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(50, 27)
        Me.BtnOK.TabIndex = 3
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'lblCli
        '
        Me.lblCli.AutoSize = True
        Me.lblCli.Location = New System.Drawing.Point(12, 30)
        Me.lblCli.Name = "lblCli"
        Me.lblCli.Size = New System.Drawing.Size(117, 20)
        Me.lblCli.TabIndex = 2
        Me.lblCli.Text = "Digite o Código"
        '
        'TxtLoc
        '
        Me.TxtLoc.Location = New System.Drawing.Point(16, 53)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(138, 26)
        Me.TxtLoc.TabIndex = 0
        '
        'DtaMax
        '
        Me.DtaMax.CalendarFont = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.DtaMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaMax.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaMax.Location = New System.Drawing.Point(340, 33)
        Me.DtaMax.Margin = New System.Windows.Forms.Padding(2)
        Me.DtaMax.Name = "DtaMax"
        Me.DtaMax.Size = New System.Drawing.Size(151, 26)
        Me.DtaMax.TabIndex = 7
        '
        'DtaMin
        '
        Me.DtaMin.CalendarFont = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.DtaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaMin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaMin.Location = New System.Drawing.Point(93, 32)
        Me.DtaMin.Margin = New System.Windows.Forms.Padding(2)
        Me.DtaMin.Name = "DtaMin"
        Me.DtaMin.Size = New System.Drawing.Size(151, 26)
        Me.DtaMin.TabIndex = 6
        '
        'DtaPed
        '
        Me.DtaPed.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaPed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaPed.Location = New System.Drawing.Point(176, 166)
        Me.DtaPed.Margin = New System.Windows.Forms.Padding(2)
        Me.DtaPed.Name = "DtaPed"
        Me.DtaPed.Size = New System.Drawing.Size(151, 30)
        Me.DtaPed.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(98, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 22)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Pedido:"
        '
        'CboPed
        '
        Me.CboPed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPed.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPed.FormattingEnabled = True
        Me.CboPed.Items.AddRange(New Object() {"Capota", "Fechamento", "Lona", "Frontal", "Lateral", "Traseiro"})
        Me.CboPed.Location = New System.Drawing.Point(176, 50)
        Me.CboPed.Margin = New System.Windows.Forms.Padding(2)
        Me.CboPed.Name = "CboPed"
        Me.CboPed.Size = New System.Drawing.Size(264, 30)
        Me.CboPed.TabIndex = 1
        '
        'BtnCli
        '
        Me.BtnCli.BackColor = System.Drawing.Color.Silver
        Me.BtnCli.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCli.FlatAppearance.BorderSize = 2
        Me.BtnCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCli.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCli.Location = New System.Drawing.Point(236, 88)
        Me.BtnCli.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCli.Name = "BtnCli"
        Me.BtnCli.Size = New System.Drawing.Size(45, 30)
        Me.BtnCli.TabIndex = 2
        Me.BtnCli.Text = "..."
        Me.BtnCli.UseVisualStyleBackColor = False
        '
        'TxtCli
        '
        Me.TxtCli.Enabled = False
        Me.TxtCli.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCli.Location = New System.Drawing.Point(286, 89)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(231, 30)
        Me.TxtCli.TabIndex = 80
        '
        'TxtCodCli
        '
        Me.TxtCodCli.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodCli.Location = New System.Drawing.Point(175, 88)
        Me.TxtCodCli.Name = "TxtCodCli"
        Me.TxtCodCli.Size = New System.Drawing.Size(55, 30)
        Me.TxtCodCli.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 22)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Código Do Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DtaMin)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DtaMax)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(26, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 78)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prazo De Entrega"
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(692, 404)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCli)
        Me.Controls.Add(Me.TxtCli)
        Me.Controls.Add(Me.TxtCodCli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CboPed)
        Me.Controls.Add(Me.DtaPed)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.MskVal)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents BtnExc As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents MskVal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents lblCli As System.Windows.Forms.Label
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents DtaMax As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtaMin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtaPed As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboPed As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCli As System.Windows.Forms.Button
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnOK As System.Windows.Forms.Button
End Class
