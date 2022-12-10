using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class PhanQuyenBLL
    {
        PhanQuyenAccess pq;
        public PhanQuyenBLL()
        {
            pq = new PhanQuyenAccess();

        }
        public List<PhanQuyen> LayToanBoPhanQuyen()
        {
            return pq.LayToanBoPhanQuyen();

        }
        public PhanQuyen getPhanQuyen(string maquyen)
        {
            return pq.getPhanQuyen(maquyen);
        }
        public bool themQuyen(string maquyen)
        {
            return pq.themQuyen(maquyen);
        }
        public bool suaQuyen(PhanQuyen phanquyen)
        {
            return pq.suaQuyen(phanquyen);
        }
        public bool xoaQuyen(string maquyen)
        {
            return pq.xoaQuyen(maquyen);
        }
    }

}
