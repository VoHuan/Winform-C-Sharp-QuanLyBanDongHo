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
    public class PhanQuyenAccess
    {
        public List<PhanQuyen> LayToanBoPhanQuyen()
        {
            List<PhanQuyen> dspq = new List<PhanQuyen>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PhanQuyen  ";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maQuyen = reader.GetString(0);
                string quanLyBanHang = reader.GetString(1);
                string quanLyNhapHang = reader.GetString(2);
                string quanLyKhachHang = reader.GetString(3);
                string quanLyNhanVien = reader.GetString(4);
                string quanLySanPham = reader.GetString(5);
                string xemThongKe = reader.GetString(6);
                string quyenPhanQuyen = reader.GetString(7);
                String quanlyKhuyenMai = reader.GetString(8);


                PhanQuyen pq = new PhanQuyen();
                pq.MaQuyen = maQuyen;
                pq.QuanLyBanHang = quanLyBanHang;
                pq.QuanLyNhapHang = quanLyNhapHang;
                pq.QuanLyKhachHang = quanLyKhachHang;
                pq.QuanLyNhanVien = quanLyNhanVien;
                pq.QuanLySanPham = quanLySanPham;
                pq.XemThongKe = xemThongKe;
                pq.QuyenPhanQuyen = quyenPhanQuyen;
                pq.QuanLyKhuyenMai = quanlyKhuyenMai;


                dspq.Add(pq);
            }
            reader.Close();
            return dspq;
        }
        public PhanQuyen getPhanQuyen(string maquyen)
        {
            List<PhanQuyen> dspq = new List<PhanQuyen>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PhanQuyen where maquyen = @maquyen ";
            command.Connection = DatabaseAccess.getConn();
            command.Parameters.Add("@maquyen", SqlDbType.NChar).Value = maquyen;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maQuyen = reader.GetString(0);
                string quanLyBanHang = reader.GetString(1);
                string quanLyNhapHang = reader.GetString(2);
                string quanLyKhachHang = reader.GetString(3);
                string quanLyNhanVien = reader.GetString(4);
                string quanLySanPham = reader.GetString(5);
                string xemThongKe = reader.GetString(6);
                string quyenPhanQuyen = reader.GetString(7);
                string quanLyKhuyenMai = reader.GetString(8);

                PhanQuyen pq = new PhanQuyen();
                pq.MaQuyen = maQuyen;
                pq.QuanLyBanHang = quanLyBanHang;
                pq.QuanLyNhapHang = quanLyNhapHang;
                pq.QuanLyKhachHang = quanLyKhachHang;
                pq.QuanLyNhanVien = quanLyNhanVien;
                pq.QuanLySanPham = quanLySanPham;
                pq.XemThongKe = xemThongKe;
                pq.QuyenPhanQuyen = quyenPhanQuyen;
                pq.QuanLyKhuyenMai = quanLyKhuyenMai;

                dspq.Add(pq);
            }
            reader.Close();
            return dspq[0];
        }
        public bool themQuyen(string maquyen)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO PhanQuyen VALUES(@maquyen,0,0,0,0,0,0,0,0)";
                command.Connection = DatabaseAccess.getConn();
               
                command.Parameters.Add("@maquyen", SqlDbType.NChar).Value = maquyen;
                
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
        public bool suaQuyen(PhanQuyen phanquyen)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE PhanQuyen SET QuanLyBanHang=@banhang, QuanLyNhapHang=@nhaphang, QuanLyKhachHang=@khachang, QuanLyNhanVien=@nhanvien," +
                    " QuanLySanPham=@sanpham, XemThongKe=@thongke, PhanQuyen=@phanquyen,QuanLyKhuyenMai=@khuyenmai WHERE Maquyen=@maquyen";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maquyen", SqlDbType.NChar).Value = phanquyen.MaQuyen;
                command.Parameters.Add("@banhang", SqlDbType.NChar).Value = phanquyen.QuanLyBanHang;
                command.Parameters.Add("@nhaphang", SqlDbType.NChar).Value = phanquyen.QuanLyNhapHang;
                command.Parameters.Add("@khachang", SqlDbType.NChar).Value = phanquyen.QuanLyKhachHang;
                command.Parameters.Add("@nhanvien", SqlDbType.NChar).Value = phanquyen.QuanLyNhanVien;
                command.Parameters.Add("@sanpham", SqlDbType.NChar).Value = phanquyen.QuanLySanPham;
                command.Parameters.Add("@thongke", SqlDbType.NChar).Value = phanquyen.XemThongKe;
                command.Parameters.Add("@phanquyen", SqlDbType.NChar).Value = phanquyen.QuyenPhanQuyen;
                command.Parameters.Add("@khuyenmai", SqlDbType.NChar).Value = phanquyen.QuanLyKhuyenMai;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool xoaQuyen(string maquyen)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "delete phanquyen where maquyen = @maquyen";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maquyen", SqlDbType.NChar).Value = maquyen;
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
