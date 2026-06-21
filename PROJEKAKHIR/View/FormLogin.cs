using System;
using System.Drawing;
using System.Windows.Forms;
using BibitKu.Controllers;
using BibitKu.Models;
using BibitKu.Helpers;
using PROJEKAKHIR;

namespace BibitKu.Views   
{
    public partial class FormLogin : Form
    {
        private readonly LoginController _controller;

        public FormLogin()
        {
            InitializeComponent();
            _controller = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            string pesanError = _controller.ValidasiInput(email, password);
            if (pesanError != null)
            {
                TampilPesan(pesanError, Color.Red);
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Memproses...";
            this.Cursor = Cursors.WaitCursor;

            try
            {
                User user = _controller.Login(email, password);

                if (user == null)
                {
                    TampilPesan("Email, password, atau role tidak sesuai.", Color.Red);
                    return;
                }

                Session.CurrentUser = user;
                TampilPesan("Login berhasil!", Color.Green);
                this.Hide();


                if (user is Penjual penjual)
                {
                    MessageBox.Show(
                        $"Selamat datang, {penjual.Nama}!\nToko: {penjual.NamaToko}",
                        "Login Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    Form1 frpenjual = new Form1();
                    frpenjual.Show();
                }
                else if (user is Pembeli pembeli)
                {
                    MessageBox.Show(
                        $"Selamat datang, {pembeli.Nama}!",
                        "Login Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    FormPembeli fr = new FormPembeli();
                    fr.Show();
                }
            }
            catch (Exception ex)
            {
                TampilPesan("Koneksi error: " + ex.Message, Color.Red);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Masuk";
                this.Cursor = Cursors.Default;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkTampilPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkTampilPassword.Checked ? '\0' : '●';
        }

        private void TampilPesan(string pesan, Color warna)
        {
            lblPesan.Text = pesan;
            lblPesan.ForeColor = warna;
        }

        private void linkLabel1_LinkClicked(object sender,LinkLabelLinkClickedEventArgs e)
        {
            RegisterControll auth = new RegisterControll();

            this.Hide();

            auth.ShowDialog();

            this.Show();
        }
    }
}