Imports MySql.Data.MySqlClient
Public Class BookingForm


    Private Sub booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        List_event()


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

        End While
        Conn.Close()
    End Sub

    Public Sub clearbiodata()
        idTBX.Text = ""
        NameTBX.Text = ""
        TlpTBX.Text = ""
        EmailTBX.Text = ""
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If idTBX.Text = "" Or NameTBX.Text = "" Or EmailTBX.Text = "" Or TlpTBX.Text = "" Then
            MsgBox("Data Yang Anda Inputkan Belum Lengkap")
        Else
            CheckoutForm.TopLevel = False
            Form1.Panel2.Controls.Add(CheckoutForm)
            CheckoutForm.BringToFront()
            CheckoutForm.Show()
        End If
    End Sub


    Private Sub EventCBX_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles EventCBX.SelectionChangeCommitted
        GetVenueDate()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CheckoutForm.Close()
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