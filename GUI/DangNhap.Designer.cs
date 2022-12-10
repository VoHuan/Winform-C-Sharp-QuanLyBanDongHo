namespace GUI
{
    partial class DangNhap
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
            this.tbTenDangNhap = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.cbxDangNhap = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lbQuenMatKhau = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.pbPassWord = new System.Windows.Forms.PictureBox();
            this.pbEyeOpen = new System.Windows.Forms.PictureBox();
            this.pbEyeClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEyeOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEyeClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(155, 397);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTenDangNhap.Location = new System.Drawing.Point(189, 485);
            this.tbTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.Size = new System.Drawing.Size(250, 34);
            this.tbTenDangNhap.TabIndex = 3;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMatKhau.Location = new System.Drawing.Point(189, 540);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(250, 34);
            this.tbMatKhau.TabIndex = 4;
            // 
            // cbxDangNhap
            // 
            this.cbxDangNhap.AutoSize = true;
            this.cbxDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbxDangNhap.Location = new System.Drawing.Point(189, 580);
            this.cbxDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDangNhap.Name = "cbxDangNhap";
            this.cbxDangNhap.Size = new System.Drawing.Size(153, 24);
            this.cbxDangNhap.TabIndex = 5;
            this.cbxDangNhap.Text = "Ghi nhớ đăng nhập";
            this.cbxDangNhap.UseVisualStyleBackColor = true;
            this.cbxDangNhap.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Lime;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangNhap.Location = new System.Drawing.Point(115, 631);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(404, 52);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lbQuenMatKhau
            // 
            this.lbQuenMatKhau.AutoSize = true;
            this.lbQuenMatKhau.BackColor = System.Drawing.Color.Coral;
            this.lbQuenMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbQuenMatKhau.Location = new System.Drawing.Point(260, 694);
            this.lbQuenMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuenMatKhau.Name = "lbQuenMatKhau";
            this.lbQuenMatKhau.Size = new System.Drawing.Size(114, 20);
            this.lbQuenMatKhau.TabIndex = 7;
            this.lbQuenMatKhau.Text = "Quên mật khẩu?";
            this.lbQuenMatKhau.Click += new System.EventHandler(this.lbQuenMatKhau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GUI.Properties.Resources.watch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.Image = global::GUI.Properties.Resources.user1;
            this.pbUserIcon.Location = new System.Drawing.Point(115, 463);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(69, 60);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserIcon.TabIndex = 9;
            this.pbUserIcon.TabStop = false;
            // 
            // pbPassWord
            // 
            this.pbPassWord.Image = global::GUI.Properties.Resources.pwd;
            this.pbPassWord.Location = new System.Drawing.Point(115, 529);
            this.pbPassWord.Name = "pbPassWord";
            this.pbPassWord.Size = new System.Drawing.Size(69, 49);
            this.pbPassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassWord.TabIndex = 10;
            this.pbPassWord.TabStop = false;
            // 
            // pbEyeOpen
            // 
            this.pbEyeOpen.BackColor = System.Drawing.SystemColors.Window;
            this.pbEyeOpen.Image = global::GUI.Properties.Resources.eye_open;
            this.pbEyeOpen.Location = new System.Drawing.Point(411, 547);
            this.pbEyeOpen.Name = "pbEyeOpen";
            this.pbEyeOpen.Size = new System.Drawing.Size(25, 22);
            this.pbEyeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEyeOpen.TabIndex = 11;
            this.pbEyeOpen.TabStop = false;
            this.pbEyeOpen.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pbEyeClose
            // 
            this.pbEyeClose.BackColor = System.Drawing.SystemColors.Window;
            this.pbEyeClose.Image = global::GUI.Properties.Resources.eye_close_1;
            this.pbEyeClose.Location = new System.Drawing.Point(411, 547);
            this.pbEyeClose.Name = "pbEyeClose";
            this.pbEyeClose.Size = new System.Drawing.Size(25, 22);
            this.pbEyeClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEyeClose.TabIndex = 12;
            this.pbEyeClose.TabStop = false;
            this.pbEyeClose.Click += new System.EventHandler(this.pbEyeClose_Click);
            // 
            // DangNhap
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(604, 772);
            this.Controls.Add(this.pbEyeClose);
            this.Controls.Add(this.pbEyeOpen);
            this.Controls.Add(this.pbPassWord);
            this.Controls.Add(this.pbUserIcon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbQuenMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.cbxDangNhap);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTenDangNhap);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEyeOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEyeClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbTenDangNhap;
        private TextBox tbMatKhau;
        private CheckBox cbxDangNhap;
        private Button btnDangNhap;
        private Label lbQuenMatKhau;
        private PictureBox pictureBox1;
        private PictureBox pbUserIcon;
        private PictureBox pbPassWord;
        private PictureBox pbEyeOpen;
        private PictureBox pbEyeClose;
    }
}