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
    public class NhanVienAccess
    {
        public List<NhanVien> LayToanBoNhanVien()
        {
            List<NhanVien> dsnv = new List<NhanVien>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NhanVien where tinhtrang =1";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                DateTime ngaySinh = reader.GetDateTime(2);
                string soDienThoai = reader.GetString(3);
                string chucvu = reader.GetString(4);

                NhanVien nv = new NhanVien();
                nv.MaNhanVien = ma;
                nv.TenNhanVien = ten;
                nv.NgaySinh = ngaySinh;
                nv.SoDienThoai = soDienThoai;
                nv.ChucVu = chucvu;

                dsnv.Add(nv);
                Console.Write(nv.MaNhanVien);
            }
            reader.Close();
            return dsnv;
        }

        public bool themNhanVien(NhanVien nv)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO NhanVien VALUES(@tenNhanVien,@ngaySinh,@soDienThoai,@chucVu,1)";
                command.Connection = DatabaseAccess.getConn();
                
                command.Parameters.Add("@tenNhanVien", SqlDbType.NChar).Value = nv.TenNhanVien;
                command.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value =nv.NgaySinh;
                command.Parameters.Add("@soDienThoai", SqlDbType.NChar).Value = nv.SoDienThoai;
                command.Parameters.Add("@chucVu", SqlDbType.NChar).Value = nv.ChucVu;
               
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool xoaNhanVien(int maNV)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Nhanvien SET TinhTrang = 0 WHERE Manhanvien = @ma";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@ma", SqlDbType.Int).Value = maNV;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool suaNhanVien(NhanVien nv)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE NhanVien SET TenNhanVien=@tennv, NgaySinh=@ns, sodienthoai=@sdt, chucvu=@chucvu WHERE Manhanvien=@ma";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@tennv", SqlDbType.NChar).Value = nv.TenNhanVien;
                command.Parameters.Add("@ns", SqlDbType.DateTime).Value = nv.NgaySinh;
                command.Parameters.Add("@sdt", SqlDbType.NChar).Value = nv.SoDienThoai;
                command.Parameters.Add("@chucvu", SqlDbType.NChar).Value = nv.ChucVu;
                command.Parameters.Add("@ma", SqlDbType.Int).Value = nv.MaNhanVien;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public NhanVien getNhanVien (int ma)
        {
            
            List<NhanVien> dsnv = new List<NhanVien>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NhanVien where maNhanVien = @ma AND tinhtrang =1";
            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int maNV = reader.GetInt32(0);
                string ten = reader.GetString(1);
                DateTime ngaySinh = reader.GetDateTime(2);
                string soDienThoai = reader.GetString(3);
                string chucvu = reader.GetString(4);

                NhanVien nv = new NhanVien();
                nv.MaNhanVien = maNV;
                nv.TenNhanVien = ten;
                nv.NgaySinh = ngaySinh;
                nv.SoDienThoai = soDienThoai;
                nv.ChucVu = chucvu;

                dsnv.Add(nv);
                Console.Write(nv.MaNhanVien);
            }
             reader.Close();
            return dsnv[0];
        }
    }
}
