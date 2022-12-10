using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapBLL
    {
        PhieuNhapDAL pnDAL;
        public PhieuNhapBLL()
        {
            pnDAL = new PhieuNhapDAL();

        }
        public List<PhieuNhap> LayToanBoPhieuNhap()
        {
            return pnDAL.LayToanBoPhieuNhap();

        }
        public bool ThemPhieuNhap(PhieuNhap obj)
        {
            return pnDAL.ThemPhieuNhap(obj);
        }
        public bool SuaPhieuNhap(PhieuNhap obj)
        {
            return pnDAL.SuaPhieuNhap(obj);
        }
        public int MaCuoiCung()
        {
            return pnDAL.MaCuoiCung();
        }
    }
}
