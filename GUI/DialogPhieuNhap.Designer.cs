namespace GUI
{
    partial class DialogPhieuNhap
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
            this.tblSP = new System.Windows.Forms.TableLayoutPanel();
            this.lvSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMPN = new System.Windows.Forms.Label();
            this.lbTNV = new System.Windows.Forms.Label();
            this.lbNL = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txMPN = new System.Windows.Forms.Label();
            this.txTNV = new System.Windows.Forms.Label();
            this.txNL = new System.Windows.Forms.Label();
            this.txTongTien = new System.Windows.Forms.Label();
            this.tblSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHIẾU NHẬP";
            // 
            // tblSP
            // 
            this.tblSP.AutoSize = true;
            this.tblSP.ColumnCount = 1;
            this.tblSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSP.Controls.Add(this.lvSP, 0, 0);
            this.tblSP.Location = new System.Drawing.Point(12, 166);
            this.tblSP.Name = "tblSP";
            this.tblSP.RowCount = 1;
            this.tblSP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSP.Size = new System.Drawing.Size(549, 170);
            this.tblSP.TabIndex = 1;
            // 
            // lvSP
            // 
            this.lvSP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvSP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvSP.Location = new System.Drawing.Point(3, 3);
            this.lvSP.Name = "lvSP";
            this.lvSP.Size = new System.Drawing.Size(543, 164);
            this.lvSP.TabIndex = 0;
            this.lvSP.UseCompatibleStateImageBehavior = false;
            this.lvSP.View = System.Windows.Forms.View.Details;
            this.lvSP.SelectedIndexChanged += new System.EventHandler(this.lvSP_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SP";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SP";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành tiền";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "========================================================";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "========================================================";
            // 
            // lbMPN
            // 
            this.lbMPN.AutoSize = true;
            this.lbMPN.Location = new System.Drawing.Point(15, 44);
            this.lbMPN.Name = "lbMPN";
            this.lbMPN.Size = new System.Drawing.Size(108, 20);
            this.lbMPN.TabIndex = 4;
            this.lbMPN.Text = "Mã phiếu nhập";
            // 
            // lbTNV
            // 
            this.lbTNV.AutoSize = true;
            this.lbTNV.Location = new System.Drawing.Point(15, 77);
            this.lbTNV.Name = "lbTNV";
            this.lbTNV.Size = new System.Drawing.Size(99, 20);
            this.lbTNV.TabIndex = 5;
            this.lbTNV.Text = "Tên nhân viên";
            // 
            // lbNL
            // 
            this.lbNL.AutoSize = true;
            this.lbNL.Location = new System.Drawing.Point(15, 110);
            this.lbNL.Name = "lbNL";
            this.lbNL.Size = new System.Drawing.Size(69, 20);
            this.lbNL.TabIndex = 6;
            this.lbNL.Text = "Ngày lập";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(15, 359);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(72, 20);
            this.lbTongTien.TabIndex = 7;
            this.lbTongTien.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(569, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "========================================================";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(499, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cảm ơn quý khách đã sử dụng dịch vụ. Xin cảm ơn!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(569, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "========================================================";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(215, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "HẸN GẶP LẠI!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(100, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "In Phiếu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(363, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txMPN
            // 
            this.txMPN.AutoSize = true;
            this.txMPN.Location = new System.Drawing.Point(159, 44);
            this.txMPN.Name = "txMPN";
            this.txMPN.Size = new System.Drawing.Size(45, 20);
            this.txMPN.TabIndex = 14;
            this.txMPN.Text = "None";
            // 
            // txTNV
            // 
            this.txTNV.AutoSize = true;
            this.txTNV.Location = new System.Drawing.Point(159, 77);
            this.txTNV.Name = "txTNV";
            this.txTNV.Size = new System.Drawing.Size(45, 20);
            this.txTNV.TabIndex = 15;
            this.txTNV.Text = "None";
            // 
            // txNL
            // 
            this.txNL.AutoSize = true;
            this.txNL.Location = new System.Drawing.Point(159, 110);
            this.txNL.Name = "txNL";
            this.txNL.Size = new System.Drawing.Size(45, 20);
            this.txNL.TabIndex = 16;
            this.txNL.Text = "None";
            // 
            // txTongTien
            // 
            this.txTongTien.AutoSize = true;
            this.txTongTien.Location = new System.Drawing.Point(159, 359);
            this.txTongTien.Name = "txTongTien";
            this.txTongTien.Size = new System.Drawing.Size(45, 20);
            this.txTongTien.TabIndex = 17;
            this.txTongTien.Text = "None";
            // 
            // DialogPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 533);
            this.Controls.Add(this.txTongTien);
            this.Controls.Add(this.txNL);
            this.Controls.Add(this.txTNV);
            this.Controls.Add(this.txMPN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbNL);
            this.Controls.Add(this.lbTNV);
            this.Controls.Add(this.lbMPN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblSP);
            this.Controls.Add(this.label1);
            this.Name = "DialogPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogPhieuNhap";
            this.Load += new System.EventHandler(this.DialogPhieuNhap_Load);
            this.tblSP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TableLayoutPanel tblSP;
        private ListView lvSP;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label2;
        private Label label3;
        private Label lbMPN;
        private Label lbTNV;
        private Label lbNL;
        private Label lbTongTien;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Label txMPN;
        private Label txTNV;
        private Label txNL;
        private Label txTongTien;
    }
}