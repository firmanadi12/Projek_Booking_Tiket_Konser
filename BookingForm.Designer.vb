<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookingForm))
        Me.idTBX = New ns1.BunifuMetroTextbox()
        Me.NameTBX = New ns1.BunifuMetroTextbox()
        Me.EmailTBX = New ns1.BunifuMetroTextbox()
        Me.TlpTBX = New ns1.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbemail = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.DateTBX = New ns1.BunifuMetroTextbox()
        Me.VanueTBX = New ns1.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EventCBX = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idTBX
        '
        Me.idTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.idTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.idTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.idTBX.BorderThickness = 3
        Me.idTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.idTBX.ForeColor = System.Drawing.Color.White
        Me.idTBX.isPassword = False
        Me.idTBX.Location = New System.Drawing.Point(24, 159)
        Me.idTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.idTBX.Name = "idTBX"
        Me.idTBX.Size = New System.Drawing.Size(302, 44)
        Me.idTBX.TabIndex = 3
        Me.idTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'NameTBX
        '
        Me.NameTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.NameTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NameTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.NameTBX.BorderThickness = 3
        Me.NameTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NameTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.NameTBX.ForeColor = System.Drawing.Color.White
        Me.NameTBX.isPassword = False
        Me.NameTBX.Location = New System.Drawing.Point(24, 251)
        Me.NameTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTBX.Name = "NameTBX"
        Me.NameTBX.Size = New System.Drawing.Size(302, 44)
        Me.NameTBX.TabIndex = 4
        Me.NameTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'EmailTBX
        '
        Me.EmailTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.EmailTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EmailTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.EmailTBX.BorderThickness = 3
        Me.EmailTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.EmailTBX.ForeColor = System.Drawing.Color.White
        Me.EmailTBX.isPassword = False
        Me.EmailTBX.Location = New System.Drawing.Point(24, 348)
        Me.EmailTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailTBX.Name = "EmailTBX"
        Me.EmailTBX.Size = New System.Drawing.Size(302, 44)
        Me.EmailTBX.TabIndex = 5
        Me.EmailTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TlpTBX
        '
        Me.TlpTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.TlpTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TlpTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.TlpTBX.BorderThickness = 3
        Me.TlpTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TlpTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TlpTBX.ForeColor = System.Drawing.Color.White
        Me.TlpTBX.isPassword = False
        Me.TlpTBX.Location = New System.Drawing.Point(24, 444)
        Me.TlpTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.TlpTBX.Name = "TlpTBX"
        Me.TlpTBX.Size = New System.Drawing.Size(302, 44)
        Me.TlpTBX.TabIndex = 6
        Me.TlpTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(25, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID ( KTP / PASSPOR)"
        '
        'lbemail
        '
        Me.lbemail.AutoSize = True
        Me.lbemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbemail.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbemail.Location = New System.Drawing.Point(25, 328)
        Me.lbemail.Name = "lbemail"
        Me.lbemail.Size = New System.Drawing.Size(47, 16)
        Me.lbemail.TabIndex = 12
        Me.lbemail.Text = "EMAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(25, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(25, 424)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "PHONE NUMBER"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(19, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Booking Ticket"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(358, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 16)
        Me.Label8.TabIndex = 18
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "NEXT >>"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(367, 559)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(356, 48)
        Me.BunifuFlatButton1.TabIndex = 23
        Me.BunifuFlatButton1.Text = "NEXT >>"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DateTBX
        '
        Me.DateTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.DateTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.DateTBX.BorderThickness = 3
        Me.DateTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DateTBX.ForeColor = System.Drawing.Color.White
        Me.DateTBX.isPassword = False
        Me.DateTBX.Location = New System.Drawing.Point(364, 251)
        Me.DateTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTBX.Name = "DateTBX"
        Me.DateTBX.Size = New System.Drawing.Size(358, 44)
        Me.DateTBX.TabIndex = 31
        Me.DateTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'VanueTBX
        '
        Me.VanueTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.VanueTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VanueTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.VanueTBX.BorderThickness = 3
        Me.VanueTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VanueTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.VanueTBX.ForeColor = System.Drawing.Color.White
        Me.VanueTBX.isPassword = False
        Me.VanueTBX.Location = New System.Drawing.Point(361, 348)
        Me.VanueTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.VanueTBX.Name = "VanueTBX"
        Me.VanueTBX.Size = New System.Drawing.Size(362, 44)
        Me.VanueTBX.TabIndex = 32
        Me.VanueTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(365, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "EVENT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(364, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 16)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "DATE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(365, 328)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "VANUE"
        '
        'EventCBX
        '
        Me.EventCBX.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.EventCBX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EventCBX.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventCBX.ForeColor = System.Drawing.Color.White
        Me.EventCBX.FormattingEnabled = True
        Me.EventCBX.Location = New System.Drawing.Point(361, 171)
        Me.EventCBX.Name = "EventCBX"
        Me.EventCBX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EventCBX.Size = New System.Drawing.Size(362, 32)
        Me.EventCBX.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(712, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(638, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 24)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Logout"
        '
        'BookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(866, 663)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EventCBX)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.VanueTBX)
        Me.Controls.Add(Me.DateTBX)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbemail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TlpTBX)
        Me.Controls.Add(Me.EmailTBX)
        Me.Controls.Add(Me.NameTBX)
        Me.Controls.Add(Me.idTBX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookingForm"
        Me.Text = "booking"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idTBX As ns1.BunifuMetroTextbox
    Friend WithEvents NameTBX As ns1.BunifuMetroTextbox
    Friend WithEvents EmailTBX As ns1.BunifuMetroTextbox
    Friend WithEvents TlpTBX As ns1.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbemail As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents DateTBX As ns1.BunifuMetroTextbox
    Friend WithEvents VanueTBX As ns1.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents EventCBX As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
