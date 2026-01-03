Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmMainTrainer

    Private MembersTable As DataTable
    Private TodayAppointmentsTable As DataTable

    Private ReadOnly Property CurrentTrainerId As Integer
        Get
            ' TODO: أربط هذا بالمدرب الحالي بعد تسجيل الدخول
            ' حالياً نأخذ أي قيمة من UserID إن كانت مفيدة، وإلا 0.
            Try
                If UserID > 0 Then Return UserID
            Catch
            End Try
            Return 0
        End Get
    End Property







    Private Sub LoadMembersForTrainer()
        MembersTable = New DataTable()

        Dim sql As String =
            "SELECT MS.MemberID, M.FullName AS MemberName, M.PhoneNumber AS Phone, SP.PackageName AS Package " &
            "FROM MemberSubscriptions MS " &
            "LEFT JOIN Members M ON MS.MemberID = M.MemberID " &
            "LEFT JOIN SubscriptionPackages SP ON MS.PackageID = SP.PackageID " &
            "WHERE MS.TrainerID = @tid AND (MS.SubscriptionStatus = N'نشط' OR MS.SubscriptionStatus = N'موقوف')"

        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.Add("@tid", SqlDbType.Int).Value = CurrentTrainerId
            Using da As New SqlDataAdapter(cmd)
                da.Fill(MembersTable)
            End Using
        End Using
    End Sub

    Private Sub LoadTodayAppointmentsForTrainer()
        TodayAppointmentsTable = New DataTable()

        Dim sql As String =
            "SELECT TA.StartTime AS [Time], M.FullName AS MemberName, TA.Status AS [Status] " &
            "FROM TrainerAppointments TA " &
            "LEFT JOIN Members M ON TA.MemberID = M.MemberID " &
            "WHERE TA.TrainerID = @tid AND TA.AppointmentDate = @d " &
            "ORDER BY TA.StartTime"

        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.Add("@tid", SqlDbType.Int).Value = CurrentTrainerId
            cmd.Parameters.Add("@d", SqlDbType.Date).Value = Date.Today
            Using da As New SqlDataAdapter(cmd)
                da.Fill(TodayAppointmentsTable)
            End Using
        End Using

        If TodayAppointmentsTable.Columns.Contains("Time") Then
            For Each r As DataRow In TodayAppointmentsTable.Rows
                If Not IsDBNull(r("Time")) Then
                    Dim ts As TimeSpan = CType(r("Time"), TimeSpan)
                    r("Time") = ts.ToString("hh\:mm")
                End If
            Next
        End If
    End Sub

    Private Sub LoadExpiringSubscriptionsForTrainer(daysAhead As Integer)
        Dim dt As New DataTable()

        Dim sql As String =
            "SELECT COUNT(*) AS Cnt " &
            "FROM MemberSubscriptions MS " &
            "WHERE MS.TrainerID = @tid " &
            "AND MS.EndDate >= @from AND MS.EndDate <= @to " &
            "AND MS.SubscriptionStatus = N'نشط'"

        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.Add("@tid", SqlDbType.Int).Value = CurrentTrainerId
            cmd.Parameters.Add("@from", SqlDbType.Date).Value = Date.Today
            cmd.Parameters.Add("@to", SqlDbType.Date).Value = Date.Today.AddDays(daysAhead)
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        Dim cnt As Integer = 0
        If dt.Rows.Count > 0 AndAlso dt.Columns.Contains("Cnt") AndAlso Not IsDBNull(dt.Rows(0)("Cnt")) Then
            cnt = CInt(dt.Rows(0)("Cnt"))
        End If
        LblExpiringCount.Text = cnt.ToString()
    End Sub

    Private Sub LoadFallbackData()
        MembersTable = New DataTable()
        MembersTable.Columns.Add("MemberID", GetType(Integer))
        MembersTable.Columns.Add("MemberName", GetType(String))
        MembersTable.Columns.Add("Phone", GetType(String))
        MembersTable.Columns.Add("Package", GetType(String))
        MembersTable.Rows.Add(1, "عضو تجريبي 1", "0000000000", "شهري")
        MembersTable.Rows.Add(2, "عضو تجريبي 2", "0000000000", "3 أشهر")

        TodayAppointmentsTable = New DataTable()
        TodayAppointmentsTable.Columns.Add("Time", GetType(String))
        TodayAppointmentsTable.Columns.Add("MemberName", GetType(String))
        TodayAppointmentsTable.Columns.Add("Status", GetType(String))
        TodayAppointmentsTable.Rows.Add("10:00", "عضو تجريبي 1", "مؤكد")
        TodayAppointmentsTable.Rows.Add("12:30", "عضو تجريبي 2", "قيد الانتظار")

        LblMembersCount.Text = MembersTable.Rows.Count.ToString()
        LblTodayCount.Text = TodayAppointmentsTable.Rows.Count.ToString()
        LblExpiringCount.Text = "0"
    End Sub

    Private Sub FrmMainTrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MnuMembers_Click(sender As Object, e As EventArgs)
        Using f As New FrmmemberTrainer()
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub MnuAppointments_Click(sender As Object, e As EventArgs)
        Using f As New frmTabletrainer()
            f.ShowDialog(Me)
        End Using
    End Sub



    Private Sub TSMProfile_Click(sender As Object, e As EventArgs) Handles TSMProfile.Click
        FrmTrainerProfile.ShowDialog()
    End Sub

    Private Sub TSMManageTrainer_Click(sender As Object, e As EventArgs) Handles TSMManageTrainer.Click
        FrmmemberTrainer.ShowDialog()

    End Sub

    Private Sub TSMTable_Click(sender As Object, e As EventArgs) Handles TSMTable.Click
        frmTabletrainer.ShowDialog()

    End Sub
End Class