using System.IO;
using System.IO.Packaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL;
using DTO;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class QuanLyKhachHang : Form
    {
        KhachHangBLL khBLL;
        List<KhachHang> dskh;
        public QuanLyKhachHang()
        {
            khBLL = new KhachHangBLL();
            InitializeComponent();
        }


        private void HienThiToanBoKhachHang()
        {
            listViewKH.Items.Clear();
            dskh = khBLL.LayToanBoKhachHang();
            foreach (var kh in dskh)
            {
                ListViewItem lvi = new ListViewItem(kh.MaKhachHang + "");
                lvi.SubItems.Add(kh.TenKhachHang.Trim() + "");
                lvi.SubItems.Add(kh.NgaySinh.ToShortDateString() + "");
                lvi.SubItems.Add(kh.SoDienThoai.Trim() + "");
                lvi.SubItems.Add(kh.DiemTichLuy + "");
                lvi.SubItems.Add(kh.TongChiTieu + "");
                //lvi.SubItems.Add(kh.TinhTrang + "");//tinhtrang

                listViewKH.Items.Add(lvi);
            }
            listViewKH.Enabled = true;
        }

        private void HienThiToanBoKhachHang(List<KhachHang> dskh)
        {
            listViewKH.Items.Clear();
            foreach (var kh in dskh)
            {
                ListViewItem lvi = new ListViewItem(kh.MaKhachHang + "");
                lvi.SubItems.Add(kh.TenKhachHang.Trim() + "");
                lvi.SubItems.Add(kh.NgaySinh.ToShortDateString() + "");
                lvi.SubItems.Add(kh.SoDienThoai.Trim() + "");
                lvi.SubItems.Add(kh.DiemTichLuy + "");
                lvi.SubItems.Add(kh.TongChiTieu + "");
                //lvi.SubItems.Add(kh.TinhTrang + "");//tinhtrang

                listViewKH.Items.Add(lvi);
            }
            listViewKH.Enabled = true;
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            this.HienThiToanBoKhachHang();
        }

        private void listViewKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMaKhachHang.Text = listViewKH.FocusedItem.SubItems[0].Text;
            tbHoTen.Text = listViewKH.FocusedItem.SubItems[1].Text;
            DateTime date = DateTime.Parse(listViewKH.FocusedItem.SubItems[2].Text);
            dtpNgaySinh.Text = date.ToString("yyyy/MM/dd");
            tbSDT.Text = listViewKH.FocusedItem.SubItems[3].Text;
            tbDiemTichLuy.Text = listViewKH.FocusedItem.SubItems[4].Text;
            tbTongChiTieu.Text = listViewKH.FocusedItem.SubItems[5].Text;
        }

        //---------------------------------Chuc nang---------------------------------

        //Clear textbox cua thong tin khach hang
        private void clearTextBoxNhapThongTin()
        {
            tbMaKhachHang.Text = "";
            tbHoTen.Text = "";
            dtpNgaySinh.Text = "";
            tbSDT.Text = "";
            tbDiemTichLuy.Text = "";
            tbTongChiTieu.Text = "";
        }

        //Hủy chọn chức năng
        private void btHuy_Click(object sender, EventArgs e)
        {
            tbMaKhachHang.Enabled = false;
            tbHoTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            tbSDT.Enabled = false;
            listViewKH.Enabled = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            btHuy.Visible = false;
            clearTextBoxNhapThongTin();
        }

        //Chọn chức năng thêm khách hàng
        private void btThem_Click(object sender, EventArgs e)
        {
            btHuyTimKiem_Click(sender, e);
            tbMaKhachHang.Enabled = false;
            tbHoTen.Enabled = true;
            dtpNgaySinh.Enabled = true;
            tbSDT.Enabled = true;
            btHuy.Visible = true;
            listViewKH.Enabled = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            btnThem.Visible = true;
            clearTextBoxNhapThongTin();
        }

        //Chọn chức năng xóa khách hàng
        private void btXoa_Click(object sender, EventArgs e)
        {
            btHuyTimKiem_Click(sender, e);
            listViewKH.Enabled = true;
            btnXoa.Visible = true;
            btnSua.Visible = false;
            btnThem.Visible = false;
            btHuy.Visible = true;
            tbMaKhachHang.Enabled = false;
            tbHoTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            tbSDT.Enabled = false;
            clearTextBoxNhapThongTin();
        }

        //Chọn chức năng sửa khách hàng
        private void btSua_Click(object sender, EventArgs e)
        {
            btHuyTimKiem_Click(sender, e);
            tbMaKhachHang.Enabled = false;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            tbHoTen.Enabled = true;
            dtpNgaySinh.Enabled = true;
            tbSDT.Enabled = true;
            btHuy.Visible = true;
            listViewKH.Enabled = true;
            btnSua.Visible = true;
            clearTextBoxNhapThongTin();
        }

        //private void tbMaKhachHang_TextChanged(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < listViewKH.Items.Count; i++)
        //    {
        //        if (tbMaKhachHang.Text == listViewKH.Items[i].SubItems[0].Text.ToString())
        //        {
        //            tbHoTen.Text = listViewKH.Items[i].SubItems[1].Text;
        //            dtpNgaySinh.Text = listViewKH.Items[i].SubItems[2].Text;
        //            tbSDT.Text = listViewKH.Items[i].SubItems[3].Text;
        //            tbTongChiTieu.Text = listViewKH.Items[i].SubItems[4].Text;
        //        }
        //    }
        //}

        /*Kiểm tra thông tin khách hàng*/
        private bool KiemTraThongTin()
        {
            int num;
            if (tbHoTen.Text == "" || dtpNgaySinh.Text == "" || tbSDT.Text == "" || !Regex.Match(tbSDT.Text, @"^(0|84)(2(0[3-9]|1[0-6|8|9]|2[0-2|5-9]|3[2-9]|4[0-9]|5[1|2|4-9]|6[0-3|9]|7[0-7]|8[0-9]|9[0-4|6|7|9])|3[2-9]|5[5|6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])([0-9]{7})$").Success
)
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin hoặc thông tin không hợp lệ!");
                return false;
            }
            else return true;
        }

        //Lấy thông tin khách hàng trong text box
        private KhachHang ThongTinKhachHang(KhachHang kh)
        {
            try
            {
                if (tbMaKhachHang.Text != "") kh.MaKhachHang = int.Parse(tbMaKhachHang.Text.ToString());
                kh.TenKhachHang = tbHoTen.Text.ToString();
                kh.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Text.ToString());
                kh.SoDienThoai = tbSDT.Text.ToString();
                //kh.TongChiTieu = Convert.ToInt32(tbTongChiTieu.Text.ToString());
                return kh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //Thêm khách hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                KhachHang kh = new KhachHang();
                kh = ThongTinKhachHang(kh);
                var respond = MessageBox.Show("Xác nhận thêm khách hàng ?", "Thông báo", MessageBoxButtons.YesNo);
                if (respond == DialogResult.Yes)
                {
                    if (khBLL.ThemKhachHang(kh) && kh != null)
                    {
                        MessageBox.Show("Thêm thành công!");
                        HienThiToanBoKhachHang();
                        btHuy_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi. Thêm thất bại!");
                    }
                }
            }
        }

        //Xóa khách hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                KhachHang kh = new KhachHang();
                kh = ThongTinKhachHang(kh);
                var respond = MessageBox.Show("Xác nhận xóa khách hàng ?", "Thông báo", MessageBoxButtons.YesNo);
                if (respond == DialogResult.Yes)
                {
                    if (khBLL.XoaKhachHang(kh) && kh != null)
                    {
                        MessageBox.Show("Xóa thành công!");
                        HienThiToanBoKhachHang();
                        btHuy_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi. Xóa thất bại!");
                    }
                }
            }
        }

        //Sửa khách hàng
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                KhachHang kh = new KhachHang();
                kh = ThongTinKhachHang(kh);
                var respond = MessageBox.Show("Xác nhận sửa khách hàng ?", "Thông báo", MessageBoxButtons.YesNo);
                if (respond == DialogResult.Yes)
                {
                    if (khBLL.SuaKhachHang(kh) && kh != null)
                    {
                        MessageBox.Show("Sửa thành công!");
                        HienThiToanBoKhachHang();
                        btHuy_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi. Sửa thất bại!");
                    }
                }
            }
        }

        //---------------------------------Tim kiem---------------------------------

        /*Disable các chức năng thêm, xóa sửa*/
        private void ClearHideBtnTbNhapThongTin()
        {
            tbMaKhachHang.Enabled = false;
            tbHoTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            tbSDT.Enabled = false;
            listViewKH.Enabled = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            btHuy.Visible = false;
            clearTextBoxNhapThongTin();
        }

        private void rbTongChiTieu_CheckedChanged(object sender, EventArgs e)
        {
            tbTu.Text = "";
            tbDen.Text = "";
            tbsTimKiem.Text = "";
            flpTimKiem.Visible = false;
            flpTimKiemTongChiTieu.Visible = true;
            flpTimKiemTongChiTieu.Enabled = true;

            ClearHideBtnTbNhapThongTin();
            HienThiToanBoKhachHang();
        }

        private void rbMaKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            tbTu.Text = "";
            tbDen.Text = "";
            tbsTimKiem.Text = "";
            flpTimKiem.Visible = true;
            flpTimKiem.Enabled = true;
            flpTimKiemTongChiTieu.Visible = false;
            flpTimKiemTongChiTieu.Enabled = false;

            ClearHideBtnTbNhapThongTin();
            HienThiToanBoKhachHang();
        }

        private void rbTenKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            tbTu.Text = "";
            tbDen.Text = "";
            tbsTimKiem.Text = "";
            flpTimKiem.Visible = true;
            flpTimKiem.Enabled = true;
            flpTimKiemTongChiTieu.Visible = false;
            flpTimKiemTongChiTieu.Enabled = false;

            ClearHideBtnTbNhapThongTin();
            HienThiToanBoKhachHang();
        }

        //private void tbsMaKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {
        //        HienThiToanBoKhachHang();
        //        int count = 0;
        //        for (int i = 0; i < listViewKH.Items.Count; i++)
        //        {
        //            if (tbsTimKiem.Text.ToString() == listViewKH.Items[i].SubItems[0].Text.ToString())
        //            {
        //                count++;
        //                string makh = listViewKH.Items[i].SubItems[0].Text;
        //                string tenkh = listViewKH.Items[i].SubItems[1].Text;
        //                string ngsinh = listViewKH.Items[i].SubItems[2].Text;
        //                string sdt = listViewKH.Items[i].SubItems[3].Text;
        //                string diemtichluy = listViewKH.Items[i].SubItems[4].Text;
        //                string tongchitieu = listViewKH.Items[i].SubItems[5].Text;
        //                string tinhtrang = listViewKH.Items[i].SubItems[6].Text;//tinhtrang

        //                ListViewItem lvi = new ListViewItem();
        //                lvi.SubItems[0].Text = makh.ToString();
        //                lvi.SubItems.Add(tenkh.ToString());
        //                lvi.SubItems.Add(ngsinh.ToString());
        //                lvi.SubItems.Add(sdt.ToString());
        //                lvi.SubItems.Add(diemtichluy.ToString());
        //                lvi.SubItems.Add(tongchitieu.ToString());
        //                lvi.SubItems.Add(tinhtrang.ToString());//tinhtrang

        //                listViewKH.Items.Clear();
        //                listViewKH.Items.Add(lvi);
        //                return;
        //            }
        //        }
        //        if (count == 0 && tbsTimKiem.Text.ToString() != "") { listViewKH.Items.Clear(); }
        //        else HienThiToanBoKhachHang();
        //    }
        //}

        //private void tbsTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {
        //        HienThiToanBoKhachHang();
        //        List<KhachHang> dskh1 = new List<KhachHang>();
        //        for (int i = 0; i < listViewKH.Items.Count; i++)
        //        {
        //            if (listViewKH.Items[i].SubItems[1].Text.ToString().ToLower().Contains(tbsTimKiem.Text.ToString().ToLower()))
        //            {
        //                KhachHang kh = new KhachHang();
        //                kh.MaKhachHang = int.Parse(listViewKH.Items[i].SubItems[0].Text);
        //                kh.TenKhachHang = listViewKH.Items[i].SubItems[1].Text;
        //                kh.NgaySinh = Convert.ToDateTime(listViewKH.Items[i].SubItems[2].Text);
        //                kh.SoDienThoai = listViewKH.Items[i].SubItems[3].Text;
        //                kh.DiemTichLuy = int.Parse(listViewKH.Items[i].SubItems[4].Text);
        //                kh.TongChiTieu = Convert.ToInt32(listViewKH.Items[i].SubItems[5].Text);
        //                kh.TinhTrang = listViewKH.Items[i].SubItems[6].Text;//tinhtrang

        //                dskh1.Add(kh);
        //            }
        //        }
        //        if (tbsTimKiem.Text.ToString() == "") HienThiToanBoKhachHang();
        //        else HienThiToanBoKhachHang(dskh1);
        //    }
        //}


        /*Tìm kiếm mã, tên kh khi nhấn enter*/
        private void tbsTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbMaKhachHang.Checked)
            {
                if (e.KeyChar == (char)13)
                {
                    HienThiToanBoKhachHang();
                    int count = 0;
                    for (int i = 0; i < listViewKH.Items.Count; i++)
                    {
                        if (tbsTimKiem.Text.ToString() == listViewKH.Items[i].SubItems[0].Text.ToString())
                        {
                            count++;
                            string makh = listViewKH.Items[i].SubItems[0].Text;
                            string tenkh = listViewKH.Items[i].SubItems[1].Text;
                            string ngsinh = listViewKH.Items[i].SubItems[2].Text;
                            string sdt = listViewKH.Items[i].SubItems[3].Text;
                            string diemtichluy = listViewKH.Items[i].SubItems[4].Text;
                            string tongchitieu = listViewKH.Items[i].SubItems[5].Text;
                            //string tinhtrang = listViewKH.Items[i].SubItems[6].Text;//tinhtrang

                            ListViewItem lvi = new ListViewItem();
                            lvi.SubItems[0].Text = makh.ToString();
                            lvi.SubItems.Add(tenkh.ToString());
                            lvi.SubItems.Add(ngsinh.ToString());
                            lvi.SubItems.Add(sdt.ToString());
                            lvi.SubItems.Add(diemtichluy.ToString());
                            lvi.SubItems.Add(tongchitieu.ToString());
                            //lvi.SubItems.Add(tinhtrang.ToString());//tinhtrang

                            listViewKH.Items.Clear();
                            listViewKH.Items.Add(lvi);
                            return;
                        }
                    }
                    if (count == 0 && tbsTimKiem.Text.ToString() != "") { listViewKH.Items.Clear(); }
                    else HienThiToanBoKhachHang();
                }
            }
            else if (rbTenKhachHang.Checked)
            {
                if (e.KeyChar == (char)13)
                {
                    HienThiToanBoKhachHang();
                    List<KhachHang> dskh1 = new List<KhachHang>();
                    for (int i = 0; i < listViewKH.Items.Count; i++)
                    {
                        if (listViewKH.Items[i].SubItems[1].Text.ToString().ToLower().Contains(tbsTimKiem.Text.ToString().ToLower()))
                        {
                            KhachHang kh = new KhachHang();
                            kh.MaKhachHang = int.Parse(listViewKH.Items[i].SubItems[0].Text);
                            kh.TenKhachHang = listViewKH.Items[i].SubItems[1].Text;
                            kh.NgaySinh = Convert.ToDateTime(listViewKH.Items[i].SubItems[2].Text);
                            kh.SoDienThoai = listViewKH.Items[i].SubItems[3].Text;
                            kh.DiemTichLuy = int.Parse(listViewKH.Items[i].SubItems[4].Text);
                            kh.TongChiTieu = Convert.ToInt32(listViewKH.Items[i].SubItems[5].Text);
                            //kh.TinhTrang = listViewKH.Items[i].SubItems[6].Text;//tinhtrang

                            dskh1.Add(kh);
                        }
                    }
                    if (tbsTimKiem.Text.ToString() == "") HienThiToanBoKhachHang();
                    else HienThiToanBoKhachHang(dskh1);
                }
            }
        }


        /*Tìm kiếm tổng chi tiêu khi nhấn enter*/
        private void tbTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                HienThiToanBoKhachHang();
                if (tbTu.Text != "" && tbDen.Text != "")
                {
                    try
                    {
                        long ChiTieu1 = Convert.ToInt64(tbTu.Text);
                        long ChiTieu2 = Convert.ToInt64(tbDen.Text);
                        List<KhachHang> dskh1 = new List<KhachHang>();
                        for (int i = 0; i < listViewKH.Items.Count; i++)
                        {
                            int TongChiTieu = int.Parse(listViewKH.Items[i].SubItems[5].Text.ToString());
                            if (ChiTieu1 <= TongChiTieu && ChiTieu2 >= TongChiTieu)
                            {
                                KhachHang kh = new KhachHang();
                                kh.MaKhachHang = int.Parse(listViewKH.Items[i].SubItems[0].Text);
                                kh.TenKhachHang = listViewKH.Items[i].SubItems[1].Text;
                                kh.NgaySinh = Convert.ToDateTime(listViewKH.Items[i].SubItems[2].Text);
                                kh.SoDienThoai = listViewKH.Items[i].SubItems[3].Text;
                                kh.DiemTichLuy = int.Parse(listViewKH.Items[i].SubItems[4].Text);
                                kh.TongChiTieu = Convert.ToInt32(listViewKH.Items[i].SubItems[5].Text);
                                //kh.TinhTrang = listViewKH.Items[i].SubItems[6].Text;//tinhtrang

                                dskh1.Add(kh);
                            }
                        }
                        HienThiToanBoKhachHang(dskh1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nhập đúng định dạng số", "Thông báo");
                    }
                }
            }
        }


        //Tìm kiếm 
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (rbMaKhachHang.Checked)
            {
                HienThiToanBoKhachHang();
                int count = 0;
                for (int i = 0; i < listViewKH.Items.Count; i++)
                {
                    if (tbsTimKiem.Text.ToString() == listViewKH.Items[i].SubItems[0].Text.ToString())
                    {
                        count++;
                        string makh = listViewKH.Items[i].SubItems[0].Text;
                        string tenkh = listViewKH.Items[i].SubItems[1].Text;
                        string ngsinh = listViewKH.Items[i].SubItems[2].Text;
                        string sdt = listViewKH.Items[i].SubItems[3].Text;
                        string diemtichluy = listViewKH.Items[i].SubItems[4].Text;
                        string tongchitieu = listViewKH.Items[i].SubItems[5].Text;
                        //string tinhtrang = listViewKH.Items[i].SubItems[6].Text;//tinhtrang

                        ListViewItem lvi = new ListViewItem();
                        lvi.SubItems[0].Text = makh.ToString();
                        lvi.SubItems.Add(tenkh.ToString());
                        lvi.SubItems.Add(ngsinh.ToString());
                        lvi.SubItems.Add(sdt.ToString());
                        lvi.SubItems.Add(diemtichluy.ToString());
                        lvi.SubItems.Add(tongchitieu.ToString());
                        //lvi.SubItems.Add(tinhtrang.ToString());//tinhtrang

                        listViewKH.Items.Clear();
                        listViewKH.Items.Add(lvi);
                        return;
                    }
                }
                if (count == 0 && tbsTimKiem.Text.ToString() != "") { listViewKH.Items.Clear(); }
                else HienThiToanBoKhachHang();
            }
            else if (rbTenKhachHang.Checked)
            {
                HienThiToanBoKhachHang();
                List<KhachHang> dskh1 = new List<KhachHang>();
                for (int i = 0; i < listViewKH.Items.Count; i++)
                {
                    if (listViewKH.Items[i].SubItems[1].Text.ToString().ToLower().Contains(tbsTimKiem.Text.ToString().ToLower()))
                    {
                        KhachHang kh = new KhachHang();
                        kh.MaKhachHang = int.Parse(listViewKH.Items[i].SubItems[0].Text);
                        kh.TenKhachHang = listViewKH.Items[i].SubItems[1].Text;
                        kh.NgaySinh = Convert.ToDateTime(listViewKH.Items[i].SubItems[2].Text);
                        kh.SoDienThoai = listViewKH.Items[i].SubItems[3].Text;
                        kh.DiemTichLuy = int.Parse(listViewKH.Items[i].SubItems[4].Text);
                        kh.TongChiTieu = Convert.ToInt32(listViewKH.Items[i].SubItems[5].Text);
                        //kh.TinhTrang = listViewKH.Items[i].SubItems[6].Text;//tinhtrang

                        dskh1.Add(kh);
                    }
                }
                if (tbsTimKiem.Text.ToString() == "") HienThiToanBoKhachHang();
                else HienThiToanBoKhachHang(dskh1);
            }
            else if (rbTongChiTieu.Checked)
            {
                HienThiToanBoKhachHang();
                if (tbTu.Text != "" && tbDen.Text != "")
                {
                    try
                    {
                        long ChiTieu1 = Convert.ToInt64(tbTu.Text);
                        long ChiTieu2 = Convert.ToInt64(tbDen.Text);
                        List<KhachHang> dskh1 = new List<KhachHang>();
                        for (int i = 0; i < listViewKH.Items.Count; i++)
                        {
                            int TongChiTieu = int.Parse(listViewKH.Items[i].SubItems[5].Text.ToString());
                            if (ChiTieu1 <= TongChiTieu && ChiTieu2 >= TongChiTieu)
                            {
                                KhachHang kh = new KhachHang();
                                kh.MaKhachHang = int.Parse(listViewKH.Items[i].SubItems[0].Text);
                                kh.TenKhachHang = listViewKH.Items[i].SubItems[1].Text;
                                kh.NgaySinh = Convert.ToDateTime(listViewKH.Items[i].SubItems[2].Text);
                                kh.SoDienThoai = listViewKH.Items[i].SubItems[3].Text;
                                kh.DiemTichLuy = int.Parse(listViewKH.Items[i].SubItems[4].Text);
                                kh.TongChiTieu = Convert.ToInt32(listViewKH.Items[i].SubItems[5].Text);
                                //kh.TinhTrang = listViewKH.Items[i].SubItems[6].Text;//tinhtrang

                                dskh1.Add(kh);
                            }
                        }
                        HienThiToanBoKhachHang(dskh1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nhập đúng định dạng số", "Thông báo");
                    }
                }
            }
        }

        //Hủy tìm kiếm
        private void btHuyTimKiem_Click(object sender, EventArgs e)
        {
            rbMaKhachHang.Checked = false;
            rbTongChiTieu.Checked = false;
            rbTenKhachHang.Checked = false;
            flpTimKiem.Visible = true;
            flpTimKiem.Enabled = false;
            flpTimKiemTongChiTieu.Visible = false;
            flpTimKiemTongChiTieu.Enabled = false;
            listViewKH.Enabled = true;
            tbTu.Text = "";
            tbDen.Text = "";
            tbsTimKiem.Text = "";
            HienThiToanBoKhachHang();
        }

        //private void tbsMaKhachHang_TextChanged(object sender, EventArgs e)
        //{ 
        //    //HienThiToanBoKhachHang();
        //    //int count = 0;
        //    //for (int i = 0; i < listViewKH.Items.Count; i++)
        //    //{
        //    //    if (tbsMaKhachHang.Text.ToString() == listViewKH.Items[i].SubItems[0].Text.ToString())
        //    //    {
        //    //        count++;
        //    //        string makh = listViewKH.Items[i].SubItems[0].Text;
        //    //        string tenkh = listViewKH.Items[i].SubItems[1].Text;
        //    //        string ngsinh = listViewKH.Items[i].SubItems[2].Text;
        //    //        string sdt = listViewKH.Items[i].SubItems[3].Text;
        //    //        string tongchitieu = listViewKH.Items[i].SubItems[4].Text;

        //    //        ListViewItem lvi = new ListViewItem();
        //    //        lvi.SubItems[0].Text = makh.ToString();
        //    //        lvi.SubItems.Add(tenkh.ToString());
        //    //        lvi.SubItems.Add(ngsinh.ToString());
        //    //        lvi.SubItems.Add(sdt.ToString());
        //    //        lvi.SubItems.Add(tongchitieu.ToString());

        //    //        listViewKH.Items.Clear();
        //    //        listViewKH.Items.Add(lvi);
        //    //        return;
        //    //    }
        //    //}
        //    //if (count == 0 && tbsMaKhachHang.Text.ToString() != "") { listViewKH.Items.Clear(); }
        //    //else HienThiToanBoKhachHang();

        //}

        //private void tbsTenKhachHang_TextChanged(object sender, EventArgs e)
        //{
        //    //HienThiToanBoKhachHang();
        //    //List<KhachHang> dskh1 = new List<KhachHang>();
        //    //for (int i = 0; i < listViewKH.Items.Count; i++)
        //    //{
        //    //    if (listViewKH.Items[i].SubItems[1].Text.ToString().ToLower().Contains(tbsTenKhachHang.Text.ToString().ToLower()))
        //    //    {
        //    //        KhachHang kh = new KhachHang();
        //    //        kh.MaKhachHang = int.Parse(listViewKH.Items[i].SubItems[0].Text);
        //    //        kh.TenKhachHang = listViewKH.Items[i].SubItems[1].Text;
        //    //        kh.NgaySinh = Convert.ToDateTime(listViewKH.Items[i].SubItems[2].Text);
        //    //        kh.SoDienThoai = listViewKH.Items[i].SubItems[3].Text;
        //    //        kh.TongChiTieu = Convert.ToInt32(listViewKH.Items[i].SubItems[4].Text);

        //    //        dskh1.Add(kh);
        //    //    }
        //    //}
        //    //if (tbsTenKhachHang.Text.ToString() == "") HienThiToanBoKhachHang();
        //    //else HienThiToanBoKhachHang(dskh1);
        //}

        //private void tbTu_TextChanged(object sender, EventArgs e)
        //{
        //    //HienThiToanBoKhachHang();
        //    //if (tbTu.Text != "" && tbDen.Text != "")
        //    //{
        //    //    int ChiTieu1 = Convert.ToInt32(tbTu.Text);
        //    //    int ChiTieu2 = Convert.ToInt32(tbDen.Text);
        //    //    List<KhachHang> dskh1 = new List<KhachHang>();
        //    //    for (int i = 0; i < listViewKH.Items.Count; i++)
        //    //    {
        //    //        int TongChiTieu = int.Parse(listViewKH.Items[i].SubItems[4].Text.ToString());
        //    //        if (ChiTieu1 <= TongChiTieu && ChiTieu2 >= TongChiTieu)
        //    //        {
        //    //            KhachHang kh = new KhachHang();
        //    //            kh.MaKhachHang = int.Parse(listViewKH.Items[i].SubItems[0].Text);
        //    //            kh.TenKhachHang = listViewKH.Items[i].SubItems[1].Text;
        //    //            kh.NgaySinh = Convert.ToDateTime(listViewKH.Items[i].SubItems[2].Text);
        //    //            kh.SoDienThoai = listViewKH.Items[i].SubItems[3].Text;
        //    //            kh.TongChiTieu = Convert.ToInt32(listViewKH.Items[i].SubItems[4].Text);

        //    //            dskh1.Add(kh);
        //    //        }
        //    //    }
        //    //    HienThiToanBoKhachHang(dskh1);
        //    //}
        //}


        /*---------------------------------Excel---------------------------------*/

        /*Phương thức xuất file excel*/
        private void ExportExcel(string path)
        {
            try
            {
                int number = listViewKH.Items.Count;

                Microsoft.Office.Interop.Excel.Application excel;
                Workbook worKbooK;
                Worksheet worKsheeT;

                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DisplayAlerts = false;

                worKbooK = excel.Workbooks.Add(Type.Missing);
                worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                worKsheeT.Name = "DANH SÁCH KHÁCH HÀNG";
                worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[1, 5]].Merge();
                Microsoft.Office.Interop.Excel.Range range = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[1, 6]];
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                range.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                worKsheeT.Cells[1, 1] = "DANH SÁCH KHÁCH HÀNG";
                worKsheeT.Cells[2, 1] = "Mã khách hàng";
                worKsheeT.Cells[2, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                worKsheeT.Cells[2, 2] = "Tên khách hàng";
                worKsheeT.Cells[2, 2].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                worKsheeT.Cells[2, 3] = "Ngày sinh";
                worKsheeT.Cells[2, 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                worKsheeT.Cells[2, 4] = "Số điện thoại";
                worKsheeT.Cells[2, 4].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                worKsheeT.Cells[2, 5] = "Điểm tích lũy";
                worKsheeT.Cells[2, 5].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                worKsheeT.Cells[2, 6] = "Tổng chi tiêu";
                worKsheeT.Cells[2, 6].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                //worKsheeT.Cells[2, 7] = "Tình trạng";//tinhtrang
                worKsheeT.Cells.Font.Size = 15;
                worKsheeT.Columns.ColumnWidth = 35;


                int i = 3;
                foreach (ListViewItem item in listViewKH.Items)
                {
                    worKsheeT.Cells[i, 1] = item.SubItems[0].Text.ToString();
                    worKsheeT.Cells[i, 2] = item.SubItems[1].Text.ToString();
                    DateTime ngaySinh = Convert.ToDateTime(item.SubItems[2].Text.ToString());
                    worKsheeT.Cells[i, 3] = ngaySinh.ToShortDateString();
                    worKsheeT.Cells[i, 4] = item.SubItems[3].Text.ToString();
                    worKsheeT.Cells[i, 5] = item.SubItems[4].Text.ToString();
                    worKsheeT.Cells[i, 6] = item.SubItems[5].Text.ToString();
                    //worKsheeT.Cells[i, 7] = item.SubItems[6].Text.ToString();//tinhtrang
                    i++;
                }
                excel.ActiveWorkbook.SaveCopyAs(path);
                excel.ActiveWorkbook.Saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xuất file");
            }
        }

        //Xuất excel
        private void btXuatEx_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)| *.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show(saveFileDialog1.FileName);
                    ExportExcel(saveFileDialog1.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Xuất file thất bại");
                }
            }
        }


        //Phương thức nhập file excel
        private void ImportExcel(string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                for (int i = excelWorksheet.Dimension.Start.Row + 2; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    ListViewItem lvi = new ListViewItem(excelWorksheet.Cells[i, excelWorksheet.Dimension.Start.Column].Value.ToString());
                    for (int j = excelWorksheet.Dimension.Start.Column +1 ; j <= excelWorksheet.Dimension.End.Column; j++)
                    {                                             
                        lvi.SubItems.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    listViewKH.Items.Add(lvi);
                }
            }
        }

        //Nhập excel
        private void btNhapEx_Click(object sender, EventArgs e)
        {
            
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Export Excel";
            openFileDialog1.Filter = "Excel (*.xlsx)| *.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listViewKH.Items.Clear();
                    ImportExcel(openFileDialog1.FileName);
                   // MessageBox.Show("Nhập file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file thất bại");
                }
           }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Visible = true;
            menu.quangcao();
        }
    }
}