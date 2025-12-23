Imports System.Drawing

Module UIHelpers

    Public Sub SetLtrAndFont(frm As Form, f As Font)
        If frm Is Nothing Then Return
        Try
            frm.RightToLeft = RightToLeft.No
            frm.RightToLeftLayout = False
            frm.Font = f
            ApplyToControls(frm, f)
        Catch
        End Try
    End Sub

    Private Sub ApplyToControls(parent As Control, f As Font)
        For Each c As Control In parent.Controls
            Try
                c.Font = f
                c.RightToLeft = RightToLeft.No
            Catch
            End Try
            If c.HasChildren Then ApplyToControls(c, f)
        Next
    End Sub

End Module