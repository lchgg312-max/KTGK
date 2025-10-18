using KTGK_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KTGK_1
{
    public partial class Form1 : Form
    {
        private bool sapXepTang = false; // để luân phiên tăng/giảm khi F1
        private List<DiaPhuong> danhSach = new List<DiaPhuong>();

        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện click
            dgvDiaPhuong.CellClick += DgvDiaPhuong_CellClick;
            btnThem.Click += BtnThem_Click;
            btnCapNhat.Click += BtnCapNhat_Click;
            sapXepTheoSoCaNhiemToolStripMenuItem.Click += SapXepTheoSoCaNhiemToolStripMenuItem_Click;
            cacDiaPhuongNhomNguyCoToolStripMenuItem.Click += CacDiaPhuongNhomNguyCoToolStripMenuItem_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTrangThai();
            LoadDiaPhuong();
        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new string[]
            {
                "Bình thường",
                "Bình thường Mới",
                "Cách ly xã hội",
                "Khóa chặt đông cứng"
            });
            cboTrangThai.SelectedIndex = 0;
        }

        private void LoadDiaPhuong()
        {
            // Giả lập dữ liệu ban đầu (vì không kết nối CSDL)
            danhSach = new List<DiaPhuong>()
            {
                new DiaPhuong("BDU","Bình Dương",521,"Bình thường Mới"),
                new DiaPhuong("DAK","ĐắkLak",254,"Cách ly xã hội"),
                new DiaPhuong("DON","Đồng Nai",499,"Khóa chặt đông cứng"),
                new DiaPhuong("HNO","Hà Nội",0,"Bình thường"),
                new DiaPhuong("SGN","Tp. HCM",1140,"Bình thường Mới")
            };

            HienThiLenGrid(danhSach);
        }

        private void HienThiLenGrid(IEnumerable<DiaPhuong> list)
        {
            dgvDiaPhuong.Rows.Clear();
            foreach (var d in list)
            {
                dgvDiaPhuong.Rows.Add(d.MaDP, d.TenDP, d.SoCaNhiemMoi, d.TrangThai);
            }
        }

        // ==========================================
        // 2. Khi click vào dòng DataGridView
        // ==========================================
        private void DgvDiaPhuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDiaPhuong.Rows[e.RowIndex];
                txtMaDiaPhuong.Text = row.Cells["colMDP"].Value?.ToString();
                txtTenDiaPhuong.Text = row.Cells["colTenDP"].Value?.ToString();
                txtSoCaNhiemMoi.Text = row.Cells["colCaNhiem"].Value?.ToString();
                cboTrangThai.Text = row.Cells["colTrangThai"].Value?.ToString();
            }
        }

        // ==========================================
        // 3. Khi click nút Thêm
        // ==========================================
        private void BtnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaDiaPhuong.Text.Trim();
            string ten = txtTenDiaPhuong.Text.Trim();
            string soText = txtSoCaNhiemMoi.Text.Trim();
            string tt = cboTrangThai.Text;

            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(soText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mã hợp lệ
            if (ma.Length != 3 || !int.TryParse(soText, out int so) || so < 0)
            {
                MessageBox.Show("Mã địa phương phải có 3 ký tự và số ca nhiễm ≥ 0", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã
            if (danhSach.Any(d => d.MaDP.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã địa phương đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm mới
            danhSach.Add(new DiaPhuong(ma, ten, so, tt));
            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HienThiLenGrid(danhSach);
            ClearInput();
        }

        // ==========================================
        // 4. Khi click nút Cập nhật
        // ==========================================
        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            string ma = txtMaDiaPhuong.Text.Trim();
            string ten = txtTenDiaPhuong.Text.Trim();
            string soText = txtSoCaNhiemMoi.Text.Trim();
            string tt = cboTrangThai.Text;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Không tìm thấy thông tin địa phương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dp = danhSach.FirstOrDefault(d => d.MaDP.Equals(ma, StringComparison.OrdinalIgnoreCase));
            if (dp == null)
            {
                MessageBox.Show("Không tìm thấy thông tin địa phương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(soText, out int so) || so < 0)
            {
                MessageBox.Show("Số ca nhiễm phải ≥ 0", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu thay đổi trạng thái -> hỏi Yes/No
            if (dp.TrangThai != tt)
            {
                DialogResult dr = MessageBox.Show(
                    $"Địa phương có sự thay đổi về từ {dp.TrangThai} -> {tt}?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                    return;
            }

            // Cập nhật
            dp.TenDP = ten;
            dp.SoCaNhiemMoi = so;
            dp.TrangThai = tt;

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiLenGrid(danhSach);
            ClearInput();
        }

        private void ClearInput()
        {
            txtMaDiaPhuong.Clear();
            txtTenDiaPhuong.Clear();
            txtSoCaNhiemMoi.Clear();
            cboTrangThai.SelectedIndex = 0;
        }

        // ==========================================
        // 5.1 Chức năng F1 - Sắp xếp theo số ca nhiễm
        // ==========================================
        private void SapXepTheoSoCaNhiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!sapXepTang)
                danhSach = danhSach.OrderByDescending(d => d.SoCaNhiemMoi).ToList();
            else
                danhSach = danhSach.OrderBy(d => d.SoCaNhiemMoi).ToList();

            sapXepTang = !sapXepTang;
            HienThiLenGrid(danhSach);
        }

        // ==========================================
        // 5.2 Chức năng F2 - Lọc nhóm nguy cơ
        // ==========================================
        private void CacDiaPhuongNhomNguyCoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nguyCo = danhSach.Where(d => d.TrangThai != "Bình thường").ToList();
            HienThiLenGrid(nguyCo);
        }
    }

    // ==========================================
    // Class dữ liệu đơn giản thay thế cho CSDL
    // ==========================================
    public class DiaPhuong
    {
        public string MaDP { get; set; }
        public string TenDP { get; set; }
        public int SoCaNhiemMoi { get; set; }
        public string TrangThai { get; set; }

        public DiaPhuong(string ma, string ten, int so, string tt)
        {
            MaDP = ma;
            TenDP = ten;
            SoCaNhiemMoi = so;
            TrangThai = tt;
        }
    }
}
