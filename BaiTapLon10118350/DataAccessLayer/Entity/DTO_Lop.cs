using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon10118350.DataAccessLayer.Entity
{
    public class DTO_Lop
    {
        private string maLop, maKhoa, tenLop;
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
        public DTO_Lop()
        {

        }
        public DTO_Lop(string maLop, string maKhoa, string tenLop)
        {
            this.maLop = maLop;
            this.maKhoa = maKhoa;
            this.tenLop = tenLop;
        }
    }
}
