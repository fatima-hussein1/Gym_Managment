Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Net.Mail

Public Class FrmDietitians

    Private CR As Integer
    Private DietitianID As Integer

    Private ReadOnly DTDietitians As New DataTable()

    Private Sub FrmDietitians_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridDietitians.AutoGenerateColumns = False

        AddHandler TxtName.KeyPress, AddressOf TxtName_KeyPress
        AddHandler TxtPhone.KeyPress, AddressOf TxtPhone_KeyPress

        ClearForm()
    End Sub

    Private Sub FrmDietitians_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        GetDietitians()
    End Sub

    Private Function GetDefaultDietitianPassword() As String
        Return DtpBirthDate.Value.Year.ToString()
    End Function

    Private Function IsValidEmail(value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then Return True
        Try
            Dim addr As New MailAddress(value.Trim())
            Return addr.Address = value.Trim()
        Catch
            Return False
        End Try
    End Function

    Private Sub GetDietitians(Optional filter As String = Nothing)
        Try
            DTDietitians.Clear()
            GridDietitians.Rows.Clear()

            If GridDietitians.ColumnCount = 0 Then
                Return
            End If

            Dim sql As String = "SELECT DietitianID, Name, phoneNumber, certification, joineDate, birthdate, Specialization FROM Dietitians"
            Dim hasFilter As Boolean = Not String.IsNullOrWhiteSpace(filter)
            If hasFilter Then
                sql &= " WHERE (Name LIKE @q OR phoneNumber LIKE @q OR Specialization LIKE @q)"
            End If
            sql &= " ORDER BY DietitianID DESC"

            Using cmd As New SqlCommand(sql, con)
                If hasFilter Then
                    cmd.Parameters.AddWithValue("@q", "%" & filter.Trim() & "%")
                End If

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(DTDietitians)
                End Using
            End Using


            For i As Integer = 0 To DTDietitians.Rows.Count - 1
                GridDietitians.Rows.Add()
                GridDietitians.Item(0, i).Value = DTDietitians.Rows(i)("DietitianID")
                GridDietitians.Item(1, i).Value = DTDietitians.Rows(i)("Name")
                GridDietitians.Item(2, i).Value = DTDietitians.Rows(i)("phoneNumber")
                GridDietitians.Item(3, i).Value = DTDietitians.Rows(i)("certification")
                GridDietitians.Item(4, i).Value = DTDietitians.Rows(i)("Specialization")
            Next

        Catch ex As Exception
            ShowAppMessage("خطأ في جلب بيانات أخصائيي التغذية: " & ex.Message, AppMessageType.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) Then Return
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) Then Return
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function NameHasDigits(value As String) As Boolean
        If String.IsNullOrEmpty(value) Then Return False
        For Each ch As Char In value
            If Char.IsDigit(ch) Then Return True
        Next
        Return False
    End Function

    Private Function PhoneHasNonDigits(value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then Return False
        For Each ch As Char In value
            If Not Char.IsDigit(ch) Then Return True
        Next
        Return False
    End Function

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(TxtName.Text) Then
            ShowAppMessage(" يرجى إدخال الاسم", AppMessageType.Warning)
            TxtName.Focus()
            Return False
        End If

        If NameHasDigits(TxtName.Text) Then
            ShowAppMessage(" حقل الاسم لا يقبل أرقام", AppMessageType.Warning)
            TxtName.Focus()
            Return False
        End If

        If PhoneHasNonDigits(TxtPhone.Text) Then
            ShowAppMessage(" حقل رقم الهاتف لا يقبل أحرف", AppMessageType.Warning)
            TxtPhone.Focus()
            Return False
        End If

        If Not IsValidEmail(TxtEmail.Text) Then
            ShowAppMessage(" الرجاء إدخال بريد إلكتروني بصيغة صحيحة", AppMessageType.Warning)
            TxtEmail.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ClearForm()
        DietitianID = 0
        TxtName.Clear()
        TxtPhone.Clear()
        TxtCertification.Clear()
        TxtSpecialization.Clear()
        DtJoinDate.Value = Date.Today
        DtpBirthDate.Value = Date.Today
        TxtEmail.Clear()
        Try
            GridDietitians.ClearSelection()
        Catch
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearForm()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        TxtSearch.Clear()
        GetDietitians()
        ClearForm()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        GetDietitians(TxtSearch.Text)
    End Sub

    Private Sub GridDietitians_Click(sender As Object, e As EventArgs) Handles GridDietitians.Click
        Try
            If GridDietitians.CurrentRow Is Nothing Then Return
            CR = GridDietitians.CurrentRow.Index

            Dim idObj = GridDietitians.Item(0, CR).Value
            If idObj Is Nothing OrElse IsDBNull(idObj) Then Return
            DietitianID = Convert.ToInt32(idObj)

            TxtName.Text = If(GridDietitians.Item(1, CR).Value, "").ToString()
            TxtPhone.Text = If(GridDietitians.Item(2, CR).Value, "").ToString()
            TxtCertification.Text = If(GridDietitians.Item(3, CR).Value, "").ToString()
            TxtSpecialization.Text = If(GridDietitians.Item(4, CR).Value, "").ToString()

            Try
                Dim dtBirth As New DataTable()
                Using cmd As New SqlCommand("SELECT birthdate, joineDate, UserID, UserEmail FROM Dietitians LEFT JOIN UserTable ON Dietitians.UserID = UserTable.UserID WHERE DietitianID=@Id", con)
                    cmd.Parameters.AddWithValue("@Id", DietitianID)
                    If con.State = ConnectionState.Open Then con.Close()
                    con.Open()
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dtBirth)
                    End Using
                    con.Close()
                End Using

                If dtBirth.Rows.Count > 0 Then
                    Dim bdObj = dtBirth.Rows(0)("birthdate")
                    If bdObj IsNot Nothing AndAlso Not IsDBNull(bdObj) Then
                        DtpBirthDate.Value = Convert.ToDateTime(bdObj)
                    Else
                        DtpBirthDate.Value = Date.Today
                    End If

                    Dim jdObj = dtBirth.Rows(0)("joineDate")
                    If jdObj IsNot Nothing AndAlso Not IsDBNull(jdObj) Then
                        DtJoinDate.Value = Convert.ToDateTime(jdObj)
                    Else
                        DtJoinDate.Value = Date.Today
                    End If

                    Dim emailObj = dtBirth.Rows(0)("UserEmail")
                    TxtEmail.Text = If(emailObj Is Nothing OrElse IsDBNull(emailObj), "", emailObj.ToString())
                End If
            Catch
            End Try

        Catch
        End Try
    End Sub

    Private Function NormalizePersonName(value As String) As String
        If value Is Nothing Then Return String.Empty

        Dim s As String = value.Trim()
        If s = "" Then Return ""

        Dim sb As New System.Text.StringBuilder(s.Length)
        Dim prevWasSpace As Boolean = False

        For Each ch As Char In s
            Dim isSpace As Boolean = Char.IsWhiteSpace(ch)
            If isSpace Then
                If Not prevWasSpace Then
                    sb.Append(" "c)
                    prevWasSpace = True
                End If
            Else
                sb.Append(ch)
                prevWasSpace = False
            End If
        Next

        Return sb.ToString()
    End Function

    Private Function DietitianNameExists(normalizedName As String, Optional excludeId As Integer = 0) As Boolean
        If String.IsNullOrWhiteSpace(normalizedName) Then Return False

        Try
            Dim dt As New DataTable()
            Using cmd As New SqlCommand("SELECT DietitianID, Name FROM Dietitians", con)
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
                con.Close()
            End Using

            For Each r As DataRow In dt.Rows
                Dim id As Integer = 0
                Try
                    id = Convert.ToInt32(r("DietitianID"))
                Catch
                End Try

                If excludeId <> 0 AndAlso id = excludeId Then
                    Continue For
                End If

                Dim dbName As String = NormalizePersonName(If(r("Name"), "").ToString())
                If String.Equals(dbName, normalizedName, StringComparison.OrdinalIgnoreCase) Then
                    Return True
                End If
            Next

            Return False

        Catch
            If con.State = ConnectionState.Open Then con.Close()
            Return False
        End Try
    End Function

    Private Function EnsureDietitiansUserColumn() As Boolean
        Try
            Dim dt As New DataTable()
            Using cmd As New SqlCommand(
                "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Dietitians' AND COLUMN_NAME = 'UserID'", con)

                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                dt.Load(cmd.ExecuteReader())
                con.Close()
            End Using

            If dt.Rows.Count = 0 Then Return False
            Dim cnt As Integer = Convert.ToInt32(dt.Rows(0)(0))
            Return cnt > 0
        Catch
            If con.State = ConnectionState.Open Then con.Close()
            Return False
        End Try
    End Function

    Private Function CreateDietitianUser(tx As SqlTransaction, normalizedName As String) As Integer
        Dim newUserId As Integer

        Dim sql As String =
            "INSERT INTO UserTable (UserName, UserPass, Userjob, UserEmail, UserPhone, UserPic, LockedOut, RoleID) " &
            "VALUES (@UserName, @UserPass, @Userjob, @UserEmail, @UserPhone, @UserPic, @LockedOut, @RoleID); " &
            "SELECT CAST(SCOPE_IDENTITY() AS int);"

        Using cmd As New SqlCommand(sql, con, tx)
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 100).Value = normalizedName
            cmd.Parameters.Add("@UserPass", SqlDbType.NVarChar, 50).Value = GetDefaultDietitianPassword()
            cmd.Parameters.Add("@Userjob", SqlDbType.NVarChar, 100).Value = "أخصائي تغذية"

            If String.IsNullOrWhiteSpace(TxtEmail.Text) Then
                cmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar, 100).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar, 100).Value = TxtEmail.Text.Trim()
            End If

            If String.IsNullOrWhiteSpace(TxtPhone.Text) Then
                cmd.Parameters.Add("@UserPhone", SqlDbType.BigInt).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@UserPhone", SqlDbType.BigInt).Value = CLng(Val(TxtPhone.Text.Trim()))
            End If

            cmd.Parameters.Add("@UserPic", SqlDbType.Image).Value = DBNull.Value
            cmd.Parameters.Add("@LockedOut", SqlDbType.Bit).Value = False
            cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = 4

            newUserId = CInt(cmd.ExecuteScalar())
        End Using

        Return newUserId
    End Function

    Private Function GetDietitianUserId(dietitianId As Integer) As Integer
        If dietitianId <= 0 Then Return 0

        Try
            Using cmd As New SqlCommand("SELECT UserID FROM Dietitians WHERE DietitianID=@Id", con)
                cmd.Parameters.AddWithValue("@Id", dietitianId)
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim obj = cmd.ExecuteScalar()
                con.Close()
                If obj Is Nothing OrElse IsDBNull(obj) Then Return 0
                Return Convert.ToInt32(obj)
            End Using
        Catch
            If con.State = ConnectionState.Open Then con.Close()
            Return 0
        End Try
    End Function

    Private Sub UpdateDietitianUser(tx As SqlTransaction, userId As Integer, normalizedName As String)
        If userId <= 0 Then Return

        Using cmd As New SqlCommand("UPDATE UserTable SET UserName=@UserName, UserPhone=@UserPhone, UserEmail=@UserEmail WHERE UserID=@UserID", con, tx)
            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userId
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 100).Value = normalizedName

            If String.IsNullOrWhiteSpace(TxtPhone.Text) Then
                cmd.Parameters.Add("@UserPhone", SqlDbType.BigInt).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@UserPhone", SqlDbType.BigInt).Value = CLng(Val(TxtPhone.Text.Trim()))
            End If

            If String.IsNullOrWhiteSpace(TxtEmail.Text) Then
                cmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar, 100).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar, 100).Value = TxtEmail.Text.Trim()
            End If

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub LockDietitianUser(tx As SqlTransaction, userId As Integer)
        If userId <= 0 Then Return

        Using cmd As New SqlCommand("UPDATE UserTable SET LockedOut=1 WHERE UserID=@UserID", con, tx)
            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userId
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If DietitianID <> 0 Then
            ShowAppMessage("تم تحديد أخصائي من الجدول. اضغط (تفريغ) لإضافة سجل جديد", AppMessageType.Warning)
            Return
        End If

        If Not ValidateInputs() Then Exit Sub

        Dim normalizedName As String = NormalizePersonName(TxtName.Text)
        If DietitianNameExists(normalizedName) Then
            ShowAppMessage("هذا الاسم موجود مسبقاً", AppMessageType.Warning)
            TxtName.Focus()
            Return
        End If

        If Not EnsureDietitiansUserColumn() Then
            ShowAppMessage("جدول Dietitians لا يحتوي عمود UserID. أضف العمود أولاً ثم أعد المحاولة.", AppMessageType.Warning)
            Return
        End If

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim tx = con.BeginTransaction()

            Try
                Dim newUserId As Integer = CreateDietitianUser(tx, normalizedName)

                Const sql As String = "INSERT INTO Dietitians (Name, phoneNumber, certification, joineDate, birthdate, Specialization, UserID) VALUES (@Name, @Phone, @Cert, @JoinDate, @BirthDate, @Spec, @UserID)"
                Using cmd As New SqlCommand(sql, con, tx)
                    cmd.Parameters.AddWithValue("@Name", normalizedName)
                    cmd.Parameters.AddWithValue("@Phone", If(String.IsNullOrWhiteSpace(TxtPhone.Text), CType(DBNull.Value, Object), TxtPhone.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Cert", If(String.IsNullOrWhiteSpace(TxtCertification.Text), CType(DBNull.Value, Object), TxtCertification.Text.Trim()))
                    cmd.Parameters.AddWithValue("@JoinDate", DtJoinDate.Value.Date)
                    cmd.Parameters.AddWithValue("@BirthDate", DtpBirthDate.Value.Date)
                    cmd.Parameters.AddWithValue("@Spec", If(String.IsNullOrWhiteSpace(TxtSpecialization.Text), CType(DBNull.Value, Object), TxtSpecialization.Text.Trim()))
                    cmd.Parameters.AddWithValue("@UserID", newUserId)
                    cmd.ExecuteNonQuery()
                End Using

                tx.Commit()
                con.Close()

                ShowAppMessage("تمت إضافة أخصائي التغذية كمستخدم بنجاح.", AppMessageType.Success)
                GetDietitians(TxtSearch.Text)
                ClearForm()

            Catch ex As Exception
                Try
                    tx.Rollback()
                Catch
                End Try
                Throw
            End Try

        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            ShowAppMessage("خطأ أثناء الإضافة: " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If DietitianID = 0 Then
            ShowAppMessage("اختر أخصائي من الجدول أولاً", AppMessageType.Warning)
            Exit Sub
        End If
        If Not ValidateInputs() Then Exit Sub

        Dim normalizedName As String = NormalizePersonName(TxtName.Text)
        If DietitianNameExists(normalizedName, DietitianID) Then
            ShowAppMessage("لا يمكن التعديل: هذا الاسم موجود مسبقاً لأخصائي آخر", AppMessageType.Warning)
            TxtName.Focus()
            Return
        End If

        Try
            If Not EnsureDietitiansUserColumn() Then
                ShowAppMessage("جدول Dietitians لا يحتوي عمود UserID. أضف العمود أولاً.", AppMessageType.Warning)
                Return
            End If

            Dim userId As Integer = GetDietitianUserId(DietitianID)

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim tx = con.BeginTransaction()

            Try
                Const sql As String = "UPDATE Dietitians SET Name=@Name, phoneNumber=@Phone, certification=@Cert, joineDate=@JoinDate, birthdate=@BirthDate, Specialization=@Spec WHERE DietitianID=@Id"

                Using cmd As New SqlCommand(sql, con, tx)
                    cmd.Parameters.AddWithValue("@Id", DietitianID)
                    cmd.Parameters.AddWithValue("@Name", normalizedName)
                    cmd.Parameters.AddWithValue("@Phone", If(String.IsNullOrWhiteSpace(TxtPhone.Text), CType(DBNull.Value, Object), TxtPhone.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Cert", If(String.IsNullOrWhiteSpace(TxtCertification.Text), CType(DBNull.Value, Object), TxtCertification.Text.Trim()))
                    cmd.Parameters.AddWithValue("@JoinDate", DtJoinDate.Value.Date)
                    cmd.Parameters.AddWithValue("@BirthDate", DtpBirthDate.Value.Date)
                    cmd.Parameters.AddWithValue("@Spec", If(String.IsNullOrWhiteSpace(TxtSpecialization.Text), CType(DBNull.Value, Object), TxtSpecialization.Text.Trim()))
                    cmd.ExecuteNonQuery()
                End Using

                UpdateDietitianUser(tx, userId, normalizedName)

                tx.Commit()
                con.Close()

                ShowAppMessage("تم التعديل بنجاح", AppMessageType.Success)
                GetDietitians(TxtSearch.Text)

            Catch ex As Exception
                Try
                    tx.Rollback()
                Catch
                End Try
                Throw
            End Try

        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            ShowAppMessage("خطأ أثناء التعديل " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DietitianID = 0 Then
            ShowAppMessage("اختر أخصائي من الجدول أولاً", AppMessageType.Warning)
            Exit Sub
        End If

        If MessageBox.Show("هل أنت متأكد من حذف هذا الأخصائي؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        Try

            Dim userId As Integer = GetDietitianUserId(DietitianID)

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim tx = con.BeginTransaction()

            Try
                Const sql As String = "DELETE FROM Dietitians WHERE DietitianID=@Id"
                Using cmd As New SqlCommand(sql, con, tx)
                    cmd.Parameters.AddWithValue("@Id", DietitianID)
                    cmd.ExecuteNonQuery()
                End Using

                LockDietitianUser(tx, userId)

                tx.Commit()
                con.Close()

                ShowAppMessage("تم الحذف بنجاح", AppMessageType.Success)
                GetDietitians(TxtSearch.Text)
                ClearForm()

            Catch ex As Exception
                Try
                    tx.Rollback()
                Catch
                End Try
                Throw
            End Try

        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            ShowAppMessage("خطأ أثناء الحذف " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

End Class