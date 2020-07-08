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
        public DataTable GetSinhVienTheoKhoa(string maKhoa)
        {
            return dalSinhVien.GetSinhVienTheoKhoa(maKhoa);
        }
        public int SoLuongGetSinhVienTheoKhoa(string maKhoa)
        {
            return dalSinhVien.SoLuongGetSinhVienTheoKhoa(maKhoa);
        }
        public DataTable GetSinhVienTheoDiem(int diem1,int diem2)
        {
            return dalSinhVien.GetSinhVienTheoDiem(diem1, diem2);
        }
        public int SoLuongGetSinhVienTheoDiem(int diem1,int diem2)
        {
            return dalSinhVien.SoLuongGetSinhVienTheoDiem(diem1, diem2);
        }
        public DataTable GetSinhVienTheoMonHoc(string maMonHoc)
        {
            return dalSinhVien.GetSinhVienTheoMonHoc(maMonHoc);
        }
        public int SoLuongGetSinhVienTheoMonHoc(string maMonHoc)
        {
            return dalSinhVien.SoLuongGetSinhVienTheoMonHoc(maMonHoc);
        }

        public DataTable GetSinhVienTheoLop(string maLop)
        {
            return dalSinhVien.getSinhVienTheoLop(maLop);
        }
        public DataTable ThongKeGetSinhVienTheoLop(string maLop)
        {
            return dalSinhVien.GetSinhVienTheoLop(maLop);
        }
        public int SoLuongGetSinhVienTheoLop(string maKhoa)
        {
            return dalSinhVien.SoLuongGetSinhVienTheoLop(maKhoa);
        }
        public DataTable GetSinHVienTheoTen(string tenSV)
        {
            return dalSinhVien.GetSinHVienTheoTen(tenSV);
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
        
    }
}
