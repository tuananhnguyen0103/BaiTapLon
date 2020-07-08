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
    public class BUS_Lop
    {
        // Khởi tạo đối tượng của lớp DAL_Lop (lớp thao tác với cơ sở dữ liệu)
        DAL_Lop dalLop = new DAL_Lop();
        public DataTable GetKhoa()
        {
            return dalLop.getkhoa();
        }
        public DataTable GetLop()
        {
            return dalLop.getLop();
        }
        public DataTable GetLopTheoKhoa(string maKhoa)
        {
            return dalLop.getLopThuocKhoa(maKhoa);
        }
       
        public DataTable FindGetLop(string tenLop)
        {
            return dalLop.FindGetLOp(tenLop);
        }
        public int KiemTraMaTrung(string maLop)
        {
            return dalLop.KiemTraMaTrung(maLop);
        }
        public void ThemLop(DTO_Lop Lop)
        {
            dalLop.ThemLop(Lop);
        }
        public void SuaLop(string maLop, DTO_Lop Lop)
        {
            dalLop.SuaLop(maLop, Lop);
        }
        public void XoaLop(string maLop)
        {
            dalLop.XoaLop(maLop);
        }
        public string GetTenKhoa(string maKhoa)
        {
            return dalLop.getTenKhoa(maKhoa);
        }
        public string GetMaKhoa(string tenKhoa)
        {
            return dalLop.getMaKhoa(tenKhoa);
        }
    }
}
