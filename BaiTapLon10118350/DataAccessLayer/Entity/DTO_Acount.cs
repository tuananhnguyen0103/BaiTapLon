using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon10118350.DataAccessLayer.Entity
{
    class DTO_Acount
    {
        private string userAcount, passAcount, positionAcount;
        public string UserAcount
        {
            get { return userAcount; }
            set { userAcount = value; }
        }
        public string PassAcount
        {
            get { return passAcount; }
            set { passAcount = value; }
        }
        public string PositionAcount
        {
            get { return positionAcount; }
            set { positionAcount = value; }
        }
        public DTO_Acount()
        {

        }
        public DTO_Acount   (string userAcount, string passAcount, string positionAcount)
        {
            this.userAcount = userAcount;
            this.passAcount = passAcount;
            this.positionAcount = positionAcount;
        }
    }
}
