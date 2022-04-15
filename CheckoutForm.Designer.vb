<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckoutForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Qty = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotalPriceTBX = New ns1.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PriceTBX = New ns1.BunifuMetroTextbox()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.EventTBX = New ns1.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idTranTBX = New ns1.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton2 = New ns1.BunifuFlatButton()
        CType(Me.Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Qty
        '
        Me.Qty.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty.Location = New System.Drawing.Point(369, 221)
        Me.Qty.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.Qty.Name = "Qty"
        Me.Qty.Size = New System.Drawing.Size(254, 41)
        Me.Qty.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(366, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "TOTAL"
        '
        'TotalPriceTBX
        '
        Me.TotalPriceTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.TotalPriceTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TotalPriceTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.TotalPriceTBX.BorderThickness = 3
        Me.TotalPriceTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TotalPriceTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TotalPriceTBX.ForeColor = System.Drawing.Color.White
        Me.TotalPriceTBX.isPassword = False
        Me.TotalPriceTBX.Location = New System.Drawing.Point(369, 312)
        Me.TotalPriceTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalPriceTBX.Name = "TotalPriceTBX"
        Me.TotalPriceTBX.Size = New System.Drawing.Size(254, 44)
        Me.TotalPriceTBX.TabIndex = 32
        Me.TotalPriceTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(52, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "PRICE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(366, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "QTY"
        '
        'PriceTBX
        '
        Me.PriceTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.PriceTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PriceTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.PriceTBX.BorderThickness = 3
        Me.PriceTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PriceTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.PriceTBX.ForeColor = System.Drawing.Color.White
        Me.PriceTBX.isPassword = False
        Me.PriceTBX.Location = New System.Drawing.Point(51, 312)
        Me.PriceTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.PriceTBX.Name = "PriceTBX"
        Me.PriceTBX.Size = New System.Drawing.Size(257, 44)
        Me.PriceTBX.TabIndex = 27
        Me.PriceTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "BUY"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(369, 398)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(254, 61)
        Me.BunifuFlatButton1.TabIndex = 35
        Me.BunifuFlatButton1.Text = "BUY"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'EventTBX
        '
        Me.EventTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.EventTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EventTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.EventTBX.BorderThickness = 3
        Me.EventTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EventTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.EventTBX.ForeColor = System.Drawing.Color.White
        Me.EventTBX.isPassword = False
        Me.EventTBX.Location = New System.Drawing.Point(51, 137)
        Me.EventTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.EventTBX.Name = "EventTBX"
        Me.EventTBX.Size = New System.Drawing.Size(572, 44)
        Me.EventTBX.TabIndex = 36
        Me.EventTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(56, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "EVENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(52, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "ID TRANSACTION"
        '
        'idTranTBX
        '
        Me.idTranTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.idTranTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.idTranTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.idTranTBX.BorderThickness = 3
        Me.idTranTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idTranTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.idTranTBX.ForeColor = System.Drawing.Color.White
        Me.idTranTBX.isPassword = False
        Me.idTranTBX.Location = New System.Drawing.Point(51, 218)
        Me.idTranTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.idTranTBX.Name = "idTranTBX"
        Me.idTranTBX.Size = New System.Drawing.Size(257, 44)
        Me.idTranTBX.TabIndex = 38
        Me.idTranTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(22, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 25)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "CHECKOUT"
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "<<  BACK"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(51, 398)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(118, 61)
        Me.BunifuFlatButton2.TabIndex = 41
        Me.BunifuFlatButton2.Text = "<<  BACK"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CheckoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(820, 648)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idTranTBX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EventTBX)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Qty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TotalPriceTBX)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PriceTBX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CheckoutForm"
        Me.Text = "Form2"
        CType(Me.Qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Qty As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents TotalPriceTBX As ns1.BunifuMetroTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PriceTBX As ns1.BunifuMetroTextbox
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents EventTBX As ns1.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents idTranTBX As ns1.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuFlatButton2 As ns1.BunifuFlatButton
End Class
