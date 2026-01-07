Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class FrmMainDite
    Private Sub TsmPlans_Click(sender As Object, e As EventArgs) Handles TsmPlans.Click
        Using f As New FrmDietPlans()
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub TsmConsultations_Click(sender As Object, e As EventArgs) Handles TsmConsultations.Click
        Using f As New FrmMemberConsultations()
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub TsmPlanDetails_Click(sender As Object, e As EventArgs) Handles TsmPlanDetails.Click


        FrmPlanDetails.ShowDialog()


    End Sub

    Private Sub TSMReport_Click(sender As Object, e As EventArgs) Handles TSMReport.Click
        FrmReportDiet.ShowDialog()
    End Sub
End Class