using BibitKu.Controllers;
using System;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class RegisterControll : Form
    {
        public event EventHandler KembaliKeLogin;

        public RegisterControll()
        {
            InitializeComponent();
            registerControl1.KembaliKeLogin += RegisterControl1_KembaliKeLogin;
        }

        private void RegisterControl1_KembaliKeLogin(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KembaliKeLogin?.Invoke(this, EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void registerControl1_Load(object sender, EventArgs e) { }
    }
}