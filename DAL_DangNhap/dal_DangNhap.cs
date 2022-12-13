using ET_QLBHX;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml;

namespace DAL_DangNhap
{
    public class dal_DangNhap
    {
        private readonly SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLyBachHoaXanh;Integrated Security=True");
        private SqlCommand cmd;

        public int KiemTraDangNhap(et_DangNhap et)
        {
            int a=0;
            try
            {
                conn.Open();
                cmd=new SqlCommand("SP_KiemTraDangNhap",conn);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenDangNhap",SqlDbType.VarChar).Value=et.TenTaiKhoan;
                cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value=et.MatKhau;
                a=(int)cmd.ExecuteScalar();
            }
            catch(Exception) { }
            finally 
            {
                conn.Close();
            }
            return a;
        }

    }
}