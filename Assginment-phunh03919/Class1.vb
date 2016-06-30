Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "server=WIN-HTF5R8D5DJS;database=QLBH03919;trusted_connection=false;uid=sa;pwd=eizovn2101"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKh as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT' from KHACHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "server=WIN-HTF5R8D5DJS;database=QLBH03919;trusted_connection=false;uid=sa;pwd=eizovn2101"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SanPham.MaSP as 'Mã sản phẩm',SanPham.TenSP as 'Tên sản phẩm', LoaiSP.MaLSP as 'Mã LSP',SanPham.MoTa as 'Mô Tả',SanPham.SoLuong as 'Số Lượng' from SanPham inner join LoaiSP on SanPham.MaLSP = LoaiSP.MaLSP", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
