using BibitKu.Controllers;
using System;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class RegisterControll : Form
    {
        private RegisterController controller =
            new RegisterController();

        public event EventHandler KembaliKeLogin;

        public RegisterControll()
        {
            InitializeComponent();
            registerControl1.KembaliKeLogin +=
              RegisterControl1_KembaliKeLogin;
        }
        private void RegisterControl1_KembaliKeLogin(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
        private void guna2Button1_Click(
            object sender,
            EventArgs e)
        {
            string nama = guna2TextBox1.Text.Trim();
            string email = guna2TextBox2.Text.Trim();
            string password = guna2TextBox3.Text;
            string noTelpon = guna2TextBox4.Text.Trim();
            string alamat = guna2TextBox5.Text.Trim();
            string pesanError = controller.ValidasiInput(nama, email, password, noTelpon, alamat);

            if (pesanError != null)
            {
                MessageBox.Show(
                    pesanError,
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(nama) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Nama, email, dan password wajib diisi!",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string hasil = controller.RegisterPembeli(
                nama,
                email,
                password,
                noTelpon,
                alamat);

            if (hasil == "SUCCESS")
            {
                MessageBox.Show(
                    "Registrasi berhasil. Silakan login.",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Beri tahu Formauth
                KembaliKeLogin?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(
                    hasil,
                    "Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            KembaliKeLogin?.Invoke(this, EventArgs.Empty);
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registerControl1_Load(object sender, EventArgs e)
        {

        }
    }
}