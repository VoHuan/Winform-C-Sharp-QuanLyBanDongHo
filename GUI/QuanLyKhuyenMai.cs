using BLL;
//using DevExpress.DataProcessing.InMemoryDataProcessor;
//using DevExpress.XtraCharts.Designer.Native;
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
    public partial class QuanLyKhuyenMai : Form
    {

        KhuyenMaiBLL kmBLL = new KhuyenMaiBLL();
        ChiTietKhuyenMaiBLL ctkmBLL = new ChiTietKhuyenMaiBLL();
        List<KhuyenMai> dsKM;
        List<ChiTietKhuyenMai> dsCTKM;
        DateTime tn1;
        DateTime tn2;
        public QuanLyKhuyenMai()
        {
            InitializeComponent();
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "dd-MM-yyyy";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "dd-MM-yyyy";
            tn1 = dtpEnd.Value;
            tn2 = dtpStart.Value;
        }


        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            int daysDiff = ((TimeSpan)(dtpEnd.Value.Date - dtpStart.Value.Date)).Days;
            if (daysDiff <= 0)
            {
                dtpStart.Value = tn1;
                return;
            }
            else
            {
                tn1 = dtpStart.Value;
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            int daysDiff = ((TimeSpan)(dtpEnd.Value.Date - dtpStart.Value.Date)).Days;
            if (daysDiff <= 0)
            {
                dtpEnd.Value = tn2;
                return;
            }
            else
            {
                tn2 = dtpEnd.Value;
            }
        }

        private void btTKM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txTKM.Equals("") != null)
                {
                    KhuyenMai km = new KhuyenMai();
                    km.TenKhuyenMai = txTKM.Text;
                    km.NgayBatDau = dtpStart.Value;
                    km.NgayKetThuc = dtpEnd.Value;
                    if (kmBLL.ThemKhuyenMai(km))
                    {
                        MessageBox.Show("Thêm thành công!");
                        hienThiKhuyenMai();
                        hienThiChiTietKhuyenMai();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mời nhập tên khuyến mãi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSKM_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Int32.Parse(txMKM1.Text);
                if (m == 1)
                {
                    MessageBox.Show("Bạn không thể thao tác với mã này!");
                    return;
                }
                if (txTKM.Equals("") != null)
                {
                    KhuyenMai km = new KhuyenMai();
                    km.MaKhuyenMai = Int32.Parse(txMKM1.Text);
                    km.TenKhuyenMai = txTKM.Text;
                    km.NgayBatDau = dtpStart.Value;
                    km.NgayKetThuc = dtpEnd.Value;
                    if (kmBLL.SuaKhuyenMai(km))
                    {
                        MessageBox.Show("Sửa thành công!");
                        hienThiKhuyenMai();
                        hienThiChiTietKhuyenMai();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mời nhập tên khuyến mãi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXKM_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Int32.Parse(txMKM1.Text);
                if (m == 1)
                {
                    MessageBox.Show("Bạn không thể thao tác với mã này!");
                    return;
                }
                if (txMKM1.Equals("") != null)
                {
                    if (kmBLL.XoaKhuyenMai(Int32.Parse(txMKM1.Text)))
                    {
                        MessageBox.Show("Xóa thành công!");
                        hienThiKhuyenMai();
                        hienThiChiTietKhuyenMai();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mời chọn mã khuyến mãi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            hienThiKhuyenMai();
            hienThiChiTietKhuyenMai();

        }
        public void hienThiKhuyenMai()
        {
            lvKhuyenMai.Items.Clear();
            dsKM = kmBLL.LayToanBoKhuyenMai();
            foreach (KhuyenMai km in dsKM)
            {
                ListViewItem lvi = new ListViewItem(km.MaKhuyenMai + "");
                lvi.SubItems.Add(km.TenKhuyenMai + "");
                if (km.MaKhuyenMai.Equals(1) == true)
                {
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add("");
                }
                else
                {
                    lvi.SubItems.Add(km.NgayBatDau + "");
                    lvi.SubItems.Add(km.NgayKetThuc + "");
                }
                lvKhuyenMai.Items.Add(lvi);
            }
        }
        public void hienThiChiTietKhuyenMai()
        {
            lvCTKM.Items.Clear();
            dsCTKM = ctkmBLL.LayToanBoCTKM();
            foreach (ChiTietKhuyenMai ctkm in dsCTKM)
            {
                ListViewItem lvi = new ListViewItem(ctkm.MaKhuyenMai + "");
                lvi.SubItems.Add(ctkm.MaSanPham + "");
                lvi.SubItems.Add(ctkm.GiaTriGiam + "");
                lvi.SubItems.Add(ctkm.DonViGiam + "");
                lvCTKM.Items.Add(lvi);
            }
        }

        private void lvKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvKhuyenMai.SelectedItems.Count > 0)
                {
                    txMKM1.Text = lvKhuyenMai.FocusedItem.SubItems[0].Text;
                    txTKM.Text = lvKhuyenMai.FocusedItem.SubItems[1].Text;
                    string s1 = lvKhuyenMai.FocusedItem.SubItems[2].Text;
                    string s2 = lvKhuyenMai.FocusedItem.SubItems[3].Text;
                    int m = Int32.Parse(txMKM1.Text);
                    lvCTKM.Items.Clear();
                    foreach (ChiTietKhuyenMai ctkm in dsCTKM)
                    {
                        if (ctkm.MaKhuyenMai == m)
                        {
                            ListViewItem lvi = new ListViewItem(ctkm.MaKhuyenMai + "");
                            lvi.SubItems.Add(ctkm.MaSanPham + "");
                            lvi.SubItems.Add(ctkm.GiaTriGiam + "");
                            lvi.SubItems.Add(ctkm.DonViGiam + "");
                            lvCTKM.Items.Add(lvi);
                        }
                    }
                    if (m == 1)
                    {
                        return;
                    }
                    else
                    {
                        DateTime startTime = DateTime.Parse(s1);
                        DateTime endTime = DateTime.Parse(s2);
                        dtpStart.Value = new DateTime(startTime.Year, startTime.Month, startTime.Day, startTime.Hour, startTime.Minute, startTime.Second);
                        dtpEnd.Value = new DateTime(endTime.Year, endTime.Month, endTime.Day, endTime.Hour, endTime.Minute, endTime.Second);

                    }

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btTCTKM_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietKhuyenMai ctkm = new ChiTietKhuyenMai();
                ctkm.MaKhuyenMai = Int32.Parse(txMKM2.Text);
                ctkm.MaSanPham = Int32.Parse(txMSP.Text);
                ctkm.GiaTriGiam = Int32.Parse(txGTG.Text);
                ctkm.DonViGiam = txDVG.Text.Trim() + "";
                if (ctkmBLL.ThemCTKM(ctkm))
                {
                    MessageBox.Show("Thêm thành công!");
                    hienThiKhuyenMai();
                    hienThiChiTietKhuyenMai();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btSCTKM_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietKhuyenMai ctkm = new ChiTietKhuyenMai();
                ctkm.MaKhuyenMai = Int32.Parse(txMKM2.Text);
                ctkm.MaSanPham = Int32.Parse(txMSP.Text);
                ctkm.GiaTriGiam = Int32.Parse(txGTG.Text);
                ctkm.DonViGiam = txDVG.Text.Trim() + "";
                if (ctkmBLL.SuaCTKM(ctkm))
                {
                    MessageBox.Show("Sửa thành công!");
                    hienThiKhuyenMai();
                    hienThiChiTietKhuyenMai();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXCTKM_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietKhuyenMai ctkm = new ChiTietKhuyenMai();
                ctkm.MaKhuyenMai = Int32.Parse(txMKM2.Text);
                ctkm.MaSanPham = Int32.Parse(txMSP.Text);
                ctkm.GiaTriGiam = Int32.Parse(txGTG.Text);
                ctkm.DonViGiam = txDVG.Text.Trim() + "";
                if (ctkmBLL.XoaCTKM(ctkm))
                {
                    MessageBox.Show("Xóa thành công!");
                    hienThiKhuyenMai();
                    hienThiChiTietKhuyenMai();
                }
                else
                {
                    MessageBox.Show("Xoát thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvCTKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvCTKM.SelectedItems.Count > 0)
                {
                    txMKM2.Text = lvCTKM.FocusedItem.SubItems[0].Text;
                    txMSP.Text = lvCTKM.FocusedItem.SubItems[1].Text;
                    txGTG.Text = lvCTKM.FocusedItem.SubItems[2].Text;
                    txDVG.Text = lvCTKM.FocusedItem.SubItems[3].Text;
                }
            }
            catch (Exception ex)
            {

            }
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
