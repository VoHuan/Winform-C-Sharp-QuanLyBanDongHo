using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        
        ChiTietHoaDonAccess chiTietHoaDonAccess;
        public ChiTietHoaDonBLL()
        {
            chiTietHoaDonAccess = new ChiTietHoaDonAccess();

        }
        public List<ChiTietHoaDon> LayToanBoCTHoaDon()
        {
            return chiTietHoaDonAccess.LayToanBoCTHoaDon();

        }
        public void ThemCTHoaDon(ChiTietHoaDon cthd)
        {
             chiTietHoaDonAccess.ThemCTHoaDon(cthd);
        }
        

    
    }
}
