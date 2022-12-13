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
    public class bus_KhachHang
    {
        dal_KhachHang KhachHang = new dal_KhachHang();
        public DataTable HienThiKhachHang()
        {
            return KhachHang.HienThiKhachHang();
        }
        public bool ThemKhachHang(et_KhachHang et)
        {
             return KhachHang.ThemKhachHang(et);
        }
        public bool XoaKhachHang(et_KhachHang et)
        {
            return KhachHang.XoaKhachHang(et);
        }
        public bool SuaKhachHang(et_KhachHang et)
        {
            return KhachHang.SuaKhachHang(et);
        }

    }
}
