namespace KTGK_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sapXepTheoSoCaNhiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatBaoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtSoCaNhiemMoi = new System.Windows.Forms.TextBox();
            this.txtTenDiaPhuong = new System.Windows.Forms.TextBox();
            this.txtMaDiaPhuong = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSoCaNhiemMoi = new System.Windows.Forms.Label();
            this.lblTenDiaPhuong = new System.Windows.Forms.Label();
            this.lblMaDiaPhuong = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvDiaPhuong = new System.Windows.Forms.DataGridView();
            this.colMDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaNhiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaPhuong)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sapXepTheoSoCaNhiemToolStripMenuItem,
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem,
            this.xuatBaoCaoToolStripMenuItem});
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.chucNangToolStripMenuItem.Text = "Chức năng";
            // 
            // sapXepTheoSoCaNhiemToolStripMenuItem
            // 
            this.sapXepTheoSoCaNhiemToolStripMenuItem.Name = "sapXepTheoSoCaNhiemToolStripMenuItem";
            this.sapXepTheoSoCaNhiemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.sapXepTheoSoCaNhiemToolStripMenuItem.Size = new System.Drawing.Size(392, 34);
            this.sapXepTheoSoCaNhiemToolStripMenuItem.Text = "Sắp xếp theo số ca nhiễm";
            // 
            // cacDiaPhuongNhomNguyCoToolStripMenuItem
            // 
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem.Name = "cacDiaPhuongNhomNguyCoToolStripMenuItem";
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem.Size = new System.Drawing.Size(392, 34);
            this.cacDiaPhuongNhomNguyCoToolStripMenuItem.Text = "Các địa phương nhóm nguy cơ";
            // 
            // xuatBaoCaoToolStripMenuItem
            // 
            this.xuatBaoCaoToolStripMenuItem.Name = "xuatBaoCaoToolStripMenuItem";
            this.xuatBaoCaoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuatBaoCaoToolStripMenuItem.Size = new System.Drawing.Size(392, 34);
            this.xuatBaoCaoToolStripMenuItem.Text = "Xuất Báo cáo";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(300, 40);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(416, 40);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Tình hình dịch Covid 19";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.txtSoCaNhiemMoi);
            this.groupBox1.Controls.Add(this.txtTenDiaPhuong);
            this.groupBox1.Controls.Add(this.txtMaDiaPhuong);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.lblSoCaNhiemMoi);
            this.groupBox1.Controls.Add(this.lblTenDiaPhuong);
            this.groupBox1.Controls.Add(this.lblMaDiaPhuong);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin địa phương";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Bình thường",
            "Bình thường Mới",
            "Cách ly xã hội",
            "Khóa chặt đông cứng"});
            this.cboTrangThai.Location = new System.Drawing.Point(138, 173);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(120, 28);
            this.cboTrangThai.TabIndex = 0;
            // 
            // txtSoCaNhiemMoi
            // 
            this.txtSoCaNhiemMoi.Location = new System.Drawing.Point(138, 125);
            this.txtSoCaNhiemMoi.Name = "txtSoCaNhiemMoi";
            this.txtSoCaNhiemMoi.Size = new System.Drawing.Size(120, 26);
            this.txtSoCaNhiemMoi.TabIndex = 1;
            // 
            // txtTenDiaPhuong
            // 
            this.txtTenDiaPhuong.Location = new System.Drawing.Point(138, 82);
            this.txtTenDiaPhuong.Name = "txtTenDiaPhuong";
            this.txtTenDiaPhuong.Size = new System.Drawing.Size(120, 26);
            this.txtTenDiaPhuong.TabIndex = 2;
            // 
            // txtMaDiaPhuong
            // 
            this.txtMaDiaPhuong.Location = new System.Drawing.Point(138, 36);
            this.txtMaDiaPhuong.Name = "txtMaDiaPhuong";
            this.txtMaDiaPhuong.Size = new System.Drawing.Size(120, 26);
            this.txtMaDiaPhuong.TabIndex = 3;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(10, 176);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(84, 20);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // lblSoCaNhiemMoi
            // 
            this.lblSoCaNhiemMoi.AutoSize = true;
            this.lblSoCaNhiemMoi.Location = new System.Drawing.Point(10, 131);
            this.lblSoCaNhiemMoi.Name = "lblSoCaNhiemMoi";
            this.lblSoCaNhiemMoi.Size = new System.Drawing.Size(126, 20);
            this.lblSoCaNhiemMoi.TabIndex = 5;
            this.lblSoCaNhiemMoi.Text = "Số ca nhiễm mới";
            // 
            // lblTenDiaPhuong
            // 
            this.lblTenDiaPhuong.AutoSize = true;
            this.lblTenDiaPhuong.Location = new System.Drawing.Point(10, 88);
            this.lblTenDiaPhuong.Name = "lblTenDiaPhuong";
            this.lblTenDiaPhuong.Size = new System.Drawing.Size(123, 20);
            this.lblTenDiaPhuong.TabIndex = 6;
            this.lblTenDiaPhuong.Text = "Tên Địa Phương";
            // 
            // lblMaDiaPhuong
            // 
            this.lblMaDiaPhuong.AutoSize = true;
            this.lblMaDiaPhuong.Location = new System.Drawing.Point(10, 42);
            this.lblMaDiaPhuong.Name = "lblMaDiaPhuong";
            this.lblMaDiaPhuong.Size = new System.Drawing.Size(118, 20);
            this.lblMaDiaPhuong.TabIndex = 7;
            this.lblMaDiaPhuong.Text = "Mã Địa Phương";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(28, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(150, 234);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 30);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            // 
            // dgvDiaPhuong
            // 
            this.dgvDiaPhuong.AllowUserToAddRows = false;
            this.dgvDiaPhuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaPhuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMDP,
            this.colTenDP,
            this.colCaNhiem,
            this.colTrangThai});
            this.dgvDiaPhuong.Location = new System.Drawing.Point(307, 99);
            this.dgvDiaPhuong.Name = "dgvDiaPhuong";
            this.dgvDiaPhuong.RowHeadersWidth = 62;
            this.dgvDiaPhuong.Size = new System.Drawing.Size(664, 328);
            this.dgvDiaPhuong.TabIndex = 3;
            // 
            // colMDP
            // 
            this.colMDP.HeaderText = "MDP";
            this.colMDP.MinimumWidth = 8;
            this.colMDP.Name = "colMDP";
            this.colMDP.Width = 150;
            // 
            // colTenDP
            // 
            this.colTenDP.HeaderText = "Tên ĐP";
            this.colTenDP.MinimumWidth = 8;
            this.colTenDP.Name = "colTenDP";
            this.colTenDP.Width = 180;
            // 
            // colCaNhiem
            // 
            this.colCaNhiem.HeaderText = "Ca nhiễm";
            this.colCaNhiem.MinimumWidth = 8;
            this.colCaNhiem.Name = "colCaNhiem";
            this.colCaNhiem.Width = 150;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 180;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.dgvDiaPhuong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Thông tin địa phương";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaPhuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sapXepTheoSoCaNhiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacDiaPhuongNhomNguyCoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuatBaoCaoToolStripMenuItem;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtSoCaNhiemMoi;
        private System.Windows.Forms.TextBox txtTenDiaPhuong;
        private System.Windows.Forms.TextBox txtMaDiaPhuong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSoCaNhiemMoi;
        private System.Windows.Forms.Label lblTenDiaPhuong;
        private System.Windows.Forms.Label lblMaDiaPhuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvDiaPhuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaNhiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}