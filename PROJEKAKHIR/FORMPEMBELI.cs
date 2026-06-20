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

            // Tampilkan yang dipilih
            targetControl.Visible = true;

            // Pindahkan SidePanel ke posisi tombol yang aktif
            SidePanel.Height = activeButton.Height;
            SidePanel.Top = activeButton.Top;
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
            ShowPanel(keranjang1, buttonKeranjang);
        }

        private void buttonRiwayat_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRiwayat_Click_1(object sender, EventArgs e)
        {
            ShowPanel(riwayatTransaksi1, buttonRiwayat);
        }
    }
}