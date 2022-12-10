using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CTPNBLL
    {
        CTPNDAL ctpnDAL;
        public CTPNBLL()
        {
            ctpnDAL = new CTPNDAL();
        }

        public List<CTPN> LayToanBoCTPN()
        {
            return ctpnDAL.LayToanBoCTPN();
        }

        public bool themChiTietPhieuNhap(List<CTPN> dsCTPN)
        {
            return ctpnDAL.themChiTietPhieuNhap(dsCTPN);
        }
    }
}
