Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class frmDisplayAppointment

    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As Date = Date.Today

    Private Sub frmDisplayAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDayPanel(42)
        DisplayCurrentDate()
        flDays.Width = 7 * 128 + 10

    End Sub

    Private Sub AddNewAppointment(ByVal sender As Object, e As EventArgs)
        Dim day As Integer = CInt(DirectCast(sender, FlowLayoutPanel).Tag)
        If day <> 0 Then
            Dim selectedDate As New Date(currentDate.Year, currentDate.Month, day)

            Dim frm As New FrmAdd_Update_Appointments()
            frm.SelectedDate = selectedDate
            frm.ShowDialog(Me)

            DisplayCurrentDate()
        End If
    End Sub
    Private Sub AddAppointmentToFlDay(ByVal startDayAtFlNumber As Integer)
        Dim startDate As New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As Date = startDate.AddMonths(1).AddDays(-1)

        Dim sql As String =
        "SELECT TA.AppointmentID,
                TA.TrainerID,
                TA.AppointmentDate,
                TA.StartTime,
                TA.EndTime,
                TA.Status,
                TA.Notes,
                T.Name AS TrainerName
         FROM TrainerAppointments TA
         LEFT JOIN Trainers T ON TA.TrainerID = T.TrainerID
         WHERE TA.AppointmentDate BETWEEN @init AND @end"

        Dim cmd As New SqlCommand(sql, con)
        cmd.Parameters.Add("@init", SqlDbType.Date).Value = startDate
        cmd.Parameters.Add("@end", SqlDbType.Date).Value = endDate

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            Dim appDay As Date = CDate(row("AppointmentDate"))
            Dim link As New LinkLabel()

            link.Tag = row("AppointmentID")
            link.Name = "link" & row("AppointmentID").ToString()

            Dim trainerName As String = If(IsDBNull(row("TrainerName")), "", row("TrainerName").ToString())
            Dim startTimeText As String = CType(row("StartTime"), TimeSpan).ToString("hh\:mm")
            Dim endTimeText As String = CType(row("EndTime"), TimeSpan).ToString("hh\:mm")

            If trainerName <> "" Then
                link.Text = trainerName & " - " & startTimeText & " - " & endTimeText
            Else
                link.Text = startTimeText & " - " & endTimeText
            End If

            link.Font = New Font("Tajawal", 11.0F)
            AddHandler link.Click, AddressOf ShowAppointmentDetail

            Dim index As Integer = (appDay.Day - 1) + (startDayAtFlNumber - 1)
            If index >= 0 AndAlso index < listFlDay.Count Then
                listFlDay(index).Controls.Add(link)
            End If
        Next
    End Sub
    Private Sub ShowAppointmentDetail(sender As Object, e As EventArgs)
        Dim appID As Integer = CInt(DirectCast(sender, LinkLabel).Tag)

        Dim frm As New FrmAdd_Update_Appointments()
        frm.SelectedAppointmentId = appID
        frm.ShowDialog(Me)

        DisplayCurrentDate()
    End Sub



    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As New Date(currentDate.Year, currentDate.Month, 1)

        Dim dow As Integer = CInt(firstDayOfMonth.DayOfWeek)

        ' الأعمدة من اليسار إلى اليمين: السبت, الأحد, الإثنين, الثلاثاء, الأربعاء, الخميس, الجمعة
        ' نريد الخريطة التالية:
        ' Sunday(0) -> column 1
        ' Monday(1) -> column 2
        ' Tuesday(2) -> column 3
        ' Wednesday(3) -> column 4
        ' Thursday(4) -> column 5
        ' Friday(5) -> column 6
        ' Saturday(6) -> column 0
        Dim toColumn() As Integer = {1, 2, 3, 4, 5, 6, 0}
        Dim columnIndex As Integer = toColumn(dow)

        Return columnIndex + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDay As New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDay.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy")

        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()

        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
        RemoveTestData(Me)
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
        RemoveTestData(Me)
    End Sub

    Private Sub Today()
        currentDate = Date.Today
        DisplayCurrentDate()
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()

        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel()
            fl.Name = "flDay" & i.ToString()
            fl.Size = New Size(128, 100)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True

            AddHandler fl.Click, AddressOf AddNewAppointment

            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub

    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.FromArgb(64, 64, 64)
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label()
            lbl.Name = "lblDay" & i.ToString()
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(110, 22)
            lbl.Text = i.ToString()
            lbl.BackColor = Color.FromArgb(64, 64, 64)
            lbl.Font = New Font("Microsoft Sans Serif", 12.0F)

            Dim index As Integer = (i - 1) + (startDayAtFlNumber - 1)
            If index >= 0 AndAlso index < listFlDay.Count Then
                listFlDay(index).Tag = i
                listFlDay(index).Controls.Add(lbl)

                If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                    listFlDay(index).BackColor = Color.FromArgb(215, 198, 202)
                    lbl.BackColor = Color.FromArgb(215, 198, 202)
                End If
            End If
        Next
    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        PrevMonth()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        NextMonth()
    End Sub


    Private Sub RemoveTestData(c As Control)
        For Each ctrl As Control In c.Controls
            RemoveTestData(ctrl)
        Next

        If c.Name IsNot Nothing AndAlso c.Name.Contains("LblTest") Then
            c.Parent.Controls.Remove(c)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class