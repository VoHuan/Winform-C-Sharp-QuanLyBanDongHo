using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace GUI
{

    public partial class DangNhap : Form
    {
        TaiKhoanBLL tkBLL;
        List<TaiKhoan> dstk;
        public DangNhap()
        {
            tkBLL = new TaiKhoanBLL();
            InitializeComponent();
        }

       

        private void DangNhap_Load(object sender, EventArgs e)
        {
            cbxDangNhap.Checked = true;
            tbTenDangNhap.Text = Properties.Settings.Default.user;
            tbMatKhau.Text = Properties.Settings.Default.pass;
            tbMatKhau.UseSystemPasswordChar = true;
            pbEyeClose.Visible = false;
        }

        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.Reset();
            TaiKhoan tk = tkBLL.getTaiKhoan(tbTenDangNhap.Text, tbMatKhau.Text);
            if(tk == null)
            {
                MessageBox.Show("Sai thông tin đăng nhập hoặc tài khoản đã bị khóa");
                return;
            }
            else
            {
                if(cbxDangNhap.Checked == true)
                {
                    Properties.Settings.Default.user = tbTenDangNhap.Text.Trim();
                    Properties.Settings.Default.pass = tk.MatKhau.Trim();
                    Properties.Settings.Default.Save();                  
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
                Properties.Settings1.Default.temp = tk.MaNhanVien.ToString().Trim();               
                Properties.Settings1.Default.Save();

                this.Visible = false;
                Menu m = new Menu();
                m.Show();
                m.hienThiChucNang(tk.MaQuyen.Trim());
                m.quangcao();

              
            }
           



        }



        private void lbQuenMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin hãy liên hệ admin!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tbMatKhau.UseSystemPasswordChar = false;
            pbEyeOpen.Visible = false;
            pbEyeClose.Visible = true;
        }

        private void pbEyeClose_Click(object sender, EventArgs e)
        {
            pbEyeClose.Visible = false;
            pbEyeOpen.Visible = true;
            tbMatKhau.UseSystemPasswordChar = true;
        }
    }
}

