using BLL;
using DTO;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
//using OfficeOpenXml.Core.ExcelPackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GUI
{
    public partial class QuanLyNhanVien : Form
    {
        NhanVienBLL nvBLL;
        List<NhanVien> dsnv = new List<NhanVien>();
        public QuanLyNhanVien()
        {
            nvBLL = new NhanVienBLL();
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
            loadDataComBoBox();
        }
        public void loadData()
        {
            lvDSNV.Items.Clear();
            dsnv = nvBLL.layToanBoNhanVien();
            
            foreach (NhanVien nv in dsnv)
            {              
                ListViewItem lvi = new ListViewItem(nv.MaNhanVien + "");
                lvi.SubItems.Add(nv.TenNhanVien.Trim() + "");
                lvi.SubItems.Add(nv.NgaySinh.ToShortDateString() + "");
                lvi.SubItems.Add(nv.SoDienThoai.Trim() + "");
                lvi.SubItems.Add(nv.ChucVu.Trim() + "");
                
                lvDSNV.Items.Add(lvi);
            }
        }
        public void loadDataComBoBox()
        {
            cbbChucVu.Items.Clear();
            cbbTimKiem.Items.Clear();
            List<String> chucvu = new List<string>();
            foreach(NhanVien nv in dsnv)
            {
                if (chucvu.Contains(nv.ChucVu.Trim()))
                {
                    continue;
                }
                else
                {
                    chucvu.Add(nv.ChucVu.Trim());
                    cbbChucVu.Items.Add(nv.ChucVu.Trim());
                    cbbTimKiem.Items.Add(nv.ChucVu.Trim());
                }
                
            }
        }
        private void lvDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count > 0)
            {
                tbMaNV.Text = lvDSNV.FocusedItem.SubItems[0].Text;
                tbTenNV.Text = lvDSNV.FocusedItem.SubItems[1].Text;
                dtpNgaySinh.Value = DateTime.Parse(lvDSNV.FocusedItem.SubItems[2].Text.ToString());
                tbSDT.Text = lvDSNV.FocusedItem.SubItems[3].Text;
                cbbChucVu.Text = lvDSNV.FocusedItem.SubItems[4].Text;
            }
        }
        public void timKiemTheoChucVu(string chucvu)
        {
            lvDSNV.Items.Clear();
            if(cbbTimKiem.Text == "Tất cả")
            {
                loadData();
                return;
            }
                
            foreach (NhanVien nv in dsnv)
            {
                if(nv.ChucVu.Trim() == chucvu)
                {
                    ListViewItem lvi = new ListViewItem(nv.MaNhanVien + "");
                    lvi.SubItems.Add(nv.TenNhanVien.Trim() + "");
                    lvi.SubItems.Add(nv.NgaySinh.ToShortDateString() + "");
                    lvi.SubItems.Add(nv.SoDienThoai.Trim() + "");
                    lvi.SubItems.Add(nv.ChucVu.Trim() + "");

                    lvDSNV.Items.Add(lvi);
                }
               
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if(tbTenNV.Text == "" || cbbChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
                return;
            }
            NhanVien nv = new NhanVien();
            nv.TenNhanVien = tbTenNV.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.SoDienThoai = tbSDT.Text;
            if(cbbChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Chức vụ ko hợp lệ, hãy chọn chức vụ có sẵn !");
                return;
            }
            else
                nv.ChucVu = cbbChucVu.Text;

            if (nvBLL.themNhanVien(nv))
                MessageBox.Show("Thêm thành công nhân viên !");
            else
                MessageBox.Show("Thêm thất bại !");
            

            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbTenNV.Text == "" || cbbChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
                return;
            }
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = Int32.Parse(tbMaNV.Text);
            nv.TenNhanVien = tbTenNV.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.SoDienThoai = tbSDT.Text;
            nv.ChucVu = cbbChucVu.Text;

            if (nvBLL.suaNhanVien(nv))
                MessageBox.Show("Sửa thành công nhân viên !");
            else
                MessageBox.Show("Sửa thất bại !");


            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(tbMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên !");
                return;
            }

            if(nvBLL.xoaNhanVien(Int32.Parse(tbMaNV.Text.Trim())))
                 MessageBox.Show("Xóa thành công !");
            else
                MessageBox.Show("Xóa thất bại !");

            loadData();
        }



        private void ExportExcel(string path)
        {
            try
            {
                int number = lvDSNV.Items.Count;

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
                worKsheeT.Cells[1, 1] = "DANH SÁCH NHÂN VIÊN";
                worKsheeT.Cells[2, 1] = "Mã nhân viên";
                worKsheeT.Cells[2, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                worKsheeT.Cells[2, 2] = "Tên nhân viên";
                worKsheeT.Cells[2, 2].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                worKsheeT.Cells[2, 3] = "Ngày sinh";
                worKsheeT.Cells[2, 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                worKsheeT.Cells[2, 4] = "Số điện thoại";
                worKsheeT.Cells[2, 4].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                worKsheeT.Cells[2, 5] = "Chức vụ";
                worKsheeT.Cells[2, 5].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                
                
                worKsheeT.Cells.Font.Size = 15;
                worKsheeT.Columns.ColumnWidth = 35;


                int i = 3;
                foreach (ListViewItem item in lvDSNV.Items)
                {
                    worKsheeT.Cells[i, 1] = item.SubItems[0].Text.ToString();
                    worKsheeT.Cells[i, 2] = item.SubItems[1].Text.ToString();
                    DateTime ngaySinh = Convert.ToDateTime(item.SubItems[2].Text.ToString());
                    worKsheeT.Cells[i, 3] = ngaySinh.ToShortDateString();
                    worKsheeT.Cells[i, 4] = item.SubItems[3].Text.ToString();
                    worKsheeT.Cells[i, 5] = item.SubItems[4].Text.ToString();
                   
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





        private void ImportExcel(string path)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                for (int i = excelWorksheet.Dimension.Start.Row + 2; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    ListViewItem lvi = new ListViewItem(excelWorksheet.Cells[i, excelWorksheet.Dimension.Start.Column].Value.ToString());
                    for (int j = excelWorksheet.Dimension.Start.Column + 1; j <= excelWorksheet.Dimension.End.Column-1; j++)
                    {
                        lvi.SubItems.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    lvDSNV.Items.Add(lvi);
                }
            }
        }
        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Title = "Export Excel";
            openFileDialog1.Filter = "Excel (*.xlsx)| *.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lvDSNV.Items.Clear();
                    ImportExcel(openFileDialog1.FileName);
                   // MessageBox.Show("Nhập file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Nhập file thất bại");
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.Title = "Export Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)| *.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    ExportExcel(saveFileDialog1.FileName);
                    //MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Xuất file thất bại");
                }
            }
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTimKiem.SelectedIndex > -1)
            {
                timKiemTheoChucVu(cbbTimKiem.Text.Trim());
            }
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            lvDSNV.Items.Clear();
            foreach (NhanVien nv in dsnv)
            {
                if (nv.TenNhanVien.Contains(tbTimKiem.Text, StringComparison.InvariantCultureIgnoreCase)  || nv.MaNhanVien.ToString() == tbTimKiem.Text
                    || nv.SoDienThoai.Contains(tbTimKiem.Text))
                {
                    ListViewItem lvi = new ListViewItem(nv.MaNhanVien + "");
                    lvi.SubItems.Add(nv.TenNhanVien.Trim() + "");
                    lvi.SubItems.Add(nv.NgaySinh.ToShortDateString() + "");
                    lvi.SubItems.Add(nv.SoDienThoai.Trim() + "");
                    lvi.SubItems.Add(nv.ChucVu.Trim() + "");

                    lvDSNV.Items.Add(lvi);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Visible = true;
            menu.quangcao();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
