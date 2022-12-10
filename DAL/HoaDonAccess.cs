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
    public class HoaDonAccess : DatabaseAccess
    {
        public List<HoaDon> LayToanBoHoaDon()
        {

            List<HoaDon> dshd = new List<HoaDon>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from HoaDon";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maHoaDon = reader.GetInt32(0);
                int maNhanVien = reader.GetInt32(1);
                int maKhachHang = reader.GetInt32(2);
                DateTime ngayLap = reader.GetDateTime(3);
                int tongTien = reader.GetInt32(4);

                HoaDon hd = new HoaDon();
                hd.MaHoaDon = maHoaDon;
                hd.MaNhanVien = maNhanVien;
                hd.MaKhachHang = maKhachHang;
                hd.NgayLap = ngayLap;
                hd.TongTien = tongTien;

                dshd.Add(hd);
                
            }
            reader.Close();
            return dshd;
        }
        public bool ThemHoaDon(HoaDon hd)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO HoaDon VALUES(@maNhanVien,@maKhachHang,@ngayLap,@tongTien,1)";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = hd.MaNhanVien;
                command.Parameters.Add("@maKhachHang", SqlDbType.Int).Value = hd.MaKhachHang;
                command.Parameters.Add("@ngayLap", SqlDbType.DateTime).Value = hd.NgayLap;
                command.Parameters.Add("@tongTien", SqlDbType.Int).Value = hd.TongTien;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
        public int getMaHoaDonMoiNhat()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT TOP (1) MaHoaDon FROM HoaDon WHERE TinhTrang = 1 ORDER BY MaHoaDon DESC";
            command.Connection = DatabaseAccess.getConn();

            SqlDataReader reader = command.ExecuteReader();
            int m = -1;
            while (reader.Read())
            {
                m = reader.GetInt32("MaHoaDon");
            }
            reader.Close();
            return m;
        }
    }
}
