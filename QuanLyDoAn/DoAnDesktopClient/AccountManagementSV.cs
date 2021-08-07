using DBStore.DAO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace DoAnDesktopClient
{
    public partial class AccountManagementSV : Form
    {
        string host = "https://localhost:44390/api/sinhvien";

        public MainForm MainForm { get; }

        public AccountManagementSV(MainForm mainForm)
        {
            InitializeComponent();
            this.MainForm = mainForm;
        }
        private void GetListSinhVien()
        {
            List<SinhVien> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(host);
                //HTTP GET
                var responseTask = client.GetAsync("SinhVien");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<SinhVien>>();
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
                dataGridView1.Rows.Add(item.MaSV, item.TenSV, item.PassWord);
            }
        }
        private void AddSinhVien()
        {
            if (txtTenSV.Text.Length == 0 || txtPass.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập tên hoặc mật khẩu sv");
                return;
            }
            SinhVien sinhvien = new SinhVien(txtTenSV.Text, txtPass.Text);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(host);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<SinhVien>("sinhvien", sinhvien);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm sinh viên thành công");
                    GetListSinhVien();
                }
            }
        }
        string ten;
        string pass;
        private void UpdateSinhVien()
        {
            if (ten==txtTenSV.Text&&pass==txtPass.Text)
            {
                MessageBox.Show("Thông tin sv chưa thay đổi nên không cần update");
                return;
            }
            if (maSV != null)
            {
                SinhVien sinhvien = new SinhVien(maSV, txtTenSV.Text, txtPass.Text);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(host);

                    //HTTP POST
                    var postTask = client.PutAsJsonAsync<SinhVien>("sinhvien", sinhvien);

                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cập nhật thông tin sinh viên thành công");
                        GetListSinhVien();
                    }
                }
            }
        }
        private void DeleteSinhVien()
        {
            if (maSV != null)
            {
                SinhVien sinhvien = new SinhVien(maSV, txtTenSV.Text, txtPass.Text);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(host);

                    //HTTP POST
                    var postTask = client.DeleteAsync(host + "?maSV=" + maSV);

                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xóa thông tin sinh viên thành công");
                        GetListSinhVien();
                    }
                }
            }
        }
        private void AccountManagementSV_Load(object sender, EventArgs e)
        {
            GetListSinhVien();
        }

        private void AccountManagementSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }
        string maSV=null;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                ten=txtTenSV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                pass=txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                maSV = txtMaSV.Text;
            }
            catch
            {
                maSV = null;
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

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
