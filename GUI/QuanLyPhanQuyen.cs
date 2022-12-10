using BLL;
using DTO;
//using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;


namespace GUI
{
    public partial class QuanLyPhanQuyen : Form
    {
        PhanQuyenBLL phanQuyenBLL;
        NhanVienBLL nvBLL;
        TaiKhoanBLL tkBLL;
        List<PhanQuyen> dspq = new List<PhanQuyen>();
        List<NhanVien> dsnv = new List<NhanVien>();
        List<TaiKhoan> dstk = new List<TaiKhoan>();
        public QuanLyPhanQuyen()
        {
            phanQuyenBLL = new PhanQuyenBLL();
            nvBLL = new NhanVienBLL();
            tkBLL = new TaiKhoanBLL();
            InitializeComponent();
        }

        private void QuanLyPhanQuyen_Load(object sender, EventArgs e)
        {
            loadCBBLoaiQuyen();
            loadCBBMaQuyen();
            hienThiDanhSachNhanvien();
        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(30, 10, 372, 30);
            textBox.SetBounds(20, 36, 372, 30);
            buttonOk.SetBounds(228, 72, 75, 33);
            buttonCancel.SetBounds(309, 72, 75, 33);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cbbLoaiQuyen.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn quyền cần sửa !");
                return;
            }
            else
            {
                PhanQuyen pq = new PhanQuyen();
                pq.MaQuyen = cbbLoaiQuyen.Text.Trim();
                if (cbQLPhanQuyen.Checked)
                    pq.QuyenPhanQuyen = "1";
                else
                    pq.QuyenPhanQuyen = "0";

                if (cbQLBanHang.Checked)
                    pq.QuanLyBanHang = "1";
                else
                    pq.QuanLyBanHang ="0";

                if(cbQLNhanVien.Checked)
                    pq.QuanLyNhanVien = "1";
                else
                    pq.QuanLyNhanVien="0";

                if (cbQLKhachHang.Checked)
                    pq.QuanLyKhachHang = "1";
                else
                    pq.QuanLyKhachHang="0";

                if (cbQLNhapHang.Checked)
                    pq.QuanLyNhapHang = "1";
                else
                    pq.QuanLyNhapHang = "0";

                if(cbQLSanPham.Checked)
                    pq.QuanLySanPham ="1";
                else
                    pq.QuanLySanPham ="0";

                if(cbQLThongKe.Checked)
                    pq.XemThongKe = "1";
                else
                    pq.XemThongKe = "0";

                if(cbQLKhuyenMai.Checked)
                    pq.QuanLyKhuyenMai = "1";
                else
                    pq.QuanLyKhuyenMai ="0";

                if (phanQuyenBLL.suaQuyen(pq))
                {
                    MessageBox.Show("Sửa thành công !");
                    loadCBBLoaiQuyen();
                }
                else
                    MessageBox.Show("Sửa thất bại !");

            }
        }

        private void cbbLoaiQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset();
            foreach (PhanQuyen pq in dspq)
            {
                if (pq.MaQuyen.Trim() == cbbLoaiQuyen.Text)
                {

                    
                    cbQLBanHang.Checked = ( pq.QuanLyBanHang.Trim() == "1") ? true : false;
                    cbQLSanPham.Checked = (pq.QuanLySanPham.Trim() == "1") ? true : false;
                    cbQLNhapHang.Checked = (pq.QuanLyNhapHang.Trim() == "1") ? true : false;
                    cbQLNhanVien.Checked = (pq.QuanLyNhanVien.Trim() == "1") ? true : false;
                    cbQLKhachHang.Checked = (pq.QuanLyKhachHang.Trim() == "1") ? true : false;
                    cbQLKhuyenMai.Checked = (pq.QuanLyKhuyenMai.Trim() == "1") ? true : false;
                    cbQLPhanQuyen.Checked = (pq.QuyenPhanQuyen.Trim() == "1") ? true : false;
                    cbQLThongKe.Checked = (pq.XemThongKe.Trim() == "1") ? true : false;


                    break;
                    
                }
            }
        }
        
        public void reset()
        {
            cbQLSanPham.Checked = false;
            cbQLBanHang.Checked = false;
            cbQLNhapHang.Checked = false;
            cbQLNhanVien.Checked = false;
            cbQLKhachHang.Checked = false;
            cbQLKhuyenMai.Checked = false;
            cbQLThongKe.Checked = false;
            cbQLPhanQuyen.Checked = false;
        }
        public void loadCBBLoaiQuyen()
        {
            cbbLoaiQuyen.Items.Clear();
            dspq = phanQuyenBLL.LayToanBoPhanQuyen();
            foreach (PhanQuyen pq in dspq)
            {
                cbbLoaiQuyen.Items.Add(pq.MaQuyen.Trim());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Thêm Quyền", "Nhập Tên Quyền Cần Thêm:", ref value) == DialogResult.OK)
            {
                if (phanQuyenBLL.themQuyen(value.Trim()) == true)
                {
                    MessageBox.Show("Bạn đã thêm quyền thành công ! \n Hãy hiệu chỉnh quyền vừa thêm !");
                    loadCBBLoaiQuyen();
                }
                else
                    MessageBox.Show("Thêm thất bại !" );
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(cbbLoaiQuyen.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn quyền muốn xóa !");
                return;
            }
            else
            {
                string maquyen = cbbLoaiQuyen.Text.Trim();
                if(phanQuyenBLL.xoaQuyen(maquyen) == true)
                {
                    MessageBox.Show("Xóa quyền thành công !");
                    loadCBBLoaiQuyen();
                    cbbLoaiQuyen.Text = "Chọn quyền";
                    reset();
                }
                else
                    MessageBox.Show("Xóa quyền thất bại !");
            }
        }




        /// <summary>                        Quản Lý Tài Khoản
        /// ///////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public void hienThiDanhSachNhanvien()
        {
            lvDSNV.Items.Clear();
            dsnv = nvBLL.layToanBoNhanVien();
            dstk = tkBLL.layToanBoTaiKhoan();

            foreach(NhanVien nv in dsnv)
            {
                bool check = false;
                ListViewItem lvi = new ListViewItem(nv.MaNhanVien + "");
                lvi.SubItems.Add(nv.TenNhanVien.Trim() + "");              
                lvi.SubItems.Add(nv.NgaySinh.ToShortDateString() + "");               
                lvi.SubItems.Add(nv.SoDienThoai.Trim() + "");
                lvi.SubItems.Add(nv.ChucVu.Trim() + "");
                foreach (TaiKhoan  tk in dstk)
                {                 
                    if (nv.MaNhanVien == tk.MaNhanVien && tk.TinhTrang.Trim() =="1")
                    {
                        
                        lvi.SubItems.Add("Hiệu lực");
                        check = true;
                        break;
                    }
                    
                }
               if(check == false)
                    lvi.SubItems.Add("Không Hiệu lực");




                lvDSNV.Items.Add(lvi);
            }
        }
        public void loadCBBMaQuyen()
        {
            cbbMaQuyen.Items.Clear();
            
            foreach (PhanQuyen pq in dspq)
            {
                cbbMaQuyen.Items.Add(pq.MaQuyen.Trim());
            }
        }

        private void lvDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count > 0)
            {
                tbMaNV.Text = lvDSNV.SelectedItems[0].Text;
                TaiKhoan tk = getTaiKhoan(Int32.Parse(lvDSNV.SelectedItems[0].Text));
                if(tk == null)
                {
                    tbMatKhau.Enabled = true;
                    tbTenDangNhap.Enabled = true;
                    cbbMaQuyen.Enabled = true;

                    tbMatKhau.Text = "";
                    tbTenDangNhap.Text = "";
                    cbbMaQuyen.Text = "";

                }
                
                else 
                {
                    if (tk.TinhTrang.Trim() == "0")
                    {


                        tbMatKhau.Text = tk.MatKhau;
                        tbTenDangNhap.Text = tk.TenDangNhap;
                        cbbMaQuyen.Text = tk.MaQuyen;


                        tbMatKhau.Enabled = false;
                        tbTenDangNhap.Enabled = false;
                        cbbMaQuyen.Enabled = false;
                    }
                    else
                    {
                        tbMatKhau.Text = tk.MatKhau;
                        tbTenDangNhap.Text = tk.TenDangNhap;
                        cbbMaQuyen.Text = tk.MaQuyen;

                        tbMatKhau.Enabled = true;
                        tbTenDangNhap.Enabled = false;
                        cbbMaQuyen.Enabled = true;
                    }

                    
                }

            }

        }
        public TaiKhoan getTaiKhoan(int ma)
        {
            return tkBLL.getTaiKhoan1(ma);
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if(tbMatKhau.Text == "" || tbTenDangNhap.Text == "" || cbbMaQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản ! ");
                return;
            }
            foreach(TaiKhoan taiKhoan in dstk)
            {
                if(tbTenDangNhap.Text.Trim() == taiKhoan.TenDangNhap.Trim())
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, hãy chọn tên khác ! ");
                    return;
                }
            }

            TaiKhoan tk = new TaiKhoan();
            tk.TenDangNhap = tbTenDangNhap.Text;
            tk.MatKhau = tbMatKhau.Text;
            tk.MaQuyen = cbbMaQuyen.Text;
            tk.MaNhanVien = Int32.Parse(tbMaNV.Text);

            if (tkBLL.ThemTaiKhoan(tk))
                MessageBox.Show("Tài khoản đã được tạo thành công ! ");
            else
                MessageBox.Show("Thêm tài khoản thất bại ! ");

            hienThiDanhSachNhanvien();
            reset1();


        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (tbMatKhau.Text == "" || tbTenDangNhap.Text == "" || cbbMaQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản ! ");
                return;
            }
            
            TaiKhoan tk = new TaiKhoan();
            tk.TenDangNhap = tbTenDangNhap.Text;
            tk.MatKhau = tbMatKhau.Text;
            tk.MaQuyen = cbbMaQuyen.Text;
            tk.MaNhanVien = Int32.Parse(tbMaNV.Text);

            if (tkBLL.SuaTaiKhoan(tk))
                MessageBox.Show("Tài khoản đã được cập nhật thành công ! ");
            else
                MessageBox.Show("Cập nhật tài khoản thất bại ! ");

            hienThiDanhSachNhanvien();
            reset1();
        }

        private void btnKhoaTK_Click(object sender, EventArgs e)
        {
            if (tbMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên ! ");
                return;
            }
            if (tbMatKhau.Enabled == true && tbMatKhau.Text == "")
            {
                MessageBox.Show("Nhân viên này chưa có tài khoản ! ");
                return;
            }
            int maNV = Int32.Parse(tbMaNV.Text);
            if (tkBLL.khoaTaiKhoan(maNV))
                MessageBox.Show("Đã khóa tài khoản "+ tbTenDangNhap.Text+" ! ");
            else
                MessageBox.Show("Khóa tài khoản thất bại ! ");

            tbMatKhau.Enabled = false;
            tbTenDangNhap.Enabled = false;
            cbbMaQuyen.Enabled = false;
            hienThiDanhSachNhanvien();
        }


        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            if (tbMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên ! ");
                return;
            }
            if (tbMatKhau.Enabled == true)
            {
                MessageBox.Show("Tài khoản hiện tại không bị khóa ! ");
                return;
            }

            int maNV = Int32.Parse(tbMaNV.Text);
            if (tkBLL.moKhoaTaiKhoan(maNV))
                MessageBox.Show("Tài khoản "+ tbTenDangNhap.Text+" đã được mở khóa thành công ! ");
            else
                MessageBox.Show("Mở khóa tài khoản thất bại ! ");

            tbMatKhau.Enabled = true;
            tbTenDangNhap.Enabled = true;
            cbbMaQuyen.Enabled = true;
            hienThiDanhSachNhanvien();
        }
        public void reset1()
        {
            tbMatKhau.Text = "";
            tbTenDangNhap.Text = "";
            cbbMaQuyen.Text = "";
            tbMaNV.Text = "";
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Visible = true;
            menu.quangcao();
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
