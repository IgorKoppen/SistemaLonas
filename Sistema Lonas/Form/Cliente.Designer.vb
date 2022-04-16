<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente))
        Me.TxtIns = New System.Windows.Forms.TextBox()
        Me.LblIns = New System.Windows.Forms.Label()
        Me.LblCnpj = New System.Windows.Forms.Label()
        Me.TxtEst = New System.Windows.Forms.TextBox()
        Me.TxtCid = New System.Windows.Forms.TextBox()
        Me.TxtBai = New System.Windows.Forms.TextBox()
        Me.TxtCom = New System.Windows.Forms.TextBox()
        Me.TxtEnd = New System.Windows.Forms.TextBox()
        Me.LblCpf = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MskTel = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEma = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.TxtCep = New System.Windows.Forms.MaskedTextBox()
        Me.btnConsultarCep = New System.Windows.Forms.Button()
        Me.mskCpf = New System.Windows.Forms.MaskedTextBox()
        Me.mskCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.RADpf = New System.Windows.Forms.RadioButton()
        Me.RADpj = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrpLoc.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtIns
        '
        Me.TxtIns.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIns.Location = New System.Drawing.Point(221, 535)
        Me.TxtIns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtIns.MaxLength = 9
        Me.TxtIns.Name = "TxtIns"
        Me.TxtIns.Size = New System.Drawing.Size(244, 35)
        Me.TxtIns.TabIndex = 10
        Me.TxtIns.Tag = "x"
        '
        'LblIns
        '
        Me.LblIns.AutoSize = True
        Me.LblIns.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIns.Location = New System.Drawing.Point(12, 539)
        Me.LblIns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIns.Name = "LblIns"
        Me.LblIns.Size = New System.Drawing.Size(195, 27)
        Me.LblIns.TabIndex = 90
        Me.LblIns.Text = "Inscrição Estadual:"
        '
        'LblCnpj
        '
        Me.LblCnpj.AutoSize = True
        Me.LblCnpj.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCnpj.Location = New System.Drawing.Point(91, 490)
        Me.LblCnpj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCnpj.Name = "LblCnpj"
        Me.LblCnpj.Size = New System.Drawing.Size(74, 27)
        Me.LblCnpj.TabIndex = 88
        Me.LblCnpj.Text = "CNPJ:"
        '
        'TxtEst
        '
        Me.TxtEst.Enabled = False
        Me.TxtEst.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEst.Location = New System.Drawing.Point(195, 390)
        Me.TxtEst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEst.MaxLength = 2
        Me.TxtEst.Name = "TxtEst"
        Me.TxtEst.Size = New System.Drawing.Size(40, 35)
        Me.TxtEst.TabIndex = 18
        '
        'TxtCid
        '
        Me.TxtCid.Enabled = False
        Me.TxtCid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCid.Location = New System.Drawing.Point(195, 436)
        Me.TxtCid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCid.Name = "TxtCid"
        Me.TxtCid.Size = New System.Drawing.Size(477, 35)
        Me.TxtCid.TabIndex = 19
        '
        'TxtBai
        '
        Me.TxtBai.Enabled = False
        Me.TxtBai.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBai.Location = New System.Drawing.Point(195, 346)
        Me.TxtBai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBai.Name = "TxtBai"
        Me.TxtBai.Size = New System.Drawing.Size(480, 35)
        Me.TxtBai.TabIndex = 17
        '
        'TxtCom
        '
        Me.TxtCom.Enabled = False
        Me.TxtCom.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCom.Location = New System.Drawing.Point(195, 298)
        Me.TxtCom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCom.Name = "TxtCom"
        Me.TxtCom.Size = New System.Drawing.Size(365, 35)
        Me.TxtCom.TabIndex = 7
        Me.TxtCom.Tag = ""
        '
        'TxtEnd
        '
        Me.TxtEnd.Enabled = False
        Me.TxtEnd.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.TxtEnd.Location = New System.Drawing.Point(195, 252)
        Me.TxtEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEnd.Name = "TxtEnd"
        Me.TxtEnd.Size = New System.Drawing.Size(480, 30)
        Me.TxtEnd.TabIndex = 15
        '
        'LblCpf
        '
        Me.LblCpf.AutoSize = True
        Me.LblCpf.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCpf.Location = New System.Drawing.Point(104, 490)
        Me.LblCpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCpf.Name = "LblCpf"
        Me.LblCpf.Size = New System.Drawing.Size(61, 27)
        Me.LblCpf.TabIndex = 86
        Me.LblCpf.Text = "CPF:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(96, 351)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 27)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Bairro:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(65, 256)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 27)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Endereço:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 302)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 27)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Complemento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(81, 441)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 27)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Cidade:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(88, 394)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 27)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 212)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 27)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "CEP:"
        '
        'MskTel
        '
        Me.MskTel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTel.Location = New System.Drawing.Point(195, 111)
        Me.MskTel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MskTel.Mask = "(99) 00000-0000"
        Me.MskTel.Name = "MskTel"
        Me.MskTel.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MskTel.Size = New System.Drawing.Size(271, 35)
        Me.MskTel.TabIndex = 3
        '
        'TxtEma
        '
        Me.TxtEma.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEma.Location = New System.Drawing.Point(195, 158)
        Me.TxtEma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEma.Name = "TxtEma"
        Me.TxtEma.Size = New System.Drawing.Size(480, 35)
        Me.TxtEma.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 27)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 27)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Telefone:"
        '
        'TxtNom
        '
        Me.TxtNom.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(195, 64)
        Me.TxtNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(480, 35)
        Me.TxtNom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 27)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Nome:"
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(195, 17)
        Me.TxtCod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(168, 35)
        Me.TxtCod.TabIndex = 0
        Me.TxtCod.Tag = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 27)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Código:"
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.Label5)
        Me.GrpLoc.Controls.Add(Me.BtnOK)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.ForeColor = System.Drawing.Color.White
        Me.GrpLoc.Location = New System.Drawing.Point(689, 446)
        Me.GrpLoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrpLoc.Size = New System.Drawing.Size(307, 111)
        Me.GrpLoc.TabIndex = 14
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Text = "Localizar"
        Me.GrpLoc.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 37)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 27)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Digite o Código ou Nome"
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
        Me.BtnOK.Location = New System.Drawing.Point(213, 65)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(67, 33)
        Me.BtnOK.TabIndex = 1
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'TxtLoc
        '
        Me.TxtLoc.Location = New System.Drawing.Point(21, 65)
        Me.TxtLoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(183, 30)
        Me.TxtLoc.TabIndex = 0
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
        Me.BtnAlt.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.BtnAlt.ForeColor = System.Drawing.Color.Black
        Me.BtnAlt.Location = New System.Drawing.Point(831, 262)
        Me.BtnAlt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(165, 53)
        Me.BtnAlt.TabIndex = 15
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
        Me.BtnSai.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.BtnSai.ForeColor = System.Drawing.Color.Black
        Me.BtnSai.Location = New System.Drawing.Point(831, 385)
        Me.BtnSai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(165, 53)
        Me.BtnSai.TabIndex = 17
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
        Me.BtnCan.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.BtnCan.ForeColor = System.Drawing.Color.Black
        Me.BtnCan.Location = New System.Drawing.Point(831, 322)
        Me.BtnCan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(165, 53)
        Me.BtnCan.TabIndex = 16
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
        Me.BtnLoc.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.BtnLoc.ForeColor = System.Drawing.Color.Black
        Me.BtnLoc.Location = New System.Drawing.Point(831, 201)
        Me.BtnLoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(165, 54)
        Me.BtnLoc.TabIndex = 13
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
        Me.BtnExc.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.BtnExc.ForeColor = System.Drawing.Color.Black
        Me.BtnExc.Location = New System.Drawing.Point(831, 140)
        Me.BtnExc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(165, 53)
        Me.BtnExc.TabIndex = 12
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
        Me.BtnGra.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.BtnGra.ForeColor = System.Drawing.Color.Black
        Me.BtnGra.Location = New System.Drawing.Point(831, 79)
        Me.BtnGra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(165, 53)
        Me.BtnGra.TabIndex = 11
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
        Me.BtnNov.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.BtnNov.ForeColor = System.Drawing.Color.Black
        Me.BtnNov.Location = New System.Drawing.Point(831, 18)
        Me.BtnNov.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(165, 53)
        Me.BtnNov.TabIndex = 0
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = False
        '
        'TxtCep
        '
        Me.TxtCep.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCep.Location = New System.Drawing.Point(195, 206)
        Me.TxtCep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCep.Mask = "00000-000"
        Me.TxtCep.Name = "TxtCep"
        Me.TxtCep.Size = New System.Drawing.Size(132, 35)
        Me.TxtCep.TabIndex = 5
        '
        'btnConsultarCep
        '
        Me.btnConsultarCep.BackColor = System.Drawing.Color.Silver
        Me.btnConsultarCep.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConsultarCep.FlatAppearance.BorderSize = 2
        Me.btnConsultarCep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConsultarCep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConsultarCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarCep.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarCep.ForeColor = System.Drawing.Color.Black
        Me.btnConsultarCep.Location = New System.Drawing.Point(336, 206)
        Me.btnConsultarCep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConsultarCep.Name = "btnConsultarCep"
        Me.btnConsultarCep.Size = New System.Drawing.Size(167, 36)
        Me.btnConsultarCep.TabIndex = 6
        Me.btnConsultarCep.Text = "Consultar CEP"
        Me.btnConsultarCep.UseVisualStyleBackColor = False
        '
        'mskCpf
        '
        Me.mskCpf.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCpf.Location = New System.Drawing.Point(195, 485)
        Me.mskCpf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskCpf.Mask = "000,000,000-00"
        Me.mskCpf.Name = "mskCpf"
        Me.mskCpf.Size = New System.Drawing.Size(269, 35)
        Me.mskCpf.TabIndex = 8
        '
        'mskCNPJ
        '
        Me.mskCNPJ.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCNPJ.Location = New System.Drawing.Point(195, 485)
        Me.mskCNPJ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskCNPJ.Mask = "00,000,000/0000-00"
        Me.mskCNPJ.Name = "mskCNPJ"
        Me.mskCNPJ.Size = New System.Drawing.Size(269, 35)
        Me.mskCNPJ.TabIndex = 9
        '
        'RADpf
        '
        Me.RADpf.AutoSize = True
        Me.RADpf.Checked = True
        Me.RADpf.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.RADpf.Location = New System.Drawing.Point(15, 30)
        Me.RADpf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RADpf.Name = "RADpf"
        Me.RADpf.Size = New System.Drawing.Size(57, 29)
        Me.RADpf.TabIndex = 0
        Me.RADpf.TabStop = True
        Me.RADpf.Text = "PF"
        Me.RADpf.UseVisualStyleBackColor = True
        '
        'RADpj
        '
        Me.RADpj.AutoSize = True
        Me.RADpj.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.RADpj.Location = New System.Drawing.Point(101, 30)
        Me.RADpj.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RADpj.Name = "RADpj"
        Me.RADpj.Size = New System.Drawing.Size(54, 29)
        Me.RADpj.TabIndex = 1
        Me.RADpj.Text = "PJ"
        Me.RADpj.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RADpf)
        Me.GroupBox1.Controls.Add(Me.RADpj)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(495, 485)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(179, 68)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Pessoa"
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(1021, 598)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mskCNPJ)
        Me.Controls.Add(Me.mskCpf)
        Me.Controls.Add(Me.btnConsultarCep)
        Me.Controls.Add(Me.TxtCep)
        Me.Controls.Add(Me.TxtIns)
        Me.Controls.Add(Me.LblIns)
        Me.Controls.Add(Me.LblCnpj)
        Me.Controls.Add(Me.TxtEst)
        Me.Controls.Add(Me.TxtCid)
        Me.Controls.Add(Me.TxtBai)
        Me.Controls.Add(Me.TxtCom)
        Me.Controls.Add(Me.TxtEnd)
        Me.Controls.Add(Me.LblCpf)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MskTel)
        Me.Controls.Add(Me.TxtEma)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtIns As System.Windows.Forms.TextBox
    Friend WithEvents LblIns As System.Windows.Forms.Label
    Friend WithEvents LblCnpj As System.Windows.Forms.Label
    Friend WithEvents TxtEst As System.Windows.Forms.TextBox
    Friend WithEvents TxtCid As System.Windows.Forms.TextBox
    Friend WithEvents TxtBai As System.Windows.Forms.TextBox
    Friend WithEvents TxtCom As System.Windows.Forms.TextBox
    Friend WithEvents TxtEnd As System.Windows.Forms.TextBox
    Friend WithEvents LblCpf As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MskTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtEma As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents BtnExc As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents TxtCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnConsultarCep As System.Windows.Forms.Button
    Friend WithEvents mskCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RADpf As System.Windows.Forms.RadioButton
    Friend WithEvents RADpj As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
