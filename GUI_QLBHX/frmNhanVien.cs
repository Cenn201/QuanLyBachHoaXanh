using BUS_QLBHX;
using DAL_QLBHX;
using ET_QLBHX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBHX
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        //Nhan Vien
        bus_NhanVien nhanvien = new bus_NhanVien();
        public void HienThiNhanVien()
        {
            dgvNhanVien.DataSource=nhanvien.HienThiNhanVien();
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            et_NhanVien et = new et_NhanVien(txtMaNV.Text, txtHoTenNV.Text, cbChucVu.SelectedValue.ToString(), cbBoPhan.SelectedValue.ToString(), dtgNgaySinhNV.Text, rdoNamNV.Text, txtSDTNV.Text, txtDiaChiNV.Text);
            if (nhanvien.ThemNhanVien(et)==true)
            {
                MessageBox.Show("Thêm thành công");
                HienThiNhanVien();

            }
            else
            {
                MessageBox.Show("Thêm that bại");

            }

        }
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            et_NhanVien et = new et_NhanVien(txtMaNV.Text);
            if (nhanvien.XoaNhanVien(et)==true)
            {
                MessageBox.Show("Xoá thành công");
                HienThiNhanVien();

            }
            else
            {
                MessageBox.Show("Xoá that bại");

            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {

                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text=row.Cells[0].Value.ToString();
                txtHoTenNV.Text=row.Cells[1].Value.ToString();
                cbChucVu.Text=HienThiTenChucVu(row.Cells[2].Value.ToString());
                cbBoPhan.Text=HienThiTenBoPhan(row.Cells[3].Value.ToString());
                if (row.Cells[4].Value.ToString()=="Nam")
                {
                    rdoNamNV.Checked=true;
                }
                else
                {
                    rdoNuNV.Checked=true;
                }
                dtgNgaySinhNV.Text=row.Cells[5].Value.ToString();
                txtSDTNV.Text=row.Cells[6].Value.ToString();
                txtDiaChiNV.Text=row.Cells[7].Value.ToString();
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            et_NhanVien et = new et_NhanVien(txtMaNV.Text, txtHoTenNV.Text, cbChucVu.SelectedValue.ToString(), cbBoPhan.SelectedValue.ToString(), dtgNgaySinhNV.Text, rdoNamNV.Text, txtSDTNV.Text, txtDiaChiNV.Text);
            if (nhanvien.SuaNhanVien(et)==true)
            {
                MessageBox.Show("Sửa thành công");
                HienThiNhanVien();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        //ChucVu
        bus_ChucVu chucvu = new bus_ChucVu();
        private void HienThiChucVu()
        {
            cbChucVu.DataSource= chucvu.HienThiChucVu();
            cbChucVu.DisplayMember="TenCV";
            cbChucVu.ValueMember="MaCV";
        }
        private string HienThiTenChucVu(string MaCV)
        {
            return chucvu.HienThiTenChucVu(MaCV);
        }




        //BoPhan
        dal_BoPhan boPhan = new dal_BoPhan();
        private void HienThiBoPhan()
        {
            cbBoPhan.DataSource= boPhan.HienThiBoPhan();
            cbBoPhan.DisplayMember="TenBP";
            cbBoPhan.ValueMember="MaBP";
        }
        private string HienThiTenBoPhan(string MaBP)
        {
            return boPhan.HienThiTenBoPhan(MaBP);
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiBoPhan();
            HienThiChucVu();
            HienThiNhanVien();
        }
    }
}
