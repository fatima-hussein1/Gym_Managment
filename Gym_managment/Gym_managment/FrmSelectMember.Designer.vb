<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectMember
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PanelTop = New Guna.UI2.WinForms.Guna2Panel()
        ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        lblTitle = New Label()
        PanelBody = New Guna.UI2.WinForms.Guna2Panel()
        DGVMembers = New DataGridView()
        txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        btnSelect = New Guna.UI2.WinForms.Guna2Button()
        Column0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewImageColumn()
        Column4 = New DataGridViewTextBoxColumn()
        PanelTop.SuspendLayout()
        PanelBody.SuspendLayout()
        CType(DGVMembers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTop
        ' 
        PanelTop.Controls.Add(ControlBoxMin)
        PanelTop.Controls.Add(ControlBoxClose)
        PanelTop.Controls.Add(lblTitle)
        PanelTop.CustomizableEdges = CustomizableEdges5
        PanelTop.Dock = DockStyle.Top
        PanelTop.FillColor = Color.FromArgb(0, 9, 43)
        PanelTop.Location = New Point(0, 0)
        PanelTop.Name = "PanelTop"
        PanelTop.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        PanelTop.Size = New Size(806, 42)
        PanelTop.TabIndex = 1
        ' 
        ' ControlBoxMin
        ' 
        ControlBoxMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        ControlBoxMin.CustomizableEdges = CustomizableEdges1
        ControlBoxMin.FillColor = Color.FromArgb(0, 9, 43)
        ControlBoxMin.IconColor = Color.White
        ControlBoxMin.Location = New Point(63, 6)
        ControlBoxMin.Name = "ControlBoxMin"
        ControlBoxMin.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ControlBoxMin.Size = New Size(45, 30)
        ControlBoxMin.TabIndex = 0
        ' 
        ' ControlBoxClose
        ' 
        ControlBoxClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ControlBoxClose.CustomizableEdges = CustomizableEdges3
        ControlBoxClose.FillColor = Color.FromArgb(0, 9, 43)
        ControlBoxClose.HoverState.FillColor = Color.Red
        ControlBoxClose.IconColor = Color.White
        ControlBoxClose.Location = New Point(12, 6)
        ControlBoxClose.Name = "ControlBoxClose"
        ControlBoxClose.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        ControlBoxClose.Size = New Size(45, 30)
        ControlBoxClose.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(684, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(104, 28)
        lblTitle.TabIndex = 2
        lblTitle.Text = "اختيار عضو"
        ' 
        ' PanelBody
        ' 
        PanelBody.Controls.Add(DGVMembers)
        PanelBody.Controls.Add(txtSearch)
        PanelBody.Controls.Add(btnCancel)
        PanelBody.Controls.Add(btnSelect)
        PanelBody.CustomizableEdges = CustomizableEdges13
        PanelBody.Dock = DockStyle.Fill
        PanelBody.FillColor = Color.FromArgb(0, 9, 43)
        PanelBody.Location = New Point(0, 42)
        PanelBody.Name = "PanelBody"
        PanelBody.Padding = New Padding(12)
        PanelBody.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        PanelBody.Size = New Size(806, 480)
        PanelBody.TabIndex = 0
        ' 
        ' DGVMembers
        ' 
        DGVMembers.AllowUserToAddRows = False
        DGVMembers.AllowUserToOrderColumns = True
        DGVMembers.BackgroundColor = Color.FromArgb(0, 9, 43)
        DGVMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(193, 20, 137)
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(193, 20, 137)
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGVMembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVMembers.ColumnHeadersHeight = 40
        DGVMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVMembers.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column2, Column3, Column5, Column4})
        DGVMembers.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(0, 9, 43)
        DataGridViewCellStyle2.Font = New Font("Simplified Arabic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(36, 45, 77)
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DGVMembers.DefaultCellStyle = DataGridViewCellStyle2
        DGVMembers.EditMode = DataGridViewEditMode.EditProgrammatically
        DGVMembers.EnableHeadersVisualStyles = False
        DGVMembers.GridColor = Color.FromArgb(234, 153, 149)
        DGVMembers.Location = New Point(26, 57)
        DGVMembers.Margin = New Padding(5)
        DGVMembers.MultiSelect = False
        DGVMembers.Name = "DGVMembers"
        DGVMembers.RightToLeft = RightToLeft.Yes
        DGVMembers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGVMembers.RowHeadersVisible = False
        DGVMembers.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(36, 45, 77)
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DGVMembers.RowsDefaultCellStyle = DataGridViewCellStyle3
        DGVMembers.RowTemplate.DividerHeight = 2
        DGVMembers.RowTemplate.Height = 45
        DGVMembers.RowTemplate.Resizable = DataGridViewTriState.False
        DGVMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVMembers.Size = New Size(762, 266)
        DGVMembers.TabIndex = 237
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderColor = Color.FromArgb(234, 153, 149)
        txtSearch.BorderRadius = 6
        txtSearch.CustomizableEdges = CustomizableEdges7
        txtSearch.DefaultText = ""
        txtSearch.FillColor = Color.FromArgb(0, 9, 43)
        txtSearch.Font = New Font("Segoe UI", 9.0F)
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(12, 12)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "بحث بالاسم..."
        txtSearch.RightToLeft = RightToLeft.Yes
        txtSearch.SelectedText = ""
        txtSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtSearch.Size = New Size(776, 36)
        txtSearch.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.Animated = True
        btnCancel.BorderColor = Color.FromArgb(234, 153, 149)
        btnCancel.BorderRadius = 10
        btnCancel.BorderThickness = 2
        btnCancel.CustomizableEdges = CustomizableEdges9
        btnCancel.FillColor = Color.FromArgb(0, 9, 43)
        btnCancel.Font = New Font("Segoe UI", 9.0F)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(113, 374)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnCancel.Size = New Size(239, 56)
        btnCancel.TabIndex = 2
        btnCancel.Text = "إلغاء"
        ' 
        ' btnSelect
        ' 
        btnSelect.Animated = True
        btnSelect.BorderRadius = 10
        btnSelect.CustomizableEdges = CustomizableEdges11
        btnSelect.FillColor = Color.FromArgb(193, 20, 137)
        btnSelect.Font = New Font("Segoe UI", 9.0F)
        btnSelect.ForeColor = Color.White
        btnSelect.Location = New Point(445, 374)
        btnSelect.Name = "btnSelect"
        btnSelect.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnSelect.Size = New Size(239, 56)
        btnSelect.TabIndex = 3
        btnSelect.Text = "اختيار"
        ' 
        ' Column0
        ' 
        Column0.FillWeight = 78.20972F
        Column0.HeaderText = "رقم العضو"
        Column0.MinimumWidth = 6
        Column0.Name = "Column0"
        Column0.Visible = False
        Column0.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "اسم"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 200
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "رقم الهاتف"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 130
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "تاريخ التسجيل"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 123
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الصورة"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Automatic
        Column5.Width = 132
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "رقم المستخدم"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Visible = False
        Column4.Width = 125
        ' 
        ' FrmSelectMember
        ' 
        BackColor = Color.FromArgb(0, 9, 43)
        ClientSize = New Size(806, 522)
        Controls.Add(PanelBody)
        Controls.Add(PanelTop)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmSelectMember"
        StartPosition = FormStartPosition.CenterScreen
        PanelTop.ResumeLayout(False)
        PanelTop.PerformLayout()
        PanelBody.ResumeLayout(False)
        CType(DGVMembers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblTitle As Label

    Friend WithEvents PanelBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGVMembers As DataGridView
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
