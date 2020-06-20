using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BaiTapLon10118350.DataAccessLayer.Entity;  

namespace BaiTapLon10118350.DataAccessLayer.DataAccess
{
    public class DAL_MonHoc:DBConnect
    {
        public DataTable getMonHoc()
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter("Select * From dbo.MonHoc", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdap.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }

        public int KiemTraMaTrung(string ma)
        {
            int i;
            sqlCon.Open();
            string strCheck = string.Format(@"Select Count(*) From dbo.MonHoc Where maMonHoc='{0}'", ma);
            SqlCommand sqlCom = new SqlCommand(strCheck, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            sqlCon.Close();
            return i;
        }
        public void ThemMonHoc(DTO_MonHoc MonHoc)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Insert Into dbo.MonHoc (maMonHoc,tenMonHoc,soTinChi)
                                                 Values('{0}',N'{1}','{2}')", MonHoc.MaMonHoc,MonHoc.TenMonHoc, MonHoc.SoTinChi);
                SqlCommand sqlCom = new SqlCommand(strQuery, sqlCon);
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
        public void SuaMonHoc(string maMonHoc, DTO_MonHoc MonHoc)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Update dbo.MonHoc Set tenMonHoc=N'{0}',soTinChi={1}
                                                Where maMonHoc ='{2}'", MonHoc.TenMonHoc, MonHoc.SoTinChi, maMonHoc);
                SqlCommand sqlCom = new SqlCommand(strQuery, sqlCon);
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
        public void XoaMonHoc(string maMonHoc)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Delete From dbo.MonHoc Where maMonHoc='{0}'", maMonHoc);
                SqlCommand sqlCom = new SqlCommand(strQuery, sqlCon);
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
