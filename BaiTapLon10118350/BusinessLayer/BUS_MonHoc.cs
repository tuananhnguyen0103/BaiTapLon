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
    class BUS_MonHoc
    {
        // Khởi tạo đối tượng của lớp DAL_MonHoc (lớp thao tác với cơ sở dữ liệu)
        DAL_MonHoc dalMonHoc = new DAL_MonHoc();

        public DataTable GetMonHoc()
        {
            return dalMonHoc.getMonHoc();
        }

        public int KiemTraMaTrung(string maMonHoc)
        {
            return dalMonHoc.KiemTraMaTrung(maMonHoc);
        }
        public void ThemMonHoc(DTO_MonHoc MonHoc)
        {
            dalMonHoc.ThemMonHoc(MonHoc);
        }
        public void SuaMonHoc(string maMonHoc, DTO_MonHoc MonHoc)
        {
            dalMonHoc.SuaMonHoc(maMonHoc, MonHoc);
        }
        public void XoaMonHoc(string maMonHoc)
        {
            dalMonHoc.XoaMonHoc(maMonHoc);
        }
    }
}
