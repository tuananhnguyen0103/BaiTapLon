using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon10118350.DataAccessLayer.Entity
{
    public class DTO_Diem
    {
        
        private string maMonHoc, maSinhVien;
        private int kiHoc;
        private float diemLan1,diemLan2;
        public string MaMonHoc
        {
            get { return maMonHoc; }
            set { maMonHoc = value; }
        }
        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }
        public int KiHoc
        {
            get { return kiHoc; }
            set { kiHoc = value; }
        }
        public float DiemLan1
        {
            get { return diemLan1; }
            set { diemLan1 = value; }
        }
        public float DiemLan2
        {
            get { return diemLan2; }
            set { diemLan2 = value; }
        }
        public DTO_Diem()
        {

        }
        public DTO_Diem(string maMonHoc, string maSinhVien, int kiHoc, float diemLan1, float diemLan2 )
        {
            this.maMonHoc = maMonHoc;
            this.maSinhVien = maSinhVien;
            this.kiHoc = kiHoc;
            this.diemLan1 = diemLan1;
            this.diemLan2 = diemLan2;
        }
    }
}
