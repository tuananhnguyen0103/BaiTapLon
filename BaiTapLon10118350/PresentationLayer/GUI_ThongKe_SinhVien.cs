using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon10118350.PresentationLayer
{
    public partial class GUI_ThongKe_SinhVien : Form
    {
        public GUI_ThongKe_SinhVien()
        {
            InitializeComponent();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            GUI_ThongKe_SinhVien_MonHoc vien_MonHoc = new GUI_ThongKe_SinhVien_MonHoc();
            vien_MonHoc.ShowDialog();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            GUI_ThongKe_SinhVien_Khoa sinhVien_Khoa = new GUI_ThongKe_SinhVien_Khoa();
            sinhVien_Khoa.ShowDialog();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            GUI_ThongKe_SinhVien_Lop sinhVien_Lop = new GUI_ThongKe_SinhVien_Lop();
            sinhVien_Lop.ShowDialog();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            GUI_ThongKe_SinhVien_ChuaDat sinhVien_ChuaDat = new GUI_ThongKe_SinhVien_ChuaDat();
            sinhVien_ChuaDat.ShowDialog();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            //GUI_ThongKe_SinhVien_QueQuan sinhVien_QueQuan = new GUI_ThongKe_SinhVien_QueQuan();
            //sinhVien_QueQuan.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            GUI_ThongKe_SinhVien_DiemCao sinhVien_DiemCao = new GUI_ThongKe_SinhVien_DiemCao();
            sinhVien_DiemCao.ShowDialog();
        }
    }
}
