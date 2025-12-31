Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmMemberTransction

    Private DTTrans As New DataTable()
    Private selectedMemberId As Integer = 0

    Private Sub FrmMemberTransction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbType.Items.Clear()
        cmbType.Items.AddRange(New Object() {"الكل", "اشتراك", "دفع", "خصم", "إضافة", "أخرى"})
        If cmbType.Items.Count > 0 Then cmbType.SelectedIndex = 0

        dtpFrom.Value = Date.Today.AddMonths(-1)
        dtpTo.Value = Date.Today

        ConfigureGridIfNeeded()
        LoadTransactions()
    End Sub

    Private Sub ConfigureGridIfNeeded()
        If dgvTrans Is Nothing Then Return
        If dgvTrans.Columns.Count > 0 Then
            dgvTrans.AutoGenerateColumns = False
            Return
        End If

        dgvTrans.AutoGenerateColumns = False

        Dim cId As New DataGridViewTextBoxColumn() With {.Name = "colId", .HeaderText = "ID", .Visible = False}
        Dim cTransDate As New DataGridViewTextBoxColumn() With {.Name = "colTransDate", .HeaderText = "التاريخ", .Width = 170}
        Dim cTransType As New DataGridViewTextBoxColumn() With {.Name = "colType", .HeaderText = "النوع", .Width = 140}
        Dim cDebit As New DataGridViewTextBoxColumn() With {.Name = "colDebit", .HeaderText = "مدين", .Width = 110}
        Dim cCredit As New DataGridViewTextBoxColumn() With {.Name = "colCredit", .HeaderText = "دائن", .Width = 110}
        Dim cRefT As New DataGridViewTextBoxColumn() With {.Name = "colRefTable", .HeaderText = "المرجع", .Width = 130}
        Dim cRefId As New DataGridViewTextBoxColumn() With {.Name = "colRefId", .HeaderText = "RefID", .Width = 80}
        Dim cNotes As New DataGridViewTextBoxColumn() With {.Name = "colNotes", .HeaderText = "ملاحظات", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill}

        dgvTrans.Columns.AddRange(New DataGridViewColumn() {cId, cTransDate, cTransType, cDebit, cCredit, cRefT, cRefId, cNotes})
    End Sub

    Private Sub LoadTransactions()
        If dgvTrans Is Nothing Then Return

        dgvTrans.Rows.Clear()
        DTTrans.Clear()

        Dim sql As String = "SELECT MemberTransID, MemberID, TransactionDate, TransactionType, DebitAmount, CreditAmount, ReferenceTable, ReferenceID, Notes " &
                            "FROM MemberTransactions WHERE TransactionDate >= @from AND TransactionDate < @to"

        If selectedMemberId > 0 Then
            sql &= " AND MemberID = @mid"
        End If

        Dim typeFilter As String = If(cmbType.SelectedItem Is Nothing, "الكل", cmbType.SelectedItem.ToString())
        If Not String.IsNullOrWhiteSpace(typeFilter) AndAlso typeFilter <> "الكل" Then
            sql &= " AND TransactionType = @type"
        End If

        Dim search As String = txtSearch.Text.Trim()
        If Not String.IsNullOrWhiteSpace(search) Then
            sql &= " AND (TransactionType LIKE @s OR Notes LIKE @s OR ReferenceTable LIKE @s)"
        End If

        sql &= " ORDER BY MemberTransID DESC"

        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date)
            cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date.AddDays(1))

            If selectedMemberId > 0 Then
                cmd.Parameters.AddWithValue("@mid", selectedMemberId)
            End If

            If Not String.IsNullOrWhiteSpace(typeFilter) AndAlso typeFilter <> "الكل" Then
                cmd.Parameters.AddWithValue("@type", typeFilter)
            End If

            If Not String.IsNullOrWhiteSpace(search) Then
                cmd.Parameters.AddWithValue("@s", "%" & search & "%")
            End If

            Using da As New SqlDataAdapter(cmd)
                da.Fill(DTTrans)
            End Using
        End Using

        For Each r As DataRow In DTTrans.Rows
            Dim n As Integer = dgvTrans.Rows.Add()
            dgvTrans.Rows(n).Cells("colId").Value = r("MemberTransID")

            Dim d As DateTime = Convert.ToDateTime(r("TransactionDate"))
            dgvTrans.Rows(n).Cells("colTransDate").Value = d.ToString("dd-MM-yyyy HH:mm", Globalization.CultureInfo.InvariantCulture)

            dgvTrans.Rows(n).Cells("colType").Value = r("TransactionType").ToString()
            dgvTrans.Rows(n).Cells("colDebit").Value = If(IsDBNull(r("DebitAmount")), "", Convert.ToDecimal(r("DebitAmount")).ToString("0.00"))
            dgvTrans.Rows(n).Cells("colCredit").Value = If(IsDBNull(r("CreditAmount")), "", Convert.ToDecimal(r("CreditAmount")).ToString("0.00"))
            dgvTrans.Rows(n).Cells("colRefTable").Value = If(IsDBNull(r("ReferenceTable")), "", r("ReferenceTable").ToString())
            dgvTrans.Rows(n).Cells("colRefId").Value = If(IsDBNull(r("ReferenceID")), "", r("ReferenceID").ToString())
            dgvTrans.Rows(n).Cells("colNotes").Value = If(IsDBNull(r("Notes")), "", r("Notes").ToString())
        Next
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTransactions()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        LoadTransactions()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        LoadTransactions()
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        LoadTransactions()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        LoadTransactions()
    End Sub

    Private Sub btnSelectMember_Click(sender As Object, e As EventArgs) Handles btnSelectMember.Click
        Using f As New FrmSelectMember()
            If f.ShowDialog(Me) = DialogResult.OK Then
                selectedMemberId = f.SelectedMemberId
                txtMember.Text = f.SelectedMemberName
                LoadTransactions()
            End If
        End Using
    End Sub

End Class

