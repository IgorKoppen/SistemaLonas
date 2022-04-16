<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agendamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agendamento))
        Me.txtnomcli = New System.Windows.Forms.TextBox()
        Me.btnalt = New System.Windows.Forms.Button()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.btncan = New System.Windows.Forms.Button()
        Me.btnloc = New System.Windows.Forms.Button()
        Me.btnexc = New System.Windows.Forms.Button()
        Me.btngra = New System.Windows.Forms.Button()
        Me.btnnov = New System.Windows.Forms.Button()
        Me.txtcodemb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpmed = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpprazomin = New System.Windows.Forms.DateTimePicker()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Txtcodcli = New System.Windows.Forms.TextBox()
        Me.dtpprazomax = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNom = New System.Windows.Forms.Button()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.GrpDat = New System.Windows.Forms.GroupBox()
        Me.btnEmbarcacao = New System.Windows.Forms.Button()
        Me.txtEmbarcacao = New System.Windows.Forms.TextBox()
        Me.GrpLoc.SuspendLayout()
        Me.GrpDat.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnomcli
        '
        Me.txtnomcli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomcli.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomcli.Location = New System.Drawing.Point(368, 59)
        Me.txtnomcli.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnomcli.Name = "txtnomcli"
        Me.txtnomcli.Size = New System.Drawing.Size(239, 30)
        Me.txtnomcli.TabIndex = 79
        '
        'btnalt
        '
        Me.btnalt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnalt.BackColor = System.Drawing.Color.Silver
        Me.btnalt.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnalt.FlatAppearance.BorderSize = 2
        Me.btnalt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnalt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnalt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnalt.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalt.Location = New System.Drawing.Point(631, 226)
        Me.btnalt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnalt.Name = "btnalt"
        Me.btnalt.Size = New System.Drawing.Size(124, 43)
        Me.btnalt.TabIndex = 9
        Me.btnalt.Text = "&Alterar"
        Me.btnalt.UseVisualStyleBackColor = False
        '
        'btnsair
        '
        Me.btnsair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsair.BackColor = System.Drawing.Color.Silver
        Me.btnsair.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnsair.FlatAppearance.BorderSize = 2
        Me.btnsair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsair.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsair.Location = New System.Drawing.Point(631, 332)
        Me.btnsair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(124, 43)
        Me.btnsair.TabIndex = 11
        Me.btnsair.Text = "Sai&r"
        Me.btnsair.UseVisualStyleBackColor = False
        '
        'btncan
        '
        Me.btncan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncan.BackColor = System.Drawing.Color.Silver
        Me.btncan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btncan.FlatAppearance.BorderSize = 2
        Me.btncan.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncan.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncan.Location = New System.Drawing.Point(631, 279)
        Me.btncan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncan.Name = "btncan"
        Me.btncan.Size = New System.Drawing.Size(124, 43)
        Me.btncan.TabIndex = 10
        Me.btncan.Text = "&Cancelar"
        Me.btncan.UseVisualStyleBackColor = False
        '
        'btnloc
        '
        Me.btnloc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnloc.BackColor = System.Drawing.Color.Silver
        Me.btnloc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnloc.FlatAppearance.BorderSize = 2
        Me.btnloc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnloc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnloc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloc.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloc.Location = New System.Drawing.Point(631, 173)
        Me.btnloc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnloc.Name = "btnloc"
        Me.btnloc.Size = New System.Drawing.Size(124, 43)
        Me.btnloc.TabIndex = 7
        Me.btnloc.Text = "&Localizar"
        Me.btnloc.UseVisualStyleBackColor = False
        '
        'btnexc
        '
        Me.btnexc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexc.BackColor = System.Drawing.Color.Silver
        Me.btnexc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnexc.FlatAppearance.BorderSize = 2
        Me.btnexc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnexc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnexc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnexc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexc.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexc.Location = New System.Drawing.Point(631, 120)
        Me.btnexc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnexc.Name = "btnexc"
        Me.btnexc.Size = New System.Drawing.Size(124, 43)
        Me.btnexc.TabIndex = 6
        Me.btnexc.Text = "&Excluir"
        Me.btnexc.UseVisualStyleBackColor = False
        '
        'btngra
        '
        Me.btngra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngra.BackColor = System.Drawing.Color.Silver
        Me.btngra.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btngra.FlatAppearance.BorderSize = 2
        Me.btngra.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btngra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btngra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btngra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngra.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngra.Location = New System.Drawing.Point(631, 67)
        Me.btngra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btngra.Name = "btngra"
        Me.btngra.Size = New System.Drawing.Size(124, 43)
        Me.btngra.TabIndex = 5
        Me.btngra.Text = "&Gravar"
        Me.btngra.UseVisualStyleBackColor = False
        '
        'btnnov
        '
        Me.btnnov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnov.BackColor = System.Drawing.Color.Silver
        Me.btnnov.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnnov.FlatAppearance.BorderSize = 2
        Me.btnnov.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnnov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnnov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnnov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnov.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnov.Location = New System.Drawing.Point(631, 14)
        Me.btnnov.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnnov.Name = "btnnov"
        Me.btnnov.Size = New System.Drawing.Size(124, 43)
        Me.btnnov.TabIndex = 0
        Me.btnnov.Text = "&Novo"
        Me.btnnov.UseVisualStyleBackColor = False
        '
        'txtcodemb
        '
        Me.txtcodemb.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodemb.Location = New System.Drawing.Point(205, 231)
        Me.txtcodemb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcodemb.Name = "txtcodemb"
        Me.txtcodemb.Size = New System.Drawing.Size(102, 30)
        Me.txtcodemb.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 235)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 22)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Código da embarcação:"
        '
        'dtpmed
        '
        Me.dtpmed.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpmed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpmed.Location = New System.Drawing.Point(205, 182)
        Me.dtpmed.Name = "dtpmed"
        Me.dtpmed.Size = New System.Drawing.Size(132, 30)
        Me.dtpmed.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(54, 186)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 22)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Data da Medição:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(247, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 23)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Maximo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 23)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Mínimo:"
        '
        'dtpprazomin
        '
        Me.dtpprazomin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpprazomin.Location = New System.Drawing.Point(109, 29)
        Me.dtpprazomin.Name = "dtpprazomin"
        Me.dtpprazomin.Size = New System.Drawing.Size(119, 30)
        Me.dtpprazomin.TabIndex = 0
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(205, 17)
        Me.TxtCod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(188, 30)
        Me.TxtCod.TabIndex = 1
        '
        'Txtcodcli
        '
        Me.Txtcodcli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtcodcli.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcodcli.Location = New System.Drawing.Point(205, 58)
        Me.Txtcodcli.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtcodcli.Name = "Txtcodcli"
        Me.Txtcodcli.Size = New System.Drawing.Size(102, 30)
        Me.Txtcodcli.TabIndex = 22
        '
        'dtpprazomax
        '
        Me.dtpprazomax.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpprazomax.Location = New System.Drawing.Point(335, 29)
        Me.dtpprazomax.Name = "dtpprazomax"
        Me.dtpprazomax.Size = New System.Drawing.Size(119, 30)
        Me.dtpprazomax.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(45, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 22)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Código do Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(132, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Código:"
        '
        'BtnNom
        '
        Me.BtnNom.BackColor = System.Drawing.Color.Silver
        Me.BtnNom.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnNom.FlatAppearance.BorderSize = 2
        Me.BtnNom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNom.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNom.Location = New System.Drawing.Point(315, 58)
        Me.BtnNom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnNom.Name = "BtnNom"
        Me.BtnNom.Size = New System.Drawing.Size(45, 30)
        Me.BtnNom.TabIndex = 1
        Me.BtnNom.Text = "..."
        Me.BtnNom.UseVisualStyleBackColor = False
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.BtnOK)
        Me.GrpLoc.Controls.Add(Me.Label8)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.ForeColor = System.Drawing.Color.White
        Me.GrpLoc.Location = New System.Drawing.Point(377, 268)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(230, 90)
        Me.GrpLoc.TabIndex = 8
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
        Me.BtnOK.Location = New System.Drawing.Point(160, 53)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(50, 27)
        Me.BtnOK.TabIndex = 1
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Digite o Código"
        '
        'TxtLoc
        '
        Me.TxtLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLoc.Location = New System.Drawing.Point(16, 53)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(138, 26)
        Me.TxtLoc.TabIndex = 0
        '
        'GrpDat
        '
        Me.GrpDat.Controls.Add(Me.dtpprazomin)
        Me.GrpDat.Controls.Add(Me.dtpprazomax)
        Me.GrpDat.Controls.Add(Me.Label4)
        Me.GrpDat.Controls.Add(Me.Label5)
        Me.GrpDat.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDat.ForeColor = System.Drawing.Color.White
        Me.GrpDat.Location = New System.Drawing.Point(49, 97)
        Me.GrpDat.Name = "GrpDat"
        Me.GrpDat.Size = New System.Drawing.Size(471, 72)
        Me.GrpDat.TabIndex = 2
        Me.GrpDat.TabStop = False
        Me.GrpDat.Text = "Data do Agendamento"
        '
        'btnEmbarcacao
        '
        Me.btnEmbarcacao.BackColor = System.Drawing.Color.Silver
        Me.btnEmbarcacao.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEmbarcacao.FlatAppearance.BorderSize = 2
        Me.btnEmbarcacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEmbarcacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEmbarcacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmbarcacao.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmbarcacao.Location = New System.Drawing.Point(315, 230)
        Me.btnEmbarcacao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEmbarcacao.Name = "btnEmbarcacao"
        Me.btnEmbarcacao.Size = New System.Drawing.Size(45, 31)
        Me.btnEmbarcacao.TabIndex = 4
        Me.btnEmbarcacao.Text = "..."
        Me.btnEmbarcacao.UseVisualStyleBackColor = False
        '
        'txtEmbarcacao
        '
        Me.txtEmbarcacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmbarcacao.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmbarcacao.Location = New System.Drawing.Point(368, 232)
        Me.txtEmbarcacao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmbarcacao.Name = "txtEmbarcacao"
        Me.txtEmbarcacao.Size = New System.Drawing.Size(239, 30)
        Me.txtEmbarcacao.TabIndex = 84
        '
        'Agendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(768, 388)
        Me.Controls.Add(Me.txtEmbarcacao)
        Me.Controls.Add(Me.btnEmbarcacao)
        Me.Controls.Add(Me.GrpDat)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.BtnNom)
        Me.Controls.Add(Me.txtnomcli)
        Me.Controls.Add(Me.btnalt)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.btncan)
        Me.Controls.Add(Me.btnloc)
        Me.Controls.Add(Me.btnexc)
        Me.Controls.Add(Me.btngra)
        Me.Controls.Add(Me.btnnov)
        Me.Controls.Add(Me.txtcodemb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpmed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Txtcodcli)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agendamento"
        Me.Text = "Agendamento"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.GrpDat.ResumeLayout(False)
        Me.GrpDat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnomcli As System.Windows.Forms.TextBox
    Friend WithEvents btnalt As System.Windows.Forms.Button
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents btncan As System.Windows.Forms.Button
    Friend WithEvents btnloc As System.Windows.Forms.Button
    Friend WithEvents btnexc As System.Windows.Forms.Button
    Friend WithEvents btngra As System.Windows.Forms.Button
    Friend WithEvents btnnov As System.Windows.Forms.Button
    Friend WithEvents txtcodemb As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpmed As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpprazomin As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents Txtcodcli As System.Windows.Forms.TextBox
    Friend WithEvents dtpprazomax As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNom As System.Windows.Forms.Button
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents GrpDat As System.Windows.Forms.GroupBox
    Friend WithEvents btnEmbarcacao As System.Windows.Forms.Button
    Friend WithEvents txtEmbarcacao As System.Windows.Forms.TextBox
    Friend WithEvents BtnOK As System.Windows.Forms.Button
End Class
