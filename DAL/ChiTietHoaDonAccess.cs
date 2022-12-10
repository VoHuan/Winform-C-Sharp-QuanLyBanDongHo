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
    public  class ChiTietHoaDonAccess
    {
        public List<ChiTietHoaDon> LayToanBoCTHoaDon()
        {

            List<ChiTietHoaDon> dscthd = new List<ChiTietHoaDon>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from ChiTietHoaDon";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maHoaDon = reader.GetInt32(0);
                int maSanPham = reader.GetInt32(1);
                int soLuong = reader.GetInt32(2);
                int donGia = reader.GetInt32(3);
                int thanhTien = reader.GetInt32(4);

                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.maHoaDon = maHoaDon;
                cthd.maSanPham = maSanPham;
                cthd.soLuong= soLuong;
                cthd.donGia = donGia;
                cthd.thanhTien = thanhTien;

                dscthd.Add(cthd);

            }
            reader.Close();
            return dscthd;
        }
        public void ThemCTHoaDon(ChiTietHoaDon cthd)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO ChiTietHoaDon VALUES(@maHoaDon,@maSanPham,@soLuong,@donGia,@thanhTien,1)";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maHoaDon", SqlDbType.Int).Value = cthd.maHoaDon;
                command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = cthd.maSanPham;
                command.Parameters.Add("@soLuong", SqlDbType.Int).Value = cthd.soLuong;
                command.Parameters.Add("@donGia", SqlDbType.Int).Value = cthd.donGia;
                command.Parameters.Add("@thanhTien", SqlDbType.Int).Value = cthd.thanhTien;
                int kq = command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {      
            }
        }
    }
}
