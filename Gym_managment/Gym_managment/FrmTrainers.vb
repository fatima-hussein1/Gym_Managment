Imports Microsoft.Data.SqlClient
'Imports MaterialSkin
Imports System.Drawing

Partial Public Class FrmTrainers

    Private DTTrainers As New DataTable


    Private Sub FrmTrainers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_Trainers()
    End Sub


    Public Sub Load_Trainers()
        dgvTrainers.Rows.Clear()
        DTTrainers.Clear()
        Try
            SQLQuery = "SELECT * FROM Trainers where Active =1 "
            DA = New SqlDataAdapter(SQLQuery, con)
            DA.Fill(DTTrainers)

            For i As Integer = 0 To DTTrainers.Rows.Count - 1
                dgvTrainers.Rows.Add()

                dgvTrainers.Item(0, i).Value = DTTrainers.Rows(i).Item("TrainerID")
                dgvTrainers.Item(1, i).Value = DTTrainers.Rows(i).Item("Name")
                dgvTrainers.Item(2, i).Value = DTTrainers.Rows(i).Item("PhoneNumber")

                If Not IsDBNull(DTTrainers.Rows(i).Item("HireDate")) Then
                    Dim hireDate As Date = CDate(DTTrainers.Rows(i).Item("HireDate"))
                    dgvTrainers.Item(3, i).Value = hireDate.ToString("dd-MM-yyyy", Globalization.CultureInfo.InvariantCulture)
                Else
                    dgvTrainers.Item(3, i).Value = ""
                End If

                dgvTrainers.Item(4, i).Value = DTTrainers.Rows(i).Item("UserID")

                If Not IsDBNull(DTTrainers.Rows(i).Item("PicTrainer")) Then
                    Dim imgData As Byte() = DirectCast(DTTrainers.Rows(i).Item("PicTrainer"), Byte())
                    Using ms As New IO.MemoryStream(imgData)
                        dgvTrainers.Item(5, i).Value = Image.FromStream(ms)
                    End Using
                Else
                    dgvTrainers.Item(5, i).Value = Nothing
                End If
            Next
        Catch ex As Exception
            ShowAppMessage("›‘· ›Ì «·« ’«· »ﬁÊ«⁄œ «·»Ì«‰« : " & ex.Message, AppMessageType.Error)
        End Try
    End Sub

    Private Sub DgvTrainers_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvTrainers.DataError
        e.ThrowException = False
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs)
        'Dim f As New FrmTrainerEdit()
        'If f.ShowDialog() = DialogResult.OK Then
        '    LoadTrainers()
        'End If
    End Sub

    Private Sub BtnAddtrain_Click(sender As Object, e As EventArgs) Handles BtnAddtrain.Click
        FrmAddTrainer.Trainer_ID = 0
        FrmAddTrainer.CLEARITEMS()
        FrmAddTrainer.BtnAddTrainer.Enabled = True
        FrmAddTrainer.BtnUpdateTrainer.Enabled = False
        FrmAddTrainer.ShowDialog()
    End Sub

    Private Sub DgvTrainers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrainers.CellContentClick
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = 6 Then
            With FrmAddTrainer
                .Trainer_ID = dgvTrainers.CurrentRow.Cells(0).Value
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim Cmd As New SqlCommand("Select * from Trainers Where TrainerID=@TrainerID", con)
                Cmd.Parameters.AddWithValue("@TrainerID", .Trainer_ID)
                Dim rdr As SqlDataReader = Cmd.ExecuteReader()
                rdr.Read()
                If rdr.HasRows Then
                    .TxtName.Text = rdr("Name").ToString()
                    .TxtPhone.Text = rdr("PhoneNumber").ToString()
                    If Not IsDBNull(rdr("HireDate")) Then
                        .DtpDate.Value = Convert.ToDateTime(rdr("HireDate"))
                    Else
                        .DtpDate.Value = Now
                    End If

                    If Not IsDBNull(rdr("PicTrainer")) Then
                        Dim imgData As Byte() = DirectCast(rdr("PicTrainer"), Byte())
                        Dim ms As New IO.MemoryStream(imgData)
                        .Pictrainer.Image = Image.FromStream(ms)
                    Else
                        .Pictrainer.Image = Nothing
                    End If

                    rdr.Close()
                    con.Close()
                    .Text = " ⁄œÌ· »Ì«‰«  «·„œ—»"
                    .BtnAddTrainer.Enabled = False
                    .BtnUpdateTrainer.Enabled = True
                    .ShowDialog()
                Else
                    rdr.Close()
                    con.Close()
                End If
            End With

        ElseIf e.ColumnIndex = 7 Then
            If MsgBox("Â· √‰  „ √ﬂœ „‰ Õ–› Â–« «·„œ—»ø", MsgBoxStyle.Question + MsgBoxStyle.YesNo, " √ﬂÌœ «·Õ–›") = MsgBoxResult.Yes Then
                Try
                    If con.State = ConnectionState.Open Then con.Close()
                    con.Open()
                    Dim Cmd As New SqlCommand("UPDATE Trainers SET Active=0 WHERE TrainerID=@TrainerID", con)
                    Cmd.Parameters.AddWithValue("@TrainerID", dgvTrainers.CurrentRow.Cells(0).Value)
                    Cmd.ExecuteNonQuery()
                    con.Close()
                    ShowAppMessage(" „ Õ–› «·„œ—» »‰Ã«Õ", AppMessageType.Success)
                    Load_Trainers()
                Catch ex As Exception
                    ShowAppMessage("Œÿ√ ›Ì «·Õ–›: " & ex.Message, AppMessageType.Error)
                Finally
                    If con.State = ConnectionState.Open Then con.Close()
                End Try
            End If
        End If
    End Sub

End Class