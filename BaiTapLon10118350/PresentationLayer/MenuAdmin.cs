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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_Khoa gUI_Khoa = new GUI_Khoa();
            gUI_Khoa.ShowDialog();
            this.Close();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_Lop gUI_Lop = new GUI_Lop();
            gUI_Lop.ShowDialog();
            this.Close();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MonHoc gUI_Mon = new GUI_MonHoc();
            gUI_Mon.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_ThongKe  gUI_ThongKe= new GUI_ThongKe();
            gUI_ThongKe.ShowDialog();
            this.Close();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_Diem gUI_Diem = new GUI_Diem();
            gUI_Diem.ShowDialog();
            this.Close();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_SinhVien gUI_SinhVien = new GUI_SinhVien();
            gUI_SinhVien.ShowDialog();
            this.Close();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            label4.Text = "User: " + Properties.Settings.Default.UserName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có đổi tài khoản?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
