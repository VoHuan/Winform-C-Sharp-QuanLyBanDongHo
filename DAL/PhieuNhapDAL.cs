using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapDAL
    {
        public List<PhieuNhap> LayToanBoPhieuNhap()
        {
            List<PhieuNhap> dspn = new List<PhieuNhap>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PhieuNhap where TinhTrang = 1";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maPhieuNhap = reader.GetInt32("MaPhieuNhap");
                int maNhaCungCap = reader.GetInt32("MaNhaCungCap");
                int maNhanVien = reader.GetInt32("MaNhanVien");
                DateTime ngayNhap = reader.GetDateTime("NgayLap");
                int tongTien = reader.GetInt32("TongTien");

                PhieuNhap pn = new PhieuNhap();
                pn.MaPhieuNhap = maPhieuNhap;
                pn.MaNhaCungCap = maNhaCungCap;
                pn.MaNhanVien = maNhanVien;
                pn.NgayNhap = ngayNhap;
                pn.TongTien = tongTien;
                dspn.Add(pn);
            }
            reader.Close();
            return dspn;
        }
        public bool SuaPhieuNhap(PhieuNhap obj)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE PhieuNhap SET MaNhanVien=@maNhanVien, MaNhaCungCap=@maNhaCungCap, ngayNhap=@ngayNhap, TongTien=@tongTien WHERE MaPhieuNhap=@maPhieuNhap";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maPhieuNhap", SqlDbType.Int).Value = obj.MaPhieuNhap;
                command.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = obj.MaNhanVien;
                command.Parameters.Add("@maNhaCungCap", SqlDbType.Int).Value = obj.MaNhaCungCap;
                command.Parameters.Add("@ngayNhap", SqlDbType.DateTime).Value = obj.NgayNhap;
                command.Parameters.Add("@tongTien", SqlDbType.Int).Value = obj.TongTien;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemPhieuNhap(PhieuNhap obj)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO PhieuNhap VALUES(@maNhaCungCap,@maNhanVien,@ngayNhap,@tongTien,1)";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maNhaCungCap", SqlDbType.Int).Value = obj.MaNhaCungCap;
                command.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = obj.MaNhanVien;
                command.Parameters.Add("@ngayNhap", SqlDbType.DateTime).Value = obj.NgayNhap;
                command.Parameters.Add("@tongTien", SqlDbType.Int).Value = obj.TongTien;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int MaCuoiCung()
        {
            try
            {
                List<PhieuNhap> dspn = new List<PhieuNhap>();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT TOP (1) MaPhieuNhap FROM PhieuNhap WHERE TinhTrang = 1 ORDER BY MaPhieuNhap DESC";
                command.Connection = DatabaseAccess.getConn();
                SqlDataReader reader = command.ExecuteReader();
                int m = -1;
                while (reader.Read())
                {
                    m = reader.GetInt32("MaPhieuNhap");
                }
                reader.Close();
                return m;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public bool XoaPhieuNhap(int ma)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE PhieuNhap SET TinhTrang = 0 WHERE MaPhieuNhap = @ma";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
