using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public int MaSanPham { get; set; }
        public int MaDanhMuc { get; set; }      
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public String DuongDan { get; set; }
        public int Phai { get; set; }
        public String TinhTrang { get; set; }
    }
}
