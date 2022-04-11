<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ideventTBX = New ns1.BunifuMetroTextbox()
        Me.eventnameTBX = New ns1.BunifuMetroTextbox()
        Me.vanueTBX = New ns1.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EventDate = New ns1.BunifuDatepicker()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton2 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton4 = New ns1.BunifuFlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DgvEvent = New ns1.BunifuCustomDataGrid()
        CType(Me.DgvEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ideventTBX
        '
        Me.ideventTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.ideventTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ideventTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.ideventTBX.BorderThickness = 3
        Me.ideventTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ideventTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ideventTBX.ForeColor = System.Drawing.Color.White
        Me.ideventTBX.isPassword = False
        Me.ideventTBX.Location = New System.Drawing.Point(420, 89)
        Me.ideventTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.ideventTBX.Name = "ideventTBX"
        Me.ideventTBX.Size = New System.Drawing.Size(228, 44)
        Me.ideventTBX.TabIndex = 37
        Me.ideventTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'eventnameTBX
        '
        Me.eventnameTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.eventnameTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.eventnameTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.eventnameTBX.BorderThickness = 3
        Me.eventnameTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.eventnameTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.eventnameTBX.ForeColor = System.Drawing.Color.White
        Me.eventnameTBX.isPassword = False
        Me.eventnameTBX.Location = New System.Drawing.Point(420, 174)
        Me.eventnameTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.eventnameTBX.Name = "eventnameTBX"
        Me.eventnameTBX.Size = New System.Drawing.Size(228, 44)
        Me.eventnameTBX.TabIndex = 38
        Me.eventnameTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'vanueTBX
        '
        Me.vanueTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.vanueTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.vanueTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.vanueTBX.BorderThickness = 3
        Me.vanueTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.vanueTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.vanueTBX.ForeColor = System.Drawing.Color.White
        Me.vanueTBX.isPassword = False
        Me.vanueTBX.Location = New System.Drawing.Point(687, 174)
        Me.vanueTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.vanueTBX.Name = "vanueTBX"
        Me.vanueTBX.Size = New System.Drawing.Size(228, 44)
        Me.vanueTBX.TabIndex = 40
        Me.vanueTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(417, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "ID EVENT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(417, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "EVENT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(684, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "VANUE"
        '
        'EventDate
        '
        Me.EventDate.BackColor = System.Drawing.Color.SeaGreen
        Me.EventDate.BorderRadius = 0
        Me.EventDate.ForeColor = System.Drawing.Color.White
        Me.EventDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.EventDate.FormatCustom = Nothing
        Me.EventDate.Location = New System.Drawing.Point(687, 89)
        Me.EventDate.Name = "EventDate"
        Me.EventDate.Size = New System.Drawing.Size(228, 36)
        Me.EventDate.TabIndex = 44
        Me.EventDate.Value = New Date(2022, 4, 11, 7, 14, 2, 500)
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "ADD"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(469, 243)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(110, 24)
        Me.BunifuFlatButton1.TabIndex = 46
        Me.BunifuFlatButton1.Text = "ADD"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "EDIT"
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
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(594, 243)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(110, 24)
        Me.BunifuFlatButton2.TabIndex = 47
        Me.BunifuFlatButton2.Text = "EDIT"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "RESET"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = Nothing
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(721, 243)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(110, 24)
        Me.BunifuFlatButton4.TabIndex = 49
        Me.BunifuFlatButton4.Text = "RESET"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 31)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "EVENT"
        '
        'DgvEvent
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvEvent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEvent.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvEvent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvEvent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEvent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvEvent.ColumnHeadersHeight = 35
        Me.DgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvEvent.DoubleBuffered = True
        Me.DgvEvent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvEvent.EnableHeadersVisualStyles = False
        Me.DgvEvent.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DgvEvent.HeaderForeColor = System.Drawing.Color.White
        Me.DgvEvent.Location = New System.Drawing.Point(420, 288)
        Me.DgvEvent.Name = "DgvEvent"
        Me.DgvEvent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEvent.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvEvent.Size = New System.Drawing.Size(495, 164)
        Me.DgvEvent.TabIndex = 64
        '
        'EventForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1222, 517)
        Me.Controls.Add(Me.DgvEvent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuFlatButton4)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.EventDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vanueTBX)
        Me.Controls.Add(Me.eventnameTBX)
        Me.Controls.Add(Me.ideventTBX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EventForm"
        Me.Text = "EventForm"
        CType(Me.DgvEvent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ideventTBX As ns1.BunifuMetroTextbox
    Friend WithEvents eventnameTBX As ns1.BunifuMetroTextbox
    Friend WithEvents vanueTBX As ns1.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EventDate As ns1.BunifuDatepicker
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As ns1.BunifuFlatButton
    Friend WithEvents Label5 As Label
    Friend WithEvents DgvEvent As ns1.BunifuCustomDataGrid
End Class
