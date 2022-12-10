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
    public class TaiKhoanAccess
    {
        public List<TaiKhoan> LayToanBoTaiKhoan()
        {
            List<TaiKhoan> dstk = new List<TaiKhoan>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from TaiKhoan";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maQuyen = reader.GetString(0);

                int maNhanVien = reader.GetInt32(1);
                string tenDangNhap = reader.GetString(2);
                string matKhau = reader.GetString(3);
                string tinhTrang = reader.GetString(4);


                TaiKhoan tk = new TaiKhoan();
                tk.MaQuyen = maQuyen;
                tk.MaNhanVien = maNhanVien;
                tk.TenDangNhap = tenDangNhap;
                tk.MatKhau = matKhau;
                tk.TinhTrang = tinhTrang;


                dstk.Add(tk);
            }
            reader.Close();
            return dstk;
        }
        public bool khoaTaiKhoan(int maNhanVien)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE TaiKhoan SET TinhTrang = 0 WHERE MaNhanVien = @maNhanVien";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = maNhanVien;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool moKhoaTaiKhoan(int maNhanVien)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE TaiKhoan SET TinhTrang = 1 WHERE MaNhanVien = @maNhanVien";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = maNhanVien;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SuaTaiKhoan(TaiKhoan tk)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE TaiKhoan SET MaQuyen=@maQuyen, TenDangNhap=@tenDangNhap, MatKhau=@matKhau WHERE MaNhanVien=@maNhanVien";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maQuyen", SqlDbType.NChar).Value = tk.MaQuyen;
                command.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = tk.MaNhanVien;
                command.Parameters.Add("@tenDangNhap", SqlDbType.VarChar).Value = tk.TenDangNhap;
                command.Parameters.Add("@matKhau", SqlDbType.VarChar).Value = tk.MatKhau;


                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemTaiKhoan(TaiKhoan tk)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO TaiKhoan VALUES(@maQuyen,@maNhanVien,@tenDangNhap,@matKhau,1)";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maQuyen", SqlDbType.NChar).Value = tk.MaQuyen;
                command.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = tk.MaNhanVien;

                command.Parameters.Add("@tenDangNhap", SqlDbType.VarChar).Value = tk.TenDangNhap;

                command.Parameters.Add("@matKhau", SqlDbType.VarChar).Value = tk.MatKhau;

                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaTaiKhoan(int maNhanVien)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE TaiKhoan SET TinhTrang = 0 WHERE MaNhanVien = @maNhanVien";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = maNhanVien;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool checkTaiKhoan(string user, string pass)
        {
            try
            {
                
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from TaiKhoan where tendangnhap = @user and matkhau = @pass and tinhtrang=1";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@user", SqlDbType.Char).Value = user;
                command.Parameters.Add("@pass", SqlDbType.Char).Value = pass;
                
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public TaiKhoan getTaiKhoan(string user, string pass)
        {
            try
            {
                List<TaiKhoan> dstk = new List<TaiKhoan>();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from TaiKhoan where tendangnhap = @user and matkhau = @pass and tinhtrang=1";
                command.Parameters.Add("@user", SqlDbType.Char).Value = user;
                command.Parameters.Add("@pass", SqlDbType.Char).Value = pass;
                command.Connection = DatabaseAccess.getConn();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string maQuyen = reader.GetString(0);

                    int maNhanVien = reader.GetInt32(1);
                    string tenDangNhap = reader.GetString(2);
                    string matKhau = reader.GetString(3);
                    string tinhTrang = reader.GetString(4);


                    TaiKhoan tk = new TaiKhoan();
                    tk.MaQuyen = maQuyen;
                    tk.MaNhanVien = maNhanVien;
                    tk.TenDangNhap = tenDangNhap;
                    tk.MatKhau = matKhau;
                    tk.TinhTrang = tinhTrang;


                    dstk.Add(tk);
                }
                reader.Close();
                return dstk[0];
            }
            catch
            {
                return null;
            }
           
        }
        public bool checkTaiKhoan1(int manv)
        {
            try
            {

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from TaiKhoan where MaNhanVien = @ma and tinhtrang =1";
                command.Connection = DatabaseAccess.getConn();

                command.Parameters.Add("@ma", SqlDbType.Int).Value = manv;

                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public TaiKhoan getTaiKhoan1(int ma)
        {
            try
            {
                List<TaiKhoan> dstk = new List<TaiKhoan>();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from TaiKhoan where manhanvien=@ma";
                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;               
                command.Connection = DatabaseAccess.getConn();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string maQuyen = reader.GetString(0);

                    int maNhanVien = reader.GetInt32(1);
                    string tenDangNhap = reader.GetString(2);
                    string matKhau = reader.GetString(3);
                    string tinhTrang = reader.GetString(4);


                    TaiKhoan tk = new TaiKhoan();
                    tk.MaQuyen = maQuyen;
                    tk.MaNhanVien = maNhanVien;
                    tk.TenDangNhap = tenDangNhap;
                    tk.MatKhau = matKhau;
                    tk.TinhTrang = tinhTrang;


                    dstk.Add(tk);
                }
                reader.Close();
                return dstk[0];
            }
            catch
            {
                return null;
            }
        }
    }
}
