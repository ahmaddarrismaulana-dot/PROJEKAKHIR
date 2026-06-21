using System;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class Formauth : Form
    {
        public Formauth()
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
        private void registerControl1_Load(object sender, EventArgs e)
        {

        }
    }
}