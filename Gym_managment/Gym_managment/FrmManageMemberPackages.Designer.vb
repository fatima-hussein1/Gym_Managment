<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageMemberPackages
    Inherits MaterialSkin.Controls.MaterialForm

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
        DGVProduct = New DataGridView()
        Panel1 = New Panel()
        TxtSearch = New TextBox()
        BtnAddMemberSubscription = New Button()
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
        CType(DGVProduct, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGVProduct
        ' 
        DGVProduct.AllowUserToAddRows = False
        DGVProduct.AllowUserToOrderColumns = True
        DGVProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVProduct.BackgroundColor = Color.White
        DGVProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(197), CByte(202), CByte(232))
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGVProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVProduct.ColumnHeadersHeight = 40
        DGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVProduct.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column8, Column2, Column3, Column9, Column10, Column11, Column12, Column13, Column4, Column6, Column7, Column5})
        DGVProduct.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Simplified Arabic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DGVProduct.DefaultCellStyle = DataGridViewCellStyle2
        DGVProduct.Dock = DockStyle.Fill
        DGVProduct.EditMode = DataGridViewEditMode.EditProgrammatically
        DGVProduct.EnableHeadersVisualStyles = False
        DGVProduct.Location = New Point(0, 0)
        DGVProduct.Margin = New Padding(5)
        DGVProduct.MultiSelect = False
        DGVProduct.Name = "DGVProduct"
        DGVProduct.RightToLeft = RightToLeft.Yes
        DGVProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGVProduct.RowHeadersVisible = False
        DGVProduct.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DGVProduct.RowsDefaultCellStyle = DataGridViewCellStyle3
        DGVProduct.RowTemplate.DividerHeight = 2
        DGVProduct.RowTemplate.Height = 45
        DGVProduct.RowTemplate.Resizable = DataGridViewTriState.False
        DGVProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVProduct.Size = New Size(1432, 525)
        DGVProduct.TabIndex = 236
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DGVProduct)
        Panel1.Location = New Point(19, 203)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.Yes
        Panel1.Size = New Size(1432, 525)
        Panel1.TabIndex = 4
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Location = New Point(219, 105)
        TxtSearch.Margin = New Padding(4)
        TxtSearch.Multiline = True
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(970, 41)
        TxtSearch.TabIndex = 3
        ' 
        ' BtnAddMemberSubscription
        ' 
        BtnAddMemberSubscription.BackColor = Color.FromArgb(CByte(157), CByte(161), CByte(185))
        BtnAddMemberSubscription.FlatStyle = FlatStyle.Popup
        BtnAddMemberSubscription.Image = My.Resources.Resources.icons8_add_member_48
        BtnAddMemberSubscription.ImageAlign = ContentAlignment.MiddleRight
        BtnAddMemberSubscription.Location = New Point(1224, 87)
        BtnAddMemberSubscription.Name = "BtnAddMemberSubscription"
        BtnAddMemberSubscription.Size = New Size(227, 92)
        BtnAddMemberSubscription.TabIndex = 5
        BtnAddMemberSubscription.Text = "إضافة إشتراك"
        BtnAddMemberSubscription.UseVisualStyleBackColor = False
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
        ' FrmManageMemberPackages
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1467, 735)
        Controls.Add(Panel1)
        Controls.Add(TxtSearch)
        Controls.Add(BtnAddMemberSubscription)
        Name = "FrmManageMemberPackages"
        StartPosition = FormStartPosition.CenterScreen
        CType(DGVProduct, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGVProduct As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnAddMemberSubscription As Button
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
