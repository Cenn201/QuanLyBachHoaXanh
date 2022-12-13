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
    public class dal_NhanVien:DataAcces
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable HienthiNhanVien()
        {
            dt= new DataTable();
            try
            {
                MoKetNoi();
                cmd=new SqlCommand("SP_GetNhanVien", conNect);
                cmd.CommandType= CommandType.StoredProcedure;
                da= new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch(Exception) { }
            finally { DongKetNoi(); }
            return dt;
        }
        public bool ThemNhanVien(et_NhanVien et)
        {
            try
            {
                MoKetNoi();
                cmd=new SqlCommand("SP_ThemNhanVien", conNect);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value=et.MaNV;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value=et.TenNV;
                cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value=et.ChucVu;
                cmd.Parameters.Add("@MaBP", SqlDbType.VarChar).Value=et.BoPhan;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value=et.GioiTinh;
                cmd.Parameters.Add("@NamSinh", SqlDbType.VarChar).Value=et.NgaySinh;
                cmd.Parameters.Add("@SDTNV", SqlDbType.VarChar).Value=et.SDTNV;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value=et.DiaChi;
                if(cmd.ExecuteNonQuery()>0)
                    return true;
            }
            catch(Exception) { }
            finally { DongKetNoi(); }
            return false;
        }
        public bool XoaNhanVien(et_NhanVien et)
        {
            try
            {

                MoKetNoi();
                cmd=new SqlCommand("SP_XoaNhanVien", conNect);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV",SqlDbType.VarChar).Value=et.MaNV;
                if(cmd.ExecuteNonQuery() >0) return true;
            }
            catch(Exception) { }
            finally { DongKetNoi(); }
            return false;
        }
        public bool SuaNhanVien(et_NhanVien et)
        {
            try
            {
                MoKetNoi();
                cmd=new SqlCommand("SP_SuaNhanVien", conNect);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value=et.MaNV;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value=et.TenNV;
                cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value=et.ChucVu;
                cmd.Parameters.Add("@MaBP", SqlDbType.VarChar).Value=et.BoPhan;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value=et.GioiTinh;
                cmd.Parameters.Add("@NamSinh", SqlDbType.VarChar).Value=et.NgaySinh;
                cmd.Parameters.Add("@SDTNV", SqlDbType.VarChar).Value=et.SDTNV;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value=et.DiaChi;
                if (cmd.ExecuteNonQuery()>0) return true;
            }
            catch(Exception) { }
            finally { DongKetNoi(); }
            return false;
        }

    }
}
