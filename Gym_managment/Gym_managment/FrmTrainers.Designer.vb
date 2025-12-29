<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTrainers
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PanelTop = New Guna.UI2.WinForms.Guna2Panel()
        BtnAddtrain = New Guna.UI2.WinForms.Guna2Button()
        dgvTrainers = New DataGridView()
        Column0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewImageColumn()
        Column6 = New DataGridViewImageColumn()
        Column7 = New DataGridViewImageColumn()
        Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        CType(dgvTrainers, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTop
        ' 
        PanelTop.CustomizableEdges = CustomizableEdges1
        PanelTop.Dock = DockStyle.Top
        PanelTop.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        PanelTop.Location = New Point(0, 0)
        PanelTop.Name = "PanelTop"
        PanelTop.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        PanelTop.Size = New Size(1186, 100)
        PanelTop.TabIndex = 1
        ' 
        ' BtnAddtrain
        ' 
        BtnAddtrain.Animated = True
        BtnAddtrain.BackColor = Color.Transparent
        BtnAddtrain.BorderRadius = 10
        BtnAddtrain.CustomizableEdges = CustomizableEdges3
        BtnAddtrain.FillColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnAddtrain.Font = New Font("Segoe UI", 10.0F)
        BtnAddtrain.ForeColor = Color.White
        BtnAddtrain.Image = My.Resources.Resources.icons8_add_641
        BtnAddtrain.ImageAlign = HorizontalAlignment.Right
        BtnAddtrain.ImageSize = New Size(40, 40)
        BtnAddtrain.Location = New Point(954, 133)
        BtnAddtrain.Name = "BtnAddtrain"
        BtnAddtrain.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        BtnAddtrain.Size = New Size(220, 58)
        BtnAddtrain.TabIndex = 3
        BtnAddtrain.Text = "≈÷«›… „œ—»"
        BtnAddtrain.TextAlign = HorizontalAlignment.Left
        BtnAddtrain.UseTransparentBackground = True
        ' 
        ' dgvTrainers
        ' 
        dgvTrainers.AllowUserToAddRows = False
        dgvTrainers.AllowUserToOrderColumns = True
        dgvTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTrainers.BackgroundColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        dgvTrainers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvTrainers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvTrainers.ColumnHeadersHeight = 40
        dgvTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvTrainers.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        dgvTrainers.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        DataGridViewCellStyle2.Font = New Font("Simplified Arabic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(36), CByte(45), CByte(77))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvTrainers.DefaultCellStyle = DataGridViewCellStyle2
        dgvTrainers.Dock = DockStyle.Fill
        dgvTrainers.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvTrainers.EnableHeadersVisualStyles = False
        dgvTrainers.GridColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        dgvTrainers.Location = New Point(0, 0)
        dgvTrainers.Margin = New Padding(5)
        dgvTrainers.MultiSelect = False
        dgvTrainers.Name = "dgvTrainers"
        dgvTrainers.RightToLeft = RightToLeft.Yes
        dgvTrainers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvTrainers.RowHeadersVisible = False
        dgvTrainers.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(36), CByte(45), CByte(77))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        dgvTrainers.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvTrainers.RowTemplate.DividerHeight = 2
        dgvTrainers.RowTemplate.Height = 45
        dgvTrainers.RowTemplate.Resizable = DataGridViewTriState.False
        dgvTrainers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTrainers.Size = New Size(1177, 522)
        dgvTrainers.TabIndex = 237
        ' 
        ' Column0
        ' 
        Column0.HeaderText = "—ﬁ„ «·„œ—»"
        Column0.MinimumWidth = 6
        Column0.Name = "Column0"
        Column0.Visible = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "«”„ "
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "—ﬁ„ «·Â« ›"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = " «—ÌŒ «·≈‰÷„«„"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Â· „›⁄·"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Visible = False
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "«·’Ê—…"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = " ⁄œÌ·"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Õ–›"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        ' 
        ' Panel1
        ' 
        Panel1.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        Panel1.BorderRadius = 10
        Panel1.BorderThickness = 1
        Panel1.Controls.Add(dgvTrainers)
        Panel1.CustomizableEdges = CustomizableEdges5
        Panel1.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        Panel1.Location = New Point(3, 199)
        Panel1.Name = "Panel1"
        Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Panel1.Size = New Size(1177, 522)
        Panel1.TabIndex = 4
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 10
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.BorderRadius = 10
        Guna2ShadowForm1.ShadowColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' FrmTrainers
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        ClientSize = New Size(1186, 727)
        Controls.Add(BtnAddtrain)
        Controls.Add(Panel1)
        Controls.Add(PanelTop)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmTrainers"
        CType(dgvTrainers, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvTrainers As DataGridView
    Friend WithEvents BtnAddtrain As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
End Class