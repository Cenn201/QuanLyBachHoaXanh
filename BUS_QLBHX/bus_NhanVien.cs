using DAL_QLBHX;
using ET_QLBHX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBHX
{
    public class bus_NhanVien
    {
        dal_NhanVien nhanVien= new dal_NhanVien();
        public DataTable HienThiNhanVien()
        {
            return nhanVien.HienthiNhanVien();
        }
        public bool ThemNhanVien(et_NhanVien et)
        {
            return nhanVien.ThemNhanVien(et);
        }
        public bool XoaNhanVien(et_NhanVien et)
        {
            return nhanVien.XoaNhanVien(et);
        }
        public bool SuaNhanVien(et_NhanVien et)
        {
            return nhanVien.SuaNhanVien(et) ;
        }
    }
}
