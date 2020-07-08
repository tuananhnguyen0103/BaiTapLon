using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BaiTapLon10118350.DataAccessLayer.DataAccess
{
    public class DBConnect
    {
        // Đường dẫn để kết nối cơ sở dữ liệu
        public string strConnect = @"Data Source=DESKTOP-DCMU7ET;Initial Catalog = BTLWinFormQuanLyDiemSinhVien; Integrated Security = True";

        // Đối tượng thực hiện kết nối cơ sở dữ liệu thông qua đường dẫn
        public SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-DCMU7ET;Initial Catalog=BTLWinFormQuanLyDiemSinhVien;Integrated Security=True");

        
    }
}
