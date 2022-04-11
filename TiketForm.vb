Imports MySql.Data.MySqlClient
Public Class TiketForm
    Private Sub TiketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        List_event()
        Updatedata()
        clear()


    End Sub

    Sub clear()
        IdTiketTBX.Text = ""
        CategoryTBX.Text = ""
        PriceTBX.Text = ""
        QuotaTBX.Text = ""
        EventCBX.SelectedIndex = -1
        BunifuFlatButton1.Enabled = True
        BunifuFlatButton2.Enabled = False
        BunifuFlatButton3.Enabled = False
        BunifuFlatButton4.Enabled = False

        EventCBX.Enabled = True
        IdTiketTBX.Enabled = True
        CategoryTBX.Enabled = True


    End Sub

    Sub List_event()
        Conn.Open()
        Dim dt As DataTable
        Dim sqlstr As String
        Dim data As Integer

        sqlstr = "select id_event,nama_event from tb_event"
        da = New MySqlDataAdapter(sqlstr, Conn)
        dt = New DataTable
        data = da.Fill(dt)

        EventCBX.DisplayMember = "nama_event"
        EventCBX.ValueMember = "id_event"
        EventCBX.DataSource = dt
        Conn.Close()
    End Sub

    Sub Updatedata()
        Conn.Open()
        da = New MySqlDataAdapter("select * from tb_tiket order by id_tiket", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_tiket")
        Me.DgvTiket.DataSource = (ds.Tables("tb_tiket"))
        Conn.Close()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If IdTiketTBX.Text = "" Or CategoryTBX.Text = "" Or PriceTBX.Text = "" Or QuotaTBX.Text = "" Then
            MsgBox("Data Yang Anda Input Belum Lengkap")
        Else
            Conn.Open()
            Dim inputdata As String
            inputdata = "insert into tb_tiket values('" & IdTiketTBX.Text & "','" & EventCBX.SelectedValue.ToString() & "','" & CategoryTBX.Text & "','" & PriceTBX.Text & "','" & QuotaTBX.Text & "')"
            cmd = New MySqlCommand(inputdata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data tiket Berhasil Ditambahkan")
            Conn.Close()
            Updatedata()
            clear()
        End If
    End Sub
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If IdTiketTBX.Text = "" Or CategoryTBX.Text = "" Or PriceTBX.Text = "" Or QuotaTBX.Text = "" Then
            MsgBox("Data Yang Anda Input Belum Lengkap")
        Else
            Conn.Open()
            Dim Editdata As String
            Editdata = "update tb_tiket set id_tiket = '" & IdTiketTBX.Text & "',kategori = '" & CategoryTBX.Text & "',harga = '" & PriceTBX.Text & "',kuota = '" & QuotaTBX.Text & "'  where id_tiket='" & IdTiketTBX.Text & "' "
            cmd = New MySqlCommand(Editdata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Update Data tiket Berhasil")
            Conn.Close()
            Updatedata()
            clear()

        End If
    End Sub


    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        If IdTiketTBX.Text = "" Then
            MsgBox("Anda Belum Memilih Item")
        Else
            Conn.Open()
            Dim deletedata As String
            deletedata = "delete from tb_tiket where id_tiket = '" & IdTiketTBX.Text & "' "
            cmd = New MySqlCommand(deletedata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Tiket Berhasil Di Hapus")
            Conn.Close()
            Updatedata()
            clear()
        End If
    End Sub


    Private Sub DgvTiket_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTiket.CellDoubleClick
        Dim row As DataGridViewRow = DgvTiket.Rows(e.RowIndex)
        IdTiketTBX.Text = row.Cells(0).Value.ToString
        CategoryTBX.Text = row.Cells(2).Value.ToString
        PriceTBX.Text = row.Cells(3).Value.ToString
        QuotaTBX.Text = row.Cells(4).Value.ToString

        BunifuFlatButton1.Enabled = False
        BunifuFlatButton2.Enabled = True
        BunifuFlatButton3.Enabled = True
        BunifuFlatButton4.Enabled = True
        EventCBX.Enabled = False
        IdTiketTBX.Enabled = False
        CategoryTBX.Enabled = False

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        clear()

    End Sub
End Class