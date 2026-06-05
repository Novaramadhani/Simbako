using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Wajib ada - Designer: label1_Click (dipakai lbUsername dan lb)
        private void label1_Click(object sender, EventArgs e) { }

        // Wajib ada - Designer: label2_Click
        private void label2_Click(object sender, EventArgs e) { }

        // Wajib ada - Designer: lbPassword_Click
        private void lbPassword_Click(object sender, EventArgs e) { }

        // Wajib ada - Designer: panel1_Paint
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        // Wajib ada - Designer: label1_Click_1 (dipakai lb)
        private void label1_Click_1(object sender, EventArgs e) { }

        // Wajib ada - Designer: label3_Click
        private void label3_Click(object sender, EventArgs e) { }

        // Tombol Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username dan password tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Admin admin = new Admin();
            if (admin.Login(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Login berhasil!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDashboardAdmin dashboard = new FormDashboardAdmin();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Wajib ada - Designer: btnPetani.Click += button1_Click (BUKAN btnPetani_Click!)
        private void button1_Click(object sender, EventArgs e)
        {
            FormPetani formPetani = new FormPetani();
            formPetani.Show();
            this.Hide();
        }

        // Tombol Customer
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }
    }
}