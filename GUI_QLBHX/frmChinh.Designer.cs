namespace GUI_QLBHX
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.Thoatitem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.qlkhitem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlnv = new System.Windows.Forms.ToolStripMenuItem();
            this.qlhhitem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlpxitem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlpnitem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.dxitem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHeThong,
            this.tsmiQuanLy,
            this.tsmiDangNhap,
            this.tsmiThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1882, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiHeThong
            // 
            this.tsmiHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Thoatitem});
            this.tsmiHeThong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmiHeThong.Image = global::GUI_QLBHX.Properties.Resources._2630878;
            this.tsmiHeThong.Name = "tsmiHeThong";
            this.tsmiHeThong.Size = new System.Drawing.Size(149, 36);
            this.tsmiHeThong.Text = "Hệ thống";
            // 
            // Thoatitem
            // 
            this.Thoatitem.Image = global::GUI_QLBHX.Properties.Resources.Windows_Close_Program_icon;
            this.Thoatitem.Name = "Thoatitem";
            this.Thoatitem.Size = new System.Drawing.Size(163, 36);
            this.Thoatitem.Text = "Thoát";
            // 
            // tsmiQuanLy
            // 
            this.tsmiQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlkhitem,
            this.qlnv,
            this.qlhhitem,
            this.qlpxitem,
            this.qlpnitem});
            this.tsmiQuanLy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmiQuanLy.Image = global::GUI_QLBHX.Properties.Resources.pngtree_vector_user_management_icon_png_image_3773556;
            this.tsmiQuanLy.Name = "tsmiQuanLy";
            this.tsmiQuanLy.Size = new System.Drawing.Size(131, 36);
            this.tsmiQuanLy.Text = "Quản lý";
            // 
            // qlkhitem
            // 
            this.qlkhitem.Image = global::GUI_QLBHX.Properties.Resources.shopping_girl_icon;
            this.qlkhitem.Name = "qlkhitem";
            this.qlkhitem.Size = new System.Drawing.Size(228, 36);
            this.qlkhitem.Text = "Khách hàng";
            this.qlkhitem.Click += new System.EventHandler(this.qlkhitem_Click);
            // 
            // qlnv
            // 
            this.qlnv.Image = global::GUI_QLBHX.Properties.Resources._148_1482312_employees_icon_download_employee_management_system_logo_png;
            this.qlnv.Name = "qlnv";
            this.qlnv.Size = new System.Drawing.Size(228, 36);
            this.qlnv.Text = "Nhân viên";
            this.qlnv.Click += new System.EventHandler(this.qlnv_Click);
            // 
            // qlhhitem
            // 
            this.qlhhitem.Image = global::GUI_QLBHX.Properties.Resources.download;
            this.qlhhitem.Name = "qlhhitem";
            this.qlhhitem.Size = new System.Drawing.Size(228, 36);
            this.qlhhitem.Text = "Hàng hoá";
            // 
            // qlpxitem
            // 
            this.qlpxitem.Image = global::GUI_QLBHX.Properties.Resources.nhân_viên_kho;
            this.qlpxitem.Name = "qlpxitem";
            this.qlpxitem.Size = new System.Drawing.Size(228, 36);
            this.qlpxitem.Text = "Phiếu xuất";
            // 
            // qlpnitem
            // 
            this.qlpnitem.Image = global::GUI_QLBHX.Properties.Resources.mo_ta_cong_viec_nhan_vien_kho_lam_gi;
            this.qlpnitem.Name = "qlpnitem";
            this.qlpnitem.Size = new System.Drawing.Size(228, 36);
            this.qlpnitem.Text = "Phiếu nhập";
            // 
            // tsmiDangNhap
            // 
            this.tsmiDangNhap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dxitem});
            this.tsmiDangNhap.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmiDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDangNhap.Image")));
            this.tsmiDangNhap.Name = "tsmiDangNhap";
            this.tsmiDangNhap.Size = new System.Drawing.Size(149, 36);
            this.tsmiDangNhap.Text = "Tài khoản";
            // 
            // dxitem
            // 
            this.dxitem.Image = global::GUI_QLBHX.Properties.Resources.logout_icon__1_;
            this.dxitem.Name = "dxitem";
            this.dxitem.Size = new System.Drawing.Size(211, 36);
            this.dxitem.Text = "Đăng xuất";
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmiThoat.Image = global::GUI_QLBHX.Properties.Resources.Windows_Close_Program_icon;
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.Size = new System.Drawing.Size(109, 36);
            this.tsmiThoat.Text = "Thoát";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 753);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Quản lý siêu thị bách hoá xanh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiHeThong;
        private ToolStripMenuItem tsmiQuanLy;
        private ToolStripMenuItem tsmiDangNhap;
        private ToolStripMenuItem tsmiThoat;
        private ToolStripMenuItem qlkhitem;
        private ToolStripMenuItem qlnv;
        private ToolStripMenuItem qlhhitem;
        private ToolStripMenuItem qlpxitem;
        private ToolStripMenuItem qlpnitem;
        private ToolStripMenuItem dxitem;
        private ToolStripMenuItem Thoatitem;
    }
}