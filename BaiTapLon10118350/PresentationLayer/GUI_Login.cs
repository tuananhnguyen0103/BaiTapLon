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
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
            Load_Data();
        }


        BUS_Acount bUS_Acount = new BUS_Acount();


        public void Load_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUser.Text = Properties.Settings.Default.UserName;
                txtPass.Text = Properties.Settings.Default.Password;
                checkRemember.Checked = true;
            }
            else
            {
                txtUser.Text = Properties.Settings.Default.UserName;
            }
        }
        public void Save_Data()
        {
            if (checkRemember.Checked)
            {
                Properties.Settings.Default.UserName = txtUser.Text;
                Properties.Settings.Default.Password = txtPass.Text;
                Properties.Settings.Default.Remember = "yes";
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.UserName = txtUser.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = "no";
                Properties.Settings.Default.Save();
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (bUS_Acount.KiemTraAcount(txtUser.Text, txtPass.Text) != 1)
            {
                MessageBox.Show("Tài khoản mật khẩu không tồn tại");
            }
            else
            {
                if (bUS_Acount.GetPosition(txtUser.Text) == "admin")
                {
                    
                    Save_Data();
                    MenuAdmin menuAdmin = new MenuAdmin();
                    menuAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tạo đi nhé");
                }
            }
        }
    }
}
