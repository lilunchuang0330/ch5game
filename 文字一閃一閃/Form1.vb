Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1_Timer()
    End Sub



    Private Sub Timer1_Timer()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.ForeColor = ForeColor.Red Then



            Label1.ForeColor = ForeColor.Transparent



        Else



            Label1.ForeColor = ForeColor.Red



        End If
    End Sub
End Class
