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
    public partial class GUI_MonHoc : Form
    {
        public GUI_MonHoc()
        {
            InitializeComponent();
        }
        BUS_MonHoc busMonHoc = new BUS_MonHoc();
        string maMonHoc;
        string tenMonHoc;
        int soTC;
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
        void ChoPhep()
        {
            btnThem.Enabled = true; 
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        void KhongChoPhep()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaMH, "Mã môn học không được để trống");
                KhongChoPhep();
            }
            else
            {
                ChoPhep();
                errorProvider1.Clear();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maMonHoc = txtMaMH.Text.Trim();
            tenMonHoc = txtTenMonHoc.Text.Trim();
            soTC = int.Parse(cbbSTC.Text.Trim());
            DTO_MonHoc MonHoc = new DTO_MonHoc(maMonHoc, tenMonHoc, soTC);
            if (busMonHoc.KiemTraMaTrung(maMonHoc) == 1)
            {
                MessageBox.Show("Đã tồn tại mã lớp! Mời bạn nhập lại!");
            }
            else
            {
                try
                {
                    MessageBox.Show("Bạn đã thêm thành công");
                    busMonHoc.ThemMonHoc(MonHoc);
                    dataGridView1.DataSource = busMonHoc.GetMonHoc();
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
            maMonHoc = txtMaMH.Text.Trim();
            tenMonHoc = txtTenMonHoc.Text.Trim();
            soTC = int.Parse(cbbSTC.Text.Trim());
            DTO_MonHoc MonHoc = new DTO_MonHoc(maMonHoc, tenMonHoc, soTC);
            if (busMonHoc.KiemTraMaTrung(maMonHoc) == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 môn học để sửa");
            }
            else
            {
                try
                {
                    MessageBox.Show("Bạn đã sửa thành công");
                    busMonHoc.SuaMonHoc(maMonHoc, MonHoc);
                    dataGridView1.DataSource = busMonHoc.GetMonHoc();
                    Xoa();
                }
                catch (Exception A)
                {
                    MessageBox.Show(A.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                maMonHoc = txtMaMH.Text.Trim();
                try
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    busMonHoc.XoaMonHoc(maMonHoc);
                    dataGridView1.DataSource = busMonHoc.GetMonHoc();
                    Xoa();
                }
                catch (Exception A)
                {
                    MessageBox.Show(A.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GUI_MonHocReport gUI_MonHocReport = new GUI_MonHocReport();
            gUI_MonHocReport.ShowDialog();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Xoa();
            KhongChoPhep();
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
        private void cbbSTC_SelectedValueChanged(object sender, EventArgs e)
        {
            soTC = int.Parse(cbbSTC.SelectedItem.ToString().Trim());
        }

        private void cbbSTC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                soTC = int.Parse(cbbSTC.SelectedItem.ToString().Trim());
                if (soTC < 1 || soTC > 8)
                {
                    errorProvider1.SetError(cbbSTC, "Số tín chỉ trong khoảng từ 1-8");
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;

                }
                else
                {
                    errorProvider1.Clear();
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                }
            }
            catch
            {
                errorProvider1.SetError(cbbSTC, "Số tín chỉ phải là số");
                btnThem.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void txtTenMonHoc_TextChanged(object sender, EventArgs e)
        {
            if (txtTenMonHoc.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenMonHoc, "Tên môn học không được để trống");
                KhongChoPhep();

            }
            else
            {
                ChoPhep();
                errorProvider1.Clear();
            }
        }

        private void GUI_MonHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busMonHoc.GetMonHoc();
            KhongChoPhep();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Hang = e.RowIndex;
                txtMaMH.Text = dataGridView1[0, Hang].Value.ToString().Trim();
                txtTenMonHoc.Text = dataGridView1[1, Hang].Value.ToString().Trim();
                cbbSTC.Text = dataGridView1[2, Hang].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bên trong bảng");
                errorProvider1.Clear();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busMonHoc.FindGetMonHoc(txtFind.Text);
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
