Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmHoaDon
    Dim db As New DataTable
    Dim chuoiketnoi As String = "server=WIN-HTF5R8D5DJS;database=QLBH03919;trusted_connection=false;uid=sa;pwd=eizovn2101"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs)
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaHD as 'Mã HD' ,MaKh as 'Mã KH', NgayLap as 'Ngày Lập' from HoaDon", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtMaHD.Text = ""
        txtMaKH.Text = ""
        txtNgayLap.Text = ""
        txtMaHD.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaHD.Text = "" Then
            MessageBox.Show("Chua nhap mã hóa đơn")
            txtMaHD.Focus()
        ElseIf txtMaKH.Text = "" Then
            MessageBox.Show("Chua nhap mã khách hàng")
            txtMaKH.Focus()
        ElseIf txtNgayLap.Text = "" Then
            MessageBox.Show("Chua nhap ngày lập")
            txtNgayLap.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into HoaDon values(@MaHD,@NgayLap,@MaKh)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            save.Parameters.AddWithValue("@MaKh", txtMaKH.Text)
            save.Parameters.AddWithValue("@NgayLap", txtNgayLap.Text)
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
            Dim delquery As String = "delete from HoaDon where MaHD=@MaHD"
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
            txtMaKH.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update HoaDon set MaKh=@MaKh, NgayLap=@NgayLap where MaHD=@MaHD"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            save.Parameters.AddWithValue("@MaKh", txtMaKH.Text)
            save.Parameters.AddWithValue("@NgayLap", txtNgayLap.Text)
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
        txtMaKH.Text = DataGridView1.Item(1, click).Value
        txtNgayLap.Text = DataGridView1.Item(2, click).Value

    End Sub
   
End Class