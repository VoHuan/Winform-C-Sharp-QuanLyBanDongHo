using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace DAL
{
    public class KhachHangAccess
    {
        


        public bool ThemKhachHang(KhachHang kh)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO KhachHang VALUES(@tenkh,@ngaysinh,@sdt,@tongchi,@tichdiem,1);";
                command.Connection = DatabaseAccess.getConn();
                //command.Parameters.Add("@makh", SqlDbType.Int).Value = 50;
                command.Parameters.Add("@tenkh", SqlDbType.NChar).Value = kh.TenKhachHang.ToString();
                command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = kh.NgaySinh.ToShortDateString();
                command.Parameters.Add("@sdt", SqlDbType.NChar).Value = kh.SoDienThoai.ToString();
                command.Parameters.Add("@tongchi", SqlDbType.Int).Value = 0;
                command.Parameters.Add("@tichdiem", SqlDbType.Int).Value = kh.DiemTichLuy;
               // command.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = 1;
                command.Connection = DatabaseAccess.getConn();
                int kq = command.ExecuteNonQuery();
                //DatabaseAccess.CloseConnection();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaKhachHang(KhachHang kh)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE KhachHang SET TinhTrang = 0 where MaKhachHang = @makh";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@makh", SqlDbType.Int).Value = kh.MaKhachHang;
                int kq = command.ExecuteNonQuery();
                command.Connection = DatabaseAccess.getConn();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false; ;
            }
        }

        public bool SuaKhachHang(KhachHang kh)
        {

            try
            {
                KhachHang kh_hang = new KhachHang();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE KhachHang SET TenKhachHang = @tenkh , NgaySinh = @ngaysinh , SoDienThoai = @sdt," +
                                      "TongChiTieu = @tongchi , TichDiem = @tichdiem WHERE MaKhachHang = '" + kh.MaKhachHang + "'";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@tenkh", SqlDbType.NChar).Value = kh.TenKhachHang;
                command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = kh.NgaySinh.ToShortDateString();
                command.Parameters.Add("@sdt", SqlDbType.NChar).Value = kh.SoDienThoai;
                command.Parameters.Add("@tichdiem", SqlDbType.Int).Value = kh.DiemTichLuy;
                command.Parameters.Add("@tongchi", SqlDbType.Int).Value = kh.TongChiTieu;
                int kq = command.ExecuteNonQuery();
                command.Connection = DatabaseAccess.getConn();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false; ;
            }
        }
        public List<KhachHang> LayToanBoKhachHang()
        {
            List<KhachHang> dskh = new List<KhachHang>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from KhachHang where tinhtrang=1";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                DateTime ngaySinh = reader.GetDateTime(2);
                string soDienThoai = reader.GetString(3);
                int chiTieu = reader.GetInt32(4);
                int diemTichLuy = reader.GetInt32(5);

                KhachHang kh = new KhachHang();
                kh.MaKhachHang = ma;
                kh.TenKhachHang = ten;
                kh.NgaySinh = ngaySinh;
                kh.SoDienThoai = soDienThoai;
                kh.TongChiTieu = chiTieu;
                kh.DiemTichLuy = diemTichLuy;

                dskh.Add(kh);
                Console.Write(kh.MaKhachHang);
            }
            reader.Close();
            return dskh;
        }
        public bool ThemKhachHang1(KhachHang kh)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO KhachHang VALUES(@tenKhacHang,@ngaySinh,@soDienThoai,0,0,1)";
                command.Connection = DatabaseAccess.getConn();            
               
                command.Parameters.Add("@tenKhacHang", SqlDbType.Char).Value = kh.TenKhachHang;
                command.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = kh.NgaySinh;
                command.Parameters.Add("@soDienThoai", SqlDbType.Char).Value = kh.SoDienThoai;
                
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }
        public bool TimKiemKhachHang(int ma)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from KhachHang where maKhacHang = @ma and tinhtrang =1";
                command.Connection = DatabaseAccess.getConn();
              
                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;

                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public List<KhachHang> getKhachHang(int ma)
        {
            List<KhachHang> dskh = new List<KhachHang>();
            try
            {
               
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from KhachHang where maKhachHang = @ma and tinhtrang =1";
                command.Connection = DatabaseAccess.getConn();

                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int maKH = reader.GetInt32(0);
                    string ten = reader.GetString(1);
                    DateTime ngaySinh = reader.GetDateTime(2);
                    string soDienThoai = reader.GetString(3);
                    int chiTieu = reader.GetInt32(4);
                    int diemTichLuy = reader.GetInt32(5);

                    KhachHang kh = new KhachHang();
                    kh.MaKhachHang = maKH;
                    kh.TenKhachHang = ten;
                    kh.NgaySinh = ngaySinh;
                    kh.SoDienThoai = soDienThoai;
                    kh.TongChiTieu = chiTieu;
                    kh.DiemTichLuy = diemTichLuy;

                    dskh.Add(kh);
                    Console.Write(kh.MaKhachHang);
                }
                reader.Close();
                return dskh;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return dskh;
            }
        }

        public bool UpdateDiemTichLuy(int ma, int diem)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE KhachHang SET TichDiem = (TichDiem - @diem) WHERE MaKhachHang = @ma";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
                command.Parameters.Add("@diem", SqlDbType.Int).Value = diem;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int getDiemTichLuy(int ma)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT TichDiem from KhachHang where maKhachHang = @ma";
            command.Connection = DatabaseAccess.getConn();
            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
            SqlDataReader reader = command.ExecuteReader();
            int m = -1;
            while (reader.Read())
            {
                m = reader.GetInt32("TichDiem");
            }
            reader.Close();
            return m;
        }
        public bool updateTongChiTieu(int ma, int chitieu)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE KhachHang SET TongChiTieu = (TongChiTieu + @chitieu) WHERE MaKhachHang = @ma";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
                command.Parameters.Add("@chitieu", SqlDbType.Int).Value = chitieu;
                int kq = command.ExecuteNonQuery();
                
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
