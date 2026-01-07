Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmDietPlans


    Private CR As Integer
        Private PlanId As Integer
        Private ReadOnly DTPlans As New DataTable()

        Private ReadOnly Property CurrentDietitianId As Integer
            Get
                Try
                    If UserID <= 0 Then Return 0
                    Using cmd As New SqlCommand("SELECT TOP 1 DietitianID FROM Dietitians WHERE UserID=@uid", con)
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
            End Get
        End Property

        Private Sub FrmDietPlans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            GridPlans.AutoGenerateColumns = False
            ClearForm()
            GetPlans()
        End Sub

        Private Sub GetPlans(Optional filter As String = Nothing)
            Try
                DTPlans.Clear()
                GridPlans.Rows.Clear()

                If GridPlans.ColumnCount = 0 Then Return

                Dim sql As String = "SELECT PlanID, PlanName, Goal, CaloriesPerDay, PlanDescription FROM DietPlans"
                Dim hasFilter As Boolean = Not String.IsNullOrWhiteSpace(filter)
                If hasFilter Then
                    sql &= " WHERE (PlanName LIKE @q OR Goal LIKE @q)"
                End If
                sql &= " ORDER BY PlanID DESC"

                Using cmd As New SqlCommand(sql, con)
                    If hasFilter Then
                        cmd.Parameters.Add("@q", SqlDbType.NVarChar, 200).Value = "%" & filter.Trim() & "%"
                    End If

                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(DTPlans)
                    End Using
                End Using

                For i As Integer = 0 To DTPlans.Rows.Count - 1
                    GridPlans.Rows.Add()
                    GridPlans.Item(0, i).Value = DTPlans.Rows(i)("PlanID")
                    GridPlans.Item(1, i).Value = DTPlans.Rows(i)("PlanName")
                    GridPlans.Item(2, i).Value = If(DTPlans.Rows(i)("Goal"), "").ToString()
                    GridPlans.Item(3, i).Value = If(IsDBNull(DTPlans.Rows(i)("CaloriesPerDay")), "", DTPlans.Rows(i)("CaloriesPerDay").ToString())
                Next

            Catch ex As Exception
                ShowAppMessage("خطأ في جلب خطط التغذية: " & ex.Message, AppMessageType.Error)
            Finally
                If con.State = ConnectionState.Open Then con.Close()
            End Try
        End Sub

        Private Sub ClearForm()
            PlanId = 0
            TxtName.Clear()
            TxtGoal.Clear()
            TxtCalories.Clear()
            TxtDescription.Clear()
            Try
                GridPlans.ClearSelection()
            Catch
            End Try
        End Sub

        Private Function ValidateInputs() As Boolean
            If String.IsNullOrWhiteSpace(TxtName.Text) Then
                ShowAppMessage("يرجى إدخال اسم الخطة", AppMessageType.Warning)
                TxtName.Focus()
                Return False
            End If

            If Not String.IsNullOrWhiteSpace(TxtCalories.Text) Then
                Dim cal As Integer
                If Not Integer.TryParse(TxtCalories.Text.Trim(), cal) Then
                    ShowAppMessage("السعرات يجب أن تكون رقم صحيح", AppMessageType.Warning)
                    TxtCalories.Focus()
                    Return False
                End If
            End If

            Return True
        End Function

        Private Sub GridPlans_Click(sender As Object, e As EventArgs) Handles GridPlans.Click
            Try
                If GridPlans.CurrentRow Is Nothing Then Return
                CR = GridPlans.CurrentRow.Index
                Dim idObj = GridPlans.Item(0, CR).Value
                If idObj Is Nothing OrElse IsDBNull(idObj) Then Return
                PlanId = Convert.ToInt32(idObj)

                TxtName.Text = If(GridPlans.Item(1, CR).Value, "").ToString()
                TxtGoal.Text = If(GridPlans.Item(2, CR).Value, "").ToString()
                TxtCalories.Text = If(GridPlans.Item(3, CR).Value, "").ToString()

                ' load description
                Try
                    Using cmd As New SqlCommand("SELECT PlanDescription FROM DietPlans WHERE PlanID=@id", con)
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = PlanId
                        If con.State = ConnectionState.Open Then con.Close()
                        con.Open()
                        Dim o = cmd.ExecuteScalar()
                        con.Close()
                        TxtDescription.Text = If(o Is Nothing OrElse o Is DBNull.Value, "", o.ToString())
                    End Using
                Catch
                    If con.State = ConnectionState.Open Then con.Close()
                End Try

            Catch
            End Try
        End Sub

        Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
            GetPlans(TxtSearch.Text)
        End Sub

        Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
            TxtSearch.Clear()
            GetPlans()
            ClearForm()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            ClearForm()
        End Sub

        Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
            If PlanId <> 0 Then
                ShowAppMessage("تم تحديد خطة من الجدول. اضغط تفريغ لإضافة خطة جديدة", AppMessageType.Warning)
                Return
            End If
            If Not ValidateInputs() Then Return

            Dim did As Integer = CurrentDietitianId
            If did <= 0 Then
                ShowAppMessage("تعذر تحديد أخصائي التغذية الحالي.", AppMessageType.Error)
                Return
            End If

            Try
                Const sql As String = "INSERT INTO DietPlans (PlanName, Goal, PlanDescription, CaloriesPerDay, CreatedByDietitianID) VALUES (@n,@g,@d,@c,@did)"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.Add("@n", SqlDbType.NVarChar, 100).Value = TxtName.Text.Trim()
                    cmd.Parameters.Add("@g", SqlDbType.NVarChar, 50).Value = If(String.IsNullOrWhiteSpace(TxtGoal.Text), CType(DBNull.Value, Object), TxtGoal.Text.Trim())
                    cmd.Parameters.Add("@d", SqlDbType.NVarChar).Value = If(String.IsNullOrWhiteSpace(TxtDescription.Text), CType(DBNull.Value, Object), TxtDescription.Text.Trim())

                    If String.IsNullOrWhiteSpace(TxtCalories.Text) Then
                        cmd.Parameters.Add("@c", SqlDbType.Int).Value = DBNull.Value
                    Else
                        cmd.Parameters.Add("@c", SqlDbType.Int).Value = Integer.Parse(TxtCalories.Text.Trim())
                    End If

                    cmd.Parameters.Add("@did", SqlDbType.Int).Value = did

                    If con.State = ConnectionState.Open Then con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using

                ShowAppMessage("تمت إضافة الخطة بنجاح", AppMessageType.Success)
                GetPlans(TxtSearch.Text)
                ClearForm()

            Catch ex As Exception
                If con.State = ConnectionState.Open Then con.Close()
                ShowAppMessage("خطأ أثناء الإضافة: " & ex.Message, AppMessageType.Error)
            End Try
        End Sub

        Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
            If PlanId = 0 Then
                ShowAppMessage("اختر خطة من الجدول أولاً", AppMessageType.Warning)
                Return
            End If
            If Not ValidateInputs() Then Return

            Try
                Const sql As String = "UPDATE DietPlans SET PlanName=@n, Goal=@g, PlanDescription=@d, CaloriesPerDay=@c WHERE PlanID=@id"
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = PlanId
                    cmd.Parameters.Add("@n", SqlDbType.NVarChar, 100).Value = TxtName.Text.Trim()
                    cmd.Parameters.Add("@g", SqlDbType.NVarChar, 50).Value = If(String.IsNullOrWhiteSpace(TxtGoal.Text), CType(DBNull.Value, Object), TxtGoal.Text.Trim())
                    cmd.Parameters.Add("@d", SqlDbType.NVarChar).Value = If(String.IsNullOrWhiteSpace(TxtDescription.Text), CType(DBNull.Value, Object), TxtDescription.Text.Trim())

                    If String.IsNullOrWhiteSpace(TxtCalories.Text) Then
                        cmd.Parameters.Add("@c", SqlDbType.Int).Value = DBNull.Value
                    Else
                        cmd.Parameters.Add("@c", SqlDbType.Int).Value = Integer.Parse(TxtCalories.Text.Trim())
                    End If

                    If con.State = ConnectionState.Open Then con.Close()
                    con.Open()
                    Dim rows = cmd.ExecuteNonQuery()
                    con.Close()

                    If rows > 0 Then
                        ShowAppMessage("تم التعديل بنجاح", AppMessageType.Success)
                    Else
                        ShowAppMessage("لم يتم العثور على السجل", AppMessageType.Warning)
                    End If
                End Using

                GetPlans(TxtSearch.Text)

            Catch ex As Exception
                If con.State = ConnectionState.Open Then con.Close()
                ShowAppMessage("خطأ أثناء التعديل: " & ex.Message, AppMessageType.Error)
            End Try
        End Sub

        Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
            If PlanId = 0 Then
                ShowAppMessage("اختر خطة من الجدول أولاً", AppMessageType.Warning)
                Return
            End If

            If MessageBox.Show("هل أنت متأكد من حذف هذه الخطة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

            Try
                Using cmd As New SqlCommand("DELETE FROM DietPlans WHERE PlanID=@id", con)
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = PlanId
                    If con.State = ConnectionState.Open Then con.Close()
                    con.Open()
                    Dim rows = cmd.ExecuteNonQuery()
                    con.Close()

                    If rows > 0 Then
                        ShowAppMessage("تم الحذف بنجاح", AppMessageType.Success)
                    Else
                        ShowAppMessage("لم يتم العثور على السجل", AppMessageType.Warning)
                    End If
                End Using

                GetPlans(TxtSearch.Text)
                ClearForm()

            Catch ex As Exception
                If con.State = ConnectionState.Open Then con.Close()
                ShowAppMessage("خطأ أثناء الحذف: " & ex.Message, AppMessageType.Error)
            End Try
        End Sub

    End Class

