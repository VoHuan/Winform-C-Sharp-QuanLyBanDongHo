using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Reflection;
using Microsoft.VisualBasic.ApplicationServices;
using System.Resources;
using System.Text.RegularExpressions;
using System.Globalization;

namespace GUI
{
    public partial class QuanLySanPham : Form
    {
        //int s;
        string pathInfor="";
        SanPhamBLL spBLL;
        DanhMucBLL dmBLL;
        List<SanPham> dsSp ;
        List<DanhMuc> dsDanhMuc;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public QuanLySanPham()
        {
            spBLL = new SanPhamBLL();
            dmBLL = new DanhMucBLL();
            InitializeComponent();
        }
        public void loadDanhSachLoaiSP()
        {
            dmBLL.LayToanBoDanhMuc();
            dsDanhMuc = dmBLL.LayToanBoDanhMuc();
            foreach (DanhMuc dm in dsDanhMuc)
            {
                ListViewItem lvi = new ListViewItem(dm.MaDanhMuc + "");                
                lvi.SubItems.Add(dm.TenDanhMuc.Trim() + "");                
                lvLoaiSP.Items.Add(lvi);
            }
        }
        public void hienThiToanBo()
        {
            lvSanPham.Items.Clear();
            spBLL.LayToanBoSanPham();
            dsSp = spBLL.LayToanBoSanPham();
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   
         
            foreach (SanPham sp in dsSp) {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.MaDanhMuc + "");
                if(sp.Phai == 1)
                {
                    lvi.SubItems.Add("Nam");
                }
                else
                {
                    lvi.SubItems.Add("Nữ");
                }
                lvi.SubItems.Add(sp.TenSanPham.Trim() + "");
                lvi.SubItems.Add(int.Parse(sp.DonGia+"").ToString("#,###", cul.NumberFormat) + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(sp.DuongDan.Trim() + "");
                lvSanPham.Items.Add(lvi);
            }
        }
        public void hienThiToanBo(List<SanPham> dsSp)
        {

            foreach (SanPham sp in dsSp)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.MaDanhMuc + "");
                if (sp.Phai == 1)
                {
                    lvi.SubItems.Add("Nam");
                }
                else
                {
                    lvi.SubItems.Add("Nữ");
                }
                lvi.SubItems.Add(sp.TenSanPham.Trim() + "");
                lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(sp.DuongDan.Trim() + "");
                lvSanPham.Items.Add(lvi);
            }
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            cbbTimTheoGia.Visible = false;
            gbGioiTinh.Visible = false;
            hienThiToanBo();
            loadDanhSachLoaiSP();
            loadCBBLoaiSP();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathClone, pathImage;
            if (lvSanPham.SelectedItems.Count > 0)
            {
                txtMaSanPham.Text = lvSanPham.FocusedItem.SubItems[0].Text;
                txtMaDanhMuc.Text = lvSanPham.FocusedItem.SubItems[1].Text;
                txtPhai.Text = lvSanPham.FocusedItem.SubItems[2].Text;
                txtTenSanPham.Text = lvSanPham.FocusedItem.SubItems[3].Text;
                txtDonGia.Text = lvSanPham.FocusedItem.SubItems[4].Text;
                txtSoLuong.Text = lvSanPham.FocusedItem.SubItems[5].Text;
                dsSp = spBLL.LayToanBoSanPham();
                foreach(SanPham sp in dsSp)
                {
                    if (sp.MaSanPham.ToString().Equals(lvSanPham.FocusedItem.SubItems[0].Text))
                    {
                        pathClone = Application.StartupPath.Substring(0,
                                           Application.StartupPath.IndexOf("GUI") + 3) + "\\Resources\\";
                        pathImage = pathClone + sp.DuongDan.ToString();
                        try
                        {   pic.Image = resizeImage(new Bitmap(pathImage.ToString()), new Size(500,500));  

                        } catch (Exception exc) {
                            pic.Image = new Bitmap(pathClone + "eimage.png");
                        }
                    }
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //check input empty
            if(txtMaDanhMuc.Text == ""  || txtTenSanPham.Text == "" ||
                txtDonGia.Text == ""|| txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm cần thêm !");
                return;
            }
            //check input number
            if (kiemTraChuSo(txtMaDanhMuc.Text) == false 
                || kiemTraChuSo(txtDonGia.Text.Replace(".", "")) == false || kiemTraChuSo(txtSoLuong.Text) == false)
            {
                MessageBox.Show("Sai định dạng dữ liệu đầu vào của sản phẩm cần thêm !");
                return;
            }
            bool check1 = false;
           // dsSp = spBLL.LayToanBoSanPham();
           foreach(DanhMuc dm in dsDanhMuc)
                {
                    if (txtMaDanhMuc.Text.Trim() == dm.MaDanhMuc.ToString().Trim())
                    {
                        check1 = true;
                        break; 
                    }
            }
                
            
            if(check1 == false)
            {
                MessageBox.Show("Loại sản phẩm không tồn tại !");
                return;
            }

            SanPham sp = new SanPham();
            sp.MaDanhMuc = int.Parse(txtMaDanhMuc.Text);

            string phai = txtPhai.Text.Trim();
            if(phai == "Nam")
            {
                sp.Phai = 1;
            }
            else
            {
                sp.Phai = 0;
            }
            
            sp.TenSanPham = txtTenSanPham.Text + "";
            if(int.Parse(txtDonGia.Text.Replace(".", "")) < 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0 !");
                return;

            }
            sp.DonGia = int.Parse(txtDonGia.Text.Replace(".",""));           
            sp.SoLuong = int.Parse(txtSoLuong.Text);
            sp.DuongDan = pathInfor;
            if (spBLL.ThemSanPham(sp))
            {
                
                MessageBox.Show("Thêm thành công!");
                emptyTextBox(); //reset textbox
            }
            else
            {
                MessageBox.Show("Đã có lỗi, thêm thất bại!");
            }
            lvSanPham.Items.Clear();
            hienThiToanBo();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //check input empty
            if (txtMaDanhMuc.Text == "" || txtTenSanPham.Text == "" ||
                txtDonGia.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm cần thêm !");
                return;
            }
            //check input number
            if (kiemTraChuSo(txtMaDanhMuc.Text) == false 
                || kiemTraChuSo(txtDonGia.Text.Replace(".", "")) == false || kiemTraChuSo(txtSoLuong.Text) == false)
            {
                MessageBox.Show("Sai định dạng dữ liệu đầu vào của sản phẩm cần thêm !");
                return;
            }
           
            SanPham sp = new SanPham();
            sp.MaSanPham = Convert.ToInt32(txtMaSanPham.Text);
            sp.MaDanhMuc = int.Parse(txtMaDanhMuc.Text);
            string phai = txtPhai.Text.Trim();
            if (phai == "Nam")
            {
                sp.Phai = 1;
            }
            else
            {
                sp.Phai = 0;
            }
            sp.TenSanPham = txtTenSanPham.Text + "";
            sp.DonGia = int.Parse(txtDonGia.Text.Replace(".", ""));
            sp.SoLuong = int.Parse(txtSoLuong.Text);
            sp.DuongDan = pathInfor;
            if (spBLL.SuaSanPham(sp))
            {
               
                MessageBox.Show("Sửa thành công!");
                emptyTextBox();//reset textbox
            } else
            {
                MessageBox.Show("Đã có lỗi, sửa thất bại!");
            }
            lvSanPham.Items.Clear();
            hienThiToanBo();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (spBLL.XoaSanPham(int.Parse(txtMaSanPham.Text)))
            {
                
                MessageBox.Show("Xóa thành công!");
                emptyTextBox();//reset textbox
            }
            else
            {
                MessageBox.Show("Đã có lỗi, xóa thất bại!");
            }
            lvSanPham.Items.Clear();
            hienThiToanBo();
        }

        private void btChonAnh_Click(object sender, System.EventArgs e)
        {
            try
            {
                string pathClone;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var path = openFileDialog1.FileName;
                    pic.Image = new Bitmap(path.ToString());  //load image

                    // get image name
                    string[] temp = path.Split('\\');
                    int l = temp.Length;

                    //copy image into Resources folder
                    pathClone = Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("GUI") + 3) + "\\Resources\\";
                    System.IO.File.Copy(path, pathClone + temp[l - 1], true);

                    pathInfor = temp[l - 1]; //get path image to save database

                }
            }
            catch{
                
            }

            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        public  Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void lvLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLoaiSP.SelectedItems.Count > 0)
            {
                tbMaLoai.Text = lvLoaiSP.FocusedItem.SubItems[0].Text;
                tbTenLoai.Text = lvLoaiSP.FocusedItem.SubItems[1].Text;
            }
        }

        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            if(tbTenLoai.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thêm !");
                return;
            }
            DanhMuc dm = new DanhMuc();
            dm.TenDanhMuc = tbTenLoai.Text;
            
            if (dmBLL.ThemDanhMuc(dm))
            {
                MessageBox.Show("Thêm thành công!");

                //reset textbox
                tbTenLoai.ResetText();
                tbMaLoai.ResetText();
            }
            else
            {
                MessageBox.Show("Đã có lỗi, thêm thất bại!");
            }
            lvLoaiSP.Items.Clear();
            loadDanhSachLoaiSP();
            loadCBBLoaiSP();
        }

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            if (dmBLL.XoaDanhMuc(int.Parse(tbMaLoai.Text)))
            {
                MessageBox.Show("Xóa thành công!");
                //reset textbox
                tbTenLoai.ResetText();
                tbMaLoai.ResetText();
            }
            else
            {
                MessageBox.Show("Đã có lỗi, xóa thất bại!");
            }
            lvLoaiSP.Items.Clear();
            loadDanhSachLoaiSP();
            loadCBBLoaiSP();
        }

        private void btnSuaLoaiSP_Click(object sender, EventArgs e)
        {
            if (tbTenLoai.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần thêm !");
                return;
            }
            DanhMuc dm = new DanhMuc();
            dm.MaDanhMuc = int.Parse(tbMaLoai.Text);           
            dm.TenDanhMuc = tbTenLoai.Text + "";          
            if (dmBLL.SuaDanhMuc(dm))
            {
                MessageBox.Show("Sửa thành công!");
                //reset textbox
                tbTenLoai.ResetText();
                tbMaLoai.ResetText();
            }
            else
            {
                MessageBox.Show("Đã có lỗi, sửa thất bại!");
            }
            lvLoaiSP.Items.Clear();
            loadDanhSachLoaiSP();
            loadCBBLoaiSP();
        }

        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSanPham.Items.Clear();
            if (cbbLoaiSP.SelectedIndex == 0)
            {
                hienThiToanBo();
            }
            else
            {
                string loai = cbbLoaiSP.Text;
                string[] ma = loai.Split("-");

                dsSp = spBLL.LayToanBoSanPhamTheoLoai(int.Parse(ma[0]));
                foreach (SanPham sp in dsSp)
                {
                    ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                    lvi.SubItems.Add(sp.MaDanhMuc + "");
                    if (sp.Phai == 1)
                    {
                        lvi.SubItems.Add("Nam");
                    }
                    else
                    {
                        lvi.SubItems.Add("Nữ");
                    }
                    lvi.SubItems.Add(sp.TenSanPham.Trim() + "");
                    lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                    lvi.SubItems.Add(sp.SoLuong + "");
                    lvi.SubItems.Add(sp.DuongDan.Trim() + "");
                    lvSanPham.Items.Add(lvi);
                }
            }
            
        }
        public void loadCBBLoaiSP()
        {
            foreach (DanhMuc dm in dsDanhMuc)
            {
                cbbLoaiSP.Items.Add(dm.MaDanhMuc + "-" + dm.TenDanhMuc.Trim());
            }
            cbbLoaiSP.SelectedIndex = 0;
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTimKiem.Text = "";
            rbtNam.Checked = false;
            rbtNu.Checked = false;
            if (cbbTimKiem.SelectedIndex == 1)
            {

                tbTimKiem.Visible = false;
                cbbTimTheoGia.Visible = false;
                gbGioiTinh.Visible = true;
            }
            else if(cbbTimKiem.SelectedIndex == 4)
            {
                tbTimKiem.Visible = false;
                gbGioiTinh.Visible = false;
                cbbTimTheoGia.Visible = true;
                cbbTimTheoGia.Text = "Chọn mức giá";
            }
            else
            {
                tbTimKiem.Visible = true;
                cbbTimTheoGia.Visible = false;
                gbGioiTinh.Visible = false;
            }

        }
        public void timKiemTheoMa()
        {
            //check input number
            if (kiemTraChuSo(tbTimKiem.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập chữ số để tìm kiếm !");
                return;
            }

            lvSanPham.Items.Clear();
            dsSp = spBLL.TimKiemTheoMaSP(int.Parse(tbTimKiem.Text.Trim()));
            foreach (SanPham sp in dsSp)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.MaDanhMuc + "");
                if (sp.Phai == 1)
                {
                    lvi.SubItems.Add("Nam");
                }
                else
                {
                    lvi.SubItems.Add("Nữ");
                }
                lvi.SubItems.Add(sp.TenSanPham.Trim() + "");
                lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(sp.DuongDan.Trim() + "");
                lvSanPham.Items.Add(lvi);
            }
        }
        public void timKiemTheoTen()
        {
            lvSanPham.Items.Clear();
            dsSp = spBLL.LayToanBoSanPham();
            foreach (SanPham sp in dsSp)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.MaDanhMuc + "");
                if (sp.Phai == 1)
                {
                    lvi.SubItems.Add("Nam");
                }
                else
                {
                    lvi.SubItems.Add("Nữ");
                }
                lvi.SubItems.Add(sp.TenSanPham.Trim() + "");
                lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(sp.DuongDan.Trim() + "");
                lvSanPham.Items.Add(lvi);
            }
        }
        public void timKiemTheoGia()
        {
            if(cbbTimTheoGia.SelectedIndex > -1)
            {
                lvSanPham.Items.Clear();
                long giaBD, giaKT;
                string gia = cbbTimTheoGia.Text;

                if (gia.Contains("<"))
                {
                    giaBD = 0;
                    giaKT = int.Parse(gia.Replace("<", "").Replace(".", ""));
                }
                else if (gia.Contains(">"))
                {
                    giaBD = int.Parse(gia.Replace(">", "").Replace(".", ""));
                    giaKT = long.MaxValue;
                }
                else
                {
                    string[] temp = gia.Split(" - ");
                    giaBD = int.Parse(temp[0].Replace(".", ""));
                    giaKT = int.Parse(temp[1].Replace(".", ""));
                }

                dsSp = spBLL.LayToanBoSanPham();
                foreach (SanPham sp in dsSp)
                {
                    ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                    lvi.SubItems.Add(sp.MaDanhMuc + "");
                    if (sp.Phai == 1)
                    {
                        lvi.SubItems.Add("Nam");
                    }
                    else
                    {
                        lvi.SubItems.Add("Nữ");
                    }
                    lvi.SubItems.Add(sp.TenSanPham.Trim() + "");
                    lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                    lvi.SubItems.Add(sp.SoLuong + "");
                    lvi.SubItems.Add(sp.DuongDan.Trim() + "");
                    lvSanPham.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mức giá trước khi tìm kiếm !");
            }
            
        }

        public void timKiemTheoSoLuong()
        {
            //check input number
            if (kiemTraChuSo(tbTimKiem.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập chữ số để tìm kiếm !");
                return;
            }

            lvSanPham.Items.Clear();
            dsSp = spBLL.TimKiemTheoSoLuong(int.Parse(tbTimKiem.Text.Trim()));
            foreach (SanPham sp in dsSp)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.MaDanhMuc + "");
                if (sp.Phai == 1)
                {
                    lvi.SubItems.Add("Nam");
                }
                else
                {
                    lvi.SubItems.Add("Nữ");
                }
                lvi.SubItems.Add(sp.TenSanPham.Trim() + "");
                lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(sp.DuongDan.Trim() + "");
                lvSanPham.Items.Add(lvi);
            }
        }

        public void timKiemTheoPhai()
        {
            
            lvSanPham.Items.Clear();
            if(rbtNam.Checked == true)
            {
                dsSp = spBLL.TimKiemTheoPhai(1);
                
            }
            else
            {
                dsSp = spBLL.TimKiemTheoPhai(0);
            }
            
            foreach (SanPham sp in dsSp)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.MaDanhMuc + "");
                if (sp.Phai == 1)
                {
                    lvi.SubItems.Add("Nam");
                }
                else
                {
                    lvi.SubItems.Add("Nữ");
                }
                lvi.SubItems.Add(sp.TenSanPham.Trim() + "");
                lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(sp.DuongDan.Trim() + "");
                lvSanPham.Items.Add(lvi);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            string infor = cbbTimKiem.Text;
            if (infor.Equals("Tất cả"))
            {
                hienThiToanBo();
            }
            if(infor.Equals("Giới Tính"))
            {
                timKiemTheoPhai();
            }
            
            if (infor.Equals("Theo Mã"))
            {
                timKiemTheoMa();
            }
            if (infor.Equals("Theo Tên"))
            {
                timKiemTheoTen();
            }
            if (infor.Equals("Theo Giá"))
            {
               timKiemTheoGia();
            }
            if (infor.Equals("Theo Số Lượng"))
            {
                timKiemTheoSoLuong();
            }
        }
        public  bool kiemTraChuSo(string input)
        {
            int check = 0;
            if (int.TryParse(input, out check) == false)
            {               
                return false;
            }
            return true;
        }
        public void emptyTextBox()
        {
            txtMaSanPham.ResetText();
            txtMaDanhMuc.ResetText();
            txtPhai.ResetText();
            txtTenSanPham.ResetText();
            txtDonGia.ResetText();
            txtSoLuong.ResetText();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Visible = true;
            menu.quangcao();
        }
    }
}
