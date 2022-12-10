using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamAccess sanPhamAccess;
        public SanPhamBLL ()
        {
            sanPhamAccess = new SanPhamAccess ();

        }

        public List<SanPham> LayToanBoSanPham()
        {
            return sanPhamAccess.LayToanBoSanPham();
            
        }
        public List<SanPham> LayToanBoSanPhamTheoLoai(int ma)
        {
            return sanPhamAccess.LayToanBoSanPhamTheoLoai(ma);

        }
        public List<SanPham> TimKiemTheoMaSP(int ma)
        {
            return sanPhamAccess.TimKiemTheoMaSP(ma);

        }
        public List<SanPham> TimKiemTheoPhai(int phai)
        {
            return sanPhamAccess.TimKiemTheoPhai(phai);

        }
        public List<SanPham> TimKiemTheoTenSP(string ten)
        {
            return sanPhamAccess.TimKiemTheoTenSP(ten);

        }
        public List<SanPham> TimKiemTheoGia(int gia)
        {
            return sanPhamAccess.TimKiemTheoGia(gia);

        }
        public List<SanPham> TimKiemTheoSoLuong(int soluong)
        {
            return sanPhamAccess.TimKiemTheoSoLuong(soluong);

        }
        public bool ThemSanPham(SanPham sp)
        {
            return sanPhamAccess.ThemSanPham(sp);
        }
        public bool SuaSanPham(SanPham sp)
        {
            return sanPhamAccess.SuaSanPham(sp);
        }
        public bool XoaSanPham(int ma)
        {
            return sanPhamAccess.XoaSanPham(ma);
        }
        public bool UpdateSoLuong (int ma, int soluong)
        {
            return sanPhamAccess.UpdateSoLuong(ma, soluong);
        }
        public bool CapNhatSoLuong(List<SanPham> dsTemp)
        {
            return sanPhamAccess.CapNhatSoLuong(dsTemp);
        }


    }
}
/*        public static SanPhamBLL spBLL;
        public static SanPhamBLL getInstance()
        {
            if (spBLL == null)
            {
                spBLL = new SanPhamBLL();
            }
            return spBLL;
        }*/