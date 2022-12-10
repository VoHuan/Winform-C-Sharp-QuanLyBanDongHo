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
using System.Threading;

namespace GUI
{
    public partial class Menu : Form
    {
        TaiKhoanBLL tkBLL;
        NhanVienBLL nhanVienBLL;
        List<TaiKhoan> dstk;

        PhanQuyenBLL pqBLL;
        List<PhanQuyen> dspq;
        NhanVien nvLogin = new NhanVien();
        int checkk = 0;
        public Menu()
        {
            pqBLL = new PhanQuyenBLL();
            tkBLL = new TaiKhoanBLL();
            nhanVienBLL = new NhanVienBLL();
            InitializeComponent();
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
            dstk = tkBLL.layToanBoTaiKhoan();
           
            int maNV_Login = Int32.Parse(Properties.Settings1.Default.temp);                  
            nvLogin = nhanVienBLL.getNhanVien(maNV_Login);
            tbTenNV.Text = nvLogin.MaNhanVien+"-"+nvLogin.TenNhanVien;
                          
        }
        
        public void hienThiChucNang(string maQuyen)
        {
            PhanQuyen phanquyen = pqBLL.getPhanQuyen(maQuyen.Trim());
            

            if (phanquyen.QuanLyBanHang.Trim() == "0")
            {
                flowLayoutPanel1.Controls.Remove(btnBanHang);
                
            }
            if (phanquyen.QuanLyNhapHang.Trim() == "0")
            {
                flowLayoutPanel1.Controls.Remove(btnNhapHang);
            }
            if (phanquyen.QuanLyKhachHang.Trim() == "0")
            {
                flowLayoutPanel1.Controls.Remove(btnKhachHang);
            }
            if (phanquyen.QuanLyNhanVien.Trim() == "0")
            {
                flowLayoutPanel1.Controls.Remove(btnNhanVien);
            }
            if (phanquyen.QuanLySanPham.Trim() == "0")
            {
                flowLayoutPanel1.Controls.Remove(btnSanPham);
            }
            if (phanquyen.XemThongKe.Trim() == "0")
            {
                flowLayoutPanel1.Controls.Remove(btnThongKe);
            }
            if (phanquyen.QuyenPhanQuyen.Trim() == "0")
            {
                flowLayoutPanel1.Controls.Remove(BtnPhanQuyen);
            }
            if (phanquyen.QuanLyKhuyenMai.Trim() == "0")
            {
                flowLayoutPanel1.Controls.Remove(btnKhuyenMai);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();

            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.Close();
            QuanLyPhanQuyen qlkm = new QuanLyPhanQuyen();
            qlkm.ShowDialog();
            //this.Hide();
        }

        private void lbXinChao_Click(object sender, EventArgs e)
        {

        }
        public void quangcao()
        {
           
            Thread thread = new Thread(delegate ()
            {
                // rbtButton1.Checked = true;
                //Do somthing and set your value
                //Thread.Sleep(2000);

                while (true)
                {
                    checkk = 1;
                    if (checkk == 1)
                    {

                        pbQuangCao1.Image = Properties.Resources.quangcao2;

                        Thread.Sleep(6000);


                        checkk = 2;
                    }
                    if (checkk == 2)
                    {
                        pbQuangCao1.Image = Properties.Resources.quangcao1;

                        Thread.Sleep(6000);

                        checkk = 3;
                    }
                    if (checkk == 3)
                    {
                        pbQuangCao1.Image = Properties.Resources.quangcao4;

                        Thread.Sleep(6000);

                        checkk = 4;
                    }
                    if (checkk == 4)
                    {
                        pbQuangCao1.Image = Properties.Resources.quangcao5;

                        Thread.Sleep(6000);

                        checkk = 5;
                    }
                    if (checkk == 5)
                    {
                        pbQuangCao1.Image = Properties.Resources.quangcao6;

                        Thread.Sleep(6000);

                        checkk = 1;
                    }
                }
            });

            thread.Start();

            while (thread.IsAlive)
                Application.DoEvents();
            
         
        }

        private void pbQuangCao1_Click(object sender, EventArgs e)
        {

        }

        private void tbTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            QuanLySanPham qlsp = new QuanLySanPham();
            qlsp.Show();
            this.Hide();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLyBanHang qlbh = new QuanLyBanHang();
            qlbh.ShowDialog();
            //this.Hide();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLyNhapHang qlnh = new QuanLyNhapHang();
            qlnh.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLyKhachHang qlkh = new QuanLyKhachHang();
            qlkh.ShowDialog();
            //this.Hide();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.ShowDialog();
            //this.Hide();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLyKhuyenMai qlkm = new QuanLyKhuyenMai();
            qlkm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
            chart qltk = new chart();
            qltk.ShowDialog();
        }
    }
}
