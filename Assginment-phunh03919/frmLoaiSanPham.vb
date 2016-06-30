Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmLoaiSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "server=WIN-HTF5R8D5DJS;database=QLBH03919;trusted_connection=false;uid=sa;pwd=eizovn2101"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs)
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaLSP as 'Mã LSP' ,TenLSP as 'Tên LSP' from LoaiSP", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtMaLSP.Text = ""
        txtTenLSP.Text = ""
        txtMaLSP.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaLSP.Text = "" Then
            MessageBox.Show("Chua nhap mã loại sản phẩm")
            txtMaLSP.Focus()
        ElseIf txtTenLSP.Text = "" Then
            MessageBox.Show("Chua nhap tên Loại Sản Phẩm")
            txtTenLSP.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into LoaiSP values(@MaLSP,@TenLSP)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaLSP", txtMaLSP.Text)
            save.Parameters.AddWithValue("@TenLSP", txtTenLSP.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaLSP.Text = "" Then
            MessageBox.Show("Nhap MaLSP cần xóa")
            txtMaLSP.Focus()
        Else
            Dim delquery As String = "delete from LoaiSP where MaLSP=@MaLSP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaLSP", txtMaLSP.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMaLSP.ReadOnly = True
            btnSua.Text = "Update"
            txtMaLSP.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update LoaiSP set MaLSP=@MaLSP, TenLSP=@TenLSP where MaLSP=@MaLSP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaLSP", txtMaLSP.Text)
            save.Parameters.AddWithValue("@TenLSP", txtTenLSP.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaLSP.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaLSP.Text = DataGridView1.Item(0, click).Value
        txtTenLSP.Text = DataGridView1.Item(1, click).Value

    End Sub
End Class