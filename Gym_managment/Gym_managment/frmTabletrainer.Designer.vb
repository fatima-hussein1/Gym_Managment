<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTabletrainer
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()

        PnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        CbMin = New Guna.UI2.WinForms.Guna2ControlBox()
        CbClose = New Guna.UI2.WinForms.Guna2ControlBox()
        LblTitle = New Label()
        DragHeader = New Guna.UI2.WinForms.Guna2DragControl(components)

        PnlBody = New Guna.UI2.WinForms.Guna2Panel()
        PnlFilters = New Guna.UI2.WinForms.Guna2Panel()
        LblDate = New Label()
        DtpDay = New Guna.UI2.WinForms.Guna2DateTimePicker()
        LblStatus = New Label()
        CmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        BtnRefresh = New Guna.UI2.WinForms.Guna2Button()

        PnlGrid = New Guna.UI2.WinForms.Guna2Panel()
        GridApps = New Guna.UI2.WinForms.Guna2DataGridView()

        ColId = New DataGridViewTextBoxColumn()
        ColDate = New DataGridViewTextBoxColumn()
        ColStart = New DataGridViewTextBoxColumn()
        ColEnd = New DataGridViewTextBoxColumn()
        ColStatus = New DataGridViewTextBoxColumn()
        ColNotes = New DataGridViewTextBoxColumn()

        PnlHeader.SuspendLayout()
        PnlBody.SuspendLayout()
        PnlFilters.SuspendLayout()
        PnlGrid.SuspendLayout()
        CType(GridApps, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' 
        ' PnlHeader
        ' 
        PnlHeader.Controls.Add(CbMin)
        PnlHeader.Controls.Add(CbClose)
        PnlHeader.Controls.Add(LblTitle)
        PnlHeader.CustomizableEdges = CustomizableEdges1
        PnlHeader.Dock = DockStyle.Top
        PnlHeader.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        PnlHeader.Location = New Point(0, 0)
        PnlHeader.Name = "PnlHeader"
        PnlHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        PnlHeader.Size = New Size(1100, 64)
        PnlHeader.TabIndex = 0

        ' 
        ' CbMin
        ' 
        CbMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        CbMin.CustomizableEdges = CustomizableEdges3
        CbMin.Dock = DockStyle.Left
        CbMin.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        CbMin.IconColor = Color.White
        CbMin.Location = New Point(48, 0)
        CbMin.Name = "CbMin"
        CbMin.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        CbMin.Size = New Size(48, 64)
        CbMin.TabIndex = 2

        ' 
        ' CbClose
        ' 
        CbClose.CustomizableEdges = CustomizableEdges5
        CbClose.Dock = DockStyle.Left
        CbClose.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        CbClose.HoverState.FillColor = Color.Red
        CbClose.IconColor = Color.White
        CbClose.Location = New Point(0, 0)
        CbClose.Name = "CbClose"
        CbClose.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        CbClose.Size = New Size(48, 64)
        CbClose.TabIndex = 1

        ' 
        ' LblTitle
        ' 
        LblTitle.Dock = DockStyle.Fill
        LblTitle.Font = New Font("Times New Roman", 13.8F)
        LblTitle.ForeColor = Color.White
        LblTitle.Location = New Point(0, 0)
        LblTitle.Name = "LblTitle"
        LblTitle.Padding = New Padding(12, 0, 12, 0)
        LblTitle.Size = New Size(1100, 64)
        LblTitle.TabIndex = 0
        LblTitle.Text = "جدول مواعيدي"
        LblTitle.TextAlign = ContentAlignment.MiddleLeft

        ' 
        ' DragHeader
        ' 
        DragHeader.ContainerControl = Me
        DragHeader.TargetControl = PnlHeader
        DragHeader.UseTransparentDrag = True

        ' 
        ' PnlBody
        ' 
        PnlBody.Controls.Add(PnlGrid)
        PnlBody.Controls.Add(PnlFilters)
        PnlBody.CustomizableEdges = CustomizableEdges7
        PnlBody.Dock = DockStyle.Fill
        PnlBody.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        PnlBody.Location = New Point(0, 64)
        PnlBody.Name = "PnlBody"
        PnlBody.Padding = New Padding(12)
        PnlBody.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        PnlBody.Size = New Size(1100, 636)
        PnlBody.TabIndex = 1

        ' 
        ' PnlFilters
        ' 
        PnlFilters.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        PnlFilters.BorderRadius = 14
        PnlFilters.BorderThickness = 1
        PnlFilters.Controls.Add(BtnRefresh)
        PnlFilters.Controls.Add(TxtSearch)
        PnlFilters.Controls.Add(CmbStatus)
        PnlFilters.Controls.Add(LblStatus)
        PnlFilters.Controls.Add(DtpDay)
        PnlFilters.Controls.Add(LblDate)
        PnlFilters.CustomizableEdges = CustomizableEdges9
        PnlFilters.Dock = DockStyle.Top
        PnlFilters.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        PnlFilters.Location = New Point(12, 12)
        PnlFilters.Name = "PnlFilters"
        PnlFilters.Padding = New Padding(12)
        PnlFilters.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        PnlFilters.Size = New Size(1076, 96)
        PnlFilters.TabIndex = 0

        ' 
        ' LblDate
        ' 
        LblDate.AutoSize = True
        LblDate.Font = New Font("Times New Roman", 12.0F)
        LblDate.ForeColor = Color.White
        LblDate.Location = New Point(980, 15)
        LblDate.Name = "LblDate"
        LblDate.Size = New Size(55, 22)
        LblDate.TabIndex = 0
        LblDate.Text = "اليوم:"

        ' 
        ' DtpDay
        ' 
        DtpDay.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        DtpDay.BorderRadius = 6
        DtpDay.Checked = True
        DtpDay.CustomizableEdges = CustomizableEdges11
        DtpDay.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        DtpDay.Font = New Font("Segoe UI", 10.0F)
        DtpDay.ForeColor = Color.White
        DtpDay.Format = DateTimePickerFormat.Short
        DtpDay.Location = New Point(760, 40)
        DtpDay.MaxDate = New Date(2077, 11, 16, 23, 59, 59, 0)
        DtpDay.MinDate = New Date(1900, 4, 30, 0, 0, 0, 0)
        DtpDay.Name = "DtpDay"
        DtpDay.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        DtpDay.Size = New Size(275, 40)
        DtpDay.TabIndex = 1
        DtpDay.Value = Date.Today

        ' 
        ' LblStatus
        ' 
        LblStatus.AutoSize = True
        LblStatus.Font = New Font("Times New Roman", 12.0F)
        LblStatus.ForeColor = Color.White
        LblStatus.Location = New Point(560, 15)
        LblStatus.Name = "LblStatus"
        LblStatus.Size = New Size(56, 22)
        LblStatus.TabIndex = 2
        LblStatus.Text = "الحالة:"

        ' 
        ' CmbStatus
        ' 
        CmbStatus.BackColor = Color.Transparent
        CmbStatus.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        CmbStatus.BorderRadius = 6
        CmbStatus.CustomizableEdges = CustomizableEdges13
        CmbStatus.DrawMode = DrawMode.OwnerDrawFixed
        CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        CmbStatus.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        CmbStatus.FocusedColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        CmbStatus.FocusedState.BorderColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        CmbStatus.Font = New Font("Segoe UI", 10.0F)
        CmbStatus.ForeColor = Color.White
        CmbStatus.ItemHeight = 30
        CmbStatus.Location = New Point(424, 40)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        CmbStatus.Size = New Size(192, 36)
        CmbStatus.TabIndex = 3

        ' 
        ' TxtSearch
        ' 
        TxtSearch.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        TxtSearch.BorderRadius = 8
        TxtSearch.CustomizableEdges = CustomizableEdges15
        TxtSearch.DefaultText = ""
        TxtSearch.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        TxtSearch.Font = New Font("Segoe UI", 10.0F)
        TxtSearch.ForeColor = Color.White
        TxtSearch.Location = New Point(12, 40)
        TxtSearch.Margin = New Padding(4, 5, 4, 5)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.PlaceholderForeColor = Color.Gray
        TxtSearch.PlaceholderText = "بحث (ملاحظة/حالة)"
        TxtSearch.RightToLeft = RightToLeft.Yes
        TxtSearch.SelectedText = ""
        TxtSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        TxtSearch.Size = New Size(392, 40)
        TxtSearch.TabIndex = 4

        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.Animated = True
        BtnRefresh.BorderRadius = 10
        BtnRefresh.FillColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnRefresh.Font = New Font("Times New Roman", 13.8F)
        BtnRefresh.ForeColor = Color.White
        BtnRefresh.Location = New Point(635, 40)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(110, 40)
        BtnRefresh.TabIndex = 5
        BtnRefresh.Text = "تحديث"

        ' 
        ' PnlGrid
        ' 
        PnlGrid.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        PnlGrid.BorderRadius = 14
        PnlGrid.BorderThickness = 1
        PnlGrid.Controls.Add(GridApps)
        PnlGrid.CustomizableEdges = CustomizableEdges9
        PnlGrid.Dock = DockStyle.Fill
        PnlGrid.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        PnlGrid.Location = New Point(12, 108)
        PnlGrid.Name = "PnlGrid"
        PnlGrid.Padding = New Padding(12)
        PnlGrid.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        PnlGrid.Size = New Size(1076, 516)
        PnlGrid.TabIndex = 1

        ' 
        ' GridApps
        ' 
        GridApps.AllowUserToAddRows = False
        GridApps.AllowUserToDeleteRows = False
        GridApps.AllowUserToResizeRows = False
        GridApps.AutoGenerateColumns = False
        GridApps.BackgroundColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        GridApps.BorderStyle = BorderStyle.None
        GridApps.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        GridApps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        DataGridViewCellStyle1.ForeColor = Color.White
        GridApps.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1

        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        GridApps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        GridApps.ColumnHeadersHeight = 40

        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(12), CByte(24), CByte(80))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        GridApps.DefaultCellStyle = DataGridViewCellStyle3

        GridApps.Dock = DockStyle.Fill
        GridApps.GridColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        GridApps.Location = New Point(12, 12)
        GridApps.MultiSelect = False
        GridApps.Name = "GridApps"
        GridApps.ReadOnly = True
        GridApps.RowHeadersVisible = False
        GridApps.RowTemplate.Height = 36
        GridApps.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GridApps.Size = New Size(1052, 492)
        GridApps.TabIndex = 0

        ' Columns
        ColId.DataPropertyName = "AppointmentID"
        ColId.HeaderText = "ID"
        ColId.Name = "ColId"
        ColId.Visible = False

        ColDate.DataPropertyName = "AppointmentDate"
        ColDate.HeaderText = "التاريخ"
        ColDate.Name = "ColDate"
        ColDate.Width = 120

        ColStart.DataPropertyName = "StartTime"
        ColStart.HeaderText = "من"
        ColStart.Name = "ColStart"
        ColStart.Width = 80

        ColEnd.DataPropertyName = "EndTime"
        ColEnd.HeaderText = "إلى"
        ColEnd.Name = "ColEnd"
        ColEnd.Width = 80

        ColStatus.DataPropertyName = "Status"
        ColStatus.HeaderText = "الحالة"
        ColStatus.Name = "ColStatus"
        ColStatus.Width = 110

        ColNotes.DataPropertyName = "Notes"
        ColNotes.HeaderText = "ملاحظات"
        ColNotes.Name = "ColNotes"
        ColNotes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        GridApps.Columns.AddRange(New DataGridViewColumn() {ColId, ColDate, ColStart, ColEnd, ColStatus, ColNotes})

        ' 
        ' frmTabletrainer
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        ClientSize = New Size(1100, 700)
        Controls.Add(PnlBody)
        Controls.Add(PnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmTabletrainer"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "جدول مواعيدي"
        WindowState = FormWindowState.Normal

        PnlHeader.ResumeLayout(False)
        PnlBody.ResumeLayout(False)
        PnlFilters.ResumeLayout(False)
        PnlFilters.PerformLayout()
        PnlGrid.ResumeLayout(False)
        CType(GridApps, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CbMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents CbClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents DragHeader As Guna.UI2.WinForms.Guna2DragControl

    Friend WithEvents PnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlFilters As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblDate As Label
    Friend WithEvents DtpDay As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents LblStatus As Label
    Friend WithEvents CmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnRefresh As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents PnlGrid As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GridApps As Guna.UI2.WinForms.Guna2DataGridView

    Friend WithEvents ColId As DataGridViewTextBoxColumn
    Friend WithEvents ColDate As DataGridViewTextBoxColumn
    Friend WithEvents ColStart As DataGridViewTextBoxColumn
    Friend WithEvents ColEnd As DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As DataGridViewTextBoxColumn
    Friend WithEvents ColNotes As DataGridViewTextBoxColumn

End Class
