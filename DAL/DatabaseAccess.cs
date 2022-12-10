
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DAL
{
    public class DatabaseAccess 
    {
/*        public static string strConn = "Server=DESKTOP-LJ6HVC9\\SQLEXPRESS;Database=QuanLyBanHang;User Id=\"\";pwd=\"\"";*/
        public static string strConn = @"Data Source=DESKTOP-NCG51K4\VOHUAN;Initial Catalog=QuanLyBanDongHo;Integrated Security=True";
        public static SqlConnection conn = null;
        public static void OpenConnection()
        {
            if(conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn!=null && conn.State==ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public static SqlConnection getConn()
        {
            OpenConnection();
            return conn;
        }
    }
}