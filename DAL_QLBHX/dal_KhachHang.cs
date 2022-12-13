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
    public class dal_KhachHang: DataAcces
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        DataTable dt;
        public DataTable HienThiKhachHang()
        {
            dt= new DataTable();
            try
            {
                MoKetNoi();
                cmd=new SqlCommand("SP_GetKhachHang", conNect);
                cmd.CommandType=CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch(Exception) { }
            finally { DongKetNoi(); }
            return dt;
        }
        public bool ThemKhachHang(et_KhachHang et)
        {
            bool KTra=false;
            try
            {
                MoKetNoi();
                cmd=new SqlCommand("SP_ThemKhachHang", conNect);
                cmd.CommandType= CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value=et.MaKH;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value=et.TenKH;
                cmd.Parameters.Add("@NamSinh", SqlDbType.Date).Value=et.NamSinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value=et.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value=et.DiaChi;
                cmd.Parameters.Add("@SDTKH", SqlDbType.VarChar).Value=et.SDTKH;
                cmd.Parameters.Add("@SoCCCD", SqlDbType.VarChar).Value=et.SoCCCD;
                cmd.Parameters.Add("@STKKH", SqlDbType.VarChar).Value=et.STKKH;
                cmd.Parameters.Add("@MaSoThue", SqlDbType.VarChar).Value=et.MaSoThue;
                KTra=( cmd.ExecuteNonQuery()>0);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DongKetNoi();
            }
            return KTra;
        }
        public bool XoaKhachHang(et_KhachHang et)
        {
            try
            {
                MoKetNoi();
                cmd=new SqlCommand("SP_XoaKhachHang",conNect);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKH",SqlDbType.VarChar).Value= et.MaKH;
                if (cmd.ExecuteNonQuery() > 0) { return true; };
            }
            catch(Exception) { }
            finally { DongKetNoi(); }
            return false;
        }
        public bool SuaKhachHang(et_KhachHang et)
        {
            try
            {
                MoKetNoi();
                cmd=new SqlCommand("SP_SuaKhachHang", conNect);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value=et.MaKH;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value=et.TenKH;
                cmd.Parameters.Add("@NamSinh", SqlDbType.Date).Value=et.NamSinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value=et.GioiTinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value=et.DiaChi;
                cmd.Parameters.Add("@SDTKH", SqlDbType.VarChar).Value=et.SDTKH;
                cmd.Parameters.Add("@SoCCCD", SqlDbType.VarChar).Value=et.SoCCCD;
                cmd.Parameters.Add("@STKKH", SqlDbType.VarChar).Value=et.STKKH;
                cmd.Parameters.Add("@MaSoThue", SqlDbType.VarChar).Value=et.MaSoThue;
                if (cmd.ExecuteNonQuery()>0)
                {
                    return true;
                }    
            }
            catch (Exception) { }
            finally { DongKetNoi(); }
            return false;
        }
    }
}
