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
    public  class NhaCungCapDAL
    {
        
    public List<NhaCungCap> LayToanBoNhaCungCap()
        {
            List<NhaCungCap> dsncc = new List<NhaCungCap>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NhaCungCap where TinhTrang = 1";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maNhaCungCap = reader.GetInt32("MaNhaCungCap");
                string tenNhaCungCap = reader.GetString("TenNhaCungCap").Trim();
                string diaChi = reader.GetString("DiaChi").Trim();
                string soDienThoai = reader.GetString("SoDienThoai").Trim();
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNhaCungCap = maNhaCungCap;
                ncc.TenNhaCungCap = tenNhaCungCap.Trim();
                ncc.DiaChi = diaChi.Trim();
                ncc.SoDienThoai = soDienThoai.Trim();
                dsncc.Add(ncc);
            }
            reader.Close();
            return dsncc;
        }
        public bool SuaNhaCungCap(NhaCungCap obj)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE NhaCungCap SET TenNhaCungCap=@tenNhaCungCap, DiaChi=@diaChi, SoDienThoai=@soDienThoai WHERE MaNhaCungCap=@maNhaCungCap";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@maNhaCungCap", SqlDbType.Int).Value = obj.MaNhaCungCap;
                command.Parameters.Add("@tenNhaCungCap", SqlDbType.NVarChar).Value = obj.TenNhaCungCap;
                command.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = obj.DiaChi;
                command.Parameters.Add("@soDienThoai", SqlDbType.NVarChar).Value = obj.SoDienThoai;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemNhaCungCap(NhaCungCap obj)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO NhaCungCap VALUES(@tenNhaCungCap,@diaChi,@soDienThoai,1)";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@tenNhaCungCap", SqlDbType.NVarChar).Value = obj.TenNhaCungCap;
                command.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = obj.DiaChi;
                command.Parameters.Add("@soDienThoai", SqlDbType.NVarChar).Value = obj.SoDienThoai;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool XoaNhaCungCap(int ma)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE NhaCungCap SET TinhTrang = 0 WHERE MaNhaCungCap = @ma";
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
    }

}
