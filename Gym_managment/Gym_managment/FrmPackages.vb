Imports Microsoft.Data.SqlClient
Imports System.Drawing
Imports Guna.UI2.WinForms

Public Class FrmPackages

    Private DTPackages As New DataTable
    Private CurrentPackageId As Integer = 0
    Private selectedCard As Guna2Panel = Nothing

    Private Sub FrmPackages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        ConfigureDetailsPanel()
        LoadPackages()
    End Sub

    Private Sub ConfigureDetailsPanel()
        'PnlDetails.Visible = False
        NumDuration.Minimum = 1
        NumDuration.Maximum = 365
        If NumDuration.Value < NumDuration.Minimum Then NumDuration.Value = NumDuration.Minimum
    End Sub

    Private Sub LoadPackages(Optional filter As String = "")
        FlpPackages.Controls.Clear()
        DTPackages.Clear()

        Try
            SQLQuery = "SELECT * FROM SubscriptionPackages"
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            DA = New SqlDataAdapter(SQLQuery, con)
            DA.Fill(DTPackages)
            con.Close()

            Dim rows = DTPackages.Select().AsEnumerable()

            If Not String.IsNullOrWhiteSpace(filter) Then
                Dim f = filter.Trim().ToLower()
                rows = rows.Where(Function(r) _
                    r("PackageName").ToString().ToLower().Contains(f) OrElse
                    r("DurationInDays").ToString().Contains(f) OrElse
                    r("Price").ToString().Contains(f)
                ).ToArray()
            End If

            For Each row In rows
                Dim card = CreatePackageCard(row)
                FlpPackages.Controls.Add(card)
            Next

        Catch ex As Exception
            ShowAppMessage("خطأ في تحميل الباقات: " & ex.Message, AppMessageType.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Function CreatePackageCard(row As DataRow) As Panel
        Dim packageId As Integer = Convert.ToInt32(row("PackageID"))
        Dim days As Integer = Convert.ToInt32(row("DurationInDays"))
        Dim price As Decimal = Convert.ToDecimal(row("Price"))
        Dim isActive As Boolean = Convert.ToBoolean(row("IsActive"))

        Dim card As New Guna2Panel() With {
            .Width = 590,
            .Height = 128,
            .Margin = New Padding(0, 0, 0, 12),
            .Padding = New Padding(14),
            .BorderRadius = 12,
            .BorderThickness = 1,
            .BorderColor = Color.FromArgb(234, 153, 149),
            .FillColor = Color.FromArgb(8, 16, 60),
            .Tag = packageId,
            .Cursor = Cursors.Hand
        }
        card.ShadowDecoration.Enabled = True
        card.ShadowDecoration.BorderRadius = 12
        card.ShadowDecoration.Color = Color.FromArgb(40, 0, 0, 0)
        card.ShadowDecoration.Depth = 10
        card.ShadowDecoration.Shadow = New Padding(2, 2, 6, 6)

        Dim lblName As New Label() With {
            .Text = row("PackageName").ToString(),
            .Font = New Font("Segoe UI", 12.0F, FontStyle.Bold),
            .ForeColor = Color.White,
            .AutoSize = False,
            .Left = 14,
            .Top = 14,
            .Width = card.Width - 28,
            .Height = 30,
            .TextAlign = ContentAlignment.MiddleLeft
        }

        Dim lblPrice As New Label() With {
            .Text = $"السعر: {price:0.00} دينار",
            .Font = New Font("Segoe UI", 10.0F, FontStyle.Regular),
            .ForeColor = Color.White,
            .AutoSize = False,
            .Left = 14,
            .Top = 54,
            .Width = card.Width - 28,
            .Height = 24,
            .TextAlign = ContentAlignment.MiddleLeft
        }

        Dim lblDays As New Label() With {
            .Text = $"المدة: {days} يوم",
            .Font = New Font("Segoe UI", 10.0F, FontStyle.Regular),
            .ForeColor = Color.White,
            .AutoSize = False,
            .Left = 14,
            .Top = 80,
            .Width = card.Width - 28,
            .Height = 24,
            .TextAlign = ContentAlignment.MiddleLeft
        }

        Dim statusText As String = If(isActive, "نشطة", "غير مفعلة")
        Dim statusColor As Color = If(isActive, Color.FromArgb(76, 175, 80), Color.FromArgb(244, 67, 54))
        Dim lblState As New Label() With {
            .Text = statusText,
            .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
            .ForeColor = Color.White,
            .BackColor = statusColor,
            .AutoSize = False,
            .Width = 90,
            .Height = 22,
            .Left = 14,
            .Top = 16,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        ' في WinForms (RTL) جهة اليمين هي X=14 داخل الكارد
        lblState.Left = 14

        card.Controls.Add(lblName)
        card.Controls.Add(lblPrice)
        card.Controls.Add(lblDays)
        card.Controls.Add(lblState)
        lblState.BringToFront()

        Dim originalFill As Color = card.FillColor
        Dim originalBorder As Color = card.BorderColor

        Dim hoverEnter As EventHandler =
        Sub(sender As Object, e As EventArgs)
            If selectedCard IsNot Nothing AndAlso Object.ReferenceEquals(card, selectedCard) Then Return
            card.FillColor = Color.FromArgb(12, 24, 80)
        End Sub

        Dim hoverLeave As EventHandler =
        Sub(sender As Object, e As EventArgs)
            If selectedCard IsNot Nothing AndAlso Object.ReferenceEquals(card, selectedCard) Then Return
            card.FillColor = originalFill
        End Sub

        AddHandler card.MouseEnter, hoverEnter
        AddHandler card.MouseLeave, hoverLeave
        For Each ctl As Control In card.Controls
            AddHandler ctl.MouseEnter, hoverEnter
            AddHandler ctl.MouseLeave, hoverLeave
        Next

        Dim clickHandler As EventHandler =
        Sub(sender As Object, e As EventArgs)
            If selectedCard IsNot Nothing AndAlso Not Object.ReferenceEquals(selectedCard, card) Then
                selectedCard.BorderColor = Color.FromArgb(234, 153, 149)
                selectedCard.BorderThickness = 1
                selectedCard.FillColor = Color.FromArgb(8, 16, 60)
            End If

            selectedCard = card
            card.BorderColor = Color.FromArgb(193, 20, 137)
            card.BorderThickness = 2
            card.FillColor = Color.FromArgb(12, 24, 80)

            Dim found = DTPackages.Select($"PackageID = {packageId}").FirstOrDefault()
            If found IsNot Nothing Then
                EditPackage(found)
            End If
        End Sub

        AddHandler card.Click, clickHandler
        For Each ctl As Control In card.Controls
            AddHandler ctl.Click, clickHandler
        Next

        Return card
    End Function
    Private Sub EditPackage(row As DataRow)
        Try
            CurrentPackageId = Convert.ToInt32(row("PackageID"))
            TxtpackName.Text = row("PackageName").ToString()

            Dim days As Integer = CInt(NumDuration.Minimum)
            If row.Table.Columns.Contains("DurationInDays") AndAlso Not IsDBNull(row("DurationInDays")) Then
                Integer.TryParse(row("DurationInDays").ToString(), days)
            End If

            days = Math.Max(CInt(NumDuration.Minimum), Math.Min(CInt(NumDuration.Maximum), days))

            NumDuration.Value = days
            NumDuration.Refresh()
            NumDuration.Update()

            TxtPrice.Text = Convert.ToDecimal(row("Price")).ToString("0.00")
            ChkIsActive.Checked = Convert.ToBoolean(row("IsActive"))

            PnlDetails.Visible = True
            PnlDetails.BringToFront()
            NumDuration.Focus()
        Catch ex As Exception
            ShowAppMessage("خطأ في تحميل بيانات الباقة للتعديل: " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub DeletePackage(row As DataRow)
        Dim name = row("PackageName").ToString()
        If MessageBox.Show("هل أنت متأكد من حذف الباقة: " & name & " ؟", "تأكيد الحذف",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = DialogResult.Yes Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Using cmd As New SqlCommand("UPDATE SubscriptionPackages SET IsActive = 0 WHERE PackageID = @id", con)
                    cmd.Parameters.AddWithValue("@id", row("PackageID"))
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
                ShowAppMessage("تم حذف الباقة (تعطيلها) بنجاح", AppMessageType.Success)
                LoadPackages(TxtSearch.Text)
            Catch ex As Exception
                ShowAppMessage("خطأ في حذف الباقة: " & ex.Message, AppMessageType.Error)
            Finally
                If con.State = ConnectionState.Open Then con.Close()
            End Try
        End If
    End Sub




    'Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
    '    PnlDetails.Visible = False
    'End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        LoadPackages(TxtSearch.Text)
    End Sub

    Private Sub BtnAddPack_Click(sender As Object, e As EventArgs) Handles BtnAddPack.Click
        If String.IsNullOrWhiteSpace(TxtpackName.Text) Then
            ShowAppMessage("يرجى إدخال اسم الباقة", AppMessageType.Warning)
            Return
        End If

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            If CurrentPackageId = 0 Then
                Using cmd As New SqlCommand("INSERT INTO SubscriptionPackages (PackageName, DurationInDays, Price, IsActive) VALUES(@n,@d,@p,@a)", con)
                    cmd.Parameters.AddWithValue("@n", TxtpackName.Text.Trim())
                    cmd.Parameters.AddWithValue("@d", CInt(NumDuration.Value))
                    cmd.Parameters.AddWithValue("@p", Decimal.Parse(TxtPrice.Text))
                    cmd.Parameters.AddWithValue("@a", ChkIsActive.Checked)
                    cmd.ExecuteNonQuery()
                End Using
                ShowAppMessage("تم إضافة الباقة بنجاح", AppMessageType.Success)
            Else
                Using cmd As New SqlCommand("UPDATE SubscriptionPackages SET PackageName=@n, DurationInDays=@d, Price=@p, IsActive=@a WHERE PackageID=@id", con)
                    cmd.Parameters.AddWithValue("@id", CurrentPackageId)
                    cmd.Parameters.AddWithValue("@n", TxtpackName.Text.Trim())
                    cmd.Parameters.AddWithValue("@d", CInt(NumDuration.Value))
                    cmd.Parameters.AddWithValue("@p", Decimal.Parse(TxtPrice.Text))
                    cmd.Parameters.AddWithValue("@a", ChkIsActive.Checked)
                    cmd.ExecuteNonQuery()
                End Using
                ShowAppMessage("تم تعديل بيانات الباقة بنجاح", AppMessageType.Success)
            End If

            con.Close()
            'PnlDetails.Visible = False
            LoadPackages(TxtSearch.Text)

        Catch ex As Exception
            ShowAppMessage("خطأ في حفظ بيانات الباقة: " & ex.Message, AppMessageType.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        CurrentPackageId = 0
        TxtpackName.Text = ""
        NumDuration.Value = 30
        TxtPrice.Text = ""
        ChkIsActive.Checked = True
        PnlDetails.Visible = True
    End Sub

    Private Sub BtnUpdatePack_Click(sender As Object, e As EventArgs) Handles BtnUpdatePack.Click
        If CurrentPackageId = 0 Then
            ShowAppMessage("اختر باقة من القائمة أولاً للتعديل", AppMessageType.Warning)
            Return
        End If

        BtnAddPack_Click(sender, e)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

    End Sub
End Class