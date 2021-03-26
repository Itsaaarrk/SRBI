<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PREVIEW
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CRV_PREVIEW = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BTN_VIEW_LOGS = New System.Windows.Forms.Button()
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SPM4_PRINTSTICKERDataGridView = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SPM4_TRP_LISTTableAdapter = New SRBI.DS_STOREDPROCTableAdapters.SPM4_TRP_LISTTableAdapter()
        Me.SPM4TRPLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New SRBI.DS_STOREDPROC()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PNL2.SuspendLayout()
        Me.PNL1.SuspendLayout()
        Me.PNL3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PRINTSTICKERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4TRPLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.BTN_VIEW_LOGS)
        Me.Panel1.Controls.Add(Me.PNL2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 450)
        Me.Panel1.TabIndex = 1469
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CRV_PREVIEW)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(533, 374)
        Me.Panel2.TabIndex = 1415
        '
        'CRV_PREVIEW
        '
        Me.CRV_PREVIEW.ActiveViewIndex = -1
        Me.CRV_PREVIEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_PREVIEW.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_PREVIEW.DisplayBackgroundEdge = False
        Me.CRV_PREVIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_PREVIEW.EnableRefresh = False
        Me.CRV_PREVIEW.Location = New System.Drawing.Point(0, 0)
        Me.CRV_PREVIEW.Name = "CRV_PREVIEW"
        Me.CRV_PREVIEW.ShowCloseButton = False
        Me.CRV_PREVIEW.ShowCopyButton = False
        Me.CRV_PREVIEW.ShowGroupTreeButton = False
        Me.CRV_PREVIEW.ShowLogo = False
        Me.CRV_PREVIEW.ShowPrintButton = False
        Me.CRV_PREVIEW.ShowRefreshButton = False
        Me.CRV_PREVIEW.ShowTextSearchButton = False
        Me.CRV_PREVIEW.Size = New System.Drawing.Size(533, 374)
        Me.CRV_PREVIEW.TabIndex = 0
        Me.CRV_PREVIEW.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'BTN_VIEW_LOGS
        '
        Me.BTN_VIEW_LOGS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BTN_VIEW_LOGS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_VIEW_LOGS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTN_VIEW_LOGS.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.BTN_VIEW_LOGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VIEW_LOGS.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_VIEW_LOGS.ForeColor = System.Drawing.Color.White
        Me.BTN_VIEW_LOGS.Location = New System.Drawing.Point(0, 418)
        Me.BTN_VIEW_LOGS.Name = "BTN_VIEW_LOGS"
        Me.BTN_VIEW_LOGS.Size = New System.Drawing.Size(533, 32)
        Me.BTN_VIEW_LOGS.TabIndex = 1414
        Me.BTN_VIEW_LOGS.Text = "PRINT"
        Me.BTN_VIEW_LOGS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_VIEW_LOGS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BTN_VIEW_LOGS.UseMnemonic = False
        Me.BTN_VIEW_LOGS.UseVisualStyleBackColor = False
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
        Me.PNL2.Size = New System.Drawing.Size(533, 44)
        Me.PNL2.TabIndex = 1413
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
        Me.PNL_LBL.Text = "PRINT PREVIEW"
        '
        'PNL3
        '
        Me.PNL3.Controls.Add(Me.BTN_F_MINIMIZE)
        Me.PNL3.Controls.Add(Me.BTN_F_CLOSE)
        Me.PNL3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PNL3.Location = New System.Drawing.Point(443, 0)
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
        Me.BTN_INMA_MINIMIZE.Location = New System.Drawing.Point(-1535, 8)
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
        Me.BTN_INMA_CLOSE.Location = New System.Drawing.Point(-1500, 7)
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-7354, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-7307, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(3, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'SPM4_PRINTSTICKERDataGridView
        '
        Me.SPM4_PRINTSTICKERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SPM4_PRINTSTICKERDataGridView.Location = New System.Drawing.Point(3052, 100)
        Me.SPM4_PRINTSTICKERDataGridView.Name = "SPM4_PRINTSTICKERDataGridView"
        Me.SPM4_PRINTSTICKERDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.SPM4_PRINTSTICKERDataGridView.TabIndex = 1466
        Me.SPM4_PRINTSTICKERDataGridView.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-1376, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 1465
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'SPM4_TRP_LISTTableAdapter
        '
        Me.SPM4_TRP_LISTTableAdapter.ClearBeforeFill = True
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
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'FRM_PREVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(4.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SPM4_PRINTSTICKERDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Bahnschrift Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FRM_PREVIEW"
        Me.Text = "FRM_PREVIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PNL2.ResumeLayout(False)
        Me.PNL1.ResumeLayout(False)
        Me.PNL1.PerformLayout()
        Me.PNL3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PRINTSTICKERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4TRPLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CRV_PREVIEW As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SPM4_PRINTSTICKERDataGridView As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PNL2 As Panel
    Friend WithEvents PNL1 As Panel
    Friend WithEvents PNL_LBL As Label
    Friend WithEvents PNL3 As Panel
    Friend WithEvents BTN_F_MINIMIZE As Button
    Friend WithEvents BTN_F_CLOSE As Button
    Friend WithEvents BTN_INMA_MINIMIZE As Button
    Friend WithEvents BTN_INMA_CLOSE As Button
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents BTN_VIEW_LOGS As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SPM4_TRP_LISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_TRP_LISTTableAdapter
    Friend WithEvents SPM4TRPLISTBindingSource As BindingSource
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents PrintDocument As Printing.PrintDocument
End Class
