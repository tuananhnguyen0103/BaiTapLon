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
    public partial class GUI_Lop : Form
    {
        public GUI_Lop()
        {
            InitializeComponent();
        }
        BUS_Lop busLop = new BUS_Lop();
        string maLop;
        string maKhoa;
        string tenLop;
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
        
        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaLop, "Mã lớp không được để trống");
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cbbKhoa_TextChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.Text.Trim() == "")
            {
                errorProvider1.SetError(cbbKhoa, "Khoa không được để trống");
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
                errorProvider1.Clear();
            }
        }
        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLop.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenLop, "Tên lớp không được để trống");
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
            GUI_LopReport gUI_LopReport = new GUI_LopReport();
            gUI_LopReport.ShowDialog();
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
                maLop = txtMaLop.Text.Trim();
                try
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    busLop.XoaLop(maLop);
                    dataGridView1.DataSource = busLop.GetLop();
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
            maLop = txtMaLop.Text.Trim();
            tenLop = txtTenLop.Text.Trim();
            maKhoa = busLop.GetMaKhoa(cbbKhoa.Text.Trim());
            DTO_Lop Lop = new DTO_Lop(maLop, maKhoa, tenLop);

            try
            {
                MessageBox.Show("Bạn đã sửa thành công");
                busLop.SuaLop(maLop, Lop);
                dataGridView1.DataSource = busLop.GetLop();
                Xoa();
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maLop = txtMaLop.Text.Trim();
            tenLop = txtTenLop.Text.Trim();
            maKhoa = busLop.GetMaKhoa(cbbKhoa.Text.Trim());
            DTO_Lop Lop = new DTO_Lop(maLop, maKhoa, tenLop);
            if (busLop.KiemTraMaTrung(maLop) == 1)
            {
                MessageBox.Show("Đã tồn tại mã lớp! Mời bạn nhập lại");
            }
            else
            {
                try
                {
                    MessageBox.Show(maLop + maKhoa + tenLop);
                    MessageBox.Show("Bạn đã thêm thành công");
                    busLop.ThemLop(Lop);
                    dataGridView1.DataSource = busLop.GetLop();
                    Xoa();
                }
                catch (Exception A)
                {
                    MessageBox.Show(A.Message);
                }
            }
        }

        private void GUI_Lop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busLop.GetLop();
            cbbKhoa.DataSource = busLop.GetKhoa();
            cbbKhoa.DisplayMember = "tenKhoa";
            cbbKhoa.ValueMember = "maKhoa";

            cbbSearch.DataSource = busLop.GetKhoa();
            cbbSearch.DisplayMember = "tenKhoa";
            cbbSearch.ValueMember = "maKhoa";
            btnThem.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Hang = e.RowIndex;
                txtMaLop.Text = dataGridView1[0, Hang].Value.ToString();
                cbbKhoa.Text = busLop.GetTenKhoa(dataGridView1[1, Hang].Value.ToString());
                txtTenLop.Text = dataGridView1[2, Hang].Value.ToString();
                errorProvider1.Clear();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bên trong bảng");
                errorProvider1.Clear();
            }
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ThongTinLop_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busLop.GetLop();
        }

        private void btn_SearchKhoa_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busLop.GetLopTheoKhoa(cbbSearch.SelectedValue.ToString());
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busLop.FindGetLop(txtFind.Text.Trim());
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
