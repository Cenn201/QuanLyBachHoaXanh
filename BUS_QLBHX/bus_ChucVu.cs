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
    public class bus_ChucVu
    {
        dal_ChucVu ChucVu = new dal_ChucVu();
        public DataTable HienThiChucVu()
        {
            return ChucVu.HienThiChucVu();
        }
        public string HienThiTenChucVu(string MaCV)
        {
            return ChucVu.HienThiTenChucVu(MaCV);
        }
    }
}
