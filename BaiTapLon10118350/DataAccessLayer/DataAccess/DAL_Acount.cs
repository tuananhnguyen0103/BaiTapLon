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
    public class DAL_Acount : DBConnect
    {
        public DataTable getAcount()
        {
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Đổ dữ liệu vào sqlDataAdapter với 2 tham số truyền vào là câu truy vấn và chuỗi kết nối với cơ sở dữ liệu
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.ACOUNT", strConnect);
            // Tạo đối tượng dataTable để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();
            // Đổ dữ liệu từ sqlDataAdapter vào dataTable
            sqlDataAdapter.Fill(dataTable);
            // Đóng kết nối với cơ sở dữ liệu
            sqlCon.Close();
            // Trả ra dữ liệu mong muốn theo đối tượng datatable
            return dataTable;
        }
        public string GetPosition(string acountUser)
        {
            DataTable data = getAcount();
            string position = "";
            for(int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][0].ToString() == acountUser)
                {
                    if (data.Rows[i][2].ToString().ToLower() == "user")
                    {
                        position = "user";
                        break;
                    }
                    if (data.Rows[i][2].ToString().ToLower() == "admin")
                    {
                        position = "admin";
                        break;
                    }
                }
            }
            return position;
        }
        public int KiemTraTaiKhoan(string acountUser,string acountPass)
        {
            // Giá trị trả ra nếu là 1 là trùng, 0 là không tồn tại mã trong cơ sở dữ liệu
            int i;
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Câu truy vấn để kiểm tra mã có tồn tại hay không?
            string strCheck = string.Format(@"Select Count(*) From dbo.Acount Where UserAcount='{0}' and PassAcount ='{1}'", acountUser,acountPass);
            SqlCommand sqlCom = new SqlCommand(strCheck, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            sqlCon.Close();
            return i;

        }
    }
}
