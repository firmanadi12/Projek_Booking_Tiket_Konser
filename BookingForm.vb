Imports MySql.Data.MySqlClient
Public Class BookingForm


    Private Sub booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        'List_Category()
        List_event()


    End Sub

    Sub List_Category()


        Dim dt As DataTable
        Dim sqlstr As String
        Dim data As Integer

        sqlstr = "select id_tiket,kategori from tb_tiket where id_event ='" & EventCBX.SelectedValue.ToString() & "'"
        da = New MySqlDataAdapter(sqlstr, Conn)
        dt = New DataTable
        data = da.Fill(dt)

        ComboBox1.DisplayMember = "kategori"
        ComboBox1.ValueMember = "id_tiket"
        ComboBox1.DataSource = dt

        Conn.Close()
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

    Sub GetVenueDate()
        Conn.Open()
        Dim vanueDate = "select * from tb_event where id_event='" & EventCBX.SelectedValue.ToString() & "'"
        Dim cmd As New MySqlCommand(vanueDate, Conn)
        Dim dtb As New DataTable
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            DateTBX.Text = "" + reader("tgl_event")
            VanueTBX.Text = "" + reader("tempat")
            CheckoutForm.EventTBX.Text = "" + reader("nama_event")

        End While
        Conn.Close()
    End Sub

    Public Sub clear()
        idTBX.Text = ""
        NameTBX.Text = ""
        TlpTBX.Text = ""
        EmailTBX.Text = ""
        EventCBX.SelectedIndex = -1
        DateTBX.Text = ""
        VanueTBX.Text = ""
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If idTBX.Text = "" Or NameTBX.Text = "" Or EmailTBX.Text = "" Or TlpTBX.Text = "" Then
            MsgBox("Data Yang Anda Inputkan Belum Lengkap")
        Else
            CheckoutForm.GetPrice()
            CheckoutForm.TopLevel = False
            user.Panel1.Controls.Add(CheckoutForm)
            CheckoutForm.BringToFront()
            CheckoutForm.Show()
        End If
    End Sub


    Private Sub EventCBX_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles EventCBX.SelectionChangeCommitted
        GetVenueDate()
        List_Category()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub


End Class