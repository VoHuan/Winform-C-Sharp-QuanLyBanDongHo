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
    public class ChiTietKhuyenMaiAccess
    {
        public List<ChiTietKhuyenMai> LayToanBoCTKM()
        {
            List<ChiTietKhuyenMai> dskm = new List<ChiTietKhuyenMai>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from ChiTietKhuyenMai where tinhtrang = 1";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maKm = reader.GetInt32(0);
                int maSP = reader.GetInt32(1);
                int giatri = reader.GetInt32(2);
                string donvi = reader.GetString(3);

                ChiTietKhuyenMai ctkm = new ChiTietKhuyenMai();
                ctkm.MaKhuyenMai = maKm;
                ctkm.MaSanPham = maSP;
                ctkm.GiaTriGiam = giatri;
                ctkm.DonViGiam = donvi;

                dskm.Add(ctkm);
                
            }
            reader.Close();
            return dskm;
        }

        public List<ChiTietKhuyenMai> LayToanBoCTKM(int ma)
        {
            List<ChiTietKhuyenMai> dskm = new List<ChiTietKhuyenMai>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from ChiTietKhuyenMai where MaKhuyenMai = @ma and tinhtrang = 1 ";
            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maKm = reader.GetInt32(0);
                int maSP = reader.GetInt32(1);
                int giatri = reader.GetInt32(2);
                string donvi = reader.GetString(3);

                ChiTietKhuyenMai ctkm = new ChiTietKhuyenMai();
                ctkm.MaKhuyenMai = maKm;
                ctkm.MaSanPham = maSP;
                ctkm.GiaTriGiam = giatri;
                ctkm.DonViGiam = donvi;

                dskm.Add(ctkm);

            }
            reader.Close();
            return dskm;
        }
        public bool SuaCTKM(ChiTietKhuyenMai obj)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE ChiTietKhuyenMai SET GiaTriGiam=@giaTriGiam, DonViGiam=@donViGiam WHERE MaKhuyenMai=@maKhuyenMai AND MaSanPham = @maSanPham";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maKhuyenMai", SqlDbType.Int).Value = obj.MaKhuyenMai;
                command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = obj.MaSanPham;
                command.Parameters.Add("@giaTriGiam", SqlDbType.Int).Value = obj.GiaTriGiam;
                command.Parameters.Add("@donViGiam", SqlDbType.NVarChar).Value = obj.DonViGiam;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemCTKM(ChiTietKhuyenMai obj)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO ChiTietKhuyenMai VALUES(@maKhuyenMai,@maSanPham,@giaTriGiam,@donViGiam,1)"; ;
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maKhuyenMai", SqlDbType.Int).Value = obj.MaKhuyenMai;
                command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = obj.MaSanPham;
                command.Parameters.Add("@giaTriGiam", SqlDbType.Int).Value = obj.GiaTriGiam;
                command.Parameters.Add("@donViGiam", SqlDbType.NVarChar).Value = obj.DonViGiam;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaCTKM(ChiTietKhuyenMai obj)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM ChiTietKhuyenMai WHERE MaKhuyenMai = @ma0 AND MaSanPham = @ma1";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@ma0", SqlDbType.Int).Value = obj.MaKhuyenMai;
                command.Parameters.Add("@ma1", SqlDbType.Int).Value = obj.MaSanPham;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
