using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DialogNhaCungCap : Form
    {
        public NhaCungCap ncc = new NhaCungCap();
        List<NhaCungCap> dsNCC = new List<NhaCungCap>();
        NhaCungCapBLL nccBLL = new NhaCungCapBLL();
        public DialogNhaCungCap()
        {
            InitializeComponent();
        }

        private void hienThiToanBo()
        {
            dsNCC = nccBLL.LayNhaCungCap();
            foreach (NhaCungCap ncc in dsNCC)
            {
                ListViewItem lvi = new ListViewItem(ncc.MaNhaCungCap + "");
                lvi.SubItems.Add(ncc.TenNhaCungCap + "");
                lvi.SubItems.Add(ncc.SoDienThoai + "");
                lvi.SubItems.Add(ncc.DiaChi + "");
                lvNhaCungCap.Items.Add(lvi);
            }
        }

        private void DialogNhaCungCap_Load(object sender, EventArgs e)
        {
            hienThiToanBo();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txMaNhaCungCap.Text == "" || txDiaChi.Text == "" || Regex.Match(txSoDienThoai.Text, @"^(0|84)(2(0[3-9]|1[0-6|8|9]|2[0-2|5-9]|3[2-9]|4[0-9]|5[1|2|4-9]|6[0-3|9]|7[0-7]|8[0-9]|9[0-4|6|7|9])|3[2-9]|5[5|6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])([0-9]{7})$").Success)
            {
                MessageBox.Show("Mời điền đúng thông tin");
                return;
            }
            NhaCungCap obj = new NhaCungCap();
            obj.TenNhaCungCap = txTenNhaCungCap.Text;
            obj.DiaChi = txDiaChi.Text;
            obj.SoDienThoai = txSoDienThoai.Text;
            try
            {
                if (nccBLL.themNhaCungCap(obj))
                {
                    lvNhaCungCap.Items.Clear();
                    hienThiToanBo();
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (Exception them)
            {
                MessageBox.Show("Thêm thất bại!");
                MessageBox.Show(them.ToString());
            }
        }

        private void lvNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhaCungCap.SelectedItems.Count > 0)
            {
                txMaNhaCungCap.Text = lvNhaCungCap.FocusedItem.SubItems[0].Text;
                txTenNhaCungCap.Text = lvNhaCungCap.FocusedItem.SubItems[1].Text;
                txSoDienThoai.Text = lvNhaCungCap.FocusedItem.SubItems[2].Text;
                txDiaChi.Text = lvNhaCungCap.FocusedItem.SubItems[3].Text;

                this.ncc.MaNhaCungCap = Int32.Parse(txMaNhaCungCap.Text);
                this.ncc.TenNhaCungCap = txTenNhaCungCap.Text;
                this.ncc.SoDienThoai = txSoDienThoai.Text;
                this.ncc.DiaChi = txDiaChi.Text;
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txMaNhaCungCap.Text == "" || txDiaChi.Text == "" || Regex.Match(txSoDienThoai.Text, @"^(0|84)(2(0[3-9]|1[0-6|8|9]|2[0-2|5-9]|3[2-9]|4[0-9]|5[1|2|4-9]|6[0-3|9]|7[0-7]|8[0-9]|9[0-4|6|7|9])|3[2-9]|5[5|6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])([0-9]{7})$").Success)
            {
                MessageBox.Show("Mời điền đúng thông tin");
                return;
            }
            NhaCungCap obj = new NhaCungCap();
            obj.MaNhaCungCap = Int32.Parse(txMaNhaCungCap.Text);
            obj.TenNhaCungCap = txTenNhaCungCap.Text;
            obj.DiaChi = txDiaChi.Text;
            obj.SoDienThoai = txSoDienThoai.Text;
            try
            {
                if (nccBLL.suaNhaCungCap(obj))
                {
                    lvNhaCungCap.Items.Clear();
                    hienThiToanBo();
                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception them)
            {
                MessageBox.Show("Sửa thất bại!");
                MessageBox.Show(them.ToString());
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txMaNhaCungCap.Text == "")
            {
                MessageBox.Show("Chưa chọn nhà cung cấp");
                return;
            }
            NhaCungCap obj = new NhaCungCap();
            obj.MaNhaCungCap = Int32.Parse(txMaNhaCungCap.Text);
            obj.TenNhaCungCap = txTenNhaCungCap.Text;
            obj.DiaChi = txDiaChi.Text;
            obj.SoDienThoai = txSoDienThoai.Text;
            try
            {
                if (nccBLL.xoaNhaCungCap(obj.MaNhaCungCap))
                {
                    lvNhaCungCap.Items.Clear();
                    hienThiToanBo();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (Exception them)
            {
                MessageBox.Show("Xóa thất bại!");
                MessageBox.Show(them.ToString());
            }
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            if (lvNhaCungCap.SelectedItems.Count == 0)
            {
                MessageBox.Show("Mời chọn nhà cung cấp!");
            }
            else
            {
                this.Hide();
            }
            QuanLyNhapHang.txNhaCungCap.Text = ncc.MaNhaCungCap + "-" + ncc.TenNhaCungCap;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (txTuKhoa.Text.Equals(""))
            {
                MessageBox.Show("Mời nhập từ khóa tìm kiếm!");
                return;
            }
            lvNhaCungCap.Items.Clear();
            nccBLL.LayNhaCungCap();
            dsNCC = nccBLL.LayNhaCungCap();
            int i = 0;
            foreach (NhaCungCap ncc in dsNCC)
            {
                if (ncc.MaNhaCungCap.ToString().ToLower().Contains(txTuKhoa.Text.ToLower())
                    || ncc.TenNhaCungCap.ToString().ToLower().Contains(txTuKhoa.Text.ToLower())
                    || ncc.DiaChi.ToString().ToLower().Contains(txTuKhoa.Text.ToLower())
                    || ncc.SoDienThoai.ToString().ToLower().Contains(txTuKhoa.Text.ToLower())
                   )
                {
                    i++;
                    ListViewItem lvi = new ListViewItem(ncc.MaNhaCungCap + "");
                    lvi.SubItems.Add(ncc.TenNhaCungCap + "");
                    lvi.SubItems.Add(ncc.DiaChi + "");
                    lvi.SubItems.Add(ncc.SoDienThoai + "");
                    lvNhaCungCap.Items.Add(lvi);
                }
            }
            MessageBox.Show("Tìm được " + i + " nhà cung cấp");
        }

        private void txTuKhoa_TextChanged(object sender, EventArgs e)
        {
            lvNhaCungCap.Items.Clear();
            nccBLL.LayNhaCungCap();
            dsNCC = nccBLL.LayNhaCungCap();
            if (txTuKhoa.Text.Equals(""))
            {
                hienThiToanBo();
                return;
            }
            foreach (NhaCungCap ncc in dsNCC)
            {
                if (ncc.MaNhaCungCap.ToString().ToLower().Contains(txTuKhoa.Text.ToLower())
                    || ncc.TenNhaCungCap.ToString().ToLower().Contains(txTuKhoa.Text.ToLower())
                    || ncc.DiaChi.ToString().ToLower().Contains(txTuKhoa.Text.ToLower())
                    || ncc.SoDienThoai.ToString().ToLower().Contains(txTuKhoa.Text.ToLower())
                   )
                {
                    ListViewItem lvi = new ListViewItem(ncc.MaNhaCungCap + "");
                    lvi.SubItems.Add(ncc.TenNhaCungCap + "");
                    lvi.SubItems.Add(ncc.DiaChi + "");
                    lvi.SubItems.Add(ncc.SoDienThoai + "");
                    lvNhaCungCap.Items.Add(lvi);
                }
            }
        }
    }
}
