Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmKhachHang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "server=WIN-HTF5R8D5DJS;database=QLBH03919;trusted_connection=false;uid=sa;pwd=eizovn2101"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs)
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH', TenKh as 'Tên KH', DiaChi as 'Địa Chỉ', SDT as 'Số ĐT' from KhachHang", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtMaKH.Text = ""
        txtTenKH.Text = ""
        txtDiaChi.Text = ""
        txtSDT.Text = ""
        txtMaKH.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaKH.Text = "" Then
            MessageBox.Show("Chua nhap mã khách hàng")
            txtMaKH.Focus()
        ElseIf txtTenKH.Text = "" Then
            MessageBox.Show("Chua nhap Tên khách hàng")
            txtTenKH.Focus()
        ElseIf txtSDT.Text = "" Then
            MessageBox.Show("Chua nhap số điện thoại")
            txtSDT.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into KhachHang values(@MaKH,@TenKh,@DiaChi,@SDT)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            save.Parameters.AddWithValue("@TenKh", txtTenKH.Text)
            save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            save.Parameters.AddWithValue("@SDT", txtSDT.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaKH.Text = "" Then
            MessageBox.Show("Nhap MaSP cần xóa")
            txtTenKH.Focus()
        Else
            Dim delquery As String = "delete from KhachHang where MaKH=@MaKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMaKH.ReadOnly = True
            btnSua.Text = "Update"
            txtTenKH.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update KhachHang set TenKH=@TenKH, DiaChi=@DiaChi , SDT=@SDT where MaKH=@MaKH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            save.Parameters.AddWithValue("@TenKh", txtTenKH.Text)
            save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            save.Parameters.AddWithValue("@SDT", txtSDT.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaKH.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaKH.Text = DataGridView1.Item(0, click).Value
        txtTenKH.Text = DataGridView1.Item(1, click).Value
        txtDiaChi.Text = DataGridView1.Item(2, click).Value
        txtSDT.Text = DataGridView1.Item(3, click).Value

    End Sub
End Class