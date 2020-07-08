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
    public partial class GUI_Diem : Form
    {
        public GUI_Diem()
        {
            InitializeComponent();
        }
        BUS_Diem busDien = new BUS_Diem();
        string maSinhVien;
        string maMonHoc;
        int kiHoc;
        float diemLan1;
        float diemLan2;
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
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busDien.FindGetDiem(txtFind.Text);
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Xoa();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            GUI_DiemReport gUI_DiemReport = new GUI_DiemReport();
            gUI_DiemReport.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.ShowDialog();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                maMonHoc = cbbMonHoc.SelectedValue.ToString().Trim();
                maSinhVien = cbbSinhVien.SelectedValue.ToString().Trim();
                try
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    busDien.XoaKhoa(maSinhVien,maMonHoc);
                    dataGridView1.DataSource = busDien.GetDiem();
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

            maMonHoc = cbbMonHoc.SelectedValue.ToString().Trim();
            maSinhVien = cbbSinhVien.SelectedValue.ToString().Trim();
            kiHoc = int.Parse(cbbKiHoc.SelectedItem.ToString().Trim());
            diemLan1 = float.Parse(txtDiemL1.Text.Trim());
            diemLan2 = float.Parse(txtDieml2.Text.Trim());

            DTO_Diem Diem = new DTO_Diem(maMonHoc, maSinhVien, kiHoc, diemLan1, diemLan2);

            try
            {
                MessageBox.Show("Bạn đã sửa thành công");
                busDien.SuaDiem(maSinhVien,maMonHoc,Diem);
                dataGridView1.DataSource = busDien.GetDiem();
                Xoa();
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            maMonHoc = cbbMonHoc.SelectedValue.ToString().Trim();
            maSinhVien = cbbSinhVien.SelectedValue.ToString().Trim();
            kiHoc = int.Parse(cbbKiHoc.SelectedItem.ToString().Trim());
            diemLan1 = float.Parse(txtDiemL1.Text.Trim());
            diemLan2 = float.Parse(txtDieml2.Text.Trim());

            DTO_Diem Diem = new DTO_Diem(maMonHoc, maSinhVien, kiHoc, diemLan1,diemLan2);
            if (busDien.KiemTraMaTrung(maMonHoc,maSinhVien) == 1)
            {
                MessageBox.Show("Đã tồn tại sinh viên với môn học! Mời bạn nhập lại");
            }
            else
            {
                try
                {
                    MessageBox.Show("Bạn đã thêm thành công");
                    busDien.ThemDiem(Diem);
                    dataGridView1.DataSource = busDien.GetDiem();
                    Xoa();
                }
                catch (Exception A)
                {
                    MessageBox.Show(A.Message);
                }
            }

            
        }

        private void GUI_Diem_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busDien.GetDiem();

            cbbMonHoc.DataSource = busDien.GetMonHoc();
            cbbMonHoc.DisplayMember = "tenMonHoc";
            cbbMonHoc.ValueMember = "maMonHoc";

            cbbSinhVien.DataSource = busDien.GetSinHVien();
            cbbSinhVien.DisplayMember = "tenSinhVien";
            cbbSinhVien.ValueMember = "maSinhVien";

            txtMaSV.Text = cbbSinhVien.SelectedValue.ToString();
            txtMaMH.Text = cbbMonHoc.SelectedValue.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void txtDiemL1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDiemL1.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtDiemL1, "Điểm không được để trống");
                    btnThem.Enabled = false;
                }
                else
                {
                    diemLan1 = float.Parse(txtDiemL1.Text);
                    btnThem.Enabled = true;
                    errorProvider1.Clear();
                }
            }
            catch
            {
                errorProvider1.SetError(txtDiemL1,"Vui lòng nhập số");
                btnThem.Enabled = false;
            }
        }

        private void txtDieml2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDieml2.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtDieml2, "Điểm không được để trống");
                    btnThem.Enabled = false;
                }
                else
                {
                    diemLan1 = float.Parse(txtDieml2.Text);
                    btnThem.Enabled = true;
                    errorProvider1.Clear();
                }
            }
            catch
            {
                errorProvider1.SetError(txtDieml2, "Vui lòng nhập số");
                btnThem.Enabled = false;
            }
        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaMH.Text = cbbMonHoc.SelectedValue.ToString();
        }

        private void cbbSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaSV.Text = cbbSinhVien.SelectedValue.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Hang = e.RowIndex;
                txtMaMH.Text = dataGridView1[0, Hang].Value.ToString();
                txtMaSV.Text = dataGridView1[1, Hang].Value.ToString();
                cbbKiHoc.Text = dataGridView1[2, Hang].Value.ToString();
                txtDiemL1.Text = dataGridView1[3, Hang].Value.ToString();
                txtDieml2.Text = dataGridView1[4, Hang].Value.ToString();
                errorProvider1.Clear();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bên trong bảng");
                errorProvider1.Clear();
            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            cbbSinhVien.Text = busDien.GetTenSinHVien(txtMaSV.Text);
        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {
            cbbMonHoc.Text = busDien.GetTenMH(txtMaMH.Text);
        }
    }
}
