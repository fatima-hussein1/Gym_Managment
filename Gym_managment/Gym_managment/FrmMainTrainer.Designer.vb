<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainTrainer
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        MenuStrip1 = New MenuStrip()
        TSMProfile = New ToolStripMenuItem()
        TSMManageTrainer = New ToolStripMenuItem()
        TSMTable = New ToolStripMenuItem()
        CbMin = New Guna.UI2.WinForms.Guna2ControlBox()
        CbClose = New Guna.UI2.WinForms.Guna2ControlBox()
        DragHeader = New Guna.UI2.WinForms.Guna2DragControl(components)
        PnlBody = New Guna.UI2.WinForms.Guna2Panel()
        PnlStats = New Guna.UI2.WinForms.Guna2Panel()
        CardExpiring = New Guna.UI2.WinForms.Guna2Panel()
        LblExpiringCount = New Label()
        LblExpiringTitle = New Label()
        CardToday = New Guna.UI2.WinForms.Guna2Panel()
        LblTodayCount = New Label()
        LblTodayTitle = New Label()
        CardMembers = New Guna.UI2.WinForms.Guna2Panel()
        LblMembersCount = New Label()
        LblMembersTitle = New Label()
        MnuMembers = New ToolStripMenuItem()
        MnuAppointments = New ToolStripMenuItem()
        MnuProfile = New ToolStripMenuItem()
        PnlHeader.SuspendLayout()
        MenuStrip1.SuspendLayout()
        PnlBody.SuspendLayout()
        PnlStats.SuspendLayout()
        CardExpiring.SuspendLayout()
        CardToday.SuspendLayout()
        CardMembers.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlHeader
        ' 
        PnlHeader.Controls.Add(MenuStrip1)
        PnlHeader.Controls.Add(CbMin)
        PnlHeader.Controls.Add(CbClose)
        PnlHeader.CustomizableEdges = CustomizableEdges5
        PnlHeader.Dock = DockStyle.Top
        PnlHeader.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        PnlHeader.Location = New Point(0, 0)
        PnlHeader.Name = "PnlHeader"
        PnlHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        PnlHeader.Size = New Size(1200, 50)
        PnlHeader.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.AutoSize = False
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        MenuStrip1.Font = New Font("Microsoft Sans Serif", 12.0F)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TSMProfile, TSMManageTrainer, TSMTable})
        MenuStrip1.Location = New Point(96, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.RightToLeft = RightToLeft.Yes
        MenuStrip1.Size = New Size(1104, 43)
        MenuStrip1.TabIndex = 31
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TSMProfile
        ' 
        TSMProfile.Font = New Font("Times New Roman", 12.0F)
        TSMProfile.ForeColor = Color.White
        TSMProfile.Image = My.Resources.Resources.icons8_users_47
        TSMProfile.Name = "TSMProfile"
        TSMProfile.Size = New Size(144, 39)
        TSMProfile.Text = "الملف الشخصي"
        ' 
        ' TSMManageTrainer
        ' 
        TSMManageTrainer.Font = New Font("Times New Roman", 12.0F)
        TSMManageTrainer.ForeColor = Color.White
        TSMManageTrainer.Name = "TSMManageTrainer"
        TSMManageTrainer.Size = New Size(119, 39)
        TSMManageTrainer.Text = "إدارة المتدربين"
        ' 
        ' TSMTable
        ' 
        TSMTable.Font = New Font("Times New Roman", 12.0F)
        TSMTable.ForeColor = Color.White
        TSMTable.Name = "TSMTable"
        TSMTable.Size = New Size(182, 39)
        TSMTable.Text = "جدول الحصص التدريبية"
        ' 
        ' CbMin
        ' 
        CbMin.BackColor = Color.FromArgb(CByte(57), CByte(0), CByte(148))
        CbMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        CbMin.CustomizableEdges = CustomizableEdges1
        CbMin.Dock = DockStyle.Left
        CbMin.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        CbMin.IconColor = Color.White
        CbMin.Location = New Point(48, 0)
        CbMin.Name = "CbMin"
        CbMin.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        CbMin.Size = New Size(48, 50)
        CbMin.TabIndex = 2
        ' 
        ' CbClose
        ' 
        CbClose.BackColor = Color.FromArgb(CByte(57), CByte(0), CByte(148))
        CbClose.CustomizableEdges = CustomizableEdges3
        CbClose.Dock = DockStyle.Left
        CbClose.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        CbClose.HoverState.FillColor = Color.Red
        CbClose.IconColor = Color.White
        CbClose.Location = New Point(0, 0)
        CbClose.Name = "CbClose"
        CbClose.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        CbClose.Size = New Size(48, 50)
        CbClose.TabIndex = 1
        ' 
        ' DragHeader
        ' 
        DragHeader.ContainerControl = Me
        DragHeader.DockIndicatorTransparencyValue = 0.6R
        DragHeader.TargetControl = PnlHeader
        DragHeader.UseTransparentDrag = True
        ' 
        ' PnlBody
        ' 
        PnlBody.Controls.Add(PnlStats)
        PnlBody.CustomizableEdges = CustomizableEdges15
        PnlBody.Dock = DockStyle.Fill
        PnlBody.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        PnlBody.Location = New Point(0, 50)
        PnlBody.Name = "PnlBody"
        PnlBody.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        PnlBody.Size = New Size(1200, 670)
        PnlBody.TabIndex = 1
        ' 
        ' PnlStats
        ' 
        PnlStats.Controls.Add(CardExpiring)
        PnlStats.Controls.Add(CardToday)
        PnlStats.Controls.Add(CardMembers)
        PnlStats.CustomizableEdges = CustomizableEdges13
        PnlStats.Dock = DockStyle.Fill
        PnlStats.FillColor = Color.Transparent
        PnlStats.Location = New Point(0, 0)
        PnlStats.Name = "PnlStats"
        PnlStats.Padding = New Padding(12)
        PnlStats.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        PnlStats.Size = New Size(1200, 670)
        PnlStats.TabIndex = 0
        ' 
        ' CardExpiring
        ' 
        CardExpiring.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        CardExpiring.BorderRadius = 14
        CardExpiring.BorderThickness = 1
        CardExpiring.Controls.Add(LblExpiringCount)
        CardExpiring.Controls.Add(LblExpiringTitle)
        CardExpiring.CustomizableEdges = CustomizableEdges7
        CardExpiring.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        CardExpiring.Location = New Point(96, 274)
        CardExpiring.Name = "CardExpiring"
        CardExpiring.Padding = New Padding(12)
        CardExpiring.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        CardExpiring.Size = New Size(240, 88)
        CardExpiring.TabIndex = 2
        ' 
        ' LblExpiringCount
        ' 
        LblExpiringCount.Dock = DockStyle.Fill
        LblExpiringCount.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        LblExpiringCount.ForeColor = Color.White
        LblExpiringCount.Location = New Point(12, 36)
        LblExpiringCount.Name = "LblExpiringCount"
        LblExpiringCount.Size = New Size(216, 40)
        LblExpiringCount.TabIndex = 1
        LblExpiringCount.Text = "0"
        LblExpiringCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblExpiringTitle
        ' 
        LblExpiringTitle.Dock = DockStyle.Top
        LblExpiringTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblExpiringTitle.ForeColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        LblExpiringTitle.Location = New Point(12, 12)
        LblExpiringTitle.Name = "LblExpiringTitle"
        LblExpiringTitle.Size = New Size(216, 24)
        LblExpiringTitle.TabIndex = 0
        LblExpiringTitle.Text = "تنتهي قريباً"
        LblExpiringTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CardToday
        ' 
        CardToday.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        CardToday.BorderRadius = 14
        CardToday.BorderThickness = 1
        CardToday.Controls.Add(LblTodayCount)
        CardToday.Controls.Add(LblTodayTitle)
        CardToday.CustomizableEdges = CustomizableEdges9
        CardToday.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        CardToday.Location = New Point(712, 274)
        CardToday.Name = "CardToday"
        CardToday.Padding = New Padding(12)
        CardToday.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        CardToday.Size = New Size(240, 88)
        CardToday.TabIndex = 1
        ' 
        ' LblTodayCount
        ' 
        LblTodayCount.Dock = DockStyle.Fill
        LblTodayCount.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        LblTodayCount.ForeColor = Color.White
        LblTodayCount.Location = New Point(12, 36)
        LblTodayCount.Name = "LblTodayCount"
        LblTodayCount.Size = New Size(216, 40)
        LblTodayCount.TabIndex = 1
        LblTodayCount.Text = "0"
        LblTodayCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTodayTitle
        ' 
        LblTodayTitle.Dock = DockStyle.Top
        LblTodayTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblTodayTitle.ForeColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        LblTodayTitle.Location = New Point(12, 12)
        LblTodayTitle.Name = "LblTodayTitle"
        LblTodayTitle.Size = New Size(216, 24)
        LblTodayTitle.TabIndex = 0
        LblTodayTitle.Text = "مواعيد اليوم"
        LblTodayTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CardMembers
        ' 
        CardMembers.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        CardMembers.BorderRadius = 14
        CardMembers.BorderThickness = 1
        CardMembers.Controls.Add(LblMembersCount)
        CardMembers.Controls.Add(LblMembersTitle)
        CardMembers.CustomizableEdges = CustomizableEdges11
        CardMembers.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        CardMembers.Location = New Point(415, 274)
        CardMembers.Name = "CardMembers"
        CardMembers.Padding = New Padding(12)
        CardMembers.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        CardMembers.Size = New Size(240, 88)
        CardMembers.TabIndex = 0
        ' 
        ' LblMembersCount
        ' 
        LblMembersCount.Dock = DockStyle.Fill
        LblMembersCount.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        LblMembersCount.ForeColor = Color.White
        LblMembersCount.Location = New Point(12, 36)
        LblMembersCount.Name = "LblMembersCount"
        LblMembersCount.Size = New Size(216, 40)
        LblMembersCount.TabIndex = 1
        LblMembersCount.Text = "0"
        LblMembersCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblMembersTitle
        ' 
        LblMembersTitle.Dock = DockStyle.Top
        LblMembersTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblMembersTitle.ForeColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        LblMembersTitle.Location = New Point(12, 12)
        LblMembersTitle.Name = "LblMembersTitle"
        LblMembersTitle.Size = New Size(216, 24)
        LblMembersTitle.TabIndex = 0
        LblMembersTitle.Text = "أعضائي"
        LblMembersTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MnuMembers
        ' 
        MnuMembers.Name = "MnuMembers"
        MnuMembers.Size = New Size(80, 24)
        MnuMembers.Text = "أعضاء مسجلون"
        ' 
        ' MnuAppointments
        ' 
        MnuAppointments.Name = "MnuAppointments"
        MnuAppointments.Size = New Size(86, 24)
        MnuAppointments.Text = "جدولي التدريبي"
        ' 
        ' MnuProfile
        ' 
        MnuProfile.Name = "MnuProfile"
        MnuProfile.Size = New Size(118, 24)
        MnuProfile.Text = "الملف الشخصي"
        ' 
        ' FrmMainTrainer
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        ClientSize = New Size(1200, 720)
        Controls.Add(PnlBody)
        Controls.Add(PnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmMainTrainer"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "لوحة المدرب"
        PnlHeader.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        PnlBody.ResumeLayout(False)
        PnlStats.ResumeLayout(False)
        CardExpiring.ResumeLayout(False)
        CardToday.ResumeLayout(False)
        CardMembers.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CbMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents CbClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DragHeader As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents PnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlStats As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CardMembers As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblMembersCount As Label
    Friend WithEvents LblMembersTitle As Label
    Friend WithEvents CardToday As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblTodayCount As Label
    Friend WithEvents LblTodayTitle As Label
    Friend WithEvents CardExpiring As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblExpiringCount As Label
    Friend WithEvents LblExpiringTitle As Label
    Friend WithEvents MnuMembers As ToolStripMenuItem
    Friend WithEvents MnuAppointments As ToolStripMenuItem
    Friend WithEvents MnuProfile As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TSMProfile As ToolStripMenuItem
    Friend WithEvents TSMManageTrainer As ToolStripMenuItem
    Friend WithEvents TSMTable As ToolStripMenuItem
End Class
