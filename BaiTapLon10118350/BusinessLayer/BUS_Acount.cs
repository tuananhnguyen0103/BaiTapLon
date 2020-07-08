using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BaiTapLon10118350.DataAccessLayer.DataAccess;
using BaiTapLon10118350.DataAccessLayer.Entity;

namespace BaiTapLon10118350.BusinessLayer
{
    public class BUS_Acount
    {
        DAL_Acount dalAcount = new DAL_Acount();

        public DataTable GetAcount()
        {
            return dalAcount.getAcount();
        }
        public int KiemTraAcount(string user,string pass)
        {
            return dalAcount.KiemTraTaiKhoan(user,pass);
        }
        public string GetPosition(string user)
        {
            return dalAcount.GetPosition(user);
        }
    }
}
