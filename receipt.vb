Imports MessagingToolkit.QRCode.Codec
Public Class receipt
    Private Sub receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call qrcodeGen()
        lbRecieptID.Text = CheckoutForm.idTranTBX.Text
        lbQty.Text = CheckoutForm.Qty.Value
        lbtotal.Text = CheckoutForm.TotalPriceTBX.Text
        lbCat.Text = BookingForm.ComboBox1.Text
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
        PictureBox3.Image = bmp

        bmp.Save(My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & Me.Text & ".png", Imaging.ImageFormat.Png)
        Me.Close()
        BookingForm.TopLevel = False
        user.Panel1.Controls.Add(BookingForm)
        BookingForm.BringToFront()
        BookingForm.Show()
        BookingForm.clear()


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label13_Click_1(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Close()
        BookingForm.TopLevel = False
        user.Panel1.Controls.Add(BookingForm)
        BookingForm.BringToFront()
        BookingForm.Show()
        BookingForm.clear()
    End Sub
End Class