<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddMember
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        RdStatues = New RadioButton()
        DtpDate = New DateTimePicker()
        PicMember = New PictureBox()
        TxtPhone = New TextBox()
        TxtName = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        BtnAddMember = New Button()
        BtnUpdateMember = New Button()
        BtnNew = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        CType(PicMember, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F)
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
        RdStatues.AutoSize = True
        RdStatues.Font = New Font("Times New Roman", 13.8F)
        RdStatues.Location = New Point(601, 207)
        RdStatues.Name = "RdStatues"
        RdStatues.RightToLeft = RightToLeft.No
        RdStatues.Size = New Size(118, 30)
        RdStatues.TabIndex = 8
        RdStatues.TabStop = True
        RdStatues.Text = "حالة العضو"
        RdStatues.UseVisualStyleBackColor = True
        ' 
        ' DtpDate
        ' 
        DtpDate.Font = New Font("Times New Roman", 13.8F)
        DtpDate.Format = DateTimePickerFormat.Short
        DtpDate.Location = New Point(385, 136)
        DtpDate.Name = "DtpDate"
        DtpDate.Size = New Size(208, 34)
        DtpDate.TabIndex = 7
        ' 
        ' PicMember
        ' 
        PicMember.BackgroundImage = My.Resources.Resources.icons8_add_user_male_80
        PicMember.BackgroundImageLayout = ImageLayout.Stretch
        PicMember.Location = New Point(60, 42)
        PicMember.Name = "PicMember"
        PicMember.Size = New Size(131, 128)
        PicMember.SizeMode = PictureBoxSizeMode.StretchImage
        PicMember.TabIndex = 6
        PicMember.TabStop = False
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Font = New Font("Times New Roman", 13.8F)
        TxtPhone.Location = New Point(385, 90)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(208, 34)
        TxtPhone.TabIndex = 5
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Times New Roman", 13.8F)
        TxtName.Location = New Point(385, 48)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(208, 34)
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
        BtnAddMember.FlatStyle = FlatStyle.Popup
        BtnAddMember.Font = New Font("Times New Roman", 12.0F)
        BtnAddMember.Image = My.Resources.Resources.icons8_add_40
        BtnAddMember.ImageAlign = ContentAlignment.MiddleRight
        BtnAddMember.Location = New Point(597, 399)
        BtnAddMember.Name = "BtnAddMember"
        BtnAddMember.Size = New Size(217, 77)
        BtnAddMember.TabIndex = 9
        BtnAddMember.Text = "إضافة "
        BtnAddMember.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdateMember
        ' 
        BtnUpdateMember.FlatStyle = FlatStyle.Popup
        BtnUpdateMember.Font = New Font("Times New Roman", 12.0F)
        BtnUpdateMember.Image = My.Resources.Resources.icons8_edit_64__1_1
        BtnUpdateMember.ImageAlign = ContentAlignment.MiddleRight
        BtnUpdateMember.Location = New Point(299, 399)
        BtnUpdateMember.Name = "BtnUpdateMember"
        BtnUpdateMember.Size = New Size(203, 77)
        BtnUpdateMember.TabIndex = 10
        BtnUpdateMember.Text = "تعديل"
        BtnUpdateMember.UseVisualStyleBackColor = True
        ' 
        ' BtnNew
        ' 
        BtnNew.FlatStyle = FlatStyle.Popup
        BtnNew.Font = New Font("Times New Roman", 12.0F)
        BtnNew.Image = My.Resources.Resources.icons8_refresh
        BtnNew.ImageAlign = ContentAlignment.MiddleRight
        BtnNew.Location = New Point(48, 399)
        BtnNew.Name = "BtnNew"
        BtnNew.Size = New Size(191, 77)
        BtnNew.TabIndex = 11
        BtnNew.Text = "جديد"
        BtnNew.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FrmAddMember
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 498)
        Controls.Add(BtnNew)
        Controls.Add(BtnUpdateMember)
        Controls.Add(GroupBox1)
        Controls.Add(BtnAddMember)
        Name = "FrmAddMember"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PicMember, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PicMember As PictureBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents RdStatues As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnAddMember As Button
    Friend WithEvents BtnUpdateMember As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
