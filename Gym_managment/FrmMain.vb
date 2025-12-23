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
    Next iÂ
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

Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ThemeManager.Initialize()
    ThemeManager.ApplyTheme(Me)

    ' Make main form occupy the screen (maximized)
    Me.StartPosition = FormStartPosition.CenterScreen
    Me.WindowState = FormWindowState.Maximized

    ' If you want true fullscreen (no border/taskbar), uncomment:
    ' Me.FormBorderStyle = FormBorderStyle.None
    ' Me.Bounds = Screen.PrimaryScreen.Bounds
    ' Me.TopMost = True

    '  ⁄ÌÌ‰ Œÿ Times New Roman »ÕÃ„ 14 ⁄·Ï «·›Ê—„ Êﬂ· «·√œÊ« 
    Dim appFont As New Font("Times New Roman", 14.0F, FontStyle.Regular)
    Me.Font = appFont
    ApplyFontToControls(Me, appFont)

    ' Initialize theme switch state
    If msTheme IsNot Nothing Then
        msTheme.Checked = (ThemeManager.Mode = ThemeManager.ThemeMode.Dark)
    End If
End Sub