Imports Microsoft.Data.SqlClient
Imports System.ComponentModel
Imports System.Net.NetworkInformation
Imports System.Text
Imports Microsoft.Win32
Imports System.Net
Imports System.Web
Imports System.IO

Public Class FrmLogin

    Private DTUser As New DataTable
    Private DS As New DataSet
    Private DT As New DataTable, RandomPass As String
    Private R As New ResizeControls()

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SWForm = True
        Try
            If con Is Nothing OrElse con.State <> ConnectionState.Open Then
                OpenCon()
            End If

            SQLQuery = "SELECT * FROM UserTable WHERE lockedout=0"
            DA = New SqlDataAdapter(SQLQuery, con)
            DT = New DataTable
            DA.Fill(DT)
            CmbUserName.DataSource = DT
            CmbUserName.DisplayMember = "UserName"
            CmbUserName.ValueMember = "ID"
            If My.Settings.SelectedUser <= CmbUserName.Items.Count - 1 Then
                CmbUserName.SelectedIndex = My.Settings.SelectedUser
            Else
                My.Settings.SelectedUser = -1
                My.Settings.Save()
            End If
        Catch ex As Exception
            ShowAppMessage("فشل في جلب بيانات المستخدمين أو الإتصال: " & ex.Message, AppMessageType.Error)
        Finally
            Try
                CloseCon()
            Catch
            End Try
            SWForm = False
        End Try
    End Sub

    Private Sub CmbUserName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbUserName.SelectionChangeCommitted
        My.Settings.SelectedUser = CmbUserName.SelectedIndex
        My.Settings.Save()
        TxtPasswprd.Text = ""
        TxtPasswprd.Focus()
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.SelectedUser = CmbUserName.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If CmbUserName.Text.Trim = "" Then
            ShowAppMessage("يرجى ادخال اسم المستخدم", AppMessageType.Warning)
            CmbUserName.Focus()
            Exit Sub
        End If
        If TxtPasswprd.Text.Trim = "" Then
            ShowAppMessage("يرجى ادخال كلمة المرور", AppMessageType.Warning)
            TxtPasswprd.Focus()
            Exit Sub
        End If

        Try
            OpenCon()
        Catch ex As Exception
            ShowAppMessage("فشل في فتح الاتصال: " & ex.Message, AppMessageType.Error)
            Exit Sub
        End Try
        Dim userRoleId As Integer = 0
        Dim authenticated As Boolean = False
        Try
            Using cmd As New SqlCommand("
    SELECT TOP 1 ID, UserName, UserPass, Userjob, LockedOut, RoleID
    FROM UserTable
    WHERE UserName = @u AND UserPass = @p AND LockedOut = 0", con)

                cmd.Parameters.AddWithValue("@u", CmbUserName.Text.Trim)
                cmd.Parameters.AddWithValue("@p", TxtPasswprd.Text)

                Using rdr As SqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        If Not rdr.IsDBNull(rdr.GetOrdinal("LockedOut")) Then
                            Dim locked = Convert.ToBoolean(rdr("LockedOut"))
                            If locked Then
                                ShowAppMessage("الحساب مقفل. تواصل مع المسؤول.", AppMessageType.Warning)
                                TxtPasswprd.Text = ""
                                TxtPasswprd.Focus()
                                Return
                            End If
                        End If

                        UserID = Convert.ToInt32(rdr("ID"))
                        UserName = Convert.ToString(rdr("UserName"))
                        UserPassword = Convert.ToString(rdr("UserPass"))
                        UserJob = If(rdr.IsDBNull(rdr.GetOrdinal("Userjob")), "", Convert.ToString(rdr("Userjob")))
                        userRoleId = If(rdr.IsDBNull(rdr.GetOrdinal("RoleID")), 0, Convert.ToInt32(rdr("RoleID")))
                        authenticated = True
                    End If
                End Using
            End Using

            If authenticated Then
                Try
                    DTUserPermission.Clear()
                    Using cmd2 As New SqlCommand("SELECT * FROM PermissionTable WHERE RoleID = @rid", con)
                        cmd2.Parameters.AddWithValue("@rid", userRoleId)
                        Using daPerm As New SqlDataAdapter(cmd2)
                            daPerm.Fill(DTUserPermission)
                        End Using
                    End Using
                Catch ex As Exception
                    ShowAppMessage("خطأ في تحميل صلاحيات المستخدم: " & ex.Message, AppMessageType.Error)
                End Try

                SWForm = False
                swactive = True
                'SetPermission()
                Me.Dispose()
            Else
                ShowAppMessage("كلمة المرور غير صحيحة  يرجى اعادة المحاولة", AppMessageType.Warning)
                TxtPasswprd.Text = ""
                TxtPasswprd.Focus()
            End If
        Catch ex As Exception
            ShowAppMessage("خطأ  اتصال بقاعدة البيانات: " & ex.Message, AppMessageType.Error)
        Finally
            Try
                CloseCon()
            Catch
            End Try
        End Try
    End Sub

    Private Sub CmbUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUserName.SelectedIndexChanged

    End Sub

    Private Sub FrmLogin_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        R.Container = Me
    End Sub
End Class
