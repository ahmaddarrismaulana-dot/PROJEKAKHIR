using BibitKu.Models;
using PROJEKAKHIR.Models;
using BibitKu.Helpers;
using BibitKu.Controllers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class CardBibit : UserControl
    {
        // Menyimpan data bibit yang sedang ditampilkan
        private Bibit bibitData;

        public CardBibit()
        {
            InitializeComponent();

            this.Width = 230;
            this.Height = 380;
        }

        // Property untuk mengambil data bibit dari luar jika diperlukan
        public Bibit BibitData
        {
            get { return bibitData; }
        }

        // Method untuk mengisi card dengan data bibit
        public void SetData(Bibit bibit)
        {
            bibitData = bibit;

            lblNama.Text = bibit.nama_bibit;
            lblHarga.Text = "Rp " + bibit.harga.ToString("N0");
            lblStok.Text = "Stok : " + bibit.stok;
            lblUmur.Text = bibit.umur_bibit;

            // kalau belum ada label kategori, abaikan ini dulu
            // lblKategori.Text = bibit.nama_kategori;

            if (bibit.foto_bibit != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(bibit.foto_bibit))
                    {
                        picBibit.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    picBibit.Image = null;
                }
            }
            else
            {
                picBibit.Image = null;
            }
        }

        // Tombol Detail
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (bibitData == null)
                return;

            MessageBox.Show(
                "Nama Bibit : " + bibitData.nama_bibit +
                "\nKategori : " + bibitData.nama_kategori +
                "\nHarga : Rp " + bibitData.harga.ToString("N0") +
                "\nStok : " + bibitData.stok +
                "\nUmur : " + bibitData.umur_bibit +
                "\n\nDeskripsi :" +
                "\n" + bibitData.deskripsi,
                "Detail Bibit",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void CardBibit_Load(object sender, EventArgs e)
        {

        }
        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void picBibit_Click(object sender, EventArgs e)
        {

        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            Pembeli pembeli = Session.CurrentUser as Pembeli;

            if (pembeli == null)
            {
                MessageBox.Show("Silakan login sebagai pembeli!");
                return;
            }

            KeranjangController controller = new KeranjangController();

            bool berhasil = controller.TambahKeKeranjang(
                pembeli.Id,
                bibitData.id_bibit,
                1
            );

            if (berhasil)
            {
                MessageBox.Show("Berhasil ditambahkan ke keranjang");
            }
        }
    }
}