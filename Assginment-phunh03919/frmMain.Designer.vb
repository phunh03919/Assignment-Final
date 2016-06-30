<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KhácHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChỉnhSữaKHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiênHệToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnKHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiTiếtHĐToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiớiThiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KhácHàngToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.LiênHệToolStripMenuItem, Me.GiớiThiệuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(488, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KhácHàngToolStripMenuItem
        '
        Me.KhácHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChỉnhSữaKHToolStripMenuItem})
        Me.KhácHàngToolStripMenuItem.Name = "KhácHàngToolStripMenuItem"
        Me.KhácHàngToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.KhácHàngToolStripMenuItem.Text = "Khách Hàng"
        '
        'ChỉnhSữaKHToolStripMenuItem
        '
        Me.ChỉnhSữaKHToolStripMenuItem.Name = "ChỉnhSữaKHToolStripMenuItem"
        Me.ChỉnhSữaKHToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ChỉnhSữaKHToolStripMenuItem.Text = "Cập nhật KH"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmSảnPhẩmToolStripMenuItem, Me.XemSảnPhẩmToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem1})
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản phẩm"
        '
        'ThêmSảnPhẩmToolStripMenuItem
        '
        Me.ThêmSảnPhẩmToolStripMenuItem.Name = "ThêmSảnPhẩmToolStripMenuItem"
        Me.ThêmSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ThêmSảnPhẩmToolStripMenuItem.Text = "Loại Sản Phẩm"
        '
        'XemSảnPhẩmToolStripMenuItem
        '
        Me.XemSảnPhẩmToolStripMenuItem.Name = "XemSảnPhẩmToolStripMenuItem"
        Me.XemSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.XemSảnPhẩmToolStripMenuItem.Text = "Xem sản phẩm"
        '
        'SảnPhẩmToolStripMenuItem1
        '
        Me.SảnPhẩmToolStripMenuItem1.Name = "SảnPhẩmToolStripMenuItem1"
        Me.SảnPhẩmToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.SảnPhẩmToolStripMenuItem1.Text = "Sản Phẩm"
        '
        'LiênHệToolStripMenuItem
        '
        Me.LiênHệToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HóaĐơnKHToolStripMenuItem, Me.ChiTiếtHĐToolStripMenuItem})
        Me.LiênHệToolStripMenuItem.Name = "LiênHệToolStripMenuItem"
        Me.LiênHệToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.LiênHệToolStripMenuItem.Text = "Hóa Đơn"
        '
        'HóaĐơnKHToolStripMenuItem
        '
        Me.HóaĐơnKHToolStripMenuItem.Name = "HóaĐơnKHToolStripMenuItem"
        Me.HóaĐơnKHToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HóaĐơnKHToolStripMenuItem.Text = "Hóa Đơn KH"
        '
        'ChiTiếtHĐToolStripMenuItem
        '
        Me.ChiTiếtHĐToolStripMenuItem.Name = "ChiTiếtHĐToolStripMenuItem"
        Me.ChiTiếtHĐToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ChiTiếtHĐToolStripMenuItem.Text = "Chi Tiết HĐ"
        '
        'GiớiThiệuToolStripMenuItem
        '
        Me.GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        Me.GiớiThiệuToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.GiớiThiệuToolStripMenuItem.Text = "Giới thiệu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(434, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 301)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 88)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PS03919"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nguyễn Hoàng Phú"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 401)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KhácHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChỉnhSữaKHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThêmSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HóaĐơnKHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChiTiếtHĐToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GiớiThiệuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
