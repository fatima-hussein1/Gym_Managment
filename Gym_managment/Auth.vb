Imports Microsoft.Data.SqlClient

'Public Module Auth
'    ' Returns DataRow of user if authenticated; otherwise Nothing.
'    Public Function AuthenticateUser(username As String, password As String) As DataRow
'        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then Return Nothing
'        Try
'            OpenCon()
'            Using cmd As New SqlCommand("SELECT TOP 1 ID, UserName, UserPass, Userjob, LockedOut FROM UserTable WHERE UserName = @u", con)
'                cmd.Parameters.AddWithValue("@u", username)
'                Using da As New SqlDataAdapter(cmd)
'                    Dim dt As New DataTable()
'                    da.Fill(dt)
'                    If dt.Rows.Count = 0 Then Return Nothing
'                    Dim row As DataRow = dt.Rows(0)

'                    Dim stored = Convert.ToString(row("UserPass"))
'                    ' Compare stored password directly (no hashing verification)
'                    If stored = password Then
'                        Return row
'                    End If

'                    Return Nothing
'                End Using
'            End Using
'        Catch ex As Exception
'            ' Handle/log error in development
'            Return Nothing
'        Finally
'            Try
'                CloseCon()
'            Catch
'            End Try
'        End Try
'    End Function
'End Module