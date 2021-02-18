Public Class Result
    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim score As Integer = 0
        If Game.opt_america.Checked Then
            score += 1
        End If
        If Game.opt_cruz_azul.Checked Then
            score += 1
        End If
        If Game.opt_atlas.Checked Then
            score += 1
        End If
        If Game.opt_tigres.Checked Then
            score += 1
        End If
        If Game.opt_leones_negros.Checked Then
            score += 1
        End If
        If Game.opt_unam.Checked Then
            score += 1
        End If
        If Game.opt_puebla.Checked Then
            score += 1
        End If

        If score >= 5 Then
            Dim res As String = score.ToString() + Environment.NewLine + Environment.NewLine
            Me.lbl_result.Text = "¡Ganador!"
            Me.pic_result.Image = My.Resources.ResourceManager.GetObject("winner")

            If score = 7 Then
                Me.lbl_data.Text = res + "$ 5,000,000"
            ElseIf score = 6 Then
                Me.lbl_data.Text = res + "$ 50,000"
            ElseIf score = 5 Then
                Me.lbl_data.Text = res + "$ 500"
            End If
        Else
            Me.lbl_result.Text = "Perdiste."
            Me.pic_result.Image = My.Resources.ResourceManager.GetObject("loser")
            Me.lbl_data_holder.Text = "Aciertos:"
            Me.lbl_data.Text = score.ToString()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class