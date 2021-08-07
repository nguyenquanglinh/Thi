using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDesktopClient
{
    public partial class MainForm : Form
    {
        public MainForm(Login login)
        {
            InitializeComponent();
            this.Login = login;
        }

        public Login Login { get; }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Show();
        }

        private void btnSVMng_Click(object sender, EventArgs e)
        {
            new AccountManagementSV(this).Show();
            this.Hide();
        }

        private void btnGVMng_Click(object sender, EventArgs e)
        {
            new AccountManagementGV(this).Show();
            this.Hide();
        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chua lam");
        }
    }
}
