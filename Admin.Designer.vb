<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.MenuToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1386, 46)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(76, 42)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataEventToolStripMenuItem, Me.DataTiketToolStripMenuItem, Me.DataUserToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 42)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'DataEventToolStripMenuItem
        '
        Me.DataEventToolStripMenuItem.Name = "DataEventToolStripMenuItem"
        Me.DataEventToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataEventToolStripMenuItem.Text = "Event"
        '
        'DataTiketToolStripMenuItem
        '
        Me.DataTiketToolStripMenuItem.Name = "DataTiketToolStripMenuItem"
        Me.DataTiketToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataTiketToolStripMenuItem.Text = "Tiket"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataUserToolStripMenuItem.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1324, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1386, 526)
        Me.Panel1.TabIndex = 3
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 42)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1386, 576)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataEventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTiketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
End Class
