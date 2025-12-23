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
        LblDayNumber.AutoSize = True
        LblDayNumber.Location = New Point(184, 109)
        LblDayNumber.Name = "LblDayNumber"
        LblDayNumber.Size = New Size(53, 20)
        LblDayNumber.TabIndex = 0
        LblDayNumber.Text = "Label1"
        ' 
        ' DayCell
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(LblDayNumber)
        Name = "DayCell"
        Size = New Size(349, 285)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblDayNumber As Label

End Class
