Public Class Form1

    Private Sub ChỉnhSữaKHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChỉnhSữaKHToolStripMenuItem.Click
        frmKhachHang.ShowDialog()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem1.Click
        frmSanPham.ShowDialog()
    End Sub

    Private Sub ThêmSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSảnPhẩmToolStripMenuItem.Click
        FrmLoaiSanPham.ShowDialog()
    End Sub

    Private Sub XemSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemSảnPhẩmToolStripMenuItem.Click
        frmXemSanPham.ShowDialog()

    End Sub

    Private Sub HóaĐơnKHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnKHToolStripMenuItem.Click
        frmHoaDon.ShowDialog()
    End Sub

    Private Sub ChiTiếtHĐToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHĐToolStripMenuItem.Click
        frmChiTietHoaDon.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
