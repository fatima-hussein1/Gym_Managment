<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDisplayAppointment
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PanelTop = New Guna.UI2.WinForms.Guna2Panel()
        ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Sidebar = New Guna.UI2.WinForms.Guna2Panel()
        flAppointments = New FlowLayoutPanel()
        BtnAddAppointment = New Guna.UI2.WinForms.Guna2Button()
        LblSelectedDate = New Label()
        PanelHeader = New Guna.UI2.WinForms.Guna2Panel()
        lblMonthAndYear = New Label()
        btnPrevMonth = New Guna.UI2.WinForms.Guna2Button()
        btnNextMonth = New Guna.UI2.WinForms.Guna2Button()
        PanelDaysHeader = New Guna.UI2.WinForms.Guna2Panel()
        LblTue = New Label()
        LblMon = New Label()
        LblSat = New Label()
        LblSun = New Label()
        LblWed = New Label()
        LblThu = New Label()
        LblFri = New Label()
        flDays = New FlowLayoutPanel()
        PanelTop.SuspendLayout()
        Sidebar.SuspendLayout()
        PanelHeader.SuspendLayout()
        PanelDaysHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTop
        ' 
        PanelTop.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        PanelTop.Controls.Add(ControlBoxMin)
        PanelTop.Controls.Add(ControlBoxClose)
        PanelTop.CustomizableEdges = CustomizableEdges5
        PanelTop.Dock = DockStyle.Top
        PanelTop.Location = New Point(0, 0)
        PanelTop.Name = "PanelTop"
        PanelTop.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        PanelTop.Size = New Size(1078, 42)
        PanelTop.TabIndex = 100
        ' 
        ' ControlBoxMin
        ' 
        ControlBoxMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        ControlBoxMin.CustomizableEdges = CustomizableEdges1
        ControlBoxMin.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        ControlBoxMin.IconColor = Color.White
        ControlBoxMin.Location = New Point(39, 6)
        ControlBoxMin.Name = "ControlBoxMin"
        ControlBoxMin.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ControlBoxMin.Size = New Size(45, 30)
        ControlBoxMin.TabIndex = 1
        ' 
        ' ControlBoxClose
        ' 
        ControlBoxClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ControlBoxClose.CustomizableEdges = CustomizableEdges3
        ControlBoxClose.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        ControlBoxClose.HoverState.FillColor = Color.Red
        ControlBoxClose.IconColor = Color.White
        ControlBoxClose.Location = New Point(-12, 6)
        ControlBoxClose.Name = "ControlBoxClose"
        ControlBoxClose.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        ControlBoxClose.Size = New Size(45, 30)
        ControlBoxClose.TabIndex = 0
        ' 
        ' Sidebar
        ' 
        Sidebar.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        Sidebar.BorderThickness = 1
        Sidebar.Controls.Add(flAppointments)
        Sidebar.Controls.Add(BtnAddAppointment)
        Sidebar.Controls.Add(LblSelectedDate)
        Sidebar.CustomizableEdges = CustomizableEdges9
        Sidebar.Dock = DockStyle.Left
        Sidebar.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        Sidebar.Location = New Point(0, 42)
        Sidebar.Name = "Sidebar"
        Sidebar.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Sidebar.Size = New Size(276, 877)
        Sidebar.TabIndex = 0
        ' 
        ' flAppointments
        ' 
        flAppointments.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        flAppointments.AutoScroll = True
        flAppointments.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        flAppointments.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        flAppointments.Location = New Point(3, 290)
        flAppointments.Name = "flAppointments"
        flAppointments.Size = New Size(267, 563)
        flAppointments.TabIndex = 0
        ' 
        ' BtnAddAppointment
        ' 
        BtnAddAppointment.Animated = True
        BtnAddAppointment.BorderRadius = 10
        BtnAddAppointment.CustomizableEdges = CustomizableEdges7
        BtnAddAppointment.FillColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnAddAppointment.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnAddAppointment.ForeColor = Color.White
        BtnAddAppointment.Location = New Point(28, 229)
        BtnAddAppointment.Name = "BtnAddAppointment"
        BtnAddAppointment.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        BtnAddAppointment.Size = New Size(226, 40)
        BtnAddAppointment.TabIndex = 1
        BtnAddAppointment.Text = "حجز موعد"
        ' 
        ' LblSelectedDate
        ' 
        LblSelectedDate.Font = New Font("Times New Roman", 12.0F)
        LblSelectedDate.ForeColor = Color.White
        LblSelectedDate.Location = New Point(12, 165)
        LblSelectedDate.Name = "LblSelectedDate"
        LblSelectedDate.Size = New Size(256, 30)
        LblSelectedDate.TabIndex = 2
        LblSelectedDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        PanelHeader.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        PanelHeader.BorderThickness = 1
        PanelHeader.Controls.Add(lblMonthAndYear)
        PanelHeader.Controls.Add(btnPrevMonth)
        PanelHeader.Controls.Add(btnNextMonth)
        PanelHeader.CustomizableEdges = CustomizableEdges15
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(276, 42)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        PanelHeader.Size = New Size(802, 80)
        PanelHeader.TabIndex = 2
        ' 
        ' lblMonthAndYear
        ' 
        lblMonthAndYear.AutoSize = True
        lblMonthAndYear.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblMonthAndYear.ForeColor = Color.White
        lblMonthAndYear.Location = New Point(20, 20)
        lblMonthAndYear.Name = "lblMonthAndYear"
        lblMonthAndYear.Size = New Size(0, 41)
        lblMonthAndYear.TabIndex = 0
        ' 
        ' btnPrevMonth
        ' 
        btnPrevMonth.Animated = True
        btnPrevMonth.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        btnPrevMonth.BorderRadius = 10
        btnPrevMonth.BorderThickness = 2
        btnPrevMonth.CustomizableEdges = CustomizableEdges11
        btnPrevMonth.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        btnPrevMonth.Font = New Font("Segoe UI", 9.0F)
        btnPrevMonth.ForeColor = Color.White
        btnPrevMonth.Location = New Point(600, 18)
        btnPrevMonth.Name = "btnPrevMonth"
        btnPrevMonth.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnPrevMonth.Size = New Size(45, 45)
        btnPrevMonth.TabIndex = 1
        btnPrevMonth.Text = "<"
        ' 
        ' btnNextMonth
        ' 
        btnNextMonth.Animated = True
        btnNextMonth.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        btnNextMonth.BorderRadius = 10
        btnNextMonth.BorderThickness = 2
        btnNextMonth.CustomizableEdges = CustomizableEdges13
        btnNextMonth.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        btnNextMonth.Font = New Font("Segoe UI", 9.0F)
        btnNextMonth.ForeColor = Color.White
        btnNextMonth.Location = New Point(660, 18)
        btnNextMonth.Name = "btnNextMonth"
        btnNextMonth.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnNextMonth.Size = New Size(45, 45)
        btnNextMonth.TabIndex = 2
        btnNextMonth.Text = ">"
        ' 
        ' PanelDaysHeader
        ' 
        PanelDaysHeader.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        PanelDaysHeader.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        PanelDaysHeader.BorderThickness = 1
        PanelDaysHeader.Controls.Add(LblTue)
        PanelDaysHeader.Controls.Add(LblMon)
        PanelDaysHeader.Controls.Add(LblSat)
        PanelDaysHeader.Controls.Add(LblSun)
        PanelDaysHeader.Controls.Add(LblWed)
        PanelDaysHeader.Controls.Add(LblThu)
        PanelDaysHeader.Controls.Add(LblFri)
        PanelDaysHeader.CustomizableEdges = CustomizableEdges17
        PanelDaysHeader.Dock = DockStyle.Top
        PanelDaysHeader.Location = New Point(276, 122)
        PanelDaysHeader.Name = "PanelDaysHeader"
        PanelDaysHeader.RightToLeft = RightToLeft.No
        PanelDaysHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        PanelDaysHeader.Size = New Size(802, 40)
        PanelDaysHeader.TabIndex = 1
        ' 
        ' LblTue
        ' 
        LblTue.BackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        LblTue.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold)
        LblTue.ForeColor = Color.White
        LblTue.Location = New Point(340, 3)
        LblTue.Name = "LblTue"
        LblTue.Size = New Size(120, 34)
        LblTue.TabIndex = 3
        LblTue.Text = "الثلاثاء"
        LblTue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblMon
        ' 
        LblMon.BackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        LblMon.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold)
        LblMon.ForeColor = Color.White
        LblMon.Location = New Point(456, 3)
        LblMon.Name = "LblMon"
        LblMon.Size = New Size(118, 34)
        LblMon.TabIndex = 2
        LblMon.Text = "الإثنين"
        LblMon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblSat
        ' 
        LblSat.BackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        LblSat.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold)
        LblSat.ForeColor = Color.White
        LblSat.Location = New Point(688, 3)
        LblSat.Name = "LblSat"
        LblSat.Size = New Size(110, 34)
        LblSat.TabIndex = 0
        LblSat.Text = "السبت"
        LblSat.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblSun
        ' 
        LblSun.BackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        LblSun.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold)
        LblSun.ForeColor = Color.White
        LblSun.Location = New Point(572, 3)
        LblSun.Name = "LblSun"
        LblSun.Size = New Size(119, 34)
        LblSun.TabIndex = 1
        LblSun.Text = "الأحد"
        LblSun.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblWed
        ' 
        LblWed.BackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        LblWed.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold)
        LblWed.ForeColor = Color.White
        LblWed.Location = New Point(224, 3)
        LblWed.Name = "LblWed"
        LblWed.Size = New Size(118, 34)
        LblWed.TabIndex = 4
        LblWed.Text = "الأربعاء"
        LblWed.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblThu
        ' 
        LblThu.BackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        LblThu.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold)
        LblThu.ForeColor = Color.White
        LblThu.Location = New Point(108, 3)
        LblThu.Name = "LblThu"
        LblThu.Size = New Size(118, 34)
        LblThu.TabIndex = 5
        LblThu.Text = "الخميس"
        LblThu.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblFri
        ' 
        LblFri.BackColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        LblFri.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold)
        LblFri.ForeColor = Color.White
        LblFri.Location = New Point(4, 3)
        LblFri.Name = "LblFri"
        LblFri.Size = New Size(105, 34)
        LblFri.TabIndex = 6
        LblFri.Text = "الجمعة"
        LblFri.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' flDays
        ' 
        flDays.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        flDays.Dock = DockStyle.Fill
        flDays.Location = New Point(276, 162)
        flDays.Name = "flDays"
        flDays.RightToLeft = RightToLeft.Yes
        flDays.Size = New Size(802, 757)
        flDays.TabIndex = 0
        ' 
        ' frmDisplayAppointment
        ' 
        BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        ClientSize = New Size(1078, 919)
        Controls.Add(flDays)
        Controls.Add(PanelDaysHeader)
        Controls.Add(PanelHeader)
        Controls.Add(Sidebar)
        Controls.Add(PanelTop)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDisplayAppointment"
        RightToLeft = RightToLeft.Yes
        StartPosition = FormStartPosition.CenterScreen
        PanelTop.ResumeLayout(False)
        Sidebar.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelDaysHeader.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Sidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblSelectedDate As Label
    Friend WithEvents flAppointments As FlowLayoutPanel
    Friend WithEvents BtnAddAppointment As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents PanelHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblMonthAndYear As Label
    Friend WithEvents btnPrevMonth As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNextMonth As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents PanelDaysHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblSat As Label
    Friend WithEvents LblSun As Label
    Friend WithEvents LblMon As Label
    Friend WithEvents LblTue As Label
    Friend WithEvents LblWed As Label
    Friend WithEvents LblThu As Label
    Friend WithEvents LblFri As Label

    Friend WithEvents flDays As FlowLayoutPanel
End Class
