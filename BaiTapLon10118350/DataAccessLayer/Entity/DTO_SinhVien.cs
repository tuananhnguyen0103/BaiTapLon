using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon10118350.DataAccessLayer.Entity
{
    public class DTO_SinhVien
    {
        private string maSinhVien, maLop, tenSinhVien, queQuan;
        private DateTime ngaySinh;
        private int gioiTinh;
        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public string TenSinhVien
        {
            get { return tenSinhVien; }
            set { tenSinhVien = value; }
        }
        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public DTO_SinhVien()
        {

        }
        public DTO_SinhVien(string maSinhVien, string maLop, string tenSinhVien, string queQuan, DateTime ngaySinh, int gioiTinh)
        {
            this.maSinhVien = maSinhVien;
            this.maLop = maLop;
            this.tenSinhVien = tenSinhVien;
            this.queQuan = queQuan;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
        }
    }
}
