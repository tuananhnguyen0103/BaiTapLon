using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTapLon10118350.DataAccessLayer.DataAccess;

namespace BaiTapLon10118350.PresentationLayer
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            string stringConnect =string.Format( @"Data Source=DESKTOP-DCMU7ET;Initial Catalog=BTLWinFormQuanLyDiemSinhVien;User ID={0};Password={1}",txtUser.Text.Trim(),txtPassword.Text.Trim());
            
        }
    }
}
