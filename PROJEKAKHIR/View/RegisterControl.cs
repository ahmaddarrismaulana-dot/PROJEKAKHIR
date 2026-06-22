using BibitKu.Controllers;
using BibitKu.Models;
using System;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class RegisterControl : UserControl
    {
        private readonly RegisterController controller = new RegisterController();

        public event EventHandler KembaliKeLogin;

        public RegisterControl()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Buat objek Pembeli dari input form
            var pembeli = new Pembeli
            {
                Nama = guna2TextBox1.Text.Trim(),
                Email = guna2TextBox2.Text.Trim(),
                Password = guna2TextBox3.Text,
                NoTelpon = guna2TextBox4.Text.Trim(),
                Alamat = guna2TextBox5.Text.Trim()
            };

            // Validasi via controller
            string pesanError = controller.ValidasiInput(pembeli);
            if (pesanError != null)
            {
                MessageBox.Show(
                    pesanError,
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Proses registrasi
            string hasil = controller.RegisterPembeli(pembeli);

            if (hasil == "SUCCESS")
            {
                MessageBox.Show(
                    "Registrasi berhasil. Silakan login.",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KembaliKeLogin?.Invoke(this, EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox4_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox5_TextChanged(object sender, EventArgs e) { }
    }
}