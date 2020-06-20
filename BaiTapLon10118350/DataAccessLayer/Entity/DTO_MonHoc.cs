using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon10118350.DataAccessLayer.Entity
{
    public class DTO_MonHoc
    {
        private string maMonHoc ,tenMonHoc;
        private int soTinChi;

        public string MaMonHoc
        {
            get { return maMonHoc; }
            set { maMonHoc = value; }
        }
        public string TenMonHoc
        {
            get { return tenMonHoc; }
            set { tenMonHoc = value; }
        }
        public int SoTinChi
        {
            get { return soTinChi; }
            set { soTinChi = value; }
        }
        public DTO_MonHoc()
        {

        }
        public DTO_MonHoc(string maMonHoc, string tenMonHoc, int soTinChi)
        {
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.soTinChi = soTinChi;
        }
    }
}
