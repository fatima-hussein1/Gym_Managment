Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmDietitians

    Private ReadOnly _dtDietitians As New DataTable()
    Private _selectedDietitianId As Integer = 0

    Private Sub FrmDietitians_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        GridDietitians.AutoGenerateColumns = False
        ApplyGridStyle()

        BindDietitianColumns()
        LoadDietitians()
        ClearForm()
    End Sub

    Private Sub BindDietitianColumns()
        For Each c As DataGridViewColumn In GridDietitians.Columns
            Dim key As String = (If(c.DataPropertyName, String.Empty)).Trim()
            If key <> "" Then Continue For

            Dim id As String = (If(c.Name, String.Empty)).Trim().ToLowerInvariant()
            Dim header As String = (If(c.HeaderText, String.Empty)).Trim().ToLowerInvariant()
            Dim text As String = If(id <> "", id, header)

            If text.Contains("dietitianid") OrElse text.Contains("المعرف") OrElse text.Contains("id") Then
                c.DataPropertyName = "DietitianID"
            ElseIf text.Contains("name") OrElse text.Contains("الاسم") Then
                c.DataPropertyName = "Name"
            ElseIf text.Contains("phone") OrElse text.Contains("الهاتف") OrElse text.Contains("phonenumber") Then
                c.DataPropertyName = "phoneNumber"
            ElseIf text.Contains("cert") OrElse text.Contains("الشهادة") OrElse text.Contains("certification") Then
                c.DataPropertyName = "certification"
            ElseIf text.Contains("join") OrElse text.Contains("تاريخ") OrElse text.Contains("joine") Then
                c.DataPropertyName = "joineDate"
            ElseIf text.Contains("spec") OrElse text.Contains("التخصص") OrElse text.Contains("specialization") Then
                c.DataPropertyName = "Specialization"
            End If
        Next
    End Sub

    Private Sub ApplyGridStyle()
        Try
            GridDietitians.EnableHeadersVisualStyles = False
            GridDietitians.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 9, 43)
            GridDietitians.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            GridDietitians.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            GridDietitians.DefaultCellStyle.Font = New Font("Segoe UI", 10.0F)
            GridDietitians.DefaultCellStyle.SelectionBackColor = Color.FromArgb(234, 153, 149)
            GridDietitians.DefaultCellStyle.SelectionForeColor = Color.Black
        Catch
        End Try
    End Sub

    Private Sub LoadDietitians(Optional filter As String = Nothing)
        _dtDietitians.Clear()

        Dim sql As String = "SELECT DietitianID, Name, phoneNumber, certification, joineDate, Specialization FROM Dietitians"
        Dim hasFilter As Boolean = Not String.IsNullOrWhiteSpace(filter)
        If hasFilter Then
            sql &= " WHERE (Name LIKE @q OR phoneNumber LIKE @q OR Specialization LIKE @q)"
        End If
        sql &= " ORDER BY DietitianID DESC"

        Try
            Using cmd As New SqlCommand(sql, con)
                If hasFilter Then
                    cmd.Parameters.AddWithValue("@q", "%" & filter.Trim() & "%")
                End If

                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(_dtDietitians)
                End Using
                con.Close()
            End Using

            ' لا تقم بتغيير Columns هنا إذا كانت مصممة مسبقاً
            GridDietitians.DataSource = _dtDietitians

        Catch ex As Exception
            ShowAppMessage("خطأ في تحميل أخصائيي التغذية: " & ex.Message, AppMessageType.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(TxtName.Text) Then
            ShowAppMessage("الرجاء إدخال الاسم.", AppMessageType.Warning)
            TxtName.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub ClearForm()
        _selectedDietitianId = 0
        TxtName.Clear()
        TxtPhone.Clear()
        TxtCertification.Clear()
        TxtSpecialization.Clear()
        DtJoinDate.Value = Date.Today
        Try
            GridDietitians.ClearSelection()
        Catch
        End Try
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        TxtSearch.Clear()
        LoadDietitians()
        ClearForm()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        LoadDietitians(TxtSearch.Text)
    End Sub

    Private Sub GridDietitians_SelectionChanged(sender As Object, e As EventArgs)
        Try
            If GridDietitians.CurrentRow Is Nothing Then Return
            Dim row = GridDietitians.CurrentRow
            If row.Cells("DietitianID").Value Is Nothing OrElse IsDBNull(row.Cells("DietitianID").Value) Then Return

            _selectedDietitianId = Convert.ToInt32(row.Cells("DietitianID").Value)
            TxtName.Text = If(row.Cells("Name").Value, "").ToString
            TxtPhone.Text = If(row.Cells("phoneNumber").Value, "").ToString
            TxtCertification.Text = If(row.Cells("certification").Value, "").ToString
            TxtSpecialization.Text = If(row.Cells("Specialization").Value, "").ToString

            If row.Cells("joineDate").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("joineDate").Value) Then
                DtJoinDate.Value = Convert.ToDateTime(row.Cells("joineDate").Value)
            Else
                DtJoinDate.Value = Date.Today
            End If
        Catch
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If Not ValidateInputs() Then Return

        Const sql As String = "INSERT INTO Dietitians (Name, phoneNumber, certification, joineDate, Specialization) VALUES (@Name, @Phone, @Cert, @JoinDate, @Spec)"

        Try
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Name", TxtName.Text.Trim())
                cmd.Parameters.AddWithValue("@Phone", If(String.IsNullOrWhiteSpace(TxtPhone.Text), CType(DBNull.Value, Object), TxtPhone.Text.Trim()))
                cmd.Parameters.AddWithValue("@Cert", If(String.IsNullOrWhiteSpace(TxtCertification.Text), CType(DBNull.Value, Object), TxtCertification.Text.Trim()))
                cmd.Parameters.AddWithValue("@JoinDate", DtJoinDate.Value.Date)
                cmd.Parameters.AddWithValue("@Spec", If(String.IsNullOrWhiteSpace(TxtSpecialization.Text), CType(DBNull.Value, Object), TxtSpecialization.Text.Trim()))

                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            ShowAppMessage("تمت الإضافة بنجاح.", AppMessageType.Success)
            LoadDietitians(TxtSearch.Text)
            ClearForm()

        Catch ex As Exception
            ShowAppMessage("خطأ أثناء الإضافة: " & ex.Message, AppMessageType.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If _selectedDietitianId <= 0 Then
            ShowAppMessage("اختر أخصائي من الجدول أولاً.", AppMessageType.Warning)
            Return
        End If
        If Not ValidateInputs() Then Return

        Const sql As String = "UPDATE Dietitians SET Name=@Name, phoneNumber=@Phone, certification=@Cert, joineDate=@JoinDate, Specialization=@Spec WHERE DietitianID=@Id"

        Try
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Id", _selectedDietitianId)
                cmd.Parameters.AddWithValue("@Name", TxtName.Text.Trim())
                cmd.Parameters.AddWithValue("@Phone", If(String.IsNullOrWhiteSpace(TxtPhone.Text), CType(DBNull.Value, Object), TxtPhone.Text.Trim()))
                cmd.Parameters.AddWithValue("@Cert", If(String.IsNullOrWhiteSpace(TxtCertification.Text), CType(DBNull.Value, Object), TxtCertification.Text.Trim()))
                cmd.Parameters.AddWithValue("@JoinDate", DtJoinDate.Value.Date)
                cmd.Parameters.AddWithValue("@Spec", If(String.IsNullOrWhiteSpace(TxtSpecialization.Text), CType(DBNull.Value, Object), TxtSpecialization.Text.Trim()))

                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim rows = cmd.ExecuteNonQuery()
                con.Close()

                If rows > 0 Then
                    ShowAppMessage("تم التعديل بنجاح.", AppMessageType.Success)
                Else
                    ShowAppMessage("لم يتم العثور على السجل.", AppMessageType.Warning)
                End If
            End Using

            LoadDietitians(TxtSearch.Text)

        Catch ex As Exception
            ShowAppMessage("خطأ أثناء التعديل: " & ex.Message, AppMessageType.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If _selectedDietitianId <= 0 Then
            ShowAppMessage("اختر أخصائي من الجدول أولاً.", AppMessageType.Warning)
            Return
        End If

        Const sql As String = "DELETE FROM Dietitians WHERE DietitianID=@Id"

        Try
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Id", _selectedDietitianId)

                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim rows = cmd.ExecuteNonQuery()
                con.Close()

                If rows > 0 Then
                    ShowAppMessage("تم الحذف بنجاح.", AppMessageType.Success)
                Else
                    ShowAppMessage("لم يتم العثور على السجل.", AppMessageType.Warning)
                End If
            End Using

            LoadDietitians(TxtSearch.Text)
            ClearForm()

        Catch ex As Exception
            ShowAppMessage("خطأ أثناء الحذف: " & ex.Message, AppMessageType.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearForm()
    End Sub

End Class