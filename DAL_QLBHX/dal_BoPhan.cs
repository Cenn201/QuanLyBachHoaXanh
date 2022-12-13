using ET_QLBHX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBHX
{
    public class dal_BoPhan:DataAcces
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable HienThiBoPhan()
        {
            dt= new DataTable();
            try
            {
                MoKetNoi();
                cmd= new SqlCommand("SP_GetBoPhan",conNect);
                cmd.CommandType= CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                da.Fill(dt); 
            }
            catch(Exception) { }
            finally { DongKetNoi(); }
            return dt;
        }
        public string HienThiTenBoPhan(string MaBP)
        {
                string name=null;
            try
            {
                MoKetNoi();
                cmd= new SqlCommand("SP_GetTenBoPhan", conNect);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaBP",SqlDbType.VarChar).Value= MaBP;
                SqlDataReader dr=cmd.ExecuteReader();
                while(dr.Read())
                {
                    name= dr["TenBP"].ToString();
                }
                return name;
            }
            catch(Exception ) { }
            finally { DongKetNoi(); }
            return name;
        }
    }
}
