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
    public class dal_ChucVu : DataAcces
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable HienThiChucVu()
        {
            dt=new DataTable();
            try
            {
                MoKetNoi();
                cmd= new SqlCommand("SP_GetChucVu", conNect);
                cmd.CommandType= CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch(Exception) { }
            finally { DongKetNoi(); }
            return dt;
        }
        public string HienThiTenChucVu(string MaCV)
        {
                string name=null;
            try
            {
                MoKetNoi();
                cmd= new SqlCommand("SP_GetTenChucVu", conNect);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value=MaCV;
                SqlDataReader dr=cmd.ExecuteReader();
                while(dr.Read())
                {
                    name = dr["TenCV"].ToString();
                }
                return name;
            }
            catch (Exception) { }
            finally { DongKetNoi(); }
            return name;
        }
    }
}
