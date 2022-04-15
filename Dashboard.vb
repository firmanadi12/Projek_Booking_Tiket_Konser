Imports MySql.Data.MySqlClient
Public Class Dashboard


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        DataTransaksi()
        CountCustomers()
        CountRevenue()
        CountEvent()
        List_event()
        CountTicketSold()
        CountTicketAvail()



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
    Private Sub CountCustomers()
        Conn.Open()

        Dim CCustomer As Integer
        Dim query = "select COUNT(*) from tb_transaksi"
        cmd = New MySqlCommand(query, Conn)
        CCustomer = cmd.ExecuteScalar
        CountCustLB.Text = CCustomer
        Conn.Close()
    End Sub

    Private Sub CountTicketSold()
        Conn.Open()
        Dim CTicketSold As Integer
        Dim query = "SELECT sum(qty) from ((tb_transaksi inner join tb_tiket on tb_transaksi.id_tiket = tb_tiket.id_tiket) inner join tb_event on tb_tiket.id_event=tb_event.id_event) where tb_event.id_event ='" & EventCBX.SelectedValue.ToString() & "'"
        cmd = New MySqlCommand(query, Conn)
        CTicketSold = cmd.ExecuteScalar
        CountSoldLB.Text = CTicketSold.ToString()
        If CountSoldLB.Text Is DBNull.Value Then
            CountSoldLB.Text = 0
        End If

        Conn.Close()
    End Sub

    Private Sub CountTicketAvail()
        Conn.Open()
        Dim CTicketAvail As Integer
        Dim query = "select sum(kuota) from tb_tiket where id_event='" & EventCBX.SelectedValue.ToString() & "'"
        cmd = New MySqlCommand(query, Conn)
        CTicketAvail = cmd.ExecuteScalar
        CountAvailLB.Text = CTicketAvail.ToString()


        If CountAvailLB.Text Is DBNull.Value Then
            CountAvailLB.Text = 0
        End If

        Conn.Close()
    End Sub

    Private Sub CountRevenue()
        Conn.Open()
        Dim CRevenue As Integer
        Dim query = "select sum(total_harga) from tb_transaksi"
        cmd = New MySqlCommand(query, Conn)
        CRevenue = cmd.ExecuteScalar
        CountRevLB.Text = FormatCurrency(CRevenue)
        Conn.Close()
    End Sub

    Private Sub CountEvent()
        Conn.Open()
        Dim CEvent As Integer
        Dim query = "select count(*) from tb_event"
        cmd = New MySqlCommand(query, Conn)
        CEvent = cmd.ExecuteScalar
        CountEventLB.Text = CEvent
        Conn.Close()
    End Sub

    Sub DataTransaksi()
        Conn.Open()

        da = New MySqlDataAdapter("select tb_transaksi.id_transaksi,tb_transaksi.nama_pembeli,tb_transaksi.email_pembeli,tb_transaksi.no_telp,tb_event.nama_event,tb_tiket.kategori,tb_tiket.harga, tb_transaksi.tgl_pesan, tb_transaksi.qty, tb_transaksi.total_harga from ((tb_transaksi inner join tb_tiket on tb_transaksi.id_tiket = tb_tiket.id_tiket) inner join tb_event on tb_tiket.id_event = tb_event.id_event);", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_transaksi")
        Me.DgvTransaction.DataSource = (ds.Tables("tb_transaksi"))
        Conn.Close()

    End Sub

    Private Sub SearchTbx_OnValueChanged(sender As Object, e As EventArgs) Handles SearchTbx.OnValueChanged
        Conn.Close()

        da = New MySqlDataAdapter("select tb_transaksi.id_transaksi,tb_transaksi.nama_pembeli,tb_transaksi.email_pembeli,tb_transaksi.no_telp,tb_event.nama_event,tb_tiket.kategori, tb_transaksi.tgl_pesan, tb_transaksi.qty, tb_transaksi.total_harga from ((tb_transaksi inner join tb_tiket on tb_transaksi.id_tiket = tb_tiket.id_tiket) inner join tb_event on tb_tiket.id_event = tb_event.id_event) where id_transaksi   like '%" & SearchTbx.Text & "%' or nama_pembeli like '%" & SearchTbx.Text & "%'", Conn)
        ds = New DataSet
        da.Fill(ds, "tb_transaksi")
        DgvTransaction.DataSource = (ds.Tables("tb_transaksi"))


    End Sub

    Private Sub EventCBX_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles EventCBX.SelectionChangeCommitted
        CountTicketAvail()
        CountTicketSold()
    End Sub
End Class