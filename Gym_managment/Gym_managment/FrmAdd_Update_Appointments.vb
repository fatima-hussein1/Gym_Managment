Imports System.Data.SqlClient
Imports System.Drawing
Imports Microsoft.Data.SqlClient
Imports System.ComponentModel

Public Class FrmAdd_Update_Appointments
    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property SelectedDate As Date
    Dim btnTrainer As New Button

    Private SelectedTrainerId As Integer = 0
    Private SelectedTrainerName As String = ""


    Private Sub FrmAdd_Update_Appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SelectedDate <> Date.MinValue Then
            Me.Text = "مواعيد المدربين - " & SelectedDate.ToString("yyyy/MM/dd")
        End If

        loadall_Trainer()

        If SelectedDate <> Date.MinValue Then
        Me.Text = "مواعيد المدربين - " & SelectedDate.ToString("yyyy/MM/dd")
        DtpDate.Value = SelectedDate
    End If

    loadall_Trainer()

        If SelectedAppointmentId > 0 Then
            LoadAppointmentForEdit(SelectedAppointmentId)
        End If
    End Sub

    Private Sub LoadAppointmentForEdit(appId As Integer)
        Dim sql As String =
        "SELECT TA.AppointmentID,
                TA.TrainerID,
                TA.AppointmentDate,
                TA.StartTime,
                TA.EndTime,
                TA.Status,
                TA.Notes,
                T.Name
         FROM TrainerAppointments TA
         LEFT JOIN Trainers T ON TA.TrainerID = T.TrainerID
         WHERE TA.AppointmentID = @ID"

        Dim dt As New DataTable()

        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@ID", appId)

            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        If dt.Rows.Count = 0 Then
            MessageBox.Show("لم يتم العثور على هذا الموعد.", "تنبيه",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim r = dt.Rows(0)

        SelectedTrainerId = CInt(r("TrainerID"))
        SelectedTrainerName = r("Name").ToString()
        TxtName.Text = SelectedTrainerName

        Dim appDate As Date = CDate(r("AppointmentDate"))
        DtpDate.Value = appDate
        SelectedDate = appDate

        Dim st As TimeSpan = CType(r("StartTime"), TimeSpan)
        Dim et As TimeSpan = CType(r("EndTime"), TimeSpan)
        DtpStartTime.Value = DtpStartTime.Value.Date + st
        DtpEndTime.Value = DtpEndTime.Value.Date + et

        Dim statusText As String = r("Status").ToString()
        ChkIsActive.Checked = (statusText = "نشط")

        TxtNote.Text = If(IsDBNull(r("Notes")), "", r("Notes").ToString())
    End Sub


    Private Sub loadall_Trainer()
        Try
            FlowLayoutPanel3.AutoScroll = True
            FlowLayoutPanel3.Controls.Clear()

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()

            Using cmd As New SqlCommand("SELECT TrainerID, Name FROM Trainers", con)
                rdr = cmd.ExecuteReader()

                While rdr.Read()
                    btnTrainer = New Button()

                    btnTrainer.Width = 220
                    btnTrainer.Height = 50
                    btnTrainer.Text = rdr("Name").ToString()
                    btnTrainer.Tag = rdr("TrainerID").ToString()
                    btnTrainer.FlatStyle = FlatStyle.Flat
                    btnTrainer.FlatAppearance.BorderSize = 0

                    btnTrainer.BackColor = Color.FromArgb(52, 152, 219)
                    btnTrainer.ForeColor = Color.White

                    btnTrainer.Cursor = Cursors.Hand
                    btnTrainer.Font = New Font("Hacen Algeria", 10.8!, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
                    btnTrainer.TextAlign = ContentAlignment.MiddleCenter

                    AddHandler btnTrainer.Click, AddressOf _SelectEmp_click

                    FlowLayoutPanel3.Controls.Add(btnTrainer)
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading trainers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If rdr IsNot Nothing AndAlso Not rdr.IsClosed Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub



    Private Sub TxtSearchTrainer_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchTrainer.TextChanged
        Dim searchText As String = TxtSearchTrainer.Text.Trim()

        If String.IsNullOrWhiteSpace(searchText) Then
            loadall_Trainer()
        Else
            LoadTrainersByName(searchText)
        End If
    End Sub
    Private Sub LoadTrainersByName(searchName As String)
        Try
            FlowLayoutPanel3.AutoScroll = True
            FlowLayoutPanel3.Controls.Clear()

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()

            Dim sql As String = "SELECT TrainerID, Name FROM Trainers"
            If Not String.IsNullOrWhiteSpace(searchName) Then
                sql &= " WHERE Name LIKE @Name"
            End If

            Using cmd As New SqlCommand(sql, con)
                If Not String.IsNullOrWhiteSpace(searchName) Then
                    cmd.Parameters.AddWithValue("@Name", "%" & searchName & "%")
                End If

                rdr = cmd.ExecuteReader()

                While rdr.Read()
                    btnTrainer = New Button()

                    btnTrainer.Width = 220
                    btnTrainer.Height = 50
                    btnTrainer.Text = rdr("Name").ToString()
                    btnTrainer.Tag = rdr("TrainerID").ToString()
                    btnTrainer.FlatStyle = FlatStyle.Flat
                    btnTrainer.FlatAppearance.BorderSize = 0

                    btnTrainer.BackColor = Color.FromArgb(52, 152, 219)
                    btnTrainer.ForeColor = Color.White

                    btnTrainer.Cursor = Cursors.Hand
                    btnTrainer.Font = New Font("Hacen Algeria", 10.8!, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
                    btnTrainer.TextAlign = ContentAlignment.MiddleCenter

                    AddHandler btnTrainer.Click, AddressOf _SelectEmp_click

                    FlowLayoutPanel3.Controls.Add(btnTrainer)
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading trainers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If rdr IsNot Nothing AndAlso Not rdr.IsClosed Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub Insert_TrainerAppointment(ByVal trainerId As Integer,
                                        ByVal appDate As Date,
                                        ByVal startTime As TimeSpan,
                                        ByVal endTime As TimeSpan,
                                        ByVal status As String,
                                        ByVal notes As String,
                                        ByVal userId As Integer?)

        Dim cmd As New SqlCommand
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText =
                "INSERT INTO TrainerAppointments " &
                " (TrainerID, AppointmentDate, StartTime, EndTime, Status, Notes, UserID) " &
                "VALUES (@TrainerID, @AppointmentDate, @StartTime, @EndTime, @Status, @Notes, @UserID)"

            .Parameters.Clear()
            .Parameters.AddWithValue("@TrainerID", trainerId)
            .Parameters.AddWithValue("@AppointmentDate", appDate)
            .Parameters.AddWithValue("@StartTime", startTime)
            .Parameters.AddWithValue("@EndTime", endTime)
            .Parameters.AddWithValue("@Status", status)
            .Parameters.AddWithValue("@Notes", If(String.IsNullOrEmpty(notes), CType(DBNull.Value, Object), notes))
            .Parameters.AddWithValue("@UserID", If(userId.HasValue, CType(userId, Object), DBNull.Value))
        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("تم حفظ الموعد بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd = Nothing
    End Sub

    Public Sub Update_TrainerAppointment(ByVal appointmentId As Integer,
                                     ByVal trainerId As Integer,
                                     ByVal appDate As Date,
                                     ByVal startTime As TimeSpan,
                                     ByVal endTime As TimeSpan,
                                     ByVal status As String,
                                     ByVal notes As String,
                                     ByVal userId As Integer?)

        Dim cmd As New SqlCommand
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText =
                "UPDATE TrainerAppointments SET " &
                " TrainerID       = @TrainerID, " &
                " AppointmentDate = @AppointmentDate, " &
                " StartTime       = @StartTime, " &
                " EndTime         = @EndTime, " &
                " Status          = @Status, " &
                " Notes           = @Notes, " &
                " UserID          = @UserID " &
                "WHERE AppointmentID = @AppointmentID"

            .Parameters.Clear()
            .Parameters.AddWithValue("@AppointmentID", appointmentId)
            .Parameters.AddWithValue("@TrainerID", trainerId)
            .Parameters.AddWithValue("@AppointmentDate", appDate)
            .Parameters.AddWithValue("@StartTime", startTime)
            .Parameters.AddWithValue("@EndTime", endTime)
            .Parameters.AddWithValue("@Status", status)
            .Parameters.AddWithValue("@Notes", If(String.IsNullOrEmpty(notes), CType(DBNull.Value, Object), notes))
            .Parameters.AddWithValue("@UserID", If(userId.HasValue, CType(userId, Object), DBNull.Value))
        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("تم تعديل الموعد بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd = Nothing
    End Sub

    Private Sub _SelectEmp_click(sender As Object, e As EventArgs)
        Dim btn = TryCast(sender, Button)
        If btn Is Nothing Then Return

        SelectedTrainerId = CInt(btn.Tag)
        SelectedTrainerName = btn.Text

        TxtName.Text = SelectedTrainerName
    End Sub

    Private Sub BtnAddTrainerTable_Click(sender As Object, e As EventArgs) _
    Handles BtnAddTrainerTable.Click

        If SelectedTrainerId = 0 Then
            MessageBox.Show("الرجاء اختيار مدرب أولاً.", "تنبيه",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim appDate As Date =
        If(SelectedDate <> Date.MinValue, SelectedDate, DtpDate.Value)

        Dim startTime As TimeSpan = DtpStartTime.Value.TimeOfDay
        Dim endTime As TimeSpan = DtpEndTime.Value.TimeOfDay
        If endTime <= startTime Then
            MessageBox.Show("وقت النهاية يجب أن يكون بعد وقت البداية.", "تنبيه",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim status As String = If(ChkIsActive.Checked, "نشط", "غير نشط")

        Dim notes As String = TxtNote.Text
        Dim userId As Integer? = CurrentUserID

        Insert_TrainerAppointment(SelectedTrainerId,
                              appDate,
                              startTime,
                              endTime,
                              status,
                              notes,
                              userId)

        Me.DialogResult = DialogResult.OK
    End Sub

    Public SelectedAppointmentId As Integer = 0

    Private Sub BtnUpdateTrainerTable_Click(sender As Object, e As EventArgs) Handles BtnUpdateTrainerTable.Click
        If SelectedAppointmentId = 0 Then
            MessageBox.Show("الرجاء اختيار موعد للتعديل.", "تنبيه",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If SelectedTrainerId = 0 Then
            MessageBox.Show("الرجاء اختيار مدرب أولاً.", "تنبيه",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim appDate As Date =
        If(SelectedDate <> Date.MinValue, SelectedDate, DtpDate.Value)

        Dim startTime As TimeSpan = DtpStartTime.Value.TimeOfDay
        Dim endTime As TimeSpan = DtpEndTime.Value.TimeOfDay
        If endTime <= startTime Then
            MessageBox.Show("وقت النهاية يجب أن يكون بعد وقت البداية.", "تنبيه",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim status As String = If(ChkIsActive.Checked, "نشط", "غير نشط")

        Dim notes As String = TxtNote.Text
        Dim userId As Integer? = CurrentUserID

        Update_TrainerAppointment(SelectedAppointmentId,
                              SelectedTrainerId,
                              appDate,
                              startTime,
                              endTime,
                              status,
                              notes,
                              userId)

        Me.DialogResult = DialogResult.OK
    End Sub
End Class

