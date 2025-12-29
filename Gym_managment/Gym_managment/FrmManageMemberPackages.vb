Imports Microsoft.Data.SqlClient

Public Class FrmManageMemberPackages

    Private DTSubs As New DataTable

    Private Sub FrmManageMemberPackages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_MemberSubscriptions()
    End Sub

    Public Sub Load_MemberSubscriptions(Optional filter As String = "")
        DGVProduct.Rows.Clear()
        DTSubs.Clear()

        Try
            SQLQuery = "SELECT  MS.SubscriptionID,
                                MS.MemberID,
                                M.Name       AS MemberName,
                                MS.PackageID,
                                P.PackageName,
                                MS.StartDate,
                                MS.EndDate,
                                MS.SubscriptionStatus,
                                MS.TrainerID,
                                T.Name       AS TrainerName,
                                MS.UserID
                        FROM MemberSubscriptions MS
                        INNER JOIN Members M
                            ON MS.MemberID = M.MemberID
                        INNER JOIN SubscriptionPackages P
                            ON MS.PackageID = P.PackageID
                        LEFT JOIN Trainers T
                            ON MS.TrainerID = T.TrainerID"

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            DA = New SqlDataAdapter(SQLQuery, con)
            DA.Fill(DTSubs)
            con.Close()

            Dim rows = DTSubs.Select().AsEnumerable()

            If Not String.IsNullOrWhiteSpace(filter) Then
                Dim f = filter.Trim().ToLower()
                rows = rows.Where(Function(r) _
                    r("MemberName").ToString().ToLower().Contains(f) OrElse
                    r("PackageName").ToString().ToLower().Contains(f) OrElse
                    r("TrainerName").ToString().ToLower().Contains(f)
                ).ToArray()
            End If

            For Each r In rows
                Dim i As Integer = DGVProduct.Rows.Add()
                DGVProduct.Item("Column0", i).Value = r("SubscriptionID")   ' رقم اشتراك العضو
                DGVProduct.Item("Column1", i).Value = r("MemberID")        ' رقم العضو
                DGVProduct.Item("Column8", i).Value = r("MemberName")      ' اسم العضو
                DGVProduct.Item("Column2", i).Value = r("PackageID")       ' رقم الباقة
                DGVProduct.Item("Column3", i).Value = r("PackageName")     ' اسم الباقة
                DGVProduct.Item("Column9", i).Value = r("StartDate")       ' تاريخ البداية
                DGVProduct.Item("Column10", i).Value = r("EndDate")        ' تاريخ النهاية
                DGVProduct.Item("Column11", i).Value = r("SubscriptionStatus") ' حالة اشتراك العضو
                DGVProduct.Item("Column12", i).Value = r("TrainerID")      ' رقم المدرب
                DGVProduct.Item("Column13", i).Value = r("TrainerName")    ' اسم المدرب
                DGVProduct.Item("Column4", i).Value = r("UserID")          ' رقم المستخدم
            Next

        Catch ex As Exception
            ShowAppMessage("خطأ في تحميل اشتراكات الأعضاء: " & ex.Message, AppMessageType.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Load_MemberSubscriptions(TxtSearch.Text)
    End Sub

    Private Sub DGVProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProduct.CellContentClick
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = DGVProduct.Columns("Column11").Index Then
            EditSubscription(e.RowIndex)

        ElseIf e.ColumnIndex = DGVProduct.Columns("Column12").Index Then
            DeleteSubscription(e.RowIndex)
        End If
    End Sub

    'Private Sub BtnDetails_Click(sender As Object, e As EventArgs) Handles BtnDetails.Click
    '    If DGVProduct.CurrentRow Is Nothing Then
    '        ShowAppMessage("اختر اشتراكاً من الجدول أولاً", AppMessageType.Warning)
    '        Return
    '    End If

    '    EditSubscription(DGVProduct.CurrentRow.Index)
    'End Sub

    Private Sub EditSubscription(rowIndex As Integer)
        Dim row = DGVProduct.Rows(rowIndex)

        Dim subscriptionId As Integer = CInt(row.Cells("Column0").Value)
        Dim memberId As Integer = CInt(row.Cells("Column1").Value)
        Dim memberName As String = row.Cells("Column8").Value.ToString()
        Dim packageId As Integer = CInt(row.Cells("Column2").Value)
        Dim packageName As String = row.Cells("Column3").Value.ToString()
        Dim startDate As Date = CDate(row.Cells("Column9").Value)
        Dim endDate As Date = CDate(row.Cells("Column10").Value)
        Dim status As String = row.Cells("Column11").Value.ToString()
        Dim trainerId As Integer = If(IsDBNull(row.Cells("Column12").Value), 0, CInt(row.Cells("Column12").Value))
        Dim trainerName As String = row.Cells("Column13").Value.ToString()

        Dim msg As String =
            "رقم الاشتراك: " & subscriptionId & Environment.NewLine &
            "العضو: " & memberName & " (" & memberId & ")" & Environment.NewLine &
            "الباقة: " & packageName & " (" & packageId & ")" & Environment.NewLine &
            "من: " & startDate.ToShortDateString() & " إلى: " & endDate.ToShortDateString() & Environment.NewLine &
            "الحالة: " & status & Environment.NewLine &
            "المدرب: " & trainerName & " (" & trainerId & ")"

        ShowAppMessage(msg, AppMessageType.Success)

        ' With FrmEditMemberSubscription
        '     .SubscriptionID = subscriptionId
        '     .LoadDetails()
        '     .ShowDialog()
        ' End With

    End Sub

    Private Sub DeleteSubscription(rowIndex As Integer)
        Dim row = DGVProduct.Rows(rowIndex)
        Dim subscriptionId As Integer = CInt(row.Cells("Column0").Value)
        Dim memberName As String = row.Cells("Column8").Value.ToString()
        Dim packageName As String = row.Cells("Column3").Value.ToString()

        Dim q = "هل أنت متأكد من حذف اشتراك """ & memberName & """ في باقة """ & packageName & """ ؟"
        If MessageBox.Show(q, "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = DialogResult.Yes Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()

                Using cmd As New SqlCommand("DELETE FROM MemberSubscriptions WHERE SubscriptionID = @id", con)
                    cmd.Parameters.AddWithValue("@id", subscriptionId)
                    cmd.ExecuteNonQuery()
                End Using

                con.Close()
                ShowAppMessage("تم حذف الاشتراك بنجاح", AppMessageType.Success)
                Load_MemberSubscriptions(TxtSearch.Text)

            Catch ex As Exception
                ShowAppMessage("خطأ في حذف الاشتراك: " & ex.Message, AppMessageType.Error)
            Finally
                If con.State = ConnectionState.Open Then con.Close()
            End Try
        End If
    End Sub

    Private Sub BtnAddMemberSubscription_Click(sender As Object, e As EventArgs) Handles BtnAddMemberSubscription.Click
        FrmAddSubscriptionMember.ShowDialog()

    End Sub
End Class