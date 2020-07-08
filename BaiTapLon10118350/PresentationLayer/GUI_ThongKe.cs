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
    public partial class GUI_ThongKe : Form
    {
        public GUI_ThongKe()
        {
            InitializeComponent();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            GUI_ThongKe_SinhVien ke_SinhVien = new GUI_ThongKe_SinhVien();
            ke_SinhVien.ShowDialog();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            
        }
    }
}
