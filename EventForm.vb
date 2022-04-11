Imports MySql.Data.MySqlClient
Public Class EventForm
    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Updatedata()
        clear()


    End Sub

    Sub clear()
        eventnameTBX.Text = ""
        vanueTBX.Text = ""
        BunifuFlatButton1.Enabled = True
        BunifuFlatButton2.Enabled = False
        BunifuFlatButton4.Enabled = False
        Updatedata()

    End Sub

    Sub AutoEventID()
        Dim DR As DataRow
        Dim s As String
        DR = SQLTable("select max(right(id_event,1)) as nomor from tb_event").Rows(0)
        If DR.IsNull("Nomor") Then
            s = "EID1"
        Else
            s = "EID" & Format(DR("Nomor") + 1, "0")
        End If
        ideventTBX.Text = s
        ideventTBX.Enabled = False
    End Sub

    Sub Updatedata()
        Conn.Open()
        da = New MySqlDataAdapter("select id_event as ID_Event,nama_event as Event_Name,tgl_event as Date, tempat as Vanue from tb_event order by id_event", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_event")
        Me.DgvEvent.DataSource = (ds.Tables("tb_event"))
        AutoEventID()
        Conn.Close()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If eventnameTBX.Text = "" Or vanueTBX.Text = "" Then
            MsgBox("Data Yang Anda Input Belum Lengkap")
        Else
            Conn.Open()
            Dim inputdata As String
            inputdata = "insert into tb_event values('" & ideventTBX.Text & "','" & eventnameTBX.Text & "','" & Format(EventDate.Value, "yyyy-MM-dd") & "','" & vanueTBX.Text & "')"
            cmd = New MySqlCommand(inputdata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Event Berhasil Ditambahkan")
            Conn.Close()
            Updatedata()
            clear()
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If eventnameTBX.Text = "" Or vanueTBX.Text = "" Then
            MsgBox("Data Yang Anda Input Belum Lengkap")
        Else
            Conn.Open()
            Dim Editdata As String
            Editdata = "update tb_event set nama_event = '" & eventnameTBX.Text & "',tgl_event ='" & Format(EventDate.Value, "yyyy-MM-dd") & "',tempat = '" & vanueTBX.Text & "'  where id_event='" & ideventTBX.Text & "' "
            cmd = New MySqlCommand(Editdata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Update Data Event Berhasil")
            Conn.Close()
            Updatedata()
            clear()

        End If

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        clear()
    End Sub

    Private Sub DgvEvent_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEvent.CellDoubleClick
        Dim row As DataGridViewRow = DgvEvent.Rows(e.RowIndex)
        ideventTBX.Text = row.Cells(0).Value.ToString
        eventnameTBX.Text = row.Cells(1).Value.ToString
        EventDate.Value = row.Cells(2).Value
        vanueTBX.Text = row.Cells(3).Value.ToString

        BunifuFlatButton1.Enabled = False
        BunifuFlatButton2.Enabled = True
        BunifuFlatButton4.Enabled = True

    End Sub


End Class