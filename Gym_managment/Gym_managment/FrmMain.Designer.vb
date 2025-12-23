<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmMain
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
        components = New ComponentModel.Container()
        TSLMessage = New ToolStripStatusLabel()
        TSLDateTime = New ToolStripStatusLabel()
        StatusStrip1 = New StatusStrip()
        TSLUserName = New ToolStripStatusLabel()
        Panel1 = New Panel()
        BtnTrainingBooking = New Button()
        BtnMemberSubscription = New Button()
        BtnSubscribtion = New Button()
        BtnCautch = New Button()
        BtnCustomer = New Button()
        BtnSubscription = New Button()
        msTheme = New MaterialSkin.Controls.MaterialSwitch()
        lblTheme = New Label()
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
        PnlMain = New Panel()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        PnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' TSLMessage
        ' 
        TSLMessage.DisplayStyle = ToolStripItemDisplayStyle.Text
        TSLMessage.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold)
        TSLMessage.ForeColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        TSLMessage.Margin = New Padding(100, 3, 0, 2)
        TSLMessage.Name = "TSLMessage"
        TSLMessage.Size = New Size(94, 25)
        TSLMessage.Text = "تأكيد الحفظ"
        TSLMessage.Visible = False
        ' 
        ' TSLDateTime
        ' 
        TSLDateTime.Font = New Font("Microsoft Sans Serif", 11.0F)
        TSLDateTime.ForeColor = Color.White
        TSLDateTime.Margin = New Padding(10, 3, 50, 2)
        TSLDateTime.Name = "TSLDateTime"
        TSLDateTime.Size = New Size(103, 25)
        TSLDateTime.Text = "الساعة والتاريخ"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = Color.FromArgb(CByte(25), CByte(118), CByte(210))
        StatusStrip1.Font = New Font("Microsoft Sans Serif", 11.0F)
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {TSLDateTime, TSLUserName, TSLMessage})
        StatusStrip1.Location = New Point(3, 1069)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 19, 0)
        StatusStrip1.Size = New Size(1825, 30)
        StatusStrip1.TabIndex = 33
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' TSLUserName
        ' 
        TSLUserName.Font = New Font("Microsoft Sans Serif", 11.0F)
        TSLUserName.ForeColor = Color.White
        TSLUserName.Name = "TSLUserName"
        TSLUserName.Size = New Size(112, 24)
        TSLUserName.Text = "مستخدم المنظومة"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Panel1.Controls.Add(BtnTrainingBooking)
        Panel1.Controls.Add(BtnMemberSubscription)
        Panel1.Controls.Add(BtnSubscribtion)
        Panel1.Controls.Add(BtnCautch)
        Panel1.Controls.Add(BtnCustomer)
        Panel1.Controls.Add(BtnSubscription)
        Panel1.Location = New Point(3, 142)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(314, 792)
        Panel1.TabIndex = 31
        ' 
        ' BtnTrainingBooking
        ' 
        BtnTrainingBooking.BackColor = Color.White
        BtnTrainingBooking.FlatAppearance.BorderColor = Color.FromArgb(CByte(21), CByte(101), CByte(192))
        BtnTrainingBooking.FlatAppearance.BorderSize = 0
        BtnTrainingBooking.FlatStyle = FlatStyle.Popup
        BtnTrainingBooking.Font = New Font("Times New Roman", 12.0F)
        BtnTrainingBooking.ForeColor = Color.Black
        BtnTrainingBooking.Image = My.Resources.Resources.icons8_schedule_64
        BtnTrainingBooking.ImageAlign = ContentAlignment.MiddleLeft
        BtnTrainingBooking.Location = New Point(17, 412)
        BtnTrainingBooking.Margin = New Padding(3, 4, 3, 4)
        BtnTrainingBooking.Name = "BtnTrainingBooking"
        BtnTrainingBooking.Size = New Size(279, 81)
        BtnTrainingBooking.TabIndex = 5
        BtnTrainingBooking.Text = "جدول مواعيد المدربين"
        BtnTrainingBooking.UseVisualStyleBackColor = False
        ' 
        ' BtnMemberSubscription
        ' 
        BtnMemberSubscription.BackColor = Color.White
        BtnMemberSubscription.FlatAppearance.BorderColor = Color.FromArgb(CByte(21), CByte(101), CByte(192))
        BtnMemberSubscription.FlatAppearance.BorderSize = 0
        BtnMemberSubscription.FlatStyle = FlatStyle.Popup
        BtnMemberSubscription.Font = New Font("Times New Roman", 12.0F)
        BtnMemberSubscription.ForeColor = Color.Black
        BtnMemberSubscription.Image = My.Resources.Resources.icons8_add_member_50
        BtnMemberSubscription.ImageAlign = ContentAlignment.MiddleLeft
        BtnMemberSubscription.Location = New Point(17, 323)
        BtnMemberSubscription.Margin = New Padding(3, 4, 3, 4)
        BtnMemberSubscription.Name = "BtnMemberSubscription"
        BtnMemberSubscription.Size = New Size(279, 81)
        BtnMemberSubscription.TabIndex = 4
        BtnMemberSubscription.Text = "إشتراكات الأعضاء"
        BtnMemberSubscription.UseVisualStyleBackColor = False
        ' 
        ' BtnSubscribtion
        ' 
        BtnSubscribtion.BackColor = Color.White
        BtnSubscribtion.FlatAppearance.BorderColor = Color.FromArgb(CByte(21), CByte(101), CByte(192))
        BtnSubscribtion.FlatAppearance.BorderSize = 0
        BtnSubscribtion.FlatStyle = FlatStyle.Popup
        BtnSubscribtion.Font = New Font("Times New Roman", 12.0F)
        BtnSubscribtion.ForeColor = Color.Black
        BtnSubscribtion.Image = My.Resources.Resources.icons8_chat_64
        BtnSubscribtion.ImageAlign = ContentAlignment.MiddleLeft
        BtnSubscribtion.Location = New Point(17, 222)
        BtnSubscribtion.Margin = New Padding(3, 4, 3, 4)
        BtnSubscribtion.Name = "BtnSubscribtion"
        BtnSubscribtion.Size = New Size(279, 81)
        BtnSubscribtion.TabIndex = 3
        BtnSubscribtion.Text = " الإشتراكات"
        BtnSubscribtion.UseVisualStyleBackColor = False
        ' 
        ' BtnCautch
        ' 
        BtnCautch.BackColor = Color.White
        BtnCautch.FlatAppearance.BorderColor = Color.FromArgb(CByte(21), CByte(101), CByte(192))
        BtnCautch.FlatAppearance.BorderSize = 0
        BtnCautch.FlatStyle = FlatStyle.Popup
        BtnCautch.Font = New Font("Times New Roman", 12.0F)
        BtnCautch.ForeColor = Color.Black
        BtnCautch.Image = My.Resources.Resources.icons8_gym_64__1_
        BtnCautch.ImageAlign = ContentAlignment.MiddleLeft
        BtnCautch.Location = New Point(17, 121)
        BtnCautch.Margin = New Padding(3, 4, 3, 4)
        BtnCautch.Name = "BtnCautch"
        BtnCautch.Size = New Size(279, 81)
        BtnCautch.TabIndex = 2
        BtnCautch.Text = "المدربين"
        BtnCautch.UseVisualStyleBackColor = False
        ' 
        ' BtnCustomer
        ' 
        BtnCustomer.BackColor = Color.White
        BtnCustomer.FlatAppearance.BorderColor = Color.FromArgb(CByte(21), CByte(101), CByte(192))
        BtnCustomer.FlatAppearance.BorderSize = 0
        BtnCustomer.FlatStyle = FlatStyle.Popup
        BtnCustomer.Font = New Font("Times New Roman", 12.0F)
        BtnCustomer.ForeColor = Color.Black
        BtnCustomer.Image = My.Resources.Resources.icons8_member_80
        BtnCustomer.ImageAlign = ContentAlignment.MiddleLeft
        BtnCustomer.Location = New Point(17, 32)
        BtnCustomer.Margin = New Padding(3, 4, 3, 4)
        BtnCustomer.Name = "BtnCustomer"
        BtnCustomer.Size = New Size(276, 81)
        BtnCustomer.TabIndex = 0
        BtnCustomer.Text = " الأعضاء"
        BtnCustomer.UseVisualStyleBackColor = False
        ' 
        ' BtnSubscription
        ' 
        BtnSubscription.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnSubscription.FlatAppearance.BorderColor = Color.FromArgb(CByte(21), CByte(101), CByte(192))
        BtnSubscription.FlatAppearance.BorderSize = 0
        BtnSubscription.FlatStyle = FlatStyle.Flat
        BtnSubscription.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold)
        BtnSubscription.ForeColor = Color.Black
        BtnSubscription.Location = New Point(894, 28)
        BtnSubscription.Margin = New Padding(3, 4, 3, 4)
        BtnSubscription.Name = "BtnSubscription"
        BtnSubscription.Size = New Size(250, 81)
        BtnSubscription.TabIndex = 1
        BtnSubscription.Text = "الإشتراكات"
        BtnSubscription.UseVisualStyleBackColor = False
        ' 
        ' msTheme
        ' 
        msTheme.AutoSize = True
        msTheme.Depth = 0
        msTheme.Font = New Font("Times New Roman", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        msTheme.Location = New Point(1046, 83)
        msTheme.Margin = New Padding(0)
        msTheme.MouseLocation = New Point(-1, -1)
        msTheme.MouseState = MaterialSkin.MouseState.HOVER
        msTheme.Name = "msTheme"
        msTheme.Ripple = True
        msTheme.Size = New Size(58, 37)
        msTheme.TabIndex = 10
        msTheme.UseVisualStyleBackColor = True
        ' 
        ' lblTheme
        ' 
        lblTheme.AutoSize = True
        lblTheme.Font = New Font("Times New Roman", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTheme.Location = New Point(1107, 83)
        lblTheme.Name = "lblTheme"
        lblTheme.Size = New Size(94, 27)
        lblTheme.TabIndex = 11
        lblTheme.Text = "وضع داكن"
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
        TSMControl.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Font = New Font("Microsoft Sans Serif", 12.0F)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {المستخدمينToolStripMenuItem, TSMControl})
        MenuStrip1.Location = New Point(3, 64)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.RightToLeft = RightToLeft.Yes
        MenuStrip1.Size = New Size(1825, 59)
        MenuStrip1.TabIndex = 30
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' المستخدمينToolStripMenuItem
        ' 
        المستخدمينToolStripMenuItem.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        المستخدمينToolStripMenuItem.Image = My.Resources.Resources.icons8_users_47
        المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem"
        المستخدمينToolStripMenuItem.Size = New Size(118, 55)
        المستخدمينToolStripMenuItem.Text = "المستخدمين"
        ' 
        ' PnlMain
        ' 
        PnlMain.BackColor = Color.WhiteSmoke
        PnlMain.BackgroundImageLayout = ImageLayout.Stretch
        PnlMain.BorderStyle = BorderStyle.FixedSingle
        PnlMain.Controls.Add(lblTheme)
        PnlMain.Controls.Add(msTheme)
        PnlMain.Dock = DockStyle.Fill
        PnlMain.Location = New Point(3, 64)
        PnlMain.Margin = New Padding(3, 4, 3, 4)
        PnlMain.Name = "PnlMain"
        PnlMain.Size = New Size(1825, 1035)
        PnlMain.TabIndex = 32
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        ClientSize = New Size(1831, 1102)
        Controls.Add(StatusStrip1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        Controls.Add(PnlMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
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
        PnlMain.ResumeLayout(False)
        PnlMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TSLMessage As ToolStripStatusLabel
    Friend WithEvents TSLDateTime As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TSLUserName As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents msTheme As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents lblTheme As Label
    Friend WithEvents BtnTrainingBooking As Button
    Friend WithEvents TSMChangepassword As ToolStripMenuItem
End Class
