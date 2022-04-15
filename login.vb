Imports MySql.Data.MySqlClient
Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()

    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If (usernameTBX.Text = "") Then
            MsgBox("Please enter Username")
            usernameTBX.Focus()
        End If
        If (passwordTBX.Text = "") Then
            MsgBox("Please enter Password")
            passwordTBX.Focus()
        End If

        Conn.Open()
        Dim query As String = "select role from tb_user where username=@d1 and passwd=@d2"
        cmd = New MySqlCommand(query, Conn)
        cmd.Parameters.AddWithValue("@d1", usernameTBX.Text)
        cmd.Parameters.AddWithValue("@d2", passwordTBX.Text)
        rdr = cmd.ExecuteReader()

        If (rdr.Read()) Then
            Form1.lbUsertype.Text = rdr.GetValue(0)
            Form1.lbUsername.Text = usernameTBX.Text
            Form1.lbDate.Text = Now

            If usernameTBX.Text = "admin" Then
                Form1.Panel2.Dock = DockStyle.Fill
                Admin.TopLevel = False
                Form1.Panel2.Controls.Add(Admin)
                Admin.BringToFront()
                Admin.Show()
                usernameTBX.Text = ""
                passwordTBX.Text = ""


            Else
                user.TopLevel = False
                Form1.Panel2.Controls.Add(user)
                user.BringToFront()
                user.Show()
                usernameTBX.Text = ""
                passwordTBX.Text = ""


            End If


        Else
            MsgBox("Please enter the valid username and password,", MsgBoxStyle.Critical, "Login Denied")
            usernameTBX.Text = ""
            passwordTBX.Text = ""
            usernameTBX.Focus()

            Conn.Close()
        End If



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            passwordTBX.UseSystemPasswordChar = False
        Else
            passwordTBX.UseSystemPasswordChar = True
        End If
    End Sub
End Class