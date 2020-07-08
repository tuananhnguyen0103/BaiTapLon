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
    public partial class GUI_Khoa : Form
    {
        BUS_Khoa busKhoa = new BUS_Khoa();
        public GUI_Khoa()
        {
            InitializeComponent();
        }
        string maKhoa;
        string tenKhoa;
        string vanPhongKhoa;
        string soDienThoai;
        Regex regexSDT = new Regex("[0][0-9]");
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
        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {

            if (txtMaKhoa.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaKhoa, "Mã khoa của Khoa không được để trống");
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                errorProvider1.Clear();
            }
        }


        private void txtTenKhoa_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKhoa.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenKhoa, "Tên của Khoa không được để trống");
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void txtVPK_TextChanged(object sender, EventArgs e)
        {
            if (txtVPK.Text.Trim() == "")
            {
                errorProvider1.SetError(txtVPK, "Văn phòng của Khoa không được để trống");
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại của Khoa không được để trống");
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                errorProvider1.Clear();
            }


            if (!regexSDT.IsMatch(txtSDT.Text) || txtSDT.Text.Trim().Length != 11)
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại của Khoa phải là 11 chữ số và bắt đầu bằng 0");
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            UserControl1 ReportKhoa = new UserControl1();
            ReportKhoa.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.ShowDialog();
                this.Close();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                maKhoa = txtMaKhoa.Text.Trim();
                try
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    busKhoa.XoaKhoa(maKhoa);
                    dtgridview.DataSource = busKhoa.GetKhoa();
                    Xoa();
                }
                catch (Exception A)
                {
                    MessageBox.Show(A.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            maKhoa = txtMaKhoa.Text.Trim();
            tenKhoa = txtTenKhoa.Text.Trim();
            vanPhongKhoa = txtVPK.Text.Trim();
            soDienThoai = txtSDT.Text.Trim();

            DTO_Khoa khoa = new DTO_Khoa(maKhoa, tenKhoa, vanPhongKhoa, soDienThoai);

            try
            {
                MessageBox.Show("Bạn đã sửa thành công");
                busKhoa.SuaKhoa(maKhoa, khoa);
                dtgridview.DataSource = busKhoa.GetKhoa();
                Xoa();
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maKhoa = txtMaKhoa.Text.Trim();
            tenKhoa = txtTenKhoa.Text.Trim();
            vanPhongKhoa = txtVPK.Text.Trim();
            soDienThoai = txtSDT.Text.Trim();

            DTO_Khoa khoa = new DTO_Khoa(maKhoa, tenKhoa, vanPhongKhoa, soDienThoai);
            if (busKhoa.KiemTraMaTrung(maKhoa) == 1)
            {
                MessageBox.Show("Đã tồn tại mã khoa! Mời bạn nhập lại");
            }
            else
            {
                try
                {
                    MessageBox.Show("Bạn đã thêm thành công");
                    busKhoa.ThemKhoa(khoa);
                    dtgridview.DataSource = busKhoa.GetKhoa();
                    Xoa();
                }
                catch (Exception A)
                {
                    MessageBox.Show(A.Message);
                }
            }
        }

        private void dtgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Hang = e.RowIndex;
                txtMaKhoa.Text = dtgridview[0, Hang].Value.ToString();
                txtTenKhoa.Text = dtgridview[1, Hang].Value.ToString();
                txtVPK.Text = dtgridview[2, Hang].Value.ToString();
                txtSDT.Text = dtgridview[3, Hang].Value.ToString();
                errorProvider1.Clear();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bên trong bảng");
                errorProvider1.Clear();
            }
        }

        private void GUI_Khoa_Load(object sender, EventArgs e)
        {
            dtgridview.DataSource = busKhoa.GetKhoa();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/");
        }

        private void txtFind_TextChanged_1(object sender, EventArgs e)
        {
            dtgridview.DataSource = busKhoa.FindGetKhoa(txtFind.Text.Trim());
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
