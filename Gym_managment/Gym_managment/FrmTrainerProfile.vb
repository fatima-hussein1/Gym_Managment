Imports Microsoft.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class FrmTrainerProfile

    Private _trainerId As Integer

    Private Sub FrmTrainerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler BtnCancel.Click, Sub(s, e2) Me.Close()
        AddHandler CbClose.Click, Sub(s, e2) Me.Close()
        AddHandler CbMin.Click, Sub(s, e2) Me.WindowState = FormWindowState.Minimized
        AddHandler BtnChangePic.Click, AddressOf BtnChangePic_Click
        AddHandler BtnSave.Click, AddressOf BtnSave_Click

        LoadProfile()
    End Sub

    Private Sub LoadProfile()
        If UserID <= 0 Then
            ShowAppMessage("لم يتم تحديد المستخدم الحالي", AppMessageType.Error)
            Return
        End If

        Try
            Dim dtUser As New DataTable()
            Using cmd As New SqlCommand("SELECT TOP 1 UserName, UserEmail, UserPass, UserPic FROM UserTable WHERE ID = @id", con)
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = UserID
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dtUser)
                End Using
            End Using

            If dtUser.Rows.Count = 0 Then
                ShowAppMessage("لم يتم العثور على بيانات المستخدم", AppMessageType.Error)
                Return
            End If

            Dim ur = dtUser.Rows(0)
            TxtUserName.Text = If(IsDBNull(ur("UserName")), "", ur("UserName").ToString())
            TxtEmail.Text = If(IsDBNull(ur("UserEmail")), "", ur("UserEmail").ToString())
            TxtPassword.Text = If(IsDBNull(ur("UserPass")), "", ur("UserPass").ToString())

            If Not IsDBNull(ur("UserPic")) Then
                Dim imgBytes = DirectCast(ur("UserPic"), Byte())
                Using ms As New MemoryStream(imgBytes)
                    PicTrainer.Image = Image.FromStream(ms)
                End Using
            Else
                PicTrainer.Image = Nothing
            End If

            Dim dtTr As New DataTable()
            Using cmd As New SqlCommand("SELECT TOP 1 TrainerID, Name, HireDate, Specialization FROM Trainers WHERE UserID = @uid", con)
                cmd.Parameters.Add("@uid", SqlDbType.Int).Value = UserID
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dtTr)
                End Using
            End Using

            If dtTr.Rows.Count > 0 Then
                Dim tr = dtTr.Rows(0)
                _trainerId = If(IsDBNull(tr("TrainerID")), 0, CInt(tr("TrainerID")))
                TxtTrainerName.Text = If(IsDBNull(tr("Name")), "", tr("Name").ToString())
                TxtSpecialization.Text = If(IsDBNull(tr("Specialization")), "", tr("Specialization").ToString())

                If Not IsDBNull(tr("HireDate")) Then
                    Dim d As Date = CDate(tr("HireDate"))
                    TxtJoinDate.Text = d.ToString("dd-MM-yyyy")
                Else
                    TxtJoinDate.Text = "-"
                End If
            Else
                _trainerId = 0
                TxtTrainerName.Text = ""
                TxtSpecialization.Text = ""
                TxtJoinDate.Text = "-"
            End If

        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            ShowAppMessage("تعذر تحميل بيانات الملف الشخصي " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub BtnChangePic_Click(sender As Object, e As EventArgs)
        Try
            If OpenPic.ShowDialog(Me) <> DialogResult.OK Then Return
            PicTrainer.Image = Image.FromFile(OpenPic.FileName)
        Catch ex As Exception
            ShowAppMessage(":تعذر تحميل الصورة " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        If UserID <= 0 Then Return

        If String.IsNullOrWhiteSpace(TxtUserName.Text) Then
            ShowAppMessage("الرجاء إدخال اسم المستخدم", AppMessageType.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(TxtTrainerName.Text) Then
            ShowAppMessage("الرجاء إدخال اسم المدرب", AppMessageType.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(TxtEmail.Text) Then
            ShowAppMessage("الرجاء إدخال البريد الإلكتروني", AppMessageType.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(TxtPassword.Text) Then
            ShowAppMessage("الرجاء إدخال كلمة المرور", AppMessageType.Error)
            Return
        End If

        Try
            Using cmd As New SqlCommand("UPDATE UserTable SET UserName=@n, UserEmail=@e, UserPass=@p, UserPic=@pic WHERE ID=@id", con)
                cmd.Parameters.Add("@n", SqlDbType.NVarChar, 100).Value = TxtUserName.Text.Trim()
                cmd.Parameters.Add("@e", SqlDbType.NVarChar, 100).Value = TxtEmail.Text.Trim()
                cmd.Parameters.Add("@p", SqlDbType.NVarChar, 50).Value = TxtPassword.Text

                If PicTrainer.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        PicTrainer.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                        cmd.Parameters.Add("@pic", SqlDbType.Image).Value = ms.ToArray()
                    End Using
                Else
                    cmd.Parameters.Add("@pic", SqlDbType.Image).Value = DBNull.Value
                End If

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = UserID

                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            If _trainerId > 0 Then
                Using cmd2 As New SqlCommand("UPDATE Trainers SET Name=@tn, Specialization=@sp WHERE TrainerID=@tid", con)
                    cmd2.Parameters.Add("@tn", SqlDbType.NVarChar, 100).Value = TxtTrainerName.Text.Trim()
                    cmd2.Parameters.Add("@sp", SqlDbType.NVarChar, 100).Value = TxtSpecialization.Text.Trim()
                    cmd2.Parameters.Add("@tid", SqlDbType.Int).Value = _trainerId

                    If con.State = ConnectionState.Open Then con.Close()
                    con.Open()
                    cmd2.ExecuteNonQuery()
                    con.Close()
                End Using
            End If

            ShowAppMessage(".تم حفظ بيانات الملف الشخصي بنجاح", AppMessageType.Success)

        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            ShowAppMessage(":حدث خطأ أثناء الحفظ " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub LblEmail_Click(sender As Object, e As EventArgs) Handles LblEmail.Click

    End Sub
End Class