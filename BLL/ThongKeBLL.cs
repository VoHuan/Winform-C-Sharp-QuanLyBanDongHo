using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        public ThongKeAccess tkDAL;
        public ThongKeBLL()
        {
            tkDAL = new ThongKeAccess();
        }
        public Hashtable doanhThuNgay(String tenBang, String d, String m, String y)
        {
            return tkDAL.doanhThuNgay(tenBang, d, m, y);
        }
        public Hashtable doanhThuThang(String tenBang, String d, String m, String y)
        {
            return tkDAL.doanhThuThang(tenBang, d, m, y);
        }
        public Hashtable doanhThuQuy(String tenBang, String d, String m, String y)
        {
            return tkDAL.doanhThuQuy(tenBang, d, m, y);
        }
        public Hashtable doanhThuNam(String tenBang)
        {
            return tkDAL.doanhThuNam(tenBang);
        }

        //Thong ke san pham
        public Hashtable thongKeSanPhamTheoNgay(string d, string m, string y)
        {
            return tkDAL.thongKeSanPhamTheoNgay(d, m, y);
        }
        public Hashtable thongKeSanPhamTheoThang(string d, string m, string y)
        {
            return tkDAL.thongKeSanPhamTheoThang(d, m, y);
        }
        public Hashtable thongKeSanPhamTheoQuy(string d, string m, string y)
        {
            return tkDAL.thongKeSanPhamTheoQuy(d, m, y);
        }
        public Hashtable thongKeSanPhamTheoNam(string y)
        {
            return tkDAL.thongKeSanPhamTheoNam(y);
        }

        //Thong ke khach hang
        public Hashtable thongKeKhachHangTheoNgay(string d, string m, string y)
        {
            return tkDAL.thongKeKhachHangTheoNgay(d, m, y);
        }

        public Hashtable thongKeKhachHangTheoThang(string d, string m, string y)
        {
            return tkDAL.thongKeKhachHangTheoThang(d, m, y);
        }
        public Hashtable thongKeKhachHangTheoQuy(string d, string m, string y)
        {
            return tkDAL.thongKeKhachHangTheoQuy(d, m, y);
        }
        public Hashtable thongKeKhachHangTheoNam(string y)
        {
            return tkDAL.thongKeKhachHangTheoNam(y);
        }


        //Thong ke nhan vien
        public Hashtable thongKeNhanVienTheoNgay(string d, string m, string y)
        {
            return tkDAL.thongKeNhanVienTheoNgay(d, m, y);
        }
        public Hashtable thongKeNhanVienTheoThang(string d, string m, string y)
        {
            return tkDAL.thongKeNhanVienTheoThang(d, m, y);
        }
        public Hashtable thongKeNhanVienTheoQuy(string d, string m, string y)
        {
            return tkDAL.thongKeNhanVienTheoQuy(d, m, y);
        }
        public Hashtable thongKeNhanVienTheoNam(string y)
        {
            return tkDAL.thongKeNhanVienTheoNam(y);
        }

    }
}
