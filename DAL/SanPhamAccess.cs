using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamAccess
    {
        public List<SanPham> LayToanBoSanPham()
        {
            List<SanPham> dssp = new List<SanPham>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham where TinhTrang = 1";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maSanPham = reader.GetInt32("MaSanPham");
                Console.WriteLine(maSanPham);
                int maDanhMuc = reader.GetInt32("MaLoai");
               
                string tenSanPham = reader.GetString("TenSanPham");
                int donGia = reader.GetInt32("DonGia");
                int soLuong = reader.GetInt32("SoLuong");
                int phai = reader.GetInt32("PhanLoai");
                string duongDan = "";
                try
                {
                    duongDan = reader.GetString("DuongDan");
                } catch (Exception e)
                {
                    
                }

                SanPham sp = new SanPham();
                sp.MaSanPham = maSanPham;
                sp.MaDanhMuc = maDanhMuc;
                sp.Phai = phai;
                sp.TenSanPham = tenSanPham;
                sp.DonGia = donGia;
                sp.SoLuong = soLuong;
                sp.DuongDan = duongDan + "";

                dssp.Add(sp);
            }
            reader.Close();
            return dssp;
        }
        public List<SanPham> LayToanBoSanPhamTheoLoai(int ma)
        {
            List<SanPham> dssp = new List<SanPham>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham where maLoai = @ma and tinhtrang =1";
            command.Connection = DatabaseAccess.getConn();
            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maSanPham = reader.GetInt32("MaSanPham");              
                int maDanhMuc = reader.GetInt32("MaLoai");
                
                string tenSanPham = reader.GetString("TenSanPham");
                int donGia = reader.GetInt32("DonGia");
                int soLuong = reader.GetInt32("SoLuong");
                int phai = reader.GetInt32("PhanLoai");
                string duongDan = "";
                try
                {
                    duongDan = reader.GetString("DuongDan");
                }
                catch (Exception e)
                {

                }

                SanPham sp = new SanPham();
                sp.MaSanPham = maSanPham;
                sp.MaDanhMuc = maDanhMuc;
                sp.Phai = phai;
                sp.TenSanPham = tenSanPham;
                sp.DonGia = donGia;
                sp.SoLuong = soLuong;
                sp.DuongDan = duongDan + "";

                dssp.Add(sp);
            }
            reader.Close();
            return dssp;
        }

        public List<SanPham> TimKiemTheoMaSP(int ma)
        {
            List<SanPham> dssp = new List<SanPham>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham where maSanPham = @ma and tinhtrang =1";
            command.Connection = DatabaseAccess.getConn();
            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maSanPham = reader.GetInt32("MaSanPham");
                int maDanhMuc = reader.GetInt32("MaLoai");
                
                string tenSanPham = reader.GetString("TenSanPham");
                int donGia = reader.GetInt32("DonGia");
                int soLuong = reader.GetInt32("SoLuong");
                int phai = reader.GetInt32("PhanLoai");
                string duongDan = "";
                try
                {
                    duongDan = reader.GetString("DuongDan");
                }
                catch (Exception e)
                {

                }

                SanPham sp = new SanPham();
                sp.MaSanPham = maSanPham;
                sp.MaDanhMuc = maDanhMuc;
                sp.Phai = phai;
                sp.TenSanPham = tenSanPham;
                sp.DonGia = donGia;
                sp.SoLuong = soLuong;
                sp.DuongDan = duongDan + "";

                dssp.Add(sp);
            }
            reader.Close();
            return dssp;
        }
        public List<SanPham> TimKiemTheoPhai(int phanloai)
        {
            List<SanPham> dssp = new List<SanPham>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham where PhanLoai = @phanLoai and tinhtrang =1";
            command.Connection = DatabaseAccess.getConn();
            command.Parameters.Add("@phanLoai", SqlDbType.Int).Value = phanloai;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maSanPham = reader.GetInt32("MaSanPham");
                int maDanhMuc = reader.GetInt32("MaLoai");

                string tenSanPham = reader.GetString("TenSanPham");
                int donGia = reader.GetInt32("DonGia");
                int soLuong = reader.GetInt32("SoLuong");
                int phai = reader.GetInt32("PhanLoai");
                string duongDan = "";
                try
                {
                    duongDan = reader.GetString("DuongDan");
                }
                catch (Exception e)
                {

                }

                SanPham sp = new SanPham();
                sp.MaSanPham = maSanPham;
                sp.MaDanhMuc = maDanhMuc;
                sp.Phai = phai;
                sp.TenSanPham = tenSanPham;
                sp.DonGia = donGia;
                sp.SoLuong = soLuong;
                sp.DuongDan = duongDan + "";

                dssp.Add(sp);
            }
            reader.Close();
            return dssp;
        }
        public List<SanPham> TimKiemTheoTenSP(string ten)
        {
            List<SanPham> dssp = new List<SanPham>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham where tenSanPham = @ten and tinhtrang =1";
            command.Connection = DatabaseAccess.getConn();
            command.Parameters.Add("@ten", SqlDbType.Char).Value = ten;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maSanPham = reader.GetInt32("MaSanPham");
                int maDanhMuc = reader.GetInt32("MaLoai");
               
                string tenSanPham = reader.GetString("TenSanPham");
                int donGia = reader.GetInt32("DonGia");
                int soLuong = reader.GetInt32("SoLuong");
                int phai = reader.GetInt32("PhanLoai");
                string duongDan = "";
                try
                {
                    duongDan = reader.GetString("DuongDan");
                }
                catch (Exception e)
                {

                }

                SanPham sp = new SanPham();
                sp.MaSanPham = maSanPham;
                sp.MaDanhMuc = maDanhMuc;
                sp.Phai = phai;
                sp.TenSanPham = tenSanPham;
                sp.DonGia = donGia;
                sp.SoLuong = soLuong;
                sp.DuongDan = duongDan + "";

                dssp.Add(sp);
            }
            reader.Close();
            return dssp;
        }
        public List<SanPham> TimKiemTheoGia(int gia)
        {
            List<SanPham> dssp = new List<SanPham>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham where donGia = @gia and tinhtrang =1";
            command.Connection = DatabaseAccess.getConn();
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maSanPham = reader.GetInt32("MaSanPham");
                int maDanhMuc = reader.GetInt32("MaLoai");

                string tenSanPham = reader.GetString("TenSanPham");
                int donGia = reader.GetInt32("DonGia");
                int soLuong = reader.GetInt32("SoLuong");
                int phai = reader.GetInt32("PhanLoai");
                string duongDan = "";
                try
                {
                    duongDan = reader.GetString("DuongDan");
                }
                catch (Exception e)
                {

                }

                SanPham sp = new SanPham();
                sp.MaSanPham = maSanPham;
                sp.MaDanhMuc = maDanhMuc;
                sp.Phai = phai;
                sp.TenSanPham = tenSanPham;
                sp.DonGia = donGia;
                sp.SoLuong = soLuong;
                sp.DuongDan = duongDan + "";

                dssp.Add(sp);
            }
            reader.Close();
            return dssp;
        }
        public List<SanPham> TimKiemTheoSoLuong(int soluong)
        {
            List<SanPham> dssp = new List<SanPham>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham where soLuong = @soluong and tinhtrang =1";
            command.Connection = DatabaseAccess.getConn();
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maSanPham = reader.GetInt32("MaSanPham");
                int maDanhMuc = reader.GetInt32("MaLoai");
                
                string tenSanPham = reader.GetString("TenSanPham");
                int donGia = reader.GetInt32("DonGia");
                int soLuong = reader.GetInt32("SoLuong");
                int phai = reader.GetInt32("PhanLoai");
                string duongDan = "";
                try
                {
                    duongDan = reader.GetString("DuongDan");
                }
                catch (Exception e)
                {

                }

                SanPham sp = new SanPham();
                sp.MaSanPham = maSanPham;
                sp.MaDanhMuc = maDanhMuc;
                sp.Phai = phai;
                sp.TenSanPham = tenSanPham;
                sp.DonGia = donGia;
                sp.SoLuong = soLuong;
                sp.DuongDan = duongDan + "";

                dssp.Add(sp);
            }
            reader.Close();
            return dssp;
        }
        public bool SuaSanPham(SanPham sp)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE SanPham SET MaLoai=@maLoai, TenSanPham=@tenSanPham, DonGia=@donGia, SoLuong=@soLuong, DuongDan=@duongDan, PhanLoai=@phanLoai WHERE MaSanPham=@maSanPham";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = sp.MaSanPham;
                command.Parameters.Add("@maLoai", SqlDbType.Int).Value = sp.MaDanhMuc;
                command.Parameters.Add("@phanLoai", SqlDbType.Int).Value = sp.Phai;
                command.Parameters.Add("@tenSanPham", SqlDbType.Char).Value = sp.TenSanPham;
                command.Parameters.Add("@donGia", SqlDbType.Int).Value = sp.DonGia;
                command.Parameters.Add("@soLuong", SqlDbType.Char).Value = sp.SoLuong;
                command.Parameters.Add("@duongDan", SqlDbType.Char).Value = sp.DuongDan;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            } catch (Exception ex)
            {
                return false;
            }
        }
        
        public bool ThemSanPham(SanPham sp)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO SanPham VALUES(@maLoai,@tenSanPham,@donGia,@soLuong,@duongDan,@phanLoai,1)";
                command.Connection = DatabaseAccess.getConn();
               // command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = sp.MaSanPham;
                command.Parameters.Add("@maLoai", SqlDbType.Int).Value = sp.MaDanhMuc;
                command.Parameters.Add("@phanLoai", SqlDbType.Int).Value = sp.Phai;
                command.Parameters.Add("@tenSanPham", SqlDbType.Char).Value = sp.TenSanPham;
                command.Parameters.Add("@donGia", SqlDbType.Int).Value = sp.DonGia;
                command.Parameters.Add("@soLuong", SqlDbType.Int).Value = sp.SoLuong;
                command.Parameters.Add("@duongDan", SqlDbType.Char).Value = sp.DuongDan;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            } catch (Exception ex)
            {
               System.Diagnostics.Debug.WriteLine(ex.Message);
               Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool XoaSanPham(int ma)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE SanPham SET TinhTrang = 0 WHERE MaSanPham = @ma";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateSoLuong(int ma, int soluong)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE SanPham SET SoLuong = (SoLuong - @soluong) WHERE MaSanPham = @ma";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
                command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
                int kq = command.ExecuteNonQuery();

                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CapNhatSoLuong(List<SanPham> dsTemp)
        {
            bool check = true;
            try
            {
                foreach (SanPham obj in dsTemp)
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE SanPham SET SoLuong=@soLuong WHERE MaSanPham=@maSanPham";
                    command.Connection = DatabaseAccess.getConn();
                    command.Parameters.Add("@maSanPham", SqlDbType.Int).Value = obj.MaSanPham;
                    command.Parameters.Add("@soLuong", SqlDbType.Char).Value = obj.SoLuong;
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
