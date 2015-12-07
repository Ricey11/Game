Public Class Track_1

       Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                C1.Top -= 4
            Case Keys.Down
                C1.Top += 4
           

        End Select
    End Sub



    
End Class