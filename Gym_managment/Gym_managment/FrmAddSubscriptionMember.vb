Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class FrmAddSubscriptionMember

    Private selectedMemberId As Integer = 0
    Private selectedPackageId As Integer = 0

    Private Sub FrmAddSubscriptionMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange(New Object() {"نشط", "منتهي", "موقوف"})
        If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0

        dtpStart.Value = Date.Today
        dtpEnd.Value = Date.Today

        LoadPackagesCards()
    End Sub

    Private Sub btnSelectMember_Click(sender, e) Handles btnSelectMember.Click
        Using f As New FrmSelectMember()
            If f.ShowDialog(Me) = DialogResult.OK Then
                selectedMemberId = f.SelectedMemberId
                txtMember.Text = f.SelectedMemberName
            End If
        End Using
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        selectedMemberId = 0
        selectedPackageId = 0
        txtMember.Text = ""
        dtpStart.Value = Date.Today
        dtpEnd.Value = Date.Today
        If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0
        LoadPackagesCards()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If selectedMemberId = 0 Then
            MessageBox.Show("اختر العضو أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If selectedPackageId = 0 Then
            MessageBox.Show("اختر الباقة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dtpEnd.Value.Date < dtpStart.Value.Date Then
            MessageBox.Show("تاريخ النهاية يجب أن يكون بعد تاريخ البداية.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim sql As String = "INSERT INTO MemberSubscriptions (MemberID, PackageID, StartDate, EndDate, SubscriptionStatus, TrainerID, UserID) " &
                            "VALUES (@MemberID, @PackageID, @StartDate, @EndDate, @Status, @TrainerID, @UserID)"

        Using cmd As New SqlCommand(sql, con)
            cmd.Parameters.Add("@MemberID", SqlDbType.Int).Value = selectedMemberId
            cmd.Parameters.Add("@PackageID", SqlDbType.Int).Value = selectedPackageId
            cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = dtpStart.Value.Date
            cmd.Parameters.Add("@EndDate", SqlDbType.Date).Value = dtpEnd.Value.Date
            cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = cmbStatus.SelectedItem.ToString()

            cmd.Parameters.Add("@TrainerID", SqlDbType.Int).Value = DBNull.Value
            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = If(UserID > 0, CType(UserID, Object), DBNull.Value)

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using

        MessageBox.Show("تم حفظ الاشتراك بنجاح.", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = DialogResult.OK
    End Sub

    Private Sub LoadPackagesCards()
        flPackages.SuspendLayout()
        flPackages.Controls.Clear()

        Dim dt As New DataTable()

        Using cmd As New SqlCommand("SELECT PackageID, PackageName, Price, DurationInDays FROM SubscriptionPackages WHERE ISActive = 1", con)
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        For Each r As DataRow In dt.Rows
            Dim pkgId As Integer = CInt(r("PackageID"))
            Dim name As String = r("PackageName").ToString()
            Dim priceText As String = If(dt.Columns.Contains("Price") AndAlso Not IsDBNull(r("Price")), r("Price").ToString(), "")
            Dim days As Integer = If(dt.Columns.Contains("DurationInDays") AndAlso Not IsDBNull(r("DurationInDays")), CInt(r("DurationInDays")), 30)

            Dim card As New Guna.UI2.WinForms.Guna2Panel()
            card.BorderColor = Color.FromArgb(234, 153, 149)
            card.BorderThickness = 2
            card.BorderRadius = 12
            card.FillColor = Color.FromArgb(0, 9, 43)
            card.Size = New Size(300, 120)
            card.Margin = New Padding(0, 0, 12, 12)
            card.Tag = New CardTag With {.PackageId = pkgId, .DurationDays = days}
            card.Cursor = Cursors.Hand

            Dim lblName As New Label()
            lblName.ForeColor = Color.White
            lblName.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
            lblName.AutoSize = False
            lblName.TextAlign = ContentAlignment.MiddleRight
            lblName.Dock = DockStyle.Top
            lblName.Height = 36
            lblName.Padding = New Padding(0, 0, 10, 0)
            lblName.Text = name

            Dim lblInfo As New Label()
            lblInfo.ForeColor = Color.FromArgb(170, 170, 170)
            lblInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
            lblInfo.AutoSize = False
            lblInfo.Dock = DockStyle.Fill
            lblInfo.Padding = New Padding(0, 0, 10, 0)
            lblInfo.TextAlign = ContentAlignment.TopRight
            lblInfo.Text = $"المدة: {days} يوم" & If(String.IsNullOrWhiteSpace(priceText), "", Environment.NewLine & $"السعر: {priceText}")

            card.Controls.Add(lblInfo)
            card.Controls.Add(lblName)

            Dim hoverEnter As EventHandler =
                Sub(sender As Object, e As EventArgs)
                    Dim src = DirectCast(sender, Control)
                    Dim p = TryCast(src, Guna.UI2.WinForms.Guna2Panel)
                    If p Is Nothing Then p = TryCast(src.Parent, Guna.UI2.WinForms.Guna2Panel)
                    If p Is Nothing Then Return

                    Dim t = TryCast(p.Tag, CardTag)

                    p.BorderColor = Color.FromArgb(193, 20, 137)
                    p.BorderThickness = 2
                    p.ShadowDecoration.Enabled = True
                    p.ShadowDecoration.Color = Color.FromArgb(193, 20, 137)
                    p.ShadowDecoration.Depth = 10
                    p.ShadowDecoration.Shadow = New Padding(0, 0, 6, 6)

                    If selectedPackageId = If(t Is Nothing, 0, t.PackageId) Then
                        p.FillColor = Color.FromArgb(36, 45, 77)
                    Else
                        p.FillColor = Color.FromArgb(14, 20, 55)
                    End If
                End Sub

            Dim hoverLeave As EventHandler =
                Sub(sender As Object, e As EventArgs)
                    Dim src = DirectCast(sender, Control)
                    Dim p = TryCast(src, Guna.UI2.WinForms.Guna2Panel)
                    If p Is Nothing Then p = TryCast(src.Parent, Guna.UI2.WinForms.Guna2Panel)
                    If p Is Nothing Then Return

                    Dim t = TryCast(p.Tag, CardTag)
                    Dim pkg As Integer = If(t Is Nothing, 0, t.PackageId)

                    p.BorderColor = Color.FromArgb(234, 153, 149)
                    p.ShadowDecoration.Enabled = False

                    If selectedPackageId = pkg Then
                        p.FillColor = Color.FromArgb(36, 45, 77)
                    Else
                        p.FillColor = Color.FromArgb(0, 9, 43)
                    End If
                End Sub

            AddHandler card.MouseEnter, hoverEnter
            AddHandler card.MouseLeave, hoverLeave
            AddHandler lblName.MouseEnter, hoverEnter
            AddHandler lblName.MouseLeave, hoverLeave
            AddHandler lblInfo.MouseEnter, hoverEnter
            AddHandler lblInfo.MouseLeave, hoverLeave

            AddHandler card.Click,
                Sub(sender As Object, e As EventArgs)
                    SelectPackageCard(DirectCast(card, Guna.UI2.WinForms.Guna2Panel), pkgId, days)
                End Sub
            AddHandler lblName.Click,
                Sub(sender As Object, e As EventArgs)
                    SelectPackageCard(DirectCast(card, Guna.UI2.WinForms.Guna2Panel), pkgId, days)
                End Sub
            AddHandler lblInfo.Click,
                Sub(sender As Object, e As EventArgs)
                    SelectPackageCard(DirectCast(card, Guna.UI2.WinForms.Guna2Panel), pkgId, days)
                End Sub

            flPackages.Controls.Add(card)
        Next

        flPackages.ResumeLayout()
    End Sub

    Private Sub SelectPackageCard(selectedCard As Guna.UI2.WinForms.Guna2Panel, pkgId As Integer, durationDays As Integer)
        selectedPackageId = pkgId
        dtpEnd.Value = dtpStart.Value.Date.AddDays(durationDays)

        For Each ctrl As Control In flPackages.Controls
            Dim p = TryCast(ctrl, Guna.UI2.WinForms.Guna2Panel)
            If p Is Nothing Then Continue For

            Dim t = TryCast(p.Tag, CardTag)
            Dim idVal As Integer = If(t Is Nothing, 0, t.PackageId)

            If idVal = pkgId Then
                p.FillColor = Color.FromArgb(36, 45, 77)
                p.BorderColor = Color.FromArgb(193, 20, 137)
            Else
                p.FillColor = Color.FromArgb(0, 9, 43)
                p.BorderColor = Color.FromArgb(234, 153, 149)
            End If
        Next
    End Sub

    Private NotInheritable Class CardTag
        Public Property PackageId As Integer
        Public Property DurationDays As Integer
    End Class

End Class