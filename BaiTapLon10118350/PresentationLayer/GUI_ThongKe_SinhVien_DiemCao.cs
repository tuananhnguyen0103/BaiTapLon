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
    public partial class GUI_ThongKe_SinhVien_DiemCao : Form
    {
        public GUI_ThongKe_SinhVien_DiemCao()
        {
            InitializeComponent();
        }
        BUS_SinhVien busSinhVien = new BUS_SinhVien();
        private void lblSoLuong_Click(object sender, EventArgs e)
        {

        }
        int diem1;
        int diem2;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                diem2 = int.Parse(d2.Text.Trim());
                diem1 = int.Parse(d1.Text.Trim());
                if (diem1 > diem2)
                {
                    MessageBox.Show("Chọn điểm bên trái thấp hơn bên phải");
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                    diem2 = int.Parse(d2.Text.Trim());
                    diem1 = int.Parse(d1.Text.Trim());
                    dataGridView1.DataSource = busSinhVien.GetSinhVienTheoDiem(diem1, diem2);

                    lblSoLuong.Text = busSinhVien.SoLuongGetSinhVienTheoDiem(diem1, diem2).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                button1.Enabled = false;
            }
            
        }

        private void GUI_ThongKe_SinhVien_DiemCao_Load(object sender, EventArgs e)
        {
            d2.Text = "9";
            d1.Text = "5";
            diem2 = int.Parse(d2.Text.Trim());
            diem1 = int.Parse(d1.Text.Trim());
            button1.Enabled = true;

            dataGridView1.DataSource = busSinhVien.GetSinhVienTheoDiem(diem1, diem2);

            lblSoLuong.Text = busSinhVien.SoLuongGetSinhVienTheoDiem(diem1, diem2).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
