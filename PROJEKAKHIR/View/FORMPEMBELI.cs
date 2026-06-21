using BibitKu.Views;
using BibitKu.Helpers;
namespace PROJEKAKHIR
{
    public partial class FormPembeli : Form
    {
        public FormPembeli()
        {
            InitializeComponent();
        }
        private void ShowPanel(Control targetControl, Button activeButton)
        {
            // Sembunyikan semua user control
            keranjang1.Visible = false;
            riwayatTransaksi1.Visible = false;
            katalog1.Visible = false;
            checkout1.Visible = false;

            // Tampilkan yang dipilih
            targetControl.Visible = true;

            // Pindahkan SidePanel ke posisi tombol yang aktif
            SidePanel.Height = activeButton.Height;
            SidePanel.Top = activeButton.Top;
        }
        public void PindahKeCheckout(List<PROJEKAKHIR.Models.Keranjang> items)
        {
            checkout1.LoadDataCheckout(items);
            ShowPanel(checkout1, buttonCheckout);
        }

        private void FormPembeli_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel(katalog1, button1);
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonKeranjang_Click(object sender, EventArgs e)
        {
            keranjang1.RefreshKeranjang();
            ShowPanel(keranjang1, buttonKeranjang);
        }

        private void buttonRiwayat_Click(object sender, EventArgs e)
        {

        }

        private void buttonRiwayat_Click_1(object sender, EventArgs e)
        {
            riwayatTransaksi1.RefreshData();
            ShowPanel(riwayatTransaksi1, buttonRiwayat);
        }

        private void buttonCheckout_Click(List<PROJEKAKHIR.Models.Keranjang> items)
        {
            checkout1.LoadDataCheckout(items);
            ShowPanel(checkout1, buttonCheckout);

        }

        private void checkout1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show(
               "Yakin ingin logout?",
               "Logout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                Session.Logout();

                // Buka kembali form login
                var login = new FormLogin();
                login.Show();
                this.Close();
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            ShowPanel(checkout1, buttonCheckout);
        }
    }
}