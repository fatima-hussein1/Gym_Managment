Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient
Imports MaterialSkin

Public Class FrmAddTrainer

    Public Trainer_ID As Integer = 0

    Private Sub FrmAddTrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        SkinManager.AddFormToManage(Me)

        SkinManager.ColorScheme = New ColorScheme(
            Primary.Indigo500,
            Primary.Indigo700,
            Primary.Indigo100,
            Accent.LightBlue200,
            TextShade.WHITE
        )

        If Trainer_ID = 0 Then
            CLEARITEMS()
        End If
    End Sub

    Public Sub CLEARITEMS()
        TxtName.Text = ""
        TxtPhone.Text = ""
        DtpDate.Value = Now
        Pictrainer.Image = Nothing
        TxtName.Focus()
    End Sub

    Public Sub Insert_Trainer()
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Trainers (Name, PhoneNumber, HireDate, PicTrainer, UserID, Active) values (@Name, @PhoneNumber, @HireDate, @PicTrainer, @UserID, @Active)"
            .Parameters.Clear()

            .Parameters.Add("@Name", SqlDbType.NVarChar).Value = TxtName.Text
            .Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = TxtPhone.Text
            .Parameters.Add("@HireDate", SqlDbType.Date).Value = DtpDate.Value

            Dim ms As New MemoryStream
            If Pictrainer.Image IsNot Nothing Then
                Pictrainer.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                .Parameters.Add("@PicTrainer", SqlDbType.Image).Value = ms.ToArray()
            Else
                .Parameters.Add("@PicTrainer", SqlDbType.Image).Value = DBNull.Value
            End If

            .Parameters.Add("@UserID", SqlDbType.Int).Value = UserID
            .Parameters.Add("@Active", SqlDbType.Bit).Value = 1
        End With

        If con.State = ConnectionState.Closed Then con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم إضافة المدرب بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub BtnAddTrainer_Click(sender As Object, e As EventArgs) Handles BtnAddTrainer.Click
        If TxtName.Text = vbNullString Then
            MessageBox.Show("عذرا ، قم بتعبئة حقل الاسم", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Insert_Trainer()

        With FrmTrainers
            .Load_Trainers()
        End With

        CLEARITEMS()
    End Sub

    Public Sub Update_Trainer()
        Dim Cmd As New SqlCommand

        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update Trainers Set Name = @Name, PhoneNumber = @PhoneNumber, HireDate = @HireDate, PicTrainer = @PicTrainer Where TrainerID = @TrainerID"
            .Parameters.Clear()

            .Parameters.Add("@Name", SqlDbType.NVarChar).Value = TxtName.Text
            .Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = TxtPhone.Text
            .Parameters.Add("@HireDate", SqlDbType.Date).Value = DtpDate.Value

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