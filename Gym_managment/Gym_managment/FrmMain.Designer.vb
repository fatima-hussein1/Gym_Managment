<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmMain
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TSLMessage = New ToolStripStatusLabel()
        TSLDateTime = New ToolStripStatusLabel()
        StatusStrip1 = New StatusStrip()
        TSLUserName = New ToolStripStatusLabel()
        Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        BtnTrainingBooking = New Button()
        BtnMemberSubscription = New Button()
        BtnSubscribtion = New Button()
        BtnCautch = New Button()
        BtnCustomer = New Button()
        BtnSubscription = New Button()
        ToolTip1 = New ToolTip(components)
        Timer2 = New Timer(components)
        NotifyIcon1 = New NotifyIcon(components)
        Timer1 = New Timer(components)
        TsmInventory = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        ToolStripSeparator2 = New ToolStripSeparator()
        TsmUserControl = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        TsmMonitor = New ToolStripMenuItem()
        TsmSettings = New ToolStripMenuItem()
        TSMControl = New ToolStripMenuItem()
        TSMChangepassword = New ToolStripMenuItem()
        TsmDeletedElements = New ToolStripMenuItem()
        MenuStrip1 = New MenuStrip()
        المستخدمينToolStripMenuItem = New ToolStripMenuItem()
        الإدارةالماليةToolStripMenuItem = New ToolStripMenuItem()
        TSMTreasury = New ToolStripMenuItem()
        TSMPayment = New ToolStripMenuItem()
        TSMTransctionPayment = New ToolStripMenuItem()
        PnlMain = New Panel()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2PanelTop = New Guna.UI2.WinForms.Guna2Panel()
        Guna2ControlBoxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBoxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ElipseBtnCustomer = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ElipseBtnCautch = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ElipseBtnSubscribtion = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ElipseBtnMemberSubscription = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ElipseBtnTrainingBooking = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ElipseBtnSubscription = New Guna.UI2.WinForms.Guna2Elipse(components)
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        Guna2PanelTop.SuspendLayout()
        SuspendLayout()
        ' 
        ' TSLMessage
        ' 
        TSLMessage.DisplayStyle = ToolStripItemDisplayStyle.Text
        TSLMessage.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        TSLMessage.ForeColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        TSLMessage.Margin = New Padding(100, 3, 0, 2)
        TSLMessage.Name = "TSLMessage"
        TSLMessage.Size = New Size(94, 25)
        TSLMessage.Text = "تأكيد الحفظ"
        TSLMessage.Visible = False
        ' 
        ' TSLDateTime
        ' 
        TSLDateTime.Font = New Font("Microsoft Sans Serif", 11F)
        TSLDateTime.ForeColor = Color.White
        TSLDateTime.Margin = New Padding(10, 3, 50, 2)
        TSLDateTime.Name = "TSLDateTime"
        TSLDateTime.Size = New Size(103, 25)
        TSLDateTime.Text = "الساعة والتاريخ"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = Color.FromArgb(CByte(186), CByte(146), CByte(254))
        StatusStrip1.Font = New Font("Microsoft Sans Serif", 11F)
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {TSLDateTime, TSLUserName, TSLMessage})
        StatusStrip1.Location = New Point(0, 1072)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 19, 0)
        StatusStrip1.Size = New Size(1831, 30)
        StatusStrip1.TabIndex = 33
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' TSLUserName
        ' 
        TSLUserName.Font = New Font("Microsoft Sans Serif", 11F)
        TSLUserName.ForeColor = Color.White
        TSLUserName.Name = "TSLUserName"
        TSLUserName.Size = New Size(112, 24)
        TSLUserName.Text = "مستخدم المنظومة"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        Panel1.Controls.Add(BtnTrainingBooking)
        Panel1.Controls.Add(BtnMemberSubscription)
        Panel1.Controls.Add(BtnSubscribtion)
        Panel1.Controls.Add(BtnCautch)
        Panel1.Controls.Add(BtnCustomer)
        Panel1.Controls.Add(BtnSubscription)
        Panel1.CustomizableEdges = CustomizableEdges17
        Panel1.Location = New Point(3, 65)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Panel1.Size = New Size(314, 1003)
        Panel1.TabIndex = 31
        ' 
        ' BtnTrainingBooking
        ' 
        BtnTrainingBooking.BackColor = Color.Transparent
        BtnTrainingBooking.FlatAppearance.BorderColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnTrainingBooking.FlatAppearance.BorderSize = 2
        BtnTrainingBooking.FlatStyle = FlatStyle.Flat
        BtnTrainingBooking.Font = New Font("Times New Roman", 13.8F)
        BtnTrainingBooking.ForeColor = Color.White
        BtnTrainingBooking.Image = My.Resources.Resources.icons8_schedule_64
        BtnTrainingBooking.ImageAlign = ContentAlignment.MiddleLeft
        BtnTrainingBooking.Location = New Point(17, 412)
        BtnTrainingBooking.Margin = New Padding(3, 4, 3, 4)
        BtnTrainingBooking.Name = "BtnTrainingBooking"
        BtnTrainingBooking.Size = New Size(279, 81)
        BtnTrainingBooking.TabIndex = 5
        BtnTrainingBooking.Text = "جدول مواعيد المدربين"
        BtnTrainingBooking.TextAlign = ContentAlignment.MiddleRight
        BtnTrainingBooking.UseVisualStyleBackColor = False
        ' 
        ' BtnMemberSubscription
        ' 
        BtnMemberSubscription.BackColor = Color.Transparent
        BtnMemberSubscription.FlatAppearance.BorderColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnMemberSubscription.FlatAppearance.BorderSize = 2
        BtnMemberSubscription.FlatStyle = FlatStyle.Flat
        BtnMemberSubscription.Font = New Font("Times New Roman", 13.8F)
        BtnMemberSubscription.ForeColor = Color.White
        BtnMemberSubscription.Image = My.Resources.Resources.icons8_add_member_50
        BtnMemberSubscription.ImageAlign = ContentAlignment.MiddleLeft
        BtnMemberSubscription.Location = New Point(17, 323)
        BtnMemberSubscription.Margin = New Padding(3, 4, 3, 4)
        BtnMemberSubscription.Name = "BtnMemberSubscription"
        BtnMemberSubscription.Size = New Size(279, 81)
        BtnMemberSubscription.TabIndex = 4
        BtnMemberSubscription.Text = "إشتراكات الأعضاء"
        BtnMemberSubscription.TextAlign = ContentAlignment.MiddleRight
        BtnMemberSubscription.UseVisualStyleBackColor = False
        ' 
        ' BtnSubscribtion
        ' 
        BtnSubscribtion.BackColor = Color.Transparent
        BtnSubscribtion.FlatAppearance.BorderColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnSubscribtion.FlatAppearance.BorderSize = 2
        BtnSubscribtion.FlatStyle = FlatStyle.Flat
        BtnSubscribtion.Font = New Font("Times New Roman", 13.8F)
        BtnSubscribtion.ForeColor = Color.White
        BtnSubscribtion.Image = My.Resources.Resources.icons8_chat_64
        BtnSubscribtion.ImageAlign = ContentAlignment.MiddleLeft
        BtnSubscribtion.Location = New Point(17, 225)
        BtnSubscribtion.Margin = New Padding(3, 4, 3, 4)
        BtnSubscribtion.Name = "BtnSubscribtion"
        BtnSubscribtion.Size = New Size(279, 81)
        BtnSubscribtion.TabIndex = 3
        BtnSubscribtion.Text = " الإشتراكات"
        BtnSubscribtion.TextAlign = ContentAlignment.MiddleRight
        BtnSubscribtion.UseVisualStyleBackColor = False
        ' 
        ' BtnCautch
        ' 
        BtnCautch.BackColor = Color.Transparent
        BtnCautch.FlatAppearance.BorderColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnCautch.FlatAppearance.BorderSize = 2
        BtnCautch.FlatStyle = FlatStyle.Flat
        BtnCautch.Font = New Font("Times New Roman", 13.8F)
        BtnCautch.ForeColor = Color.White
        BtnCautch.Image = My.Resources.Resources.icons8_gym_64__1_
        BtnCautch.ImageAlign = ContentAlignment.MiddleLeft
        BtnCautch.Location = New Point(14, 117)
        BtnCautch.Margin = New Padding(3, 4, 3, 4)
        BtnCautch.Name = "BtnCautch"
        BtnCautch.Size = New Size(282, 90)
        BtnCautch.TabIndex = 2
        BtnCautch.Text = "المدربين"
        BtnCautch.TextAlign = ContentAlignment.MiddleRight
        BtnCautch.UseVisualStyleBackColor = False
        ' 
        ' BtnCustomer
        ' 
        BtnCustomer.BackColor = Color.Transparent
        BtnCustomer.FlatAppearance.BorderColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnCustomer.FlatAppearance.BorderSize = 2
        BtnCustomer.FlatStyle = FlatStyle.Flat
        BtnCustomer.Font = New Font("Times New Roman", 13.8F)
        BtnCustomer.ForeColor = Color.White
        BtnCustomer.Image = My.Resources.Resources.icons8_member_80
        BtnCustomer.ImageAlign = ContentAlignment.MiddleLeft
        BtnCustomer.Location = New Point(17, 28)
        BtnCustomer.Margin = New Padding(3, 4, 3, 4)
        BtnCustomer.Name = "BtnCustomer"
        BtnCustomer.Size = New Size(276, 81)
        BtnCustomer.TabIndex = 0
        BtnCustomer.Text = " الأعضاء"
        BtnCustomer.TextAlign = ContentAlignment.MiddleRight
        BtnCustomer.UseVisualStyleBackColor = False
        ' 
        ' BtnSubscription
        ' 
        BtnSubscription.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnSubscription.FlatAppearance.BorderColor = Color.FromArgb(CByte(21), CByte(101), CByte(192))
        BtnSubscription.FlatAppearance.BorderSize = 0
        BtnSubscription.FlatStyle = FlatStyle.Flat
        BtnSubscription.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        BtnSubscription.ForeColor = Color.Black
        BtnSubscription.Location = New Point(894, 28)
        BtnSubscription.Margin = New Padding(3, 4, 3, 4)
        BtnSubscription.Name = "BtnSubscription"
        BtnSubscription.Size = New Size(250, 81)
        BtnSubscription.TabIndex = 1
        BtnSubscription.Text = "الإشتراكات"
        BtnSubscription.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' TsmInventory
        ' 
        TsmInventory.Name = "TsmInventory"
        TsmInventory.Size = New Size(32, 19)
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 6)
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 6)
        ' 
        ' TsmUserControl
        ' 
        TsmUserControl.Name = "TsmUserControl"
        TsmUserControl.Size = New Size(32, 19)
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 6)
        ' 
        ' TsmMonitor
        ' 
        TsmMonitor.Name = "TsmMonitor"
        TsmMonitor.Size = New Size(32, 19)
        ' 
        ' TsmSettings
        ' 
        TsmSettings.Name = "TsmSettings"
        TsmSettings.Size = New Size(32, 19)
        ' 
        ' TSMControl
        ' 
        TSMControl.DropDownItems.AddRange(New ToolStripItem() {TSMChangepassword})
        TSMControl.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TSMControl.ForeColor = Color.White
        TSMControl.Name = "TSMControl"
        TSMControl.Size = New Size(86, 55)
        TSMControl.Text = "الإعدادات"
        ' 
        ' TSMChangepassword
        ' 
        TSMChangepassword.Name = "TSMChangepassword"
        TSMChangepassword.Size = New Size(210, 26)
        TSMChangepassword.Text = "تغيير كلمة المرور"
        ' 
        ' TsmDeletedElements
        ' 
        TsmDeletedElements.Name = "TsmDeletedElements"
        TsmDeletedElements.Size = New Size(32, 19)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.AutoSize = False
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        MenuStrip1.Font = New Font("Microsoft Sans Serif", 12F)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {المستخدمينToolStripMenuItem, TSMControl, الإدارةالماليةToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.RightToLeft = RightToLeft.Yes
        MenuStrip1.Size = New Size(1831, 59)
        MenuStrip1.TabIndex = 30
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' المستخدمينToolStripMenuItem
        ' 
        المستخدمينToolStripMenuItem.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        المستخدمينToolStripMenuItem.ForeColor = Color.White
        المستخدمينToolStripMenuItem.Image = My.Resources.Resources.icons8_users_47
        المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem"
        المستخدمينToolStripMenuItem.Size = New Size(118, 55)
        المستخدمينToolStripMenuItem.Text = "المستخدمين"
        ' 
        ' الإدارةالماليةToolStripMenuItem
        ' 
        الإدارةالماليةToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TSMTreasury, TSMPayment, TSMTransctionPayment})
        الإدارةالماليةToolStripMenuItem.ForeColor = Color.White
        الإدارةالماليةToolStripMenuItem.Name = "الإدارةالماليةToolStripMenuItem"
        الإدارةالماليةToolStripMenuItem.Size = New Size(111, 55)
        الإدارةالماليةToolStripMenuItem.Text = "الإدارة المالية"
        ' 
        ' TSMTreasury
        ' 
        TSMTreasury.Name = "TSMTreasury"
        TSMTreasury.Size = New Size(262, 30)
        TSMTreasury.Text = "الخزينة"
        ' 
        ' TSMPayment
        ' 
        TSMPayment.Name = "TSMPayment"
        TSMPayment.Size = New Size(262, 30)
        TSMPayment.Text = "إيصالات الدفع"
        ' 
        ' TSMTransctionPayment
        ' 
        TSMTransctionPayment.Name = "TSMTransctionPayment"
        TSMTransctionPayment.Size = New Size(262, 30)
        TSMTransctionPayment.Text = "حركات المالية للإيصالات"
        ' 
        ' PnlMain
        ' 
        PnlMain.BackColor = Color.WhiteSmoke
        PnlMain.BackgroundImageLayout = ImageLayout.Stretch
        PnlMain.BorderStyle = BorderStyle.FixedSingle
        PnlMain.Dock = DockStyle.Fill
        PnlMain.Location = New Point(0, 0)
        PnlMain.Margin = New Padding(3, 4, 3, 4)
        PnlMain.Name = "PnlMain"
        PnlMain.Size = New Size(1831, 1102)
        PnlMain.TabIndex = 32
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.BorderRadius = 10
        Guna2ShadowForm1.ShadowColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.ContainerControl = Me
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = Guna2PanelTop
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Guna2PanelTop
        ' 
        Guna2PanelTop.BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        Guna2PanelTop.Controls.Add(Guna2ControlBoxMin)
        Guna2PanelTop.Controls.Add(Guna2ControlBoxClose)
        Guna2PanelTop.CustomizableEdges = CustomizableEdges23
        Guna2PanelTop.Dock = DockStyle.Top
        Guna2PanelTop.Location = New Point(0, 59)
        Guna2PanelTop.Name = "Guna2PanelTop"
        Guna2PanelTop.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        Guna2PanelTop.Size = New Size(1831, 10)
        Guna2PanelTop.TabIndex = 100
        ' 
        ' Guna2ControlBoxMin
        ' 
        Guna2ControlBoxMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBoxMin.CustomizableEdges = CustomizableEdges19
        Guna2ControlBoxMin.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        Guna2ControlBoxMin.IconColor = Color.White
        Guna2ControlBoxMin.Location = New Point(57, 6)
        Guna2ControlBoxMin.Name = "Guna2ControlBoxMin"
        Guna2ControlBoxMin.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2ControlBoxMin.Size = New Size(45, 36)
        Guna2ControlBoxMin.TabIndex = 1
        ' 
        ' Guna2ControlBoxClose
        ' 
        Guna2ControlBoxClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBoxClose.CustomizableEdges = CustomizableEdges21
        Guna2ControlBoxClose.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        Guna2ControlBoxClose.HoverState.FillColor = Color.Red
        Guna2ControlBoxClose.IconColor = Color.White
        Guna2ControlBoxClose.Location = New Point(6, 6)
        Guna2ControlBoxClose.Name = "Guna2ControlBoxClose"
        Guna2ControlBoxClose.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        Guna2ControlBoxClose.Size = New Size(45, 36)
        Guna2ControlBoxClose.TabIndex = 0
        ' 
        ' Guna2ElipseBtnCustomer
        ' 
        Guna2ElipseBtnCustomer.BorderRadius = 20
        Guna2ElipseBtnCustomer.TargetControl = BtnCustomer
        ' 
        ' Guna2ElipseBtnCautch
        ' 
        Guna2ElipseBtnCautch.BorderRadius = 20
        Guna2ElipseBtnCautch.TargetControl = BtnCautch
        ' 
        ' Guna2ElipseBtnSubscribtion
        ' 
        Guna2ElipseBtnSubscribtion.BorderRadius = 20
        Guna2ElipseBtnSubscribtion.TargetControl = BtnSubscribtion
        ' 
        ' Guna2ElipseBtnMemberSubscription
        ' 
        Guna2ElipseBtnMemberSubscription.BorderRadius = 20
        Guna2ElipseBtnMemberSubscription.TargetControl = BtnMemberSubscription
        ' 
        ' Guna2ElipseBtnTrainingBooking
        ' 
        Guna2ElipseBtnTrainingBooking.BorderRadius = 20
        Guna2ElipseBtnTrainingBooking.TargetControl = BtnTrainingBooking
        ' 
        ' Guna2ElipseBtnSubscription
        ' 
        Guna2ElipseBtnSubscription.BorderRadius = 20
        Guna2ElipseBtnSubscription.TargetControl = BtnSubscription
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        ClientSize = New Size(1831, 1102)
        Controls.Add(Guna2PanelTop)
        Controls.Add(StatusStrip1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        Controls.Add(PnlMain)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "FrmMain"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Guna2PanelTop.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TSLMessage As ToolStripStatusLabel
    Friend WithEvents TSLDateTime As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TSLUserName As ToolStripStatusLabel
    Friend WithEvents Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnCautch As Button
    Friend WithEvents BtnCustomer As Button
    Friend WithEvents BtnSubscription As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer2 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TsmInventory As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TsmUserControl As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TsmMonitor As ToolStripMenuItem
    Friend WithEvents TsmSettings As ToolStripMenuItem
    Friend WithEvents TSMControl As ToolStripMenuItem
    Friend WithEvents TsmDeletedElements As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PnlMain As Panel
    Friend WithEvents BtnMemberSubscription As Button
    Friend WithEvents BtnSubscribtion As Button
    Friend WithEvents المستخدمينToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnTrainingBooking As Button
    Friend WithEvents TSMChangepassword As ToolStripMenuItem
    Private WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Private WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Private WithEvents Guna2PanelTop As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents Guna2ControlBoxClose As Guna.UI2.WinForms.Guna2ControlBox
    Private WithEvents Guna2ControlBoxMin As Guna.UI2.WinForms.Guna2ControlBox
    Private WithEvents Guna2ElipseBtnCustomer As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents Guna2ElipseBtnCautch As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents Guna2ElipseBtnSubscribtion As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents Guna2ElipseBtnMemberSubscription As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents Guna2ElipseBtnTrainingBooking As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents Guna2ElipseBtnSubscription As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents الإدارةالماليةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMTreasury As ToolStripMenuItem
    Friend WithEvents TSMPayment As ToolStripMenuItem
    Friend WithEvents TSMTransctionPayment As ToolStripMenuItem
End Class
