<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTrainers
    Inherits MaterialSkin.Controls.MaterialForm

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrainers))
        PanelTop = New Panel()
        BtnAddtrain = New Button()
        dgvTrainers = New DataGridView()
        Column0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewImageColumn()
        Column6 = New DataGridViewImageColumn()
        Column7 = New DataGridViewImageColumn()
        Panel1 = New Panel()
        PanelTop.SuspendLayout()
        CType(dgvTrainers, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTop
        ' 
        PanelTop.Controls.Add(BtnAddtrain)
        PanelTop.Dock = DockStyle.Top
        PanelTop.Location = New Point(3, 64)
        PanelTop.Name = "PanelTop"
        PanelTop.Size = New Size(1180, 100)
        PanelTop.TabIndex = 1
        ' 
        ' BtnAddtrain
        ' 
        BtnAddtrain.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnAddtrain.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAddtrain.Image = My.Resources.Resources.icons8_add_641
        BtnAddtrain.ImageAlign = ContentAlignment.MiddleRight
        BtnAddtrain.Location = New Point(940, 3)
        BtnAddtrain.Name = "BtnAddtrain"
        BtnAddtrain.Size = New Size(220, 81)
        BtnAddtrain.TabIndex = 3
        BtnAddtrain.Text = "≈÷«›… „œ—»"
        BtnAddtrain.TextAlign = ContentAlignment.MiddleLeft
        BtnAddtrain.UseVisualStyleBackColor = False
        ' 
        ' dgvTrainers
        ' 
        dgvTrainers.AllowUserToAddRows = False
        dgvTrainers.AllowUserToOrderColumns = True
        dgvTrainers.BackgroundColor = Color.White
        dgvTrainers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.LightGray
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvTrainers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvTrainers.ColumnHeadersHeight = 40
        dgvTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvTrainers.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        dgvTrainers.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Simplified Arabic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvTrainers.DefaultCellStyle = DataGridViewCellStyle2
        dgvTrainers.Dock = DockStyle.Fill
        dgvTrainers.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvTrainers.EnableHeadersVisualStyles = False
        dgvTrainers.Location = New Point(0, 0)
        dgvTrainers.Margin = New Padding(5)
        dgvTrainers.MultiSelect = False
        dgvTrainers.Name = "dgvTrainers"
        dgvTrainers.RightToLeft = RightToLeft.Yes
        dgvTrainers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvTrainers.RowHeadersVisible = False
        dgvTrainers.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        dgvTrainers.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvTrainers.RowTemplate.DividerHeight = 2
        dgvTrainers.RowTemplate.Height = 45
        dgvTrainers.RowTemplate.Resizable = DataGridViewTriState.False
        dgvTrainers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTrainers.Size = New Size(1173, 518)
        dgvTrainers.TabIndex = 237
        ' 
        ' Column0
        ' 
        Column0.FillWeight = 78.20972F
        Column0.HeaderText = "—ﬁ„ «·„œ—»"
        Column0.MinimumWidth = 6
        Column0.Name = "Column0"
        Column0.Visible = False
        Column0.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "«”„ «·„œ—»"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 168
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "—ﬁ„ «·Â« ›"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 168
        ' 
        ' Column3
        ' 
        Column3.HeaderText = " «—ÌŒ «· ”ÃÌ·"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 167
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "—ﬁ„ «·„” Œœ„"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Visible = False
        Column4.Width = 168
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "«·’Ê—…"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Automatic
        Column5.Width = 169
        ' 
        ' Column6
        ' 
        Column6.HeaderText = " ⁄œÌ·"
        Column6.Image = CType(resources.GetObject("Column6.Image"), Image)
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Resizable = DataGridViewTriState.True
        Column6.SortMode = DataGridViewColumnSortMode.Automatic
        Column6.Width = 168
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Õ–›"
        Column7.Image = CType(resources.GetObject("Column7.Image"), Image)
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Resizable = DataGridViewTriState.True
        Column7.SortMode = DataGridViewColumnSortMode.Automatic
        Column7.Width = 169
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(dgvTrainers)
        Panel1.Location = New Point(3, 199)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1177, 522)
        Panel1.TabIndex = 4
        ' 
        ' FrmTrainers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1186, 727)
        Controls.Add(Panel1)
        Controls.Add(PanelTop)
        Name = "FrmTrainers"
        PanelTop.ResumeLayout(False)
        CType(dgvTrainers, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As Panel
    Friend WithEvents dgvTrainers As DataGridView
    Friend WithEvents BtnAddtrain As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
End Class