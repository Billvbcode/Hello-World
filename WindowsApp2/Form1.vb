Public Class Form1
    Private Sub BtnHello_Click(sender As Object, e As EventArgs) Handles BtnHello.Click
        LblHello.Text = "Hello World"    ' Write Hello World
        LblHello.BackColor = Color.Aqua  ' Background Aqua
        LblHello.ForeColor = Color.Red   ' Text Red
    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        End  ' End program without using Blue Square on Menu
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
