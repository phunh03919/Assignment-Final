Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "server=WIN-HTF5R8D5DJS;database=QLBH03919;trusted_connection=false;uid=sa;pwd=eizovn2101"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs)
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã SP' ,MaLSP as 'Mã LSP', TenSP as 'Tên SP', MoTa as 'Mô Tả', SoLuong as 'Số Lượng' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtMaSP.Text = ""
        txtMaLSP.Text = ""
        txtTenSP.Text = ""
        txtMoTa.Text = ""
        txtSoLuong.Text = ""
        txtMaSP.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Chua nhap mã sản phẩm")
            txtMaSP.Focus()
        ElseIf txtMaLSP.Text = "" Then
            MessageBox.Show("Chua nhap mã loại sản phẩm")
            txtMaLSP.Focus()
        ElseIf txtTenSP.Text = "" Then
            MessageBox.Show("Chua nhap tên sản phẩm")
            txtTenSP.Focus()
        ElseIf txtMoTa.Text = "" Then
            MessageBox.Show("Chua nhap nội dung")
            txtMoTa.Focus()
        ElseIf txtSoLuong.Text = "" Then
            MessageBox.Show("Chua nhap ngày đăng")
            txtSoLuong.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into SanPham values(@MaSP,@TenSP,@SoLuong,@MoTa,@MaLSP)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            save.Parameters.AddWithValue("@MaLSP", txtMaLSP.Text)
            save.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            save.Parameters.AddWithValue("@MoTa", txtMoTa.Text)
            save.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Nhap MaSP cần xóa")
            txtMaSP.Focus()
        Else
            Dim delquery As String = "delete from SanPham where MaSP=@MaSP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMaSP.ReadOnly = True
            btnSua.Text = "Update"
            txtTenSP.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update SanPham set MaLSP=@MaLSP, TenSP=@TenSP, MoTa=@MoTa, SoLuong=@SoLuong where MaSP=@MASP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            save.Parameters.AddWithValue("@MaLSP", txtMaLSP.Text)
            save.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            save.Parameters.AddWithValue("@MoTa", txtMoTa.Text)
            save.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaSP.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaSP.Text = DataGridView1.Item(0, click).Value
        txtMaLSP.Text = DataGridView1.Item(1, click).Value
        txtTenSP.Text = DataGridView1.Item(2, click).Value
        txtMoTa.Text = DataGridView1.Item(3, click).Value
        txtSoLuong.Text = DataGridView1.Item(4, click).Value
    End Sub

    Private Sub btnĐóng_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class