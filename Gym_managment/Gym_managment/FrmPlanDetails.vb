Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmPlanDetails

    Private CR As Integer
    Private DetailId As Integer
    Private PlanId As Integer
    Private ReadOnly DTDetails As New DataTable()

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

    Private Sub EnsureCombosLoaded()
        If CmbDay.Items.Count = 0 Then
            CmbDay.Items.AddRange(New Object() {"-- اختر اليوم --", "السبت", "الأحد", "الإثنين", "الثلاثاء", "الأربعاء", "الخميس", "الجمعة"})
        End If

        If CmbMealType.Items.Count = 0 Then
            CmbMealType.Items.AddRange(New Object() {"-- اختر نوع الوجبة --", "فطور", "غداء", "سناك", "عشاء"})
        End If

        CmbDay.DropDownStyle = ComboBoxStyle.DropDownList
        CmbMealType.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub LoadPlans()
        Try
            Dim did = CurrentDietitianId
            Dim dt As New DataTable()

            Dim sql As String = "SELECT PlanID, PlanName FROM DietPlans"
            If did > 0 Then
                sql &= " WHERE DietitianID=@did"
            End If
            sql &= " ORDER BY PlanID DESC"

            Using cmd As New SqlCommand(sql, con)
                If did > 0 Then
                    cmd.Parameters.Add("@did", SqlDbType.Int).Value = did
                End If

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            CmbPlan.DisplayMember = "PlanName"
            CmbPlan.ValueMember = "PlanID"
            CmbPlan.DataSource = dt
        Catch
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub FrmPlanDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridDetails.AutoGenerateColumns = False
        EnsureCombosLoaded()
        LoadPlans()

        ' عند فتح الشاشة من الرئيسية: اعرض كل التفاصيل
        PlanId = 0
        ClearForm()
        GetDetails()
    End Sub

    Private Sub GetDetails(Optional filter As String = Nothing)
        Try
            DTDetails.Clear()
            GridDetails.Rows.Clear()

            Dim did = CurrentDietitianId

            Dim sql As String =
                "SELECT D.DetailID, D.DayOfWeek, D.MealType, D.FoodItem, D.Quantity, P.PlanName, D.PlanID " &
                "FROM DietPlanDetails D " &
                "INNER JOIN DietPlans P ON D.PlanID = P.PlanID"

            Dim whereAdded As Boolean = False

            If did > 0 Then
                sql &= " WHERE P.DietitianID=@did"
                whereAdded = True
            End If

            If PlanId > 0 Then
                sql &= If(whereAdded, " AND ", " WHERE ") & " D.PlanID=@pid"
                whereAdded = True
            End If

            Dim hasFilter As Boolean = Not String.IsNullOrWhiteSpace(filter)
            If hasFilter Then
                sql &= If(whereAdded, " AND ", " WHERE ") & " (P.PlanName LIKE @q OR D.DayOfWeek LIKE @q OR D.MealType LIKE @q OR D.FoodItem LIKE @q)"
            End If

            sql &= " ORDER BY D.DetailID DESC"

            Using cmd As New SqlCommand(sql, con)
                If did > 0 Then
                    cmd.Parameters.Add("@did", SqlDbType.Int).Value = did
                End If
                If PlanId > 0 Then
                    cmd.Parameters.Add("@pid", SqlDbType.Int).Value = PlanId
                End If
                If hasFilter Then
                    cmd.Parameters.Add("@q", SqlDbType.NVarChar, 300).Value = "%" & filter.Trim() & "%"
                End If

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(DTDetails)
                End Using
            End Using

            For i As Integer = 0 To DTDetails.Rows.Count - 1
                GridDetails.Rows.Add()
                GridDetails.Item(0, i).Value = DTDetails.Rows(i)("DetailID")
                GridDetails.Item(1, i).Value = If(DTDetails.Rows(i)("DayOfWeek"), "").ToString()
                GridDetails.Item(2, i).Value = If(DTDetails.Rows(i)("MealType"), "").ToString()
                GridDetails.Item(3, i).Value = If(DTDetails.Rows(i)("FoodItem"), "").ToString()
                GridDetails.Item(4, i).Value = If(DTDetails.Rows(i)("Quantity"), "").ToString()
            Next

        Catch ex As Exception
            ShowAppMessage("خطأ في جلب تفاصيل الخطة: " & ex.Message, AppMessageType.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub ClearForm()
        DetailId = 0

        ' لا تغيّر الخطة المختارة هنا

        If CmbDay.Items IsNot Nothing AndAlso CmbDay.Items.Count > 0 Then
            CmbDay.SelectedIndex = 0
        Else
            CmbDay.SelectedIndex = -1
        End If

        If CmbMealType.Items IsNot Nothing AndAlso CmbMealType.Items.Count > 0 Then
            CmbMealType.SelectedIndex = 0
        Else
            CmbMealType.SelectedIndex = -1
        End If

        TxtFoodItem.Clear()
        TxtQuantity.Clear()
        Try
            GridDetails.ClearSelection()
        Catch
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        If PlanId <= 0 Then
            ShowAppMessage("لم يتم تحديد الخطة.", AppMessageType.Warning)
            Return False
        End If

        If CmbDay.SelectedIndex < 0 OrElse (CmbDay.Items.Count > 0 AndAlso CmbDay.SelectedIndex = 0 AndAlso CmbDay.Items(0).ToString().Contains("اختر")) Then
            ShowAppMessage("يرجى اختيار اليوم", AppMessageType.Warning)
            Return False
        End If

        If CmbMealType.SelectedIndex < 0 OrElse (CmbMealType.Items.Count > 0 AndAlso CmbMealType.SelectedIndex = 0 AndAlso CmbMealType.Items(0).ToString().Contains("اختر")) Then
            ShowAppMessage("يرجى اختيار نوع الوجبة", AppMessageType.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtFoodItem.Text) Then
            ShowAppMessage("يرجى إدخال صنف الطعام", AppMessageType.Warning)
            TxtFoodItem.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GridDetails_Click(sender As Object, e As EventArgs) Handles GridDetails.Click
        Try
            If GridDetails.CurrentRow Is Nothing Then Return
            CR = GridDetails.CurrentRow.Index

            Dim idObj = GridDetails.Item(0, CR).Value
            If idObj Is Nothing OrElse IsDBNull(idObj) Then Return
            DetailId = Convert.ToInt32(idObj)

            ' PlanID من الصف (مهم للتعديل/الحذف عند عرض كل التفاصيل)
            Try
                Dim pidObj = DTDetails.Rows(CR)("PlanID")
                If pidObj IsNot Nothing AndAlso Not IsDBNull(pidObj) Then
                    PlanId = Convert.ToInt32(pidObj)
                    Try
                        If CmbPlan.DataSource IsNot Nothing Then
                            CmbPlan.SelectedValue = PlanId
                        End If
                    Catch
                    End Try
                End If
            Catch
            End Try

            CmbDay.SelectedItem = If(GridDetails.Item(1, CR).Value, "").ToString()
            CmbMealType.SelectedItem = If(GridDetails.Item(2, CR).Value, "").ToString()
            TxtFoodItem.Text = If(GridDetails.Item(3, CR).Value, "").ToString()
            TxtQuantity.Text = If(GridDetails.Item(4, CR).Value, "").ToString()
        Catch
        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        GetDetails(TxtSearch.Text)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        TxtSearch.Clear()
        GetDetails()
        ' لا تصفّر الخطة عند التحديث
        ClearForm()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearForm()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If DetailId <> 0 Then
            ShowAppMessage("تم تحديد سجل من الجدول. اضغط تفريغ لإضافة سجل جديد", AppMessageType.Warning)
            Return
        End If
        If Not ValidateInputs() Then Return

        Try
            Const sql As String = "INSERT INTO DietPlanDetails (PlanID, DayOfWeek, MealType, FoodItem, Quantity) VALUES (@pid,@day,@meal,@food,@qty)"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.Add("@pid", SqlDbType.Int).Value = PlanId
                cmd.Parameters.Add("@day", SqlDbType.NVarChar, 20).Value = CmbDay.SelectedItem.ToString()
                cmd.Parameters.Add("@meal", SqlDbType.NVarChar, 50).Value = CmbMealType.SelectedItem.ToString()
                cmd.Parameters.Add("@food", SqlDbType.NVarChar, 255).Value = TxtFoodItem.Text.Trim()
                cmd.Parameters.Add("@qty", SqlDbType.NVarChar, 100).Value = If(String.IsNullOrWhiteSpace(TxtQuantity.Text), CType(DBNull.Value, Object), TxtQuantity.Text.Trim())

                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            ShowAppMessage("تمت الإضافة بنجاح", AppMessageType.Success)
            GetDetails(TxtSearch.Text)
            ClearForm()

        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            ShowAppMessage("خطأ أثناء الإضافة: " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If DetailId = 0 Then
            ShowAppMessage("اختر سطر من الجدول أولاً", AppMessageType.Warning)
            Return
        End If
        If Not ValidateInputs() Then Return

        Try
            Const sql As String = "UPDATE DietPlanDetails SET DayOfWeek=@day, MealType=@meal, FoodItem=@food, Quantity=@qty WHERE DetailID=@id AND PlanID=@pid"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = DetailId
                cmd.Parameters.Add("@pid", SqlDbType.Int).Value = PlanId
                cmd.Parameters.Add("@day", SqlDbType.NVarChar, 20).Value = CmbDay.SelectedItem.ToString()
                cmd.Parameters.Add("@meal", SqlDbType.NVarChar, 50).Value = CmbMealType.SelectedItem.ToString()
                cmd.Parameters.Add("@food", SqlDbType.NVarChar, 255).Value = TxtFoodItem.Text.Trim()
                cmd.Parameters.Add("@qty", SqlDbType.NVarChar, 100).Value = If(String.IsNullOrWhiteSpace(TxtQuantity.Text), CType(DBNull.Value, Object), TxtQuantity.Text.Trim())

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

            GetDetails(TxtSearch.Text)

        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            ShowAppMessage("خطأ أثناء التعديل: " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DetailId = 0 Then
            ShowAppMessage("اختر سطر من الجدول أولاً", AppMessageType.Warning)
            Return
        End If

        If MessageBox.Show("هل أنت متأكد من حذف هذا السطر؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Try
            Using cmd As New SqlCommand("DELETE FROM DietPlanDetails WHERE DetailID=@id AND PlanID=@pid", con)
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = DetailId
                cmd.Parameters.Add("@pid", SqlDbType.Int).Value = PlanId

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

            GetDetails(TxtSearch.Text)
            ClearForm()

        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            ShowAppMessage("خطأ أثناء الحذف: " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub CmbPlan_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbPlan.SelectionChangeCommitted
        Try
            If CmbPlan.SelectedValue Is Nothing Then
                PlanId = 0
            Else
                PlanId = Convert.ToInt32(CmbPlan.SelectedValue)
            End If
            GetDetails(TxtSearch.Text)
            ' تفريغ الحقول فقط بدون لمس الخطة
            DetailId = 0
            If CmbDay.Items.Count > 0 Then CmbDay.SelectedIndex = 0
            If CmbMealType.Items.Count > 0 Then CmbMealType.SelectedIndex = 0
            TxtFoodItem.Clear()
            TxtQuantity.Clear()
            Try
                GridDetails.ClearSelection()
            Catch
            End Try
        Catch
        End Try
    End Sub

End Class
