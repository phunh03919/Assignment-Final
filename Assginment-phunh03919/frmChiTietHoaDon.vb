Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmChiTietHoaDon
    Dim db As New DataTable
    Dim chuoiketnoi As String = "server=WIN-HTF5R8D5DJS;database=QLBH03919;trusted_connection=false;uid=sa;pwd=eizovn2101"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs)
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaHD as 'Mã HD' ,MaSP as 'Mã SP', SoLuong as 'Số Lượng', DonGiaBan as 'Đơn Gía Bán' from ChiTietHoaDon", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtMaHD.Text = ""
        txtMaSP.Text = ""
        txtSoLuongMua.Text = ""
        txtDonGiaBan.Text = ""
        txtMaHD.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaHD.Text = "" Then
            MessageBox.Show("Chua nhap mã hóa đơn")
            txtMaHD.Focus()
        ElseIf txtMaSP.Text = "" Then
            MessageBox.Show("Chua nhap mã sản phẩm")
            txtMaSP.Focus()
        ElseIf txtSoLuongMua.Text = "" Then
            MessageBox.Show("Chua nhap số lượng mua")
            txtSoLuongMua.Focus()
        ElseIf txtDonGiaBan.Text = "" Then
            MessageBox.Show("Chua nhap đơn giá bán")
            txtDonGiaBan.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into ChiTietHoaDon values(@MaSP,@MaHD,@SoLuong,@DonGiaBan)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            save.Parameters.AddWithValue("@SoLuong", txtSoLuongMua.Text)
            save.Parameters.AddWithValue("@DonGiaBan", txtDonGiaBan.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaHD.Text = "" Then
            MessageBox.Show("Nhap MaHD cần xóa")
            txtMaHD.Focus()
        Else
            Dim delquery As String = "delete from ChiTietHoaDon where MaHD=@MaHD"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMaHD.ReadOnly = True
            btnSua.Text = "Update"
            txtMaSP.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update ChiTietHoaDon set MaSP=@MaSP, SoLuong=@SoLuong , DonGiaBan=@DonGiaBan where MaHD=@MaHD"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            save.Parameters.AddWithValue("@SoLuong", txtSoLuongMua.Text)
            save.Parameters.AddWithValue("@DonGiaBan", txtDonGiaBan.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaHD.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaHD.Text = DataGridView1.Item(0, click).Value
        txtMaSP.Text = DataGridView1.Item(1, click).Value
        txtSoLuongMua.Text = DataGridView1.Item(2, click).Value
        txtDonGiaBan.Text = DataGridView1.Item(3, click).Value
    End Sub

End Class