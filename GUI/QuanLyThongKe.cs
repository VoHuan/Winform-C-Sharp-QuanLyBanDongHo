using BLL;
using DevExpress.Charts.Model;
using DevExpress.DataAccess.Native.Web;
using DevExpress.Spreadsheet.Charts;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;
using Series = DevExpress.XtraCharts.Series;
using SeriesCollection = DevExpress.Spreadsheet.Charts.SeriesCollection;

namespace GUI
{
    public partial class chart : DevExpress.XtraEditors.XtraForm
    {
        public String tx = "HoaDon";
        public chart()
        {
            InitializeComponent();
            this.tx = "HoaDon";
            dtpThoiGian.CustomFormat = "dd-MM-yyyy";
            dtpThoiGian.Format = DateTimePickerFormat.Custom;
            doanhThuBanHangTheoNam(tx);
        }

        private void doanhThuBanHangTheoNam(String s)
        {
            try
            {
                Series seri;
                Series seri1;
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.doanhThuNam(s);
                if (tx.Equals("HoaDon"))
                {
                    seri = new Series("Doanh thu năm", ViewType.Pie);
                    seri1 = new Series("Doanh thu năm", ViewType.Bar);
                }
                else
                {
                    seri = new Series("Chi tiêu năm", ViewType.Pie);
                    seri1 = new Series("Chi tiêu năm", ViewType.Bar);
                }
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Năm {A}: {VP: p0}";

                chartColumns.Series.Clear();
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Năm " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " VND");
                    lvObj.Items.Add(lvi);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private void doanhThuBanHangTheoQuy(String s, String d, String m, String y)
        {
            try
            {
                Series seri;
                Series seri1;
                if (tx.Equals("HoaDon"))
                {
                    seri = new Series("Doanh thu quý", ViewType.Pie);
                    seri1 = new Series("Doanh thu quý", ViewType.Bar);
                }
                else
                {
                    seri = new Series("Chi tiêu quý", ViewType.Pie);
                    seri1 = new Series("Chi tiêu quý", ViewType.Bar);
                }
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.doanhThuQuy(s, d, m, y);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Quý {A}: {VP: p0}";

                chartColumns.Series.Clear();
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Quý " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " VND");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void doanhThuBanHangTheoThang(String s, String d, String m, String y)
        {
            try
            {
                Series seri;
                Series seri1;
                if (tx.Equals("HoaDon"))
                {
                    seri = new Series("Doanh thu tháng", ViewType.Pie);
                    seri1 = new Series("Doanh thu tháng", ViewType.Bar);
                }
                else
                {
                    seri = new Series("Chi tiêu tháng", ViewType.Pie);
                    seri1 = new Series("Chi tiêu tháng", ViewType.Bar);
                }
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.doanhThuThang(s, d, m, y);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Tháng {A}: {VP: p0}";

                chartColumns.Series.Clear();
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Tháng " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " VND");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void doanhThuBanHangTheoNgay(String s, String d, String m, String y)
        {
            try
            {
                Series seri;
                Series seri1;
                if (tx.Equals("HoaDon"))
                {
                    seri = new Series("Doanh thu ngày", ViewType.Pie);
                    seri1 = new Series("Doanh thu ngày", ViewType.Bar);
                }
                else
                {
                    seri = new Series("Chi tiêu ngày", ViewType.Pie);
                    seri1 = new Series("Chi tiêu ngày", ViewType.Bar);
                }
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.doanhThuNgay(s, d, m, y);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Ngày {A}: {VP: p0}";

                chartColumns.Series.Clear();
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Ngày " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " VND");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cbLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBangThongKe.SelectedIndex == 0)
            {
                doanhThuBanHang();
            }
            else if (cbBangThongKe.SelectedIndex == 1)
            {
                doanhThuChiTieu();
            }
            else if (cbBangThongKe.SelectedIndex == 2)
            {
                thongKeSanPham();
            }
            else if (cbBangThongKe.SelectedIndex == 3)
            {
                thongKeKhachHang();
            }
            else if (cbBangThongKe.SelectedIndex == 4)
            {
                thongKeNhanVien();
            }
        }

        private void cbBangThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            String d = dtpThoiGian.Value.Day + "";
            String m = dtpThoiGian.Value.Month + "";
            String y = dtpThoiGian.Value.Year + "";
            if (cbBangThongKe.SelectedIndex == 0)
            {
                doanhThuBanHang();
            }
            else if (cbBangThongKe.SelectedIndex == 1)
            {
                doanhThuChiTieu();
            }
            else if (cbBangThongKe.SelectedIndex == 2)
            {
                thongKeSanPham();
            }
            else if (cbBangThongKe.SelectedIndex == 3)
            {
                thongKeKhachHang();
            }
            else if (cbBangThongKe.SelectedIndex == 4)
            {
                thongKeNhanVien();
            }
        }

        private void thongKeKhachHangTheoNgay(string d, string m, string y)
        {
            try
            {
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeKhachHangTheoNgay(d, m, y);
                Series seri = new Series("Chi tiêu khách hàng theo ngày", ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã khách hàng {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Chi tiêu khách hàng theo ngày " + d + " tháng " + m + " năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã KH " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " VND");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void thongKeKhachHangTheoThang(string d, string m, string y)
        {
            try
            {
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeKhachHangTheoThang(d, m, y);
                Series seri = new Series("Chi tiêu khách hàng tháng" + m + " năm " + y, ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã khách hàng {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Chi tiêu khách hàng tháng " + m + " năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã KH " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " VND");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void thongKeKhachHangTheoQuy(string d, string m, string y)
        {
            try
            {
                int mm = Int32.Parse(m);
                int v = 0;
                if (mm > 0 && mm <= 3)
                {
                    v = 1;
                }
                else if (mm > 3 && mm <= 6)
                {
                    v = 2;
                }
                else if (mm > 6 && mm <= 9)
                {
                    v = 3;
                }
                else if (mm > 9 && mm <= 12)
                {
                    v = 4;
                }
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeKhachHangTheoNgay(d, m, y);
                Series seri = new Series("Chi tiêu khách hàng quý " + v + " năm " + y, ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã khách hàng {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Chi tiêu khách hàng quý " + v + " năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã KH " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " VND");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void thongKeKhachHangTheoNam(string y)
        {
            try
            {
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeKhachHangTheoNam(y);
                Series seri = new Series("Chi tiêu khách hàng năm " + y, ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã khách hàng {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Chi tiêu khách hàng năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã KH " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " VND");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void thongKeNhanVienTheoNgay(string d, string m, string y)
        {
            try
            {
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeNhanVienTheoNgay(d, m, y);
                Series seri = new Series("Số lượng sản phẩm nhân viên bán tháng " + m + " năm " + y, ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã nhân viên {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Số lượng sản phẩm nhân viên bán vào ngày " + d + " tháng " + m + " năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã NV " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " sản phẩm");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void thongKeNhanVienTheoThang(string d, string m, string y)
        {
            try
            {
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeNhanVienTheoThang(d, m, y);
                Series seri = new Series("Số lượng sản phẩm nhân viên bán vào tháng " + m + " năm " + y, ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã nhân viên {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Số lượng sản phẩm nhân viên bán vào tháng " + m + " năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã NV " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " sản phẩm");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void thongKeNhanVienTheoQuy(string d, string m, string y)
        {
            try
            {
                int mm = Int32.Parse(m);
                int v = 0;
                if (mm > 0 && mm <= 3)
                {
                    v = 1;
                }
                else if (mm > 3 && mm <= 6)
                {
                    v = 2;
                }
                else if (mm > 6 && mm <= 9)
                {
                    v = 3;
                }
                else if (mm > 9 && mm <= 12)
                {
                    v = 4;
                }
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeNhanVienTheoQuy(d, m, y);
                Series seri = new Series("Số lượng sản phẩm nhân viên bán quý " + v + " năm " + y, ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã nhân viên {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Số lượng sản phẩm nhân viên bán trong quý " + v + " năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã NV " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " sản phẩm");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void thongKeNhanVienTheoNam(string y)
        {
            try
            {
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeNhanVienTheoNam(y);
                Series seri = new Series("Số lượng sản phẩm nhân viên bán vào năm " + y, ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã nhân viên {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Số lượng sản phẩm nhân viên bán vào năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã NV " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " sản phẩm");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void thongKeSanPhamTheoNgay(string d, string m, string y)
        {
            try
            {
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeSanPhamTheoNgay(d, m, y);
                Series seri = new Series("Số lượng từng sản phẩm bán theo ngày", ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã sản phẩm {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Số lượng từng sản phẩm bán vào ngày " + d + " tháng " + m + " năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã SP " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " sản phẩm");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void thongKeSanPhamTheoThang(string d, string m, string y)
        {
            try
            {
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeSanPhamTheoThang(d, m, y);
                Series seri = new Series("Số lượng từng sản phẩm bán vào tháng " + m + " năm " + y, ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã sản phẩm {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Số lượng từng sản phẩm bán vào tháng " + m + " năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã SP " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " sản phẩm");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void thongKeSanPhamTheoQuy(string d, string m, string y)
        {
            try
            {
                int mm = Int32.Parse(m);
                int v = 0;
                if (mm > 0 && mm <= 3)
                {
                    v = 1;
                }
                else if (mm > 3 && mm <= 6)
                {
                    v = 2;
                }
                else if (mm > 6 && mm <= 9)
                {
                    v = 3;
                }
                else if (mm > 9 && mm <= 12)
                {
                    v = 4;
                }
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeSanPhamTheoQuy(d, m, y);
                Series seri = new Series("Số lượng từng sản phẩm bán được vào quý " + v + " năm " + y, ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã sản phẩm {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Số lượng từng sản phẩm bán được vào quý " + v + " năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã SP " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " sản phẩm");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void thongKeSanPhamTheoNam(String y)
        {
            try
            {
                chartPies.Series.Clear();
                ThongKeBLL thongKeBLL = new ThongKeBLL();
                Hashtable h = thongKeBLL.thongKeSanPhamTheoNam(y);
                Series seri = new Series("Số lượng từng sản phẩm bán được năm " + y, ViewType.Pie);
                foreach (DictionaryEntry item in h)
                {
                    seri.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartPies.Series.Add(seri);
                seri.Label.TextPattern = "Mã sản phẩm {A}: {VP: p0}";

                chartColumns.Series.Clear();
                Series seri1 = new Series("Số lượng từng sản phẩm bán được năm " + y, ViewType.Bar);
                foreach (DictionaryEntry item in h)
                {
                    seri1.Points.Add(new SeriesPoint(item.Key, item.Value));
                }
                chartColumns.Series.Add(seri1);

                lvObj.Items.Clear();
                int[] arrKey = new int[h.Count];
                int[] arrValue = new int[h.Count];
                h.Keys.CopyTo(arrKey, 0);
                h.Values.CopyTo(arrValue, 0);
                Array.Sort(arrValue, arrKey);
                for (int i = arrKey.Length - 1; i>=0; i--)
                {
                    ListViewItem lvi = new ListViewItem("Mã sản phẩm " + arrKey[i].ToString() + "");
                    lvi.SubItems.Add(arrValue[i].ToString() + " sản phẩm");
                    lvObj.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            if (cbBangThongKe.SelectedIndex == 0)
            {
                doanhThuBanHang();
            }
            else if (cbBangThongKe.SelectedIndex == 1)
            {
                doanhThuChiTieu();
            }
            else if (cbBangThongKe.SelectedIndex == 2)
            {
                thongKeSanPham();
            }
            else if (cbBangThongKe.SelectedIndex == 3)
            {
                thongKeKhachHang();
            }
            else if (cbBangThongKe.SelectedIndex == 4)
            {
                thongKeNhanVien();
            }
        }

        private void thongKeSanPham()
        {
            String d = dtpThoiGian.Value.Day + "";
            String m = dtpThoiGian.Value.Month + "";
            String y = dtpThoiGian.Value.Year + "";
            if (cbLoaiThongKe.SelectedIndex == 0)
            {
                thongKeSanPhamTheoNam(y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 1)
            {
                thongKeSanPhamTheoQuy(d, m, y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 2)
            {
                thongKeSanPhamTheoThang(d, m, y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 3)
            {
                thongKeSanPhamTheoNgay(d, m, y);
            }
        }


        private void thongKeNhanVien()
        {
            String d = dtpThoiGian.Value.Day + "";
            String m = dtpThoiGian.Value.Month + "";
            String y = dtpThoiGian.Value.Year + "";
            if (cbLoaiThongKe.SelectedIndex == 0)
            {
                thongKeNhanVienTheoNam(y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 1)
            {
                thongKeNhanVienTheoQuy(d, m, y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 2)
            {
                thongKeNhanVienTheoThang(d, m, y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 3)
            {
                thongKeNhanVienTheoNgay(d, m, y);
            }
            else
            {
                thongKeNhanVienTheoNam(y);
            }
        }
        private void thongKeKhachHang()
        {
            String d = dtpThoiGian.Value.Day + "";
            String m = dtpThoiGian.Value.Month + "";
            String y = dtpThoiGian.Value.Year + "";
            if (cbLoaiThongKe.SelectedIndex == 0)
            {
                thongKeKhachHangTheoNam(y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 1)
            {
                thongKeKhachHangTheoQuy(d, m, y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 2)
            {
                thongKeKhachHangTheoThang(d, m, y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 3)
            {
                thongKeKhachHangTheoNgay(d, m, y);
            }
            else
            {
                thongKeKhachHangTheoNam(y);
            }
        }
        private void doanhThuChiTieu()
        {
            tx = "PhieuNhap";
            String d = dtpThoiGian.Value.Day + "";
            String m = dtpThoiGian.Value.Month + "";
            String y = dtpThoiGian.Value.Year + "";
            if (cbLoaiThongKe.SelectedIndex == 0)
            {
                doanhThuBanHangTheoNam(this.tx);
            }
            else if (cbLoaiThongKe.SelectedIndex == 1)
            {
                doanhThuBanHangTheoQuy(this.tx, d, m, y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 2)
            {
                doanhThuBanHangTheoThang(this.tx, d, m, y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 3)
            {
                doanhThuBanHangTheoNgay(this.tx, d, m, y);
            }
        }

        private void doanhThuBanHang()
        {
            tx = "HoaDon";
            String d = dtpThoiGian.Value.Day + "";
            String m = dtpThoiGian.Value.Month + "";
            String y = dtpThoiGian.Value.Year + "";
            if (cbLoaiThongKe.SelectedIndex == 0)
            {
                doanhThuBanHangTheoNam(this.tx);
            }
            else if (cbLoaiThongKe.SelectedIndex == 1)
            {
                doanhThuBanHangTheoQuy(this.tx, d, m, y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 2)
            {
                doanhThuBanHangTheoThang(this.tx, d, m, y);
            }
            else if (cbLoaiThongKe.SelectedIndex == 3)
            {
                doanhThuBanHangTheoNgay(this.tx, d, m, y);
            }
        }

        private void chart_Load(object sender, EventArgs e)
        {

        }

        private void lvObj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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