using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkhoan;
        public TaiKhoanBLL()
        {
            tkhoan = new TaiKhoanAccess();
        }
        public List<TaiKhoan> layToanBoTaiKhoan()
        {
            return tkhoan.LayToanBoTaiKhoan();
        }
        public bool khoaTaiKhoan(int maNhanVien)
        {
            return tkhoan.khoaTaiKhoan(maNhanVien);
        }
        public bool moKhoaTaiKhoan(int maNhanVien)
        {
            return tkhoan.moKhoaTaiKhoan(maNhanVien);
        }
        public bool ThemTaiKhoan(TaiKhoan tk)
        {
            return tkhoan.ThemTaiKhoan(tk);
        }
        public bool SuaTaiKhoan(TaiKhoan tk)
        {
            return tkhoan.SuaTaiKhoan(tk);
        }
        public bool XoaTaiKhoan(int maNhanVien)
        {
            return tkhoan.XoaTaiKhoan(maNhanVien);
        }
        public bool checkTaiKhoan(string user,string pass)
        {
            return tkhoan.checkTaiKhoan(user, pass);
        }
        public TaiKhoan getTaiKhoan(string user, string pass)
        {
            return tkhoan.getTaiKhoan(user, pass);
        }
        public TaiKhoan getTaiKhoan1(int ma)
        {
            return tkhoan.getTaiKhoan1(ma);
        }
        public bool checkTaiKhoan1(int manv)
        {
            return tkhoan.checkTaiKhoan1(manv);
        }
    }
}
