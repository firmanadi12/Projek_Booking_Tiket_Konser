Public Class Admin
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        login.TopLevel = False
        Form1.Panel2.Controls.Add(login)
        login.BringToFront()
        login.Show()
        Form1.lbUsertype.Text = "-"
        Form1.lbUsername.Text = "-"
        Form1.Panel2.Dock = DockStyle.Right
    End Sub

    Private Sub DataEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataEventToolStripMenuItem.Click
        EventForm.TopLevel = False
        Me.Panel1.Controls.Add(EventForm)
        EventForm.BringToFront()
        EventForm.Show()
        TiketForm.Close()
        UserForm.Close()


    End Sub

    Private Sub DataTiketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTiketToolStripMenuItem.Click
        TiketForm.TopLevel = False
        Me.Panel1.Controls.Add(TiketForm)
        TiketForm.BringToFront()
        TiketForm.Show()
        EventForm.Close()
        UserForm.Close()


    End Sub


    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        UserForm.TopLevel = False
        Me.Panel1.Controls.Add(UserForm)
        UserForm.BringToFront()
        UserForm.Show()
        EventForm.Close()
        TiketForm.Close()
    End Sub
End Class