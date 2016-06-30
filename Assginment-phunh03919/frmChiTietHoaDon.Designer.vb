<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChiTietHoaDon
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDonGiaBan = New System.Windows.Forms.TextBox()
        Me.txtSoLuongMua = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(521, 208)
        Me.DataGridView1.TabIndex = 54
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(36, 82)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 23)
        Me.btnLuu.TabIndex = 53
        Me.btnLuu.Text = "Thêm"
        Me.btnLuu.UseVisualStyleBackColor = true
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(303, 82)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 51
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = true
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(171, 82)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 52
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(236, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Đơn Gía Bán:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(236, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Số Lượng Mua:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(63, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Mã SP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(67, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Mã HD:"
        '
        'txtDonGiaBan
        '
        Me.txtDonGiaBan.Location = New System.Drawing.Point(322, 47)
        Me.txtDonGiaBan.Name = "txtDonGiaBan"
        Me.txtDonGiaBan.Size = New System.Drawing.Size(100, 20)
        Me.txtDonGiaBan.TabIndex = 48
        '
        'txtSoLuongMua
        '
        Me.txtSoLuongMua.Location = New System.Drawing.Point(322, 14)
        Me.txtSoLuongMua.Name = "txtSoLuongMua"
        Me.txtSoLuongMua.Size = New System.Drawing.Size(100, 20)
        Me.txtSoLuongMua.TabIndex = 49
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(115, 43)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(100, 20)
        Me.txtMaSP.TabIndex = 47
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(115, 14)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(100, 20)
        Me.txtMaHD.TabIndex = 42
        '
        'FrmChiTietHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 348)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDonGiaBan)
        Me.Controls.Add(Me.txtSoLuongMua)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.txtMaHD)
        Me.Name = "FrmChiTietHoaDon"
        Me.Text = "frmChiTietHoaDon"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDonGiaBan As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLuongMua As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
End Class
