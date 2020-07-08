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
namespace BaiTapLon10118350.PresentationLayer
{
    public partial class GUI_ThongKe_SinhVien_Lop : Form
    {
        public GUI_ThongKe_SinhVien_Lop()
        {
            InitializeComponent();
        }
        BUS_SinhVien busSinhVien = new BUS_SinhVien();
        BUS_Lop BUS_Lop = new BUS_Lop();
        private void GUI_ThongKe_SinhVien_Lop_Load(object sender, EventArgs e)
        {
            cbbKhoa.DataSource = BUS_Lop.GetLop();
            cbbKhoa.DisplayMember = "tenLop";
            cbbKhoa.ValueMember = "maLop";

            dataGridView1.DataSource = busSinhVien.ThongKeGetSinhVienTheoLop(cbbKhoa.SelectedValue.ToString());

            lblSoLuong.Text = "    " + busSinhVien.SoLuongGetSinhVienTheoLop(cbbKhoa.SelectedValue.ToString()).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busSinhVien.ThongKeGetSinhVienTheoLop(cbbKhoa.SelectedValue.ToString());

            lblSoLuong.Text = "    " + busSinhVien.SoLuongGetSinhVienTheoLop(cbbKhoa.SelectedValue.ToString()).ToString();
        }
    }
}
