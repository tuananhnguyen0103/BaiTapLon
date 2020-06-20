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
    public class DAL_Khoa : DBConnect
    {
        public DataTable getKhoa()
        {
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Đổ dữ liệu vào sqlDataAdapter với 2 tham số truyền vào là câu truy vấn và chuỗi kết nối với cơ sở dữ liệu
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.Khoa", strConnect);
            // Tạo đối tượng dataTable để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();
            // Đổ dữ liệu từ sqlDataAdapter vào dataTable
            sqlDataAdapter.Fill(dataTable);
            // Đóng kết nối với cơ sở dữ liệu
            sqlCon.Close();
            // Trả ra dữ liệu mong muốn theo đối tượng datatable
            return dataTable;
        }
        public int KiemTraMaTrung(string ma)
        {
           // Giá trị trả ra nếu là 1 là trùng, 0 là không tồn tại mã trong cơ sở dữ liệu
            int i;
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Câu truy vấn để kiểm tra mã có tồn tại hay không?
            string strCheck = string.Format(@"Select Count(*) From dbo.Khoa Where maKhoa ='{0}'", ma);

            SqlCommand sqlCom = new SqlCommand(strCheck, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            sqlCon.Close();
            return i;
            
        }
        public void ThemKhoa(DTO_Khoa Khoa)
        {
            try
            {
                // Kết Nối với cơ sở dữ liệu
                sqlCon.Open();
                // Câu truy vấn để thêm thông tin
                string strQuery = string.Format(@"Insert Into dbo.Khoa (maKhoa,tenKhoa,vanPhongKhoa,soDienThoai)
                                                 Values('{0}',N'{1}','{2}','{3}')", Khoa.MaKhoa, Khoa.TenKhoa, Khoa.VanPhongKhoa, Khoa.SoDienThoai);
                // Dùng đối tượng sqlCommand để thao tác với cơ sở dữ liệu với 2 tham số truyền vào là câu truy vấn và đối tượng thực thi
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
        public void SuaKhoa(string maKhoa, DTO_Khoa Khoa)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Update dbo.Khoa Set tenKhoa=N'{0}',vanPhongKhoa='{1}',soDienThoai='{2}'
                                                Where maKhoa ='{3}'", Khoa.TenKhoa, Khoa.VanPhongKhoa, Khoa.SoDienThoai, maKhoa);
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
        public void XoaKhoa(string maKhoa)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Delete From dbo.Khoa Where maKhoa='{0}'", maKhoa);
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
