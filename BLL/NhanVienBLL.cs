using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienAccess nhanVienAccess;
        public NhanVienBLL()
        {
            nhanVienAccess = new NhanVienAccess();
        }
        public List<NhanVien> layToanBoNhanVien()
        {
            return nhanVienAccess.LayToanBoNhanVien();
        }
        public NhanVien getNhanVien(int ma)
        {
            return nhanVienAccess.getNhanVien(ma);
        }
        public bool themNhanVien(NhanVien nv)
        {
            return nhanVienAccess.themNhanVien(nv);
        }
        public bool xoaNhanVien(int maNV)
        {
            return nhanVienAccess.xoaNhanVien(maNV);
        }
        public bool suaNhanVien(NhanVien nv)
        {
            return nhanVienAccess.suaNhanVien(nv);
        }

    }
}
