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
    public partial class GUI_ThongKe_SinhVien_MonHoc : Form
    {
        public GUI_ThongKe_SinhVien_MonHoc()
        {
            InitializeComponent();
        }
        BUS_SinhVien busSinhVien = new BUS_SinhVien();
        BUS_MonHoc BUS_Mon = new BUS_MonHoc();
        private void GUI_ThongKe_SinhVien_MonHoc_Load(object sender, EventArgs e)
        {
            cbbKhoa.DataSource = BUS_Mon.GetMonHoc();
            cbbKhoa.DisplayMember = "tenMonHoc";
            cbbKhoa.ValueMember = "maMonHoc";

            dataGridView1.DataSource = busSinhVien.GetSinhVienTheoMonHoc(cbbKhoa.SelectedValue.ToString());

            lblSoLuong.Text = "    " + busSinhVien.SoLuongGetSinhVienTheoMonHoc(cbbKhoa.SelectedValue.ToString()).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busSinhVien.GetSinhVienTheoMonHoc(cbbKhoa.SelectedValue.ToString());

            lblSoLuong.Text = "    " + busSinhVien.SoLuongGetSinhVienTheoMonHoc(cbbKhoa.SelectedValue.ToString()).ToString();
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
