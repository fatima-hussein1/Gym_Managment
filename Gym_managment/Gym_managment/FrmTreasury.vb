Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmTreasury

    Private DTTreasury As New DataTable()
    Private selectedTreasuryId As Integer = 0

    Private Sub FrmTreasury_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTreasury()
    End Sub

    Private Sub LoadTreasury(Optional search As String = Nothing)
        ' قد يحدث TextChanged قبل تهيئة الـDataGridView بالكامل
        If dgvTreasury Is Nothing Then Return

        ' إذا لم تُحمّل أعمدة المصمم لأي سبب، أنشئها هنا بنفس الأسماء
        If dgvTreasury.Columns.Count = 0 Then
            dgvTreasury.AutoGenerateColumns = False

            Dim col0 As New DataGridViewTextBoxColumn() With {.Name = "Column0", .HeaderText = "معرف الخزينة", .Visible = False}
            Dim col1 As New DataGridViewTextBoxColumn() With {.Name = "Column1", .HeaderText = "الخزينة"}
            Dim col2 As New DataGridViewTextBoxColumn() With {.Name = "Column2", .HeaderText = "أمين الخزينة"}
            Dim col3 As New DataGridViewTextBoxColumn() With {.Name = "Column3", .HeaderText = "الرصيد"}

            dgvTreasury.Columns.AddRange(New DataGridViewColumn() {col0, col1, col2, col3})
        End If

        dgvTreasury.Rows.Clear()
        DTTreasury.Clear()

        Dim sql As String = "SELECT treasury_id, treasury_name, Storekeeper, balance FROM treasury_Table"
        If Not String.IsNullOrWhiteSpace(search) Then
            sql &= " WHERE treasury_name LIKE @s OR Storekeeper LIKE @s"
        End If
        sql &= " ORDER BY treasury_id DESC"

        Using cmd As New SqlCommand(sql, con)
            If Not String.IsNullOrWhiteSpace(search) Then
                cmd.Parameters.AddWithValue("@s", "%" & search & "%")
            End If
            Using da As New SqlDataAdapter(cmd)
                da.Fill(DTTreasury)
            End Using
        End Using

        For i As Integer = 0 To DTTreasury.Rows.Count - 1
            Dim n As Integer = dgvTreasury.Rows.Add()

            dgvTreasury.Rows(n).Cells("Column0").Value = DTTreasury.Rows(i)("treasury_id")
            dgvTreasury.Rows(n).Cells("Column1").Value = DTTreasury.Rows(i)("treasury_name")
            dgvTreasury.Rows(n).Cells("Column2").Value = If(IsDBNull(DTTreasury.Rows(i)("Storekeeper")), "", DTTreasury.Rows(i)("Storekeeper").ToString())
            dgvTreasury.Rows(n).Cells("Column3").Value = If(IsDBNull(DTTreasury.Rows(i)("balance")), 0, Convert.ToDouble(DTTreasury.Rows(i)("balance")))
        Next
    End Sub

    Private Sub dgvTreasury_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTreasury.CellClick
        If e.RowIndex < 0 OrElse dgvTreasury.CurrentRow Is Nothing Then Return

        selectedTreasuryId = CInt(dgvTreasury.CurrentRow.Cells("Column0").Value)
        txtName.Text = dgvTreasury.CurrentRow.Cells("Column1").Value?.ToString()
        txtStorekeeper.Text = dgvTreasury.CurrentRow.Cells("Column2").Value?.ToString()
        txtBalance.Text = dgvTreasury.CurrentRow.Cells("Column3").Value?.ToString()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        LoadTreasury(txtSearch.Text.Trim())
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        selectedTreasuryId = 0
        txtName.Text = ""
        txtStorekeeper.Text = ""
        txtBalance.Text = "0"
        txtName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("اسم الخزينة مطلوب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bal As Double
        If Not Double.TryParse(txtBalance.Text.Trim(), bal) Then
            MessageBox.Show("الرصيد غير صحيح.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If selectedTreasuryId = 0 Then
            InsertTreasury(txtName.Text.Trim(), txtStorekeeper.Text.Trim(), bal)
        Else
            UpdateTreasury(selectedTreasuryId, txtName.Text.Trim(), txtStorekeeper.Text.Trim(), bal)
        End If

        LoadTreasury(txtSearch.Text.Trim())
        btnNew.PerformClick()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedTreasuryId = 0 Then
            MessageBox.Show("اختر خزينة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("هل أنت متأكد من حذف هذه الخزينة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        Using cmd As New SqlCommand("DELETE FROM treasury_Table WHERE treasury_id = @id", con)
            cmd.Parameters.AddWithValue("@id", selectedTreasuryId)
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using

        LoadTreasury(txtSearch.Text.Trim())
        btnNew.PerformClick()
    End Sub

    Private Sub InsertTreasury(name As String, keeper As String, balance As Double)
        Using cmd As New SqlCommand("INSERT INTO treasury_Table (treasury_name, Storekeeper, balance, UserID) VALUES (@n, @k, @b, @u)", con)
            cmd.Parameters.AddWithValue("@n", name)
            cmd.Parameters.AddWithValue("@k", If(String.IsNullOrWhiteSpace(keeper), CType(DBNull.Value, Object), keeper))
            cmd.Parameters.AddWithValue("@b", balance)
            cmd.Parameters.AddWithValue("@u", If(UserID > 0, CType(UserID, Object), DBNull.Value))

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Private Sub UpdateTreasury(id As Integer, name As String, keeper As String, balance As Double)
        Using cmd As New SqlCommand("UPDATE treasury_Table SET treasury_name=@n, Storekeeper=@k, balance=@b, UserID=@u WHERE treasury_id=@id", con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@n", name)
            cmd.Parameters.AddWithValue("@k", If(String.IsNullOrWhiteSpace(keeper), CType(DBNull.Value, Object), keeper))
            cmd.Parameters.AddWithValue("@b", balance)
            cmd.Parameters.AddWithValue("@u", If(UserID > 0, CType(UserID, Object), DBNull.Value))

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If selectedTreasuryId = 0 Then
            MessageBox.Show("اختر خزينة من الجدول أولاً للتعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("اسم الخزينة مطلوب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bal As Double
        If Not Double.TryParse(txtBalance.Text.Trim(), bal) Then
            MessageBox.Show("الرصيد غير صحيح.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        UpdateTreasury(selectedTreasuryId, txtName.Text.Trim(), txtStorekeeper.Text.Trim(), bal)

        LoadTreasury(txtSearch.Text.Trim())
        MessageBox.Show("تم تعديل الخزينة بنجاح.", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class