Imports System.Data.SqlClient
Imports System.IO
Module MdlFunction

    
    Public Sub ClearText(ByVal G As GroupBox, P As PictureBox)

        For Each C As Control In G.Controls
            If TypeOf C Is TextBox Or TypeOf C Is ComboBox Then
                C.Text = ""
            End If
        Next

        If P IsNot Nothing Then P.Image = Nothing

        'If P IsNot Nothing Then
        '    P.Image = Nothing
        'End If

    End Sub


    Public Sub MessageStatus(MSG As String, Style As Boolean)
        If Style = True Then
            FrmMain.StatusStrip1.BackColor = Color.FromArgb(128, 255, 128)
        ElseIf Style = False Then
            FrmMain.StatusStrip1.BackColor = Color.FromArgb(255, 128, 128)
        End If
        FrmMain.TSLMessage.Visible = True
        FrmMain.TSLMessage.Text = MSG

        FrmMain.Timer1.Tag = 1
    End Sub
    Public Function ImageToByte(Pic As PictureBox) As Byte()
        Dim MS As New MemoryStream
        If Not IsNothing(Pic.Image) Then Pic.Image.Save(MS, Pic.Image.RawFormat)
        Return MS.ToArray()
    End Function

    Public Function ByteToImage(Img As Byte()) As Image
        Dim MS As New MemoryStream(Img)
        Return Image.FromStream(MS)
    End Function

    Public Function CheckDGVError(DGV As DataGridView) As Boolean
        Try
            If DGV.CurrentRow.Index = DGV.Rows.Count Or DGV.Item(0, 0).Value = Nothing Or DGV.Item(0, DGV.CurrentRow.Index).Value.ToString = vbNullString Then
                Return True
            End If
        Catch When Err.Number = 91
            Return True
        End Try

        Return False
    End Function

    Public Function CheckDSError(DS As DataSet) As Boolean
        Dim Result As Boolean
        If DS.Tables.Count > 0 Then
            For Each DT As DataTable In DS.Tables
                If (DT.Rows.Count = 0) Then Result = True
            Next
        Else
            Result = True
        End If
        Return Result
    End Function

    Public Sub Clear(ByVal G As GroupBox)
        Dim Cmb As ComboBox = Nothing
        Dim P As PictureBox = Nothing
        For Each C As Control In G.Controls
            If TypeOf C Is TextBox Then
                C.Text = ""
            End If

            If TypeOf C Is ComboBox Then
                Cmb = DirectCast(C, ComboBox)
                Cmb.SelectedIndex = -1
            End If

            If TypeOf C Is PictureBox Then
                P = DirectCast(C, PictureBox)
                P.Image = Nothing
            End If
        Next

    End Sub

    'Public Sub UserTrafficRegister(ByVal Frm As String, Entry As Boolean)
    '    If UserID = 0 Then
    '        Exit Sub
    '    End If
    '    Try
    '        CMD = New SqlCommand("UserTrafficRegister", con)
    '        CMD.CommandType = CommandType.StoredProcedure
    '        Dim param(2) As SqlParameter

    '        param(0) = New SqlParameter("@UserID", UserID)
    '        param(1) = New SqlParameter("@NewFormName", Frm)
    '        param(2) = New SqlParameter("@Entry", Entry)
    '        CMD.Parameters.AddRange(param)

    '        con.Open()
    '        CMD.ExecuteNonQuery()
    '        con.Close()
    '        'ملاحظة : يوجد Trigger يعمل على جدول مراقبة حركة المستخدمين ويقوم تلقائيا بحذف اي حركة قديمة قبل 120 يوم
    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox("خطأ في تحديث بيانت حركة المستخدم" + ex.Message, MsgBoxStyle.Critical, "خطأ إتصال بقواعد البيانات")
    '    End Try
    'End Sub

    'Public Sub SetPermission()
    '    Dim Perm() As DataRow

    '    '----------فواتير المبيعات----------------
    '    Perm = DTUserPermission.Select("OperationID=1")
    '    If Perm(0)(3) = False And Perm(0)(4) = False And Perm(0)(5) = False And Perm(0)(6) = False Then
    '        FrmMain.BtnCustomer.Enabled = False
    '    Else
    '        FrmMain.BtnCustomer.Enabled = True

    '        FrmCustomer.BtnAddCost.Enabled = Perm(0)(3) ' INSERT
    '        'FrmCustomer.BtnUpdateCost.Enabled = Perm(0)(4) 'UPDATE
    '        FrmCustomer.BtnDeleteCost.Enabled = Perm(0)(5)    'delete
    '        'FrmInvoReport.BtnPrintSearch.Enabled = Perm(0)(6) 'PRINT
    '    End If

    '    '---------إدارة الأصناف-----------------
    '    Perm = DTUserPermission.Select("OperationID=2")
    '    If Perm(0)(3) = False And Perm(0)(4) = False And Perm(0)(5) = False And Perm(0)(6) = False Then
    '        FrmMain.BtnProduct.Enabled = False
    '    Else
    '        FrmMain.BtnProduct.Enabled = True
    '        FrmProduct.BtnAddPrd.Enabled = Perm(0)(3) ' INSERT
    '        FrmProduct.BtnUpdatPrd.Enabled = Perm(0)(4) 'UPDATE
    '        FrmProduct.BtnDeletePrd.Enabled = Perm(0)(5) 'DELETE
    '        'FrmStore.PicPrint.Enabled = Perm(0)(6) 'PRINT
    '    End If

    '    ''---------إدارة خدمات------------------------------
    '    Perm = DTUserPermission.Select("OperationID=3")
    '    If Perm(0)(3) = False And Perm(0)(4) = False And Perm(0)(5) = False Then
    '        FrmMain.BtnServices.Enabled = False
    '    Else
    '        FrmMain.BtnServices.Enabled = True
    '        FrmService.BtnSaveServ.Enabled = Perm(0)(3) ' INSERT
    '        FrmService.BtnUpdatServ.Enabled = Perm(0)(4) 'UPDATE
    '        'FrmService.BtnDeleteServ.Enabled = Perm(0)(5) 'DELETE
    '        'FrmStore.PicPrint.Enabled = Perm(0)(6) 'PRINT
    '    End If

    '    'Perm = DTUserPermission.Select("OperationID=4")
    '    'ffffffff.TsmDeletedElements.Enabled = Perm(0)(3)


    '    'Perm = DTUserPermission.Select("OperationID=5")
    '    'ffffffff.TsmSettings.Enabled = Perm(0)(3)


    '    'Perm = DTUserPermission.Select("OperationID=6")
    '    'ffffffff.TsmMonitor.Enabled = Perm(0)(3)

    '    'Perm = DTUserPermission.Select("OperationID=7")
    '    'ffffffff.TsmUserControl.Enabled = Perm(0)(3)


    '    'Perm = DTUserPermission.Select("OperationID=8")
    '    'ffffffff.BtnInvoReport.Enabled = Perm(0)(3)
    '    ''FrmMain.BtnChart.Enabled = Perm(0)(3)
    '    ''--------------------------------------------------------------
    'End Sub
    ''================حركة الخزنة


    'Public Function treasurynow(tn As Integer) As Double
    '    con.Close()
    '    con.Open()
    '    Try
    '        Dim balance As Double
    '        Dim sqlcmd As SqlCommand = New SqlCommand("select * from treasury_nameTABLE where treasury_id = @tn", con)
    '        sqlcmd.Parameters.AddWithValue("@tn", tn)
    '        Dim sdr As SqlDataReader = sqlcmd.ExecuteReader()
    '        sdr.Read()
    '        If sdr.HasRows Then
    '            balance = sdr("balace")
    '        Else
    '            balance = 0.00
    '        End If


    '        sdr.Close()
    '        con.Close()
    '        Return balance

    '    Catch ex As Exception
    '        Return 0
    '    End Try

    'End Function

    'Public Function treasuryedit(money As Double, Mtype As Integer, tn As Integer) As Double
    '    ' if Mtype = 1 then add money if Mtype = 2 then substract money
    '    Try
    '        Dim balance As Double
    '        Dim sqlcmd As SqlCommand = New SqlCommand("select * from treasury_nameTABLE where treasury_id = @tn", con)
    '        sqlcmd.Parameters.AddWithValue("@tn", tn)
    '        Dim sdr As SqlDataReader = sqlcmd.ExecuteReader()
    '        sdr.Read()
    '        If sdr.HasRows Then
    '            balance = sdr("balace")
    '        Else
    '            balance = 0.00
    '        End If

    '        If Mtype = 1 Then
    '            balance = balance + money
    '        ElseIf Mtype = 2 Then
    '            balance = balance - money
    '        Else
    '            Return 0
    '        End If
    '        sdr.Close()

    '        Return balance

    '    Catch ex As Exception
    '        Return 0
    '    End Try

    'End Function
    'Public Function treasurybalance(bl As Double, tn As Integer) As String
    '    Try
    '        Dim sqlcmd As SqlCommand = New SqlCommand("update treasury_nameTABLE set balace = @bl where treasury_id = @tn", con)
    '        sqlcmd.Parameters.AddWithValue("@bl", bl)
    '        sqlcmd.Parameters.AddWithValue("@tn", tn)
    '        sqlcmd.ExecuteNonQuery()
    '        Return "done"
    '    Catch ex As Exception
    '        Return ex.InnerException.Message
    '    End Try
    'End Function

    'Public Function treasury_pay(Treasuryname, movement, Treasury_date, Treasury_time, Treasury_type, Treasury_user, income, Expenses, balace, code_trans) As Boolean

    '    Dim adp = New SqlDataAdapter("select * from treasury_pay", con)
    '    Dim ds = New DataSet
    '    adp.Fill(ds)
    '    Dim dt = ds.Tables(0)
    '    Dim dr = dt.NewRow
    '    dr!Treasuryname = Treasuryname
    '    dr!movement = movement
    '    dr!Treasury_date = Treasury_date
    '    dr!Treasury_time = Treasury_time
    '    dr!Treasury_type = Treasury_type
    '    dr!Treasury_user = Treasury_user
    '    dr!income = Convert.ToDecimal(income)
    '    dr!Expenses = Convert.ToDecimal(Expenses)
    '    dr!balace = Convert.ToDecimal(balace)
    '    dr!code_trans = code_trans
    '    dt.Rows.Add(dr)
    '    Dim cmd As New SqlCommandBuilder(adp)
    '    adp.Update(dt)
    '    treasury_pay = True

    'End Function
    ''===================================================================
    ''توليد رقم تلقائي
    'Public Function getlastcode(tb1name, orderbyfield) As Integer
    '    getlastcode = 0
    '    Dim str = "select " & orderbyfield & " from " & tb1name & " order by " & orderbyfield
    '    Dim adp = New SqlDataAdapter(str, con)
    '    Dim ds = New DataSet
    '    adp.Fill(ds)
    '    Dim dt As DataTable
    '    dt = ds.Tables(0)
    '    If dt.Rows.Count <> 0 Then
    '        Dim i = dt.Rows.Count - 1
    '        getlastcode = Val(dt.Rows(i).Item(orderbyfield))
    '    End If
    'End Function

    Public Enum AppMessageType
        Success   ' أخضر
        Warning   ' أصفر
        [Error]   ' أحمر
    End Enum

    Public Sub ShowAppMessage(text As String, msgType As AppMessageType, Optional caption As String = "")
        Dim icon As MessageBoxIcon
        Dim backColor As Color

        Select Case msgType
            Case AppMessageType.Success
                icon = MessageBoxIcon.Information
                backColor = Color.FromArgb(128, 255, 128) ' أخضر فاتح
                If caption = "" Then caption = "نجاح"
            Case AppMessageType.Warning
                icon = MessageBoxIcon.Warning
                backColor = Color.FromArgb(255, 255, 192) ' أصفر فاتح
                If caption = "" Then caption = "تنبيه"
            Case AppMessageType.Error
                icon = MessageBoxIcon.Error
                backColor = Color.FromArgb(255, 128, 128) ' أحمر فاتح
                If caption = "" Then caption = "خطأ"
        End Select

        ' تغيير شريط الحالة في الفورم الرئيسي مثل MessageStatus
        Try
            FrmMain.StatusStrip1.BackColor = backColor
            FrmMain.TSLMessage.Visible = True
            FrmMain.TSLMessage.Text = text
            FrmMain.Timer1.Tag = 1
        Catch
            ' في حال FrmMain غير محمّل نتجاهل الخطأ
        End Try

        ' رسالة منبثقة عادية
        MessageBox.Show(text, caption, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    End Sub

End Module
