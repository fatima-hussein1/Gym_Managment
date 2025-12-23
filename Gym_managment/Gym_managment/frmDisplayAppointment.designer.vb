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
        Panel1 = New Panel()
        lblMonthAndYear = New Label()
        Panel2 = New Panel()
        btnNextMonth = New Button()
        btnPrevMonth = New Button()
        Panel3 = New Panel()
        Label1 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        flDays = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        Panel1.Controls.Add(lblMonthAndYear)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1096, 111)
        Panel1.TabIndex = 0
        ' 
        ' lblMonthAndYear
        ' 
        lblMonthAndYear.AutoSize = True
        lblMonthAndYear.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMonthAndYear.ForeColor = Color.White
        lblMonthAndYear.Location = New Point(16, 28)
        lblMonthAndYear.Margin = New Padding(4, 0, 4, 0)
        lblMonthAndYear.Name = "lblMonthAndYear"
        lblMonthAndYear.Size = New Size(320, 54)
        lblMonthAndYear.TabIndex = 1
        lblMonthAndYear.Text = "January, 2018"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnNextMonth)
        Panel2.Controls.Add(btnPrevMonth)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(432, 0)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(664, 111)
        Panel2.TabIndex = 0
        ' 
        ' btnNextMonth
        ' 
        btnNextMonth.BackColor = Color.Transparent
        btnNextMonth.BackgroundImageLayout = ImageLayout.Stretch
        btnNextMonth.FlatStyle = FlatStyle.Popup
        btnNextMonth.Image = My.Resources.Resources.icons8_next_page_641
        btnNextMonth.Location = New Point(313, 16)
        btnNextMonth.Margin = New Padding(4, 5, 4, 5)
        btnNextMonth.Name = "btnNextMonth"
        btnNextMonth.Size = New Size(85, 85)
        btnNextMonth.TabIndex = 1
        btnNextMonth.UseVisualStyleBackColor = False
        ' 
        ' btnPrevMonth
        ' 
        btnPrevMonth.BackColor = Color.Transparent
        btnPrevMonth.BackgroundImageLayout = ImageLayout.Stretch
        btnPrevMonth.FlatStyle = FlatStyle.Popup
        btnPrevMonth.Image = My.Resources.Resources.icons8_back_arrow_641
        btnPrevMonth.Location = New Point(27, 16)
        btnPrevMonth.Margin = New Padding(4, 5, 4, 5)
        btnPrevMonth.Name = "btnPrevMonth"
        btnPrevMonth.Size = New Size(85, 85)
        btnPrevMonth.TabIndex = 0
        btnPrevMonth.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 111)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1096, 54)
        Panel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(938, 3)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 46)
        Label1.TabIndex = 0
        Label1.Text = "السبت"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label5.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(794, 5)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 44)
        Label5.TabIndex = 6
        Label5.Text = "الأحد"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label7.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(492, 4)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 46)
        Label7.TabIndex = 4
        Label7.Text = "الثلاثاء"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(336, 4)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 46)
        Label4.TabIndex = 3
        Label4.Text = "الإربعاء"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label6.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(645, 5)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(141, 46)
        Label6.TabIndex = 5
        Label6.Text = "الإثنين"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(186, 4)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 46)
        Label3.TabIndex = 2
        Label3.Text = "الخميس"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(33, 3)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 46)
        Label2.TabIndex = 1
        Label2.Text = "الجمعة"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' flDays
        ' 
        flDays.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        flDays.Dock = DockStyle.Fill
        flDays.Location = New Point(0, 165)
        flDays.Margin = New Padding(4, 5, 4, 5)
        flDays.Name = "flDays"
        flDays.RightToLeft = RightToLeft.Yes
        flDays.Size = New Size(1096, 751)
        flDays.TabIndex = 2
        ' 
        ' frmDisplayAppointment
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 916)
        Controls.Add(flDays)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "frmDisplayAppointment"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMonthAndYear As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnNextMonth As Button
    Friend WithEvents btnPrevMonth As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents flDays As FlowLayoutPanel
End Class
