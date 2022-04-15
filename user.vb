Public Class user
    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BookingForm.TopLevel = False
        Panel1.Controls.Add(BookingForm)
        BookingForm.BringToFront()
        BookingForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CheckoutForm.Close()
        BookingForm.Close()
        Me.Close()
        login.TopLevel = False
        Form1.Panel2.Controls.Add(login)
        login.BringToFront()
        login.Show()
        Form1.lbUsertype.Text = "-"
        Form1.lbUsername.Text = "-"
        Form1.Panel2.Dock = DockStyle.Right
    End Sub
End Class