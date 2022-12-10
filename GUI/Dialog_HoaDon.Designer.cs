namespace GUI
{
    partial class Dialog_HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.tbKhacHang = new System.Windows.Forms.TextBox();
            this.tbNhanVien = new System.Windows.Forms.TextBox();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.tbNgayLap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbDiemCongThem = new System.Windows.Forms.TextBox();
            this.tbDiemDaSuDung = new System.Windows.Forms.TextBox();
            this.tbDiemConLai = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbTongTienGiam = new System.Windows.Forms.TextBox();
            this.tbTongTienChuaKM = new System.Windows.Forms.TextBox();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Bán Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách Hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân Viên Lập :";
            // 
            // tbMaHD
            // 
            this.tbMaHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaHD.Location = new System.Drawing.Point(146, 47);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(185, 20);
            this.tbMaHD.TabIndex = 4;
            // 
            // tbKhacHang
            // 
            this.tbKhacHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKhacHang.Location = new System.Drawing.Point(146, 79);
            this.tbKhacHang.Name = "tbKhacHang";
            this.tbKhacHang.Size = new System.Drawing.Size(185, 20);
            this.tbKhacHang.TabIndex = 5;
            // 
            // tbNhanVien
            // 
            this.tbNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNhanVien.Location = new System.Drawing.Point(146, 109);
            this.tbNhanVien.Name = "tbNhanVien";
            this.tbNhanVien.Size = new System.Drawing.Size(185, 20);
            this.tbNhanVien.TabIndex = 6;
            this.tbNhanVien.TextChanged += new System.EventHandler(this.tbNhanVien_TextChanged);
            // 
            // lvSanPham
            // 
            this.lvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSanPham.Location = new System.Drawing.Point(3, 3);
            this.lvSanPham.MultiSelect = false;
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(698, 49);
            this.lvSanPham.TabIndex = 7;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            this.lvSanPham.SelectedIndexChanged += new System.EventHandler(this.lvSanPham_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sản Phẩm";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sản Phẩm";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn Giá";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành Tiền";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 135;
            // 
            // tbNgayLap
            // 
            this.tbNgayLap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNgayLap.Location = new System.Drawing.Point(146, 137);
            this.tbNgayLap.Name = "tbNgayLap";
            this.tbNgayLap.Size = new System.Drawing.Size(280, 20);
            this.tbNgayLap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày Lập :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(9, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(704, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "===============================================================================";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvSanPham, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbDiemCongThem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbDiemDaSuDung, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbDiemConLai, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbTongTienGiam, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbTongTienChuaKM, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbTongTien, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 13);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 189);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 516);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(3, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(698, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "===============================================================================";
            // 
            // tbDiemCongThem
            // 
            this.tbDiemCongThem.BackColor = System.Drawing.Color.White;
            this.tbDiemCongThem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDiemCongThem.Enabled = false;
            this.tbDiemCongThem.Location = new System.Drawing.Point(3, 84);
            this.tbDiemCongThem.Name = "tbDiemCongThem";
            this.tbDiemCongThem.Size = new System.Drawing.Size(698, 20);
            this.tbDiemCongThem.TabIndex = 14;
            // 
            // tbDiemDaSuDung
            // 
            this.tbDiemDaSuDung.BackColor = System.Drawing.Color.White;
            this.tbDiemDaSuDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDiemDaSuDung.Enabled = false;
            this.tbDiemDaSuDung.Location = new System.Drawing.Point(3, 110);
            this.tbDiemDaSuDung.Name = "tbDiemDaSuDung";
            this.tbDiemDaSuDung.Size = new System.Drawing.Size(698, 20);
            this.tbDiemDaSuDung.TabIndex = 15;
            // 
            // tbDiemConLai
            // 
            this.tbDiemConLai.BackColor = System.Drawing.Color.White;
            this.tbDiemConLai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDiemConLai.Enabled = false;
            this.tbDiemConLai.Location = new System.Drawing.Point(3, 136);
            this.tbDiemConLai.Name = "tbDiemConLai";
            this.tbDiemConLai.Size = new System.Drawing.Size(698, 20);
            this.tbDiemConLai.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(3, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(698, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "========================================================================";
            // 
            // tbTongTienGiam
            // 
            this.tbTongTienGiam.BackColor = System.Drawing.Color.White;
            this.tbTongTienGiam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTienGiam.Enabled = false;
            this.tbTongTienGiam.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbTongTienGiam.Location = new System.Drawing.Point(3, 188);
            this.tbTongTienGiam.Name = "tbTongTienGiam";
            this.tbTongTienGiam.Size = new System.Drawing.Size(698, 20);
            this.tbTongTienGiam.TabIndex = 18;
            // 
            // tbTongTienChuaKM
            // 
            this.tbTongTienChuaKM.BackColor = System.Drawing.Color.White;
            this.tbTongTienChuaKM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTienChuaKM.Enabled = false;
            this.tbTongTienChuaKM.ForeColor = System.Drawing.Color.Black;
            this.tbTongTienChuaKM.Location = new System.Drawing.Point(3, 214);
            this.tbTongTienChuaKM.Name = "tbTongTienChuaKM";
            this.tbTongTienChuaKM.Size = new System.Drawing.Size(698, 20);
            this.tbTongTienChuaKM.TabIndex = 19;
            // 
            // tbTongTien
            // 
            this.tbTongTien.BackColor = System.Drawing.Color.White;
            this.tbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTien.Enabled = false;
            this.tbTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTongTien.ForeColor = System.Drawing.Color.Black;
            this.tbTongTien.Location = new System.Drawing.Point(3, 240);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(698, 23);
            this.tbTongTien.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(3, 269);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(698, 20);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "=====================================================================";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(3, 295);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(698, 23);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "Cảm Ơn Qúy Khách Đã Mua Hàng";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(3, 324);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(698, 25);
            this.textBox6.TabIndex = 23;
            this.textBox6.Text = "Hẹn Gặp Lại Qúy Khách !!!";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(237, 711);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(94, 29);
            this.btnIn.TabIndex = 13;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(426, 711);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Dialog_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 763);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbNgayLap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNhanVien);
            this.Controls.Add(this.tbKhacHang);
            this.Controls.Add(this.tbMaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dialog_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dialog_HoaDon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbMaHD;
        private TextBox tbKhacHang;
        private TextBox tbNhanVien;
        private ListView lvSanPham;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox tbNgayLap;
        private Label label5;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox2;
        private Button btnIn;
        private Button btnThoat;
        private TextBox tbDiemCongThem;
        private TextBox tbDiemDaSuDung;
        private TextBox tbDiemConLai;
        private TextBox textBox3;
        private TextBox tbTongTienGiam;
        private TextBox tbTongTienChuaKM;
        private TextBox tbTongTien;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
    }
}