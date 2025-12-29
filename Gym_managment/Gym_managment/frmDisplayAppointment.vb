Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Globalization
Imports System.Threading

Public Class frmDisplayAppointment

    Private ReadOnly arCulture As CultureInfo = New CultureInfo("ar-SA")

    Private listDayCells As New List(Of DayCell)()
    Private currentMonth As Date = New Date(Date.Today.Year, Date.Today.Month, 1)
    Private selectedDate As Date = Date.Today

    Private Sub frmDisplayAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' عرض ميلادي مع نصوص عربية (أسماء شهور/أيام حسب إعدادات النظام)
        Thread.CurrentThread.CurrentCulture = arCulture
        Thread.CurrentThread.CurrentUICulture = arCulture

        GenerateDayCells(42)
        DisplayMonth()

        SelectDate(Date.Today)
    End Sub

    Private Sub DisplayMonth()
        lblMonthAndYear.Text = currentMonth.ToString("MMMM yyyy", arCulture)

        Dim firstDayOfMonth As Date = currentMonth
        Dim daysInMonth As Integer = firstDayOfMonth.AddMonths(1).AddDays(-1).Day

        Dim firstCellIndex As Integer = GetFirstCellIndex(firstDayOfMonth) ' Saturday=0 .. Friday=6

        Dim prevMonthLastDay As Date = firstDayOfMonth.AddDays(-1)
        Dim prevMonthDays As Integer = prevMonthLastDay.Day

        ' ابدأ من تاريخ يمثل أول خلية في الشبكة (قد يكون من الشهر السابق)
        Dim startGridDate As Date = firstDayOfMonth.AddDays(-firstCellIndex)

        ' املأ 42 خلية متتابعة بدون فراغ
        For i As Integer = 0 To listDayCells.Count - 1
            Dim d As Date = startGridDate.AddDays(i)
            Dim cell As DayCell = listDayCells(i)

            cell.DayDate = d
            cell.LblDayNumber.Text = d.Day.ToString(arCulture)
            cell.LblDayNumber.Visible = True

            Dim isCurrentMonth As Boolean = (d.Month = currentMonth.Month AndAlso d.Year = currentMonth.Year)

            If isCurrentMonth Then
                cell.BackColor = Color.FromArgb(0, 9, 43)
                cell.LblDayNumber.ForeColor = Color.White
            Else
                ' أيام من الشهر السابق/اللاحق بلون أهدأ
                cell.BackColor = Color.FromArgb(24, 30, 55)
                cell.LblDayNumber.ForeColor = Color.FromArgb(170, 170, 170)
            End If
        Next

        ' تمييز الأيام التي لديها مواعيد داخل الشهر الظاهر
        MarkDaysWithAppointments(firstDayOfMonth, firstDayOfMonth.AddMonths(1).AddDays(-1))

        HighlightSelectedDate()
    End Sub

    ' تحويل DayOfWeek إلى عمود حسب ترتيبنا: السبت..الجمعة
    Private Function GetFirstCellIndex(firstDayOfMonth As Date) As Integer
        ' DayOfWeek: Sunday=0..Saturday=6
        ' Saturday=0, Sunday=1, Monday=2, Tuesday=3, Wednesday=4, Thursday=5, Friday=6
        Dim map() As Integer = {1, 2, 3, 4, 5, 6, 0}
        Return map(CInt(firstDayOfMonth.DayOfWeek))
    End Function

    Private Sub MarkDaysWithAppointments(startDate As Date, endDate As Date)
        Dim sql As String =
        "SELECT DISTINCT AppointmentDate
         FROM TrainerAppointments
         WHERE AppointmentDate BETWEEN @init AND @end"

        Dim dt As New DataTable()
        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.Add("@init", SqlDbType.Date).Value = startDate.Date
            cmd.Parameters.Add("@end", SqlDbType.Date).Value = endDate.Date
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        Dim days As New HashSet(Of Date)()
        For Each r As DataRow In dt.Rows
            days.Add(CDate(r("AppointmentDate")).Date)
        Next

        For Each c As DayCell In listDayCells
            If c.DayDate = Date.MinValue Then Continue For
            c.SetHasAppointments(days.Contains(c.DayDate.Date))
        Next
    End Sub

    Private Sub LoadAppointmentsForSelectedDate()
        If LblSelectedDate IsNot Nothing Then
            LblSelectedDate.Text = "مواعيد يوم: " & selectedDate.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture)
        End If

        If flAppointments Is Nothing Then Return

        flAppointments.SuspendLayout()
        flAppointments.Controls.Clear()

        Dim sql As String =
        "SELECT TA.AppointmentID,
                TA.AppointmentDate,
                TA.StartTime,
                TA.EndTime,
                TA.Status,
                T.Name AS TrainerName
         FROM TrainerAppointments TA
         LEFT JOIN Trainers T ON TA.TrainerID = T.TrainerID
         WHERE TA.AppointmentDate = @d
         ORDER BY TA.StartTime"

        Dim dt As New DataTable()
        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.Add("@d", SqlDbType.Date).Value = selectedDate.Date
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        If dt.Rows.Count = 0 Then
            Dim lblEmpty As New Label()
            lblEmpty.AutoSize = False
            lblEmpty.Size = New Size(flAppointments.Width - 10, 40)
            lblEmpty.ForeColor = Color.FromArgb(234, 153, 149)
            lblEmpty.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            lblEmpty.TextAlign = ContentAlignment.MiddleCenter
            lblEmpty.Text = "لا توجد مواعيد لهذا اليوم"
            flAppointments.Controls.Add(lblEmpty)
            flAppointments.ResumeLayout()
            Return
        End If

        For Each row As DataRow In dt.Rows
            Dim appId As Integer = Convert.ToInt32(row("AppointmentID"))
            Dim trainerName As String = If(IsDBNull(row("TrainerName")), "", row("TrainerName").ToString())
            Dim startTimeText As String = CType(row("StartTime"), TimeSpan).ToString("hh\:mm")
            Dim endTimeText As String = CType(row("EndTime"), TimeSpan).ToString("hh\:mm")
            Dim statusText As String = If(IsDBNull(row("Status")), "", row("Status").ToString())

            Dim btn As New Guna.UI2.WinForms.Guna2Button()
            btn.Animated = True
            btn.BorderRadius = 10
            btn.FillColor = Color.FromArgb(0, 9, 43)
            btn.BorderColor = Color.FromArgb(234, 153, 149)
            btn.BorderThickness = 2
            btn.ForeColor = Color.White
            btn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
            btn.TextAlign = HorizontalAlignment.Left
            btn.Size = New Size(flAppointments.Width - 10, 52)
            btn.Margin = New Padding(0, 0, 0, 8)
            btn.Tag = appId

            btn.Text = $"{startTimeText}-{endTimeText}  {trainerName}  ({statusText})"
            btn.HoverState.BorderColor = Color.FromArgb(193, 20, 137)
            btn.HoverState.FillColor = Color.FromArgb(193, 20, 137)

            AddHandler btn.Click,
                Sub()
                    Dim f As New FrmAdd_Update_Appointments()
                    f.SelectedAppointmentId = appId
                    If f.ShowDialog(Me) = DialogResult.OK Then
                        DisplayMonth()
                        LoadAppointmentsForSelectedDate()
                    Else
                        LoadAppointmentsForSelectedDate()
                    End If
                End Sub

            flAppointments.Controls.Add(btn)
        Next

        flAppointments.ResumeLayout()
    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        currentMonth = currentMonth.AddMonths(-1)
        DisplayMonth()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        currentMonth = currentMonth.AddMonths(1)
        DisplayMonth()
    End Sub

    Private Sub DayCell_DayClicked(sender As DayCell, clickedDate As Date)
        If clickedDate = Date.MinValue Then Return
        SelectDate(clickedDate)
    End Sub

    Private Sub SelectDate(d As Date)
        selectedDate = d.Date

        Dim monthStart As New Date(selectedDate.Year, selectedDate.Month, 1)
        If monthStart <> currentMonth Then
            currentMonth = monthStart
            DisplayMonth()
        End If

        HighlightSelectedDate()
        LoadAppointmentsForSelectedDate()
    End Sub

    Private Sub HighlightSelectedDate()
        For Each c As DayCell In listDayCells
            If c.DayDate = Date.MinValue Then Continue For

            If c.DayDate.Date = selectedDate.Date Then
                c.BackColor = Color.FromArgb(193, 20, 137)
            ElseIf c.DayDate.Date = Date.Today Then
                c.BackColor = Color.FromArgb(36, 45, 77)
            Else
                ' اترك تمييز المواعيد إن وجد
                If c.BackColor = Color.FromArgb(36, 45, 77) Then
                    Continue For
                End If
                c.BackColor = Color.FromArgb(0, 9, 43)
            End If
        Next
    End Sub

    Private Sub GenerateDayCells(totalCells As Integer)
        flDays.Controls.Clear()
        listDayCells.Clear()

        flDays.WrapContents = True
        flDays.AutoScroll = True

        For i As Integer = 1 To totalCells
            Dim cell As New DayCell()
            cell.Name = "dayCell" & i.ToString()
            cell.Size = New Size(110, 90)
            cell.Margin = New Padding(2)
            cell.Cursor = Cursors.Hand
            cell.DayDate = Date.MinValue

            AddHandler cell.DayClicked, AddressOf DayCell_DayClicked

            flDays.Controls.Add(cell)
            listDayCells.Add(cell)
        Next
    End Sub

    Private Sub BtnAddAppointment_Click(sender As Object, e As EventArgs) Handles BtnAddAppointment.Click
        Dim frm As New FrmAdd_Update_Appointments()
        frm.SelectedDate = selectedDate

        If frm.ShowDialog(Me) = DialogResult.OK Then
            DisplayMonth()
            LoadAppointmentsForSelectedDate()
        Else
            LoadAppointmentsForSelectedDate()
        End If
    End Sub

    Private Sub LblSun_Click(sender As Object, e As EventArgs) Handles LblSun.Click

    End Sub
End Class