Imports System.Data
Imports System.Drawing
Imports Microsoft.Data.SqlClient

Public Class FrmSelectMember

    Friend SelectedMemberId As Integer
    Friend SelectedMemberName As String

    Private DTMembers As New DataTable()

    Private Sub FrmSelectMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Members()
    End Sub

    Public Sub Load_Members()
        dgvMembers.Rows.Clear()
        DTMembers.Clear()

        Try
            SQLQuery = "SELECT * FROM Members WHERE Active = 1"
            DA = New SqlDataAdapter(SQLQuery, con)
            DA.Fill(DTMembers)

            For i As Integer = 0 To DTMembers.Rows.Count - 1
                dgvMembers.Rows.Add()

                dgvMembers.Item(0, i).Value = DTMembers.Rows(i).Item(0)
                dgvMembers.Item(1, i).Value = DTMembers.Rows(i).Item(1)
                dgvMembers.Item(2, i).Value = DTMembers.Rows(i).Item(2)

                Dim dObj = DTMembers.Rows(i).Item(3)
                If Not IsDBNull(dObj) Then
                    dgvMembers.Item(3, i).Value = CDate(dObj).ToString("dd-MM-yyyy", Globalization.CultureInfo.InvariantCulture)
                Else
                    dgvMembers.Item(3, i).Value = ""
                End If

                If DTMembers.Columns.Contains("memberPic") AndAlso Not IsDBNull(DTMembers.Rows(i).Item("memberPic")) Then
                    Dim imgData As Byte() = DirectCast(DTMembers.Rows(i).Item("memberPic"), Byte())
                    Using ms As New IO.MemoryStream(imgData)
                        dgvMembers.Item(4, i).Value = Image.FromStream(ms)
                    End Using
                Else
                    dgvMembers.Item(4, i).Value = Nothing
                End If
            Next

        Catch ex As Exception
            ShowAppMessage("فشل في الاتصال بقواعد البيانات: " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dgvMembers.Rows.Clear()
            Dim searchText As String = txtSearch.Text.Trim().ToLower()

            For Each row As DataRow In DTMembers.Rows
                Dim name As String = row(1).ToString().ToLower()
                Dim phone As String = row(2).ToString().ToLower()

                If String.IsNullOrEmpty(searchText) OrElse name.Contains(searchText) OrElse phone.Contains(searchText) Then
                    Dim n As Integer = dgvMembers.Rows.Add()
                    dgvMembers.Item(0, n).Value = row(0)
                    dgvMembers.Item(1, n).Value = row(1)
                    dgvMembers.Item(2, n).Value = row(2)

                    Dim dObj = row(3)
                    If Not IsDBNull(dObj) Then
                        dgvMembers.Item(3, n).Value = CDate(dObj).ToString("dd-MM-yyyy", Globalization.CultureInfo.InvariantCulture)
                    Else
                        dgvMembers.Item(3, n).Value = ""
                    End If

                    If dgvMembers.ColumnCount > 4 Then
                        If DTMembers.Columns.Contains("memberPic") AndAlso Not IsDBNull(row("memberPic")) Then
                            Dim imgData As Byte() = DirectCast(row("memberPic"), Byte())
                            Using ms As New IO.MemoryStream(imgData)
                                dgvMembers.Item(4, n).Value = Image.FromStream(ms)
                            End Using
                        Else
                            dgvMembers.Item(4, n).Value = Nothing
                        End If
                    End If

                    If dgvMembers.ColumnCount > 5 Then
                        dgvMembers.Item(5, n).Value = row(5)
                    End If
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        SelectCurrentRow()
    End Sub

    Private Sub dgvMembers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Return
        SelectCurrentRow()
    End Sub

    Private Sub SelectCurrentRow()
        If dgvMembers.CurrentRow Is Nothing Then Return
        SelectedMemberId = CInt(dgvMembers.CurrentRow.Cells(0).Value)
        SelectedMemberName = dgvMembers.CurrentRow.Cells(1).Value.ToString()
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub dgvMembers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class