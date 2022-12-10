namespace GUI
{
    partial class chart
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.chartColumns = new DevExpress.XtraCharts.ChartControl();
            this.lvObj = new System.Windows.Forms.ListView();
            this.ch1 = new System.Windows.Forms.ColumnHeader();
            this.ch2 = new System.Windows.Forms.ColumnHeader();
            this.cbBangThongKe = new System.Windows.Forms.ComboBox();
            this.cbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.chartPies = new DevExpress.XtraCharts.ChartControl();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumns)).BeginInit();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartColumns
            // 
            this.chartColumns.Location = new System.Drawing.Point(574, 480);
            this.chartColumns.Name = "chartColumns";
            this.chartColumns.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartColumns.Size = new System.Drawing.Size(962, 351);
            this.chartColumns.TabIndex = 0;
            // 
            // lvObj
            // 
            this.lvObj.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2});
            this.lvObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvObj.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvObj.Location = new System.Drawing.Point(3, 28);
            this.lvObj.Name = "lvObj";
            this.lvObj.Size = new System.Drawing.Size(523, 279);
            this.lvObj.TabIndex = 2;
            this.lvObj.UseCompatibleStateImageBehavior = false;
            this.lvObj.View = System.Windows.Forms.View.Details;
            this.lvObj.SelectedIndexChanged += new System.EventHandler(this.lvObj_SelectedIndexChanged);
            // 
            // ch1
            // 
            this.ch1.Text = "Tên đối tượng";
            this.ch1.Width = 250;
            // 
            // ch2
            // 
            this.ch2.Text = "Chỉ số";
            this.ch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch2.Width = 250;
            // 
            // cbBangThongKe
            // 
            this.cbBangThongKe.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBangThongKe.FormattingEnabled = true;
            this.cbBangThongKe.ItemHeight = 28;
            this.cbBangThongKe.Items.AddRange(new object[] {
            "Doanh Thu",
            "Chi Tiêu",
            "Sản Phẩm",
            "Khách Hàng",
            "Nhân Viên"});
            this.cbBangThongKe.Location = new System.Drawing.Point(271, 76);
            this.cbBangThongKe.Name = "cbBangThongKe";
            this.cbBangThongKe.Size = new System.Drawing.Size(274, 36);
            this.cbBangThongKe.TabIndex = 4;
            this.cbBangThongKe.Text = "Doanh Thu";
            this.cbBangThongKe.SelectedIndexChanged += new System.EventHandler(this.cbBangThongKe_SelectedIndexChanged);
            // 
            // cbLoaiThongKe
            // 
            this.cbLoaiThongKe.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLoaiThongKe.FormattingEnabled = true;
            this.cbLoaiThongKe.ItemHeight = 28;
            this.cbLoaiThongKe.Items.AddRange(new object[] {
            "Năm",
            "Quý",
            "Tháng",
            "Ngày"});
            this.cbLoaiThongKe.Location = new System.Drawing.Point(271, 144);
            this.cbLoaiThongKe.Name = "cbLoaiThongKe";
            this.cbLoaiThongKe.Size = new System.Drawing.Size(274, 36);
            this.cbLoaiThongKe.TabIndex = 1;
            this.cbLoaiThongKe.Text = "Năm";
            this.cbLoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cbLoaiThongKe_SelectedIndexChanged);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.lvObj);
            this.gb2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb2.ForeColor = System.Drawing.Color.Navy;
            this.gb2.Location = new System.Drawing.Point(19, 521);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(529, 310);
            this.gb2.TabIndex = 4;
            this.gb2.TabStop = false;
            this.gb2.Text = "Bảng xếp hạng chi tiết từ cao đến thấp";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpThoiGian.Location = new System.Drawing.Point(271, 212);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(274, 35);
            this.dtpThoiGian.TabIndex = 7;
            this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dtpThoiGian_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(25, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bảng thống kê:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(25, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thống kê theo:";
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbThoiGian.ForeColor = System.Drawing.Color.Navy;
            this.lbThoiGian.Location = new System.Drawing.Point(25, 220);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(205, 24);
            this.lbThoiGian.TabIndex = 10;
            this.lbThoiGian.Text = "Thời gian thống kê:";
            // 
            // chartPies
            // 
            this.chartPies.Location = new System.Drawing.Point(574, 31);
            this.chartPies.Name = "chartPies";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartPies.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartPies.Size = new System.Drawing.Size(959, 443);
            this.chartPies.TabIndex = 11;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Lime;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(141, 372);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(247, 65);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Trở Về Trang Chính";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // chart
            // 
            this.Appearance.BackColor = System.Drawing.Color.Coral;
            this.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 843);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.chartPies);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.cbLoaiThongKe);
            this.Controls.Add(this.cbBangThongKe);
            this.Controls.Add(this.chartColumns);
            this.Name = "chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartColumns)).EndInit();
            this.gb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartColumns;
        private ListView lvObj;
        private ComboBox cbBangThongKe;
        private ComboBox cbLoaiThongKe;
        private GroupBox gb2;
        private DateTimePicker dtpThoiGian;
        private Label label1;
        private Label label2;
        private Label lbThoiGian;
        private ColumnHeader ch1;
        private ColumnHeader ch2;
        private DevExpress.XtraCharts.ChartControl chartPies;
        private Button btnHome;
    }
}