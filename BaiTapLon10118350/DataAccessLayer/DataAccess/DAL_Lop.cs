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
    public class DAL_Lop : DBConnect
    {
        public DataTable getkhoa()
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.Khoa", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }
        public DataTable getLop()
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.Lop", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }
        public string getMaKhoa(string tenKhoa)
        {
            string maKhoa = "";
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.Khoa", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            
            int i = 0;
            while (i < dataTable.Rows.Count)
            {
                if(tenKhoa == dataTable.Rows[i][1].ToString())
                {
                    maKhoa = dataTable.Rows[i][0].ToString();
                    break;
                }
                i++;
            }
            sqlCon.Close();
            return maKhoa;
        }
        public string getTenKhoa(string maKhoa)
        {
            string tenKhoa = "";
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.Khoa", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            int i = 0;
            while (i < dataTable.Rows.Count)
            {
                if (maKhoa == dataTable.Rows[i][0].ToString())
                {
                    tenKhoa = dataTable.Rows[i][1].ToString();
                    break;
                }
                i++;
            }
            sqlCon.Close();
            return tenKhoa;
        }
        public int KiemTraMaTrung(string ma)
        {

            int i;
            sqlCon.Open();
            string strCheck = string.Format(@"Select Count(*) From dbo.Lop Where maLop ='{0}'", ma);
            SqlCommand sqlCom = new SqlCommand(strCheck, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            sqlCon.Close();
            return i;

        }
        public void ThemLop(DTO_Lop Lop)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Insert Into dbo.Lop (maLop,maKhoa,tenLop)
                                                 Values('{0}','{1}',N'{2}')", Lop.MaLop, Lop.MaKhoa, Lop.TenLop);
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
        public void SuaLop(string maLop, DTO_Lop Lop)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Update dbo.Lop Set tenLop=N'{0}',maKhoa='{1}'
                                                Where maLop ='{2}'", Lop.TenLop, Lop.MaKhoa, maLop);
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
        public void XoaLop(string maLop)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Delete From dbo.Lop Where maLop='{0}'", maLop);
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
