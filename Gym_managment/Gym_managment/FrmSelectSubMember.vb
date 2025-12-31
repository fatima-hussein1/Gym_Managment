Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmSelectSubMember

    <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedSubscriptionId As Integer

    <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedSubscriptionDisplay As String

    <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedMemberId As Integer

    <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedMemberName As String

    <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedPackageId As Integer

    <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedPackageName As String

    <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedPackagePrice As Decimal

    <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedStartDate As Date

    <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedEndDate As Date

    <ComponentModel.DesignerSerializationVisibility(ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedStatus As String

    Private DT As New DataTable()

    Private Sub FrmSelectSubMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigureGridIfNeeded()
        LoadSubscriptions()
    End Sub

    Private Sub ConfigureGridIfNeeded()
        If dgvSubs.Columns.Count > 0 Then
            dgvSubs.AutoGenerateColumns = False
            Return
        End If

        dgvSubs.AutoGenerateColumns = False

        Dim cId As New DataGridViewTextBoxColumn() With {.Name = "colSubId", .HeaderText = "SubscriptionID", .Visible = False}
        Dim cMember As New DataGridViewTextBoxColumn() With {.Name = "colMember", .HeaderText = "العضو", .Width = 220}
        Dim cPackage As New DataGridViewTextBoxColumn() With {.Name = "colPackage", .HeaderText = "الباقة", .Width = 180}
        Dim cStart As New DataGridViewTextBoxColumn() With {.Name = "colStart", .HeaderText = "بداية", .Width = 110}
        Dim cEnd As New DataGridViewTextBoxColumn() With {.Name = "colEnd", .HeaderText = "نهاية", .Width = 110}
        Dim cStatus As New DataGridViewTextBoxColumn() With {.Name = "colStatus", .HeaderText = "الحالة", .Width = 90}

        dgvSubs.Columns.AddRange(New DataGridViewColumn() {cId, cMember, cPackage, cStart, cEnd, cStatus})
    End Sub

    Private Sub LoadSubscriptions(Optional search As String = Nothing)
        dgvSubs.Rows.Clear()
        DT.Clear()

        Dim sql As String = "SELECT ms.SubscriptionID, ms.MemberID, m.Name AS MemberName, ms.PackageID, p.PackageName, p.Price, ms.StartDate, ms.EndDate, ms.SubscriptionStatus " &
                            "FROM MemberSubscriptions ms " &
                            "INNER JOIN Members m ON ms.MemberID = m.MemberID " &
                            "INNER JOIN SubscriptionPackages p ON ms.PackageID = p.PackageID"

        If Not String.IsNullOrWhiteSpace(search) Then
            sql &= " WHERE m.Name LIKE @s OR p.PackageName LIKE @s OR ms.SubscriptionStatus LIKE @s"
        End If
        sql &= " ORDER BY ms.SubscriptionID DESC"

        Using cmd As New SqlCommand(sql, con)
            If Not String.IsNullOrWhiteSpace(search) Then
                cmd.Parameters.AddWithValue("@s", "%" & search & "%")
            End If
            Using da As New SqlDataAdapter(cmd)
                da.Fill(DT)
            End Using
        End Using

        For Each r As DataRow In DT.Rows
            Dim n As Integer = dgvSubs.Rows.Add()
            dgvSubs.Rows(n).Cells("colSubId").Value = r("SubscriptionID")
            dgvSubs.Rows(n).Cells("colMember").Value = r("MemberName").ToString()
            dgvSubs.Rows(n).Cells("colPackage").Value = r("PackageName").ToString()
            dgvSubs.Rows(n).Cells("colStart").Value = Convert.ToDateTime(r("StartDate")).ToString("dd-MM-yyyy")
            dgvSubs.Rows(n).Cells("colEnd").Value = Convert.ToDateTime(r("EndDate")).ToString("dd-MM-yyyy")
            dgvSubs.Rows(n).Cells("colStatus").Value = r("SubscriptionStatus").ToString()
        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not IsHandleCreated OrElse Not Visible Then Return
        LoadSubscriptions(txtSearch.Text.Trim())
    End Sub

    Private Sub dgvSubs_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubs.CellDoubleClick
        If e.RowIndex < 0 OrElse dgvSubs.CurrentRow Is Nothing Then Return
        SelectCurrentRow()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        SelectCurrentRow()
    End Sub

    Private Sub SelectCurrentRow()
        If dgvSubs.CurrentRow Is Nothing Then
            MessageBox.Show("اختر اشتراكاً أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SelectedSubscriptionId = CInt(dgvSubs.CurrentRow.Cells("colSubId").Value)

        Dim row = DT.AsEnumerable().FirstOrDefault(Function(r) CInt(r("SubscriptionID")) = SelectedSubscriptionId)
        If row IsNot Nothing Then
            SelectedMemberId = CInt(row("MemberID"))
            SelectedMemberName = row("MemberName").ToString()
            SelectedPackageId = CInt(row("PackageID"))
            SelectedPackageName = row("PackageName").ToString()
            SelectedPackagePrice = Convert.ToDecimal(row("Price"))
            SelectedStartDate = CDate(row("StartDate"))
            SelectedEndDate = CDate(row("EndDate"))
            SelectedStatus = row("SubscriptionStatus").ToString()
        Else
            SelectedMemberId = 0
            SelectedPackageId = 0
            SelectedPackagePrice = 0D
        End If

        SelectedSubscriptionDisplay = $"{SelectedMemberName} - {SelectedPackageName}"

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class