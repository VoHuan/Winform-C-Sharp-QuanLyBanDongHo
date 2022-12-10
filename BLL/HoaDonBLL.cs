using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonAccess hoaDonAccess;
        public HoaDonBLL()
        {
            hoaDonAccess = new HoaDonAccess();

        }
        public List<HoaDon> LayToanBoHoaDon()
        {
            return hoaDonAccess.LayToanBoHoaDon();

        }
        public bool ThemHoaDon(HoaDon hd)
        {
            return hoaDonAccess.ThemHoaDon(hd);
        }
        public int getMaHoaDonMoiNhat()
        {
            return hoaDonAccess.getMaHoaDonMoiNhat();
        }
    }
}
