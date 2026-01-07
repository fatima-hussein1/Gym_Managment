<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainDite
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        MenuStrip1 = New MenuStrip()
        TsmProfile = New ToolStripMenuItem()
        TsmPlans = New ToolStripMenuItem()
        TsmConsultations = New ToolStripMenuItem()
        TsmPlanDetails = New ToolStripMenuItem()
        CbMin = New Guna.UI2.WinForms.Guna2ControlBox()
        CbClose = New Guna.UI2.WinForms.Guna2ControlBox()
        DragHeader = New Guna.UI2.WinForms.Guna2DragControl(components)
        PnlBody = New Guna.UI2.WinForms.Guna2Panel()
        PnlStats = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CardPlans = New Guna.UI2.WinForms.Guna2Panel()
        CardConsultations = New Guna.UI2.WinForms.Guna2Panel()
        CardMembers = New Guna.UI2.WinForms.Guna2Panel()
        LblPlansTitle = New Label()
        LblPlansCount = New Label()
        LblConsultationsTitle = New Label()
        LblConsultationsCount = New Label()
        LblMembersTitle = New Label()
        LblMembersCount = New Label()
        TSMReport = New ToolStripMenuItem()
        PnlHeader.SuspendLayout()
        MenuStrip1.SuspendLayout()
        PnlBody.SuspendLayout()
        PnlStats.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlHeader
        ' 
        PnlHeader.Controls.Add(MenuStrip1)
        PnlHeader.Controls.Add(CbMin)
        PnlHeader.Controls.Add(CbClose)
        PnlHeader.CustomizableEdges = CustomizableEdges5
        PnlHeader.Dock = DockStyle.Top
        PnlHeader.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        PnlHeader.Location = New Point(0, 0)
        PnlHeader.Name = "PnlHeader"
        PnlHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        PnlHeader.Size = New Size(1200, 50)
        PnlHeader.TabIndex = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.AutoSize = False
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        MenuStrip1.Font = New Font("Microsoft Sans Serif", 12.0F)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TsmProfile, TsmPlans, TsmConsultations, TsmPlanDetails, TSMReport})
        MenuStrip1.Location = New Point(96, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.RightToLeft = RightToLeft.Yes
        MenuStrip1.Size = New Size(1104, 43)
        MenuStrip1.TabIndex = 0
        ' 
        ' TsmProfile
        ' 
        TsmProfile.Font = New Font("Times New Roman", 12.0F)
        TsmProfile.ForeColor = Color.White
        TsmProfile.Name = "TsmProfile"
        TsmProfile.Size = New Size(124, 39)
        TsmProfile.Text = "الملف الشخصي"
        ' 
        ' TsmPlans
        ' 
        TsmPlans.Font = New Font("Times New Roman", 12.0F)
        TsmPlans.ForeColor = Color.White
        TsmPlans.Name = "TsmPlans"
        TsmPlans.Size = New Size(105, 39)
        TsmPlans.Text = "خطط التغذية"
        ' 
        ' TsmConsultations
        ' 
        TsmConsultations.Font = New Font("Times New Roman", 12.0F)
        TsmConsultations.ForeColor = Color.White
        TsmConsultations.Name = "TsmConsultations"
        TsmConsultations.Size = New Size(149, 39)
        TsmConsultations.Text = "استشارات الأعضاء"
        ' 
        ' TsmPlanDetails
        ' 
        TsmPlanDetails.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TsmPlanDetails.ForeColor = Color.White
        TsmPlanDetails.Name = "TsmPlanDetails"
        TsmPlanDetails.Size = New Size(153, 39)
        TsmPlanDetails.Text = "تفاصيل خطة التغذية"
        ' 
        ' CbMin
        ' 
        CbMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        CbMin.CustomizableEdges = CustomizableEdges1
        CbMin.Dock = DockStyle.Left
        CbMin.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        CbMin.IconColor = Color.White
        CbMin.Location = New Point(48, 0)
        CbMin.Name = "CbMin"
        CbMin.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        CbMin.Size = New Size(48, 50)
        CbMin.TabIndex = 1
        ' 
        ' CbClose
        ' 
        CbClose.CustomizableEdges = CustomizableEdges3
        CbClose.Dock = DockStyle.Left
        CbClose.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        CbClose.HoverState.FillColor = Color.Red
        CbClose.IconColor = Color.White
        CbClose.Location = New Point(0, 0)
        CbClose.Name = "CbClose"
        CbClose.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        CbClose.Size = New Size(48, 50)
        CbClose.TabIndex = 2
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
        PnlBody.CustomizableEdges = CustomizableEdges17
        PnlBody.Dock = DockStyle.Fill
        PnlBody.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        PnlBody.Location = New Point(0, 50)
        PnlBody.Name = "PnlBody"
        PnlBody.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        PnlBody.Size = New Size(1200, 670)
        PnlBody.TabIndex = 0
        ' 
        ' PnlStats
        ' 
        PnlStats.Controls.Add(Guna2Panel1)
        PnlStats.Controls.Add(CardPlans)
        PnlStats.Controls.Add(CardConsultations)
        PnlStats.Controls.Add(CardMembers)
        PnlStats.CustomizableEdges = CustomizableEdges15
        PnlStats.Dock = DockStyle.Fill
        PnlStats.FillColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        PnlStats.Location = New Point(0, 0)
        PnlStats.Name = "PnlStats"
        PnlStats.Padding = New Padding(24)
        PnlStats.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        PnlStats.Size = New Size(1200, 670)
        PnlStats.TabIndex = 0
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.Location = New Point(888, 45)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(285, 548)
        Guna2Panel1.TabIndex = 3
        ' 
        ' CardPlans
        ' 
        CardPlans.CustomizableEdges = CustomizableEdges9
        CardPlans.Location = New Point(96, 114)
        CardPlans.Name = "CardPlans"
        CardPlans.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        CardPlans.Size = New Size(200, 100)
        CardPlans.TabIndex = 0
        ' 
        ' CardConsultations
        ' 
        CardConsultations.CustomizableEdges = CustomizableEdges11
        CardConsultations.Location = New Point(58, 350)
        CardConsultations.Name = "CardConsultations"
        CardConsultations.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        CardConsultations.Size = New Size(200, 100)
        CardConsultations.TabIndex = 1
        ' 
        ' CardMembers
        ' 
        CardMembers.CustomizableEdges = CustomizableEdges13
        CardMembers.Location = New Point(90, 220)
        CardMembers.Name = "CardMembers"
        CardMembers.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        CardMembers.Size = New Size(200, 100)
        CardMembers.TabIndex = 2
        ' 
        ' LblPlansTitle
        ' 
        LblPlansTitle.Location = New Point(0, 0)
        LblPlansTitle.Name = "LblPlansTitle"
        LblPlansTitle.Size = New Size(100, 23)
        LblPlansTitle.TabIndex = 0
        ' 
        ' LblPlansCount
        ' 
        LblPlansCount.Location = New Point(0, 0)
        LblPlansCount.Name = "LblPlansCount"
        LblPlansCount.Size = New Size(100, 23)
        LblPlansCount.TabIndex = 0
        ' 
        ' LblConsultationsTitle
        ' 
        LblConsultationsTitle.Location = New Point(0, 0)
        LblConsultationsTitle.Name = "LblConsultationsTitle"
        LblConsultationsTitle.Size = New Size(100, 23)
        LblConsultationsTitle.TabIndex = 0
        ' 
        ' LblConsultationsCount
        ' 
        LblConsultationsCount.Location = New Point(0, 0)
        LblConsultationsCount.Name = "LblConsultationsCount"
        LblConsultationsCount.Size = New Size(100, 23)
        LblConsultationsCount.TabIndex = 0
        ' 
        ' LblMembersTitle
        ' 
        LblMembersTitle.Location = New Point(0, 0)
        LblMembersTitle.Name = "LblMembersTitle"
        LblMembersTitle.Size = New Size(100, 23)
        LblMembersTitle.TabIndex = 0
        ' 
        ' LblMembersCount
        ' 
        LblMembersCount.Location = New Point(0, 0)
        LblMembersCount.Name = "LblMembersCount"
        LblMembersCount.Size = New Size(100, 23)
        LblMembersCount.TabIndex = 0
        ' 
        ' TSMReport
        ' 
        TSMReport.Name = "TSMReport"
        TSMReport.Size = New Size(74, 39)
        TSMReport.Text = "التقارير"
        ' 
        ' FrmMainDite
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(16), CByte(60))
        ClientSize = New Size(1200, 720)
        Controls.Add(PnlBody)
        Controls.Add(PnlHeader)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmMainDite"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "لوحة أخصائي التغذية"
        PnlHeader.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        PnlBody.ResumeLayout(False)
        PnlStats.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private Sub SetupCard(card As Guna.UI2.WinForms.Guna2Panel, title As Label, cnt As Label, titleText As String, accent As Color)
        card.BorderColor = accent
        card.BorderRadius = 14
        card.BorderThickness = 1
        card.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        card.Padding = New Padding(12)
        card.Size = New Size(300, 110)

        title.Dock = DockStyle.Top
        title.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        title.ForeColor = accent
        title.Height = 28
        title.Text = titleText
        title.TextAlign = ContentAlignment.MiddleCenter

        cnt.Dock = DockStyle.Fill
        cnt.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        cnt.ForeColor = Color.White
        cnt.Text = "0"
        cnt.TextAlign = ContentAlignment.MiddleCenter

        card.Controls.Add(cnt)
        card.Controls.Add(title)
    End Sub

    Friend WithEvents PnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TsmProfile As ToolStripMenuItem
    Friend WithEvents TsmPlans As ToolStripMenuItem
    Friend WithEvents TsmConsultations As ToolStripMenuItem
    Friend WithEvents CbMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents CbClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DragHeader As Guna.UI2.WinForms.Guna2DragControl

    Friend WithEvents PnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlStats As Guna.UI2.WinForms.Guna2Panel

    Friend WithEvents CardPlans As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblPlansTitle As Label
    Friend WithEvents LblPlansCount As Label

    Friend WithEvents CardConsultations As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblConsultationsTitle As Label
    Friend WithEvents LblConsultationsCount As Label

    Friend WithEvents CardMembers As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblMembersTitle As Label
    Friend WithEvents LblMembersCount As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TsmPlanDetails As ToolStripMenuItem
    Friend WithEvents TSMReport As ToolStripMenuItem
End Class
