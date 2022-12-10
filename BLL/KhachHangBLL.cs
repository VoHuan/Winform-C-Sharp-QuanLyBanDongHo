using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangAccess khachHangAccess;
        public KhachHangBLL()
        {
            khachHangAccess = new KhachHangAccess();

        }
        public List<KhachHang> LayToanBoKhachHang()
        {
            return khachHangAccess.LayToanBoKhachHang();

        }
        public bool ThemKachHang1(KhachHang kh)
        {
            return khachHangAccess.ThemKhachHang1(kh);
        }
        public bool TimKiemKhachHang(int ma)
        {
            return khachHangAccess.TimKiemKhachHang(ma);
        }
        public bool UpdateDiemTichLuy(int ma, int diem)
        {
            return khachHangAccess.UpdateDiemTichLuy(ma, diem);
        }
        public bool UpdateTongChiTieu(int ma, int chitieu)
        {
            return khachHangAccess.updateTongChiTieu(ma, chitieu);
        }

        public List<KhachHang> getKhachHang(int ma)
        {
            return khachHangAccess.getKhachHang(ma);
        }
        public int getDiemTichLuy(int ma)
        {
            return khachHangAccess.getDiemTichLuy(ma);
        }
        public bool ThemKhachHang(KhachHang kh)
        {
            return khachHangAccess.ThemKhachHang(kh);
        }

        public bool SuaKhachHang(KhachHang kh)
        {
            return khachHangAccess.SuaKhachHang(kh);
        }

        public bool XoaKhachHang(KhachHang kh)
        {
            return khachHangAccess.XoaKhachHang(kh);
        }
    }
}
