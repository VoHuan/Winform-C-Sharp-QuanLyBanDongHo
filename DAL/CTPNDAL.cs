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
    public class CTPNDAL
    {
        public List<CTPN> LayToanBoCTPN()
        {
            List<CTPN> list = new List<CTPN>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from ChiTietPhieuNhap where TinhTrang = 1";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maPhieuNhap = reader.GetInt32("MaPhieuNhap");
                int maSanPham = reader.GetInt32("MaSanPham");
                int soLuong = reader.GetInt32("SoLuong");
                int donGia = reader.GetInt32("DonGia");
                int thanhTien = reader.GetInt32("ThanhTien");

                CTPN ctpn = new CTPN();
                ctpn.MaPhieuNhap = maPhieuNhap;
                ctpn.MaSanPham = maSanPham;
                ctpn.SoLuong = soLuong;
                ctpn.DonGia = donGia;
                ctpn.ThanhTien = thanhTien;
                list.Add(ctpn);
            }
            reader.Close();
            return list;
        }

        public bool themChiTietPhieuNhap(List<CTPN> dsCTPN)
        {
            try
            {
                bool check = true;
                foreach (CTPN obj in dsCTPN)
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO ChiTietPhieuNhap VALUES(@maPhieuNhap,@maSanPham,@soLuong,@donGia,@thanhTien,1)";
                    command.Connection = DatabaseAccess.getConn();
                    command.Parameters.Add("@maPhieuNhap", SqlDbType.Int).Value = obj.MaPhieuNhap;
                    command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = obj.MaSanPham;
                    command.Parameters.Add("@soLuong", SqlDbType.Int).Value = obj.SoLuong;
                    command.Parameters.Add("@donGia", SqlDbType.Int).Value = obj.DonGia;
                    command.Parameters.Add("@thanhTien", SqlDbType.Int).Value = obj.ThanhTien;
                    if (command.ExecuteNonQuery() > 0)
                    {

                    }
                    else
                    {
                        check = false;
                    }
                }
                return check;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
