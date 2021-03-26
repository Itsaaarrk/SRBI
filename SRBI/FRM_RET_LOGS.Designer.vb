<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_RET_LOGS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL2 = New System.Windows.Forms.Panel()
        Me.PNL1 = New System.Windows.Forms.Panel()
        Me.PNL_LBL = New System.Windows.Forms.Label()
        Me.PNL3 = New System.Windows.Forms.Panel()
        Me.BTN_F_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_F_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_INMA_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INMA_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.DGV_TRP_LIST = New System.Windows.Forms.DataGridView()
        Me.SPM4TRPLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New SRBI.DS_STOREDPROC()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TXT_SEARCH = New System.Windows.Forms.TextBox()
        Me.BTN_SEARCH = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.CB_DATE_BY = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_FILTERBY = New System.Windows.Forms.ComboBox()
        Me.PNL_CUSTOM = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WTXT_TO = New SRBI.WatermarkTextBox()
        Me.DTSERVERDATEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WTXT_FROM = New SRBI.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape78 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PNL_NODATA = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.LBL_TOT = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.BTN_SEND_2BI = New System.Windows.Forms.Button()
        Me.BTN_GEN_REP = New System.Windows.Forms.Button()
        Me.SPM4_TRP_LISTTableAdapter = New SRBI.DS_STOREDPROCTableAdapters.SPM4_TRP_LISTTableAdapter()
        Me.DT_SERVERDATETableAdapter = New SRBI.DS_STOREDPROCTableAdapters.DT_SERVERDATETableAdapter()
        Me.SPV1_SQ_TRAVEL_CERTTableAdapter = New SRBI.DS_STOREDPROCTableAdapters.SPV1_SQ_TRAVEL_CERTTableAdapter()
        Me.SPV1_SQ_TRAVEL_CERTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbML4_EMAIL_HISTTableAdapter = New SRBI.DS_TABLESTableAdapters.tbML4_EMAIL_HISTTableAdapter()
        Me.TbML4_EMAIL_HISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DPARREFNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRVLDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULLNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NATIONALITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PPORTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VISASTATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEISSUEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACT_PRINT = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ACT_RESEND = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PNL2.SuspendLayout()
        Me.PNL1.SuspendLayout()
        Me.PNL3.SuspendLayout()
        CType(Me.DGV_TRP_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4TRPLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.PNL_CUSTOM.SuspendLayout()
        CType(Me.DTSERVERDATEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PNL_NODATA.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.SPV1_SQ_TRAVEL_CERTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbML4_EMAIL_HISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL2
        '
        Me.PNL2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PNL2.Controls.Add(Me.PNL1)
        Me.PNL2.Controls.Add(Me.PNL3)
        Me.PNL2.Controls.Add(Me.BTN_INMA_MINIMIZE)
        Me.PNL2.Controls.Add(Me.BTN_INMA_CLOSE)
        Me.PNL2.Controls.Add(Me.BTN_Minimize)
        Me.PNL2.Controls.Add(Me.BTN_CLOSE)
        Me.PNL2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL2.Location = New System.Drawing.Point(0, 0)
        Me.PNL2.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL2.Name = "PNL2"
        Me.PNL2.Size = New System.Drawing.Size(1199, 44)
        Me.PNL2.TabIndex = 1412
        '
        'PNL1
        '
        Me.PNL1.Controls.Add(Me.PNL_LBL)
        Me.PNL1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PNL1.Location = New System.Drawing.Point(0, 0)
        Me.PNL1.Name = "PNL1"
        Me.PNL1.Size = New System.Drawing.Size(186, 44)
        Me.PNL1.TabIndex = 1412
        '
        'PNL_LBL
        '
        Me.PNL_LBL.AutoSize = True
        Me.PNL_LBL.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNL_LBL.ForeColor = System.Drawing.Color.White
        Me.PNL_LBL.Location = New System.Drawing.Point(22, 7)
        Me.PNL_LBL.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PNL_LBL.Name = "PNL_LBL"
        Me.PNL_LBL.Size = New System.Drawing.Size(161, 29)
        Me.PNL_LBL.TabIndex = 8
        Me.PNL_LBL.Text = "Travel Pass List"
        '
        'PNL3
        '
        Me.PNL3.Controls.Add(Me.BTN_F_MINIMIZE)
        Me.PNL3.Controls.Add(Me.BTN_F_CLOSE)
        Me.PNL3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PNL3.Location = New System.Drawing.Point(1109, 0)
        Me.PNL3.Name = "PNL3"
        Me.PNL3.Size = New System.Drawing.Size(90, 44)
        Me.PNL3.TabIndex = 1412
        '
        'BTN_F_MINIMIZE
        '
        Me.BTN_F_MINIMIZE.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_F_MINIMIZE.BackgroundImage = Global.SRBI.My.Resources.Resources.Minimized_Left_white
        Me.BTN_F_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_F_MINIMIZE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_F_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_F_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_F_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_F_MINIMIZE.Location = New System.Drawing.Point(32, 8)
        Me.BTN_F_MINIMIZE.Name = "BTN_F_MINIMIZE"
        Me.BTN_F_MINIMIZE.Size = New System.Drawing.Size(27, 28)
        Me.BTN_F_MINIMIZE.TabIndex = 20
        Me.BTN_F_MINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_F_MINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_F_CLOSE
        '
        Me.BTN_F_CLOSE.BackgroundImage = Global.SRBI.My.Resources.Resources.close_icon_white
        Me.BTN_F_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_F_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_F_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_F_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_F_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_F_CLOSE.Location = New System.Drawing.Point(56, 7)
        Me.BTN_F_CLOSE.Name = "BTN_F_CLOSE"
        Me.BTN_F_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_F_CLOSE.TabIndex = 18
        Me.BTN_F_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_F_CLOSE.UseVisualStyleBackColor = True
        '
        'BTN_INMA_MINIMIZE
        '
        Me.BTN_INMA_MINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INMA_MINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_INMA_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INMA_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INMA_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_INMA_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INMA_MINIMIZE.Location = New System.Drawing.Point(-869, 8)
        Me.BTN_INMA_MINIMIZE.Name = "BTN_INMA_MINIMIZE"
        Me.BTN_INMA_MINIMIZE.Size = New System.Drawing.Size(27, 28)
        Me.BTN_INMA_MINIMIZE.TabIndex = 11
        Me.BTN_INMA_MINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INMA_MINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_INMA_CLOSE
        '
        Me.BTN_INMA_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INMA_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INMA_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INMA_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INMA_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INMA_CLOSE.Location = New System.Drawing.Point(-834, 7)
        Me.BTN_INMA_CLOSE.Name = "BTN_INMA_CLOSE"
        Me.BTN_INMA_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INMA_CLOSE.TabIndex = 10
        Me.BTN_INMA_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INMA_CLOSE.UseVisualStyleBackColor = True
        '
        'BTN_Minimize
        '
        Me.BTN_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Minimize.BackColor = System.Drawing.Color.DarkCyan
        Me.BTN_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_Minimize.FlatAppearance.BorderSize = 3
        Me.BTN_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Minimize.Location = New System.Drawing.Point(-6688, 11)
        Me.BTN_Minimize.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_Minimize.Name = "BTN_Minimize"
        Me.BTN_Minimize.Size = New System.Drawing.Size(47, 45)
        Me.BTN_Minimize.TabIndex = 7
        Me.BTN_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Minimize.UseVisualStyleBackColor = False
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-6641, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'DGV_TRP_LIST
        '
        Me.DGV_TRP_LIST.AllowUserToAddRows = False
        Me.DGV_TRP_LIST.AllowUserToDeleteRows = False
        Me.DGV_TRP_LIST.AllowUserToResizeRows = False
        Me.DGV_TRP_LIST.AutoGenerateColumns = False
        Me.DGV_TRP_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_TRP_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_TRP_LIST.CausesValidation = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_TRP_LIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_TRP_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_TRP_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DPARREFNUMDataGridViewTextBoxColumn, Me.TRVLDATEDataGridViewTextBoxColumn, Me.FULLNAMEDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.NATIONALITYDataGridViewTextBoxColumn, Me.PPORTNODataGridViewTextBoxColumn, Me.VISASTATDataGridViewTextBoxColumn, Me.DATEISSUEDDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.ACT_PRINT, Me.ACT_RESEND})
        Me.DGV_TRP_LIST.DataSource = Me.SPM4TRPLISTBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_TRP_LIST.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_TRP_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_TRP_LIST.GridColor = System.Drawing.Color.White
        Me.DGV_TRP_LIST.Location = New System.Drawing.Point(0, 0)
        Me.DGV_TRP_LIST.MultiSelect = False
        Me.DGV_TRP_LIST.Name = "DGV_TRP_LIST"
        Me.DGV_TRP_LIST.ReadOnly = True
        Me.DGV_TRP_LIST.RowHeadersVisible = False
        Me.DGV_TRP_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_TRP_LIST.Size = New System.Drawing.Size(1199, 479)
        Me.DGV_TRP_LIST.TabIndex = 1413
        '
        'SPM4TRPLISTBindingSource
        '
        Me.SPM4TRPLISTBindingSource.DataMember = "SPM4_TRP_LIST"
        Me.SPM4TRPLISTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1199, 39)
        Me.Panel2.TabIndex = 1415
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1199, 39)
        Me.Panel1.TabIndex = 1417
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(572, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(627, 39)
        Me.Panel5.TabIndex = 1418
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TXT_SEARCH)
        Me.Panel7.Controls.Add(Me.BTN_SEARCH)
        Me.Panel7.Location = New System.Drawing.Point(62, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(443, 28)
        Me.Panel7.TabIndex = 3
        '
        'TXT_SEARCH
        '
        Me.TXT_SEARCH.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_SEARCH.Location = New System.Drawing.Point(0, 1)
        Me.TXT_SEARCH.Name = "TXT_SEARCH"
        Me.TXT_SEARCH.Size = New System.Drawing.Size(413, 27)
        Me.TXT_SEARCH.TabIndex = 3
        '
        'BTN_SEARCH
        '
        Me.BTN_SEARCH.BackColor = System.Drawing.Color.Transparent
        Me.BTN_SEARCH.BackgroundImage = Global.SRBI.My.Resources.Resources.outline_search_black_18dp
        Me.BTN_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SEARCH.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_SEARCH.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SEARCH.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_SEARCH.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_SEARCH.Location = New System.Drawing.Point(412, 0)
        Me.BTN_SEARCH.Name = "BTN_SEARCH"
        Me.BTN_SEARCH.Size = New System.Drawing.Size(31, 28)
        Me.BTN_SEARCH.TabIndex = 1413
        Me.BTN_SEARCH.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search:"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(573, 39)
        Me.Panel6.TabIndex = 1417
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.CB_DATE_BY)
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Controls.Add(Me.CB_FILTERBY)
        Me.Panel10.Controls.Add(Me.PNL_CUSTOM)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(572, 39)
        Me.Panel10.TabIndex = 1419
        '
        'CB_DATE_BY
        '
        Me.CB_DATE_BY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_DATE_BY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_DATE_BY.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_DATE_BY.FormattingEnabled = True
        Me.CB_DATE_BY.Items.AddRange(New Object() {"Date Issued", "Travel Date"})
        Me.CB_DATE_BY.Location = New System.Drawing.Point(65, 6)
        Me.CB_DATE_BY.Name = "CB_DATE_BY"
        Me.CB_DATE_BY.Size = New System.Drawing.Size(125, 27)
        Me.CB_DATE_BY.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "FILTER BY:"
        '
        'CB_FILTERBY
        '
        Me.CB_FILTERBY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_FILTERBY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_FILTERBY.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FILTERBY.FormattingEnabled = True
        Me.CB_FILTERBY.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Custom date"})
        Me.CB_FILTERBY.Location = New System.Drawing.Point(194, 6)
        Me.CB_FILTERBY.Name = "CB_FILTERBY"
        Me.CB_FILTERBY.Size = New System.Drawing.Size(160, 27)
        Me.CB_FILTERBY.TabIndex = 0
        '
        'PNL_CUSTOM
        '
        Me.PNL_CUSTOM.Controls.Add(Me.Label2)
        Me.PNL_CUSTOM.Controls.Add(Me.Label1)
        Me.PNL_CUSTOM.Controls.Add(Me.WTXT_TO)
        Me.PNL_CUSTOM.Controls.Add(Me.WTXT_FROM)
        Me.PNL_CUSTOM.Controls.Add(Me.ShapeContainer2)
        Me.PNL_CUSTOM.Location = New System.Drawing.Point(363, 0)
        Me.PNL_CUSTOM.Name = "PNL_CUSTOM"
        Me.PNL_CUSTOM.Size = New System.Drawing.Size(206, 39)
        Me.PNL_CUSTOM.TabIndex = 1
        Me.PNL_CUSTOM.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 19)
        Me.Label2.TabIndex = 1415
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 19)
        Me.Label1.TabIndex = 1414
        Me.Label1.Text = "From"
        '
        'WTXT_TO
        '
        Me.WTXT_TO.BackColor = System.Drawing.Color.White
        Me.WTXT_TO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_TO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_TO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DTSERVERDATEBindingSource, "CUR_DATE", True))
        Me.WTXT_TO.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!)
        Me.WTXT_TO.Location = New System.Drawing.Point(135, 10)
        Me.WTXT_TO.MaxLength = 0
        Me.WTXT_TO.Name = "WTXT_TO"
        Me.WTXT_TO.Size = New System.Drawing.Size(65, 19)
        Me.WTXT_TO.TabIndex = 5
        Me.WTXT_TO.Text = "MM/DD/YYYY"
        Me.WTXT_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_TO.Watermark = "MM/DD/YYYY"
        '
        'DTSERVERDATEBindingSource
        '
        Me.DTSERVERDATEBindingSource.DataMember = "DT_SERVERDATE"
        Me.DTSERVERDATEBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'WTXT_FROM
        '
        Me.WTXT_FROM.BackColor = System.Drawing.Color.White
        Me.WTXT_FROM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_FROM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_FROM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DTSERVERDATEBindingSource, "CUR_DATE", True))
        Me.WTXT_FROM.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!)
        Me.WTXT_FROM.Location = New System.Drawing.Point(43, 10)
        Me.WTXT_FROM.MaxLength = 0
        Me.WTXT_FROM.Name = "WTXT_FROM"
        Me.WTXT_FROM.Size = New System.Drawing.Size(65, 19)
        Me.WTXT_FROM.TabIndex = 3
        Me.WTXT_FROM.Text = "MM/DD/YYYY"
        Me.WTXT_FROM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_FROM.Watermark = "MM/DD/YYYY"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RectangleShape78})
        Me.ShapeContainer2.Size = New System.Drawing.Size(206, 39)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSlateGray
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape1.Location = New System.Drawing.Point(132, 8)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(69, 22)
        '
        'RectangleShape78
        '
        Me.RectangleShape78.BorderColor = System.Drawing.Color.LightSlateGray
        Me.RectangleShape78.CornerRadius = 3
        Me.RectangleShape78.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape78.Location = New System.Drawing.Point(40, 8)
        Me.RectangleShape78.Name = "RectangleShape78"
        Me.RectangleShape78.Size = New System.Drawing.Size(69, 22)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PNL_NODATA)
        Me.Panel3.Controls.Add(Me.DGV_TRP_LIST)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1199, 479)
        Me.Panel3.TabIndex = 1416
        '
        'PNL_NODATA
        '
        Me.PNL_NODATA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PNL_NODATA.BackColor = System.Drawing.Color.Transparent
        Me.PNL_NODATA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PNL_NODATA.Controls.Add(Me.PictureBox1)
        Me.PNL_NODATA.Location = New System.Drawing.Point(389, 124)
        Me.PNL_NODATA.Name = "PNL_NODATA"
        Me.PNL_NODATA.Size = New System.Drawing.Size(446, 162)
        Me.PNL_NODATA.TabIndex = 1414
        Me.PNL_NODATA.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SRBI.My.Resources.Resources.unnamed__2_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(446, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Panel12)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 523)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1199, 39)
        Me.Panel4.TabIndex = 1417
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(185, 37)
        Me.Panel8.TabIndex = 1417
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(185, 37)
        Me.Panel9.TabIndex = 1417
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.LBL_TOT)
        Me.Panel11.Controls.Add(Me.Label4)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(183, 37)
        Me.Panel11.TabIndex = 1
        '
        'LBL_TOT
        '
        Me.LBL_TOT.AutoSize = True
        Me.LBL_TOT.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TOT.ForeColor = System.Drawing.Color.Red
        Me.LBL_TOT.Location = New System.Drawing.Point(152, 7)
        Me.LBL_TOT.Name = "LBL_TOT"
        Me.LBL_TOT.Size = New System.Drawing.Size(21, 25)
        Me.LBL_TOT.TabIndex = 4
        Me.LBL_TOT.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(25, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total no. of rows: "
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.BTN_SEND_2BI)
        Me.Panel12.Controls.Add(Me.BTN_GEN_REP)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(372, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(825, 37)
        Me.Panel12.TabIndex = 1413
        '
        'BTN_SEND_2BI
        '
        Me.BTN_SEND_2BI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_SEND_2BI.BackColor = System.Drawing.Color.DarkOrange
        Me.BTN_SEND_2BI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SEND_2BI.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.BTN_SEND_2BI.FlatAppearance.BorderSize = 2
        Me.BTN_SEND_2BI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SEND_2BI.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_SEND_2BI.ForeColor = System.Drawing.Color.White
        Me.BTN_SEND_2BI.Location = New System.Drawing.Point(412, 3)
        Me.BTN_SEND_2BI.Name = "BTN_SEND_2BI"
        Me.BTN_SEND_2BI.Size = New System.Drawing.Size(229, 31)
        Me.BTN_SEND_2BI.TabIndex = 1414
        Me.BTN_SEND_2BI.Text = "SEND GENERATED REPORT FOR BI"
        Me.BTN_SEND_2BI.UseVisualStyleBackColor = False
        '
        'BTN_GEN_REP
        '
        Me.BTN_GEN_REP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_GEN_REP.BackColor = System.Drawing.Color.RoyalBlue
        Me.BTN_GEN_REP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_GEN_REP.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BTN_GEN_REP.FlatAppearance.BorderSize = 2
        Me.BTN_GEN_REP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GEN_REP.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_GEN_REP.ForeColor = System.Drawing.Color.White
        Me.BTN_GEN_REP.Location = New System.Drawing.Point(644, 3)
        Me.BTN_GEN_REP.Name = "BTN_GEN_REP"
        Me.BTN_GEN_REP.Size = New System.Drawing.Size(178, 31)
        Me.BTN_GEN_REP.TabIndex = 1413
        Me.BTN_GEN_REP.Text = "GENERATE REPORT"
        Me.BTN_GEN_REP.UseVisualStyleBackColor = False
        '
        'SPM4_TRP_LISTTableAdapter
        '
        Me.SPM4_TRP_LISTTableAdapter.ClearBeforeFill = True
        '
        'DT_SERVERDATETableAdapter
        '
        Me.DT_SERVERDATETableAdapter.ClearBeforeFill = True
        '
        'SPV1_SQ_TRAVEL_CERTTableAdapter
        '
        Me.SPV1_SQ_TRAVEL_CERTTableAdapter.ClearBeforeFill = True
        '
        'SPV1_SQ_TRAVEL_CERTBindingSource
        '
        Me.SPV1_SQ_TRAVEL_CERTBindingSource.DataMember = "SPV1_SQ_TRAVEL_CERT"
        Me.SPV1_SQ_TRAVEL_CERTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'TbML4_EMAIL_HISTTableAdapter
        '
        Me.TbML4_EMAIL_HISTTableAdapter.ClearBeforeFill = True
        '
        'TbML4_EMAIL_HISTBindingSource
        '
        Me.TbML4_EMAIL_HISTBindingSource.DataMember = "tbML4_EMAIL_HIST"
        '
        'DPARREFNUMDataGridViewTextBoxColumn
        '
        Me.DPARREFNUMDataGridViewTextBoxColumn.DataPropertyName = "DPAR_REF_NUM"
        Me.DPARREFNUMDataGridViewTextBoxColumn.HeaderText = "REF #"
        Me.DPARREFNUMDataGridViewTextBoxColumn.Name = "DPARREFNUMDataGridViewTextBoxColumn"
        Me.DPARREFNUMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRVLDATEDataGridViewTextBoxColumn
        '
        Me.TRVLDATEDataGridViewTextBoxColumn.DataPropertyName = "TRVL_DATE"
        Me.TRVLDATEDataGridViewTextBoxColumn.HeaderText = "TRAVEL DATE"
        Me.TRVLDATEDataGridViewTextBoxColumn.Name = "TRVLDATEDataGridViewTextBoxColumn"
        Me.TRVLDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FULLNAMEDataGridViewTextBoxColumn
        '
        Me.FULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "FULLNAME"
        Me.FULLNAMEDataGridViewTextBoxColumn.HeaderText = "FULLNAME"
        Me.FULLNAMEDataGridViewTextBoxColumn.Name = "FULLNAMEDataGridViewTextBoxColumn"
        Me.FULLNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DATE OF BIRTH"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NATIONALITYDataGridViewTextBoxColumn
        '
        Me.NATIONALITYDataGridViewTextBoxColumn.DataPropertyName = "NATIONALITY"
        Me.NATIONALITYDataGridViewTextBoxColumn.HeaderText = "NATIONALITY"
        Me.NATIONALITYDataGridViewTextBoxColumn.Name = "NATIONALITYDataGridViewTextBoxColumn"
        Me.NATIONALITYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PPORTNODataGridViewTextBoxColumn
        '
        Me.PPORTNODataGridViewTextBoxColumn.DataPropertyName = "PPORT_NO"
        Me.PPORTNODataGridViewTextBoxColumn.HeaderText = "PASSPORT NO."
        Me.PPORTNODataGridViewTextBoxColumn.Name = "PPORTNODataGridViewTextBoxColumn"
        Me.PPORTNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'VISASTATDataGridViewTextBoxColumn
        '
        Me.VISASTATDataGridViewTextBoxColumn.DataPropertyName = "VISA_STAT"
        Me.VISASTATDataGridViewTextBoxColumn.HeaderText = "VISA_STAT"
        Me.VISASTATDataGridViewTextBoxColumn.Name = "VISASTATDataGridViewTextBoxColumn"
        Me.VISASTATDataGridViewTextBoxColumn.ReadOnly = True
        Me.VISASTATDataGridViewTextBoxColumn.Visible = False
        '
        'DATEISSUEDDataGridViewTextBoxColumn
        '
        Me.DATEISSUEDDataGridViewTextBoxColumn.DataPropertyName = "DATE_ISSUED"
        Me.DATEISSUEDDataGridViewTextBoxColumn.HeaderText = "DATE ISSUED"
        Me.DATEISSUEDDataGridViewTextBoxColumn.Name = "DATEISSUEDDataGridViewTextBoxColumn"
        Me.DATEISSUEDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ACT_PRINT
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.ACT_PRINT.DefaultCellStyle = DataGridViewCellStyle2
        Me.ACT_PRINT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ACT_PRINT.HeaderText = "Action"
        Me.ACT_PRINT.Name = "ACT_PRINT"
        Me.ACT_PRINT.ReadOnly = True
        Me.ACT_PRINT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ACT_PRINT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ACT_PRINT.Text = "RESEND TRAVEL PASS"
        Me.ACT_PRINT.UseColumnTextForButtonValue = True
        Me.ACT_PRINT.Visible = False
        '
        'ACT_RESEND
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.ACT_RESEND.DefaultCellStyle = DataGridViewCellStyle3
        Me.ACT_RESEND.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ACT_RESEND.HeaderText = "Action"
        Me.ACT_RESEND.Name = "ACT_RESEND"
        Me.ACT_RESEND.ReadOnly = True
        Me.ACT_RESEND.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ACT_RESEND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ACT_RESEND.Text = "PRINT TRAVEL PASS"
        Me.ACT_RESEND.UseColumnTextForButtonValue = True
        Me.ACT_RESEND.Visible = False
        '
        'FRM_RET_LOGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1199, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PNL2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_RET_LOGS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNL2.ResumeLayout(False)
        Me.PNL1.ResumeLayout(False)
        Me.PNL1.PerformLayout()
        Me.PNL3.ResumeLayout(False)
        CType(Me.DGV_TRP_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4TRPLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.PNL_CUSTOM.ResumeLayout(False)
        Me.PNL_CUSTOM.PerformLayout()
        CType(Me.DTSERVERDATEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.PNL_NODATA.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        CType(Me.SPV1_SQ_TRAVEL_CERTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbML4_EMAIL_HISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL2 As Panel
    Friend WithEvents PNL1 As Panel
    Friend WithEvents PNL_LBL As Label
    Friend WithEvents PNL3 As Panel
    Friend WithEvents BTN_F_CLOSE As Button
    Friend WithEvents BTN_INMA_MINIMIZE As Button
    Friend WithEvents BTN_INMA_CLOSE As Button
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents BTN_F_MINIMIZE As Button
    Friend WithEvents DGV_TRP_LIST As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents SPM4TRPLISTBindingSource As BindingSource
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SPM4_TRP_LISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_TRP_LISTTableAdapter
    Friend WithEvents LBL_TOT As Label
    Friend WithEvents DTSERVERDATEBindingSource As BindingSource
    Friend WithEvents DT_SERVERDATETableAdapter As DS_STOREDPROCTableAdapters.DT_SERVERDATETableAdapter
    Friend WithEvents BTN_GEN_REP As Button
    Friend WithEvents SPV1_SQ_TRAVEL_CERTTableAdapter As DS_STOREDPROCTableAdapters.SPV1_SQ_TRAVEL_CERTTableAdapter
    Friend WithEvents SPV1_SQ_TRAVEL_CERTBindingSource As BindingSource
    Friend WithEvents TbML4_EMAIL_HISTTableAdapter As DS_TABLESTableAdapters.tbML4_EMAIL_HISTTableAdapter
    Friend WithEvents TbML4_EMAIL_HISTBindingSource As BindingSource
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TXT_SEARCH As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_FILTERBY As ComboBox
    Friend WithEvents PNL_CUSTOM As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WTXT_TO As WatermarkTextBox
    Friend WithEvents WTXT_FROM As WatermarkTextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape78 As PowerPacks.RectangleShape
    Friend WithEvents BTN_SEND_2BI As Button
    Friend WithEvents BTN_SEARCH As Button
    Friend WithEvents PNL_NODATA As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CB_DATE_BY As ComboBox
    Friend WithEvents DPARREFNUMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TRVLDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FULLNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NATIONALITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PPORTNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VISASTATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEISSUEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACT_PRINT As DataGridViewButtonColumn
    Friend WithEvents ACT_RESEND As DataGridViewButtonColumn
End Class
