using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBHX
{
    public class et_NhanVien
    {
        private string _MaNV, _TenNV, _ChucVu, _BoPhan, _NgaySinh, _GioiTinh, _SDTNV, _DiaChi;

        public et_NhanVien(string maNV)
        {
            _MaNV=maNV;
        }

        public et_NhanVien(string maNV, string tenNV, string chucVu, string boPhan, string ngaySinh, string gioiTinh, string sDTNV, string diaChi)
        {
            _MaNV=maNV;
            _TenNV=tenNV;
            _ChucVu=chucVu;
            _BoPhan=boPhan;
            _NgaySinh=ngaySinh;
            _GioiTinh=gioiTinh;
            _SDTNV=sDTNV;
            _DiaChi=diaChi;
        }

        public string MaNV
        {
            get => _MaNV;
            set => _MaNV=value;
        }
        public string TenNV
        {
            get => _TenNV;
            set => _TenNV=value;
        }
        public string ChucVu
        {
            get => _ChucVu;
            set => _ChucVu=value;
        }
        public string BoPhan
        {
            get => _BoPhan;
            set => _BoPhan=value;
        }
        public string NgaySinh
        {
            get => _NgaySinh;
            set => _NgaySinh=value;
        }
        public string GioiTinh
        {
            get => _GioiTinh;
            set => _GioiTinh=value;
        }
        public string SDTNV
        {
            get => _SDTNV;
            set => _SDTNV=value;
        }
        public string DiaChi
        {
            get => _DiaChi;
            set => _DiaChi=value;
        }
    }
}
