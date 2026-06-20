using BibitKu.Helpers;
using BibitKu.Models;
namespace PROJEKAKHIR
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser is Penjual penjual)
            {
                MessageBox.Show(
                    $"ID User : {penjual.Id}\n" +
                    $"ID Toko : {Session.IdToko}\n" +
                    $"Nama : {penjual.Nama}\n" +
                    $"Toko : {penjual.NamaToko}"
                );
            }

            ShowPanel(kelolaBibit2, button1);
        }

        private void ShowPanel(Control targetControl, Button activeButton)
        {
            // Sembunyikan semua user control
            kelolaBibit2.Visible = false;
            manajemenStok1.Visible = false;
            transaksiMasuk1.Visible = false;

            // Tampilkan yang dipilih
            targetControl.Visible = true;

            // Pindahkan SidePanel ke posisi tombol yang aktif
            SidePanel.Height = activeButton.Height;
            SidePanel.Top = activeButton.Top;
        }

        // Kelola Bibit → button1
        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel(kelolaBibit2, button1);
        }

        // Manajemen Stok → button2
        private void button2_Click(object sender, EventArgs e)
        {
            ShowPanel(manajemenStok1, button2);
            manajemenStok1.Mengulangdata();
        }

        // Transaksi Masuk → button3
        private void button3_Click(object sender, EventArgs e)
        {
            ShowPanel(transaksiMasuk1, button3);
        }

        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void kelolaBibit1_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void manajemenStok1_Load(object sender, EventArgs e) { }
        private void manajemenStok1_Load_1(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void kelolaBibit1_Load_1(object sender, EventArgs e) { }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}