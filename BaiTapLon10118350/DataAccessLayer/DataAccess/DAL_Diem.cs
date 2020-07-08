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
    public class DAL_Diem:DBConnect
    {
        public DataTable GetDiem()
        {
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Đổ dữ liệu vào sqlDataAdapter với 2 tham số truyền vào là câu truy vấn và chuỗi kết nối với cơ sở dữ liệu
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.Diem", strConnect);
            // Tạo đối tượng dataTable để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();
            // Đổ dữ liệu từ sqlDataAdapter vào dataTable
            sqlDataAdapter.Fill(dataTable);
            // Đóng kết nối với cơ sở dữ liệu
            sqlCon.Close();
            // Trả ra dữ liệu mong muốn theo đối tượng datatable
            return dataTable;
        }

        public DataTable GetMonHoc()
        {
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Đổ dữ liệu vào sqlDataAdapter với 2 tham số truyền vào là câu truy vấn và chuỗi kết nối với cơ sở dữ liệu
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("Select * From dbo.MonHoc"), strConnect);
            // Tạo đối tượng dataTable để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();
            // Đổ dữ liệu từ sqlDataAdapter vào dataTable
            sqlDataAdapter.Fill(dataTable);
            // Đóng kết nối với cơ sở dữ liệu
            sqlCon.Close();
            // Trả ra dữ liệu mong muốn theo đối tượng datatable
            return dataTable;
        }
        public DataTable GetSiinhVien()
        {
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Đổ dữ liệu vào sqlDataAdapter với 2 tham số truyền vào là câu truy vấn và chuỗi kết nối với cơ sở dữ liệu
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("Select * From dbo.SinhVien"), strConnect);
            // Tạo đối tượng dataTable để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();
            // Đổ dữ liệu từ sqlDataAdapter vào dataTable
            sqlDataAdapter.Fill(dataTable);
            // Đóng kết nối với cơ sở dữ liệu
            sqlCon.Close();
            // Trả ra dữ liệu mong muốn theo đối tượng datatable
            return dataTable;
        }

        public DataTable FindGetDiem(string maSinhVien)
        {
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Đổ dữ liệu vào sqlDataAdapter với 2 tham số truyền vào là câu truy vấn và chuỗi kết nối với cơ sở dữ liệu
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("Select * From dbo.Diem  Where  maSinhVien like N'%{0}%'", maSinhVien), strConnect);
            // Tạo đối tượng dataTable để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();
            // Đổ dữ liệu từ sqlDataAdapter vào dataTable
            sqlDataAdapter.Fill(dataTable);
            // Đóng kết nối với cơ sở dữ liệu
            sqlCon.Close();
            // Trả ra dữ liệu mong muốn theo đối tượng datatable
            return dataTable;
        }

        public int KiemTraMaTrung(string maSinhVien, string maMonHoc)
        {

            int i;
            sqlCon.Open();
            string strCheck = string.Format(@"Select Count(*) From dbo.Diem Where maMonHoc ='{0}' and maSinhVien ='{1}'",maMonHoc, maSinhVien);
            SqlCommand sqlCom = new SqlCommand(strCheck, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            sqlCon.Close();
            return i;

        }
        public void ThemDiem(DTO_Diem Diem)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Insert Into dbo.Diem (maMonHoc,maSinhVien,kiHoc,diemlan1,diemlan2)
                                                 Values('{0}','{1}',{2},{3},{4})",Diem.MaMonHoc,Diem.MaSinhVien,Diem.KiHoc,Diem.DiemLan1,Diem.DiemLan2);
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
        public void SuaDiem(string maMonHoc,string maSinhVien, DTO_Diem Diem)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Update dbo.Diem Set kiHoc={0},diemLan1={1},diemlan2={2}
                                                Where maSinhVien ='{3}' and maMonHoc = '{4}'", Diem.KiHoc, Diem.DiemLan1, Diem.DiemLan2,maSinhVien,maMonHoc);
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
        public void XoaDiem(string maSinhVien,string maMonHoc)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Delete From dbo.Diem Where maSinhVien='{0}' and maMonHoc='{1}'", maSinhVien,maMonHoc);
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
        public string getTenSinhVien(string maSinhVien)
        {
            string tenSV = "";
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Đổ dữ liệu vào sqlDataAdapter với 2 tham số truyền vào là câu truy vấn và chuỗi kết nối với cơ sở dữ liệu
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("Select * From dbo.SinhVien"), strConnect);
            // Tạo đối tượng dataTable để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();
            // Đổ dữ liệu từ sqlDataAdapter vào dataTable
            
            sqlDataAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][0].ToString() == maSinhVien)
                {
                    tenSV = dataTable.Rows[i][2].ToString();
                }
            }
            // Đóng kết nối với cơ sở dữ liệu
            sqlCon.Close();
            // Trả ra dữ liệu mong muốn theo đối tượng datatable
            return tenSV;
        }
        public string getTenMonHoc(string maMonHoc)
        {

            string tenMH = "";
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Đổ dữ liệu vào sqlDataAdapter với 2 tham số truyền vào là câu truy vấn và chuỗi kết nối với cơ sở dữ liệu
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("Select * From dbo.MonHoc"), strConnect);
            // Tạo đối tượng dataTable để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();
            // Đổ dữ liệu từ sqlDataAdapter vào dataTable

            sqlDataAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][0].ToString() == maMonHoc)
                {
                    tenMH = dataTable.Rows[i][1].ToString();
                }
            }
            // Đóng kết nối với cơ sở dữ liệu
            sqlCon.Close();
            // Trả ra dữ liệu mong muốn theo đối tượng datatable
            return tenMH;
        }
    }
}
