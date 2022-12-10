using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    
    public partial class Dialog_ChonKhachHang : Form
    {
        KhachHangBLL khBLL;
        List<KhachHang> dsKhachHang = new List<KhachHang>();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public static KhachHang KhachHangTimThay = new KhachHang();
        public Dialog_ChonKhachHang()
        {
            
            khBLL = new KhachHangBLL();
            InitializeComponent();
        }

        private void Dialog_ChonKhachHang_Load(object sender, EventArgs e)
        {
            loadDanhSachKhachHang();
        }
        public void loadDanhSachKhachHang()
        {
            lvDSKhachHang.Items.Clear();    
            dsKhachHang = khBLL.LayToanBoKhachHang();
            foreach (KhachHang kh in dsKhachHang)
            {
                ListViewItem lvi = new ListViewItem(kh.MaKhachHang + "");
                lvi.SubItems.Add(kh.TenKhachHang.Trim() + "");
                lvi.SubItems.Add(kh.NgaySinh + "");
                lvi.SubItems.Add(kh.SoDienThoai.Trim() + "");
                if (kh.TongChiTieu == 0)
                {
                    lvi.SubItems.Add(0 + "");
                }
                else
                {
                    lvi.SubItems.Add(int.Parse(kh.TongChiTieu + "").ToString("#,###", cul.NumberFormat) + "");
                }
                lvi.SubItems.Add(kh.DiemTichLuy+"");

                lvDSKhachHang.Items.Add(lvi);
            }
        }
        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            lvDSKhachHang.Items.Clear();
            string infor = tbTimKiem.Text;
            foreach (KhachHang kh in dsKhachHang)
            {
                if(kh.TenKhachHang.Contains(infor) || kh.SoDienThoai.Contains(infor))
                {
                    ListViewItem lvi = new ListViewItem(kh.MaKhachHang + "");
                    lvi.SubItems.Add(kh.TenKhachHang.Trim() + "");
                    lvi.SubItems.Add(kh.NgaySinh + "");
                    lvi.SubItems.Add(kh.SoDienThoai.Trim() + "");
                    if(kh.TongChiTieu == 0)
                    {
                        lvi.SubItems.Add(0+"");
                    }
                    else
                    {
                        lvi.SubItems.Add(int.Parse(kh.TongChiTieu + "").ToString("#,###", cul.NumberFormat) + "");
                    }
                    lvi.SubItems.Add(kh.DiemTichLuy + "");

                    lvDSKhachHang.Items.Add(lvi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var row = lvDSKhachHang.FocusedItem.Index;

                int maKH = Int32.Parse(lvDSKhachHang.Items[row].SubItems[0].Text);
                string tenKH = lvDSKhachHang.Items[row].SubItems[1].Text;
                DateTime ngaySinh = DateTime.Parse(lvDSKhachHang.Items[row].SubItems[2].Text);
                string soDienThoai = lvDSKhachHang.Items[row].SubItems[3].Text;
                int tongChiTieu = Int32.Parse(lvDSKhachHang.Items[row].SubItems[4].Text.Replace(".", ""));
                int diemTichLuy = Int32.Parse(lvDSKhachHang.Items[row].SubItems[5].Text);



                KhachHangTimThay.MaKhachHang = maKH;
                KhachHangTimThay.TenKhachHang = tenKH;
                KhachHangTimThay.SoDienThoai = soDienThoai;
                KhachHangTimThay.NgaySinh = ngaySinh;
                KhachHangTimThay.TongChiTieu = tongChiTieu;
                KhachHangTimThay.DiemTichLuy = diemTichLuy;


                QuanLyBanHang.getKhachHang(KhachHangTimThay);


                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn khách hàng !");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbTenKH.Text == "" || tbSDT.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
                return;
            }
            if(!Regex.Match(tbSDT.Text, @"^(0|84)(2(0[3-9]|1[0-6|8|9]|2[0-2|5-9]|3[2-9]|4[0-9]|5[1|2|4-9]|6[0-3|9]|7[0-7]|8[0-9]|9[0-4|6|7|9])|3[2-9]|5[5|6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])([0-9]{7})$").Success)
            {
                MessageBox.Show("Số tài điện thoại không hợp lệ !");
                return;
            }

            KhachHang kh = new KhachHang();
            kh.TenKhachHang = tbTenKH.Text;
            kh.SoDienThoai = tbSDT.Text;
            kh.NgaySinh = dtpNgaySinh.Value;

            if (khBLL.ThemKachHang1(kh))
            {
                MessageBox.Show("Thêm thành công !");
                loadDanhSachKhachHang();
            }
            else
            {
                MessageBox.Show("Thêm Thất bại !");
            }
        }
    }
}
