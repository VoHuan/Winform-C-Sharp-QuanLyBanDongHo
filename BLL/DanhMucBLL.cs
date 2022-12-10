using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL

{
    public class DanhMucBLL
    {
        DanhMucAccess danhMucAccess;
    public DanhMucBLL()
    {
        danhMucAccess = new DanhMucAccess();

    }
    public List<DanhMuc> LayToanBoDanhMuc()
    {
        return danhMucAccess.LayToanBoDanhMuc();

    }
    public bool ThemDanhMuc(DanhMuc dm)
    {
        return danhMucAccess.ThemDanhMuc(dm);
    }
    public bool SuaDanhMuc(DanhMuc dm)
    {
        return danhMucAccess.SuaDanhMuc(dm);
    }
    public bool XoaDanhMuc(int ma)
    {
        return danhMucAccess.XoaDanhMuc(ma);
    }

    }
}
