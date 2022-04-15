Imports MySql.Data.MySqlClient
Public Class UserForm
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Updatedata()
        clear()



        idUserTBX.Enabled = False

    End Sub

    Sub clear()
        idUserTBX.Text = ""
        UserNameTBX.Text = ""
        EmailTBX.Text = ""
        PasswordTBX.Text = ""
        RoleCBX.SelectedIndex = -1
        BunifuFlatButton1.Enabled = True
        BunifuFlatButton2.Enabled = False
        BunifuFlatButton3.Enabled = False
        BunifuFlatButton4.Enabled = False




    End Sub

    Sub Updatedata()
        Conn.Open()
        da = New MySqlDataAdapter("select * from tb_user order by id_user", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_user")
        Me.DgvUser.DataSource = (ds.Tables("tb_user"))
        Conn.Close()
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If UserNameTBX.Text = "" Or EmailTBX.Text = "" Or PasswordTBX.Text = "" Or RoleCBX.SelectedIndex = -1 Then
            MsgBox("Data Yang Anda Input Belum Lengkap")
        Else
            Conn.Open()
            Dim inputdata As String
            inputdata = "insert into tb_user values('""','" & UserNameTBX.Text & "','" & EmailTBX.Text & "','" & PasswordTBX.Text & "','" & RoleCBX.SelectedItem.ToString() & "')"
            cmd = New MySqlCommand(inputdata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("User Berhasil Ditambahkan")
            Conn.Close()
            Updatedata()
            clear()
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If idUserTBX.Text = "" Or UserNameTBX.Text = "" Or EmailTBX.Text = "" Or PasswordTBX.Text = "" Or RoleCBX.SelectedIndex = -1 Then
            MsgBox("Data Yang Anda Input Belum Lengkap")
        Else
            Conn.Open()
            Dim Editdata As String
            Editdata = "update tb_user set id_user = '" & idUserTBX.Text & "',username = '" & UserNameTBX.Text & "',email_user = '" & EmailTBX.Text & "',passwd = '" & PasswordTBX.Text & "',role = '" & RoleCBX.SelectedItem.ToString() & "'  where id_user='" & idUserTBX.Text & "' "
            cmd = New MySqlCommand(Editdata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Update Data User Berhasil")
            Conn.Close()
            Updatedata()
            clear()

        End If
    End Sub


    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        If idUserTBX.Text = "" Then
            MsgBox("Anda Belum Memilih Item")
        Else
            Conn.Open()
            Dim deletedata As String
            deletedata = "delete from tb_user where id_user = '" & idUserTBX.Text & "' "
            cmd = New MySqlCommand(deletedata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("User Berhasil Di Hapus")
            Conn.Close()
            Updatedata()
            clear()
        End If
    End Sub
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        clear()

    End Sub

    Private Sub DgvUser_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUser.CellDoubleClick
        Dim row As DataGridViewRow = DgvUser.Rows(e.RowIndex)
        idUserTBX.Text = row.Cells(0).Value.ToString
        UserNameTBX.Text = row.Cells(1).Value.ToString
        EmailTBX.Text = row.Cells(2).Value.ToString
        PasswordTBX.Text = row.Cells(3).Value.ToString
        RoleCBX.SelectedItem = row.Cells(4).Value.ToString

        BunifuFlatButton1.Enabled = False
        BunifuFlatButton2.Enabled = True
        BunifuFlatButton3.Enabled = True
        BunifuFlatButton4.Enabled = True
    End Sub


End Class