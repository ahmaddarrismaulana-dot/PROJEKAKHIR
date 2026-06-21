using Bibitku.Controllers;
using BibitKu.Helpers;
using PROJEKAKHIR.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class editdatabiibit : UserControl
    {
        private BibitController _controller = new BibitController();
        private KategoriController _kategoriCtrl = new KategoriController();
        private Bibit _bibitDiedit;
        private byte[] _fotoBaru;

        // Event untuk memberi tahu KelolaBibit bahwa edit selesai
        public event EventHandler EditSelesai;

        public editdatabiibit()
        {
            InitializeComponent();
        }

        // Dipanggil dari KelolaBibit saat tombol Edit diklik
        public void MuatDataBibit(Bibit bibit)
        {
            _bibitDiedit = bibit;
            _fotoBaru = bibit.foto_bibit;

            // Isi form dengan data bibit yang dipilih
            txtNamaBibit.Text = bibit.nama_bibit;
            textUmurBibit.Text = bibit.umur_bibit;
            txtDeskripsi.Text = bibit.deskripsi;
            numHarga.Value = bibit.harga;
            numStok.Value = bibit.stok;

            // Isi foto jika ada
            if (bibit.foto_bibit != null && bibit.foto_bibit.Length > 0)
            {
                using (var ms = new MemoryStream(bibit.foto_bibit))
                    picBibit.Image = Image.FromStream(ms);
            }

            // Load kategori
            LoadKategori(bibit.id_kategori?.id_kategori ?? 0);
        }

        private void LoadKategori(int idKategoriTerpilih)
        {
            try
            {
                var list = _kategoriCtrl.GetAllKategori();
                cmbKategori.DataSource = list;
                cmbKategori.DisplayMember = "nama_kategori";
                cmbKategori.ValueMember = "id_kategori";

                // Pilih kategori sesuai data bibit
                foreach (Kategori k in list)
                {
                    if (k.id_kategori == idKategoriTerpilih)
                    {
                        cmbKategori.SelectedItem = k;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load kategori: " + ex.Message);
            }
        }

        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _fotoBaru = File.ReadAllBytes(ofd.FileName);
                    picBibit.Image = Image.FromFile(ofd.FileName);
                    picBibit.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi
            if (string.IsNullOrWhiteSpace(txtNamaBibit.Text))
            {
                MessageBox.Show("Nama bibit harus diisi!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbKategori.SelectedIndex < 0)
            {
                MessageBox.Show("Pilih kategori!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numHarga.Value <= 0)
            {
                MessageBox.Show("Harga harus lebih dari 0!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Update objek bibit
                _bibitDiedit.nama_bibit = txtNamaBibit.Text;
                _bibitDiedit.umur_bibit = textUmurBibit.Text;
                _bibitDiedit.deskripsi = txtDeskripsi.Text;
                _bibitDiedit.harga = (int)numHarga.Value;
                _bibitDiedit.stok = (int)numStok.Value;
                _bibitDiedit.foto_bibit = _fotoBaru;

                _bibitDiedit.id_kategori = new Kategori
                {
                    id_kategori = Convert.ToInt32(cmbKategori.SelectedValue)
                };

                bool berhasil = _controller.UpdateBibit(_bibitDiedit);

                if (berhasil)
                {
                    MessageBox.Show("Bibit berhasil diupdate!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Beritahu KelolaBibit bahwa edit selesai
                    EditSelesai?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Gagal mengupdate bibit.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            // Kembali ke KelolaBibit tanpa simpan
            EditSelesai?.Invoke(this, EventArgs.Empty);
        }
    }
}