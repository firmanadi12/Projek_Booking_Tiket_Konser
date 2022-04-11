Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.TopLevel = False
        Panel2.Controls.Add(login)
        login.BringToFront()
        login.Show()


    End Sub


End Class
