<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiketForm
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
        Me.DgvTiket = New ns1.BunifuCustomDataGrid()
        Me.BunifuFlatButton4 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton2 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CategoryTBX = New ns1.BunifuMetroTextbox()
        Me.IdTiketTBX = New ns1.BunifuMetroTextbox()
        Me.EventCBX = New System.Windows.Forms.ComboBox()
        Me.PriceTBX = New ns1.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.QuotaTBX = New ns1.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton3 = New ns1.BunifuFlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DgvTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvTiket
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvTiket.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTiket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTiket.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvTiket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvTiket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTiket.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvTiket.ColumnHeadersHeight = 35
        Me.DgvTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvTiket.DoubleBuffered = True
        Me.DgvTiket.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvTiket.EnableHeadersVisualStyles = False
        Me.DgvTiket.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DgvTiket.HeaderForeColor = System.Drawing.Color.White
        Me.DgvTiket.Location = New System.Drawing.Point(314, 324)
        Me.DgvTiket.Name = "DgvTiket"
        Me.DgvTiket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTiket.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvTiket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvTiket.Size = New System.Drawing.Size(673, 164)
        Me.DgvTiket.TabIndex = 75
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
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(783, 280)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(110, 24)
        Me.BunifuFlatButton4.TabIndex = 74
        Me.BunifuFlatButton4.Text = "RESET"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(533, 280)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(110, 24)
        Me.BunifuFlatButton2.TabIndex = 73
        Me.BunifuFlatButton2.Text = "EDIT"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(408, 280)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(110, 24)
        Me.BunifuFlatButton1.TabIndex = 72
        Me.BunifuFlatButton1.Text = "ADD"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(311, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "CATEGORY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(559, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "EVENT NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(311, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "ID TIKET"
        '
        'CategoryTBX
        '
        Me.CategoryTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.CategoryTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CategoryTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.CategoryTBX.BorderThickness = 3
        Me.CategoryTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CategoryTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CategoryTBX.ForeColor = System.Drawing.Color.White
        Me.CategoryTBX.isPassword = False
        Me.CategoryTBX.Location = New System.Drawing.Point(314, 207)
        Me.CategoryTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.CategoryTBX.Name = "CategoryTBX"
        Me.CategoryTBX.Size = New System.Drawing.Size(228, 44)
        Me.CategoryTBX.TabIndex = 67
        Me.CategoryTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'IdTiketTBX
        '
        Me.IdTiketTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.IdTiketTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IdTiketTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.IdTiketTBX.BorderThickness = 3
        Me.IdTiketTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdTiketTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.IdTiketTBX.ForeColor = System.Drawing.Color.White
        Me.IdTiketTBX.isPassword = False
        Me.IdTiketTBX.Location = New System.Drawing.Point(314, 128)
        Me.IdTiketTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.IdTiketTBX.Name = "IdTiketTBX"
        Me.IdTiketTBX.Size = New System.Drawing.Size(228, 44)
        Me.IdTiketTBX.TabIndex = 65
        Me.IdTiketTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'EventCBX
        '
        Me.EventCBX.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.EventCBX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EventCBX.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventCBX.ForeColor = System.Drawing.Color.White
        Me.EventCBX.FormattingEnabled = True
        Me.EventCBX.Location = New System.Drawing.Point(567, 131)
        Me.EventCBX.Name = "EventCBX"
        Me.EventCBX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EventCBX.Size = New System.Drawing.Size(420, 38)
        Me.EventCBX.TabIndex = 76
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
        Me.PriceTBX.Location = New System.Drawing.Point(567, 207)
        Me.PriceTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.PriceTBX.Name = "PriceTBX"
        Me.PriceTBX.Size = New System.Drawing.Size(228, 44)
        Me.PriceTBX.TabIndex = 77
        Me.PriceTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(572, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "PRICE"
        '
        'QuotaTBX
        '
        Me.QuotaTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.QuotaTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.QuotaTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.QuotaTBX.BorderThickness = 3
        Me.QuotaTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QuotaTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.QuotaTBX.ForeColor = System.Drawing.Color.White
        Me.QuotaTBX.isPassword = False
        Me.QuotaTBX.Location = New System.Drawing.Point(821, 207)
        Me.QuotaTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.QuotaTBX.Name = "QuotaTBX"
        Me.QuotaTBX.Size = New System.Drawing.Size(166, 44)
        Me.QuotaTBX.TabIndex = 79
        Me.QuotaTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(818, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "QUOTA"
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "DELETE"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(658, 280)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(110, 24)
        Me.BunifuFlatButton3.TabIndex = 81
        Me.BunifuFlatButton3.Text = "DELETE"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(12, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 31)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "TICKET"
        '
        'TiketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1190, 571)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.QuotaTBX)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PriceTBX)
        Me.Controls.Add(Me.EventCBX)
        Me.Controls.Add(Me.DgvTiket)
        Me.Controls.Add(Me.BunifuFlatButton4)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CategoryTBX)
        Me.Controls.Add(Me.IdTiketTBX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TiketForm"
        Me.Text = "TiketForm"
        CType(Me.DgvTiket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvTiket As ns1.BunifuCustomDataGrid
    Friend WithEvents BunifuFlatButton4 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CategoryTBX As ns1.BunifuMetroTextbox
    Friend WithEvents IdTiketTBX As ns1.BunifuMetroTextbox
    Friend WithEvents EventCBX As ComboBox
    Friend WithEvents PriceTBX As ns1.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents QuotaTBX As ns1.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuFlatButton3 As ns1.BunifuFlatButton
    Friend WithEvents Label6 As Label
End Class
