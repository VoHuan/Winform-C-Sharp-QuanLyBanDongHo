using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private NhaCungCapDAL nccDAL;
        public NhaCungCapBLL()
        {
            nccDAL = new NhaCungCapDAL();
        }
        public List<NhaCungCap> LayNhaCungCap()
        {
            return nccDAL.LayToanBoNhaCungCap();
        }

        public bool themNhaCungCap(NhaCungCap obj)
        {
            return nccDAL.ThemNhaCungCap(obj);
        }
        public bool suaNhaCungCap(NhaCungCap obj)
        {
            return nccDAL.SuaNhaCungCap(obj);
        }
        public bool xoaNhaCungCap(int num)
        {
            return nccDAL.XoaNhaCungCap(num);
        }
    }
}
