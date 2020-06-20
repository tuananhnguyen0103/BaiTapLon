using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon10118350.DataAccessLayer.Entity
{
    public class DTO_Khoa
    {
        private string maKhoa, tenKhoa, vanPhongKhoa, soDienThoai;
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        public string TenKhoa
        {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }
        public string VanPhongKhoa
        {
            get { return vanPhongKhoa; }
            set { vanPhongKhoa = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public DTO_Khoa()
        {

        }
        public DTO_Khoa(string maKhoa, string tenKhoa, string vanPhongKhoa, string soDienThoai)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.vanPhongKhoa = vanPhongKhoa;
            this.soDienThoai = soDienThoai;
        }
    }
}
