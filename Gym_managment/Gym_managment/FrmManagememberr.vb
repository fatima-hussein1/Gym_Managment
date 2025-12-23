Imports MaterialSkin
Imports System.Drawing
Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmManagememberr

    Private DTMembers As New DataTable

    Private Sub FrmManageTrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        SkinManager.AddFormToManage(Me)

        SkinManager.ColorScheme = New ColorScheme(
            Primary.Indigo500,
            Primary.Indigo700,
            Primary.Indigo100,
            Accent.LightBlue200,
            TextShade.WHITE
        )



        Load_Members()
    End Sub

    'Private Sub ApplyFontOnly(parent As Control, f As Font)
    '    parent.Font = f
    '    For Each c As Control In parent.Controls
    '        ApplyFontOnly(c, f)
    '    Next
    'End Sub

    Public Sub Load_Members()
        DGVProduct.Rows.Clear()
        DTMembers.Clear()
        Try

            SQLQuery = "SELECT * FROM Members where Active=1 "
            DA = New SqlDataAdapter(SQLQuery, con)
            DA.Fill(DTMembers)

            For i As Integer = 0 To DTMembers.Rows.Count - 1
                DGVProduct.Rows.Add()

                DGVProduct.Item(0, i).Value = DTMembers.Rows(i).Item(0) ' رقم العضو
                DGVProduct.Item(1, i).Value = DTMembers.Rows(i).Item(1) ' الاسم
                DGVProduct.Item(2, i).Value = DTMembers.Rows(i).Item(2) ' رقم الهاتف
                DGVProduct.Item(3, i).Value = DTMembers.Rows(i).Item(3) ' تاريخ التسجيل

                If Not IsDBNull(DTMembers.Rows(i).Item("memberPic")) Then
                    Dim imgData As Byte() = DirectCast(DTMembers.Rows(i).Item("memberPic"), Byte())
                    Using ms As New IO.MemoryStream(imgData)
                        DGVProduct.Item(4, i).Value = Image.FromStream(ms)
                    End Using
                Else
                    DGVProduct.Item(4, i).Value = Nothing
                End If

                DGVProduct.Item(5, i).Value = DTMembers.Rows(i).Item(5)


            Next
        Catch ex As Exception
            ShowAppMessage("فشل في الاتصال بقواعد البيانات: " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub BtnAddMember_Click(sender As Object, e As EventArgs) Handles BtnAddMember.Click
        FrmAddMember.ShowDialog()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Try
            DGVProduct.Rows.Clear()
            Dim searchText As String = TxtSearch.Text.Trim().ToLower()

            For Each row As DataRow In DTMembers.Rows
                Dim firstName As String = row(1).ToString().ToLower()
                Dim phone As String = row(3).ToString().ToLower()

                If String.IsNullOrEmpty(searchText) OrElse firstName.Contains(searchText) OrElse phone.Contains(searchText) Then
                    Dim n As Integer = DGVProduct.Rows.Add()
                    DGVProduct.Item(0, n).Value = row(0) ' رقم العضو
                    DGVProduct.Item(1, n).Value = row(1) ' الاسم
                    DGVProduct.Item(2, n).Value = row(3) ' رقم الهاتف
                    DGVProduct.Item(3, n).Value = row(4)   ' تاريخ التسجيل
                    DGVProduct.Item(4, n).Value = row(5)

                    ' الصورة
                    If Not IsDBNull(row("memberPic")) Then
                        Dim imgData As Byte() = DirectCast(row("memberPic"), Byte())
                        Using ms As New IO.MemoryStream(imgData)
                            DGVProduct.Item(4, n).Value = Image.FromStream(ms)
                        End Using
                    Else
                        DGVProduct.Item(4, n).Value = Nothing
                    End If

                    DGVProduct.Item(5, n).Value = row(5)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DGVProduct_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGVProduct.DataError
        e.ThrowException = False
    End Sub

    Private Sub DGVProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProduct.CellContentClick
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = 6 Then
            With FrmAddMember
                .Member_ID = DGVProduct.CurrentRow.Cells(0).Value
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim Cmd As New SqlCommand("Select * from Members Where MemberID=@MemberID", con)
                Cmd.Parameters.AddWithValue("@MemberID", .Member_ID)
                Dim rdr As SqlDataReader = Cmd.ExecuteReader()
                rdr.Read()
                If rdr.HasRows Then
                    .TxtName.Text = rdr("Name").ToString()
                    .TxtPhone.Text = rdr("PhoneNumber").ToString()
                    .DtpDate.Value = Convert.ToDateTime(rdr("JoinDate"))

                    If Not IsDBNull(rdr("memberPic")) Then
                        Dim imgData As Byte() = DirectCast(rdr("memberPic"), Byte())
                        Dim ms As New IO.MemoryStream(imgData)
                        .PicMember.Image = Image.FromStream(ms)
                    Else
                        .PicMember.Image = Nothing
                    End If

                    rdr.Close()
                    con.Close()
                    .Text = "تعديل بيانات العضو"
                    .BtnAddMember.Enabled = False
                    .BtnUpdateMember.Enabled = True
                    .ShowDialog()
                Else
                    rdr.Close()
                    con.Close()
                End If
            End With

        ElseIf e.ColumnIndex = 7 Then
            If MsgBox("هل أنت متأكد من حذف هذا العضو؟", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "تأكيد الحذف") = MsgBoxResult.Yes Then
                Try
                    If con.State = ConnectionState.Open Then con.Close()
                    con.Open()
                    Dim Cmd As New SqlCommand("UPDATE Members SET Active=0 WHERE MemberID=@MemberID", con)
                    Cmd.Parameters.AddWithValue("@MemberID", DGVProduct.CurrentRow.Cells(0).Value)
                    Cmd.ExecuteNonQuery()
                    con.Close()
                    ShowAppMessage("تم حذف العضو بنجاح", AppMessageType.Success)
                    Load_Members()
                Catch ex As Exception
                    ShowAppMessage("خطأ في الحذف: " & ex.Message, AppMessageType.Error)
                Finally
                    If con.State = ConnectionState.Open Then con.Close()
                End Try
            End If
        End If
    End Sub
End Class