Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient
Imports MaterialSkin


Public Class FrmAddMember

    Public Member_ID As Integer = 0

    Private Sub FrmAddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' تم تعطيل MaterialSkin لأن الفورم أصبح بتصميم Guna وليس MaterialForm
        'Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        'SkinManager.AddFormToManage(Me)
        'SkinManager.ColorScheme = New ColorScheme(
        '    Primary.Indigo500,
        '    Primary.Indigo700,
        '    Primary.Indigo100,
        '    Accent.LightBlue200,
        '    TextShade.WHITE
        ')

        If Member_ID = 0 Then
            CLEARITEMS()
        End If
    End Sub

    Public Sub CLEARITEMS()
        TxtName.Text = ""
        TxtPhone.Text = ""
        DtpDate.Value = Now
        PicMember.Image = Nothing
        TxtName.Focus()
    End Sub



    Public Sub Insert_Member()
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Members (Name, PhoneNumber, JoinDate, memberPic, UserID, Active) values (@Name, @PhoneNumber, @JoinDate, @memberPic, @UserID, @Active)"
            .Parameters.Clear()

            .Parameters.Add("@Name", SqlDbType.NVarChar).Value = TxtName.Text
            .Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = TxtPhone.Text
            .Parameters.Add("@JoinDate", SqlDbType.Date).Value = DtpDate.Value

            Dim ms As New MemoryStream
            If PicMember.Image IsNot Nothing Then
                PicMember.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                .Parameters.Add("@memberPic", SqlDbType.Image).Value = ms.ToArray()
            Else
                .Parameters.Add("@memberPic", SqlDbType.Image).Value = DBNull.Value
            End If

            .Parameters.Add("@UserID", SqlDbType.Int).Value = UserID
            .Parameters.Add("@Active", SqlDbType.Bit).Value = 1
        End With

        If con.State = ConnectionState.Closed Then con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم إضافة العضو بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnAddMember.Click
        If TxtName.Text = vbNullString Then
            MessageBox.Show("عذرا ، قم بتعبئة حقل الاسم", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Insert_Member()

        With FrmManagememberr
            .Load_Members()
        End With

        CLEARITEMS()
    End Sub

    Public Sub Update_Member()
        Dim Cmd As New SqlCommand

        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update Members Set Name = @Name, PhoneNumber = @PhoneNumber, JoinDate = @JoinDate, memberPic = @memberPic Where MemberID = @MemberID"
            .Parameters.Clear()

            .Parameters.Add("@Name", SqlDbType.NVarChar).Value = TxtName.Text
            .Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = TxtPhone.Text
            .Parameters.Add("@JoinDate", SqlDbType.Date).Value = DtpDate.Value

            Dim ms As New MemoryStream
            If PicMember.Image IsNot Nothing Then
                PicMember.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                .Parameters.Add("@memberPic", SqlDbType.Image).Value = ms.ToArray()
            Else
                .Parameters.Add("@memberPic", SqlDbType.Image).Value = DBNull.Value
            End If

            .Parameters.Add("@MemberID", SqlDbType.Int).Value = Member_ID
        End With

        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم تعديل بيانات العضو بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdateMember.Click
        If TxtName.Text = vbNullString Then
            MsgBox("الرجاء إدخال الاسم", vbExclamation, "خطأ إدخال")
            Exit Sub
        End If

        Update_Member()

        With FrmManagememberr
            .Load_Members()
        End With
        Me.Close()
    End Sub

    Private Sub PicMember_Click(sender As Object, e As EventArgs) Handles PicMember.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif;*.ico"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PicMember.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DtpDate.ValueChanged

    End Sub

    Private Sub BtnAddMember_Click(sender As Object, e As EventArgs) Handles BtnAddMember.Click

    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ClearText(GroupBox1, PicMember)
        Member_ID = 0
    End Sub
End Class