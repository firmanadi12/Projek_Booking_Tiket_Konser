Imports MessagingToolkit.QRCode.Codec
Public Class receipt
    Private Sub receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call qrcodeGen()
        lbRecieptID.Text = CheckoutForm.idTranTBX.Text
        lbQty.Text = CheckoutForm.Qty.Value
        lbtotal.Text = CheckoutForm.TotalPriceTBX.Text
        lbCat.Text = CheckoutForm.CatCBX.Text
        lbdate.Text = BookingForm.DateTBX.Text
        lbevent.Text = CheckoutForm.EventTBX.Text
        lbVanue.Text = BookingForm.VanueTBX.Text
    End Sub

    Private Sub qrcodeGen()
        Try
            Dim qrCode As New QRCodeEncoder
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            Me.PictureBox1.Image = qrCode.Encode(CheckoutForm.idTranTBX.Text, System.Text.Encoding.UTF8)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Close()
        BookingForm.clearbiodata()
        BookingForm.TopLevel = False
        Form1.Panel2.Controls.Add(BookingForm)
        BookingForm.BringToFront()
        BookingForm.Show()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

End Class