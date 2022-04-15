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
        Dashboard.Close()
        ReportForm.Close()

    End Sub

    Private Sub DataTiketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTiketToolStripMenuItem.Click
        TiketForm.TopLevel = False
        Me.Panel1.Controls.Add(TiketForm)
        TiketForm.BringToFront()
        TiketForm.Show()
        EventForm.Close()
        UserForm.Close()
        Dashboard.Close()
        ReportForm.Close()



    End Sub


    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        UserForm.TopLevel = False
        Me.Panel1.Controls.Add(UserForm)
        UserForm.BringToFront()
        UserForm.Show()
        EventForm.Close()
        TiketForm.Close()
        Dashboard.Close()
        ReportForm.Close()

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dashboard.TopLevel = False
        Panel1.Controls.Add(Dashboard)
        Dashboard.BringToFront()
        Dashboard.Show()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dashboard.TopLevel = False
        Panel1.Controls.Add(Dashboard)
        Dashboard.BringToFront()
        Dashboard.Show()
        EventForm.Close()
        TiketForm.Close()
        UserForm.Close()
        ReportForm.Close()


    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        ReportForm.TopLevel = False
        Panel1.Controls.Add(ReportForm)
        ReportForm.BringToFront()
        ReportForm.Show()
        EventForm.Close()
        TiketForm.Close()
        UserForm.Close()
        Dashboard.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class