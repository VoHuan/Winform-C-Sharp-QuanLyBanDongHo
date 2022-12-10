using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DanhMucAccess
    {
        public List<DanhMuc> LayToanBoDanhMuc()
        {
            List<DanhMuc> dsdm = new List<DanhMuc>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from LoaiSanPham where tinhtrang = 1";
            command.Connection = DatabaseAccess.getConn();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maDanhMuc = reader.GetInt32(0);
                string tenDanhMuc = reader.GetString(1);
                DanhMuc dm = new DanhMuc();
                dm.MaDanhMuc = maDanhMuc;
                dm.TenDanhMuc = tenDanhMuc;
                dsdm.Add(dm);
                Console.Write(dm.MaDanhMuc);
            }
            reader.Close();
            return dsdm;
           
        }
      
        public bool SuaDanhMuc(DanhMuc dm)
    {
        try
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE LoaiSanPham SET  TenLoai=@tenLoai WHERE MaLoai=@maDanhMuc";
            command.Connection = DatabaseAccess.getConn();
            command.Parameters.Add("@maDanhMuc", SqlDbType.Int).Value = dm.MaDanhMuc;          
            command.Parameters.Add("@tenLoai", SqlDbType.Char).Value = dm.TenDanhMuc;          
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            return false;
        }
    }
        public bool XoaDanhMuc(int ma)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE LoaiSanPham SET TinhTrang = 0 WHERE MaLoai = @ma";
                command.Connection = DatabaseAccess.getConn();
                command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
                int kq = command.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool ThemDanhMuc(DanhMuc dm)
    {
        try
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO LoaiSanPham VALUES(@tenLoai,1)";
            command.Connection = DatabaseAccess.getConn();          
            command.Parameters.Add("@tenLoai", SqlDbType.Char).Value = dm.TenDanhMuc;          
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            return false;
        }
    }

    

    }
}
