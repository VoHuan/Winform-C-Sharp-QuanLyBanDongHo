using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhuyenMaiBLL
    {
        KhuyenMaiAccess khuyenMaiAccess;
        public KhuyenMaiBLL()
        {
            khuyenMaiAccess = new KhuyenMaiAccess();

        }
        public List<KhuyenMai> LayToanBoKhuyenMai()
        {
            return khuyenMaiAccess.LayToanBoKhuyenMai();

        }
        public bool XoaKhuyenMai(int ma)
        {
            return khuyenMaiAccess.XoaKhuyenMai(ma);
        }
        public bool SuaKhuyenMai(KhuyenMai obj)
        {
            return khuyenMaiAccess.SuaKhuyenMai(obj);
        }
        public bool ThemKhuyenMai(KhuyenMai obj)
        {
            return khuyenMaiAccess.ThemKhuyenMai(obj);
        }
    }
}
