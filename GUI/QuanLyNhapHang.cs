using BLL;
//using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.XPath;

namespace GUI
{
    public partial class QuanLyNhapHang : Form
    {
        int check = 0;
        DialogNhaCungCap a;

        SanPhamBLL spBLL = new SanPhamBLL();
        PhieuNhapBLL pnBLL = new PhieuNhapBLL();
        CTPNBLL ctpnBLL = new CTPNBLL();

        List<PhieuNhap> dspn;
        List<SanPham> dsSp;
        List<SanPham> dsSanPhamNhap = new List<SanPham>();
        List<PhieuNhap> dsPN;
        List<CTPN> dsCTPN;
        public QuanLyNhapHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyNhapHang_Load(object sender, EventArgs e)
        {
            hienThiToanBo();
        }
        public void hienThiToanBo()
        {
            lvSanPham.Items.Clear();
            dsSp = spBLL.LayToanBoSanPham();
            foreach (SanPham sp in dsSp)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.TenSanPham + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvSanPham.Items.Add(lvi);
            }

            lvCTPN.Items.Clear();
            ctpnBLL.LayToanBoCTPN();
            dsCTPN = ctpnBLL.LayToanBoCTPN();
            foreach (CTPN ctpn in dsCTPN)
            {
                ListViewItem lvi = new ListViewItem(ctpn.MaPhieuNhap + "");
                lvi.SubItems.Add(ctpn.MaSanPham + "");
                lvi.SubItems.Add(ctpn.SoLuong + "");
                lvi.SubItems.Add(ctpn.DonGia + "");
                lvi.SubItems.Add(ctpn.ThanhTien + "");
                lvCTPN.Items.Add(lvi);
            }


            lvPhieuNhap.Items.Clear();
            pnBLL.LayToanBoPhieuNhap();
            dsPN = pnBLL.LayToanBoPhieuNhap();
            foreach (PhieuNhap pn in dsPN)
            {
                ListViewItem lvi = new ListViewItem(pn.MaPhieuNhap + "");
                lvi.SubItems.Add(pn.MaNhaCungCap + "");
                lvi.SubItems.Add(pn.MaNhanVien + "");
                lvi.SubItems.Add(pn.NgayNhap + "");
                lvi.SubItems.Add(pn.TongTien + "");
                lvPhieuNhap.Items.Add(lvi);
            }

        }
        public void hienThiDanhSachSanPhamNhap()
        {
            int tongTien = 0;
            lvHangCho.Items.Clear();
            foreach (SanPham sp in dsSanPhamNhap)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.TenSanPham + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(sp.DonGia + "");
                lvi.SubItems.Add((sp.SoLuong * sp.DonGia) + "");
                tongTien += sp.SoLuong * sp.DonGia;
                lvHangCho.Items.Add(lvi);
            }
            txTongTien.Text = tongTien + "";
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                txMaSanPham.Text = lvSanPham.FocusedItem.SubItems[0].Text;
                txTenSanPham.Text = lvSanPham.FocusedItem.SubItems[1].Text;
                dsSp = spBLL.LayToanBoSanPham();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = new DialogNhaCungCap();
            a.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txMaSanPham.Text.Equals(""))
            {
                MessageBox.Show("Mời chọn sản phẩm!");
                return;
            }
            else if (txDonGia.Text.Equals(""))
            {
                MessageBox.Show("Mời nhập đơn giá!");
                return;
            }
            try
            {
                SanPham sp = new SanPham();
                check = 0;
                sp.MaSanPham = Convert.ToInt32(txMaSanPham.Text); ;
                sp.TenSanPham = txTenSanPham.Text;
                sp.SoLuong = Convert.ToInt32(txSoLuong.Value.ToString());
                sp.DonGia = Convert.ToInt32(txDonGia.Text);
                foreach (SanPham spNH in dsSanPhamNhap)
                {
                    if (sp.MaSanPham == spNH.MaSanPham)
                    {
                        spNH.SoLuong += sp.SoLuong;
                        spNH.DonGia = sp.DonGia;
                        check = 1;
                    }
                }
                if (check == 0)
                {
                    dsSanPhamNhap.Add(sp);
                }
                hienThiDanhSachSanPhamNhap();
            }
            catch (Exception ecx)
            {
                MessageBox.Show(ecx.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<SanPham> dsXoa = new List<SanPham>();
            if (lvHangCho.SelectedItems.Count > 0)
            {
                foreach (SanPham spNH in dsSanPhamNhap)
                {
                    if (lvHangCho.SelectedItems.Count > 0)
                    {
                        if (spNH.MaSanPham.ToString() == lvHangCho.FocusedItem.SubItems[0].Text)
                        {
                            dsXoa.Add(spNH);
                        }
                    }
                }
                foreach (SanPham spXoa in dsXoa)
                {
                    dsSanPhamNhap.Remove(spXoa);
                }
            }
            try
            {
                Console.WriteLine(lvHangCho.FocusedItem.SubItems[0].Text);
            }
            catch (Exception excc)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
            }
            hienThiDanhSachSanPhamNhap();
        }

        private void lvHangCho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txNhaCungCap_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Kiểm tra đầu vào
            if (txNhaCungCap.Text.Equals(""))
            {
                MessageBox.Show("Mời chọn nhà cung cấp!");
                return;
            }
            else if (dsSanPhamNhap.Count == 0)
            {
                MessageBox.Show("Mời thêm sản phẩm nhập!");
                return;
            }
            List<CTPN> dsCTPN = new List<CTPN>();
            PhieuNhap pn = new PhieuNhap();
            String[] s = txNhaCungCap.Text.Split('-');
            String[] s1 = txNhanVien.Text.Split('-');
            pn.MaNhaCungCap = Int32.Parse(s[0]);
            pn.MaNhanVien = Int32.Parse(s1[0]);
            pn.NgayNhap = System.DateTime.Now;
            pn.TongTien = Int32.Parse(txTongTien.Text);
            pnBLL.ThemPhieuNhap(pn); // Thêm phiếu nhập
            int m = pnBLL.MaCuoiCung(); // Lấy mã cuối cùng
            foreach (SanPham sp in dsSanPhamNhap)
            {
                CTPN ctpn = new CTPN();
                ctpn.MaPhieuNhap = m;
                ctpn.MaSanPham = sp.MaSanPham;
                ctpn.DonGia = sp.DonGia;
                ctpn.SoLuong = sp.SoLuong;
                ctpn.ThanhTien = sp.SoLuong * sp.DonGia;
                dsCTPN.Add(ctpn);
            }
            ctpnBLL.themChiTietPhieuNhap(dsCTPN); //Thêm chi tiết phiếu nhập
                                                  // Tạo danh sách sản phẩm cập nhật
            List<SanPham> dsTemp = new List<SanPham>();
            foreach (SanPham sp1 in dsSp)
            {
                foreach (SanPham sp2 in dsSanPhamNhap)
                {
                    if (sp1.MaSanPham == sp2.MaSanPham)
                    {
                        SanPham sp = new SanPham();
                        sp = sp1;
                        sp.SoLuong = sp1.SoLuong + sp2.SoLuong;
                        dsTemp.Add(sp1);
                    }
                }
            }
            if (spBLL.CapNhatSoLuong(dsTemp)) // Cập nhật lại số lượng
            {
                hienThiToanBo();
                DialogPhieuNhap a = new DialogPhieuNhap();
                a.tenNhanVien = txNhanVien.Text;
                pn.MaPhieuNhap = m;
                a.pn = pn;
                a.dssp = dsSanPhamNhap;
                a.tongTien = txTongTien.Text;
                a.hienThi();
                a.ShowDialog();
                MessageBox.Show("Thêm thành công phiếu nhập số " + m + " vào cơ sở dữ liệu!");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
        }

        private void btTimSP_Click(object sender, EventArgs e)
        {
            if (txTimKiem.Text.Equals(""))
            {
                MessageBox.Show("Mời nhập từ khóa tìm kiếm!");
                return;
            }

            lvSanPham.Items.Clear();
            spBLL.LayToanBoSanPham();
            dsSp = spBLL.LayToanBoSanPham();
            int i = 0;
            foreach (SanPham sp in dsSp)
            {
                if (sp.MaSanPham.ToString().ToLower().Contains(txTimKiem.Text.ToLower())
                    || sp.TenSanPham.ToString().ToLower().Contains(txTimKiem.Text.ToLower())
                    || sp.SoLuong.ToString().ToLower().Contains(txTimKiem.Text.ToLower())
                   )
                {
                    i++;
                    ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                    lvi.SubItems.Add(sp.TenSanPham + "");
                    lvi.SubItems.Add(sp.SoLuong + "");
                    lvSanPham.Items.Add(lvi);
                }
            }
            MessageBox.Show("Tìm được " + i + " sản phẩm");

        }

        private void QuanLyNhapHang_Load_1(object sender, EventArgs e)
        {

        }

        private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            lvSanPham.Items.Clear();
            spBLL.LayToanBoSanPham();
            dsSp = spBLL.LayToanBoSanPham();
            if (txTimKiem.Text.Equals(""))
            {
                hienThiToanBo();
                return;
            }
            foreach (SanPham sp in dsSp)
            {
                if (sp.MaSanPham.ToString().ToLower().Contains(txTimKiem.Text.ToLower())
                    || sp.TenSanPham.ToString().ToLower().Contains(txTimKiem.Text.ToLower())
                    || sp.SoLuong.ToString().ToLower().Contains(txTimKiem.Text.ToLower())
                   )
                {
                    ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                    lvi.SubItems.Add(sp.TenSanPham + "");
                    lvi.SubItems.Add(sp.SoLuong + "");
                    lvSanPham.Items.Add(lvi);
                }
            }
        }

        private void xoaHet_Click(object sender, EventArgs e)
        {
            dsSanPhamNhap.Clear();
            lvHangCho.Items.Clear();
        }

        private void lvPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPhieuNhap.SelectedItems.Count > 0)
            {
                List<CTPN> dsTemp = new List<CTPN>();
                int ma = Int32.Parse(lvPhieuNhap.FocusedItem.SubItems[0].Text);
                foreach (CTPN ctpn in dsCTPN)
                {
                    if (ma == ctpn.MaPhieuNhap)
                    {
                        dsTemp.Add(ctpn);
                    }
                }
                lvCTPN.Items.Clear();
                foreach (CTPN ctpn in dsTemp)
                {
                    ListViewItem lvi = new ListViewItem(ctpn.MaPhieuNhap + "");
                    lvi.SubItems.Add(ctpn.MaSanPham + "");
                    lvi.SubItems.Add(ctpn.SoLuong + "");
                    lvi.SubItems.Add(ctpn.DonGia + "");
                    lvi.SubItems.Add(ctpn.ThanhTien + "");
                    lvCTPN.Items.Add(lvi);
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void txTPN_TextChanged(object sender, EventArgs e)
        {
            lvPhieuNhap.Items.Clear();
            pnBLL.LayToanBoPhieuNhap();
            dsPN = pnBLL.LayToanBoPhieuNhap();
            if (txTPN.Text.Equals(""))
            {
                hienThiToanBo();
                return;
            }
            foreach (PhieuNhap pn in dsPN)
            {
                if (pn.MaPhieuNhap.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.MaNhanVien.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.MaNhaCungCap.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.TongTien.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.NgayNhap.ToString().ToLower().Contains(txTPN.Text.ToLower())
                   )
                {
                    ListViewItem lvi = new ListViewItem(pn.MaPhieuNhap + "");
                    lvi.SubItems.Add(pn.MaNhaCungCap + "");
                    lvi.SubItems.Add(pn.MaNhanVien + "");
                    lvi.SubItems.Add(pn.NgayNhap + "");
                    lvi.SubItems.Add(pn.TongTien + "");
                    lvPhieuNhap.Items.Add(lvi);
                }
            }
        }

        private void txTimPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lvPhieuNhap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvPhieuNhap.SelectedItems.Count > 0)
            {
                txMPNPN.Text = lvPhieuNhap.FocusedItem.SubItems[0].Text;
                txMNCCPN.Text = lvPhieuNhap.FocusedItem.SubItems[1].Text;
                txMNVPN.Text = lvPhieuNhap.FocusedItem.SubItems[2].Text;
                txNLPN.Text = lvPhieuNhap.FocusedItem.SubItems[3].Text;
                txTTPN.Text = lvPhieuNhap.FocusedItem.SubItems[4].Text;
            }
            lvCTPN.Items.Clear();
            foreach (CTPN ctpn in dsCTPN)
            {
                if (Int32.Parse(txMPNPN.Text) == ctpn.MaPhieuNhap)
                {
                    ListViewItem lvi = new ListViewItem(ctpn.MaPhieuNhap + "");
                    lvi.SubItems.Add(ctpn.MaSanPham + "");
                    lvi.SubItems.Add(ctpn.SoLuong + "");
                    lvi.SubItems.Add(ctpn.DonGia + "");
                    lvi.SubItems.Add(ctpn.ThanhTien + "");
                    lvCTPN.Items.Add(lvi);
                }
            }
        }

        private void lvCTPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCTPN.SelectedItems.Count > 0)
            {
                txMPNCTPN.Text = lvCTPN.FocusedItem.SubItems[0].Text;
                txMSPCTPN.Text = lvCTPN.FocusedItem.SubItems[1].Text;
                txSLCTPN.Text = lvCTPN.FocusedItem.SubItems[2].Text;
                txDGCTPN.Text = lvCTPN.FocusedItem.SubItems[3].Text;
                txTTCTPN.Text = lvCTPN.FocusedItem.SubItems[4].Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hienThiToanBo();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (txTPN.Text.Equals(""))
            {
                MessageBox.Show("Mời nhập từ khóa tìm kiếm!");
                return;
            }
            int i = 0;
            lvPhieuNhap.Items.Clear();
            pnBLL.LayToanBoPhieuNhap();
            dsPN = pnBLL.LayToanBoPhieuNhap();
            if (txTPN.Text.Equals(""))
            {
                hienThiToanBo();
                return;
            }
            foreach (PhieuNhap pn in dsPN)
            {
                if (pn.MaPhieuNhap.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.MaNhanVien.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.MaNhaCungCap.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.TongTien.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.NgayNhap.ToString().ToLower().Contains(txTPN.Text.ToLower())
                   )
                {
                    ListViewItem lvi = new ListViewItem(pn.MaPhieuNhap + "");
                    lvi.SubItems.Add(pn.MaNhaCungCap + "");
                    lvi.SubItems.Add(pn.MaNhanVien + "");
                    lvi.SubItems.Add(pn.NgayNhap + "");
                    lvi.SubItems.Add(pn.TongTien + "");
                    lvPhieuNhap.Items.Add(lvi);
                    i++;
                }
            }
            MessageBox.Show("Tìm thấy " + i + " phiếu nhập!");
        }

        private void txTPN_TextChanged_1(object sender, EventArgs e)
        {
            lvPhieuNhap.Items.Clear();
            pnBLL.LayToanBoPhieuNhap();
            dsPN = pnBLL.LayToanBoPhieuNhap();
            if (txTPN.Text.Equals(""))
            {
                hienThiToanBo();
                return;
            }
            foreach (PhieuNhap pn in dsPN)
            {
                if (pn.MaPhieuNhap.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.MaNhanVien.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.MaNhaCungCap.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.TongTien.ToString().ToLower().Contains(txTPN.Text.ToLower())
                    || pn.NgayNhap.ToString().ToLower().Contains(txTPN.Text.ToLower())
                   )
                {
                    ListViewItem lvi = new ListViewItem(pn.MaPhieuNhap + "");
                    lvi.SubItems.Add(pn.MaNhaCungCap + "");
                    lvi.SubItems.Add(pn.MaNhanVien + "");
                    lvi.SubItems.Add(pn.NgayNhap + "");
                    lvi.SubItems.Add(pn.TongTien + "");
                    lvPhieuNhap.Items.Add(lvi);
                }
            }
        }

        private void txDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int m = Int32.Parse(txDonGia.Text);
                if (m < 0)
                {
                    MessageBox.Show("Đơn giá không thể âm!");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Visible = true;
            menu.quangcao();
        }
    }
}
