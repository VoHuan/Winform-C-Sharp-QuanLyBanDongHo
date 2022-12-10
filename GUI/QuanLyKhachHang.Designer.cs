namespace GUI
{
    partial class QuanLyKhachHang
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
            this.btNhapEx = new System.Windows.Forms.Button();
            this.btXuatEx = new System.Windows.Forms.Button();
            this.gbDSKH = new System.Windows.Forms.GroupBox();
            this.listViewKH = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.gbThaoTac = new System.Windows.Forms.GroupBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.flpTimKiem = new System.Windows.Forms.FlowLayoutPanel();
            this.tbsTimKiem = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMaKhachHang = new System.Windows.Forms.RadioButton();
            this.rbTenKhachHang = new System.Windows.Forms.RadioButton();
            this.rbTongChiTieu = new System.Windows.Forms.RadioButton();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.flpTimKiemTongChiTieu = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTu = new System.Windows.Forms.Label();
            this.tbTu = new System.Windows.Forms.TextBox();
            this.lbDen = new System.Windows.Forms.Label();
            this.tbDen = new System.Windows.Forms.TextBox();
            this.btHuyTimKiem = new System.Windows.Forms.Button();
            this.gbKhachHang = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbDiemTichLuy = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.tbMaKhachHang = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbMaKhachHang = new System.Windows.Forms.Label();
            this.tbTongChiTieu = new System.Windows.Forms.TextBox();
            this.lbTongChiTieu = new System.Windows.Forms.Label();
            this.lbDiemTichLuy = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.gbDSKH.SuspendLayout();
            this.gbThaoTac.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.flpTimKiem.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flpTimKiemTongChiTieu.SuspendLayout();
            this.gbKhachHang.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNhapEx
            // 
            this.btNhapEx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNhapEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNhapEx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNhapEx.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNhapEx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNhapEx.Image = global::GUI.Properties.Resources.import;
            this.btNhapEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhapEx.Location = new System.Drawing.Point(3, 3);
            this.btNhapEx.Name = "btNhapEx";
            this.btNhapEx.Size = new System.Drawing.Size(145, 50);
            this.btNhapEx.TabIndex = 20;
            this.btNhapEx.Text = "Nhập Excel";
            this.btNhapEx.UseVisualStyleBackColor = false;
            this.btNhapEx.Click += new System.EventHandler(this.btNhapEx_Click);
            // 
            // btXuatEx
            // 
            this.btXuatEx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXuatEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXuatEx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXuatEx.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btXuatEx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXuatEx.Image = global::GUI.Properties.Resources.export;
            this.btXuatEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXuatEx.Location = new System.Drawing.Point(154, 3);
            this.btXuatEx.Name = "btXuatEx";
            this.btXuatEx.Size = new System.Drawing.Size(145, 49);
            this.btXuatEx.TabIndex = 21;
            this.btXuatEx.Text = "Xuất Excel";
            this.btXuatEx.UseVisualStyleBackColor = false;
            this.btXuatEx.Click += new System.EventHandler(this.btXuatEx_Click);
            // 
            // gbDSKH
            // 
            this.gbDSKH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbDSKH.Controls.Add(this.listViewKH);
            this.gbDSKH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDSKH.Location = new System.Drawing.Point(49, 392);
            this.gbDSKH.Name = "gbDSKH";
            this.gbDSKH.Size = new System.Drawing.Size(1654, 432);
            this.gbDSKH.TabIndex = 22;
            this.gbDSKH.TabStop = false;
            this.gbDSKH.Text = "Danh sách khách hàng";
            // 
            // listViewKH
            // 
            this.listViewKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listViewKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewKH.FullRowSelect = true;
            this.listViewKH.GridLines = true;
            this.listViewKH.Location = new System.Drawing.Point(12, 30);
            this.listViewKH.Name = "listViewKH";
            this.listViewKH.Size = new System.Drawing.Size(1580, 388);
            this.listViewKH.TabIndex = 0;
            this.listViewKH.UseCompatibleStateImageBehavior = false;
            this.listViewKH.View = System.Windows.Forms.View.Details;
            this.listViewKH.SelectedIndexChanged += new System.EventHandler(this.listViewKH_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khách hàng";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên khách hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 330;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 230;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số điện thoại";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điểm tích lũy";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 230;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng chi tiêu";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 260;
            // 
            // gbThaoTac
            // 
            this.gbThaoTac.BackColor = System.Drawing.SystemColors.Window;
            this.gbThaoTac.Controls.Add(this.btThem);
            this.gbThaoTac.Controls.Add(this.btXoa);
            this.gbThaoTac.Controls.Add(this.btSua);
            this.gbThaoTac.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbThaoTac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbThaoTac.Location = new System.Drawing.Point(485, 29);
            this.gbThaoTac.Name = "gbThaoTac";
            this.gbThaoTac.Size = new System.Drawing.Size(140, 237);
            this.gbThaoTac.TabIndex = 23;
            this.gbThaoTac.TabStop = false;
            this.gbThaoTac.Text = "Thao tác";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(19, 29);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(106, 45);
            this.btThem.TabIndex = 17;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Image = global::GUI.Properties.Resources.delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(19, 100);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 43);
            this.btXoa.TabIndex = 19;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSua.Image = global::GUI.Properties.Resources.tools;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(19, 170);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(106, 43);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbTimKiem.Controls.Add(this.flpTimKiem);
            this.gbTimKiem.Controls.Add(this.flowLayoutPanel1);
            this.gbTimKiem.Controls.Add(this.btTimKiem);
            this.gbTimKiem.Controls.Add(this.flpTimKiemTongChiTieu);
            this.gbTimKiem.Controls.Add(this.btHuyTimKiem);
            this.gbTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTimKiem.Location = new System.Drawing.Point(737, 24);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(574, 258);
            this.gbTimKiem.TabIndex = 24;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // flpTimKiem
            // 
            this.flpTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTimKiem.Controls.Add(this.tbsTimKiem);
            this.flpTimKiem.Enabled = false;
            this.flpTimKiem.Location = new System.Drawing.Point(32, 114);
            this.flpTimKiem.Name = "flpTimKiem";
            this.flpTimKiem.Size = new System.Drawing.Size(519, 36);
            this.flpTimKiem.TabIndex = 26;
            // 
            // tbsTimKiem
            // 
            this.tbsTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbsTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbsTimKiem.Location = new System.Drawing.Point(3, 3);
            this.tbsTimKiem.Name = "tbsTimKiem";
            this.tbsTimKiem.Size = new System.Drawing.Size(515, 27);
            this.tbsTimKiem.TabIndex = 19;
            this.tbsTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsTimKiem_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbMaKhachHang);
            this.flowLayoutPanel1.Controls.Add(this.rbTenKhachHang);
            this.flowLayoutPanel1.Controls.Add(this.rbTongChiTieu);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(519, 84);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // rbMaKhachHang
            // 
            this.rbMaKhachHang.AutoSize = true;
            this.rbMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMaKhachHang.Location = new System.Drawing.Point(3, 3);
            this.rbMaKhachHang.Name = "rbMaKhachHang";
            this.rbMaKhachHang.Size = new System.Drawing.Size(130, 24);
            this.rbMaKhachHang.TabIndex = 16;
            this.rbMaKhachHang.TabStop = true;
            this.rbMaKhachHang.Text = "Mã khách hàng";
            this.rbMaKhachHang.UseVisualStyleBackColor = true;
            this.rbMaKhachHang.CheckedChanged += new System.EventHandler(this.rbMaKhachHang_CheckedChanged);
            // 
            // rbTenKhachHang
            // 
            this.rbTenKhachHang.AutoSize = true;
            this.rbTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbTenKhachHang.Location = new System.Drawing.Point(139, 3);
            this.rbTenKhachHang.Name = "rbTenKhachHang";
            this.rbTenKhachHang.Size = new System.Drawing.Size(132, 24);
            this.rbTenKhachHang.TabIndex = 17;
            this.rbTenKhachHang.TabStop = true;
            this.rbTenKhachHang.Text = "Tên khách hàng";
            this.rbTenKhachHang.UseVisualStyleBackColor = true;
            this.rbTenKhachHang.CheckedChanged += new System.EventHandler(this.rbTenKhachHang_CheckedChanged);
            // 
            // rbTongChiTieu
            // 
            this.rbTongChiTieu.AutoSize = true;
            this.rbTongChiTieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbTongChiTieu.Location = new System.Drawing.Point(277, 3);
            this.rbTongChiTieu.Name = "rbTongChiTieu";
            this.rbTongChiTieu.Size = new System.Drawing.Size(116, 24);
            this.rbTongChiTieu.TabIndex = 14;
            this.rbTongChiTieu.TabStop = true;
            this.rbTongChiTieu.Text = "Tổng chi tiêu";
            this.rbTongChiTieu.UseVisualStyleBackColor = true;
            this.rbTongChiTieu.CheckedChanged += new System.EventHandler(this.rbTongChiTieu_CheckedChanged);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(136, 191);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(140, 47);
            this.btTimKiem.TabIndex = 20;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // flpTimKiemTongChiTieu
            // 
            this.flpTimKiemTongChiTieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTimKiemTongChiTieu.Controls.Add(this.lbTu);
            this.flpTimKiemTongChiTieu.Controls.Add(this.tbTu);
            this.flpTimKiemTongChiTieu.Controls.Add(this.lbDen);
            this.flpTimKiemTongChiTieu.Controls.Add(this.tbDen);
            this.flpTimKiemTongChiTieu.Enabled = false;
            this.flpTimKiemTongChiTieu.Location = new System.Drawing.Point(32, 114);
            this.flpTimKiemTongChiTieu.Name = "flpTimKiemTongChiTieu";
            this.flpTimKiemTongChiTieu.Size = new System.Drawing.Size(355, 37);
            this.flpTimKiemTongChiTieu.TabIndex = 25;
            this.flpTimKiemTongChiTieu.Visible = false;
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTu.Location = new System.Drawing.Point(3, 0);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(26, 20);
            this.lbTu.TabIndex = 15;
            this.lbTu.Text = "Từ";
            // 
            // tbTu
            // 
            this.tbTu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTu.Location = new System.Drawing.Point(35, 3);
            this.tbTu.Name = "tbTu";
            this.tbTu.Size = new System.Drawing.Size(127, 27);
            this.tbTu.TabIndex = 11;
            this.tbTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTu_KeyPress);
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDen.Location = new System.Drawing.Point(168, 0);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(39, 23);
            this.lbDen.TabIndex = 6;
            this.lbDen.Text = "đến";
            // 
            // tbDen
            // 
            this.tbDen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDen.Location = new System.Drawing.Point(213, 3);
            this.tbDen.Name = "tbDen";
            this.tbDen.Size = new System.Drawing.Size(127, 27);
            this.tbDen.TabIndex = 12;
            this.tbDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTu_KeyPress);
            // 
            // btHuyTimKiem
            // 
            this.btHuyTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btHuyTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHuyTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHuyTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btHuyTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btHuyTimKiem.Image = global::GUI.Properties.Resources.cancel;
            this.btHuyTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuyTimKiem.Location = new System.Drawing.Point(360, 190);
            this.btHuyTimKiem.Name = "btHuyTimKiem";
            this.btHuyTimKiem.Size = new System.Drawing.Size(140, 48);
            this.btHuyTimKiem.TabIndex = 13;
            this.btHuyTimKiem.Text = "Hủy";
            this.btHuyTimKiem.UseVisualStyleBackColor = false;
            this.btHuyTimKiem.Click += new System.EventHandler(this.btHuyTimKiem_Click);
            // 
            // gbKhachHang
            // 
            this.gbKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbKhachHang.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbKhachHang.Controls.Add(this.tableLayoutPanel1);
            this.gbKhachHang.Controls.Add(this.btnSua);
            this.gbKhachHang.Controls.Add(this.btnXoa);
            this.gbKhachHang.Controls.Add(this.btHuy);
            this.gbKhachHang.Controls.Add(this.btnThem);
            this.gbKhachHang.Controls.Add(this.gbThaoTac);
            this.gbKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbKhachHang.Location = new System.Drawing.Point(49, 16);
            this.gbKhachHang.Name = "gbKhachHang";
            this.gbKhachHang.Size = new System.Drawing.Size(655, 348);
            this.gbKhachHang.TabIndex = 0;
            this.gbKhachHang.TabStop = false;
            this.gbKhachHang.Text = "Thông tin khách hàng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.61538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.38461F));
            this.tableLayoutPanel1.Controls.Add(this.tbDiemTichLuy, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbHoTen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbMaKhachHang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbHoTen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSDT, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbSDT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbNgaySinh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgaySinh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbMaKhachHang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbTongChiTieu, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbTongChiTieu, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbDiemTichLuy, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.54099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.45901F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 237);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // tbDiemTichLuy
            // 
            this.tbDiemTichLuy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiemTichLuy.Enabled = false;
            this.tbDiemTichLuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDiemTichLuy.Location = new System.Drawing.Point(160, 162);
            this.tbDiemTichLuy.Name = "tbDiemTichLuy";
            this.tbDiemTichLuy.Size = new System.Drawing.Size(285, 27);
            this.tbDiemTichLuy.TabIndex = 21;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHoTen.Location = new System.Drawing.Point(5, 41);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(62, 23);
            this.lbHoTen.TabIndex = 4;
            this.lbHoTen.Text = "Họ tên";
            // 
            // tbMaKhachHang
            // 
            this.tbMaKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaKhachHang.Enabled = false;
            this.tbMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMaKhachHang.Location = new System.Drawing.Point(160, 5);
            this.tbMaKhachHang.Name = "tbMaKhachHang";
            this.tbMaKhachHang.Size = new System.Drawing.Size(285, 27);
            this.tbMaKhachHang.TabIndex = 16;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHoTen.Enabled = false;
            this.tbHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbHoTen.Location = new System.Drawing.Point(160, 44);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(285, 27);
            this.tbHoTen.TabIndex = 8;
            // 
            // tbSDT
            // 
            this.tbSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSDT.Enabled = false;
            this.tbSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSDT.Location = new System.Drawing.Point(160, 123);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(285, 27);
            this.tbSDT.TabIndex = 19;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSDT.Location = new System.Drawing.Point(5, 120);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(111, 23);
            this.lbSDT.TabIndex = 18;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNgaySinh.Location = new System.Drawing.Point(5, 83);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(86, 23);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(160, 86);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(285, 27);
            this.dtpNgaySinh.TabIndex = 17;
            this.dtpNgaySinh.Value = new System.DateTime(2022, 11, 22, 0, 0, 0, 0);
            // 
            // lbMaKhachHang
            // 
            this.lbMaKhachHang.AutoSize = true;
            this.lbMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMaKhachHang.Location = new System.Drawing.Point(5, 2);
            this.lbMaKhachHang.Name = "lbMaKhachHang";
            this.lbMaKhachHang.Size = new System.Drawing.Size(128, 23);
            this.lbMaKhachHang.TabIndex = 0;
            this.lbMaKhachHang.Text = "Mã khách hàng";
            // 
            // tbTongChiTieu
            // 
            this.tbTongChiTieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTongChiTieu.Enabled = false;
            this.tbTongChiTieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTongChiTieu.Location = new System.Drawing.Point(160, 200);
            this.tbTongChiTieu.Name = "tbTongChiTieu";
            this.tbTongChiTieu.Size = new System.Drawing.Size(285, 27);
            this.tbTongChiTieu.TabIndex = 9;
            // 
            // lbTongChiTieu
            // 
            this.lbTongChiTieu.AutoSize = true;
            this.lbTongChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTongChiTieu.Location = new System.Drawing.Point(5, 197);
            this.lbTongChiTieu.Name = "lbTongChiTieu";
            this.lbTongChiTieu.Size = new System.Drawing.Size(110, 23);
            this.lbTongChiTieu.TabIndex = 7;
            this.lbTongChiTieu.Text = "Tổng chi tiêu";
            // 
            // lbDiemTichLuy
            // 
            this.lbDiemTichLuy.AutoSize = true;
            this.lbDiemTichLuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDiemTichLuy.Location = new System.Drawing.Point(5, 159);
            this.lbDiemTichLuy.Name = "lbDiemTichLuy";
            this.lbDiemTichLuy.Size = new System.Drawing.Size(110, 23);
            this.lbDiemTichLuy.TabIndex = 20;
            this.lbDiemTichLuy.Text = "Điểm tích lũy";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Image = global::GUI.Properties.Resources.tools;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(167, 285);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 43);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Image = global::GUI.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(168, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 43);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btHuy.Image = global::GUI.Properties.Resources.cancel;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(288, 285);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(94, 43);
            this.btHuy.TabIndex = 23;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Visible = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Image = global::GUI.Properties.Resources.plus;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(167, 285);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 43);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Visible = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.btNhapEx);
            this.flowLayoutPanel2.Controls.Add(this.btXuatEx);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(885, 306);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(304, 58);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Lime;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(1429, 177);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(212, 65);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "Trở Về Trang Chính";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1715, 836);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbKhachHang);
            this.Controls.Add(this.gbDSKH);
            this.Name = "QuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            this.gbDSKH.ResumeLayout(false);
            this.gbThaoTac.ResumeLayout(false);
            this.gbTimKiem.ResumeLayout(false);
            this.flpTimKiem.ResumeLayout(false);
            this.flpTimKiem.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flpTimKiemTongChiTieu.ResumeLayout(false);
            this.flpTimKiemTongChiTieu.PerformLayout();
            this.gbKhachHang.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btNhapEx;
        private Button btXuatEx;
        private GroupBox gbDSKH;
        private ListView listViewKH;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox gbThaoTac;
        private Button btThem;
        private Button btXoa;
        private Button btSua;
        private GroupBox gbTimKiem;
        private TextBox tbsTimKiem;
        private RadioButton rbMaKhachHang;
        private RadioButton rbTongChiTieu;
        private Button btHuyTimKiem;
        private Label lbDen;
        private TextBox tbTu;
        private TextBox tbDen;
        private GroupBox gbKhachHang;
        private Button btnSua;
        private Button btnXoa;
        private Button btHuy;
        private Button btnThem;
        private TextBox tbSDT;
        private Label lbSDT;
        private DateTimePicker dtpNgaySinh;
        private TextBox tbMaKhachHang;
        private TextBox tbTongChiTieu;
        private Label lbNgaySinh;
        private TextBox tbHoTen;
        private Label lbTongChiTieu;
        private Label lbHoTen;
        private Label lbMaKhachHang;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button btTimKiem;
        private ColumnHeader columnHeader6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbDiemTichLuy;
        private TextBox tbDiemTichLuy;
        private RadioButton rbTenKhachHang;
        private Label lbTu;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flpTimKiemTongChiTieu;
        private FlowLayoutPanel flpTimKiem;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnHome;
    }
}