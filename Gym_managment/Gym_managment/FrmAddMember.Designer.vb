<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddMember
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        RdStatues = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        DtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        PicMember = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        TxtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        TxtName = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        Label2 = New Label()
        BtnAddMember = New Guna.UI2.WinForms.Guna2Button()
        BtnUpdateMember = New Guna.UI2.WinForms.Guna2Button()
        BtnNew = New Guna.UI2.WinForms.Guna2Button()
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        CType(PicMember, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(666, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 26)
        Label1.TabIndex = 0
        Label1.Text = "اسم "
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RdStatues)
        GroupBox1.Controls.Add(DtpDate)
        GroupBox1.Controls.Add(PicMember)
        GroupBox1.Controls.Add(TxtPhone)
        GroupBox1.Controls.Add(TxtName)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(30, 79)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(784, 296)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "بيانات العضو"
        ' 
        ' RdStatues
        ' 
        RdStatues.Checked = True
        RdStatues.CheckedState.FillColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        RdStatues.CheckedState.InnerColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        RdStatues.CustomizableEdges = CustomizableEdges1
        RdStatues.Location = New Point(380, 206)
        RdStatues.Name = "RdStatues"
        RdStatues.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        RdStatues.Size = New Size(45, 25)
        RdStatues.TabIndex = 8
        RdStatues.UncheckedState.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        RdStatues.UncheckedState.BorderThickness = 2
        RdStatues.UncheckedState.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        RdStatues.UncheckedState.InnerColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        ' 
        ' DtpDate
        ' 
        DtpDate.Animated = True
        DtpDate.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        DtpDate.BorderRadius = 6
        DtpDate.Checked = True
        DtpDate.CustomizableEdges = CustomizableEdges3
        DtpDate.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        DtpDate.Font = New Font("Segoe UI", 9.0F)
        DtpDate.ForeColor = Color.White
        DtpDate.Format = DateTimePickerFormat.Short
        DtpDate.Location = New Point(385, 136)
        DtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        DtpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        DtpDate.Name = "DtpDate"
        DtpDate.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        DtpDate.Size = New Size(208, 36)
        DtpDate.TabIndex = 7
        DtpDate.Value = New Date(2025, 12, 28, 15, 8, 14, 337)
        ' 
        ' PicMember
        ' 
        PicMember.Image = My.Resources.Resources.icons8_add_user_male_80
        PicMember.ImageRotate = 0F
        PicMember.Location = New Point(60, 42)
        PicMember.Name = "PicMember"
        PicMember.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        PicMember.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        PicMember.Size = New Size(131, 128)
        PicMember.SizeMode = PictureBoxSizeMode.CenterImage
        PicMember.TabIndex = 6
        PicMember.TabStop = False
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Animated = True
        TxtPhone.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        TxtPhone.BorderRadius = 6
        TxtPhone.Cursor = Cursors.IBeam
        TxtPhone.CustomizableEdges = CustomizableEdges6
        TxtPhone.DefaultText = ""
        TxtPhone.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        TxtPhone.Font = New Font("Segoe UI", 9.0F)
        TxtPhone.ForeColor = Color.White
        TxtPhone.Location = New Point(385, 90)
        TxtPhone.Margin = New Padding(3, 4, 3, 4)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.PlaceholderText = "رقم الهاتف"
        TxtPhone.RightToLeft = RightToLeft.Yes
        TxtPhone.SelectedText = ""
        TxtPhone.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        TxtPhone.Size = New Size(208, 36)
        TxtPhone.TabIndex = 5
        ' 
        ' TxtName
        ' 
        TxtName.Animated = True
        TxtName.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        TxtName.BorderRadius = 6
        TxtName.Cursor = Cursors.IBeam
        TxtName.CustomizableEdges = CustomizableEdges8
        TxtName.DefaultText = ""
        TxtName.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        TxtName.Font = New Font("Segoe UI", 9.0F)
        TxtName.ForeColor = Color.White
        TxtName.Location = New Point(385, 48)
        TxtName.Margin = New Padding(3, 4, 3, 4)
        TxtName.Name = "TxtName"
        TxtName.PlaceholderText = "اسم العضو"
        TxtName.RightToLeft = RightToLeft.Yes
        TxtName.SelectedText = ""
        TxtName.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        TxtName.Size = New Size(208, 36)
        TxtName.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 13.8F)
        Label3.Location = New Point(630, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 26)
        Label3.TabIndex = 2
        Label3.Text = "تاريخ التسجيل "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 13.8F)
        Label2.Location = New Point(647, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 26)
        Label2.TabIndex = 1
        Label2.Text = "رقم الهاتف"
        ' 
        ' BtnAddMember
        ' 
        BtnAddMember.Animated = True
        BtnAddMember.BackColor = Color.Transparent
        BtnAddMember.BorderRadius = 10
        BtnAddMember.CustomizableEdges = CustomizableEdges10
        BtnAddMember.FillColor = Color.FromArgb(CByte(193), CByte(20), CByte(137))
        BtnAddMember.Font = New Font("Segoe UI", 10.0F)
        BtnAddMember.ForeColor = Color.White
        BtnAddMember.Image = My.Resources.Resources.icons8_add_40
        BtnAddMember.ImageAlign = HorizontalAlignment.Right
        BtnAddMember.ImageSize = New Size(60, 60)
        BtnAddMember.Location = New Point(597, 399)
        BtnAddMember.Name = "BtnAddMember"
        BtnAddMember.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        BtnAddMember.Size = New Size(217, 77)
        BtnAddMember.TabIndex = 9
        BtnAddMember.Text = "إضافة"
        BtnAddMember.UseTransparentBackground = True
        ' 
        ' BtnUpdateMember
        ' 
        BtnUpdateMember.Animated = True
        BtnUpdateMember.BackColor = Color.Transparent
        BtnUpdateMember.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        BtnUpdateMember.BorderRadius = 10
        BtnUpdateMember.BorderThickness = 2
        BtnUpdateMember.CustomizableEdges = CustomizableEdges12
        BtnUpdateMember.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        BtnUpdateMember.Font = New Font("Segoe UI", 10.0F)
        BtnUpdateMember.ForeColor = Color.White
        BtnUpdateMember.Image = My.Resources.Resources.icons8_edit_64__1_1
        BtnUpdateMember.ImageAlign = HorizontalAlignment.Right
        BtnUpdateMember.ImageSize = New Size(60, 60)
        BtnUpdateMember.Location = New Point(294, 399)
        BtnUpdateMember.Name = "BtnUpdateMember"
        BtnUpdateMember.ShadowDecoration.CustomizableEdges = CustomizableEdges13
        BtnUpdateMember.Size = New Size(220, 77)
        BtnUpdateMember.TabIndex = 10
        BtnUpdateMember.Text = "تعديل"
        BtnUpdateMember.UseTransparentBackground = True
        ' 
        ' BtnNew
        ' 
        BtnNew.Animated = True
        BtnNew.BackColor = Color.Transparent
        BtnNew.BorderColor = Color.FromArgb(CByte(234), CByte(153), CByte(149))
        BtnNew.BorderRadius = 10
        BtnNew.BorderThickness = 2
        BtnNew.CustomizableEdges = CustomizableEdges14
        BtnNew.FillColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        BtnNew.Font = New Font("Segoe UI", 10.0F)
        BtnNew.ForeColor = Color.White
        BtnNew.Image = My.Resources.Resources.icons8_refresh
        BtnNew.ImageAlign = HorizontalAlignment.Right
        BtnNew.ImageSize = New Size(60, 60)
        BtnNew.Location = New Point(47, 399)
        BtnNew.Name = "BtnNew"
        BtnNew.ShadowDecoration.CustomizableEdges = CustomizableEdges15
        BtnNew.Size = New Size(220, 77)
        BtnNew.TabIndex = 11
        BtnNew.Text = "جديد"
        BtnNew.UseTransparentBackground = True
        ' 
        ' FrmAddMember
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(9), CByte(43))
        ClientSize = New Size(829, 498)
        Controls.Add(BtnNew)
        Controls.Add(BtnUpdateMember)
        Controls.Add(GroupBox1)
        Controls.Add(BtnAddMember)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmAddMember"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PicMember, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PicMember As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents TxtPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents RdStatues As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents BtnAddMember As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdateMember As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Private WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
