using BUS_QLBHX;
using ET_QLBHX;

namespace GUI_QLBHX
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        bus_DangNhap DangNhap=new bus_DangNhap();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            et_DangNhap et = new et_DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            int a = DangNhap.KiemTraDangNhap(et);
            if (a == 1)
            {

                MessageBox.Show("Đăng nhập thành công ", "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Hide();
                frmChucNang frmchucnang = new frmChucNang();
                frmchucnang.Show();


            }
            else if (a == 2)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtMatKhau.Text = "";
                txtMatKhau.Focus();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
            }
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked==true)
                txtMatKhau.PasswordChar=(char)0;
            else txtMatKhau.PasswordChar='*';
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không !!", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop);
            if (r==DialogResult.No)
            {
                e.Cancel=true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}