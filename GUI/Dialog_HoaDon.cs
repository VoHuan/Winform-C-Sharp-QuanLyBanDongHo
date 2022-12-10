using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Imaging;

namespace GUI
{
    public partial class Dialog_HoaDon : Form
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");



        Bitmap memoryImage;



        public Dialog_HoaDon()
        {
           
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            InitializeComponent();
        }
        public void HienThiHoaDon(List<SanPham> list,string maHD,string khachHang, string nhanvien,int diemtichluyThem, int diemtichluygiam,int diemtichluy,
            int tonggiam, int tongtien)
        {
            tbMaHD.Text = maHD;
            tbKhacHang.Text = khachHang;
            tbNhanVien.Text = nhanvien;

            DateTime now = DateTime.Now;
            tbNgayLap.Text = now.ToString();

            foreach (SanPham sp in list)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.TenSanPham + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                long thanhtien = sp.DonGia * sp.SoLuong;
                lvi.SubItems.Add(long.Parse(thanhtien + "").ToString("#,###", cul.NumberFormat) + "");
                lvSanPham.Items.Add(lvi);
            }


            int height;
            if (list.Count <= 3)
            {
                height = 50 * list.Count;
            }
            else
            {
                height = 35 * list.Count;
            }
            
            
            lvSanPham.Size =  new Size(698, height);

            tbDiemCongThem.Text = "Điểm tích lũy cộng thêm :     " +diemtichluyThem;
            tbDiemDaSuDung.Text = "Điểm tích lũy đã sử dụng :    " + diemtichluygiam;
            tbDiemConLai.Text = "Điểm tích lũy còn lại :         " + diemtichluy;

            if (tonggiam > 0)
            {
                tbTongTienGiam.Text = "Tổng khuyến mãi :                 " + tonggiam.ToString("#,###", cul.NumberFormat) + "  VNĐ";
            }
            else
            {
                tbTongTienGiam.Text = "Tổng khuyến mãi :                 " + 0 + "  VNĐ";
            }
           
            int t = tonggiam + tongtien;
            tbTongTienChuaKM.Text = "Tổng tiền chưa khuyến mãi :  " + t.ToString("#,###", cul.NumberFormat)  + "  VNĐ";
            tbTongTien.Text =       "Tổng Tiền :                     " + tongtien.ToString("#,###", cul.NumberFormat) + "  VNĐ";
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        

        private void btnIn_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }
        
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width-50, s.Height-100, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, -10, -10, s);
           
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 130, 100);
            
        }

        private void Dialog_HoaDon_Load(object sender, EventArgs e)
        {

        }
    }
        
    
}
