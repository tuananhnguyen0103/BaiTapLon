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


namespace BaiTapLon10118350.PresentationLayer
{
    public partial class GUI_SinhVien : Form
    {
        public GUI_SinhVien()
        {
            InitializeComponent();
        }
        BUS_SinhVien busSinhVien = new BUS_SinhVien();
        string maSinhVien;
        string maLop;
        string tenLop;
        string tenSinhVien;
        string queQuan;
        DateTime ngaySinh;
        string gioiTinh;
        int gioiTinhBit;
        void Xoa()
        {
            foreach (Control item in tableLayoutPanel3.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            errorProvider1.Clear();
        }
        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void ngaySinh_ValueChanged(object sender, EventArgs e)
        {
            ngaySinh = DateTime.Parse(DateNgaySinh.Value.ToShortDateString());
        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
