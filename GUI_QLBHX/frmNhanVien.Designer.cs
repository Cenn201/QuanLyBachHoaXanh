namespace GUI_QLBHX
{
    partial class frmNhanVien
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtgNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.rdoNuNV = new System.Windows.Forms.RadioButton();
            this.rdoNamNV = new System.Windows.Forms.RadioButton();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cbBoPhan = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(95, 499);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(1606, 161);
            this.dgvNhanVien.TabIndex = 17;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // groupBox16
            // 
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox16.Location = new System.Drawing.Point(0, 499);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox16.Size = new System.Drawing.Size(95, 161);
            this.groupBox16.TabIndex = 15;
            this.groupBox16.TabStop = false;
            // 
            // groupBox17
            // 
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox17.Location = new System.Drawing.Point(1701, 499);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox17.Size = new System.Drawing.Size(123, 161);
            this.groupBox17.TabIndex = 16;
            this.groupBox17.TabStop = false;
            // 
            // groupBox15
            // 
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox15.Location = new System.Drawing.Point(0, 660);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox15.Size = new System.Drawing.Size(1824, 93);
            this.groupBox15.TabIndex = 14;
            this.groupBox15.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox14);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1824, 499);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtgNgaySinhNV);
            this.groupBox7.Controls.Add(this.rdoNuNV);
            this.groupBox7.Controls.Add(this.rdoNamNV);
            this.groupBox7.Controls.Add(this.txtDiaChiNV);
            this.groupBox7.Controls.Add(this.txtSDTNV);
            this.groupBox7.Controls.Add(this.txtHoTenNV);
            this.groupBox7.Controls.Add(this.txtMaNV);
            this.groupBox7.Controls.Add(this.btnSuaNV);
            this.groupBox7.Controls.Add(this.btnXoaNV);
            this.groupBox7.Controls.Add(this.btnThemNV);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox7.Location = new System.Drawing.Point(514, 41);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(1268, 430);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thông Tin Nhân Viên";
            // 
            // dtgNgaySinhNV
            // 
            this.dtgNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtgNgaySinhNV.Location = new System.Drawing.Point(845, 37);
            this.dtgNgaySinhNV.Margin = new System.Windows.Forms.Padding(4);
            this.dtgNgaySinhNV.Name = "dtgNgaySinhNV";
            this.dtgNgaySinhNV.Size = new System.Drawing.Size(305, 34);
            this.dtgNgaySinhNV.TabIndex = 18;
            // 
            // rdoNuNV
            // 
            this.rdoNuNV.AutoSize = true;
            this.rdoNuNV.Location = new System.Drawing.Point(419, 228);
            this.rdoNuNV.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNuNV.Name = "rdoNuNV";
            this.rdoNuNV.Size = new System.Drawing.Size(67, 33);
            this.rdoNuNV.TabIndex = 17;
            this.rdoNuNV.TabStop = true;
            this.rdoNuNV.Text = "Nữ";
            this.rdoNuNV.UseVisualStyleBackColor = true;
            // 
            // rdoNamNV
            // 
            this.rdoNamNV.AutoSize = true;
            this.rdoNamNV.Location = new System.Drawing.Point(218, 226);
            this.rdoNamNV.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNamNV.Name = "rdoNamNV";
            this.rdoNamNV.Size = new System.Drawing.Size(88, 33);
            this.rdoNamNV.TabIndex = 16;
            this.rdoNamNV.TabStop = true;
            this.rdoNamNV.Text = "Nam";
            this.rdoNamNV.UseVisualStyleBackColor = true;
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Location = new System.Drawing.Point(845, 222);
            this.txtDiaChiNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(305, 34);
            this.txtDiaChiNV.TabIndex = 11;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(845, 132);
            this.txtSDTNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(305, 34);
            this.txtSDTNV.TabIndex = 11;
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(217, 138);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(280, 34);
            this.txtHoTenNV.TabIndex = 11;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(220, 44);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(280, 34);
            this.txtMaNV.TabIndex = 11;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(445, 324);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(194, 53);
            this.btnSuaNV.TabIndex = 10;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(806, 324);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(194, 53);
            this.btnXoaNV.TabIndex = 9;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(117, 324);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(194, 53);
            this.btnThemNV.TabIndex = 8;
            this.btnThemNV.Text = "Thêm ";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(653, 226);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 29);
            this.label21.TabIndex = 5;
            this.label21.Text = "Địa Chỉ :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(653, 133);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 29);
            this.label20.TabIndex = 4;
            this.label20.Text = "SĐT :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(645, 45);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 29);
            this.label19.TabIndex = 3;
            this.label19.Text = "Ngày Sinh :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(49, 231);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 29);
            this.label18.TabIndex = 2;
            this.label18.Text = "Giới Tính :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 133);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 29);
            this.label17.TabIndex = 1;
            this.label17.Text = "Họ Tên :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 45);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 29);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã NV :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbChucVu);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(48, 262);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(459, 209);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông Tin Chức vụ";
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(174, 103);
            this.cbChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(246, 37);
            this.cbChucVu.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 104);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "Chức Vụ :";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.cbBoPhan);
            this.groupBox14.Controls.Add(this.label14);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox14.Location = new System.Drawing.Point(48, 35);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox14.Size = new System.Drawing.Size(459, 219);
            this.groupBox14.TabIndex = 8;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Thông Tin Bộ Phận";
            // 
            // cbBoPhan
            // 
            this.cbBoPhan.FormattingEnabled = true;
            this.cbBoPhan.Location = new System.Drawing.Point(180, 91);
            this.cbBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.cbBoPhan.Name = "cbBoPhan";
            this.cbBoPhan.Size = new System.Drawing.Size(246, 37);
            this.cbBoPhan.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 96);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Bộ Phận :";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 753);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox17);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox5;
        private GroupBox groupBox7;
        private DateTimePicker dtgNgaySinhNV;
        private RadioButton rdoNuNV;
        private RadioButton rdoNamNV;
        private TextBox txtDiaChiNV;
        private TextBox txtSDTNV;
        private TextBox txtHoTenNV;
        private TextBox txtMaNV;
        private Button btnSuaNV;
        private Button btnXoaNV;
        private Button btnThemNV;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private GroupBox groupBox6;
        private ComboBox cbChucVu;
        private Label label15;
        private GroupBox groupBox14;
        private ComboBox cbBoPhan;
        private Label label14;
        private DataGridView dgvNhanVien;
        private GroupBox groupBox16;
        private GroupBox groupBox17;
        private GroupBox groupBox15;
    }
}