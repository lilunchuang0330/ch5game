Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.ch5gbg
        PictureBox1.Visible = False

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans As String
        If TextBox1.Text = "3412" Then
            Me.BackgroundImage = My.Resources.ch5gbg2
            TextBox1.Visible = False
            Button1.Visible = False
            PictureBox1.Visible = True


        Else
            MsgBox("密碼錯誤，請重新輸入!")
            PictureBox1.Visible = False
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("下一章")
    End Sub
End Class
