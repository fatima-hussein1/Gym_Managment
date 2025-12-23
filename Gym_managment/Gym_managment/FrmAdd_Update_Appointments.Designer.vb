<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdd_Update_Appointments
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
        DtpDate = New DateTimePicker()
        TxtPhone = New TextBox()
        TxtName = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        DtpStartTime = New DateTimePicker()
        DtpEndTime = New DateTimePicker()
        TxtNote = New TextBox()
        ChkIsActive = New CheckBox()
        GroupBox1 = New GroupBox()
        Panel2 = New Panel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Panel5 = New Panel()
        Button3 = New Button()
        TxtSearchTrainer = New TextBox()
        Panel9 = New Panel()
        Label9 = New Label()
        BtnNew = New Button()
        BtnUpdateTrainerTable = New Button()
        BtnAddTrainerTable = New Button()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel9.SuspendLayout()
        SuspendLayout()
        ' 
        ' DtpDate
        ' 
        DtpDate.Font = New Font("Times New Roman", 13.8F)
        DtpDate.Format = DateTimePickerFormat.Short
        DtpDate.Location = New Point(572, 212)
        DtpDate.Name = "DtpDate"
        DtpDate.Size = New Size(208, 34)
        DtpDate.TabIndex = 13
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Font = New Font("Times New Roman", 13.8F)
        TxtPhone.Location = New Point(572, 157)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(208, 34)
        TxtPhone.TabIndex = 12
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Times New Roman", 13.8F)
        TxtName.Location = New Point(572, 96)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(208, 34)
        TxtName.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 13.8F)
        Label3.Location = New Point(862, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 26)
        Label3.TabIndex = 10
        Label3.Text = "التاريخ"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 13.8F)
        Label2.Location = New Point(844, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 26)
        Label2.TabIndex = 9
        Label2.Text = "رقم الهاتف"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F)
        Label1.Location = New Point(843, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 26)
        Label1.TabIndex = 8
        Label1.Text = "اسم المدرب"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 13.8F)
        Label4.Location = New Point(844, 265)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 26)
        Label4.TabIndex = 14
        Label4.Text = "وقت البداية "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 13.8F)
        Label5.Location = New Point(843, 310)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 26)
        Label5.TabIndex = 15
        Label5.Text = "وقت النهاية "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 13.8F)
        Label6.Location = New Point(873, 351)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 26)
        Label6.TabIndex = 16
        Label6.Text = "النوع"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 13.8F)
        Label7.Location = New Point(873, 400)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 26)
        Label7.TabIndex = 17
        Label7.Text = "الحالة"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 13.8F)
        Label8.Location = New Point(843, 468)
        Label8.Name = "Label8"
        Label8.Size = New Size(81, 26)
        Label8.TabIndex = 18
        Label8.Text = "ملاحظات"
        ' 
        ' DtpStartTime
        ' 
        DtpStartTime.Font = New Font("Times New Roman", 13.8F)
        DtpStartTime.Format = DateTimePickerFormat.Time
        DtpStartTime.Location = New Point(572, 265)
        DtpStartTime.Name = "DtpStartTime"
        DtpStartTime.Size = New Size(208, 34)
        DtpStartTime.TabIndex = 19
        ' 
        ' DtpEndTime
        ' 
        DtpEndTime.Font = New Font("Times New Roman", 13.8F)
        DtpEndTime.Format = DateTimePickerFormat.Time
        DtpEndTime.Location = New Point(572, 310)
        DtpEndTime.Name = "DtpEndTime"
        DtpEndTime.Size = New Size(208, 34)
        DtpEndTime.TabIndex = 20
        ' 
        ' TxtNote
        ' 
        TxtNote.Font = New Font("Times New Roman", 13.8F)
        TxtNote.Location = New Point(556, 432)
        TxtNote.Multiline = True
        TxtNote.Name = "TxtNote"
        TxtNote.Size = New Size(245, 108)
        TxtNote.TabIndex = 21
        ' 
        ' ChkIsActive
        ' 
        ChkIsActive.AutoSize = True
        ChkIsActive.Checked = True
        ChkIsActive.CheckState = CheckState.Checked
        ChkIsActive.Location = New Point(762, 400)
        ChkIsActive.Name = "ChkIsActive"
        ChkIsActive.Size = New Size(18, 17)
        ChkIsActive.TabIndex = 22
        ChkIsActive.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Panel2)
        GroupBox1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(6, 97)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(500, 443)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "المدربين"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(FlowLayoutPanel3)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel9)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(4, 30)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(493, 410)
        Panel2.TabIndex = 1
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Dock = DockStyle.Fill
        FlowLayoutPanel3.Location = New Point(0, 73)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(491, 335)
        FlowLayoutPanel3.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Button3)
        Panel5.Controls.Add(TxtSearchTrainer)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 39)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(491, 34)
        Panel5.TabIndex = 1
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.icons8_search_58
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Dock = DockStyle.Left
        Button3.Location = New Point(0, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(37, 32)
        Button3.TabIndex = 1
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TxtSearchTrainer
        ' 
        TxtSearchTrainer.BorderStyle = BorderStyle.FixedSingle
        TxtSearchTrainer.Dock = DockStyle.Right
        TxtSearchTrainer.Location = New Point(37, 0)
        TxtSearchTrainer.Name = "TxtSearchTrainer"
        TxtSearchTrainer.Size = New Size(452, 34)
        TxtSearchTrainer.TabIndex = 0
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel9.Controls.Add(Label9)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(491, 39)
        Panel9.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.FromArgb(CByte(167), CByte(169), CByte(183))
        Label9.Dock = DockStyle.Fill
        Label9.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label9.Location = New Point(0, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(491, 39)
        Label9.TabIndex = 0
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnNew
        ' 
        BtnNew.FlatStyle = FlatStyle.Popup
        BtnNew.Font = New Font("Times New Roman", 12.0F)
        BtnNew.Image = My.Resources.Resources.icons8_refresh
        BtnNew.ImageAlign = ContentAlignment.MiddleRight
        BtnNew.Location = New Point(218, 560)
        BtnNew.Name = "BtnNew"
        BtnNew.Size = New Size(191, 77)
        BtnNew.TabIndex = 26
        BtnNew.Text = "جديد"
        BtnNew.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdateTrainerTable
        ' 
        BtnUpdateTrainerTable.FlatStyle = FlatStyle.Popup
        BtnUpdateTrainerTable.Font = New Font("Times New Roman", 12.0F)
        BtnUpdateTrainerTable.Image = My.Resources.Resources.icons8_edit_64__1_1
        BtnUpdateTrainerTable.ImageAlign = ContentAlignment.MiddleRight
        BtnUpdateTrainerTable.Location = New Point(469, 560)
        BtnUpdateTrainerTable.Name = "BtnUpdateTrainerTable"
        BtnUpdateTrainerTable.Size = New Size(203, 77)
        BtnUpdateTrainerTable.TabIndex = 25
        BtnUpdateTrainerTable.Text = "تعديل"
        BtnUpdateTrainerTable.UseVisualStyleBackColor = True
        ' 
        ' BtnAddTrainerTable
        ' 
        BtnAddTrainerTable.FlatStyle = FlatStyle.Popup
        BtnAddTrainerTable.Font = New Font("Times New Roman", 12.0F)
        BtnAddTrainerTable.Image = My.Resources.Resources.icons8_add_40
        BtnAddTrainerTable.ImageAlign = ContentAlignment.MiddleRight
        BtnAddTrainerTable.Location = New Point(753, 560)
        BtnAddTrainerTable.Name = "BtnAddTrainerTable"
        BtnAddTrainerTable.Size = New Size(217, 77)
        BtnAddTrainerTable.TabIndex = 24
        BtnAddTrainerTable.Text = "إضافة "
        BtnAddTrainerTable.UseVisualStyleBackColor = True
        ' 
        ' FrmAdd_Update_Appointments
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(993, 661)
        Controls.Add(BtnNew)
        Controls.Add(BtnUpdateTrainerTable)
        Controls.Add(BtnAddTrainerTable)
        Controls.Add(GroupBox1)
        Controls.Add(ChkIsActive)
        Controls.Add(TxtNote)
        Controls.Add(DtpEndTime)
        Controls.Add(DtpStartTime)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DtpDate)
        Controls.Add(TxtPhone)
        Controls.Add(TxtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmAdd_Update_Appointments"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel9.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DtpStartTime As DateTimePicker
    Friend WithEvents DtpEndTime As DateTimePicker
    Friend WithEvents TxtNote As TextBox
    Friend WithEvents ChkIsActive As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents TxtSearchTrainer As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnUpdateTrainerTable As Button
    Friend WithEvents BtnAddTrainerTable As Button
End Class
