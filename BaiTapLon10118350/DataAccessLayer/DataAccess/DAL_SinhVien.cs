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
    public class DAL_SinhVien : DBConnect
    {
        public DataTable getSinhVien()
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter("Select * From dbo.SinhVien", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdap.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }
        public DataTable getLop()
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter("Select * From dbo.Lop", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdap.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }
        public string getMaLop(string tenLop)
        {
            string maLop = "";
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.Lop", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            int i = 0;
            while (i < dataTable.Rows.Count)
            {
                if (tenLop == dataTable.Rows[i][1].ToString())
                {
                    maLop = dataTable.Rows[i][0].ToString();
                    break;
                }
                i++;
            }
            sqlCon.Close();
            return maLop;
        }
        public string getTenLop(string maLop)
        {
            string tenLop = "";
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.Lop", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            int i = 0;
            while (i < dataTable.Rows.Count)
            {
                if (maLop == dataTable.Rows[i][0].ToString())
                {
                    tenLop = dataTable.Rows[i][1].ToString();
                    break;
                }
                i++;
            }
            sqlCon.Close();
            return tenLop;
        }
        public string getGioiTinh(int Number)
        {
            string gioiTinh = "";
            if (Number == 1)
            {
                gioiTinh = "Nam";
            }
            else
                gioiTinh = "Nữ";
            return gioiTinh;
        }
        public int getGioiTinh(string gioiTinh)
        {
            int Number;
            if(gioiTinh == "Nam")
            {
                Number = 1;
            }
            else
                Number = 0;
            return Number;
        }
        public int KiemTraMaTrung(string ma)
        {
            // Giá trị trả ra nếu là 1 là trùng, 0 là không tồn tại mã trong cơ sở dữ liệu
            int i;
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Câu truy vấn để kiểm tra mã có tồn tại hay không?
            string strCheck = string.Format(@"Select Count(*) From dbo.SinhVien Where maSinhVien ='{0}'", ma);

            SqlCommand sqlCom = new SqlCommand(strCheck, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            sqlCon.Close();
            return i;

        }
        public void ThemSinhVien(DTO_SinhVien SinhVien)
        {
            try
            {
                // Kết Nối với cơ sở dữ liệu
                sqlCon.Open();
                // Câu truy vấn để thêm thông tin
                string strQuery = string.Format(@"Insert Into dbo.SinhVien (maSinhVien,maLop,tenSinhVien,queQuan,ngaySinh,gioiTinh)
                                                 Values('{0}','{1}',N'{2}',N'{3}','{4}',{5})", SinhVien.MaSinhVien, SinhVien.MaLop, SinhVien.TenSinhVien, SinhVien.QueQuan,SinhVien.NgaySinh,SinhVien.GioiTinh);
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
        public void SuaSinhVien(string maSinhVien, DTO_SinhVien SinhVien)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Update dbo.SinHVien Set maLop='{0}',tenSinHVien=N'{1}',queQuan=N'{2}',ngaySinh='{3}',gioiTinh={4}
                                                Where maLop ='{5}'", SinhVien.MaLop, SinhVien.TenSinhVien, SinhVien.NgaySinh, SinhVien.QueQuan, SinhVien.GioiTinh, SinhVien.MaSinhVien);
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
        public void XoaSinhVien(string maSinhVien)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Delete From dbo.SinhVien Where maSinhVien='{0}'", maSinhVien);
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
