<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageMemberPackages
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManageMemberPackages))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        DGVProduct = New DataGridView()
        Column0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewImageColumn()
        Column7 = New DataGridViewImageColumn()
        Column5 = New DataGridViewImageColumn()
        Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        BtnAddMemberSubscription = New Guna.UI2.WinForms.Guna2Button()
        CType(DGVProduct, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGVProduct
        ' 
        DGVProduct.AllowUserToAddRows = False
        DGVProduct.AllowUserToOrderColumns = True
        DGVProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVProduct.BackgroundColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        DGVProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGVProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVProduct.ColumnHeadersHeight = 40
        DGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVProduct.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column8, Column2, Column3, Column9, Column10, Column11, Column12, Column13, Column4, Column6, Column7, Column5})
        DGVProduct.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        DataGridViewCellStyle2.Font = New Font("Simplified Arabic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(36), CByte(45), CByte(77))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DGVProduct.DefaultCellStyle = DataGridViewCellStyle2
        DGVProduct.Dock = DockStyle.Fill
        DGVProduct.EditMode = DataGridViewEditMode.EditProgrammatically
        DGVProduct.EnableHeadersVisualStyles = False
        DGVProduct.GridColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        DGVProduct.Location = New Point(0, 0)
        DGVProduct.Margin = New Padding(5)
        DGVProduct.MultiSelect = False
        DGVProduct.Name = "DGVProduct"
        DGVProduct.RightToLeft = RightToLeft.Yes
        DGVProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGVProduct.RowHeadersVisible = False
        DGVProduct.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(36), CByte(45), CByte(77))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DGVProduct.RowsDefaultCellStyle = DataGridViewCellStyle3
        DGVProduct.RowTemplate.DividerHeight = 2
        DGVProduct.RowTemplate.Height = 45
        DGVProduct.RowTemplate.Resizable = DataGridViewTriState.False
        DGVProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVProduct.Size = New Size(1432, 525)
        DGVProduct.TabIndex = 236
        ' 
        ' Column0
        ' 
        Column0.FillWeight = 78.20972F
        Column0.HeaderText = "رقم اشتراك العضو"
        Column0.MinimumWidth = 6
        Column0.Name = "Column0"
        Column0.Visible = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "رقم العضو"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Visible = False
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "اسم العضو"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "رقم الباقة"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Visible = False
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "اسم الباقة"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "تاريخ البداية"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Visible = False
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "تاريخ النهاية"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.Visible = False
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "حالة اشتراك العضو"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.Visible = False
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "رقم المدرب"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.Visible = False
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "اسم المدرب"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "رقم المستخدم"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Visible = False
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "تعديل"
        Column6.Image = CType(resources.GetObject("Column6.Image"), Image)
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Resizable = DataGridViewTriState.True
        Column6.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "حذف"
        Column7.Image = CType(resources.GetObject("Column7.Image"), Image)
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Resizable = DataGridViewTriState.True
        Column7.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "عرض تفاصيل "
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Panel1
        ' 
        Panel1.BorderRadius = 10
        Panel1.Controls.Add(DGVProduct)
        Panel1.CustomizableEdges = CustomizableEdges1
        Panel1.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        Panel1.Location = New Point(19, 203)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.Yes
        Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Panel1.Size = New Size(1432, 525)
        Panel1.TabIndex = 4
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Animated = True
        TxtSearch.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        TxtSearch.BorderRadius = 6
        TxtSearch.Cursor = Cursors.IBeam
        TxtSearch.CustomizableEdges = CustomizableEdges3
        TxtSearch.DefaultText = ""
        TxtSearch.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        TxtSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TxtSearch.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtSearch.ForeColor = Color.White
        TxtSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TxtSearch.Location = New Point(19, 99)
        TxtSearch.Margin = New Padding(6, 7, 6, 7)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.PlaceholderText = "بحث بالاسم / الباقة / المدرب"
        TxtSearch.SelectedText = ""
        TxtSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        TxtSearch.Size = New Size(1178, 69)
        TxtSearch.TabIndex = 3
        TxtSearch.TextAlign = HorizontalAlignment.Right
        ' 
        ' BtnAddMemberSubscription
        ' 
        BtnAddMemberSubscription.Animated = True
        BtnAddMemberSubscription.BackColor = Color.Transparent
        BtnAddMemberSubscription.BorderRadius = 10
        BtnAddMemberSubscription.CustomizableEdges = CustomizableEdges5
        BtnAddMemberSubscription.FillColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnAddMemberSubscription.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAddMemberSubscription.ForeColor = Color.White
        BtnAddMemberSubscription.Image = My.Resources.Resources.icons8_add_member_48
        BtnAddMemberSubscription.ImageAlign = HorizontalAlignment.Right
        BtnAddMemberSubscription.ImageSize = New Size(60, 60)
        BtnAddMemberSubscription.Location = New Point(1224, 87)
        BtnAddMemberSubscription.Name = "BtnAddMemberSubscription"
        BtnAddMemberSubscription.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        BtnAddMemberSubscription.Size = New Size(227, 81)
        BtnAddMemberSubscription.TabIndex = 5
        BtnAddMemberSubscription.Text = "إضافة إشتراك"
        BtnAddMemberSubscription.UseTransparentBackground = True
        ' 
        ' FrmManageMemberPackages
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        ClientSize = New Size(1467, 735)
        Controls.Add(Panel1)
        Controls.Add(TxtSearch)
        Controls.Add(BtnAddMemberSubscription)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmManageMemberPackages"
        StartPosition = FormStartPosition.CenterScreen
        CType(DGVProduct, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGVProduct As DataGridView
    Friend WithEvents Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnAddMemberSubscription As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
End Class
