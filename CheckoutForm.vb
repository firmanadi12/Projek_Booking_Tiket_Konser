Imports MySql.Data.MySqlClient
Public Class CheckoutForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        GetPrice()
        generatnum()
    End Sub

    Sub generatnum()
        idTranTBX.Text = ""
        idTranTBX.Text = "IDTR-" + Date.Now.ToString("yyMMddhhmmss")
    End Sub

    Public Sub GetPrice()
        Conn.Open()
        Dim GetPrice = "select id_tiket,harga from tb_tiket where id_tiket='" & BookingForm.ComboBox1.SelectedValue.ToString() & "'"
        Dim cmd As New MySqlCommand(GetPrice, Conn)
        Dim dtb As New DataTable
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            PriceTBX.Text = Convert.ToInt32(reader("harga").ToString())

        End While
        Conn.Close()
        Qty.Value = 0
    End Sub

    Private Sub TotalPrice()
        Dim total As Integer
        total = Val(PriceTBX.Text) * Qty.Value
        TotalPriceTBX.Text = total
    End Sub

    Public Sub clear()
        PriceTBX.Text = ""
        Qty.Value = 0
        TotalPriceTBX.Text = ""
    End Sub

    Private Sub UpdateTicket()
        Conn.Open()
        Dim update As String
        update = "update tb_tiket set kuota = kuota -'" & Qty.Value & "' where id_tiket='" & BookingForm.ComboBox1.SelectedValue.ToString() & "' "
        cmd = New MySqlCommand(update, Conn)
        cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub

    Private Sub CatCBX_SelectionChangeCommitted(sender As Object, e As EventArgs)
        clear()
        GetPrice()
    End Sub

    Private Sub Qty_ValueChanged(sender As Object, e As EventArgs) Handles Qty.ValueChanged
        TotalPrice()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click


        If Qty.Value = 0 Then
            MsgBox("Data yang anda input belum lengkap")
        Else
            Conn.Open()
            Dim inputdata As String
            inputdata = "insert into tb_transaksi values('" & idTranTBX.Text & "','" & BookingForm.idTBX.Text & "','" & BookingForm.NameTBX.Text & "','" & BookingForm.EmailTBX.Text & "','" & BookingForm.TlpTBX.Text & "','" & BookingForm.ComboBox1.SelectedValue.ToString() & "','" & Format(DateTime.Now, "yyyy-MM-dd") & "','" & Qty.Value & "','" & TotalPriceTBX.Text & "' )"
            cmd = New MySqlCommand(inputdata, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Transaksi Berhasil")
            Conn.Close()
            UpdateTicket()
            receipt.ShowDialog()
            generatnum()
        End If

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

        BookingForm.TopLevel = False
        user.Panel1.Controls.Add(BookingForm)
        BookingForm.BringToFront()
        BookingForm.Show()


    End Sub

End Class