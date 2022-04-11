<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvUser = New ns1.BunifuCustomDataGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton4 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton2 = New ns1.BunifuFlatButton()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmailTBX = New ns1.BunifuMetroTextbox()
        Me.UserNameTBX = New ns1.BunifuMetroTextbox()
        Me.idUserTBX = New ns1.BunifuMetroTextbox()
        Me.PasswordTBX = New ns1.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RoleCBX = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton3 = New ns1.BunifuFlatButton()
        CType(Me.DgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvUser
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUser.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvUser.ColumnHeadersHeight = 35
        Me.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvUser.DoubleBuffered = True
        Me.DgvUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvUser.EnableHeadersVisualStyles = False
        Me.DgvUser.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DgvUser.HeaderForeColor = System.Drawing.Color.White
        Me.DgvUser.Location = New System.Drawing.Point(328, 383)
        Me.DgvUser.Name = "DgvUser"
        Me.DgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvUser.Size = New System.Drawing.Size(676, 164)
        Me.DgvUser.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 31)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "USER"
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
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(805, 338)
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
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(573, 338)
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(455, 338)
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
        Me.Label3.Location = New System.Drawing.Point(334, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "EMAIL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(334, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(334, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "ID USER"
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
        Me.EmailTBX.Location = New System.Drawing.Point(337, 247)
        Me.EmailTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailTBX.Name = "EmailTBX"
        Me.EmailTBX.Size = New System.Drawing.Size(305, 44)
        Me.EmailTBX.TabIndex = 67
        Me.EmailTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'UserNameTBX
        '
        Me.UserNameTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.UserNameTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UserNameTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.UserNameTBX.BorderThickness = 3
        Me.UserNameTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNameTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.UserNameTBX.ForeColor = System.Drawing.Color.White
        Me.UserNameTBX.isPassword = False
        Me.UserNameTBX.Location = New System.Drawing.Point(337, 165)
        Me.UserNameTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.UserNameTBX.Name = "UserNameTBX"
        Me.UserNameTBX.Size = New System.Drawing.Size(305, 44)
        Me.UserNameTBX.TabIndex = 66
        Me.UserNameTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'idUserTBX
        '
        Me.idUserTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.idUserTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.idUserTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.idUserTBX.BorderThickness = 3
        Me.idUserTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idUserTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.idUserTBX.ForeColor = System.Drawing.Color.White
        Me.idUserTBX.isPassword = False
        Me.idUserTBX.Location = New System.Drawing.Point(337, 80)
        Me.idUserTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.idUserTBX.Name = "idUserTBX"
        Me.idUserTBX.Size = New System.Drawing.Size(305, 44)
        Me.idUserTBX.TabIndex = 65
        Me.idUserTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PasswordTBX
        '
        Me.PasswordTBX.BorderColorFocused = System.Drawing.Color.Lavender
        Me.PasswordTBX.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasswordTBX.BorderColorMouseHover = System.Drawing.Color.Lavender
        Me.PasswordTBX.BorderThickness = 3
        Me.PasswordTBX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTBX.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.PasswordTBX.ForeColor = System.Drawing.Color.White
        Me.PasswordTBX.isPassword = False
        Me.PasswordTBX.Location = New System.Drawing.Point(701, 169)
        Me.PasswordTBX.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordTBX.Name = "PasswordTBX"
        Me.PasswordTBX.Size = New System.Drawing.Size(294, 44)
        Me.PasswordTBX.TabIndex = 77
        Me.PasswordTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(698, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "PASSWORD"
        '
        'RoleCBX
        '
        Me.RoleCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoleCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleCBX.FormattingEnabled = True
        Me.RoleCBX.Items.AddRange(New Object() {"Staff", "Administrator"})
        Me.RoleCBX.Location = New System.Drawing.Point(704, 88)
        Me.RoleCBX.Name = "RoleCBX"
        Me.RoleCBX.Size = New System.Drawing.Size(291, 37)
        Me.RoleCBX.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(701, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "ROLE"
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
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(689, 338)
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
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1182, 622)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RoleCBX)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PasswordTBX)
        Me.Controls.Add(Me.DgvUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuFlatButton4)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmailTBX)
        Me.Controls.Add(Me.UserNameTBX)
        Me.Controls.Add(Me.idUserTBX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserForm"
        Me.Text = "UserForm"
        CType(Me.DgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvUser As ns1.BunifuCustomDataGrid
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuFlatButton4 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As ns1.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmailTBX As ns1.BunifuMetroTextbox
    Friend WithEvents UserNameTBX As ns1.BunifuMetroTextbox
    Friend WithEvents idUserTBX As ns1.BunifuMetroTextbox
    Friend WithEvents PasswordTBX As ns1.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents RoleCBX As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuFlatButton3 As ns1.BunifuFlatButton
End Class
