using BUS_QLBHX;
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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }
        //KhachHang
        bus_KhachHang khachHang = new bus_KhachHang();
        public void HienThiKhachHang()
        {
            dgvKhachHang.DataSource=khachHang.HienThiKhachHang();
        }
        private void btn_Them_Click(object sender, EventArgs e)

        {
            bool a = false;
            string GioiTinh = null;
            if (rdoNamKH.Checked==true)
                GioiTinh=rdoNamKH.Text;
            else if (rdoNuKH.Checked==true)
                GioiTinh=rdoNuKH.Text;

            et_KhachHang a1 = new et_KhachHang(txtMaKH.Text,
                                               txtHoTenKH.Text,
                                               dtpNamSinhKH.Text,
                                               GioiTinh,
                                               txtDiaChiKH.Text,
                                               txtSDTKH.Text,
                                               txtCCCDKH.Text,
                                               txtSTKKH.Text,
                                               txtMaSoThueKH.Text);
            a= khachHang.ThemKhachHang(a1);



            if (a==true)
            {
                MessageBox.Show("Thêm vào thành công!!");
                format();
                HienThiKhachHang();
            }
            else
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }
        public void format()
        {
            txtMaKH.Text=null;
            txtHoTenKH.Text=null;
            txtDiaChiKH.Text=null;
            txtSDTKH.Text=null;
            txtCCCDKH.Text=null;
            txtSTKKH.Text=null;
            txtMaSoThueKH.Text=null;
        }
        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            et_KhachHang et = new et_KhachHang(txtMaKH.Text);
            if (khachHang.XoaKhachHang(et)==true)
            {
                MessageBox.Show("Xoá thành công");
                format();
                HienThiKhachHang();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text=row.Cells[0].Value.ToString();
                txtHoTenKH.Text=row.Cells[1].Value.ToString();
                dtpNamSinhKH.Text=row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString()=="Nam")
                {
                    rdoNamKH.Checked=true;
                }
                else
                {
                    rdoNuKH.Checked=true;
                }
                txtSDTKH.Text=row.Cells[4].Value.ToString();
                txtDiaChiKH.Text=row.Cells[5].Value.ToString();
                txtCCCDKH.Text=row.Cells[6].Value.ToString();
                txtSTKKH.Text=row.Cells[7].Value.ToString();
                txtMaSoThueKH.Text=row.Cells[8].Value.ToString();
            }
        }
        private void btnSuaKH_Click(object sender, EventArgs e)
        {

            string GioiTinh = null;
            if (rdoNamKH.Checked==true)
                GioiTinh=rdoNamKH.Text;
            else if (rdoNuKH.Checked==true)
                GioiTinh=rdoNuKH.Text;
            et_KhachHang et = new et_KhachHang(txtMaKH.Text,
                                               txtHoTenKH.Text,
                                               dtpNamSinhKH.Text,
                                               GioiTinh,
                                               txtDiaChiKH.Text,
                                               txtSDTKH.Text,
                                               txtCCCDKH.Text,
                                               txtSTKKH.Text,
                                               txtMaSoThueKH.Text);
            if (khachHang.SuaKhachHang(et)==true)
            {
                MessageBox.Show("Sửa thành công");
                HienThiKhachHang();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        //

    }
}
