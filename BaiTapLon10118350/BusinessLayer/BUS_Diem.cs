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
    public class BUS_Diem
    {
        // Khởi tạo đối tượng của lớp DAL_Khoa (lớp thao tác với cơ sở dữ liệu)
        DAL_Diem dalDiem = new DAL_Diem();

        public DataTable GetDiem()
        {
            return dalDiem.GetDiem();
        }
        public DataTable GetSinHVien()
        {
            return dalDiem.GetSiinhVien();
        }
        public DataTable GetMonHoc()
        {
            return dalDiem.GetMonHoc();
        }
        public DataTable FindGetDiem(string maSinhVien)
        {
            return dalDiem.FindGetDiem(maSinhVien);
        }
        public string GetTenMH(string maMonHoc)
        {
            return dalDiem.getTenMonHoc(maMonHoc);
        }
        public string GetTenSinHVien(string maSinHVien)
        {
            return dalDiem.getTenSinhVien(maSinHVien);
        }
        public int KiemTraMaTrung(string maMonHoc,string maSinhVien)
        {
            return dalDiem.KiemTraMaTrung(maSinhVien,maMonHoc);
        }
        public void ThemDiem(DTO_Diem Diem)
        {
            dalDiem.ThemDiem(Diem);
        }
        public void SuaDiem(string maSinhVien,string maMonHoc, DTO_Diem Diem)
        {
            dalDiem.SuaDiem(maMonHoc,maSinhVien,Diem);
        }
        public void XoaKhoa(string maSinhVien,string maMonHoc)
        {
            dalDiem.XoaDiem(maSinhVien,maMonHoc);
        }
    }
}
