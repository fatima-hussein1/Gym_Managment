<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmManagememberr
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManagememberr))
        TxtSearch = New TextBox()
        Panel1 = New Panel()
        DGVProduct = New DataGridView()
        Column0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewImageColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewImageColumn()
        Column7 = New DataGridViewImageColumn()
        BtnAddMember = New Button()
        Panel1.SuspendLayout()
        CType(DGVProduct, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Location = New Point(387, 117)
        TxtSearch.Margin = New Padding(4)
        TxtSearch.Multiline = True
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(600, 41)
        TxtSearch.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DGVProduct)
        Panel1.Location = New Point(8, 175)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.Yes
        Panel1.Size = New Size(1216, 483)
        Panel1.TabIndex = 1
        ' 
        ' DGVProduct
        ' 
        DGVProduct.AllowUserToAddRows = False
        DGVProduct.AllowUserToOrderColumns = True
        DGVProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVProduct.BackgroundColor = Color.White
        DGVProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.LightGray
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGVProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVProduct.ColumnHeadersHeight = 40
        DGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVProduct.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column2, Column3, Column5, Column4, Column6, Column7})
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
        BtnAddMember.Image = My.Resources.Resources.icons8_add_member_48
        BtnAddMember.ImageAlign = ContentAlignment.MiddleRight
        BtnAddMember.Location = New Point(994, 100)
        BtnAddMember.Name = "BtnAddMember"
        BtnAddMember.Size = New Size(230, 67)
        BtnAddMember.TabIndex = 2
        BtnAddMember.Text = "إضافة عضو"
        BtnAddMember.UseVisualStyleBackColor = True
        ' 
        ' FrmManagememberr
        ' 
        AutoScaleDimensions = New SizeF(13F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1233, 685)
        Controls.Add(BtnAddMember)
        Controls.Add(Panel1)
        Controls.Add(TxtSearch)
        Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5, 4, 5, 4)
        Name = "FrmManagememberr"
        Padding = New Padding(5, 83, 5, 4)
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        CType(DGVProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVProduct As DataGridView
    Friend WithEvents BtnAddMember As Button
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
End Class
