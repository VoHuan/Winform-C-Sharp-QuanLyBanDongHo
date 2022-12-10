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
    public class KhuyenMaiAccess
    {
        public List<KhuyenMai> LayToanBoKhuyenMai()
        {
            List<KhuyenMai> dskm = new List<KhuyenMai>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from KhuyenMai where tinhtrang = 1";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maKm = reader.GetInt32(0);
                string tenKm = reader.GetString(1);
                DateTime ngayBD = reader.GetDateTime(2);
                DateTime ngayKT = reader.GetDateTime(3);

                KhuyenMai km = new KhuyenMai();
                km.MaKhuyenMai = maKm;
                km.TenKhuyenMai = tenKm;
                km.NgayBatDau = ngayBD;
                km.NgayKetThuc = ngayKT;

                dskm.Add(km);
                Console.Write(km.MaKhuyenMai);
            }
            reader.Close();
            return dskm;
        }
        public bool SuaKhuyenMai(KhuyenMai obj)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE KhuyenMai SET TenKhuyenMai=@tenKhuyenMai, NgayBatDau=@ngayBatDau, NgayKetThuc=@ngayKetThuc WHERE MaKhuyenMai=@maKhuyenMai";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maKhuyenMai", SqlDbType.Int).Value = obj.MaKhuyenMai;
                command.Parameters.Add("@tenKhuyenMai", SqlDbType.NChar).Value = obj.TenKhuyenMai;
                command.Parameters.Add("@ngayBatDau", SqlDbType.DateTime).Value = obj.NgayBatDau;
                command.Parameters.Add("@ngayKetThuc", SqlDbType.DateTime).Value = obj.NgayKetThuc;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemKhuyenMai(KhuyenMai obj)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO KhuyenMai VALUES(@tenKhuyenMai,@ngayBatDau,@ngayKetThuc,1)";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@tenKhuyenMai", SqlDbType.NChar).Value = obj.TenKhuyenMai;
                command.Parameters.Add("@ngayBatDau", SqlDbType.DateTime).Value = obj.NgayBatDau;
                command.Parameters.Add("@ngayKetThuc", SqlDbType.DateTime).Value = obj.NgayKetThuc;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaKhuyenMai(int ma)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE KhuyenMai SET TinhTrang = 0 WHERE MaKhuyenMai = @ma";
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
