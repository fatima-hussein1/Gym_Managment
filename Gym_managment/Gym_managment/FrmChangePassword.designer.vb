<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassword
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
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        TxtUserName = New TextBox()
        TxtOldPass = New TextBox()
        TxtNewPass = New TextBox()
        GroupBox1 = New GroupBox()
        BtnExit = New Button()
        BtnOK = New Button()
        CheckBox1 = New CheckBox()
        PiczoomPass1 = New PictureBox()
        PiczoomPass2 = New PictureBox()
        Panel1 = New Panel()
        GroupBox1.SuspendLayout()
        CType(PiczoomPass1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PiczoomPass2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 178)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(460, 148)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 25)
        Label3.TabIndex = 3
        Label3.Text = "كلمة المرور الجديدة"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 178)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(460, 81)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 25)
        Label1.TabIndex = 4
        Label1.Text = "كلمة المرور الحالية"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 178)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(488, 22)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 25)
        Label2.TabIndex = 5
        Label2.Text = "إسم المستخدم"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtUserName
        ' 
        TxtUserName.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 178)
        TxtUserName.Location = New Point(162, 20)
        TxtUserName.Margin = New Padding(4, 5, 4, 5)
        TxtUserName.Name = "TxtUserName"
        TxtUserName.Size = New Size(292, 30)
        TxtUserName.TabIndex = 7
        ' 
        ' TxtOldPass
        ' 
        TxtOldPass.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 178)
        TxtOldPass.Location = New Point(223, 90)
        TxtOldPass.Margin = New Padding(4, 5, 4, 5)
        TxtOldPass.Name = "TxtOldPass"
        TxtOldPass.Size = New Size(231, 30)
        TxtOldPass.TabIndex = 8
        ' 
        ' TxtNewPass
        ' 
        TxtNewPass.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 178)
        TxtNewPass.Location = New Point(223, 148)
        TxtNewPass.Margin = New Padding(4, 5, 4, 5)
        TxtNewPass.Name = "TxtNewPass"
        TxtNewPass.Size = New Size(231, 30)
        TxtNewPass.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(BtnExit)
        GroupBox1.Controls.Add(BtnOK)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 178)
        GroupBox1.Location = New Point(66, 336)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(639, 129)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = Color.FromArgb(63, 81, 181)
        BtnExit.FlatAppearance.BorderColor = Color.Silver
        BtnExit.FlatStyle = FlatStyle.Flat
        BtnExit.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BtnExit.ForeColor = Color.Ivory
        BtnExit.ImageAlign = ContentAlignment.MiddleRight
        BtnExit.Location = New Point(57, 38)
        BtnExit.Margin = New Padding(4, 5, 4, 5)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(190, 80)
        BtnExit.TabIndex = 26
        BtnExit.Text = "إلغاء الأمر"
        BtnExit.TextAlign = ContentAlignment.MiddleLeft
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' BtnOK
        ' 
        BtnOK.BackColor = Color.FromArgb(63, 81, 181)
        BtnOK.FlatAppearance.BorderColor = Color.Silver
        BtnOK.FlatStyle = FlatStyle.Flat
        BtnOK.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BtnOK.ForeColor = Color.Ivory
        BtnOK.ImageAlign = ContentAlignment.MiddleRight
        BtnOK.Location = New Point(347, 38)
        BtnOK.Margin = New Padding(4, 5, 4, 5)
        BtnOK.Name = "BtnOK"
        BtnOK.Size = New Size(190, 80)
        BtnOK.TabIndex = 25
        BtnOK.Text = "موافق"
        BtnOK.TextAlign = ContentAlignment.MiddleLeft
        BtnOK.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178)
        CheckBox1.ForeColor = Color.Black
        CheckBox1.Location = New Point(507, 302)
        CheckBox1.Margin = New Padding(4, 5, 4, 5)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.RightToLeft = RightToLeft.Yes
        CheckBox1.Size = New Size(178, 24)
        CheckBox1.TabIndex = 14
        CheckBox1.Text = "إظهار حروف كلمة المرور"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' PiczoomPass1
        ' 
        PiczoomPass1.BackgroundImageLayout = ImageLayout.Zoom
        PiczoomPass1.Location = New Point(139, 75)
        PiczoomPass1.Margin = New Padding(4, 5, 4, 5)
        PiczoomPass1.Name = "PiczoomPass1"
        PiczoomPass1.Size = New Size(53, 54)
        PiczoomPass1.TabIndex = 12
        PiczoomPass1.TabStop = False
        ' 
        ' PiczoomPass2
        ' 
        PiczoomPass2.BackgroundImageLayout = ImageLayout.Zoom
        PiczoomPass2.Location = New Point(139, 139)
        PiczoomPass2.Margin = New Padding(4, 5, 4, 5)
        PiczoomPass2.Name = "PiczoomPass2"
        PiczoomPass2.Size = New Size(53, 52)
        PiczoomPass2.TabIndex = 11
        PiczoomPass2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(PiczoomPass1)
        Panel1.Controls.Add(PiczoomPass2)
        Panel1.Controls.Add(TxtUserName)
        Panel1.Controls.Add(TxtOldPass)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TxtNewPass)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(66, 84)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(639, 205)
        Panel1.TabIndex = 27
        ' 
        ' FrmChangePassword
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(167, 185, 185)
        ClientSize = New Size(737, 474)
        Controls.Add(Panel1)
        Controls.Add(CheckBox1)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4, 5, 4, 5)
        Name = "FrmChangePassword"
        Padding = New Padding(3, 80, 3, 4)
        RightToLeft = RightToLeft.Yes
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        CType(PiczoomPass1, ComponentModel.ISupportInitialize).EndInit()
        CType(PiczoomPass2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtOldPass As TextBox
    Friend WithEvents TxtNewPass As TextBox
    Friend WithEvents PiczoomPass2 As PictureBox
    Friend WithEvents PiczoomPass1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents Panel1 As Panel
End Class
