using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietKhuyenMaiBLL
    {
        ChiTietKhuyenMaiAccess chiTietKhuyenMaiAccess;
        public ChiTietKhuyenMaiBLL()
        {
            chiTietKhuyenMaiAccess = new ChiTietKhuyenMaiAccess();

        }
        public List<ChiTietKhuyenMai> LayToanBoCTKM()
        {
            return chiTietKhuyenMaiAccess.LayToanBoCTKM();

        }
        public List<ChiTietKhuyenMai> LayToanBoCTKM(int ma)
        {
            return chiTietKhuyenMaiAccess.LayToanBoCTKM(ma);

        }
        public bool ThemCTKM(ChiTietKhuyenMai ctkm)
        {
            return chiTietKhuyenMaiAccess.ThemCTKM(ctkm);
        }
        public bool SuaCTKM(ChiTietKhuyenMai ctkm)
        {
            return chiTietKhuyenMaiAccess.SuaCTKM(ctkm);
        }
        public bool XoaCTKM(ChiTietKhuyenMai ctkm)
        {
            return chiTietKhuyenMaiAccess.XoaCTKM(ctkm);
        }
    }
}
