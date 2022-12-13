namespace ET_QLBHX
{
    public class et_DangNhap
    {
        private string _MaNV;
        private string _TenTaiKhoan;
        private string _MatKhau;
        private string _MatKhauMoi;

        public et_DangNhap(string maNV, string tenTaiKhoan, string matKhau)
        {
            MaNV=maNV;
            TenTaiKhoan=tenTaiKhoan;
            MatKhau=matKhau;
        }
        public et_DangNhap(string tenTaiKhoan, string matKhau)
        {
            TenTaiKhoan=tenTaiKhoan;
            MatKhau=matKhau;
        }
        public et_DangNhap(string matKhauMoi)
        {
            MatKhauMoi=matKhauMoi;
        }

        public string MaNV
        {
            get => _MaNV;
            set => _MaNV=value;
        }
        public string TenTaiKhoan
        {
            get => _TenTaiKhoan;
            set => _TenTaiKhoan=value;
        }
        public string MatKhau
        {
            get => _MatKhau;
            set => _MatKhau=value;
        }
        public string MatKhauMoi
        {
            get => _MatKhauMoi;
            set => _MatKhauMoi=value;
        }
    }
}