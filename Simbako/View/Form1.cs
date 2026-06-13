using Simbako.Repository;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class Form1 : Form
    {
        private readonly Form1Repository repo;

        public Form1()
        {
            InitializeComponent();
            repo = new Form1Repository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username dan password tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (repo.Login(txtUsername.Text, txtPassword.Text))
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormPetani formPetani = new FormPetani();
            formPetani.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }

        // Event kosong biar Designer aman
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void lbPassword_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
