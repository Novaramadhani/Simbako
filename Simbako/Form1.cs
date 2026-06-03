using System;
using System.Windows.Forms;

namespace SIMBAKO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tombol Login Admin
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

        // Tombol Masuk sebagai Petani
        private void btnPetani_Click(object sender, EventArgs e)
        {
            FormPetani formPetani = new FormPetani();
            formPetani.Show();
            this.Hide();
        }

        // Tombol Masuk sebagai Customer
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }
    }
}