using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLBHX
{
    public class et_KhachHang
    {
        private string _MaKH, _TenKH, _NamSinh, _GioiTinh, _DiaChi, _SDTKH, _SoCCCD,_STKKH,_MaSoThue;

        public et_KhachHang(string maKH)
        {
            _MaKH=maKH;
        }

        public et_KhachHang(string maKH, string tenKH, string namSinh, string gioiTinh, string diaChi, string sDTKH, string soCCCD, string sTKKH, string maSoThue)
        {
            MaKH=maKH;
            TenKH=tenKH;
            NamSinh=namSinh;
            GioiTinh=gioiTinh;
            DiaChi=diaChi;
            SDTKH=sDTKH;
            SoCCCD=soCCCD;
            STKKH=sTKKH;
            MaSoThue=maSoThue;
        }

        public string MaKH
        {
            get => _MaKH;
            set => _MaKH = value;
        }
        public string TenKH
        {
            get => _TenKH;
            set => _TenKH = value;
        }
        public string NamSinh
        {
            get => _NamSinh;
            set => _NamSinh = value;
        }
        public string GioiTinh
        {
            get => _GioiTinh;
            set => _GioiTinh = value;
        }
        public string DiaChi
        {
            get => _DiaChi;
            set => _DiaChi = value;
        }
        public string SDTKH
        {
            get => _SDTKH;
            set => _SDTKH = value;
        }
        public string SoCCCD
        {
            get => _SoCCCD;
            set => _SoCCCD = value;
        }
        public string STKKH
        {
            get => _STKKH;
            set => _STKKH = value;
        }
        public string MaSoThue
        {
            get => _MaSoThue;
            set => _MaSoThue=value;
        }
    }
}
