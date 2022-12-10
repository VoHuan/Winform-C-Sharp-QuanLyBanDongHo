namespace GUI
{
    partial class DialogNhaCungCap
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
            this.lvNhaCungCap = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.txTuKhoa = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btChon = new System.Windows.Forms.Button();
            this.txTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.txSoDienThoai = new System.Windows.Forms.TextBox();
            this.txDiaChi = new System.Windows.Forms.RichTextBox();
            this.txMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvNhaCungCap
            // 
            this.lvNhaCungCap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvNhaCungCap.FullRowSelect = true;
            this.lvNhaCungCap.Location = new System.Drawing.Point(12, 61);
            this.lvNhaCungCap.Name = "lvNhaCungCap";
            this.lvNhaCungCap.Size = new System.Drawing.Size(633, 373);
            this.lvNhaCungCap.TabIndex = 0;
            this.lvNhaCungCap.UseCompatibleStateImageBehavior = false;
            this.lvNhaCungCap.View = System.Windows.Forms.View.Details;
            this.lvNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.lvNhaCungCap_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nhà cung cấp";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhà cung cấp";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số điện thoại";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // txTuKhoa
            // 
            this.txTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txTuKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTuKhoa.Location = new System.Drawing.Point(12, 17);
            this.txTuKhoa.Name = "txTuKhoa";
            this.txTuKhoa.Size = new System.Drawing.Size(472, 34);
            this.txTuKhoa.TabIndex = 2;
            this.txTuKhoa.TextChanged += new System.EventHandler(this.txTuKhoa_TextChanged);
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTim.Location = new System.Drawing.Point(490, 15);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(155, 38);
            this.btTim.TabIndex = 3;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThem.Location = new System.Drawing.Point(666, 393);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(113, 41);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btChon
            // 
            this.btChon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btChon.Location = new System.Drawing.Point(251, 450);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(155, 41);
            this.btChon.TabIndex = 7;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // txTenNhaCungCap
            // 
            this.txTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTenNhaCungCap.Location = new System.Drawing.Point(825, 86);
            this.txTenNhaCungCap.Name = "txTenNhaCungCap";
            this.txTenNhaCungCap.Size = new System.Drawing.Size(224, 30);
            this.txTenNhaCungCap.TabIndex = 15;
            // 
            // txSoDienThoai
            // 
            this.txSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txSoDienThoai.Location = new System.Drawing.Point(825, 160);
            this.txSoDienThoai.Name = "txSoDienThoai";
            this.txSoDienThoai.Size = new System.Drawing.Size(224, 30);
            this.txSoDienThoai.TabIndex = 14;
            // 
            // txDiaChi
            // 
            this.txDiaChi.Location = new System.Drawing.Point(825, 234);
            this.txDiaChi.Name = "txDiaChi";
            this.txDiaChi.Size = new System.Drawing.Size(224, 122);
            this.txDiaChi.TabIndex = 13;
            this.txDiaChi.Text = "";
            // 
            // txMaNhaCungCap
            // 
            this.txMaNhaCungCap.Enabled = false;
            this.txMaNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txMaNhaCungCap.Location = new System.Drawing.Point(825, 12);
            this.txMaNhaCungCap.Name = "txMaNhaCungCap";
            this.txMaNhaCungCap.Size = new System.Drawing.Size(224, 30);
            this.txMaNhaCungCap.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(666, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(666, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(666, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(666, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSua.Location = new System.Drawing.Point(800, 393);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(113, 41);
            this.btSua.TabIndex = 16;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoa.Location = new System.Drawing.Point(936, 393);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(113, 41);
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // DialogNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1083, 548);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.txTenNhaCungCap);
            this.Controls.Add(this.txSoDienThoai);
            this.Controls.Add(this.txDiaChi);
            this.Controls.Add(this.txMaNhaCungCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.txTuKhoa);
            this.Controls.Add(this.lvNhaCungCap);
            this.Name = "DialogNhaCungCap";
            this.Text = "DialogNhaCungCap";
            this.Load += new System.EventHandler(this.DialogNhaCungCap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvNhaCungCap;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox txTuKhoa;
        private Button btTim;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btThem;
        private Button btChon;
        private TextBox txTenNhaCungCap;
        private TextBox txSoDienThoai;
        private RichTextBox txDiaChi;
        private TextBox txMaNhaCungCap;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btSua;
        private Button btXoa;
    }
}