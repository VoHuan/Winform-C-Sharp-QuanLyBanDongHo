using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Resources;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Collections;
using static System.Formats.Asn1.AsnWriter;

namespace GUI
{
    public partial class QuanLyBanHang : Form
    {
        SanPhamBLL spBLL = new SanPhamBLL();
        DanhMucBLL dmBLL = new DanhMucBLL();
        KhachHangBLL khBLL = new KhachHangBLL();
        HoaDonBLL hdBLL = new HoaDonBLL();
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        ChiTietHoaDonBLL cthdBLL = new ChiTietHoaDonBLL();
        ChiTietKhuyenMaiBLL ctkmBLL = new ChiTietKhuyenMaiBLL();
        

        List<SanPham> dsSp;
        List<SanPham> dsGioHang = new List<SanPham>();
        List<DanhMuc> dsDanhMuc;
        List<HoaDon> dsHoaDon ;
        List<ChiTietHoaDon> dsChiTietHoaDon ;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

        //public static string ma,ten,sdt;
        public int diemTichLuyDaSuDung =0;
        public int tongTienKhuyenMai = 0;
        public int diemTichLuyCongThem = 0;
        public  static DateTime ngaysinh;
        
        public QuanLyBanHang()
        {
            KhachHang KhachHangTimThay = new KhachHang();
            InitializeComponent();
        }

        ///                           Quản Lý Sản Phẩm
        /// /////////////////////////////////////////////////////////////////
        /// 
       public void hienThiToanBoSP()
        {
            spBLL.LayToanBoSanPham();
            dsSp = spBLL.LayToanBoSanPham();
            foreach(SanPham sp in dsSp) {
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.TenSanPham.Trim() + "");
                lvi.SubItems.Add(sp.MaDanhMuc + "");
                lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(sp.DuongDan.Trim() + "");
                if (sp.Phai == 1)
                {
                    lvi.SubItems.Add("Nam");
                }
                else
                {
                    lvi.SubItems.Add("Nữ");
                }

                lvDssp.Items.Add(lvi);
            }
        }
       
       

        private void lvDssp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathClone, pathImage;
            if (lvDssp.SelectedItems.Count > 0)
            {
                tbMaSP.Text = lvDssp.FocusedItem.SubItems[0].Text;
                tbTenSP.Text = lvDssp.FocusedItem.SubItems[1].Text;
                tbDonGia.Text = lvDssp.FocusedItem.SubItems[3].Text;
                string path = lvDssp.FocusedItem.SubItems[5].Text;
                numSoLuong.Value = 1;

                dsSp = spBLL.LayToanBoSanPham();
                foreach (SanPham sp in dsSp)
                {
                    if (sp.MaSanPham.ToString().Equals(lvDssp.FocusedItem.SubItems[0].Text))
                    {
                        pathClone = Application.StartupPath.Substring(0,
                                           Application.StartupPath.IndexOf("GUI") + 3) + "\\Resources\\";
                        pathImage = pathClone + path.ToString();
                        try
                        {
                            pbHinhSP.Image = resizeImage(new Bitmap(pathImage.ToString()), new Size(400, 300));

                        }
                        catch (Exception exc)
                        {
                            pbHinhSP.Image = new Bitmap(pathClone + "eimage.png");
                        }
                    }
                }
            }
        }

        private void tpBanHang_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyBanHang_Load_1(object sender, EventArgs e)
        {
            int maNV_Login = Int32.Parse(Properties.Settings1.Default.temp);
            NhanVien nvLogin = nhanVienBLL.getNhanVien(maNV_Login);
            tbNhanVien.Text = nvLogin.MaNhanVien + "-" + nvLogin.TenNhanVien;

            cbTichDiem.Enabled = false;
            dtpBatDau.Visible = false;
            dtpKetThuc.Visible = false;
            hienThiToanBoSP();
            loadCBBLoaiSP();

            LayToanBoHoaDon();
            LayToanBoCTHD();
        }
        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void lvDssp_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }
        public void loadCBBLoaiSP()
        {
            dsDanhMuc = dmBLL.LayToanBoDanhMuc();
            foreach (DanhMuc dm in dsDanhMuc)
            {
                cbbLoaiSP.Items.Add(dm.MaDanhMuc + "-" + dm.TenDanhMuc.Trim());
            }
            cbbLoaiSP.SelectedIndex = 0;
        }

        private void tbKetThuc_TextChanged(object sender, EventArgs e)
        {
            if (tbBatDau.Text == "" || kiemTraChuSo(tbBatDau.Text) == false)
            {
                return;
            }
            string num = tbKetThuc.Text;
            num = num.Replace(".", "");           
            string temp = long.Parse(num).ToString("#,###", cul.NumberFormat);
            tbKetThuc.Text = temp;
            tbKetThuc.SelectionStart = temp.Length + 1;
        }

        private void tbBatDau_TextChanged(object sender, EventArgs e)
        {
            if (tbBatDau.Text == "" ||kiemTraChuSo(tbBatDau.Text) == false)
            {               
                return;
            }
            
            string num = tbBatDau.Text;
            num = num.Replace(".", "");
            string temp = long.Parse(num).ToString("#,###", cul.NumberFormat);
            tbBatDau.Text = temp;
            tbBatDau.SelectionStart = temp.Length + 1;
        }

        public bool kiemTraChuSo(string input)
        {
            int check = 0;
            if (int.TryParse(input, out check) == false)
            {
                return false;
            }
            return true;
        }

        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDssp.Items.Clear();
            if (cbbLoaiSP.SelectedIndex == 0)
            {
                hienThiToanBoSP();
            }
            else
            {
                string loai = cbbLoaiSP.Text;
                string[] ma = loai.Split("-");

                dsSp = spBLL.LayToanBoSanPhamTheoLoai(int.Parse(ma[0]));
                foreach (SanPham sp in dsSp)
                {
                    ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                    lvi.SubItems.Add(sp.TenSanPham + "");
                    lvi.SubItems.Add(sp.MaDanhMuc + "");
                    lvi.SubItems.Add(sp.DonGia + "");
                    lvi.SubItems.Add(sp.SoLuong + "");
                    lvi.SubItems.Add(sp.DuongDan + "");
                    if (sp.Phai == 1)
                    {
                        lvi.SubItems.Add("Nam");
                    }
                    else
                    {
                        lvi.SubItems.Add("Nữ");
                    }
                    lvDssp.Items.Add(lvi);
                }
            }
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            if (kiemTraChuSo(tbBatDau.Text) == false || kiemTraChuSo(tbBatDau.Text) == false)
            {
                MessageBox.Show("Nhập định dạng tìm kiếm !");
                return;
            }
            lvDssp.Items.Clear();
            long giaBD, giaKT;
            if (tbBatDau.Text == "" )
            {
                giaBD = 0;
            }
            else
            {
                giaBD = long.Parse(tbBatDau.Text.Replace(".", ""));
            }
            if(tbKetThuc.Text == "" )
            {
                giaKT = long.MaxValue;
            }
            else
            {
                giaKT = long.Parse(tbKetThuc.Text.Replace(".", ""));
            }

           

            foreach (SanPham sp in dsSp)
            {
                if(sp.DonGia >= giaBD && sp.DonGia <= giaKT)
                {
                    ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                    lvi.SubItems.Add(sp.TenSanPham + "");
                    lvi.SubItems.Add(sp.MaDanhMuc + "");
                    lvi.SubItems.Add(sp.DonGia + "");
                    lvi.SubItems.Add(sp.SoLuong + "");
                    lvi.SubItems.Add(sp.DuongDan + "");
                    if (sp.Phai == 1)
                    {
                        lvi.SubItems.Add("Nam");
                    }
                    else
                    {
                        lvi.SubItems.Add("Nữ");
                    }
                    lvDssp.Items.Add(lvi);
                }
                
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {   
            if(tbMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi thêm !");
                return;
            }

            lvGioHang.Items.Clear();     
            SanPham sanpham = new SanPham();
            sanpham.MaSanPham = Int32.Parse(tbMaSP.Text);
            sanpham.TenSanPham = tbTenSP.Text;
            sanpham.DonGia = Int32.Parse(tbDonGia.Text.Replace(".",""));
            sanpham.SoLuong = Int32.Parse(numSoLuong.Value.ToString());
           

                if (dsGioHang.ToArray().Length == 0) // kiểm tra trong giỏ hàng có sp nào chưa?
            {
                dsGioHang.Add(sanpham); //chưa có thì thêm mới vao giỏ
            }
            else
            {
                bool check = false;
                for(int i = 0;i<dsGioHang.Count;i++)
                {
                    if(sanpham.MaSanPham == dsGioHang.ElementAt(i).MaSanPham)    // kiểm tra trong giỏ hàng đã có sp này chưa
                    {
                        int soluongmoi = sanpham.SoLuong + dsGioHang.ElementAt(i).SoLuong;  // có thì tăng số lượng lên                       
                        sanpham.SoLuong = soluongmoi;
                        dsGioHang.Remove(dsGioHang.ElementAt(i));
                        dsGioHang.Insert(i,sanpham);
                        check = true;
                        break;
                    }
                }

                if(check == false)  // sản phẩm chưa có trong giỏ hàng
                    dsGioHang.Add(sanpham); // thêm mới vào giỏ
            }

            //load danh sách trong giỏ lên listview
            foreach (SanPham sp in dsGioHang)
            {              
                ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                lvi.SubItems.Add(sp.TenSanPham + "");                            
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                long thanhtien = sp.DonGia * sp.SoLuong;
                lvi.SubItems.Add(long.Parse(thanhtien + "").ToString("#,###", cul.NumberFormat) + "");
                lvGioHang.Items.Add(lvi);               
            }

            //số lượng sản phẩm hiện có trong giỏ
            int sl = dsGioHang.Count;
            tbSoLuongGioHang.Text = sl + "";

            tinhTongTienKhuyenMai();
            tinhTongTien();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /*int row = lvGioHang.FocusedItem.Index;
            lvGioHang.Items.RemoveAt(row);    */

            try
            {
                
                if(dsGioHang.Count == 0)
                {
                    MessageBox.Show("Giỏ hàng trống !");
                    return;
                }
                int row = lvGioHang.FocusedItem.Index;
                int id = Int32.Parse(lvGioHang.Items[row].SubItems[0].Text);

                for (int i = 0; i < dsGioHang.Count; i++)
                {
                    if (dsGioHang[i].MaSanPham == id)
                    {
                        dsGioHang.Remove(dsGioHang[i]);
                    }
                }
                lvGioHang.Items.Clear();

                foreach (SanPham sp in dsGioHang)
                {
                    ListViewItem lvi = new ListViewItem(sp.MaSanPham + "");
                    lvi.SubItems.Add(sp.TenSanPham + "");
                    lvi.SubItems.Add(sp.SoLuong + "");
                    lvi.SubItems.Add(int.Parse(sp.DonGia + "").ToString("#,###", cul.NumberFormat) + "");
                    long thanhtien = sp.DonGia * sp.SoLuong;
                    lvi.SubItems.Add(long.Parse(thanhtien + "").ToString("#,###", cul.NumberFormat) + "");
                    lvGioHang.Items.Add(lvi);
                }

                //số lượng sản phẩm hiện có trong giỏ
                int sl = dsGioHang.Count;
                tbSoLuongGioHang.Text = sl + "";

                tinhTongTienKhuyenMai();
                tinhTongTien();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa !");
            }


        }
        public void tinhTongTienKhuyenMai()
        {
            tongTienKhuyenMai = 0;

            // tính tổng tiền các sản phẩm trong giỏ hàng
            int tongTien = 0;
            for (int i = 0; i < dsGioHang.Count; i++)
            {
                tongTien += dsGioHang[i].DonGia * dsGioHang[i].SoLuong;
            }



            // tính tiền khuyến mãi nếu áp mã khuyến mãi 
            if (tbKhuyenMai.Text != "")
            {
                //lấy danh sách các sản phẩm đc khuyến mãi theo khuyến mãi đã chọn
                string[] maKM = tbKhuyenMai.Text.Split("-");
                List<ChiTietKhuyenMai> dsCTKM = new List<ChiTietKhuyenMai>();
                dsCTKM = ctkmBLL.LayToanBoCTKM(Int32.Parse(maKM[0]));

                //tinh tổng tiền khuyến mãi
                
                for (int i = 0; i < dsGioHang.Count; i++)
                {
                    for (int j = 0; j < dsCTKM.Count; j++)
                    {                
                        if (dsGioHang[i].MaSanPham == dsCTKM[j].MaSanPham)
                        {
                            if (dsCTKM[j].DonViGiam.Trim() == "%")
                            {
                          
                                int tienGiam = tongTien * dsCTKM[j].GiaTriGiam / 100 ;
                                tongTienKhuyenMai = tongTienKhuyenMai + tienGiam;                              
                                break;
                            }
                            else
                            {
                               
                                int tienGiam = dsCTKM[j].GiaTriGiam;
                                tongTienKhuyenMai = tongTienKhuyenMai + tienGiam;                       
                                break;
                            }
                            
                        }
                    }
                }

               
            }
            // tính tổng khuyến mãi với tích điểm
            if (cbTichDiem.Checked == true)
            {
                if (tbMaKh.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng !");
                    cbTichDiem.Checked = false;
                }
                else
                {
                    tongTien = tongTien - tongTienKhuyenMai;  //tong tiền sau khi trừ đi khuyến mãi của chương trình khuyến mãi

                    List<KhachHang> list = new List<KhachHang>();
                    list = khBLL.getKhachHang(Int32.Parse(tbMaKh.Text));

                    KhachHang khachHang = new KhachHang();
                    khachHang = list[0];

                    int diemTichLuy = khachHang.DiemTichLuy;
                    if (diemTichLuy >= 1000)
                    {
                                              
                        int tiengiam = tongTien * 50 / 100;   // sử dụng tối đa chỉ 1000 điểm tích lũy  =>> giảm tối đa 50%
                        tongTienKhuyenMai += tiengiam;

                        diemTichLuyDaSuDung = 1000;

                    }
                    else if(diemTichLuy >= 100)
                    {
                        int tiengiam = tongTien * (diemTichLuy / 100) * 5 / 100;   // 100 điểm giảm 5%
                        tongTienKhuyenMai += tiengiam;

                        diemTichLuyDaSuDung = diemTichLuy;
                    }
                    else
                    {
                        MessageBox.Show("Bạn ko đủ điểm để sử dụng !");
                    }
                }


            }


            // hiển thị tổng khuyến mãi lên textbox
            if (tongTienKhuyenMai > 0)
            {
                tbTongGiam.Text = long.Parse(tongTienKhuyenMai + "").ToString("#,###", cul.NumberFormat) + "  VNĐ";
            }
            else
            {
                tbTongGiam.Text = tongTienKhuyenMai + "  VNĐ";
            }

        }
        public void tinhTongTien()
        {
            long total = 0;
            if (tbTongGiam.Text == "")
            {
                
                for (int i = 0; i < dsGioHang.Count; i++)
                {
                    total += dsGioHang[i].DonGia * dsGioHang[i].SoLuong;

                }
                if (total == 0)
                {
                    tbTongTien.Text = 0 + "  VNĐ";
                    cbTichDiem.Checked = false;
                    cbTichDiem.Enabled = false;
                }
                else
                {
                    tbTongTien.Text = long.Parse((total - tongTienKhuyenMai) + "").ToString("#,###", cul.NumberFormat) + " VNĐ";
                    cbTichDiem.Enabled = true;
                }
            }
            
            else
            {
                for (int i = 0; i < dsGioHang.Count; i++)
                {
                    total += dsGioHang[i].DonGia * dsGioHang[i].SoLuong;

                }

                if (total == 0)
                {
                    tbTongTien.Text = 0 + "  VNĐ";
                    cbTichDiem.Checked = false;
                    cbTichDiem.Enabled = false;
                }
                else
                {
                    tbTongTien.Text = long.Parse((total - tongTienKhuyenMai) + "").ToString("#,###", cul.NumberFormat) + " VNĐ";
                    cbTichDiem.Enabled = true;
                }               
            }                              
        }
        public void themKhachHang()
        {
            KhachHang kh = new KhachHang();
            kh.MaKhachHang = Int32.Parse(tbMaKh.Text);
            kh.TenKhachHang = tbTenKH.Text;
            kh.SoDienThoai = tbSoDienThoai.Text;
            kh.NgaySinh = dtpNgaySinh.Value.Date;

            khBLL.ThemKachHang1(kh);
        }

        private void btnTimKhuyenMai_Click(object sender, EventArgs e)
        {
            Dialog_ChonKhuyenMai dlg = new Dialog_ChonKhuyenMai();
            dlg.ShowDialog();
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            Form dlg = new Dialog_ChonKhachHang();
            dlg.ShowDialog();

        }

        private void tbKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            tinhTongTienKhuyenMai();
            tinhTongTien();

        }

        private void cbTichDiem_CheckedChanged(object sender, EventArgs e)
        {
            
            tinhTongTienKhuyenMai();
            tinhTongTien();
        
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(tbKhuyenMai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi !");
                return;
            }
            string[] maNV = tbNhanVien.Text.Split("-");
            int maKH = Int32.Parse(tbMaKh.Text);
            DateTime now = DateTime.Today;
            int tongTien = Int32.Parse(tbTongTien.Text.Replace(".","").Replace("VNĐ",""));
            int tongGiam = Int32.Parse(tbTongGiam.Text.Replace(".", "").Replace("VNĐ", ""));

            HoaDon hd = new HoaDon();
            hd.MaNhanVien = Int32.Parse(maNV[0]);
            hd.MaKhachHang = maKH;
            hd.NgayLap = now;
            hd.TongTien = tongTien;


            //           Update database
            //////////////////////////////////////////////////////////////////////

            hdBLL.ThemHoaDon(hd);    //add hóa đơn

            // update số lượng sp
            foreach(SanPham sp in dsGioHang)
            {
                spBLL.UpdateSoLuong(sp.MaSanPham, sp.SoLuong);
            }

            //update tổng chi tiêu khách hàng
            khBLL.UpdateTongChiTieu(maKH, tongTien);

            // trừ điểm tích lũy đã sử dụng
            if (cbTichDiem.Checked == true)
            {
                
                khBLL.UpdateDiemTichLuy(maKH, diemTichLuyDaSuDung);   
            }
            
            // cộng thêm điểm theo tổng tiền đã mua
            if(tongTien < 2000000)
            {          
                khBLL.UpdateDiemTichLuy(maKH, -50); //+50 điểm
                diemTichLuyCongThem = 50;
            }else if (tongTien > 7000000)
            {
                khBLL.UpdateDiemTichLuy(maKH, -150);   //+150 điểm
                 diemTichLuyCongThem = 150;
            }
            else
            {
                khBLL.UpdateDiemTichLuy(maKH, -100);   //+100 điểm
                 diemTichLuyCongThem = 100;
            }

            // add Chi Tiết Hóa Đơn 
            int maHD = hdBLL.getMaHoaDonMoiNhat();
            
            foreach(SanPham sp in dsGioHang)
            {
                ChiTietHoaDon cthd  = new ChiTietHoaDon();
                cthd.maHoaDon = maHD;
                cthd.maSanPham = sp.MaSanPham;
                cthd.soLuong = sp.SoLuong;
                cthd.donGia = sp.DonGia;
                cthd.thanhTien = sp.SoLuong * sp.DonGia;
                try
                {
                    cthdBLL.ThemCTHoaDon(cthd);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }

            //cập nhật số lượng GUI
            lvDssp.Items.Clear();
            hienThiToanBoSP();

            //Hiển thị hóa đơn
            int diemtichluy = khBLL.getDiemTichLuy(maKH);
            Dialog_HoaDon dlg = new Dialog_HoaDon();
            dlg.Show();
            dlg.HienThiHoaDon(dsGioHang, maHD.ToString(), tbMaKh.Text+"-"+tbTenKH.Text,tbNhanVien.Text,diemTichLuyCongThem,diemTichLuyDaSuDung,diemtichluy,tongGiam,tongTien);


            //Reset textbox 
            reset();
        }

        public static  void getKhachHang(KhachHang kh)
        {

            tbMaKh.Text = kh.MaKhachHang.ToString();
            tbTenKH.Text = kh.TenKhachHang;
            tbSoDienThoai.Text = kh.SoDienThoai;
            dtpNgaySinh.Value = kh.NgaySinh;
            tbDiemTichLuy.Text = kh.DiemTichLuy.ToString(); 
            
        }
        public static void getKhuyenMai(KhuyenMai km)
        {
            tbKhuyenMai.Text = km.MaKhuyenMai + "-" + km.TenKhuyenMai;
        }

        public void reset()
        {

            tongTienKhuyenMai = 0;
            diemTichLuyDaSuDung = 0;
            diemTichLuyCongThem = 0;

            dsGioHang.Clear();

            tbMaKh.Text = "";            
            tbTenKH.Text = "";
            tbSoDienThoai.Text = "";           
            tbDiemTichLuy.Text = "";

            tbMaSP.Text = "";
            tbTenSP.Text = "";
            tbDonGia.Text = "";
            numSoLuong.Value = 1;

            lvGioHang.Items.Clear();
            tbSoLuongGioHang.Text = "";
            cbTichDiem.Checked = false;
            cbTichDiem.Enabled = false;
            

            tbKhuyenMai.Text = "";
            tbTongGiam.Text = "";
            tbTongTien.Text = "";
        }

        private void tbTongTien_TextChanged(object sender, EventArgs e)
        {

        }


                                            // Quản lý hóa đơn
        ///////////////////////////////////////////////////////////////////////////////////
        public void LayToanBoHoaDon()
        {
           
            dsHoaDon = hdBLL.LayToanBoHoaDon();
            hienThiDanhSachHoaDon(dsHoaDon);
        }
        public void LayToanBoCTHD()
        {
            dsChiTietHoaDon = cthdBLL.LayToanBoCTHoaDon();
            hienThiDanhSachCTHD(dsChiTietHoaDon);
        }

        private void cbbTimKiemHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimKiemHD.Text == "Tất cả")
            {
                LayToanBoHoaDon();
            }
            if (cbbTimKiemHD.Text == "Theo Ngày")
            {
                tbNgayBD.Visible = false;
                tbNgayKT.Visible = false;

                dtpBatDau.Visible = true;
                dtpKetThuc.Visible = true;
            }
            if(cbbTimKiemHD.Text == "Theo Giá")
            {
                tbNgayBD.Visible = true;
                tbNgayKT.Visible = true;

                dtpBatDau.Visible = false;
                dtpKetThuc.Visible = false;
            }
        }

        private void tbNgayBD_TextChanged(object sender, EventArgs e)
        {
            if (tbNgayBD.Text == "")
            {
                return;
            }
            string num = tbNgayBD.Text;
            num = num.Replace(".", "");
            string temp = long.Parse(num).ToString("#,###", cul.NumberFormat);
            tbNgayBD.Text = temp;
            tbNgayBD.SelectionStart = temp.Length + 1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            lvDSHoaDon.Items.Clear();
            /// Tìm theo ngày
            if (cbbTimKiemHD.Text == "Theo Ngày")
            {              
                DateTime ngayBD = dtpBatDau.Value;
                DateTime ngayKT = dtpKetThuc.Value;
                List<HoaDon> hoaDonList = new List<HoaDon>();
                foreach(HoaDon hd in dsHoaDon)
                {
                    if(hd.NgayLap >= ngayBD && hd.NgayLap <= ngayKT)
                    {
                        hoaDonList.Add(hd);
                    }
                }

                hienThiDanhSachHoaDon(hoaDonList);
            }


            // Tìm theo giá
            if (cbbTimKiemHD.Text == "Theo Giá")
            {
                long giaBD, giaKT;
                if (tbNgayBD.Text == "")
                {
                    giaBD = 0;
                }
                else
                {
                    giaBD = long.Parse(tbNgayBD.Text.Replace(".", ""));
                }

                if (tbNgayBD.Text == "")
                {
                    giaKT = long.MaxValue;
                }
                else
                {
                    giaKT = long.Parse(tbNgayKT.Text.Replace(".", ""));
                }
                

                List<HoaDon> dsHD = new List<HoaDon>();

                foreach (HoaDon hd in dsHoaDon)
                {
                    if (hd.TongTien >= giaBD && hd.TongTien <= giaKT)
                    {
                        dsHD.Add(hd);
                    }
                }

                hienThiDanhSachHoaDon(dsHD);
            }
        }

        private void tbNgayKT_TextChanged(object sender, EventArgs e)
        {
            if (tbNgayKT.Text == "")
            {
                return;
            }
            string num = tbNgayKT.Text;
            num = num.Replace(".", "");
            string temp = long.Parse(num).ToString("#,###", cul.NumberFormat);
            tbNgayKT.Text = temp;
            tbNgayKT.SelectionStart = temp.Length + 1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LayToanBoCTHD();
        }

        private void lvDSHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSHoaDon.SelectedItems.Count > 0)
            {
                tbMaHD.Text = lvDSHoaDon.FocusedItem.SubItems[0].Text;
                tbMaKh_HD.Text = lvDSHoaDon.FocusedItem.SubItems[1].Text;
                tbNhanVienLap_HD.Text = lvDSHoaDon.FocusedItem.SubItems[2].Text;
                tbNgayLap.Text = lvDSHoaDon.FocusedItem.SubItems[3].Text;
                tbTongTien_HD.Text = lvDSHoaDon.FocusedItem.SubItems[4].Text;
                tbGhiChu.Text = lvDSHoaDon.FocusedItem.SubItems[5].Text;

                lvDSCTHD.Items.Clear();
                List<ChiTietHoaDon> cthd = new List<ChiTietHoaDon>();
                foreach(ChiTietHoaDon CTHD in dsChiTietHoaDon)
                {
                    if(CTHD.maHoaDon == Int32.Parse(lvDSHoaDon.FocusedItem.SubItems[0].Text))
                    {
                        cthd.Add(CTHD);
                    }
                }
                hienThiDanhSachCTHD(cthd);
            }
        }

        private void lvDSCTHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSCTHD.SelectedItems.Count > 0)
            {
                tbMaHD_CTHD.Text = lvDSCTHD.FocusedItem.SubItems[0].Text;
                tbMaSP_CTHD.Text = lvDSCTHD.FocusedItem.SubItems[1].Text;
                tbSoLuong_CTHD.Text = lvDSCTHD.FocusedItem.SubItems[2].Text;
                tbDonGia_CTHD.Text = lvDSCTHD.FocusedItem.SubItems[3].Text;
                tbThanhTien_CTHD.Text = lvDSCTHD.FocusedItem.SubItems[4].Text;              
            }
        }

        public void hienThiDanhSachHoaDon(List<HoaDon> list)
        {
            foreach (HoaDon hd in list)
            {
                ListViewItem lvi = new ListViewItem(hd.MaHoaDon + "");
                lvi.SubItems.Add(hd.MaKhachHang + "");
                lvi.SubItems.Add(hd.MaNhanVien + "");

                lvi.SubItems.Add(hd.NgayLap + "");
                lvi.SubItems.Add(hd.TongTien + "");
                lvi.SubItems.Add("Đã thanh toán");
                lvDSHoaDon.Items.Add(lvi);
            }
        }

        public void hienThiDanhSachCTHD(List<ChiTietHoaDon> list)
        {
            foreach (ChiTietHoaDon cthd in list)
            {
                ListViewItem lvi = new ListViewItem(cthd.maHoaDon + "");
                lvi.SubItems.Add(cthd.maSanPham + "");
                lvi.SubItems.Add(cthd.soLuong + "");

                lvi.SubItems.Add(cthd.donGia + "");
                lvi.SubItems.Add(cthd.thanhTien + "");
                lvi.SubItems.Add("Đã thanh toán");
                lvDSCTHD.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Visible = true;
            menu.quangcao();
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {

           
            foreach (ListViewItem item in lvDssp.Items)
            {
                string maSp = item.SubItems[0].Text.ToString();
                string soluong = item.SubItems[2].Text.ToString();
                if (Int32.Parse(numSoLuong.Value.ToString()) > Int32.Parse(soluong) && tbMaSP.Text == maSp)
                {
                    MessageBox.Show("Vượt quá số lượng sản phẩm hiện có !");
                    numSoLuong.Value = Int32.Parse(soluong);
                    return;
                }
            }
        }
    }
}
