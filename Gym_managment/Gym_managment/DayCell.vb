Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Xml.Serialization

Partial Public Class DayCell

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <XmlElement("DayDate")>
    Public Property DayDate As Date

    Public Sub SetDate(d As Date)
        DayDate = d
        LblDayNumber.Text = d.Day.ToString()
    End Sub

    Public Sub SetHasAppointments(hasApps As Boolean)
        If hasApps Then
            Me.BackColor = Color.FromArgb(210, 255, 210) ' أخضر فاتح لو في مواعيد
        Else
            Me.BackColor = Color.White
        End If
    End Sub
End Class
