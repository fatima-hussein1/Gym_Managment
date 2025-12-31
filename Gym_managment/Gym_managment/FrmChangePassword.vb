Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmChangePassword

    Private Sub FrmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        TxtUserName.Text = UserName
        TxtOldPass.Select()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub ToggleShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ToggleShowPassword.CheckedChanged
        Dim ch As Char = If(ToggleShowPassword.Checked, vbNullChar, "●"c)
        TxtOldPass.PasswordChar = ch
        TxtNewPass.PasswordChar = ch
    End Sub

    Private Sub TxtOldPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOldPass.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            TxtNewPass.Focus()
        End If
    End Sub

    Private Sub TxtNewPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNewPass.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            BtnOK.PerformClick()
        End If
    End Sub

    Private Sub PiczoomPass2_MouseHover(sender As Object, e As EventArgs) Handles PiczoomPass2.MouseHover
        TxtOldPass.PasswordChar = vbNullChar
    End Sub

    Private Sub PiczoomPass2_MouseLeave(sender As Object, e As EventArgs) Handles PiczoomPass2.MouseLeave
        If Not ToggleShowPassword.Checked Then
            TxtOldPass.PasswordChar = "●"c
        End If
    End Sub

    Private Sub PiczoomPass1_MouseHover(sender As Object, e As EventArgs) Handles PiczoomPass1.MouseHover
        TxtNewPass.PasswordChar = vbNullChar
    End Sub

    Private Sub PiczoomPass1_MouseLeave(sender As Object, e As EventArgs) Handles PiczoomPass1.MouseLeave
        If Not ToggleShowPassword.Checked Then
            TxtNewPass.PasswordChar = "●"c
        End If
    End Sub

    Private Function GetCurrentPasswordFromDb() As String
        Using cmd As New SqlCommand("SELECT TOP 1 UserPass FROM UserTable WHERE ID=@id", con)
            cmd.Parameters.AddWithValue("@id", UserID)
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim o = cmd.ExecuteScalar()
            con.Close()
            If o Is Nothing OrElse IsDBNull(o) Then Return ""
            Return o.ToString()
        End Using
    End Function

    Private Sub UpdatePasswordInDb(newPass As String)
        Using cmd As New SqlCommand("UPDATE UserTable SET UserPass=@p WHERE ID=@id", con)
            cmd.Parameters.AddWithValue("@p", newPass)
            cmd.Parameters.AddWithValue("@id", UserID)
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Dim oldPass = TxtOldPass.Text.Trim()
        Dim newPass = TxtNewPass.Text.Trim()

        If String.IsNullOrWhiteSpace(oldPass) Then
            MessageBox.Show("يرجى إدخال كلمة المرور الحالية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtOldPass.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(newPass) Then
            MessageBox.Show("يرجى إدخال كلمة المرور الجديدة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNewPass.Focus()
            Return
        End If

        Try
            Dim currentPass As String = GetCurrentPasswordFromDb()
            If currentPass <> oldPass Then
                MessageBox.Show("كلمة المرور الحالية غير صحيحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtOldPass.Focus()
                Return
            End If

            UpdatePasswordInDb(newPass)

            UserPassword = newPass
            MessageBox.Show("تم تعديل كلمة المرور بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()

        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MessageBox.Show("خطأ اتصال: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class