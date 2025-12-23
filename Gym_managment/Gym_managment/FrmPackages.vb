Imports Microsoft.Data.SqlClient
Imports System.Drawing

Public Class FrmPackages

    Private DTPackages As New DataTable
    Private CurrentPackageId As Integer = 0

    Private Sub FrmPackages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigureDetailsPanel()
        LoadPackages()
    End Sub

    Private Sub ConfigureDetailsPanel()

        'PnlDetails.Visible = False
        NumDuration.Minimum = 1
        NumDuration.Maximum = 365
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
        Dim days As Integer = Convert.ToInt32(row("DurationInDays"))
        Dim price As Decimal = Convert.ToDecimal(row("Price"))
        Dim isActive As Boolean = Convert.ToBoolean(row("IsActive"))


        Dim primaryColor As Color
        If Not isActive Then

            primaryColor = Color.FromArgb(224, 216, 255)
        ElseIf days <= 30 Then

            primaryColor = Color.FromArgb(129, 212, 250)   ' Sky Blue
        ElseIf days <= 90 Then

            primaryColor = Color.FromArgb(174, 234, 0)     ' Lime Green
        Else

            primaryColor = Color.FromArgb(255, 128, 171)   ' Pink
        End If

        Dim card As New Panel() With {
        .Width = 260,
        .Height = 140,
        .Margin = New Padding(10),
        .BorderStyle = BorderStyle.None,
        .Tag = row("PackageID"),
        .Cursor = Cursors.Hand,
    .Font = New Font("Times New Roman", 14, FontStyle.Regular),
        .BackColor = Color.Transparent
    }

        Dim accentPanel As New Panel() With {
        .Dock = DockStyle.Fill,
        .BackColor = primaryColor,
        .Padding = New Padding(2)
    }
        card.Controls.Add(accentPanel)

        Dim contentPanel As New Panel() With {
        .Dock = DockStyle.Fill,
        .BackColor = Color.White
    }
        accentPanel.Controls.Add(contentPanel)

        Dim lblName As New Label() With {
        .Text = row("PackageName").ToString(),
    .Font = New Font("Times New Roman", 12, FontStyle.Bold),
        .ForeColor = Color.FromArgb(33, 33, 33),
        .AutoSize = False,
        .Dock = DockStyle.Top,
        .Height = 36,
        .TextAlign = ContentAlignment.MiddleCenter,
        .UseCompatibleTextRendering = True
    }

        Dim lblInfo As New Label() With {
        .Text = days.ToString() & " يوم" & Environment.NewLine &
                price.ToString("0.00") & " دينار",
    .Font = New Font("Times New Roman", 12, FontStyle.Regular),
        .ForeColor = Color.FromArgb(66, 66, 66),
        .AutoSize = False,
        .Dock = DockStyle.Fill,
        .TextAlign = ContentAlignment.MiddleCenter,
        .UseCompatibleTextRendering = True
    }

        Dim statusColor As Color = If(isActive,
                                  Color.FromArgb(76, 175, 80),
                                  Color.FromArgb(158, 158, 158))

        Dim lblStatus As New Label() With {
        .Text = If(isActive, "نشطة", "غير نشطة"),
        .AutoSize = False,
        .Width = 78,
        .Height = 24,
        .Top = 8,
        .Left = 8,
        .BackColor = statusColor,
        .ForeColor = Color.White,
    .Font = New Font("Times New Roman", 12, FontStyle.Bold),
        .TextAlign = ContentAlignment.MiddleCenter,
        .UseCompatibleTextRendering = True
    }

        contentPanel.Controls.Add(lblInfo)
        contentPanel.Controls.Add(lblName)
        contentPanel.Controls.Add(lblStatus)

        Dim originalContentColor As Color = contentPanel.BackColor
        Dim originalAccentColor As Color = accentPanel.BackColor

        Dim hoverEnter As EventHandler =
        Sub(sender As Object, e As EventArgs)
            accentPanel.BackColor = Color.FromArgb(
                Math.Min(originalAccentColor.R + 15, 255),
                Math.Min(originalAccentColor.G + 15, 255),
                Math.Min(originalAccentColor.B + 15, 255))
            contentPanel.BackColor = Color.FromArgb(250, 250, 255)
            card.Padding = New Padding(0, 0, 0, 4)
        End Sub

        Dim hoverLeave As EventHandler =
        Sub(sender As Object, e As EventArgs)
            accentPanel.BackColor = originalAccentColor
            contentPanel.BackColor = originalContentColor
            card.Padding = New Padding(0)
        End Sub

        AddHandler card.MouseEnter, hoverEnter
        AddHandler card.MouseLeave, hoverLeave
        For Each ctl As Control In contentPanel.Controls
            AddHandler ctl.MouseEnter, hoverEnter
            AddHandler ctl.MouseLeave, hoverLeave
        Next

        Dim clickHandler As EventHandler =
        Sub(sender As Object, e As EventArgs)
            EditPackage(row)
        End Sub

        AddHandler card.Click, clickHandler
        For Each ctl As Control In contentPanel.Controls
            AddHandler ctl.Click, clickHandler
        Next

        Return card
    End Function
    Private Sub EditPackage(row As DataRow)
        Try
            CurrentPackageId = Convert.ToInt32(row("PackageID"))
            TxtpackName.Text = row("PackageName").ToString()
            NumDuration.Value = Convert.ToInt32(row("DurationInDays"))
            TxtPrice.Text = Convert.ToDecimal(row("Price")).ToString("0.00")
            ChkIsActive.Checked = Convert.ToBoolean(row("IsActive"))

            PnlDetails.Visible = True
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