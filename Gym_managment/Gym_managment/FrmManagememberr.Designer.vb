<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmManagememberr
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManagememberr))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        DGVProduct = New DataGridView()
        Column0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewImageColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewImageColumn()
        Column7 = New DataGridViewImageColumn()
        BtnAddMember = New Guna.UI2.WinForms.Guna2Button()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Panel1.SuspendLayout()
        CType(DGVProduct, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Animated = True
        TxtSearch.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        TxtSearch.BorderRadius = 6
        TxtSearch.Cursor = Cursors.IBeam
        TxtSearch.CustomizableEdges = CustomizableEdges1
        TxtSearch.DefaultText = ""
        TxtSearch.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        TxtSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TxtSearch.Font = New Font("Segoe UI", 9.0F)
        TxtSearch.ForeColor = Color.White
        TxtSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        TxtSearch.Location = New Point(29, 89)
        TxtSearch.Margin = New Padding(4, 6, 4, 6)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.PlaceholderText = "بحث بالاسم / الهاتف"
        TxtSearch.SelectedText = ""
        TxtSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        TxtSearch.Size = New Size(942, 55)
        TxtSearch.TabIndex = 0
        TxtSearch.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel1
        ' 
        Panel1.BorderRadius = 10
        Panel1.Controls.Add(DGVProduct)
        Panel1.CustomizableEdges = CustomizableEdges3
        Panel1.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        Panel1.Location = New Point(8, 175)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.Yes
        Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Panel1.Size = New Size(1216, 483)
        Panel1.TabIndex = 1
        ' 
        ' DGVProduct
        ' 
        DGVProduct.AllowUserToAddRows = False
        DGVProduct.AllowUserToOrderColumns = True
        DGVProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVProduct.BackgroundColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        DGVProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGVProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVProduct.ColumnHeadersHeight = 40
        DGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVProduct.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column2, Column3, Column5, Column4, Column6, Column7})
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
        DGVProduct.Size = New Size(1216, 483)
        DGVProduct.TabIndex = 236
        ' 
        ' Column0
        ' 
        Column0.FillWeight = 78.20972F
        Column0.HeaderText = "رقم العضو"
        Column0.MinimumWidth = 6
        Column0.Name = "Column0"
        Column0.Visible = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "اسم"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "رقم الهاتف"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "تاريخ التسجيل"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الصورة"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Automatic
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
        ' BtnAddMember
        ' 
        BtnAddMember.Animated = True
        BtnAddMember.BackColor = Color.Transparent
        BtnAddMember.BorderRadius = 10
        BtnAddMember.CustomizableEdges = CustomizableEdges5
        BtnAddMember.FillColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnAddMember.Font = New Font("Segoe UI", 10.0F)
        BtnAddMember.ForeColor = Color.White
        BtnAddMember.Image = My.Resources.Resources.icons8_add_member_48
        BtnAddMember.ImageAlign = HorizontalAlignment.Right
        BtnAddMember.ImageSize = New Size(60, 60)
        BtnAddMember.Location = New Point(978, 86)
        BtnAddMember.Name = "BtnAddMember"
        BtnAddMember.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        BtnAddMember.Size = New Size(230, 69)
        BtnAddMember.TabIndex = 2
        BtnAddMember.Text = "إضافة عضو"
        BtnAddMember.UseTransparentBackground = True
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges7
        Guna2ControlBox2.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        Guna2ControlBox2.IconColor = Color.White
        Guna2ControlBox2.Location = New Point(64, 7)
        Guna2ControlBox2.Margin = New Padding(4, 5, 4, 5)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2ControlBox2.Size = New Size(47, 43)
        Guna2ControlBox2.TabIndex = 5
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges9
        Guna2ControlBox1.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        Guna2ControlBox1.HoverState.FillColor = Color.Red
        Guna2ControlBox1.IconColor = Color.White
        Guna2ControlBox1.Location = New Point(9, 7)
        Guna2ControlBox1.Margin = New Padding(4, 5, 4, 5)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2ControlBox1.Size = New Size(47, 43)
        Guna2ControlBox1.TabIndex = 4
        ' 
        ' FrmManagememberr
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 26.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        ClientSize = New Size(1233, 685)
        Controls.Add(Guna2ControlBox2)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(BtnAddMember)
        Controls.Add(Panel1)
        Controls.Add(TxtSearch)
        Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 4, 5, 4)
        Name = "FrmManagememberr"
        Padding = New Padding(5, 83, 5, 4)
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        CType(DGVProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGVProduct As DataGridView
    Friend WithEvents BtnAddMember As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Private WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Private WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
