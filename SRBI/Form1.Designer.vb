<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_EM_2_BI
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
        Me.PNL2 = New System.Windows.Forms.Panel()
        Me.PNL1 = New System.Windows.Forms.Panel()
        Me.PNL_LBL = New System.Windows.Forms.Label()
        Me.PNL3 = New System.Windows.Forms.Panel()
        Me.BTN_F_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_F_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INMA_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INMA_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CR_VIEWER = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CB_FILTERBY = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PNL_CUSTOM = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TXT_SEARCH = New System.Windows.Forms.TextBox()
        Me.BTN_SEARCH = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape78 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_SEND_EMAIL = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.WTXT_TO = New SRBI.WatermarkTextBox()
        Me.WTXT_FROM = New SRBI.WatermarkTextBox()
        Me.PNL2.SuspendLayout()
        Me.PNL1.SuspendLayout()
        Me.PNL3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PNL_CUSTOM.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
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
        Me.PNL2.Size = New System.Drawing.Size(1052, 44)
        Me.PNL2.TabIndex = 1411
        '
        'PNL1
        '
        Me.PNL1.Controls.Add(Me.PNL_LBL)
        Me.PNL1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PNL1.Location = New System.Drawing.Point(0, 0)
        Me.PNL1.Name = "PNL1"
        Me.PNL1.Size = New System.Drawing.Size(265, 44)
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
        Me.PNL_LBL.Size = New System.Drawing.Size(227, 29)
        Me.PNL_LBL.TabIndex = 8
        Me.PNL_LBL.Text = "SRRV Monitoring for BI"
        '
        'PNL3
        '
        Me.PNL3.Controls.Add(Me.BTN_F_CLOSE)
        Me.PNL3.Controls.Add(Me.BTN_F_MINIMIZE)
        Me.PNL3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PNL3.Location = New System.Drawing.Point(962, 0)
        Me.PNL3.Name = "PNL3"
        Me.PNL3.Size = New System.Drawing.Size(90, 44)
        Me.PNL3.TabIndex = 1412
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
        'BTN_F_MINIMIZE
        '
        Me.BTN_F_MINIMIZE.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_F_MINIMIZE.BackgroundImage = Global.SRBI.My.Resources.Resources.Minimized_Left_white
        Me.BTN_F_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_F_MINIMIZE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_F_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_F_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_F_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_F_MINIMIZE.Location = New System.Drawing.Point(26, 7)
        Me.BTN_F_MINIMIZE.Name = "BTN_F_MINIMIZE"
        Me.BTN_F_MINIMIZE.Size = New System.Drawing.Size(27, 28)
        Me.BTN_F_MINIMIZE.TabIndex = 19
        Me.BTN_F_MINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_F_MINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_INMA_MINIMIZE
        '
        Me.BTN_INMA_MINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INMA_MINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_INMA_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INMA_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INMA_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_INMA_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INMA_MINIMIZE.Location = New System.Drawing.Point(-1016, 8)
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
        Me.BTN_INMA_CLOSE.Location = New System.Drawing.Point(-981, 7)
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-6835, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-6788, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1052, 486)
        Me.Panel3.TabIndex = 1415
        '
        'CR_VIEWER
        '
        Me.CR_VIEWER.ActiveViewIndex = -1
        Me.CR_VIEWER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_VIEWER.Cursor = System.Windows.Forms.Cursors.Default
        Me.CR_VIEWER.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR_VIEWER.Location = New System.Drawing.Point(0, 0)
        Me.CR_VIEWER.Name = "CR_VIEWER"
        Me.CR_VIEWER.ShowCloseButton = False
        Me.CR_VIEWER.ShowCopyButton = False
        Me.CR_VIEWER.ShowExportButton = False
        Me.CR_VIEWER.ShowGroupTreeButton = False
        Me.CR_VIEWER.ShowLogo = False
        Me.CR_VIEWER.ShowParameterPanelButton = False
        Me.CR_VIEWER.ShowRefreshButton = False
        Me.CR_VIEWER.Size = New System.Drawing.Size(1052, 460)
        Me.CR_VIEWER.TabIndex = 0
        Me.CR_VIEWER.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.CB_FILTERBY)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(291, 38)
        Me.Panel4.TabIndex = 1416
        '
        'CB_FILTERBY
        '
        Me.CB_FILTERBY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_FILTERBY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_FILTERBY.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FILTERBY.FormattingEnabled = True
        Me.CB_FILTERBY.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Custom date"})
        Me.CB_FILTERBY.Location = New System.Drawing.Point(70, 7)
        Me.CB_FILTERBY.Name = "CB_FILTERBY"
        Me.CB_FILTERBY.Size = New System.Drawing.Size(218, 27)
        Me.CB_FILTERBY.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FILTER BY:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(291, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 38)
        Me.Panel1.TabIndex = 1417
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.PNL_CUSTOM)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(761, 38)
        Me.Panel6.TabIndex = 1417
        '
        'PNL_CUSTOM
        '
        Me.PNL_CUSTOM.Controls.Add(Me.WTXT_TO)
        Me.PNL_CUSTOM.Controls.Add(Me.Label2)
        Me.PNL_CUSTOM.Controls.Add(Me.WTXT_FROM)
        Me.PNL_CUSTOM.Controls.Add(Me.ShapeContainer2)
        Me.PNL_CUSTOM.Dock = System.Windows.Forms.DockStyle.Left
        Me.PNL_CUSTOM.Location = New System.Drawing.Point(0, 0)
        Me.PNL_CUSTOM.Name = "PNL_CUSTOM"
        Me.PNL_CUSTOM.Size = New System.Drawing.Size(166, 38)
        Me.PNL_CUSTOM.TabIndex = 1
        Me.PNL_CUSTOM.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Search:"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.BTN_SEARCH)
        Me.Panel7.Controls.Add(Me.TXT_SEARCH)
        Me.Panel7.Location = New System.Drawing.Point(217, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(346, 28)
        Me.Panel7.TabIndex = 3
        '
        'TXT_SEARCH
        '
        Me.TXT_SEARCH.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_SEARCH.Location = New System.Drawing.Point(0, 1)
        Me.TXT_SEARCH.Name = "TXT_SEARCH"
        Me.TXT_SEARCH.Size = New System.Drawing.Size(318, 27)
        Me.TXT_SEARCH.TabIndex = 0
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
        Me.BTN_SEARCH.Location = New System.Drawing.Point(315, 0)
        Me.BTN_SEARCH.Name = "BTN_SEARCH"
        Me.BTN_SEARCH.Size = New System.Drawing.Size(31, 28)
        Me.BTN_SEARCH.TabIndex = 1413
        Me.BTN_SEARCH.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1052, 38)
        Me.Panel2.TabIndex = 1414
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RectangleShape78})
        Me.ShapeContainer2.Size = New System.Drawing.Size(166, 38)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSlateGray
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape1.Location = New System.Drawing.Point(89, 8)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(69, 22)
        '
        'RectangleShape78
        '
        Me.RectangleShape78.BorderColor = System.Drawing.Color.LightSlateGray
        Me.RectangleShape78.CornerRadius = 3
        Me.RectangleShape78.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape78.Location = New System.Drawing.Point(6, 8)
        Me.RectangleShape78.Name = "RectangleShape78"
        Me.RectangleShape78.Size = New System.Drawing.Size(69, 22)
        '
        'BTN_SEND_EMAIL
        '
        Me.BTN_SEND_EMAIL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_SEND_EMAIL.BackColor = System.Drawing.Color.RoyalBlue
        Me.BTN_SEND_EMAIL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SEND_EMAIL.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BTN_SEND_EMAIL.FlatAppearance.BorderSize = 2
        Me.BTN_SEND_EMAIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SEND_EMAIL.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_SEND_EMAIL.ForeColor = System.Drawing.Color.White
        Me.BTN_SEND_EMAIL.Location = New System.Drawing.Point(14, 3)
        Me.BTN_SEND_EMAIL.Name = "BTN_SEND_EMAIL"
        Me.BTN_SEND_EMAIL.Size = New System.Drawing.Size(178, 31)
        Me.BTN_SEND_EMAIL.TabIndex = 1412
        Me.BTN_SEND_EMAIL.Text = "SEND EMAIL"
        Me.BTN_SEND_EMAIL.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BTN_SEND_EMAIL)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(857, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(195, 38)
        Me.Panel5.TabIndex = 1413
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.CR_VIEWER)
        Me.Panel9.Controls.Add(Me.Button2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1052, 486)
        Me.Panel9.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 460)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(1052, 26)
        Me.Button2.TabIndex = 1413
        Me.Button2.Text = "VIEW EMAIL LOGS"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseMnemonic = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'WTXT_TO
        '
        Me.WTXT_TO.BackColor = System.Drawing.Color.White
        Me.WTXT_TO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_TO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_TO.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!)
        Me.WTXT_TO.Location = New System.Drawing.Point(92, 10)
        Me.WTXT_TO.MaxLength = 0
        Me.WTXT_TO.Name = "WTXT_TO"
        Me.WTXT_TO.Size = New System.Drawing.Size(65, 19)
        Me.WTXT_TO.TabIndex = 5
        Me.WTXT_TO.Text = "MM/DD/YYYY"
        Me.WTXT_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_TO.Watermark = "MM/DD/YYYY"
        '
        'WTXT_FROM
        '
        Me.WTXT_FROM.BackColor = System.Drawing.Color.White
        Me.WTXT_FROM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_FROM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_FROM.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!)
        Me.WTXT_FROM.Location = New System.Drawing.Point(9, 10)
        Me.WTXT_FROM.MaxLength = 0
        Me.WTXT_FROM.Name = "WTXT_FROM"
        Me.WTXT_FROM.Size = New System.Drawing.Size(65, 19)
        Me.WTXT_FROM.TabIndex = 3
        Me.WTXT_FROM.Text = "MM/DD/YYYY"
        Me.WTXT_FROM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_FROM.Watermark = "MM/DD/YYYY"
        '
        'FRM_EM_2_BI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(4.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1052, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PNL2)
        Me.Font = New System.Drawing.Font("Bahnschrift Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_EM_2_BI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PNL2.ResumeLayout(False)
        Me.PNL1.ResumeLayout(False)
        Me.PNL1.PerformLayout()
        Me.PNL3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PNL_CUSTOM.ResumeLayout(False)
        Me.PNL_CUSTOM.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL2 As Panel
    Friend WithEvents BTN_F_MINIMIZE As Button
    Friend WithEvents BTN_F_CLOSE As Button
    Friend WithEvents BTN_INMA_MINIMIZE As Button
    Friend WithEvents BTN_INMA_CLOSE As Button
    Friend WithEvents PNL_LBL As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents PNL1 As Panel
    Friend WithEvents PNL3 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CR_VIEWER As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_FILTERBY As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BTN_SEARCH As Button
    Friend WithEvents TXT_SEARCH As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PNL_CUSTOM As Panel
    Friend WithEvents WTXT_TO As WatermarkTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents WTXT_FROM As WatermarkTextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape78 As PowerPacks.RectangleShape
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BTN_SEND_EMAIL As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button2 As Button
End Class
