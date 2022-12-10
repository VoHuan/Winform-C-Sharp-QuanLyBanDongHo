using BLL;
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
    public partial class Dialog_ChonKhuyenMai : Form
    {
        List<KhuyenMai> dsKhuyenMai;
        KhuyenMaiBLL kmBLL = new KhuyenMaiBLL();
        DateTime now = DateTime.Today;
        public static KhuyenMai KhuyenMaiTimThay = new KhuyenMai();
        public Dialog_ChonKhuyenMai()
        {
            InitializeComponent();
        }

        private void Dialog_ChonKhuyenMai_Load(object sender, EventArgs e)
        {
            loadDanhSachKhuyenMai();
        }
        public void loadDanhSachKhuyenMai()
        {
            lvDanhSachKhuyenMai.Items.Clear();
            dsKhuyenMai = kmBLL.LayToanBoKhuyenMai();
            
            
            foreach (KhuyenMai km in dsKhuyenMai)
            {
                ListViewItem lvi = new ListViewItem(km.MaKhuyenMai + "");
                lvi.SubItems.Add(km.TenKhuyenMai.Trim() + "");
                lvi.SubItems.Add(km.NgayBatDau + "");
                lvi.SubItems.Add(km.NgayKetThuc + "");
                if(km.NgayBatDau.Date <= now && km.NgayKetThuc.Date >= now)
                {
                    lvi.SubItems.Add("Có Hiệu Lực");
                }
                else
                {
                    lvi.SubItems.Add("Không Hiệu Lực");
                }
               

                lvDanhSachKhuyenMai.Items.Add(lvi);
            }
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string infor = tbTimKiem.Text;
            lvDanhSachKhuyenMai.Items.Clear();
            dsKhuyenMai = kmBLL.LayToanBoKhuyenMai();
            foreach (KhuyenMai km in dsKhuyenMai)
            {
                if (km.TenKhuyenMai.Contains(infor))
                {
                    ListViewItem lvi = new ListViewItem(km.MaKhuyenMai + "");
                    lvi.SubItems.Add(km.TenKhuyenMai.Trim() + "");
                    lvi.SubItems.Add(km.NgayBatDau + "");
                    lvi.SubItems.Add(km.NgayKetThuc + "");
                    if (km.NgayBatDau.Date <= now && km.NgayKetThuc.Date >= now)
                    {
                        lvi.SubItems.Add("Có Hiệu Lực");
                    }
                    else
                    {
                        lvi.SubItems.Add("Không Hiệu Lực");
                    }


                    lvDanhSachKhuyenMai.Items.Add(lvi);
                }
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
           
            try
            {
                var row = lvDanhSachKhuyenMai.FocusedItem.Index;
                if (lvDanhSachKhuyenMai.Items[row].SubItems[4].Text == "Không Hiệu Lực")
                {
                    MessageBox.Show("Khuyến mãi hiện không có hiệu lực ! \n " +
                        "Vui lòng chọn khuyến mãi khác !");
                    return;
                }
                int maKM = Int32.Parse(lvDanhSachKhuyenMai.Items[row].SubItems[0].Text);
                string tenKM = lvDanhSachKhuyenMai.Items[row].SubItems[1].Text;
                DateTime ngayBD = DateTime.Parse(lvDanhSachKhuyenMai.Items[row].SubItems[2].Text);
                DateTime ngayKT = DateTime.Parse(lvDanhSachKhuyenMai.Items[row].SubItems[3].Text);
                
                KhuyenMaiTimThay.MaKhuyenMai = maKM;
                KhuyenMaiTimThay.TenKhuyenMai = tenKM;
                KhuyenMaiTimThay.NgayBatDau = ngayBD;
                KhuyenMaiTimThay.NgayKetThuc = ngayKT;
               
              
                QuanLyBanHang.getKhuyenMai(KhuyenMaiTimThay);


                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn khuyến mãi !");
            }
        }
    }
}
