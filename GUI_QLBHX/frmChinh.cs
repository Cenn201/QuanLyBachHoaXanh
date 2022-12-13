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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void qlkhitem_Click(object sender, EventArgs e)
        {
            frmKhachHang khachHang= new frmKhachHang();
            if(CheckExistForm(khachHang.Name)==true)
            {
            khachHang.MdiParent= this;
            khachHang.Show();

            }

        }
        private bool CheckExistForm(string Name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == Name)
                {
                    return false;
                }
            }
            return true;
        }

        private void qlnv_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanVien= new frmNhanVien();
            if (CheckExistForm(nhanVien.Name)==true)
            {
                nhanVien.MdiParent= this;
                nhanVien.Show();

            }
        }

    }
}
