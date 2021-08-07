using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassWord.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "phamthuy" && txtPassWord.Text == "12345678*")
            {

            }
        }
    }
}
