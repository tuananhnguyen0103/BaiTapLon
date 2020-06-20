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
        public string strConnect = "";
        // Đối tượng thực hiện kết nối cơ sở dữ liệu thông qua đường dẫn
        SqlConnection sqlCon;
        
        public void GetStringConnect(string strConnect)
        {
            this.strConnect = strConnect;
             sqlCon = new SqlConnection(strConnect);
        }
    }
}
