using DBStore.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDesktopClient
{
    public partial class AccountManagementGV : Form
    {
        string host = "https://localhost:44390/api/giaovien";
        string maGV = null;
        public MainForm MainForm { get; }
        public AccountManagementGV(MainForm mainForm)
        {
            this.MainForm = mainForm;
            InitializeComponent();
        }
        private void GetListSinhVien()
        {
            List<GiaoVien> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(host);
                //HTTP GET
                var responseTask = client.GetAsync("GiaoVien");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<GiaoVien>>();
                    readTask.Wait();
                    list = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..    
                }
            }
            dataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                dataGridView1.Rows.Add(item.MaGV, item.TenGV, item.PassWord);
            }
        }
        private void AddSinhVien()
        {
            if (txtTenSV.Text.Length == 0 || txtPass.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập tên hoặc mật khẩu gv");
                return;
            }
            GiaoVien giaovien = new GiaoVien(txtTenSV.Text, txtPass.Text);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(host);
                //HTTP POST
                var postTask = client.PostAsJsonAsync<GiaoVien>("giaovien", giaovien);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm giao viên thành công");
                    GetListSinhVien();
                }
            }
        }
        string ten;
        string pass;
        private void UpdateSinhVien()
        {
            if (ten == txtTenSV.Text && pass == txtPass.Text)
            {
                MessageBox.Show("Thông tin gv chưa thay đổi nên không cần update");
                return;
            }
            if (maGV != null)
            {
                var giaovien = new GiaoVien(maGV, txtTenSV.Text, txtPass.Text);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(host);

                    //HTTP POST
                    var postTask = client.PutAsJsonAsync<GiaoVien>("GiaoVien", giaovien);

                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cập nhật thông tin gv thành công");
                        GetListSinhVien();
                    }
                }
            }
        }
        private void DeleteSinhVien()
        {
            if (maGV != null)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(host);

                    //HTTP POST
                    var postTask = client.DeleteAsync(host + "?maGV=" + maGV);

                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xóa thông tin gv thành công");
                        GetListSinhVien();
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSinhVien();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSinhVien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSinhVien();
        }

        private void AccountManagementGV_Load(object sender, EventArgs e)
        {
            GetListSinhVien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                ten = txtTenSV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                pass = txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                maGV = txtMaSV.Text;
            }
            catch
            {
                maGV = null;
            }
        }

        private void AccountManagementGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }
    }
}
