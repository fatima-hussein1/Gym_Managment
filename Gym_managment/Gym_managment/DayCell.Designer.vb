<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DayCell

    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        LblDayNumber = New Label()
        SuspendLayout()
        ' 
        ' LblDayNumber
        ' 
        LblDayNumber.Dock = DockStyle.Top
        LblDayNumber.Height = 26
        LblDayNumber.Name = "LblDayNumber"
        LblDayNumber.TabIndex = 0
        LblDayNumber.Text = ""
        LblDayNumber.TextAlign = ContentAlignment.MiddleRight
        LblDayNumber.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblDayNumber.ForeColor = Color.White
        LblDayNumber.BackColor = Color.Transparent
        LblDayNumber.Padding = New Padding(0, 0, 6, 0)
        ' 
        ' DayCell
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(0, 9, 43)
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(LblDayNumber)
        Name = "DayCell"
        Size = New Size(110, 90)
        ResumeLayout(False)
    End Sub

    Friend WithEvents LblDayNumber As Label

End Class
