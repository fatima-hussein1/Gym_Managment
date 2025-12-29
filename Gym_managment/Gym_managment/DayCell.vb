Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Xml.Serialization

Partial Public Class DayCell

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <XmlElement("DayDate")>
    Public Property DayDate As Date

    Public Event DayClicked(sender As DayCell, selectedDate As Date)

    Public Sub SetDate(d As Date)
        DayDate = d
        LblDayNumber.Text = d.Day.ToString()
        LblDayNumber.Visible = True
    End Sub

    Public Sub SetHasAppointments(hasApps As Boolean)
        ' لا تغيّر لون النص؛ فقط اعمل تمييز بسيط للخلفية
        If hasApps Then
            Me.BackColor = Color.FromArgb(36, 45, 77)
        Else
            Me.BackColor = Color.FromArgb(0, 9, 43)
        End If
    End Sub

    Private Sub DayCell_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent DayClicked(Me, DayDate)
    End Sub

    Private Sub LblDayNumber_Click(sender As Object, e As EventArgs) Handles LblDayNumber.Click
        RaiseEvent DayClicked(Me, DayDate)
    End Sub
End Class
