using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTapLon10118350.BusinessLayer;
using BaiTapLon10118350.DataAccessLayer.Entity;
using System.Text.RegularExpressions;

namespace BaiTapLon10118350.PresentationLayer
{
    public partial class GUI_ThongKe_SinhVien_Khoa : Form
    {
        public GUI_ThongKe_SinhVien_Khoa()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busSinhVien.GetSinhVienTheoKhoa(cbbKhoa.SelectedValue.ToString());

            lblSoLuong.Text = "    " + busSinhVien.SoLuongGetSinhVienTheoKhoa(cbbKhoa.SelectedValue.ToString()).ToString();
        }
        BUS_SinhVien busSinhVien = new BUS_SinhVien();
        BUS_Khoa BUS_Khoa = new BUS_Khoa();
        private void GUI_ThongKe_SinhVien_Khoa_Load(object sender, EventArgs e)
        {
            cbbKhoa.DataSource = BUS_Khoa.GetKhoa();
            cbbKhoa.DisplayMember = "tenKhoa";
            cbbKhoa.ValueMember = "maKhoa";

            dataGridView1.DataSource = busSinhVien.GetSinhVienTheoKhoa(cbbKhoa.SelectedValue.ToString());

            lblSoLuong.Text = "    " + busSinhVien.SoLuongGetSinhVienTheoKhoa(cbbKhoa.SelectedValue.ToString()).ToString();
        }
    }
}
