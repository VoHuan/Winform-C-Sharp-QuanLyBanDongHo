using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DialogPhieuNhap : Form
    {
        public List<SanPham> dssp;
        public PhieuNhap pn;
        public String tenNhanVien;
        public String tongTien;
        public DialogPhieuNhap()
        {
            InitializeComponent();
        }

        private void DialogPhieuNhap_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void hienThi()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.txMPN.Text = ":     " + this.pn.MaPhieuNhap;
            this.txTNV.Text = ":     " + this.tenNhanVien.Trim();
            this.txNL.Text = ":     " + this.pn.NgayNhap;
            this.txTongTien.Text = ":     " + this.tongTien;
            lvSP.Items.Clear();
            foreach (SanPham sp in dssp)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.TenSanPham + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(sp.DonGia + "");
                lvi.SubItems.Add(sp.SoLuong * sp.DonGia + "");
                lvSP.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lvSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
