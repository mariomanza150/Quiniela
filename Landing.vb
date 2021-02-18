Public Class Landing
    Private Sub btn_continue_Click(sender As Object, e As EventArgs) Handles btn_continue.Click
        Game.Show()
        Me.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class
