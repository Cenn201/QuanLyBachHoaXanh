
using DAL_QLBHX;
using ET_QLBHX;

namespace BUS_QLBHX
{
    public class bus_DangNhap
    {
        dal_DangNhap DangNhap=new dal_DangNhap();
        public int KiemTraDangNhap(et_DangNhap et)
        {
            return DangNhap.KiemTraDangNhap(et);
        }
    }
}