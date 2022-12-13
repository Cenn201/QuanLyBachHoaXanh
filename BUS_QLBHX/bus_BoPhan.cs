using DAL_QLBHX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBHX
{
    public class bus_BoPhan
    {
        dal_BoPhan boPhan= new dal_BoPhan();
        public DataTable HienThiBoPhan()
        {
            return boPhan.HienThiBoPhan();
        }
        public string HienThiTenBoPhan(string MaBP)
        {
            return boPhan.HienThiTenBoPhan(MaBP);
        }
    }
}
