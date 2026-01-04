Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class FrmAddTrainer

    Public Trainer_ID As Integer = 0

    Private Sub FrmAddTrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Trainer_ID = 0 Then
            CLEARITEMS()
        End If
    End Sub

    Public Sub CLEARITEMS()
        TxtName.Text = ""
        TxtPhone.Text = ""
        TxtEmail.Text = ""
        DtpDate.Value = Now
        Pictrainer.Image = Nothing
        TxtName.Focus()
    End Sub

    Private Function CreateTrainerUser() As Integer
        Dim newUserId As Integer = 0

        Dim userName As String = TxtName.Text.Trim()
        Dim userEmail As String = TxtEmail.Text.Trim()
        Dim userPhone As String = TxtPhone.Text.Trim()

        If String.IsNullOrWhiteSpace(userName) Then
            Throw New ApplicationException("الرجاء إدخال اسم المدرب.")
        End If
        If String.IsNullOrWhiteSpace(userEmail) Then
            Throw New ApplicationException("الرجاء إدخال البريد الإلكتروني.")
        End If
        If String.IsNullOrWhiteSpace(userPhone) Then
            Throw New ApplicationException("الرجاء إدخال رقم الهاتف.")
        End If

        Dim defaultPass As String = DtpBirthDate.Value.Year.ToString()

        Dim sql As String =
            "INSERT INTO UserTable (UserName, UserPass, Userjob, UserEmail, UserPhone, UserPic, LockedOut, RoleID) " &
            "VALUES (@UserName, @UserPass, @Userjob, @UserEmail, @UserPhone, @UserPic, @LockedOut, @RoleID); " &
            "SELECT CAST(SCOPE_IDENTITY() AS int);"

        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 100).Value = userName
            cmd.Parameters.Add("@UserPass", SqlDbType.NVarChar, 50).Value = defaultPass
            cmd.Parameters.Add("@Userjob", SqlDbType.NVarChar, 100).Value = "مدرب"
            cmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar, 100).Value = userEmail
            cmd.Parameters.Add("@UserPhone", SqlDbType.BigInt).Value = CLng(Val(userPhone))

            Dim ms As New MemoryStream
            If Pictrainer.Image IsNot Nothing Then
                Pictrainer.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                cmd.Parameters.Add("@UserPic", SqlDbType.Image).Value = ms.ToArray()
            Else
                cmd.Parameters.Add("@UserPic", SqlDbType.Image).Value = DBNull.Value
            End If

            cmd.Parameters.Add("@LockedOut", SqlDbType.Bit).Value = False
            cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = 3

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            newUserId = CInt(cmd.ExecuteScalar())
            con.Close()
        End Using

        Return newUserId
    End Function

    Public Sub Insert_Trainer()
        Dim trainerUserId As Integer = CreateTrainerUser()

        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Trainers (Name, PhoneNumber, HireDate, BirthDate, PicTrainer, UserID, Active) values (@Name, @PhoneNumber, @HireDate, @BirthDate, @PicTrainer, @UserID, @Active)"
            .Parameters.Clear()

            .Parameters.Add("@Name", SqlDbType.NVarChar).Value = TxtName.Text
            .Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = TxtPhone.Text
            .Parameters.Add("@HireDate", SqlDbType.Date).Value = DtpDate.Value
            .Parameters.Add("@BirthDate", SqlDbType.Date).Value = DtpBirthDate.Value.Date

            Dim ms As New MemoryStream
            If Pictrainer.Image IsNot Nothing Then
                Pictrainer.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                .Parameters.Add("@PicTrainer", SqlDbType.Image).Value = ms.ToArray()
            Else
                .Parameters.Add("@PicTrainer", SqlDbType.Image).Value = DBNull.Value
            End If

            .Parameters.Add("@UserID", SqlDbType.Int).Value = trainerUserId
            .Parameters.Add("@Active", SqlDbType.Bit).Value = 1
        End With

        If con.State = ConnectionState.Closed Then con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم إضافة المدرب بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Update_Trainer()
        Dim Cmd As New SqlCommand

        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update Trainers Set Name = @Name, PhoneNumber = @PhoneNumber, HireDate = @HireDate, BirthDate=@BirthDate, PicTrainer = @PicTrainer Where TrainerID = @TrainerID"
            .Parameters.Clear()

            .Parameters.Add("@Name", SqlDbType.NVarChar).Value = TxtName.Text
            .Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = TxtPhone.Text
            .Parameters.Add("@HireDate", SqlDbType.Date).Value = DtpDate.Value
            .Parameters.Add("@BirthDate", SqlDbType.Date).Value = DtpBirthDate.Value.Date

            Dim ms As New MemoryStream
            If Pictrainer.Image IsNot Nothing Then
                Pictrainer.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                .Parameters.Add("@PicTrainer", SqlDbType.Image).Value = ms.ToArray()
            Else
                .Parameters.Add("@PicTrainer", SqlDbType.Image).Value = DBNull.Value
            End If

            .Parameters.Add("@TrainerID", SqlDbType.Int).Value = Trainer_ID
        End With

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Cmd.ExecuteNonQuery()
            con.Close()
            ShowAppMessage("تم تعديل بيانات المدرب بنجاح", AppMessageType.Success)
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            ShowAppMessage("حدث خطأ أثناء تعديل بيانات المدرب: " & ex.Message, AppMessageType.Error)
        Finally
            Cmd = Nothing
        End Try
    End Sub

    Private Sub BtnAddTrainer_Click(sender As Object, e As EventArgs) Handles BtnAddTrainer.Click
        If TxtName.Text = vbNullString Then
            MessageBox.Show("عذرا ، قم بتعبئة حقل الاسم", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Try
            Insert_Trainer()

            With FrmTrainers
                .Load_Trainers()
            End With

            CLEARITEMS()

        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            ShowAppMessage("حدث خطأ أثناء إضافة المدرب: " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub BtnUpdateTrainer_Click(sender As Object, e As EventArgs) Handles BtnUpdateTrainer.Click
        If TxtName.Text = vbNullString Then
            MsgBox("الرجاء إدخال الاسم", vbExclamation, "خطأ إدخال")
            Exit Sub
        End If

        Update_Trainer()

        With FrmTrainers
            .Load_Trainers()
        End With
        Me.Close()
    End Sub

    Private Sub Pictrainer_Click(sender As Object, e As EventArgs) Handles Pictrainer.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif;*.ico"
        If ofd.ShowDialog() = DialogResult.OK Then
            Pictrainer.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ClearText(GroupBox1, Pictrainer)
        Trainer_ID = 0
    End Sub

End Class