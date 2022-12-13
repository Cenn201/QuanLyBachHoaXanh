using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLBHX
{
    public class DataAcces
    {
        public SqlConnection conNect = null;
        string strCon = @"Data Source=.;Initial Catalog=QLyBachHoaXanh;Integrated Security=True";
        public void MoKetNoi()
        {
            if (conNect == null)
            {
                conNect = new SqlConnection(strCon);
            }
            if (conNect.State == ConnectionState.Closed)
            {
                conNect.Open();
            }
        }
        public void DongKetNoi()
        {
            if (conNect.State == ConnectionState.Open)
            {
                conNect.Close();
            }
        }
    }
}
