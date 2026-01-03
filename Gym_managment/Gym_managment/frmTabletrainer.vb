Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class frmTabletrainer

    Private AppsTable As DataTable

    Private ReadOnly Property CurrentTrainerId As Integer
        Get
            Return GetTrainerIdForCurrentUser()
        End Get
    End Property

    Private Function GetTrainerIdForCurrentUser() As Integer
        If UserID <= 0 Then Return 0

        Try
            Dim sql As String = "SELECT TOP 1 TrainerID FROM Trainers WHERE UserID = @uid"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.Add("@uid", SqlDbType.Int).Value = UserID
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim o = cmd.ExecuteScalar()
                con.Close()
                If o Is Nothing OrElse o Is DBNull.Value Then Return 0
                Return CInt(o)
            End Using
        Catch
            If con.State = ConnectionState.Open Then con.Close()
            Return 0
        End Try
    End Function

    Private Sub frmTabletrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbStatus.Items.Clear()
        CmbStatus.Items.AddRange(New Object() {"«·ﬂ·", "‰‘ÿ", "€Ì— ‰‘ÿ"})
        If CmbStatus.Items.Count > 0 Then CmbStatus.SelectedIndex = 0

        DtpDay.Value = Date.Today
        LoadAppointments()
    End Sub

    Private Sub LoadAppointments()
        AppsTable = New DataTable()

        Dim tid As Integer = CurrentTrainerId
        If tid <= 0 Then
            GridApps.DataSource = AppsTable
            Return
        End If

        Dim sql As String =
            "SELECT AppointmentID, AppointmentDate, StartTime, EndTime, Status, Notes " &
            "FROM TrainerAppointments " &
            "WHERE TrainerID = @tid AND AppointmentDate = @d"

        Dim statusFilter As String = If(CmbStatus.SelectedItem Is Nothing, "«·ﬂ·", CmbStatus.SelectedItem.ToString())
        If statusFilter <> "«·ﬂ·" Then
            sql &= " AND Status = @st"
        End If

        Dim s As String = TxtSearch.Text.Trim()
        If Not String.IsNullOrWhiteSpace(s) Then
            sql &= " AND (Status LIKE @q OR Notes LIKE @q)"
        End If

        sql &= " ORDER BY StartTime"

        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.Add("@tid", SqlDbType.Int).Value = tid
            cmd.Parameters.Add("@d", SqlDbType.Date).Value = DtpDay.Value.Date

            If statusFilter <> "«·ﬂ·" Then
                cmd.Parameters.Add("@st", SqlDbType.NVarChar, 20).Value = statusFilter
            End If

            If Not String.IsNullOrWhiteSpace(s) Then
                cmd.Parameters.Add("@q", SqlDbType.NVarChar, 200).Value = "%" & s & "%"
            End If

            Using da As New SqlDataAdapter(cmd)
                da.Fill(AppsTable)
            End Using
        End Using

        For Each r As DataRow In AppsTable.Rows
            If AppsTable.Columns.Contains("StartTime") AndAlso Not IsDBNull(r("StartTime")) Then
                Dim ts As TimeSpan = CType(r("StartTime"), TimeSpan)
                r("StartTime") = ts.ToString("hh\:mm")
            End If
            If AppsTable.Columns.Contains("EndTime") AndAlso Not IsDBNull(r("EndTime")) Then
                Dim ts2 As TimeSpan = CType(r("EndTime"), TimeSpan)
                r("EndTime") = ts2.ToString("hh\:mm")
            End If
            If AppsTable.Columns.Contains("AppointmentDate") AndAlso Not IsDBNull(r("AppointmentDate")) Then
                Dim d As Date = CDate(r("AppointmentDate"))
                r("AppointmentDate") = d.ToString("dd-MM-yyyy")
            End If
        Next

        GridApps.AutoGenerateColumns = False
        GridApps.DataSource = AppsTable
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        LoadAppointments()
    End Sub

    Private Sub DtpDay_ValueChanged(sender As Object, e As EventArgs) Handles DtpDay.ValueChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        LoadAppointments()
    End Sub

    Private Sub CmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStatus.SelectedIndexChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        LoadAppointments()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        LoadAppointments()
    End Sub

End Class