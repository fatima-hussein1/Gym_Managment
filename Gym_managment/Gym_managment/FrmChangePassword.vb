Imports System.Data.SqlClient

Public Class FrmChangePassword
    Private Sub FrmChangPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        TxtUserName.Text = UserName
        TxtOldPass.Select()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Dispose()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TxtOldPass.PasswordChar = vbNullChar
            TxtNewPass.PasswordChar = vbNullChar
        Else
            TxtOldPass.PasswordChar = "●"
            TxtNewPass.PasswordChar = "●"
        End If
    End Sub

    Private Sub TxtOldPw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOldPass.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtNewPass.Focus()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub

    Private Sub PiczoomPass1_Click(sender As Object, e As EventArgs) Handles PiczoomPass1.Click
    End Sub

    Private Sub PiczoomPass1_MouseHover(sender As Object, e As EventArgs) Handles PiczoomPass1.MouseHover
        TxtOldPass.PasswordChar = vbNullChar
    End Sub

    Private Sub PiczoomPass1_MouseLeave(sender As Object, e As EventArgs) Handles PiczoomPass1.MouseLeave
        TxtOldPass.PasswordChar = "●"
    End Sub

    Private Sub PiczoomPass2_MouseHover(sender As Object, e As EventArgs) Handles PiczoomPass2.MouseHover
        TxtNewPass.PasswordChar = vbNullChar
    End Sub

    Private Sub PiczoomPass2_MouseLeave(sender As Object, e As EventArgs) Handles PiczoomPass2.MouseLeave
        TxtNewPass.PasswordChar = "●"

    End Sub

    'Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
    '    If TxtOldPass.Text = vbNullString Then
    '        MsgBox("يرجى ادخال كلمة المرور الحالية", vbInformation + vbOKOnly, "خطأ إدخال")
    '        TxtOldPass.Focus()
    '        Exit Sub
    '    End If
    '    If TxtNewPass.Text = vbNullString Then
    '        MsgBox("يرجى ادخال كلمة المرور الجديدة", vbInformation + vbOKOnly, "خطأ إدخال")
    '        TxtNewPass.Focus()
    '        Exit Sub
    '    End If

    '    Try
    '        SQLQuery = "update UserTable set  UserPass=@NewPass where ID=@UserID"

    '        ' تأكد من أن المتغير Cmd معرف كمتغير SqlCommand في مكان مناسب (عام في النموذج أو داخل هذا الإجراء)
    '        Using Cmd As New SqlCommand(SQLQuery, con)
    '            Cmd.Parameters.AddWithValue("@NewPass", TxtNewPass.Text.Trim())
    '            Cmd.Parameters.AddWithValue("@UserID", UserID)

    '            con.Open()
    '            Cmd.ExecuteNonQuery()
    '            con.Close()
    '        End Using
    '    Catch ex As Exception
    '        MsgBox("خطأ اتصال" + ex.Message, MsgBoxStyle.Critical)
    '        Exit Sub
    '    End Try

    '    MsgBox("تم تعديل كلمة المرور بنجاح", MsgBoxStyle.Information)
    '    UserPassword = TxtNewPass.Text.Trim()
    '    Me.Dispose()
    'End Sub
End Class