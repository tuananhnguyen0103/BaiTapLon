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
        Regex regexTen = new Regex("^[0-9A-Za-z À-Ỹà-ỹ]+$");
        Regex regexQue = new Regex("[a-zA-Z0-9-\\/à-ỹÀ-Ỹ]+$");
        Regex regexSV = new Regex("[S][V][0-9]+$");
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
            gioiTinh = "Nữ";
        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {
            if (txtQueQuan.Text.Trim() == "")
            {
                errorProvider1.SetError(txtQueQuan, "Quê quán không được để trống");
                btnThem.Enabled = false;
            }
            else
            {
                if (!regexQue.IsMatch(txtQueQuan.Text))
                {
                    errorProvider1.SetError(txtQueQuan, "Quê quán không được có số và kí tự đặc biệt");
                    btnThem.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = true;
                    errorProvider1.Clear();
                }
            }
            
        }

        private void ngaySinh_ValueChanged(object sender, EventArgs e)
        {
            ngaySinh = DateTime.Parse(DateNgaySinh.Value.ToShortDateString());
        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSV.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenSV, "Tên sinh viên không được để trống");
                btnThem.Enabled = false;
            }
            else
            {
                if (!regexTen.IsMatch(txtTenSV.Text))
                {
                    errorProvider1.SetError(txtTenSV, "Tên sinh viên không được có số và kí tự đặc biệt");
                    btnThem.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = true;
                    errorProvider1.Clear();
                }
            }
            
        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinh = "Nam";
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không được để trống");
                btnThem.Enabled = false;
            }
            else
            {
                if (!regexSV.IsMatch(txtMaSV.Text)||txtMaSV.Text.Trim().Length>10)
                {
                    errorProvider1.SetError(txtMaSV, "Mã sinh viên bắt đầu bằng SV và gồm 10 kí tự chỉ số");
                    btnThem.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = true;
                    errorProvider1.Clear();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GUI_SinhVienReport gUI_SinhVienReport = new GUI_SinhVienReport();
            gUI_SinhVienReport.ShowDialog();
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
                maSinhVien = txtMaSV.Text.Trim();
                try
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                    busSinhVien.XoaSinhVien(maSinhVien);
                    dataGridView1.DataSource = busSinhVien.GetSinhVien();
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
            maSinhVien = txtMaSV.Text.Trim();
            maLop = cbbLop.SelectedValue.ToString();
            tenSinhVien = txtTenSV.Text.Trim();
            ngaySinh = DateTime.Parse(DateNgaySinh.Value.ToLongDateString());
            string ngaySinhFormat = ngaySinh.ToString("yyyy-MM-dd");
            ngaySinh = DateTime.Parse(ngaySinhFormat);
            queQuan = txtQueQuan.Text.Trim();
            if (rdoNam.Checked)
            {
                gioiTinh = "Nam";
            }
            if(rdoNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            DTO_SinhVien SinhVien = new DTO_SinhVien(maSinhVien, maLop, tenSinhVien,queQuan,ngaySinh,gioiTinh);

            try
            {
                MessageBox.Show("Bạn đã sửa thành công");
                busSinhVien.SuaSinhVien(maSinhVien, SinhVien);
                dataGridView1.DataSource = busSinhVien.GetSinhVien();
                Xoa();
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maSinhVien = txtMaSV.Text.Trim();
            maLop = cbbLop.SelectedValue.ToString();
            tenSinhVien = txtTenSV.Text.Trim();
            ngaySinh = DateTime.Parse(DateNgaySinh.Value.ToShortDateString().ToString());
            queQuan = txtQueQuan.Text.Trim();
            if (rdoNam.Checked)
            {
                gioiTinh = "Nam";
            }
            if (rdoNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            DTO_SinhVien SinhVien = new DTO_SinhVien(maSinhVien,maLop,tenSinhVien,queQuan,ngaySinh,gioiTinh);
            if (busSinhVien.KiemTraMaTrung(maSinhVien) == 1)
            {
                MessageBox.Show("Đã tồn tại mã sinh viên! Mời bạn nhập lại");
            }
            else
            {
                try
                {
                    MessageBox.Show("Bạn đã thêm thành công");
                    busSinhVien.ThemSinhVien(SinhVien);
                    dataGridView1.DataSource = busSinhVien.GetSinhVien();
                    Xoa();
                }
                catch (Exception A)
                {
                    MessageBox.Show(A.Message);
                }
            }
        }

        private void GUI_SinhVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busSinhVien.GetSinhVien();
            cbbLop.DataSource = busSinhVien.GetLop();
            cbbLop.DisplayMember = "tenLop";
            cbbLop.ValueMember = "maLop";

            cbbSearch.DataSource = busSinhVien.GetLop();
            cbbSearch.DisplayMember = "tenLop";
            cbbSearch.ValueMember = "maLop";
        }

        private void btn_SearchLop_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busSinhVien.GetSinhVienTheoLop(cbbSearch.SelectedValue.ToString());
        }

        private void btn_ThongTinSinhVien_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busSinhVien.GetSinhVien();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busSinhVien.GetSinHVienTheoTen(txtFind.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Hang = e.RowIndex;
                txtMaSV.Text = dataGridView1[0, Hang].Value.ToString();
                cbbLop.Text = busSinhVien.GetTenLop(dataGridView1[1, Hang].Value.ToString());
                txtTenSV.Text = dataGridView1[2, Hang].Value.ToString();
                DateNgaySinh.Text = dataGridView1[3, Hang].Value.ToString();
                txtQueQuan.Text = dataGridView1[4, Hang].Value.ToString();
                if (dataGridView1[5, Hang].Value.ToString() == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
                errorProvider1.Clear();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn bên trong bảng");
                errorProvider1.Clear();
            }
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
