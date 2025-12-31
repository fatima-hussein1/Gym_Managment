<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectSubMember
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PanelTop = New Guna.UI2.WinForms.Guna2Panel()
        ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        lblTitle = New Label()
        PanelBody = New Guna.UI2.WinForms.Guna2Panel()
        btnSelect = New Guna.UI2.WinForms.Guna2Button()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        dgvSubs = New DataGridView()
        txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        PanelTop.SuspendLayout()
        PanelBody.SuspendLayout()
        CType(dgvSubs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTop
        ' 
        PanelTop.Controls.Add(ControlBoxClose)
        PanelTop.Controls.Add(lblTitle)
        PanelTop.CustomizableEdges = CustomizableEdges3
        PanelTop.Dock = DockStyle.Top
        PanelTop.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        PanelTop.Location = New Point(0, 0)
        PanelTop.Name = "PanelTop"
        PanelTop.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        PanelTop.Size = New Size(900, 42)
        PanelTop.TabIndex = 1
        ' 
        ' ControlBoxClose
        ' 
        ControlBoxClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ControlBoxClose.CustomizableEdges = CustomizableEdges1
        ControlBoxClose.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        ControlBoxClose.HoverState.FillColor = Color.Red
        ControlBoxClose.IconColor = Color.White
        ControlBoxClose.Location = New Point(12, 6)
        ControlBoxClose.Name = "ControlBoxClose"
        ControlBoxClose.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ControlBoxClose.Size = New Size(45, 30)
        ControlBoxClose.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(766, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(119, 28)
        lblTitle.TabIndex = 1
        lblTitle.Text = "اختيار اشتراك"
        ' 
        ' PanelBody
        ' 
        PanelBody.Controls.Add(btnSelect)
        PanelBody.Controls.Add(btnCancel)
        PanelBody.Controls.Add(dgvSubs)
        PanelBody.Controls.Add(txtSearch)
        PanelBody.CustomizableEdges = CustomizableEdges11
        PanelBody.Dock = DockStyle.Fill
        PanelBody.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        PanelBody.Location = New Point(0, 42)
        PanelBody.Name = "PanelBody"
        PanelBody.Padding = New Padding(12)
        PanelBody.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        PanelBody.Size = New Size(900, 568)
        PanelBody.TabIndex = 0
        ' 
        ' btnSelect
        ' 
        btnSelect.Animated = True
        btnSelect.BorderRadius = 10
        btnSelect.CustomizableEdges = CustomizableEdges5
        btnSelect.FillColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        btnSelect.Font = New Font("Segoe UI", 9.0F)
        btnSelect.ForeColor = Color.White
        btnSelect.Location = New Point(482, 467)
        btnSelect.Name = "btnSelect"
        btnSelect.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnSelect.Size = New Size(271, 70)
        btnSelect.TabIndex = 0
        btnSelect.Text = "اختيار"
        ' 
        ' btnCancel
        ' 
        btnCancel.Animated = True
        btnCancel.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        btnCancel.BorderRadius = 10
        btnCancel.BorderThickness = 2
        btnCancel.CustomizableEdges = CustomizableEdges7
        btnCancel.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        btnCancel.Font = New Font("Segoe UI", 9.0F)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(133, 467)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnCancel.Size = New Size(271, 70)
        btnCancel.TabIndex = 1
        btnCancel.Text = "إلغاء"
        ' 
        ' dgvSubs
        ' 
        dgvSubs.AllowUserToAddRows = False
        dgvSubs.AllowUserToDeleteRows = False
        dgvSubs.AllowUserToOrderColumns = True
        dgvSubs.BackgroundColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        dgvSubs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSubs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSubs.ColumnHeadersHeight = 40
        dgvSubs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvSubs.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        DataGridViewCellStyle2.Font = New Font("Simplified Arabic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(36), CByte(45), CByte(77))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvSubs.DefaultCellStyle = DataGridViewCellStyle2
        dgvSubs.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvSubs.EnableHeadersVisualStyles = False
        dgvSubs.GridColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        dgvSubs.Location = New Point(12, 60)
        dgvSubs.MultiSelect = False
        dgvSubs.Name = "dgvSubs"
        dgvSubs.ReadOnly = True
        dgvSubs.RightToLeft = RightToLeft.Yes
        dgvSubs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvSubs.RowHeadersVisible = False
        dgvSubs.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(36), CByte(45), CByte(77))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        dgvSubs.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvSubs.RowTemplate.DividerHeight = 2
        dgvSubs.RowTemplate.Height = 45
        dgvSubs.RowTemplate.Resizable = DataGridViewTriState.False
        dgvSubs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSubs.Size = New Size(873, 383)
        dgvSubs.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        txtSearch.BorderRadius = 6
        txtSearch.CustomizableEdges = CustomizableEdges9
        txtSearch.DefaultText = ""
        txtSearch.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        txtSearch.Font = New Font("Segoe UI", 9.0F)
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(12, 12)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "بحث... (اسم العضو/الباقة/الحالة)"
        txtSearch.RightToLeft = RightToLeft.Yes
        txtSearch.SelectedText = ""
        txtSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtSearch.Size = New Size(876, 36)
        txtSearch.TabIndex = 3
        ' 
        ' FrmSelectSubMember
        ' 
        BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        ClientSize = New Size(900, 610)
        Controls.Add(PanelBody)
        Controls.Add(PanelTop)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmSelectSubMember"
        StartPosition = FormStartPosition.CenterParent
        Text = "FrmSelectSubMember"
        PanelTop.ResumeLayout(False)
        PanelTop.PerformLayout()
        PanelBody.ResumeLayout(False)
        CType(dgvSubs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblTitle As Label

    Friend WithEvents PanelBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvSubs As DataGridView

    Friend WithEvents btnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button

End Class
