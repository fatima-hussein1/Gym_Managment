<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPackages
    Inherits MaterialSkin.Controls.MaterialForm

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnNew = New Button()
        BtnUpdatePack = New Button()
        BtnAddPack = New Button()
        PnlHeader = New Panel()
        TxtSearch = New TextBox()
        FlpPackages = New FlowLayoutPanel()
        PnlDetails = New Panel()
        BtnDelete = New Button()
        GroupBox1 = New GroupBox()
        NumDuration = New NumericUpDown()
        TxtPrice = New TextBox()
        Label4 = New Label()
        ChkIsActive = New CheckBox()
        TxtpackName = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PnlHeader.SuspendLayout()
        PnlDetails.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(NumDuration, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnNew
        ' 
        BtnNew.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnNew.FlatStyle = FlatStyle.Popup
        BtnNew.Font = New Font("Times New Roman", 12F)
        BtnNew.Image = My.Resources.Resources.icons8_erase_48
        BtnNew.ImageAlign = ContentAlignment.MiddleRight
        BtnNew.Location = New Point(361, 533)
        BtnNew.Name = "BtnNew"
        BtnNew.Size = New Size(180, 70)
        BtnNew.TabIndex = 19
        BtnNew.Text = "ÃœÌœ"
        BtnNew.UseVisualStyleBackColor = False
        ' 
        ' BtnUpdatePack
        ' 
        BtnUpdatePack.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnUpdatePack.FlatStyle = FlatStyle.Popup
        BtnUpdatePack.Font = New Font("Times New Roman", 12F)
        BtnUpdatePack.Image = My.Resources.Resources.icons8_edit_64__2_
        BtnUpdatePack.ImageAlign = ContentAlignment.MiddleRight
        BtnUpdatePack.Location = New Point(133, 423)
        BtnUpdatePack.Name = "BtnUpdatePack"
        BtnUpdatePack.Size = New Size(180, 70)
        BtnUpdatePack.TabIndex = 18
        BtnUpdatePack.Text = " ⁄œÌ·"
        BtnUpdatePack.UseVisualStyleBackColor = False
        ' 
        ' BtnAddPack
        ' 
        BtnAddPack.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnAddPack.FlatStyle = FlatStyle.Popup
        BtnAddPack.Font = New Font("Times New Roman", 12F)
        BtnAddPack.Image = My.Resources.Resources.icons8_add_file_40
        BtnAddPack.ImageAlign = ContentAlignment.MiddleRight
        BtnAddPack.Location = New Point(361, 423)
        BtnAddPack.Name = "BtnAddPack"
        BtnAddPack.Size = New Size(180, 70)
        BtnAddPack.TabIndex = 17
        BtnAddPack.Text = "≈÷«›… "
        BtnAddPack.UseVisualStyleBackColor = False
        ' 
        ' PnlHeader
        ' 
        PnlHeader.Controls.Add(TxtSearch)
        PnlHeader.Dock = DockStyle.Top
        PnlHeader.Location = New Point(3, 64)
        PnlHeader.Name = "PnlHeader"
        PnlHeader.Size = New Size(1360, 77)
        PnlHeader.TabIndex = 20
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Font = New Font("Times New Roman", 13.8F)
        TxtSearch.Location = New Point(357, 20)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(942, 34)
        TxtSearch.TabIndex = 5
        ' 
        ' FlpPackages
        ' 
        FlpPackages.AutoScroll = True
        FlpPackages.Dock = DockStyle.Left
        FlpPackages.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FlpPackages.Location = New Point(3, 141)
        FlpPackages.Name = "FlpPackages"
        FlpPackages.Size = New Size(616, 774)
        FlpPackages.TabIndex = 22
        ' 
        ' PnlDetails
        ' 
        PnlDetails.Controls.Add(BtnDelete)
        PnlDetails.Controls.Add(GroupBox1)
        PnlDetails.Controls.Add(BtnUpdatePack)
        PnlDetails.Controls.Add(BtnNew)
        PnlDetails.Controls.Add(BtnAddPack)
        PnlDetails.Dock = DockStyle.Right
        PnlDetails.Location = New Point(625, 141)
        PnlDetails.Name = "PnlDetails"
        PnlDetails.Size = New Size(738, 774)
        PnlDetails.TabIndex = 23
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnDelete.FlatStyle = FlatStyle.Popup
        BtnDelete.Font = New Font("Times New Roman", 12F)
        BtnDelete.Image = My.Resources.Resources.icons8_close_40
        BtnDelete.ImageAlign = ContentAlignment.MiddleRight
        BtnDelete.Location = New Point(133, 533)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(180, 70)
        BtnDelete.TabIndex = 20
        BtnDelete.Text = "Õ–›"
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(NumDuration)
        GroupBox1.Controls.Add(TxtPrice)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(ChkIsActive)
        GroupBox1.Controls.Add(TxtpackName)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(23, 38)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(681, 274)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        ' 
        ' NumDuration
        ' 
        NumDuration.Location = New Point(228, 95)
        NumDuration.Name = "NumDuration"
        NumDuration.Size = New Size(208, 34)
        NumDuration.TabIndex = 10
        ' 
        ' TxtPrice
        ' 
        TxtPrice.Font = New Font("Times New Roman", 13.8F)
        TxtPrice.Location = New Point(228, 137)
        TxtPrice.Name = "TxtPrice"
        TxtPrice.Size = New Size(208, 34)
        TxtPrice.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 13.8F)
        Label4.Location = New Point(482, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 26)
        Label4.TabIndex = 8
        Label4.Text = "Õ«·… «·»«ﬁ…"
        ' 
        ' ChkIsActive
        ' 
        ChkIsActive.AutoSize = True
        ChkIsActive.Checked = True
        ChkIsActive.CheckState = CheckState.Checked
        ChkIsActive.Location = New Point(406, 186)
        ChkIsActive.Name = "ChkIsActive"
        ChkIsActive.Size = New Size(18, 17)
        ChkIsActive.TabIndex = 7
        ChkIsActive.UseVisualStyleBackColor = True
        ' 
        ' TxtpackName
        ' 
        TxtpackName.Font = New Font("Times New Roman", 13.8F)
        TxtpackName.Location = New Point(228, 46)
        TxtpackName.Name = "TxtpackName"
        TxtpackName.Size = New Size(208, 34)
        TxtpackName.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 13.8F)
        Label3.Location = New Point(481, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 26)
        Label3.TabIndex = 2
        Label3.Text = "”⁄— «·»«ﬁ…"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 13.8F)
        Label2.Location = New Point(490, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 26)
        Label2.TabIndex = 1
        Label2.Text = "„œ… «·»«ﬁ…"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F)
        Label1.Location = New Point(511, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 26)
        Label1.TabIndex = 0
        Label1.Text = "«·»«ﬁ…"
        ' 
        ' FrmPackages
        ' 
        ClientSize = New Size(1366, 918)
        Controls.Add(FlpPackages)
        Controls.Add(PnlDetails)
        Controls.Add(PnlHeader)
        Name = "FrmPackages"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        PnlHeader.ResumeLayout(False)
        PnlHeader.PerformLayout()
        PnlDetails.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumDuration, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnUpdatePack As Button
    Friend WithEvents BtnAddPack As Button
    Friend WithEvents PnlHeader As Panel
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents FlpPackages As FlowLayoutPanel
    Friend WithEvents PnlDetails As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ChkIsActive As CheckBox
    Friend WithEvents TxtpackName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumDuration As NumericUpDown
    Friend WithEvents BtnDelete As Button
End Class