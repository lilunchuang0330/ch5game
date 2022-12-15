Imports System.Reflection.Emit
Imports System.Security.Cryptography

Public Class Form1
    Dim a(5, 5) As Button
    Dim b(5, 5) As Button
    Public Col = 4
    Public Row = 4
    Dim block As Image = CType(My.Resources.ResourceManager.GetObject("box"), Image)
    Dim counter As Integer = 1
    Dim yn As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i, j As Integer


        For i = 0 To Row
            For j = 0 To Col
                b(i, j) = New Button
                Me.Controls.Add(b(i, j))
                b(i, j).Size = New System.Drawing.Size(40, 40)
                b(i, j).FlatStyle = FlatStyle.Flat
                b(i, j).Location = New System.Drawing.Point(220 + j * 40, 10 + i * 40)

            Next
        Next

        getnumber()

        For i = 0 To Row
            For j = 0 To Col
                a(i, j) = New Button
                Me.Controls.Add(a(i, j))
                a(i, j).Text = counter
                a(i, j).Size = New System.Drawing.Size(40, 40)
                a(i, j).FlatStyle = FlatStyle.Flat
                a(i, j).Location = New System.Drawing.Point(10 + j * 40, 10 + i * 40)
                AddHandler a(i, j).Click, AddressOf handling
                counter = counter + 1
            Next
        Next


    End Sub

    Private Sub Timer1_Timer()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If b(0, 0).ForeColor = Color.Red And b(1, 0).ForeColor = Color.Red And b(2, 0).ForeColor = Color.Red And b(3, 0).ForeColor = Color.Red And b(4, 0).ForeColor = Color.Red Then
            b(0, 0).ForeColor = Color.Black
        Else
            b(0, 0).ForeColor = Color.Red
        End If
        If b(0, 1).ForeColor = Color.Red And b(1, 1).ForeColor = Color.Red And b(2, 1).ForeColor = Color.Red And b(3, 1).ForeColor = Color.Red And b(4, 1).ForeColor = Color.Red Then
            b(0, 0).ForeColor = Color.Black
        Else
            b(0, 0).ForeColor = Color.Red
        End If
        If b(0, 2).ForeColor = Color.Red And b(1, 2).ForeColor = Color.Red And b(2, 2).ForeColor = Color.Red And b(3, 2).ForeColor = Color.Red And b(4, 2).ForeColor = Color.Red Then

        End If
        If b(0, 3).ForeColor = Color.Red And b(1, 3).ForeColor = Color.Red And b(2, 3).ForeColor = Color.Red And b(3, 3).ForeColor = Color.Red And b(4, 3).ForeColor = Color.Red Then

        End If
        If b(0, 4).ForeColor = Color.Red And b(1, 4).ForeColor = Color.Red And b(2, 4).ForeColor = Color.Red And b(3, 4).ForeColor = Color.Red And b(4, 4).ForeColor = Color.Red Then

        End If
        If b(0, 0).ForeColor = Color.Red And b(0, 1).ForeColor = Color.Red And b(0, 2).ForeColor = Color.Red And b(0, 3).ForeColor = Color.Red And b(0, 4).ForeColor = Color.Red Then

        End If
        If b(1, 0).ForeColor = Color.Red And b(1, 1).ForeColor = Color.Red And b(1, 2).ForeColor = Color.Red And b(1, 3).ForeColor = Color.Red And b(1, 4).ForeColor = Color.Red Then

        End If
        If b(2, 0).ForeColor = Color.Red And b(2, 1).ForeColor = Color.Red And b(2, 2).ForeColor = Color.Red And b(2, 3).ForeColor = Color.Red And b(2, 4).ForeColor = Color.Red Then

        End If
        If b(3, 0).ForeColor = Color.Red And b(3, 1).ForeColor = Color.Red And b(3, 2).ForeColor = Color.Red And b(3, 3).ForeColor = Color.Red And b(3, 4).ForeColor = Color.Red Then

        End If
        If b(4, 0).ForeColor = Color.Red And b(4, 1).ForeColor = Color.Red And b(4, 2).ForeColor = Color.Red And b(4, 3).ForeColor = Color.Red And b(4, 4).ForeColor = Color.Red Then

        End If
        If b(0, 0).ForeColor = Color.Red And b(1, 1).ForeColor = Color.Red And b(2, 2).ForeColor = Color.Red And b(3, 3).ForeColor = Color.Red And b(4, 4).ForeColor = Color.Red Then

        End If
        If b(0, 4).ForeColor = Color.Red And b(1, 3).ForeColor = Color.Red And b(2, 2).ForeColor = Color.Red And b(3, 1).ForeColor = Color.Red And b(4, 0).ForeColor = Color.Red Then

        End If
    End Sub

    Private Sub getnumber()
        Dim r As Random
        Dim n As Integer = 1
        Dim num, n1, n2, t1, t2 As Integer


        For i = 0 To Row
            For j = 0 To Col
                b(i, j).BackgroundImage = block
                b(i, j).BackgroundImageLayout = ImageLayout.Stretch
                b(i, j).Tag = n
                n = n + 1
            Next
        Next

        r = New Random()
        For i = 0 To Row
            For j = 0 To Col
                num = r.Next((Row + 1) * (Col + 1) - 1)
                n1 = num \ (Row + 1)
                n2 = num Mod (Col + 1)


                t1 = b(i, j).Tag
                t2 = b(n1, n2).Tag
                b(i, j).Tag = t2
                b(n1, n2).Tag = t1
            Next
        Next

    End Sub

    Private Sub handling(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i, j, n As Integer
        Dim btn = CType(sender, Button)
        n = btn.Text
        btn.Enabled = False

        For i = 0 To Row
            For j = 0 To Col
                If b(i, j).Tag = n Then
                    b(i, j).BackgroundImage = Nothing
                    b(i, j).FlatAppearance.BorderColor = Color.Red
                    b(i, j).ForeColor = Color.Red
                    b(i, j).Text = b(i, j).Tag
                    If b(0, 0).ForeColor = Color.Red And b(1, 0).ForeColor = Color.Red And b(2, 0).ForeColor = Color.Red And b(3, 0).ForeColor = Color.Red And b(4, 0).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()

                    End If
                    If b(0, 1).ForeColor = Color.Red And b(1, 1).ForeColor = Color.Red And b(2, 1).ForeColor = Color.Red And b(3, 1).ForeColor = Color.Red And b(4, 1).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                    If b(0, 2).ForeColor = Color.Red And b(1, 2).ForeColor = Color.Red And b(2, 2).ForeColor = Color.Red And b(3, 2).ForeColor = Color.Red And b(4, 2).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                    If b(0, 3).ForeColor = Color.Red And b(1, 3).ForeColor = Color.Red And b(2, 3).ForeColor = Color.Red And b(3, 3).ForeColor = Color.Red And b(4, 3).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                    If b(0, 4).ForeColor = Color.Red And b(1, 4).ForeColor = Color.Red And b(2, 4).ForeColor = Color.Red And b(3, 4).ForeColor = Color.Red And b(4, 4).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                    If b(0, 0).ForeColor = Color.Red And b(0, 1).ForeColor = Color.Red And b(0, 2).ForeColor = Color.Red And b(0, 3).ForeColor = Color.Red And b(0, 4).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                    If b(1, 0).ForeColor = Color.Red And b(1, 1).ForeColor = Color.Red And b(1, 2).ForeColor = Color.Red And b(1, 3).ForeColor = Color.Red And b(1, 4).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                    If b(2, 0).ForeColor = Color.Red And b(2, 1).ForeColor = Color.Red And b(2, 2).ForeColor = Color.Red And b(2, 3).ForeColor = Color.Red And b(2, 4).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                    If b(3, 0).ForeColor = Color.Red And b(3, 1).ForeColor = Color.Red And b(3, 2).ForeColor = Color.Red And b(3, 3).ForeColor = Color.Red And b(3, 4).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                    If b(4, 0).ForeColor = Color.Red And b(4, 1).ForeColor = Color.Red And b(4, 2).ForeColor = Color.Red And b(4, 3).ForeColor = Color.Red And b(4, 4).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                    If b(0, 0).ForeColor = Color.Red And b(1, 1).ForeColor = Color.Red And b(2, 2).ForeColor = Color.Red And b(3, 3).ForeColor = Color.Red And b(4, 4).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                    If b(0, 4).ForeColor = Color.Red And b(1, 3).ForeColor = Color.Red And b(2, 2).ForeColor = Color.Red And b(3, 1).ForeColor = Color.Red And b(4, 0).ForeColor = Color.Red Then
                        MsgBox("bingo")
                        Me.Hide()
                    End If
                End If
            Next
        Next




    End Sub
End Class
