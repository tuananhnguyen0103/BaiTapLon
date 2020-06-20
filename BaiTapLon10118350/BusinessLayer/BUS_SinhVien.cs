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
    public class BUS_SinhVien
    {
        // Khởi tạo đối tượng của lớp DAL_SinhVien (lớp thao tác với cơ sở dữ liệu)
        DAL_SinhVien dalSinhVien = new DAL_SinhVien();
        public DataTable GetLop()
        {
            return dalSinhVien.getLop();
        }
        public DataTable GetSinhVien()
        {
            return dalSinhVien.getSinhVien();
        }
        public int KiemTraMaTrung(string maSinhVien)
        {
            return dalSinhVien.KiemTraMaTrung(maSinhVien);
        }
        public void ThemSinhVien(DTO_SinhVien SinhVien)
        {
            dalSinhVien.ThemSinhVien(SinhVien);
        }
        public void SuaSinhVien(string maSinhVien, DTO_SinhVien SinhVien)
        {
            dalSinhVien.SuaSinhVien(maSinhVien, SinhVien);
        }
        public void XoaSinhVien(string maSinhVien)
        {
            dalSinhVien.XoaSinhVien(maSinhVien);
        }
        public string GetTenLop(string maLop)
        {
            return dalSinhVien.getTenLop(maLop);
        }
        public string GetMaLop(string tenLop)
        {
            return dalSinhVien.getMaLop(tenLop);
        }
        public string GetGioiTinh(int Number)
        {
            return dalSinhVien.getGioiTinh(Number);
        }
        public int GetGioiTinh(string gioiTinh)
        {
            return dalSinhVien.getGioiTinh(gioiTinh);
        }
    }
}
