using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BaiTapLon10118350.DataAccessLayer.Entity;
using BaiTapLon10118350.DataAccessLayer.DataAccess;

namespace BaiTapLon10118350.BusinessLayer
{
    public class BUS_Khoa
    {
        // Khởi tạo đối tượng của lớp DAL_Khoa (lớp thao tác với cơ sở dữ liệu)
        DAL_Khoa dalKhoa = new DAL_Khoa();

        public DataTable GetKhoa()
        {
            return dalKhoa.getKhoa();
        }
        public int KiemTraMaTrung(string maKhoa)
        {
            return dalKhoa.KiemTraMaTrung(maKhoa);
        }
        public void ThemKhoa(DTO_Khoa Khoa)
        {
            dalKhoa.ThemKhoa(Khoa);
        }
        public void SuaKhoa(string maKhoa, DTO_Khoa Khoa)
        {
            dalKhoa.SuaKhoa(maKhoa, Khoa);
        }
        public void XoaKhoa(string maKhoa)
        {
            dalKhoa.XoaKhoa(maKhoa);
        }
    }
}
