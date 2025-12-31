Imports System.ComponentModel
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Drawing

Partial Public Class FrmMain

    Private Title As String = " منظومة إدارة نادي رياضي"
    Private SWBTNItem, SWInvoClick, SWStoreClick As Boolean
    Private SWInvoText, SWStoreText, StrBack As String

    Private R As New ResizeControls()

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ThemeManager.Initialize()
        'ThemeManager.ApplyTheme(Me)


        ' Initialize theme switch state
        'If msTheme IsNot Nothing Then
        '    msTheme.Checked = (ThemeManager.Mode = ThemeManager.ThemeMode.Dark)
        'End If
    End Sub

    'Private Sub msTheme_CheckedChanged(sender As Object, e As EventArgs) Handles msTheme.CheckedChanged
    '    If msTheme.Checked Then
    '        ThemeManager.Mode = ThemeManager.ThemeMode.Dark
    '    Else
    '        ThemeManager.Mode = ThemeManager.ThemeMode.Light
    '    End If
    '    ThemeManager.ApplyTheme(Me)
    'End Sub

    Private Sub BtnCautch_Click(sender As Object, e As EventArgs) Handles BtnCautch.Click
        OpenForm(FrmTrainers, BtnCautch)
    End Sub

    Private Sub OpenForm(F As Form, B As Button)
        If F.Visible = True Then
            HideOpenForms()
        Else
            HideOpenForms()
            F.TopLevel = False
            F.Parent = PnlMain
            F.BringToFront()
            F.Show()
            F.Visible = True
            F.Size = PnlMain.Size
            F.Dock = DockStyle.Fill

            Me.Text = Title & " - " & B.Text
            B.BackColor = Color.White
            B.ForeColor = Color.Black
            B.Font = New Font("Hacen Saudi Arabia", 11, FontStyle.Regular)

        End If
    End Sub

    Private Sub HideOpenForms()
        ' iterate only actual Button controls to avoid InvalidCastException
        For Each BB As Button In Panel1.Controls.OfType(Of Button)()
            If BB.BackColor <> DefaultBackColor Then
                BB.BackColor = DefaultBackColor
                BB.ForeColor = Color.Black
                BB.Font = New Font("Hacen Saudi Arabia", 11, FontStyle.Regular)
            End If
        Next
        Me.Text = Title

        For Each FF As Form In Application.OpenForms
            If FF.Name <> "FrmMain" Then
                FF.Hide()
                FF.Visible = False
            End If
        Next
    End Sub

    Private Sub CloseOpenForms()
        For Each BB As Button In Panel1.Controls.OfType(Of Button)()
            BB.BackColor = DefaultBackColor
            BB.ForeColor = Color.Black
            BB.Font = New Font("Hacen Saudi Arabia", 11, FontStyle.Regular)
        Next
        Me.Text = Title

        For i = Application.OpenForms.Count - 1 To 1 Step -1
            Dim F As Form = Application.OpenForms(i)
            If F.Name <> "FrmMain" Then
                F.Close()
            End If
        Next i
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Tag >= 1 Then
            Timer1.Tag = Timer1.Tag + 1
        End If
        If Timer1.Tag = 5 Then
            Timer1.Tag = 0
            TSLMessage.Visible = False
            StatusStrip1.BackColor = Color.FromArgb(192, 192, 255)
        End If
        TSLDateTime.Text = Now
        TSLUserName.Text = CurrentUsername & " - " & CurrentRoleName

        'If swactive = True Then
        '    UserTrafficRegister("FrmMain", 1)
        '    swactive = False
        'End If

    End Sub




    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles BtnCustomer.Click
        OpenForm(FrmManagememberr, BtnCustomer)

    End Sub

    Private Sub BtnSubscribtion_Click(sender As Object, e As EventArgs) Handles BtnSubscribtion.Click

        FrmPackages.ShowDialog()

    End Sub

    Private Sub BtnMemberSubscription_Click(sender As Object, e As EventArgs) Handles BtnMemberSubscription.Click
        FrmManageMemberPackages.ShowDialog()

    End Sub

    Private Sub BtnTrainingBooking_Click(sender As Object, e As EventArgs) Handles BtnTrainingBooking.Click
        frmDisplayAppointment.ShowDialog()

    End Sub

    Private Sub TSMChangepassword_Click(sender As Object, e As EventArgs) Handles TSMChangepassword.Click

    End Sub

    Private Sub ApplyFontToControls(parent As Control, f As Font)
        For Each c As Control In parent.Controls
            ' Attempt to set the simple Font (works for most controls)
            Try
                c.Font = f
            Catch
                ' ignore individual failures (consider logging during development)
            End Try

            ' ToolStrip and its items are not Controls in the Controls collection;
            ' if present as a Control subclass, set each ToolStripItem's font.
            If TypeOf c Is ToolStrip Then
                Dim ts As ToolStrip = DirectCast(c, ToolStrip)
                For Each item As ToolStripItem In ts.Items
                    Try
                        item.Font = f
                    Catch
                    End Try
                Next
            End If

            ' DataGridView requires setting cell/header/default styles explicitly
            If TypeOf c Is DataGridView Then
                Dim dgv As DataGridView = DirectCast(c, DataGridView)
                Try
                    dgv.DefaultCellStyle.Font = f
                    dgv.ColumnHeadersDefaultCellStyle.Font = f
                    dgv.RowsDefaultCellStyle.Font = f
                    dgv.RowTemplate.DefaultCellStyle.Font = f
                Catch
                End Try
            End If

            ' Some third-party controls (MaterialSkin) may ignore Font;
            ' handle them here if the library exposes APIs, otherwise change design or library.
            If c.HasChildren Then
                ApplyFontToControls(c, f)
            End If
        Next
    End Sub

    Private Sub TSMTreasury_Click(sender As Object, e As EventArgs) Handles TSMTreasury.Click
        FrmTreasury.ShowDialog()

    End Sub

    Private Sub TSMPayment_Click(sender As Object, e As EventArgs) Handles TSMPayment.Click
        FrmPayment.ShowDialog()

    End Sub

    Private Sub TSMTransctionPayment_Click(sender As Object, e As EventArgs) Handles TSMTransctionPayment.Click
        FrmMemberTransction.ShowDialog()

    End Sub
End Class