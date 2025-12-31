Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmPayment

    Private DTReceipts As New DataTable()
    Private selectedReceiptId As Integer = 0
    Private selectedSubscriptionId As Integer = 0
    Private selectedPackagePrice As Decimal = 0D
    Private paidBeforeCurrent As Decimal = 0D
    Private isUpdatingAmounts As Boolean = False

    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPaymentMethod.Items.Clear()
        cmbPaymentMethod.Items.AddRange(New Object() {"نقداً", "بطاقة", "تحويل", "أخرى"})
        If cmbPaymentMethod.Items.Count > 0 Then cmbPaymentMethod.SelectedIndex = 0

        dtpReceiptDate.Value = Date.Now

        ConfigureGridIfNeeded()
        ClearForm()
        LoadReceipts()

        ApplyDiscountUiState()
    End Sub

    Private Sub ConfigureGridIfNeeded()
        If dgvReceipts.Columns.Count > 0 Then
            dgvReceipts.AutoGenerateColumns = False
            Return
        End If

        dgvReceipts.AutoGenerateColumns = False

        Dim cId As New DataGridViewTextBoxColumn() With {.Name = "colReceiptId", .HeaderText = "ID", .Visible = False}
        Dim cNo As New DataGridViewTextBoxColumn() With {.Name = "colReceiptNo", .HeaderText = "رقم الإيصال", .Width = 140}
        Dim cReceiptDate As New DataGridViewTextBoxColumn() With {.Name = "colReceiptDate", .HeaderText = "التاريخ", .Width = 170}
        Dim cAmt As New DataGridViewTextBoxColumn() With {.Name = "colAmount", .HeaderText = "المبلغ", .Width = 110}
        Dim cMethod As New DataGridViewTextBoxColumn() With {.Name = "colMethod", .HeaderText = "الطريقة", .Width = 110}
        Dim cSub As New DataGridViewTextBoxColumn() With {.Name = "colSubId", .HeaderText = "SubscriptionID", .Visible = False}
        Dim cNotes As New DataGridViewTextBoxColumn() With {.Name = "colNotes", .HeaderText = "ملاحظات", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill}

        dgvReceipts.Columns.AddRange(New DataGridViewColumn() {cId, cNo, cReceiptDate, cAmt, cMethod, cSub, cNotes})
    End Sub

    Private Sub LoadReceipts(Optional search As String = Nothing)
        If dgvReceipts Is Nothing Then Return

        dgvReceipts.Rows.Clear()
        DTReceipts.Clear()

        Dim sql As String = "SELECT ReceiptID, ReceiptNumber, ReceiptDate, AmountPaid, PaymentMethod, SubscriptionID, Notes FROM PaymentReceipts"
        If Not String.IsNullOrWhiteSpace(search) Then
            sql &= " WHERE ReceiptNumber LIKE @s OR Notes LIKE @s"
        End If
        sql &= " ORDER BY ReceiptID DESC"

        Using cmd As New SqlCommand(sql, con)
            If Not String.IsNullOrWhiteSpace(search) Then
                cmd.Parameters.AddWithValue("@s", "%" & search & "%")
            End If
            Using da As New SqlDataAdapter(cmd)
                da.Fill(DTReceipts)
            End Using
        End Using

        For Each r As DataRow In DTReceipts.Rows
            Dim n As Integer = dgvReceipts.Rows.Add()
            dgvReceipts.Rows(n).Cells("colReceiptId").Value = r("ReceiptID")
            dgvReceipts.Rows(n).Cells("colReceiptNo").Value = r("ReceiptNumber").ToString()

            Dim d As DateTime = Convert.ToDateTime(r("ReceiptDate"))
            dgvReceipts.Rows(n).Cells("colReceiptDate").Value = d.ToString("dd-MM-yyyy HH:mm", Globalization.CultureInfo.InvariantCulture)

            dgvReceipts.Rows(n).Cells("colAmount").Value = Convert.ToDecimal(r("AmountPaid")).ToString("0.00")
            dgvReceipts.Rows(n).Cells("colMethod").Value = r("PaymentMethod").ToString()
            dgvReceipts.Rows(n).Cells("colSubId").Value = r("SubscriptionID")
            dgvReceipts.Rows(n).Cells("colNotes").Value = If(IsDBNull(r("Notes")), "", r("Notes").ToString())
        Next
    End Sub

    Private Function GenerateReceiptNumberFromId(receiptId As Integer, receiptDate As DateTime) As String
        Return $"RC-{receiptDate:yyyyMMdd}-{receiptId.ToString().PadLeft(8, "0"c)}"
    End Function

    Private Sub ClearForm()
        selectedReceiptId = 0
        selectedSubscriptionId = 0
        selectedPackagePrice = 0D
        paidBeforeCurrent = 0D

        txtReceiptNumber.Text = $"RC-{Date.Now:yyyyMMddHHmmss}"
        dtpReceiptDate.Value = Date.Now
        txtAmountPaid.Text = "0.00"
        If cmbPaymentMethod.Items.Count > 0 Then cmbPaymentMethod.SelectedIndex = 0
        txtSubscription.Text = ""
        txtNotes.Text = ""

        If txtPackagePrice IsNot Nothing Then txtPackagePrice.Text = "0.00"
        If TxtDescount IsNot Nothing Then TxtDescount.Text = "0.00"
        If txtRemaining IsNot Nothing Then
            txtRemaining.Text = "0.00"
            txtRemaining.ForeColor = Color.White
        End If

        ApplyDiscountUiState()
    End Sub

    Private Function GetMemberIdBySubscriptionId(subscriptionId As Integer) As Integer
        Using cmd As New SqlCommand("SELECT TOP 1 MemberID FROM MemberSubscriptions WHERE SubscriptionID=@sid", con)
            cmd.Parameters.AddWithValue("@sid", subscriptionId)
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim o = cmd.ExecuteScalar()
            con.Close()
            If o Is Nothing OrElse IsDBNull(o) Then Return 0
            Return CInt(o)
        End Using
    End Function

    Private Function InsertMemberTransaction(memberId As Integer, transDate As DateTime, transType As String, debit As Decimal?, credit As Decimal?, refTable As String, refId As Integer, notes As String) As Integer
        Dim sql As String = "INSERT INTO MemberTransactions (MemberID, TransactionDate, TransactionType, DebitAmount, CreditAmount, ReferenceTable, ReferenceID, Notes, UserID) " &
                            "VALUES (@mid, @dt, @type, @debit, @credit, @rt, @rid, @notes, @u); SELECT CAST(SCOPE_IDENTITY() AS int);"

        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@mid", memberId)
            cmd.Parameters.AddWithValue("@dt", transDate)
            cmd.Parameters.AddWithValue("@type", transType)
            cmd.Parameters.AddWithValue("@debit", If(debit.HasValue, CType(debit.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@credit", If(credit.HasValue, CType(credit.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@rt", If(String.IsNullOrWhiteSpace(refTable), CType(DBNull.Value, Object), refTable))
            cmd.Parameters.AddWithValue("@rid", If(refId > 0, CType(refId, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@notes", If(String.IsNullOrWhiteSpace(notes), CType(DBNull.Value, Object), notes))
            cmd.Parameters.AddWithValue("@u", If(UserID > 0, CType(UserID, Object), DBNull.Value))

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim newId As Integer = CInt(cmd.ExecuteScalar())
            con.Close()
            Return newId
        End Using
    End Function

    Private Sub TryUpdateReceiptMemberTransId(receiptId As Integer, memberTransId As Integer)
        Try
            Using cmd As New SqlCommand("UPDATE PaymentReceipts SET MemberTransID=@mtid WHERE ReceiptID=@rid", con)
                cmd.Parameters.AddWithValue("@mtid", memberTransId)
                cmd.Parameters.AddWithValue("@rid", receiptId)
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        Catch ex As SqlException
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub InsertReceipt(no As String, receiptDate As DateTime, amount As Decimal, method As String, subscriptionId As Integer, notes As String)
        Dim insertSql As String = "INSERT INTO PaymentReceipts (ReceiptNumber, ReceiptDate, AmountPaid, PaymentMethod, SubscriptionID, UserID, Notes) " &
                                  "VALUES (@no, @dt, @amt, @m, @sub, @u, @notes); SELECT CAST(SCOPE_IDENTITY() AS int);"

        Dim newId As Integer

        Using cmd As New SqlCommand(insertSql, con)
            cmd.Parameters.AddWithValue("@no", no)
            cmd.Parameters.AddWithValue("@dt", receiptDate)
            cmd.Parameters.AddWithValue("@amt", amount)
            cmd.Parameters.AddWithValue("@m", method)
            cmd.Parameters.AddWithValue("@sub", subscriptionId)
            cmd.Parameters.AddWithValue("@u", If(UserID > 0, CType(UserID, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@notes", If(String.IsNullOrWhiteSpace(notes), CType(DBNull.Value, Object), notes))

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            newId = CInt(cmd.ExecuteScalar())
            con.Close()
        End Using

        Dim finalNo As String = GenerateReceiptNumberFromId(newId, receiptDate)

        Using cmd2 As New SqlCommand("UPDATE PaymentReceipts SET ReceiptNumber=@no WHERE ReceiptID=@id", con)
            cmd2.Parameters.AddWithValue("@id", newId)
            cmd2.Parameters.AddWithValue("@no", finalNo)

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            cmd2.ExecuteNonQuery()
            con.Close()
        End Using

        Dim memberId As Integer = GetMemberIdBySubscriptionId(subscriptionId)
        If memberId > 0 Then
            Dim mtNotes = If(String.IsNullOrWhiteSpace(notes), $"سداد اشتراك (إيصال {finalNo})", notes)
            Dim memberTransId As Integer = InsertMemberTransaction(memberId, receiptDate, "دفع", Nothing, amount, "PaymentReceipts", newId, mtNotes)
            TryUpdateReceiptMemberTransId(newId, memberTransId)
        End If

        txtReceiptNumber.Text = finalNo
        selectedReceiptId = newId
    End Sub

    Private Sub UpdateReceipt(id As Integer, no As String, receiptDate As DateTime, amount As Decimal, method As String, subscriptionId As Integer, notes As String)
        Dim sql As String = "UPDATE PaymentReceipts SET ReceiptNumber=@no, ReceiptDate=@dt, AmountPaid=@amt, PaymentMethod=@m, SubscriptionID=@sub, UserID=@u, Notes=@notes WHERE ReceiptID=@id"

        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@no", no)
            cmd.Parameters.AddWithValue("@dt", receiptDate)
            cmd.Parameters.AddWithValue("@amt", amount)
            cmd.Parameters.AddWithValue("@m", method)
            cmd.Parameters.AddWithValue("@sub", subscriptionId)
            cmd.Parameters.AddWithValue("@u", If(UserID > 0, CType(UserID, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@notes", If(String.IsNullOrWhiteSpace(notes), CType(DBNull.Value, Object), notes))

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Private Function GetTotalPaidForSubscription(subscriptionId As Integer) As Decimal
        Using cmd As New SqlCommand("SELECT ISNULL(SUM(AmountPaid),0) FROM PaymentReceipts WHERE SubscriptionID=@sid", con)
            cmd.Parameters.AddWithValue("@sid", subscriptionId)
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim v = cmd.ExecuteScalar()
            con.Close()
            If v Is Nothing OrElse IsDBNull(v) Then Return 0D
            Return Convert.ToDecimal(v)
        End Using
    End Function

    Private Function GetCurrentAmountPaidInput() As Decimal
        Dim a As Decimal
        If Decimal.TryParse(txtAmountPaid.Text.Trim(), a) Then
            Return a
        End If
        Return 0D
    End Function

    Private Sub RefreshPaidBefore()
        If selectedSubscriptionId <= 0 Then
            paidBeforeCurrent = 0D
            Return
        End If

        paidBeforeCurrent = GetTotalPaidForSubscription(selectedSubscriptionId)

        If selectedReceiptId > 0 Then
            Dim currentAmount As Decimal = 0D
            Using cmd As New SqlCommand("SELECT ISNULL(AmountPaid,0) FROM PaymentReceipts WHERE ReceiptID=@id", con)
                cmd.Parameters.AddWithValue("@id", selectedReceiptId)
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                currentAmount = Convert.ToDecimal(cmd.ExecuteScalar())
                con.Close()
            End Using
            paidBeforeCurrent -= currentAmount
            If paidBeforeCurrent < 0D Then paidBeforeCurrent = 0D
        End If
    End Sub

    Private Function GetDiscountPercent() As Decimal
        If ChkDescount Is Nothing OrElse Not ChkDescount.Checked Then Return 0D

        Dim s As String = If(TxtDescount?.Text, "").Trim()
        If String.IsNullOrWhiteSpace(s) Then Return 0D

        Dim p As Decimal
        If Decimal.TryParse(s, p) Then
            If p < 0D Then p = 0D
            If p > 100D Then p = 100D
            Return p
        End If

        Return 0D
    End Function

    Private Sub ApplyDiscountUiState()
        If TxtDescount Is Nothing Then Return

        Dim enabled As Boolean = (ChkDescount IsNot Nothing AndAlso ChkDescount.Checked)
        TxtDescount.Enabled = enabled
        TxtDescount.TabStop = enabled

        If Not enabled Then
            TxtDescount.Text = "0.00"
        End If

        If selectedSubscriptionId > 0 Then
            UpdatePaymentSummary()
        End If
    End Sub

    Private Function GetDiscountAmount(amount As Decimal) As Decimal
        Dim p As Decimal = GetDiscountPercent()
        If p <= 0D Then Return 0D

        Dim d As Decimal = amount * (p / 100D)
        If d < 0D Then d = 0D
        If d > amount Then d = amount
        Return d
    End Function

    Private Function GetNetPaid(amount As Decimal) As Decimal
        Dim net As Decimal = amount - GetDiscountAmount(amount)
        If net < 0D Then net = 0D
        Return net
    End Function

    Private Sub UpdatePaymentSummary()
        If isUpdatingAmounts Then Return
        isUpdatingAmounts = True
        Try
            Dim enteredAmount As Decimal = GetCurrentAmountPaidInput()
            Dim discAmount As Decimal = GetDiscountAmount(enteredAmount)
            Dim netPaidNow As Decimal = enteredAmount - discAmount
            If netPaidNow < 0D Then netPaidNow = 0D

            If ChkDescount IsNot Nothing AndAlso ChkDescount.Checked Then
                txtAmountPaid.Text = netPaidNow.ToString("0.00")
            End If

            txtPackagePrice.Text = selectedPackagePrice.ToString("0.00")

            If TxtDescount IsNot Nothing Then
                TxtDescount.Text = discAmount.ToString("0.00")
            End If

            Dim remaining As Decimal = selectedPackagePrice - netPaidNow
            txtRemaining.Text = remaining.ToString("0.00")

            If remaining < 0D Then
                txtRemaining.ForeColor = Color.OrangeRed
            Else
                txtRemaining.ForeColor = Color.White
            End If
        Finally
            isUpdatingAmounts = False
        End Try
    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        If isUpdatingAmounts Then Return
        If Not IsHandleCreated OrElse Not Visible Then Return
        If selectedSubscriptionId = 0 Then Return
        UpdatePaymentSummary()
    End Sub

    Private Sub btnSelectSubscription_Click(sender As Object, e As EventArgs) Handles btnSelectSubscription.Click
        Using f As New FrmSelectSubMember()
            If f.ShowDialog(Me) = DialogResult.OK Then
                selectedReceiptId = 0
                selectedSubscriptionId = f.SelectedSubscriptionId
                txtSubscription.Text = f.SelectedSubscriptionDisplay

                selectedPackagePrice = f.SelectedPackagePrice

                RefreshPaidBefore()
                UpdatePaymentSummary()
            End If
        End Using
    End Sub

    Private Sub dgvReceipts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReceipts.CellClick
        If e.RowIndex < 0 OrElse dgvReceipts.CurrentRow Is Nothing Then Return

        selectedReceiptId = CInt(dgvReceipts.CurrentRow.Cells("colReceiptId").Value)
        txtReceiptNumber.Text = dgvReceipts.CurrentRow.Cells("colReceiptNo").Value?.ToString()

        Dim parsed As DateTime
        If DateTime.TryParse(dgvReceipts.CurrentRow.Cells("colReceiptDate").Value?.ToString(), parsed) Then
            dtpReceiptDate.Value = parsed
        End If

        txtAmountPaid.Text = dgvReceipts.CurrentRow.Cells("colAmount").Value?.ToString()

        Dim methodText = dgvReceipts.CurrentRow.Cells("colMethod").Value?.ToString()
        If Not String.IsNullOrWhiteSpace(methodText) Then
            cmbPaymentMethod.SelectedItem = methodText
        End If

        selectedSubscriptionId = CInt(dgvReceipts.CurrentRow.Cells("colSubId").Value)
        txtSubscription.Text = selectedSubscriptionId.ToString()

        txtNotes.Text = dgvReceipts.CurrentRow.Cells("colNotes").Value?.ToString()

        Try
            Using cmd As New SqlCommand("SELECT TOP 1 p.Price FROM MemberSubscriptions ms INNER JOIN SubscriptionPackages p ON ms.PackageID = p.PackageID WHERE ms.SubscriptionID=@sid", con)
                cmd.Parameters.AddWithValue("@sid", selectedSubscriptionId)
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim v = cmd.ExecuteScalar()
                con.Close()
                selectedPackagePrice = If(v Is Nothing OrElse IsDBNull(v), 0D, Convert.ToDecimal(v))
            End Using
        Catch
            If con.State = ConnectionState.Open Then con.Close()
            selectedPackagePrice = 0D
        End Try

        RefreshPaidBefore()
        UpdatePaymentSummary()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If selectedReceiptId = 0 Then
            txtReceiptNumber.Text = $"RC-{Date.Now:yyyyMMddHHmmss}"
        End If

        If String.IsNullOrWhiteSpace(txtReceiptNumber.Text) Then
            MessageBox.Show("رقم الإيصال مطلوب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(txtAmountPaid.Text.Trim(), amount) Then
            MessageBox.Show("المبلغ غير صحيح.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If amount <= 0D Then
            MessageBox.Show("المبلغ يجب أن يكون أكبر من صفر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If selectedSubscriptionId = 0 Then
            MessageBox.Show("اختر الاشتراك أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim method As String = If(cmbPaymentMethod.SelectedItem Is Nothing, "", cmbPaymentMethod.SelectedItem.ToString())
        If String.IsNullOrWhiteSpace(method) Then
            MessageBox.Show("اختر طريقة الدفع.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If selectedReceiptId = 0 Then
            InsertReceipt(txtReceiptNumber.Text.Trim(), dtpReceiptDate.Value, amount, method, selectedSubscriptionId, txtNotes.Text.Trim())
            MessageBox.Show("تم حفظ الإيصال.", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            UpdateReceipt(selectedReceiptId, txtReceiptNumber.Text.Trim(), dtpReceiptDate.Value, amount, method, selectedSubscriptionId, txtNotes.Text.Trim())
            MessageBox.Show("تم تعديل الإيصال.", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        LoadReceipts(txtSearch.Text.Trim())
        ClearForm()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedReceiptId = 0 Then
            MessageBox.Show("اختر إيصالاً أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("هل أنت متأكد من حذف هذا الإيصال؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        Try
            Dim sqlGet As String = "SELECT ReceiptNumber, ReceiptDate, AmountPaid, SubscriptionID FROM PaymentReceipts WHERE ReceiptID=@id"
            Dim receiptNo As String = ""
            Dim amount As Decimal = 0D
            Dim subId As Integer = 0

            Using cmdGet As New SqlCommand(sqlGet, con)
                cmdGet.Parameters.AddWithValue("@id", selectedReceiptId)
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Using rd = cmdGet.ExecuteReader()
                    If rd.Read() Then
                        receiptNo = rd("ReceiptNumber").ToString()
                        amount = Convert.ToDecimal(rd("AmountPaid"))
                        subId = Convert.ToInt32(rd("SubscriptionID"))
                    End If
                End Using
                con.Close()
            End Using

            If subId > 0 AndAlso amount > 0D Then
                Dim memberId As Integer = GetMemberIdBySubscriptionId(subId)
                If memberId > 0 Then
                    Dim note As String = $"إلغاء دفع لإيصال {receiptNo}"
                    InsertMemberTransaction(memberId, Date.Now, "إلغاء دفع", amount, Nothing, "PaymentReceipts", selectedReceiptId, note)
                End If
            End If
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MessageBox.Show("تعذر تسجيل الحركة العكسية: " & ex.Message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Using cmd As New SqlCommand("DELETE FROM PaymentReceipts WHERE ReceiptID=@id", con)
            cmd.Parameters.AddWithValue("@id", selectedReceiptId)
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using

        LoadReceipts(txtSearch.Text.Trim())
        ClearForm()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        LoadReceipts(txtSearch.Text.Trim())
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearForm()
        txtReceiptNumber.Focus()
    End Sub

    Private Sub ChkDescount_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDescount.CheckedChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        ApplyDiscountUiState()
    End Sub
End Class

