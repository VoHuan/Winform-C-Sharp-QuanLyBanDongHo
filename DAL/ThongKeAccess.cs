using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAL
{
    public class ThongKeAccess
    {
        public Hashtable doanhThuNgay(String tenBang, String d, String m, String y)
        {
            int yy = Int32.Parse(y);
            int mm = Int32.Parse(m);
            int days = DateTime.DaysInMonth(yy, mm);
            Hashtable htpDoanhThuNgay = new Hashtable();
            for (int i = days; i > 0; i--)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT SUM(" + tenBang + ".TongTien) as TongTien FROM " + tenBang + " " +
                    "WHERE DAY(" + tenBang + ".NgayLap) = " + i + " " +
                    "AND MONTH(" + tenBang + ".NgayLap) = " + m + " " +
                    "AND YEAR(" + tenBang + ".NgayLap) = " + y;
                command.Connection = DatabaseAccess.getConn();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        htpDoanhThuNgay.Add(i, 0);
                    }
                    else
                    {
                        int tongTien = reader.GetInt32(0);
                        htpDoanhThuNgay.Add(i, tongTien);
                    }
                }
                reader.Close();
            }
            return htpDoanhThuNgay;
        }
        public Hashtable doanhThuThang(String tenBang, String d, String m, String y)
        {
            Hashtable htpDoanhThuThang = new Hashtable();
            for (int i = 12; i > 0; i--)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT SUM(" + tenBang + ".TongTien) as TongTien FROM " + tenBang + " WHERE MONTH(" + tenBang + ".NgayLap) = " + i + " AND YEAR(" + tenBang + ".NgayLap) = " + y;
                command.Connection = DatabaseAccess.getConn();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        htpDoanhThuThang.Add(i, 0);
                    }
                    else
                    {
                        int tongTien = reader.GetInt32(0);
                        htpDoanhThuThang.Add(i, tongTien);
                    }
                }
                reader.Close();
            }
            return htpDoanhThuThang;
        }

        public Hashtable doanhThuQuy(String tenBang, String d, String m, String y)
        {
            Hashtable htpDoanhThuQuy = new Hashtable();
            int sum = 4, sumQuy = 0;
            for (int i = 12; i > 0; i--)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT SUM(" + tenBang + ".TongTien) as TongTien FROM " + tenBang + " WHERE MONTH(" + tenBang + ".NgayLap) = " + i + " AND YEAR(" + tenBang + ".NgayLap) = " + y;
                command.Connection = DatabaseAccess.getConn();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        sumQuy += 0;
                    }
                    else
                    {
                        int tongTien = reader.GetInt32(0);
                        sumQuy += tongTien;
                    }
                    if (i % 3 == 1)
                    {
                        htpDoanhThuQuy.Add(sum, sumQuy);
                        sumQuy = 0;
                        sum--;
                    }
                }
                reader.Close();
            }
            return htpDoanhThuQuy;
        }

        public Hashtable doanhThuNam(String tenBang)
        {
            int minYear = 0, maxYear = 0;
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT TOP(1) YEAR(" + tenBang + ".NgayLap) FROM " + tenBang + " ORDER BY YEAR(" + tenBang + ".NgayLap) ASC";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                minYear = reader.GetInt32(0);
            }
            reader.Close();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT TOP(1) YEAR(" + tenBang + ".NgayLap) FROM " + tenBang + " ORDER BY YEAR(" + tenBang + ".NgayLap) DESC";
            command.Connection = DatabaseAccess.getConn();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                maxYear = reader.GetInt32(0);
            }
            reader.Close();
            Hashtable htpDoanhThuNam = new Hashtable();
            for (int i = minYear; i <= maxYear; i++)
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT SUM(" + tenBang + ".TongTien) as TongTien FROM " + tenBang + " WHERE YEAR(" + tenBang + ".NgayLap) = " + i;
                command.Connection = DatabaseAccess.getConn();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        htpDoanhThuNam.Add(i, 0);
                    }
                    else
                    {
                        int tongTien = reader.GetInt32(0);
                        htpDoanhThuNam.Add(i, tongTien);
                    }
                }
                reader.Close();
            }
            return htpDoanhThuNam;
        }

        public Hashtable thongKeSanPhamTheoNgay(string d, string m, string y)
        {
            Hashtable tkNgay = new Hashtable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT ChiTietHoaDon.MaSanPham, SUM(ChiTietHoaDon.SoLuong) AS SoLuong FROM ChiTietHoaDon, HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND DAY(HoaDon.NgayLap) = " + d + " AND YEAR(HoaDon.NgayLap) = " + y + " AND MONTH(HoaDon.NgayLap) = " + m + " GROUP BY ChiTietHoaDon.MaSanPham";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                }
                else
                {
                    int ma = reader.GetInt32(0);
                    int soLuong = reader.GetInt32(1);
                    tkNgay.Add(ma, soLuong);
                }
            }
            reader.Close();
            return tkNgay;
        }

        public Hashtable thongKeSanPhamTheoThang(string d, string m, string y)
        {
            Hashtable tkThang = new Hashtable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT ChiTietHoaDon.MaSanPham, SUM(ChiTietHoaDon.SoLuong) AS SoLuong FROM ChiTietHoaDon, HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND YEAR(HoaDon.NgayLap) = " + y + " AND MONTH(HoaDon.NgayLap) = " + m + " GROUP BY ChiTietHoaDon.MaSanPham";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                }
                else
                {
                    int ma = reader.GetInt32(0);
                    int soLuong = reader.GetInt32(1);
                    tkThang.Add(ma, soLuong);
                }
            }
            reader.Close();
            return tkThang;
        }

        public Hashtable thongKeSanPhamTheoQuy(string d, string m, string y)
        {
            try
            {
                int mm = Int32.Parse(m);
                int i = 0;
                if (mm > 0 && mm <= 3)
                {
                    i = 1;
                }
                else if (mm > 3 && mm <= 6)
                {
                    i = 4;
                }
                else if (mm > 6 && mm <= 9)
                {
                    i = 7;
                }
                else if (mm > 9 && mm <= 12)
                {
                    i = 10;
                }
                int z = i;
                Hashtable tkQuy = new Hashtable();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT ChiTietHoaDon.MaSanPham, SUM(ChiTietHoaDon.SoLuong) AS SoLuong FROM ChiTietHoaDon, HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND (MONTH(HoaDon.NgayLap) BETWEEN "+i+" AND "+(z+2)+ ") AND YEAR(HoaDon.NgayLap) = "+y+" GROUP BY ChiTietHoaDon.MaSanPham";
                command.Connection = DatabaseAccess.getConn();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                    }
                    else
                    {
                        int ma = reader.GetInt32(0);
                        int soLuong = reader.GetInt32(1);
                        tkQuy.Add(ma, soLuong);
                    }
                }
                reader.Close();
                return tkQuy;
            }
            catch
            {
                return null;
            }
            
        }

        public Hashtable thongKeSanPhamTheoNam(String y)
        {
            Hashtable tkNam = new Hashtable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT ChiTietHoaDon.MaSanPham, SUM(ChiTietHoaDon.SoLuong) AS SoLuong FROM ChiTietHoaDon, HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND YEAR(HoaDon.NgayLap) = " + y + " GROUP BY ChiTietHoaDon.MaSanPham";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                }
                else
                {
                    int ma = reader.GetInt32(0);
                    int soLuong = reader.GetInt32(1);
                    tkNam.Add(ma, soLuong);
                }
            }
            reader.Close();
            return tkNam;
        }

        public Hashtable thongKeNhanVienTheoNgay(string d, string m, string y)
        {
            Hashtable tkNgay = new Hashtable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT HoaDon.MaNhanVien, SUM(ChiTietHoaDon.SoLuong) AS SanPham FROM ChiTietHoaDon,HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND DAY(HoaDon.NgayLap) = " + d + " AND YEAR(HoaDon.NgayLap) = " + y + " AND MONTH(HoaDon.NgayLap) = " + m + " GROUP BY HoaDon.MaNhanVien";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                }
                else
                {
                    int ma = reader.GetInt32(0);
                    int soLuongSanPham = reader.GetInt32(1);
                    tkNgay.Add(ma, soLuongSanPham);
                }
            }
            reader.Close();
            return tkNgay;
        }

        public Hashtable thongKeNhanVienTheoThang(string d, string m, string y)
        {
            Hashtable tkThang = new Hashtable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT HoaDon.MaNhanVien, SUM(ChiTietHoaDon.SoLuong) AS SanPham FROM ChiTietHoaDon,HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND DAY(HoaDon.NgayLap) = " + d + " AND MONTH(HoaDon.NgayLap) = " + m + " GROUP BY HoaDon.MaNhanVien";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                }
                else
                {
                    int ma = reader.GetInt32(0);
                    int soLuong = reader.GetInt32(1);
                    tkThang.Add(ma, soLuong);
                }
            }
            reader.Close();
            return tkThang;
        }

        public Hashtable thongKeNhanVienTheoQuy(string d, string m, string y)
        {
            int mm = Int32.Parse(m);
            int i = 0;
            if (mm > 0 && mm <= 3)
            {
                i = 1;
            }
            else if (mm > 3 && mm <= 6)
            {
                i = 4;
            }
            else if (mm > 6 && mm <= 9)
            {
                i = 7;
            }
            else if (mm > 9 && mm <= 12)
            {
                i = 10;
            }
            int z = i;
            Hashtable tkQuy = new Hashtable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT HoaDon.MaNhanVien, SUM(ChiTietHoaDon.SoLuong) AS SoLuong FROM ChiTietHoaDon, HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND (MONTH(HoaDon.NgayLap) BETWEEN " + i + " AND " + (z + 2) + ") AND YEAR(HoaDon.NgayLap) = " + y + " GROUP BY HoaDon.MaNhanVien";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                }
                else
                {
                    int ma = reader.GetInt32(0);
                    int soLuong = reader.GetInt32(1);
                    tkQuy.Add(ma, soLuong);
                }
            }
            reader.Close();
            return tkQuy;
        }
        public Hashtable thongKeNhanVienTheoNam(string y)
        {
            Hashtable tkNam = new Hashtable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT HoaDon.MaNhanVien, SUM(ChiTietHoaDon.SoLuong) AS SanPham FROM ChiTietHoaDon,HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND YEAR(HoaDon.NgayLap) = " + y + " GROUP BY HoaDon.MaNhanVien";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                }
                else
                {
                    int ma = reader.GetInt32(0);
                    int soLuong = reader.GetInt32(1);
                    tkNam.Add(ma, soLuong);
                }
            }
            reader.Close();
            return tkNam;
        }
        public Hashtable thongKeKhachHangTheoNgay(string d, string m, string y)
        {
            Hashtable tkNgay = new Hashtable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT HoaDon.MaKhachHang, SUM(HoaDon.TongTien) AS TongTien FROM ChiTietHoaDon,HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND DAY(HoaDon.NgayLap) = " + d + " AND YEAR(HoaDon.NgayLap) = " + y + " AND MONTH(HoaDon.NgayLap) = " + m + " GROUP BY HoaDon.MaKhachHang";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                }
                else
                {
                    int ma = reader.GetInt32(0);
                    int soLuong = reader.GetInt32(1);
                    tkNgay.Add(ma, soLuong);
                }
            }
            reader.Close();
            return tkNgay;
        }

        public Hashtable thongKeKhachHangTheoThang(string d, string m, string y)
        {
            Hashtable tkThang = new Hashtable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT HoaDon.MaKhachHang, SUM(HoaDon.TongTien) AS TongTien FROM ChiTietHoaDon,HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND YEAR(HoaDon.NgayLap) = " + y + " AND MONTH(HoaDon.NgayLap) = " + m + " GROUP BY HoaDon.MaKhachHang";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                }
                else
                {
                    int ma = reader.GetInt32(0);
                    int soLuong = reader.GetInt32(1);
                    tkThang.Add(ma, soLuong);
                }
            }
            reader.Close();
            return tkThang;
        }

        public Hashtable thongKeKhachHangTheoQuy(string d, string m, string y)
        {
            int mm = Int32.Parse(m);
            int i = 0;
            if (mm > 0 && mm <= 3)
            {
                i = 1;
            }
            else if (mm > 3 && mm <= 6)
            {
                i = 4;
            }
            else if (mm > 6 && mm <= 9)
            {
                i = 7;
            }
            else if (mm > 9 && mm <= 12)
            {
                i = 10;
            }
            int z = i;
            Hashtable tkQuy = new Hashtable();
            for (; i < z + 3; i++)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT HoaDon.MaKhachHang, SUM(ChiTietHoaDon.SoLuong) AS SoLuong FROM ChiTietHoaDon, HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND (MONTH(HoaDon.NgayLap) BETWEEN " + i + " AND " + (z + 2) + ") AND YEAR(HoaDon.NgayLap) = " + y + " GROUP BY HoaDon.MaKhachHang";
                command.Connection = DatabaseAccess.getConn();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                    }
                    else
                    {
                        int ma = reader.GetInt32(0);
                        int soLuong = reader.GetInt32(1);
                        tkQuy.Add(ma, soLuong);
                    }
                }
                reader.Close();
            }
            return tkQuy;
        }
        public Hashtable thongKeKhachHangTheoNam(String y)
        {
            Hashtable tkNam = new Hashtable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT HoaDon.MaKhachHang, SUM(HoaDon.TongTien) AS TongTien FROM ChiTietHoaDon,HoaDon WHERE ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon AND YEAR(HoaDon.NgayLap) = " + y + " GROUP BY HoaDon.MaKhachHang";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                }
                else
                {
                    int ma = reader.GetInt32(0);
                    int soLuong = reader.GetInt32(1);
                    tkNam.Add(ma, soLuong);
                }
            }
            reader.Close();
            return tkNam;
        }
    }
}
