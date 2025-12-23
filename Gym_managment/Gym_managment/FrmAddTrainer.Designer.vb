<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddTrainer
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
        BtnNew = New Button()
        BtnUpdateTrainer = New Button()
        GroupBox1 = New GroupBox()
        RdStatues = New RadioButton()
        DtpDate = New DateTimePicker()
        Pictrainer = New PictureBox()
        TxtPhone = New TextBox()
        TxtName = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        BtnAddTrainer = New Button()
        GroupBox1.SuspendLayout()
        CType(Pictrainer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnNew
        ' 
        BtnNew.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnNew.FlatStyle = FlatStyle.Popup
        BtnNew.Font = New Font("Times New Roman", 12.0F)
        BtnNew.Image = My.Resources.Resources.icons8_erase_48
        BtnNew.ImageAlign = ContentAlignment.MiddleRight
        BtnNew.Location = New Point(39, 401)
        BtnNew.Name = "BtnNew"
        BtnNew.Size = New Size(191, 77)
        BtnNew.TabIndex = 15
        BtnNew.Text = "جديد"
        BtnNew.UseVisualStyleBackColor = False
        ' 
        ' BtnUpdateTrainer
        ' 
        BtnUpdateTrainer.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnUpdateTrainer.FlatStyle = FlatStyle.Popup
        BtnUpdateTrainer.Font = New Font("Times New Roman", 12.0F)
        BtnUpdateTrainer.Image = My.Resources.Resources.icons8_edit_64__2_
        BtnUpdateTrainer.ImageAlign = ContentAlignment.MiddleRight
        BtnUpdateTrainer.Location = New Point(304, 401)
        BtnUpdateTrainer.Name = "BtnUpdateTrainer"
        BtnUpdateTrainer.Size = New Size(203, 77)
        BtnUpdateTrainer.TabIndex = 14
        BtnUpdateTrainer.Text = "تعديل"
        BtnUpdateTrainer.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RdStatues)
        GroupBox1.Controls.Add(DtpDate)
        GroupBox1.Controls.Add(Pictrainer)
        GroupBox1.Controls.Add(TxtPhone)
        GroupBox1.Controls.Add(TxtName)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(25, 113)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(780, 272)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' RdStatues
        ' 
        RdStatues.AutoSize = True
        RdStatues.Font = New Font("Times New Roman", 13.8F)
        RdStatues.Location = New Point(628, 198)
        RdStatues.Name = "RdStatues"
        RdStatues.RightToLeft = RightToLeft.No
        RdStatues.Size = New Size(124, 30)
        RdStatues.TabIndex = 8
        RdStatues.TabStop = True
        RdStatues.Text = "حالة المدرب"
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
        ' Pictrainer
        ' 
        Pictrainer.BackgroundImage = My.Resources.Resources.icons8_insert_raster_image_1001
        Pictrainer.BackgroundImageLayout = ImageLayout.Stretch
        Pictrainer.Location = New Point(43, 56)
        Pictrainer.Name = "Pictrainer"
        Pictrainer.Size = New Size(147, 156)
        Pictrainer.SizeMode = PictureBoxSizeMode.StretchImage
        Pictrainer.TabIndex = 6
        Pictrainer.TabStop = False
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F)
        Label1.Location = New Point(641, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 26)
        Label1.TabIndex = 0
        Label1.Text = "اسم المدرب"
        ' 
        ' BtnAddTrainer
        ' 
        BtnAddTrainer.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnAddTrainer.FlatStyle = FlatStyle.Popup
        BtnAddTrainer.Font = New Font("Times New Roman", 12.0F)
        BtnAddTrainer.Image = My.Resources.Resources.icons8_add_file_40
        BtnAddTrainer.ImageAlign = ContentAlignment.MiddleRight
        BtnAddTrainer.Location = New Point(574, 401)
        BtnAddTrainer.Name = "BtnAddTrainer"
        BtnAddTrainer.Size = New Size(217, 77)
        BtnAddTrainer.TabIndex = 13
        BtnAddTrainer.Text = "إضافة "
        BtnAddTrainer.UseVisualStyleBackColor = False
        ' 
        ' FrmAddTrainer
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(822, 498)
        Controls.Add(BtnNew)
        Controls.Add(BtnUpdateTrainer)
        Controls.Add(GroupBox1)
        Controls.Add(BtnAddTrainer)
        Name = "FrmAddTrainer"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(Pictrainer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnUpdateTrainer As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdStatues As RadioButton
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents Pictrainer As PictureBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAddTrainer As Button
End Class
